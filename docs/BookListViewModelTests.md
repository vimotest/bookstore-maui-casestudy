# BookListViewModel Test Specification

This document specifies the scenario tests for the `BookListViewModel` using ViMoTest. The tests follow the **Given-When-Then** pattern and verify the "Presentation-Ready ViewModel" behavior.

## 1. ViewModel Overview

The `BookListViewModel` manages a list of books displayed in a table/list format. It provides:

### Widgets
- **BookList** (TableView): Displays rows with columns:
  - `Selected` (CheckBox): Row selection state
  - `Preview` (Image): Book cover preview image
  - `Title` (Label): Book title text
  - `Author` (Label): Author name text
  - `ISBN` (Label): ISBN identifier
  - `Price` (Label): Formatted price (e.g., "5.00 €")
  - `Stock` (Label): Stock count (e.g., "x10")
- **Add** (Button): Add new book action
- **Delete** (Button): Delete selected books action

### Commands
- `LoadView`: Loads books from repository and populates the table

---

## 2. Test Scenarios

### 2.1 Loading Books

#### Scenario: Load empty book list
```
Given: no books in repository
When: LoadView is triggered
Then: BookList shows empty table (no rows)
```

#### Scenario: Load single book
```
Given: books in repository
  | isbn      | name          | author           | price | stock |
  | 123-456   | Clean Code    | Robert C. Martin | 35    | 5     |
When: LoadView is triggered
Then: BookList shows
  | Selected | Preview        | Title      | Author           | ISBN    | Price    | Stock |
  | FALSE    | Clean Code.png | Clean Code | Robert C. Martin | 123-456 | 35.00 €  | x5    |
```

#### Scenario: Load two books
```
Given: books in repository
  | isbn      | name   | author            | price | stock |
  | 345-123   | Book1  | Max Mustermann    | 5     | 10    |
  | 555-678   | Book2  | Alice Wonderland  | 7     | 4     |
When: LoadView is triggered
Then: BookList shows
  | Selected | Preview    | Title  | Author           | ISBN    | Price   | Stock |
  | FALSE    | Book1.png  | Book1  | Max Mustermann   | 345-123 | 5.00 €  | x10   |
  | FALSE    | Book2.png  | Book2  | Alice Wonderland | 555-678 | 7.00 €  | x4    |
```

#### Scenario: Load many books (pagination edge case)
```
Given: 10 books in repository with sequential names (Book1..Book10)
When: LoadView is triggered
Then: BookList shows 10 rows with correct titles
```

---

### 2.2 Selection Behavior

#### Scenario: Select a single row
```
Given: books in repository
  | isbn    | name   | author | price | stock |
  | 111-111 | BookA  | AuthA  | 10    | 1     |
  | 222-222 | BookB  | AuthB  | 20    | 2     |
When: LoadView is triggered
And: Selected checkbox at row 0 is checked
Then: BookList row 0 shows Selected = TRUE
And: BookList row 1 shows Selected = FALSE
```

#### Scenario: Select multiple rows
```
Given: books in repository
  | isbn    | name   | author | price | stock |
  | 111-111 | BookA  | AuthA  | 10    | 1     |
  | 222-222 | BookB  | AuthB  | 20    | 2     |
  | 333-333 | BookC  | AuthC  | 30    | 3     |
When: LoadView is triggered
And: Selected checkbox at row 0 is checked
And: Selected checkbox at row 2 is checked
Then: BookList row 0 shows Selected = TRUE
And: BookList row 1 shows Selected = FALSE
And: BookList row 2 shows Selected = TRUE
```

#### Scenario: Deselect a row
```
Given: books in repository
  | isbn    | name   | author | price | stock |
  | 111-111 | BookA  | AuthA  | 10    | 1     |
When: LoadView is triggered
And: Selected checkbox at row 0 is checked
And: Selected checkbox at row 0 is unchecked
Then: BookList row 0 shows Selected = FALSE
```

---

### 2.3 Price Formatting

#### Scenario: Format whole number price
```
Given: books in repository
  | isbn    | name  | author | price | stock |
  | 111-111 | BookA | AuthA  | 10    | 1     |
When: LoadView is triggered
Then: BookList row 0 shows Price = "10.00 €"
```

#### Scenario: Format decimal price
```
Given: books in repository
  | isbn    | name  | author | price | stock |
  | 111-111 | BookA | AuthA  | 9.99  | 1     |
When: LoadView is triggered
Then: BookList row 0 shows Price = "9.99 €"
```

#### Scenario: Format zero price (free book)
```
Given: books in repository
  | isbn    | name     | author | price | stock |
  | 111-111 | FreeBook | AuthA  | 0     | 1     |
When: LoadView is triggered
Then: BookList row 0 shows Price = "0.00 €"
```

---

### 2.4 Stock Display

#### Scenario: Display stock count with prefix
```
Given: books in repository
  | isbn    | name  | author | price | stock |
  | 111-111 | BookA | AuthA  | 10    | 42    |
When: LoadView is triggered
Then: BookList row 0 shows Stock = "x42"
```

