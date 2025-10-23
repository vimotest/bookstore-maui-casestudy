The 20 Perfect Issues (Prioritized) Here are 20 issues designed to guide Copilot (or a junior developer) precisely through the process.

Phase 1: Setup & Core Structure (P1 - Critical)

Issue #1 (P1): Setup: Create project structure

Title: Setup: Create Solution and four projects

Description: Create a new .NET MAUI solution (BookStore.sln) with the following four projects:

BookStore.App (.NET MAUI App)

BookStore.Core (.NET Standard Class Library)

BookStore.Infrastructure (.NET Standard Class Library)

BookStore.Tests (xUnit Test Project)

Acceptance Criteria: The solution builds without errors. BookStore.App references Core and Infrastructure. BookStore.Tests references all three other projects.

Issue #2 (P1): Setup: Integrate CommunityToolkit.Mvvm

Title: Setup: Add NuGet package CommunityToolkit.Mvvm

Description: Add the CommunityToolkit.Mvvm NuGet package to the BookStore.App project. This will be the basis for our MVVM implementation (ObservableObject, RelayCommand).

Acceptance Criteria: The package is installed in version 8.x (or newer).

Issue #3 (P1): Core: Define domain models

Title: Core: Define Book and Author domain models

Description: In the BookStore.Core project (folder Models), create the POCO classes Book and Author.

Author: Guid Id, string FirstName, string LastName

Book: Guid Id, string Title, string Isbn, Guid AuthorId, int Stock

Acceptance Criteria: The classes are implemented as public record or public class.

Issue #4 (P1): Core: Define repository interface

Title: Core: Define IBookRepository interface

Description: In the BookStore.Core project (folder Repositories), create the IBookRepository interface.

Methods:

Task<IEnumerable<Book>> GetBooksAsync();

Task<Book> GetBookByIdAsync(Guid id);

Task UpdateBookAsync(Book book);

Acceptance Criteria: The interface is public and contains the defined asynchronous methods.

Issue #5 (P1): Infra: Implement mock repository

Title: Infrastructure: Implement MockBookRepository

Description: In the BookStore.Infrastructure project, create a MockBookRepository that implements IBookRepository. Use a private static List<Book> for in-memory data. Implement the methods (GetBooksAsync, GetBookByIdAsync, UpdateBookAsync).

Acceptance Criteria: The class implements the interface correctly and simulates asynchronous behavior (e.g., using Task.FromResult).

Issue #6 (P1): Setup: Configure Dependency Injection

Title: Setup: Register services and ViewModels in MauiProgram.cs

Description: Configure Dependency Injection in MauiProgram.cs.

Register MockBookRepository as a singleton: builder.Services.AddSingleton<IBookRepository, MockBookRepository>();

Add placeholder registrations for upcoming Views/ViewModels (e.g., AddTransient<BookListView> and AddTransient<BookListViewModel>).

Acceptance Criteria: IBookRepository is registered in the DI container.

Issue #7 (P1): UI: Set up Shell Navigation (Master-Detail)

Title: UI: Configure AppShell.xaml as a master-detail layout

Description: Modify AppShell.xaml and AppShell.xaml.cs to create a flyout menu (sidebar).

Create a FlyoutItem with the title "Books".

This FlyoutItem should point to a BookListView.

Register the route for the (yet-to-be-created) BookDetailPage.

Acceptance Criteria: The app starts with a flyout menu. Clicking "Books" navigates (or should navigate) to the BookListView.

Phase 2: Feature Implementation (P1-P2)

Issue #8 (P1): Feature: Create BookListViewModel

Title: Feature: Create BookListViewModel (Presentation-Ready)

Description: Create the BookListViewModel in the BookStore.App project.

It must inherit from ObservableObject.

Inject IBookRepository via the constructor.

IMPORTANT: Create a sub-ViewModel named BookListItemViewModel (also ObservableObject) with primitive properties: Guid Id, string Title, string AuthorName, bool IsInStock.

The BookListViewModel should expose an ObservableCollection<BookListItemViewModel> Books.

Acceptance Criteria: The VM does not expose Book objects, but rather BookListItemViewModel objects.

Issue #9 (P1): Feature: Loading logic for BookListViewModel

Title: Feature: Implement LoadBooksCommand in BookListViewModel

Description: Implement a [RelayCommand] named LoadBooksAsync in the BookListViewModel.

This command should call _bookRepository.GetBooksAsync().

It should transform (map) the returned Book objects into BookListItemViewModel objects.

The transformed objects should populate the Books collection.

The command should be called when the View appears (e.g., in the constructor or via an IViewLifecycle event).

Acceptance Criteria: The logic loads books and converts them into Presentation-Ready ViewModels.

Issue #10 (P1): UI: Create BookListView (Master)

Title: UI: Create BookListView.xaml (Master View)

Description: Create the BookListView.xaml (View) and link it to the BookListViewModel (e.g., via x:DataType).

Use a CollectionView (or ListView) for display.

Bind the ItemsSource to {Binding Books}.

The ItemTemplate should display the properties of the BookListItemViewModel (e.g., Title, AuthorName).

Ensure the View is registered in MauiProgram.cs.

Acceptance Criteria: The app starts and displays the list of mock books.

