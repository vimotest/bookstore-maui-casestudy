## UI Layout and Design

The main GUI follows a classic three-pane, master-detail layout, as shown in the mockup below. This design supports our "Humble View" approach, where each pane can be backed by a dedicated, simple ViewModel.

![Main UI Mockup: Tree navigation on the left (Books, Authors), a master list of books in the center, and a detail form for the selected book on the right.](docs/images/mockup_bookstore.jpg)

### Layout Breakdown:

* **Pane 1 (Left):** A `TreeView` or `CollectionView` for global navigation (e.g., switching between the "Books" module and the "Authors" module).
* **Pane 2 (Middle - Master):** A `CollectionView` (`BookListView`) displaying the list of all books. Clicking an item here updates the detail pane.
* **Pane 3 (Right - Detail):** A `VerticalStackLayout` with `Entry`, `Label`, and `Button` controls (`BookDetailView`) bound to the selected book's properties.
