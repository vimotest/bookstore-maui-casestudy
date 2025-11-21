## Context: BookStore.Tests (Test Layer)

Strict adherence to global testing rules (Rule 3).

* **Frameworks:** xUnit and Moq.
* **Pattern:** MUST follow the **AAA Pattern (Arrange, Act, Assert)**.
* **ViewModel Tests:**
    * MUST mock dependencies (e.g., `IBookRepository`) using `Moq`.
    * MUST assert the "Presentation-Ready" properties of the ViewModel (e.g., `Assert.Equal("In Stock", vm.AvailabilityText)`), NOT the models.
* **Test Naming:** `MethodName_Scenario_ExpectedBehavior`.