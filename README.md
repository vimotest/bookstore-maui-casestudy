# MAUI Bookstore: Eine Case Study

Willkommen beim MAUI Bookstore! Dies ist ein Open-Source-Projekt, das als praxisnahe Fallstudie für die Entwicklung moderner .NET MAUI-Anwendungen dient. Der Fokus liegt auf einer sauberen, testbaren und wartbaren Architektur.

Das Projekt wird primär mithilfe von GitHub Copilot entwickelt, geleitet durch einen klaren Satz von Issues und Architektur-Richtlinien.

## Ziele

* **Architektur:** Strikte Umsetzung des **MVVM-Musters**. Siehe `doc/architecture.md`
* **Testbarkeit:** Hohe Testabdeckung (Ziel: 80%+) für ViewModels.
* **ViewModel-Philosophie:** Einsatz von "Presentation-Ready ViewModels". Das bedeutet, die ViewModels folgen dem Humble-Object-Pattern: Sie exponieren primär primitive Typen (Strings, Bools, Enums) für das Data Binding, anstatt komplexe Domain-Modelle direkt an die View durchzureichen. Dies macht die View "dumm" und die ViewModels extrem testbar (ViMoTest-Ansatz).
* **UI:** Eine klassische Master-Detail-Navigation (Seitenleiste/Hauptbereich) mit Listen- und Formular-Ansichten.

## Tech-Stack

* .NET MAUI
* C#
* MVVM (mit `CommunityToolkit.Mvvm`)
* .NET MAUI Dependency Injection
* xUnit (für Tests)
* Moq (für Mocking)

## Projektstruktur