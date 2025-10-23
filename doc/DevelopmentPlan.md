# Development Plan

This plan breaks down the development into logical phases. The issues are prioritized accordingly (P1 - P3).

## Phase 1: Setup & Core Structure (P1)

*Goal: A runnable skeleton application with navigation and data flow.*

1.  **Project Setup:** Creation of the solution and the four projects (`.App`, `.Core`, `.Infrastructure`, `.Tests`).
2.  **DI Setup:** Configuration of `MauiProgram.cs` for Dependency Injection.
3.  **Core Definition:** Definition of the domain models (`Book`, `Author`) and the `IBookRepository` interface.
4.  **Mock Implementation:** Creation of the `MockBookRepository` and its registration in the DI container.
5.  **Navigation:** Setup of `AppShell.xaml` (Master-Detail layout) with a flyout menu (e.g., link to "Book List").
6.  **Tooling:** Integration of `CommunityToolkit.Mvvm`.

## Phase 2: Feature Implementation (P1 - P2)

*Goal: Implementation of core features (List and Detail view) according to the "Presentation-Ready" VM principle.*

1.  **Book List (Master):**
    * Create `BookListViewModel`.
    * Implement `LoadBooksCommand` that uses `IBookRepository`.
    * Create `BookListView` (XAML) with a `CollectionView` (table/list).
    * *IMPORTANT:* The VM exposes a list of `BookListItemViewModel` (another Presentation-Ready VM), not `Book` objects.
2.  **Book Details (Detail):**
    * Create `BookDetailViewModel` (Presentation-Ready, with primitive properties).
    * Implement navigation from list to detail (via `GoToAsync` and `IQueryAttributable`).
    * Implement load and save logic (`SaveCommand`).
    * Create `BookDetailView` (XAML) with a classic form (Labels, Entries, CheckBox).

## Phase 3: Testing & Stabilization (P2 - P3)

*Goal: Ensuring quality and achieving test coverage.*

1.  **Unit Tests (List):** Implement xUnit tests for `BookListViewModel` (AAA Pattern, Moq).
2.  **Unit Tests (Detail):** Implement xUnit tests for `BookDetailViewModel`.
3.  **Validation:** Add simple validation logic in the `BookDetailViewModel`.
4.  **Test Coverage:** Analyze code coverage and add missing tests (Goal: 80%).

## Phase 4: Polish & CI (P3)

*Goal: Finalizing the case study.*

1.  **Styling:** Simple styling of the application (colors, font sizes) in `Styles.xaml`.
2.  **CI/CD:** Setup of a simple GitHub Action that builds the project and runs tests on every push.
3.  **Documentation:** Review and finalize the `README.md`.
