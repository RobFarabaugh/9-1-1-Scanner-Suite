from pathlib import Path

# Create README.md content from the Canvas textdoc
readme_content = """# 9‑1‑1 Scanner Suite

**Accessible Broadcastify Scanner for Windows (C#, screen-reader friendly)**\\
Designed with blind users in mind. Prototyped using ChatGPT with leadership and vision by Rob Farabaugh.

---

## 🎯 Project Goals

This project aims to deliver a fully accessible police scanner app for Windows that:

- Works out of the box with NVDA, JAWS, and Narrator
- Streams live Broadcastify feeds
- Supports keyboard-only navigation
- Has dialogs for browsing feeds, genres, alerts, and manual entries
- Provides intelligent screen reader detection and fallback to Windows TTS

---

## 🛠️ Current To‑Do List (Looking for Contributors!)

We’re looking for help completing and polishing the following features:

- [ ] Finish the “By State or Country” dialog
- [ ] Add a “Genre” selection dialog
- [ ] Create an “Alert Feeds” dialog
- [ ] Build an “Add Scanner Feed Manually” dialog
- [ ] Wire up all menu items to their respective dialogs
- [ ] Create “Settings” dialog with the following options:
  - Start at Windows startup
  - Minimize to System Tray when closed
  - Start minimized
  - Automatically detect active screen reader (NVDA, JAWS, Narrator)
  - If current screen reader closes and a new one starts, switch automatically
  - If no screen reader is detected, default to Windows TTS
  - Dialog includes checkboxes, OK and Cancel buttons
- [ ] Build a Windows Installer that includes:
  - GNU General Public License acceptance screen
  - Reboot prompt after install
  - Reboot prompt after uninstall
  - Talking installer with screen reader-specific instructions during setup
- [ ] Create a Windows Help System file (`.chm`) like JAWS uses
- [ ] Build working `.exe` from Visual Studio project

---

## ⌨️ Keyboard Shortcuts

| Shortcut   | Function                                 |
|------------|------------------------------------------|
| `Ctrl + P` | Play or pause the current feed           |
| `Ctrl + S` | Stop the current feed                    |
| `Esc`      | Stop feed and return to feed list        |
| `Esc` (2x) | Return to the main menu from feed list   |
| `Alt + F`  | Open **F**eed Menu                       |
| `Alt + S`  | Open **S**ettings Menu                   |
| `Alt + A`  | Open **A**dd to Favorites                |
| `Alt + H`  | Open **H**elp                            |
| `Ctrl + Q` | Quit the application                     |

*Note: All interface items are navigable via Tab and arrow keys. The app is optimized for use with NVDA, JAWS, or Narrator.*

---

## 🛠 Troubleshooting Tips

- If the app does not launch, ensure `.NET Framework 4.8` or higher is installed
- If audio does not play, check your internet connection and firewall
- If menu items do nothing, the corresponding dialog may still need to be implemented

---

## 🤝 Contributing

Pull requests and forks are welcome!

If you're experienced in any of the following, we need you:

- WinForms development
- .NET Installer creation (Inno Setup, WiX, etc.)
- Screen reader optimization
- Building `.chm` Windows Help files

Please start by checking the open issues and picking one to work on.

---

## 📜 License

This software is licensed under the **GNU General Public License v3.0**.\\
The final installer will include a license acceptance step.

---

## 📫 Contact

Questions or offers to help?\\
**Email:** 911scannersuite@gmail.com\\
**GitHub:** [github.com/robfarabaugh](https://github.com/robfarabaugh)

---

> *This project was created with help from ChatGPT. Rob Farabaugh guided its design and accessibility goals as a blind user passionate about accessible tech.*
"""

# Create GitHub Issues content
issues_content = """# Suggested GitHub Issues for 9‑1‑1 Scanner Suite

## Feature & Dialog Work

### Finish “By State or Country” dialog
- Populate combo box with U.S. states and countries
- Add confirmation and cancel buttons
- Return selection to parent window or handler

### Create “Genre” selection dialog
- Add combo box with hardcoded genres (Police, Fire, EMS, etc.)
- Wire selection to feed lookup or filtering logic

### Create “Alert Feeds” dialog
- Show currently active Broadcastify alerts (via API or static list)
- Add refresh and close buttons

### Create “Add Scanner Feed Manually” dialog
- Add text box to enter feed URL
- Include “Save” and “Cancel” buttons
- Validate input

### Wire menu items to dialogs
- Add `Click` handlers in `Form1.cs`
- Link to respective dialog windows using `ShowDialog()`

## Installer and Help System

### Add GNU General Public License screen to installer
- Include GPL v3.0 text and require acceptance before install continues

### Add reboot prompt to installer and uninstaller
- Trigger reboot prompt after setup/uninstall completes

### Use a talking installer with screen-reader guidance
- Announce key steps and use TTS or SAPI for accessibility

### Create Windows Help file (.chm)
- Include keyboard shortcuts, troubleshooting, and contact info
- Use HTML Help Workshop to compile the `.chm`

### Build working `.exe`
- Compile and test the full app using Visual Studio
- Validate menus, dialogs, and playback features
"""

# Save both files
readme_path = Path("/mnt/data/README.md")
issues_path = Path("/mnt/data/GitHub_Issues.md")
readme_path.write_text(readme_content)
issues_path.write_text(issues_content)

readme_path.name, issues_path.name

