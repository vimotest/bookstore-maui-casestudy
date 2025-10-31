## Context: BookStore.App (MAUI Presentation Layer)

Strict adherence to the global `.github/copilot-instructions.md` is critical here.

**Focus: Presentation-Ready ViewModels (Rule 2)**
* ViewModels (in `ViewModels/`) MUST inherit from `ObservableObject` and use `[ObservableProperty]` / `[RelayCommand]`.
* ViewModels MUST NOT expose domain models (e.g., `Book`). Expose only primitive types (`string`, `bool`, `int`, etc.).
* Dependencies (e.g., `IBookRepository`) MUST be received via constructor injection.

**Focus: Views**
* Views (in `Views/`) MUST be "dumb".
* Code-behind (`.xaml.cs`) MUST be minimal (constructor only).
* Bindings MUST target the primitive properties of the ViewModel (e.g., `{Binding Title}`).