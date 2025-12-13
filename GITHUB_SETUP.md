# GitHub Setup Instructions

## Step 1: Install Git (if not already installed)
Download and install Git from: https://git-scm.com/download/win
After installation, restart your terminal/PowerShell.

## Step 2: Initialize Git Repository

Open PowerShell in your project directory and run:

```powershell
# Initialize git repository
git init

# Add all files to staging
git add .

# Create your first commit
git commit -m "Initial commit"
```

## Step 3: Create a GitHub Repository

1. Go to https://github.com and sign in (or create an account)
2. Click the "+" icon in the top right corner
3. Select "New repository"
4. Choose a repository name (e.g., "Uniflow" or "ipp")
5. **DO NOT** initialize with README, .gitignore, or license (since you already have files)
6. Click "Create repository"

## Step 4: Connect Your Local Repository to GitHub

After creating the repository on GitHub, you'll see instructions. Run these commands (replace `YOUR_USERNAME` and `YOUR_REPO_NAME` with your actual values):

```powershell
# Add the remote repository (replace with your actual repository URL)
git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git

# Rename the default branch to main (if needed)
git branch -M main

# Push your code to GitHub
git push -u origin main
```

## Alternative: Using GitHub CLI (gh)

If you have GitHub CLI installed, you can do it all in one command:

```powershell
gh repo create --source=. --public --push
```

## Troubleshooting

- If you get authentication errors, you may need to set up a Personal Access Token:
  1. Go to GitHub Settings > Developer settings > Personal access tokens > Tokens (classic)
  2. Generate a new token with `repo` permissions
  3. Use the token as your password when pushing

- If you need to configure your Git identity:
```powershell
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

