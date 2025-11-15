## Context: BookStore.Infrastructure (Infrastructure Layer)

* Focus is the *implementation* of interfaces from `BookStore.Core`.
* Implementations (e.g., `BookRepositoryMock`) MUST use `async/await` correctly (e.g., `Task.FromResult` for mocks).
* May reference `BookStore.Core`, but **NEVER** `BookStore.App`.