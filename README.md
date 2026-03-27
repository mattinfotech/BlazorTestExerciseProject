# Blazor User Form Exercise

This repository contains a minimal Blazor application for the reusable form component exercise.

## What is included

- `Components/UserForm.razor` - reusable form component
- `Pages/Home.razor` - sample parent page demonstrating usage
- `Models/UserModel.cs` - shared model with `DataAnnotations`
- `wwwroot/app.css` - basic styling for layout and usability
- `lib/bootstrap/dist/css/bootstrap.min.css` - is utilized as the primary framework to ensure consistent, responsive, and modern user interface styling.

## Requirements

- .NET 10 SDK

## How to build and run

```bash
# restore packages
dotnet restore

# run the application
dotnet run
```

Then open the local URL shown in the terminal and navigate to home page:

## Notes and assumptions

- The reusable component accepts a model from the parent and raises submission through `EventCallback<UserModel>`.
- Validation is handled using `EditForm`, `DataAnnotationsValidator`, `ValidationSummary`, and field-level `ValidationMessage` components.
- Business logic stays in the parent page. The sample parent page handles submitted data, normalizes values, shows confirmation feedback, and resets the form.
- The implementation intentionally stays simple and avoids external dependencies.


