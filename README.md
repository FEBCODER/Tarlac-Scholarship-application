# Tarlac City Scholarship Application (prototype)

A Windows desktop application for the City Government of Tarlac scholarship
application workflow. WinForms frontend with a SQL Server LocalDB database
(real login accounts, persistent applications and photos). Demo accounts and
sample applications are seeded automatically on first run.

## Tech

- C# / .NET 10, Windows Forms
- Microsoft.Data.SqlClient against SQL Server LocalDB ((localdb)\MSSQLLocalDB)
- Database: `TarlacScholarship` (created automatically on first start)

## How to run

Open `scholarship Application.slnx` in Visual Studio and press F5, or:

```
dotnet build "scholarship Application.csproj"
dotnet run
```

SQL Server LocalDB must be present (Visual Studio installs it by default).

## Logins (seeded on first run)

| Username | Password    | Role   |
|----------|-------------|--------|
| admin    | admin123    | Admin  |
| ana      | student123  | Student |

## What works

- Login screen with role routing
- Student dashboard: overview, applications (with optional 2x2 photo), my applications
- Admin dashboard: overview, application review with status decisions
  (Approve / Under Review / Reject), activity log, creating new application
  records including a photo
- Real login accounts read from the database (PBKDF2-hashed passwords)
- Data persistence in SQL Server LocalDB, created and seeded automatically

## What is left (ideas)

- Registration page for new students
- Eligibility evaluation rules
- Reporting and export

## Project layout

- `Forms/` - windows: login, dashboards, admin application dialog
  (each has a `.Designer.cs` so it opens in the VS Forms Designer)
- `Controls/` - screens hosted inside the dashboards, shared styling (`Ui.cs`)
- `Data/` - database helper, repository (all SQL), password hashing, session
- `Models/` - the `ScholarshipApplication` record used by all screens