#### Scenario: Display zero stock
```
Given: books in repository
  | isbn    | name        | author | price | stock |
  | 111-111 | OutOfStock  | AuthA  | 10    | 0     |
When: LoadView is triggered
Then: BookList row 0 shows Stock = "x0"
```

---

### 2.5 Preview Image

#### Scenario: Generate preview image name from title
```
Given: books in repository
  | isbn    | name          | author | price | stock |
  | 111-111 | My Great Book | AuthA  | 10    | 5     |
When: LoadView is triggered
Then: BookList row 0 shows Preview = "My Great Book.png"
```

---

### 2.6 Add Button Behavior

#### Scenario: Add button is visible and enabled by default
```
Given: no preconditions
When: LoadView is triggered
Then: Add button is visible
And: Add button is enabled
```

#### Scenario: Click Add button (placeholder)
```
Given: books in repository (empty)
When: LoadView is triggered
And: Add button is clicked
Then: (TODO: define expected behavior - open add dialog, navigate to add view, etc.)
```

---

### 2.7 Delete Button Behavior

#### Scenario: Delete button is visible and enabled by default
```
Given: no preconditions
When: LoadView is triggered
Then: Delete button is visible
And: Delete button is enabled
```

#### Scenario: Click Delete with no selection (placeholder)
```
Given: books in repository
  | isbn    | name  | author | price | stock |
  | 111-111 | BookA | AuthA  | 10    | 1     |
When: LoadView is triggered
And: Delete button is clicked
Then: (TODO: define expected behavior - show warning, do nothing, etc.)
```

#### Scenario: Click Delete with selection (placeholder)
```
Given: books in repository
  | isbn    | name  | author | price | stock |
  | 111-111 | BookA | AuthA  | 10    | 1     |
  | 222-222 | BookB | AuthB  | 20    | 2     |
When: LoadView is triggered
And: Selected checkbox at row 0 is checked
And: Delete button is clicked
Then: (TODO: define expected behavior - remove selected, refresh list, etc.)
```

---

### 2.8 Error Handling

#### Scenario: Repository throws exception during load
```
Given: repository throws error on GetAllBooksAsync
When: LoadView is triggered
Then: (TODO: define expected behavior - show error message, empty list, etc.)
```

---

### 2.9 Reload/Refresh Behavior

#### Scenario: Reload replaces existing data
```
Given: books in repository
  | isbn    | name  | author | price | stock |
  | 111-111 | BookA | AuthA  | 10    | 1     |
When: LoadView is triggered
And: repository now contains different books
  | isbn    | name  | author | price | stock |
  | 999-999 | NewBook | NewAuth | 50  | 10    |
And: LoadView is triggered again
Then: BookList shows only new data
  | Selected | Preview      | Title   | Author  | ISBN    | Price   | Stock |
  | FALSE    | NewBook.png  | NewBook | NewAuth | 999-999 | 50.00 € | x10   |
```

---

## 3. Existing ViMoTest Test (Reference)

The following test is already specified in ViMoTest (`BookStoreViMoTests.tests.mps`):

### Load two books
- **Given**: Two books in repository (Book1, Book2)
- **When**: LoadView command is invoked
- **Then**: BookList table shows two rows with:
  - Row 0: Selected=FALSE, Preview=Book1.png, Title=Book1, Author=Max Mustermann, ISBN=12345678, Price=5.00 €, Stock=x10
  - Row 1: Selected=FALSE, Preview=Book2.png, Title=Book2, Author=Alice Wonderland, ISBN=555-678, Price=7.00 €, Stock=x4

---

## 4. Priority for Implementation

### High Priority (Core Functionality)
1. Load empty book list
2. Load single book
3. Load two books ✅ (already exists)
4. Select a single row
5. Deselect a row

### Medium Priority (Data Formatting)
6. Format whole number price
7. Display stock count with prefix
8. Generate preview image name from title

### Low Priority (Edge Cases & Placeholders)
9. Load many books
10. Select multiple rows
11. Format zero price
12. Display zero stock
13. Add/Delete button behaviors (pending implementation)
14. Error handling
15. Reload behavior

---

## 5. Test Data Recommendations

For consistent testing, use these standard test values:

| Field   | Example Values |
|---------|----------------|
| ISBN    | `123-456`, `111-111`, `999-999` |
| Title   | `Book1`, `Clean Code`, `Test Book` |
| Author  | `Max Mustermann`, `Alice Wonderland`, `Robert C. Martin` |
| Price   | `5`, `9.99`, `35`, `0` |
| Stock   | `0`, `1`, `5`, `10`, `42` |

---

## 6. Notes on Presentation-Ready ViewModel

Following the project's architecture rules:

- **No domain models in assertions**: Tests should verify primitive types (`string`, `bool`) only
- **All formatting in ViewModel**: Price formatting (`X.XX €`), stock prefix (`xN`), image naming (`{Title}.png`)
- **Selection state is primitive**: `bool` for `IsSelected`, not complex selection objects
