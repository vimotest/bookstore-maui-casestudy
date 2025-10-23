## DevelopmentPlan.md

```markdown
# Entwicklungsplan

Dieser Plan gliedert die Entwicklung in logische Phasen. Die Issues sind entsprechend priorisiert (P1 - P3).

## Phase 1: Setup & Kernstruktur (P1)

*Ziel: Ein lauffähiges Grundgerüst mit Navigation und Datenfluss.*

1.  **Projekt-Setup:** Erstellung der Solution und der vier Projekte (`.App`, `.Core`, `.Infrastructure`, `.Tests`).
2.  **DI-Setup:** Konfiguration des `MauiProgram.cs` für Dependency Injection.
3.  **Core-Definition:** Definition der Domain-Modelle (`Book`, `Author`) und des `IBookRepository`-Interface.
4.  **Mock-Implementierung:** Erstellung des `MockBookRepository` und Registrierung im DI-Container.
5.  **Navigation:** Aufbau der `AppShell.xaml` (Master-Detail-Layout) mit einem Flyout-Menü (z.B. Link zur "Bücherliste").
6.  **Tooling:** Integration von `CommunityToolkit.Mvvm`.

## Phase 2: Feature-Implementierung (P1 - P2)

*Ziel: Implementierung der Kern-Features (Liste und Detailansicht) nach dem "Presentation-Ready" VM-Prinzip.*

1.  **Bücherliste (Master):**
    * Erstellung `BookListViewModel`.
    * Implementierung `LoadBooksCommand`, das `IBookRepository` nutzt.
    * Erstellung `BookListView` (XAML) mit einer `CollectionView` (Tabelle/Liste).
    * *WICHTIG:* Das VM exponiert eine Liste von `BookListItemViewModel` (ein weiteres Presentation-Ready VM), nicht `Book`-Objekten.
2.  **Bücherdetails (Detail):**
    * Erstellung `BookDetailViewModel` (Presentation-Ready, mit primitiven Properties).
    * Implementierung der Navigation von Liste zu Detail (via `GoToAsync` und `IQueryAttributable`).
    * Implementierung von Lade- und Speicherlogik (`SaveCommand`).
    * Erstellung `BookDetailView` (XAML) mit einem klassischen Formular (Labels, Entries, CheckBox).

## Phase 3: Testen & Stabilisierung (P2 - P3)

*Ziel: Sicherstellung der Qualität und Erreichung der Testabdeckung.*

1.  **Unit-Tests (Liste):** Implementierung von xUnit-Tests für `BookListViewModel` (AAA-Pattern, Moq).
2.  **Unit-Tests (Detail):** Implementierung von xUnit-Tests für `BookDetailViewModel`.
3.  **Validierung:** Hinzufügen von einfacher Validierungslogik im `BookDetailViewModel`.
4.  **Test-Coverage:** Analyse der Code Coverage und Hinzufügen fehlender Tests (Ziel: 80%).

## Phase 4: Polish & CI (P3)

*Ziel: Fertigstellung der Case Study.*

1.  **Styling:** Einfaches Styling der Anwendung (Farben, Schriftgrößen) in `Styles.xaml`.
2.  **CI/CD:** Setup einer einfachen GitHub Action, die das Projekt baut und die Tests bei jedem Push ausführt.
3.  **Dokumentation:** Überprüfung und Finalisierung der `README.md`.