# Project Structure for Git Setup

## Project Information
- **Project Type**: ASP.NET Core Web Application (Razor Pages)
- **Framework**: .NET 8.0
- **Project Name**: Uniflow
- **Location**: `C:\Users\gabir\Downloads\ipp`
- **Current Git Status**: Not initialized (no .git folder exists)
- **Git Status**: Git is not installed on the system yet

## Project Structure

```
ipp/
├── .gitignore                    # Already created (Visual Studio .NET gitignore)
├── GITHUB_SETUP.md              # Setup instructions
├── PROJECT_STRUCTURE.md         # This file
│
├── Uniflow.csproj               # Main project file (.NET 8.0)
├── Uniflow.csproj.user         # User-specific project settings (should be ignored)
├── WebApplication1.sln          # Solution file
│
├── Program.cs                   # Application entry point
│
├── appsettings.json            # Application configuration
├── appsettings.Development.json # Development configuration
│
├── Areas/
│   └── Identity/
│       └── Pages/
│           ├── Account/         # Identity pages (67 files: 36 .cshtml, 31 .cs)
│           ├── Error.cshtml
│           └── [Identity scaffolded pages]
│
├── Data/
│   ├── ApplicationDbContext.cs  # Entity Framework DbContext
│   └── SeedData.cs              # Database seed data
│
├── Migrations/                  # Entity Framework migrations
│   ├── 20251130091646_InitialCreate.cs
│   ├── 20251130091646_InitialCreate.Designer.cs
│   └── ApplicationDbContextModelSnapshot.cs
│
├── Pages/                       # Razor Pages
│   ├── Admin/
│   │   ├── Index.cshtml
│   │   └── Index.cshtml.cs
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Layout.cshtml.css
│   │   ├── _LoginPartial.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   ├── Privacy.cshtml
│   ├── Privacy.cshtml.cs
│   ├── Error.cshtml
│   ├── Error.cshtml.cs
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── Properties/
│   └── launchSettings.json      # Launch configuration
│
├── wwwroot/                     # Static files
│   ├── css/
│   │   └── site.css
│   ├── js/
│   │   └── site.js
│   ├── images/
│   │   └── uniflow-2.png
│   ├── lib/                     # Third-party libraries
│   │   ├── bootstrap/
│   │   ├── jquery/
│   │   ├── jquery-validation/
│   │   └── jquery-validation-unobtrusive/
│   └── uniflow-2.ico
│
├── bin/                         # Build output (SHOULD BE IGNORED)
│   └── Debug/
│       └── net8.0/
│           └── [243 build files: DLLs, EXEs, etc.]
│
├── obj/                         # Intermediate build files (SHOULD BE IGNORED)
│   └── Debug/
│       └── net8.0/
│           └── [Many intermediate files]
│
└── ScaffoldingReadMe.txt        # Scaffolding documentation
```

## Key Technologies & Dependencies
- **ASP.NET Core Identity** (v8.0.11) - Authentication/Authorization
- **Entity Framework Core** (v8.0.11) - ORM
- **SQL Server** - Database
- **Bootstrap** - CSS framework
- **jQuery** - JavaScript library
- **jQuery Validation** - Form validation

## Files That Should Be Committed
✅ Source code files (.cs, .cshtml, .csproj, .sln)
✅ Configuration files (appsettings.json, launchSettings.json)
✅ Static assets (wwwroot/)
✅ Migrations folder
✅ .gitignore file

## Files That Should Be Ignored (already in .gitignore)
❌ `bin/` - Build output
❌ `obj/` - Intermediate build files
❌ `*.user` - User-specific settings
❌ `.vs/` - Visual Studio cache
❌ Various cache and temporary files

## Current State
- ✅ `.gitignore` file exists and is properly configured for .NET projects
- ❌ Git repository is NOT initialized
- ❌ Git is NOT installed on the system
- ❌ No commits have been made
- ❌ No remote repository configured

## What I Need Help With
I want to:
1. Initialize a Git repository
2. Make an initial commit
3. Create a GitHub repository
4. Push my code to GitHub

Please provide step-by-step instructions for Windows PowerShell, including:
- How to verify Git installation
- Commands to initialize and commit
- How to create and connect to a GitHub repository
- How to push the code

