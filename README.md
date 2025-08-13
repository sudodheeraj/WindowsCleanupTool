# 🧹 WindowsCleanupTool

[![Build and Release](https://github.com/sudodheeraj/WindowsCleanupTool/actions/workflows/release-build.yml/badge.svg)](https://github.com/sudodheeraj/WindowsCleanupTool/actions)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![.NET](https://img.shields.io/badge/.NET-9.0-purple)

A simple **C# WinForms** utility to quickly clean **unwanted files** from your Windows system — with logging support.

## ✨ Features
- Clear **Temp** folder
- Clear **Prefetch** files
- Empty **Recycle Bin**
- Remove **Windows Update Cache**
- **Log** every action to a `Logs` folder next to the EXE
- Skip locked files without crashing
- Self-contained **single EXE** (no .NET install required)

---

## 📦 Download

You can get the latest `.exe` from the **[Releases page](https://github.com/sudodheeraj/WindowsCleanupTool/releases)**.

---

## 🛠 Usage

1. **Download** the EXE from [Releases](https://github.com/sudodheeraj/WindowsCleanupTool/releases)
2. **Right-click** → **Run as Administrator**
3. Select the cleanup options you want:
   - ✅ Temporary files  
   - ✅ Prefetch  
   - ✅ Recycle Bin  
   - ✅ Windows Update cache
4. Click **Cleanup**
5. Check the `Logs` folder (created next to the EXE) for detailed results

---

## 📋 Build from Source

### Prerequisites
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- `.NET 9 SDK` installed

### Steps
```powershell
# Clone repository
git clone https://github.com/sudodheeraj/WindowsCleanupTool.git
cd WindowsCleanupTool

# Build
dotnet restore
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