Issue #11 (P2): Test: Unit tests for BookListViewModel

Title: Test: Write unit tests for BookListViewModel (AAA Pattern)

Description: In the BookStore.Tests project, create tests for the BookListViewModel.

Use Moq to mock IBookRepository.

Arrange: Create the mock and the ViewModel.

Act: Call the LoadBooksAsyncCommand.

Assert: Check if the Books collection is populated and if the mapping (transformation) was correct (e.g., Assert.Equal("Test Author", vm.Books.First().AuthorName)).

Acceptance Criteria: The tests pass successfully.

Issue #12 (P2): Feature: Create BookDetailViewModel (Presentation-Ready)

Title: Feature: Create BookDetailViewModel (Presentation-Ready)

Description: Create the BookDetailViewModel.

It must inherit from ObservableObject and implement IQueryAttributable.

Inject IBookRepository.

IMPORTANT (Presentation-Ready): Expose only primitive properties: [ObservableProperty] string title;, [ObservableProperty] string isbn;, [ObservableProperty] string authorName;, [ObservableProperty] bool isInStock;.

Not public Book CurrentBook { get; set; }!

Acceptance Criteria: The ViewModel is "Presentation-Ready" and contains no complex models.

Issue #13 (P2): Feature: Load/Save logic for BookDetailViewModel

Title: Feature: Implement load and save logic in BookDetailViewModel

Description:

Loading: Implement ApplyQueryAttributes to receive the bookId from navigation. Create a LoadBookAsync(Guid id) method that loads the Book object and maps its values to the primitive properties (Title, Isbn, etc.).

Saving: Create a [RelayCommand] named SaveAsync. This command should reconstruct a (simplified) Book object from the ViewModel properties and call _bookRepository.UpdateBookAsync().

Acceptance Criteria: Data is loaded (mapped) and can be saved (reverse-mapped).

Issue #14 (P2): UI: Create BookDetailView (Detail)

Title: UI: Create BookDetailView.xaml (Detail View)

Description: Create the BookDetailView.xaml (View).

Use a VerticalStackLayout or Grid to build a classic form.

Use Label and Entry (for Title, Isbn, AuthorName) and a CheckBox (for IsInStock).

Bind these controls directly to the primitive properties of the BookDetailViewModel.

Add a "Save" button that is bound to the SaveCommand.

Acceptance Criteria: The View is a "dumb form" that only binds to primitive types.

Issue #15 (P2): Feature: Implement Navigation (List -> Detail)

Title: Feature: Implement navigation from BookListView to BookDetailView

Description: Implement the navigation for when a user clicks on a book in the BookListView.

In BookListViewModel: Create a [RelayCommand] GoToDetailsAsync(BookListItemViewModel bookItem).

This command should call Shell.Current.GoToAsync($"BookDetailPage?id={bookItem.Id}").

In BookListView.xaml: Make the CollectionView items clickable (e.g., via TapGestureRecognizer or SelectionChanged) and bind them to this command.

Acceptance Criteria: A click on a book in the list opens the detail page with that book's data.

Phase 3: Testing & Stabilization (P2-P3)

Issue #16 (P2): Test: Unit tests for BookDetailViewModel

Title: Test: Write unit tests for BookDetailViewModel (AAA Pattern)

Description: Create tests for the BookDetailViewModel.

Test 1 (Loading): Mock IBookRepository.GetBookByIdAsync. Call ApplyQueryAttributes and the loading logic. Assert that the primitive properties (Title, IsInStock) were set (mapped) correctly.

Test 2 (Saving): Set properties in the VM. Call the SaveCommand. Verify (Mock.Verify) that UpdateBookAsync was called with a correctly reconstructed Book object.

Acceptance Criteria: The core logic of the detail ViewModel is covered by unit tests.

Issue #17 (P3): Feature: Simple validation in ViewModel

Title: Feature: Implement simple validation in BookDetailViewModel

Description: Use CommunityToolkit.Mvvm.ComponentModel.ObservableValidator to add validation.

Have the BookDetailViewModel inherit from ObservableValidator.

Add [Required] and [MinLength(3)] attributes to the presentation properties (e.g., Title).

Display validation errors in BookDetailView.xaml (e.g., below the Entry fields).

The SaveCommand should only be active if there are no errors (CanExecute).

Acceptance Criteria: The Save button is disabled if the title is empty.

Issue #18 (P3): Test: Increase test coverage to 80%

Title: Test: Increase ViewModel test coverage to 80%

Description: Run a code coverage analysis tool (e.g., in VS Enterprise or Rider). Identify gaps in the ViewModelTests (e.g., edge cases, error cases, command CanExecute logic) and add the missing tests.

Acceptance Criteria: The code coverage for the BookStore.App/ViewModels layer is at 80% or higher.

Phase 4: Polish & CI (P3)

Issue #19 (P3): UI: Define base styling

Title: UI: Define global base styling in Styles.xaml

Description: Adjust Resources/Styles/Styles.xaml to give the app a clean, consistent look.

Define global styles for Button, Label, Entry.

Define a simple color scheme (primary color, background color) in Colors.xaml.

No "fancy" effects, just a clean, professional layout.

Acceptance Criteria: The app looks consistent and tidy.
