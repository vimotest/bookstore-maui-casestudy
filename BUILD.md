# Building the BookStore Solution

This document explains how to build the BookStore MAUI case study solution.

## Prerequisites

- .NET 9.0 SDK or later
- .NET MAUI workload (required for full MAUI app functionality)

## Installing the MAUI Workload

To build and run the full MAUI application, you need to install the MAUI workload:

```bash
dotnet workload install maui
```

## Building Without MAUI Workload (Fallback Mode)

If you're in an environment where the MAUI workload cannot be installed (e.g., CI/CD pipelines, headless build servers), you can build the solution in fallback mode. In this mode, the BookStore.App project targets `net9.0` instead of the MAUI-specific target frameworks.

To build in fallback mode:

```bash
DotNetBuildFromSource=true dotnet restore
DotNetBuildFromSource=true dotnet build
DotNetBuildFromSource=true dotnet test
```

On Windows (PowerShell):
```powershell
$env:DotNetBuildFromSource="true"
dotnet restore
dotnet build
dotnet test
```

On Windows (Command Prompt):
```cmd
set DotNetBuildFromSource=true
dotnet restore
dotnet build
dotnet test
```

## Building With MAUI Workload (Full Mode)

Once the MAUI workload is installed, you can build the solution normally:

```bash
dotnet restore
dotnet build
dotnet test
```

## Project Structure

The solution consists of four projects:

1. **BookStore.Core** (.NET Standard 2.1 Class Library)
   - Contains domain models and repository interfaces
   - Platform-independent business logic

2. **BookStore.Infrastructure** (.NET Standard 2.1 Class Library)
   - Contains implementations of repository interfaces
   - Currently uses mock data; will support real data sources later

3. **BookStore.App** (.NET MAUI App)
   - The main MAUI application with UI
   - Contains Views, ViewModels, and application configuration
   - References Core and Infrastructure projects

4. **BookStore.Tests** (xUnit Test Project)
   - Unit tests for ViewModels and business logic
   - References all three other projects
   - Uses xUnit and Moq for testing

## Project References

- **BookStore.App** → BookStore.Core, BookStore.Infrastructure
- **BookStore.Tests** → BookStore.App, BookStore.Core, BookStore.Infrastructure

## Common Build Commands

```bash
# Restore NuGet packages
dotnet restore

# Build the solution
dotnet build

# Build in Release configuration
dotnet build -c Release

# Run tests
dotnet test

# Run tests with detailed output
dotnet test -v detailed

# Clean build artifacts
dotnet clean
```

## Troubleshooting

### Error: "To build this project, the following workloads must be installed: maui-android"

This error occurs when trying to build the MAUI app without the MAUI workload installed. Either:
1. Install the MAUI workload with `dotnet workload install maui`, or
2. Build in fallback mode using the `DotNetBuildFromSource=true` environment variable

### Error: "Project cannot be added due to incompatible targeted frameworks"

This is expected when the MAUI workload is not installed, as the App project targets MAUI-specific frameworks. Use the fallback mode for building and testing in such environments.
