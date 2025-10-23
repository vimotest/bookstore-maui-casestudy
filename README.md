# MAUI Bookstore: A Case Study

Welcome to the MAUI Bookstore! This is an open-source project serving as a practical case study for developing modern .NET MAUI applications. The focus is on a clean, testable, and maintainable architecture.

The project is primarily developed using GitHub Copilot, guided by a clear set of issues and architectural guidelines.

## Goals

* **Architecture:** Strict implementation of the **MVVM pattern**.
* **Testability:** High test coverage (Target: 80%+) for ViewModels.
* **ViewModel Philosophy:** Use of "Presentation-Ready ViewModels." This means the ViewModels follow the Humble Object pattern: they primarily expose primitive types (strings, bools, enums) for data binding, rather than passing complex domain models directly to the View. This makes the View "dumb" and the ViewModels extremely testable (ViMoTest approach).
* **UI:** A classic master-detail navigation (sidebar/main area) with list and form views.

## Tech-Stack

* .NET MAUI
* C#
* MVVM (using `CommunityToolkit.Mvvm`)
* .NET MAUI Dependency Injection
* xUnit (for testing)
* Moq (for mocking)

## Project Structure
```text
.
├── BookStore.App/               # The main MAUI app
│   ├── Views/                   # XAML Views (dumb & thin)
│   ├── ViewModels/              # ViewModels (Presentation-Ready)
│   ├── Services/                # View-services (e.g., navigation)
│   └── MauiProgram.cs           # DI configuration / service registration
├── BookStore.Core/              # Domain layer
│   ├── Models/                  # Domain models (e.g., Book, Author)
│   └── Repositories/            # Repository interfaces (e.g., IBookRepository)
├── BookStore.Infrastructure/    # Infrastructure layer
│   └── Data/                    # Mock or real repository implementations
└── BookStore.Tests/             # Test projects
    └── ViewModelTests/          # Unit tests for ViewModels (xUnit + Moq)
```

## Getting Started

1.  Clone the repository.
2.  Open the `BookStore.sln` in Visual Studio or JetBrains Rider.
3.  Ensure the .NET MAUI workloads are installed.
4.  Select a target (e.g., Android Emulator, Windows Machine) and start the application.

## Development

Development follows the issues in this repository. Please adhere to the `ARCHITECTURE.md` and `COPILOT-INSTRUCTIONS.md` for detailed guidelines.
