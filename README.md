# IT Elective Final Exam — BSIT 31E3

Base ASP.NET Core MVC structure for the BSIT 31E3 class portfolio.

## Add a student's portfolio

1. Create a controller in `Controllers/`.
2. Decorate the controller with `[Classmate("Student Full Name")]`.
3. Add an `Index()` action that returns the student's `ClassmateProfile`.
4. Create `Views/<ControllerName>/Index.cshtml`.
5. Use the existing `Views/Shared/_PortfolioProfile.cshtml` partial.
6. Put the student's profile photo under `wwwroot/images/`.
7. Put the student's actual GitHub profile URL in `ClassmateProfile.GitHubUrl`.
8. Put each repository URL in `ProjectItem.RepoUrl`.

The Home page automatically discovers controllers decorated with `[Classmate]`.

## Run

From the project directory:

```bash
dotnet restore
dotnet run
```

The project targets .NET 10 (`net10.0`).
