# Instructions for GitHub Copilot

Hello Copilot! Please follow these rules strictly during the development of the MAUI Bookstore project.

## 1. Architecture: MVVM

* **Strict Separation:** Code-behind (`.xaml.cs`) in Views must be minimal. All logic, state management, or data manipulation belongs in a ViewModel.
* **No View References:** ViewModels must **never** contain references to UI elements (e.g., `Button`, `Label`) or MAUI-specific View namespaces (like `Microsoft.Maui.Controls`).
* **File Structure:** Views belong in the `Views/` folder, ViewModels in the `ViewModels/` folder.

## 2. The "Presentation-Ready ViewModel" Rule (IMPORTANT!)

This is the most important rule of the project.

* **No Domain Models in Views:** ViewModels must **NOT** expose complex domain models (e.g., the `Book` object) directly to the View via data binding.
* **Primitive Types Only:** ViewModels must transform data from domain models into simple, "Presentation-Ready" properties. These properties should **only** be primitive types: `string`, `int`, `bool`, `Enum`, or `Color`.
* **Example:**
    * **BAD:** `public Book CurrentBook { get; set; }` (Binding: `{Binding CurrentBook.Title}`)
    * **GOOD:** `public string Title { get; set; }`, `public string AuthorName { get; set; }`, `public string ISBN { get; set; }`, `public bool IsInStock { get; set; }` (Binding: `{Binding Title}`)

## 3. Testing (AAA Pattern)

* **Mandatory Testing:** All public methods and commands in ViewModels must be unit-tested.
* **Pattern:** Use the **AAA Pattern (Arrange, Act, Assert)** in a clear, structured way.
* **Tools:** Use `xUnit` as the testing framework and `Moq` for mocking dependencies (e.g., `IBookRepository`).
* **Goal:** 80% code coverage for the ViewModel layer.

## 4. CommunityToolkit.Mvvm

* **Standard:** Use `CommunityToolkit.Mvvm` for the MVVM implementation.
* **Attributes:** Use `[ObservableProperty]` for INotifyPropertyChanged implementations.
* **Commands:** Use `[RelayCommand]` for `ICommand` implementations.

## 5. Dependency Injection (DI)

* **Constructor Injection:** All dependencies (services, repositories) must be injected into ViewModels via the constructor.
* **Registration:** All services and ViewModels must be registered in `MauiProgram.cs` (e.g., `builder.Services.AddTransient<BookDetailViewModel>()`).

## 6. Code Style

* **Async/Await:** Consistently use `async/await` for all I/O operations (e.g., loading from the repository). Commands should return a `Task` (e.g., `[RelayCommand] private async Task LoadBooksAsync()`).
* **Readability:** Write clean, readable C# code.