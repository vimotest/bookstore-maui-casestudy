## Context: BookStore.Core (Domain Layer)

This is the center of the business logic.

* **Models (in `Models/`):**
    * MUST be pure POCOs (e.g., `Book`, `Author`).
    * MUST NOT contain any UI logic or infrastructure references (like `Microsoft.Maui`).
    * Constructors SHOULD include `null` checks for parameters.
* **Interfaces (in `Repositories/`):**
    * Defines the contracts (e.g., `IBookRepository`).
    * MUST be `async` (Task-based) for all I/O operations.