# Tarlac City Scholarship Application (prototype)

A Windows desktop prototype for the City Government of Tarlac scholarship
application workflow. Frontend only: navigation, forms, and demo data.
No database and no backend. Everything is in-memory and disappears when
the app closes.

## Tech

- C# / .NET 10, Windows Forms
- Visual Studio 2026 (or any IDE with the .NET 10 SDK)

## How to run

Open `scholarship Application.slnx` in Visual Studio and press F5, or:

```
dotnet build "scholarship Application.csproj"
dotnet run
```

## Logging in (prototype only)

- Type any username to enter the student dashboard.
- A username starting with `admin` (any password) enters the admin dashboard.

## What works

- Login screen with role routing
- Student dashboard: overview, applications (with optional 2x2 photo), my applications
- Admin dashboard: overview, application review with status decisions
  (Approve / Under Review / Reject), activity log, creating new application
  records including a photo
- Shared demo data lives in `SampleData.cs` for the current session only

## What is left (ideas)

- Persist data (JSON file or database)
- Real login/auth
- Eligibility evaluation rules
- Reporting and export

## Project layout

- `Forms/` - windows: login, dashboards, admin application dialog
  (each has a `.Designer.cs` so it opens in the VS Forms Designer)
- `Controls/` - screens hosted inside the dashboards, shared styling (`Ui.cs`)
- `Models/` - the `ScholarshipApplication` record used by all screens
- `SampleData.cs` - demo rows shown at startup
