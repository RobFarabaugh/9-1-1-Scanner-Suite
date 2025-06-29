from pathlib import Path

# Plain text version of README with no markdown, emojis, or formatting
readme_plain_text = """9-1-1 Scanner Suite

Accessible Broadcastify Scanner for Windows (C#, screen-reader friendly)
Designed with blind users in mind. Prototyped using ChatGPT with leadership and vision by Rob Farabaugh.

About This Project

9-1-1 Scanner Suite is an accessible police scanner app for Windows, created for blind users using screen readers. It streams Broadcastify feeds and is fully keyboard-navigable.

The app was initiated by Rob Farabaugh, a blind developer who guided the project using ChatGPT to prototype features and design a fully screen-reader-friendly experience.

Rob’s goal is simple but vital: to make public safety tools accessible to everyone. This open-source project welcomes developers passionate about accessibility, C#, and real-world inclusion.

Project Goals

This project aims to deliver a fully accessible police scanner app for Windows that:
- Works out of the box with NVDA, JAWS, and Narrator
- Streams live Broadcastify feeds
- Supports keyboard-only navigation
- Has dialogs for browsing feeds, genres, alerts, and manual entries
- Provides intelligent screen reader detection and fallback to Windows TTS

Codespace Launch Configuration

This repository supports GitHub Codespaces. To run the app:

- Open the repository in GitHub Codespaces using the "Code" button
- Wait for the environment to set up (this may take a minute or two)
- Once it loads, press F5 to build and run the app

The project includes a launch.json file located in the .vscode folder. This file tells GitHub Codespaces how to compile and run the application.

By default, the launch configuration is set to look for the output file named 9-1-1-Scanner-Suite.dll in the folder bin\\Debug\\net6.0.

If your project uses a different output name in the future, you may need to manually update that file path inside launch.json.

Current To-Do List (Looking for Contributors!)

We’re looking for help completing and polishing the following features:

- Finish the ByStateOrCountry dialog
- Add a Genre selection dialog
- Create an Alert Feeds dialog
- Build an Add Scanner Feed Manually dialog
- Wire up all menu items to their respective dialogs
- Create a Settings dialog with the following options:
  - Start at Windows startup
  - Minimize to System Tray when closed
  - Start minimized
  - Automatically detect active screen reader (NVDA, JAWS, Narrator)
  - Auto-switch if screen reader changes
  - Fallback to Windows TTS if none detected
- Build a Windows Installer that includes:
  - GNU General Public License acceptance screen
  - Reboot prompts (after install/uninstall)
  - Talking installer with screen reader-specific instructions
- Create a Windows Help System file (.chm)
- Build a working .exe from Visual Studio

Keyboard Shortcuts

Ctrl + P = Play or pause the current feed
Ctrl + S = Stop the current feed
Esc = Stop feed and return to feed list
Esc (press twice) = Return to the main menu from feed list
Alt + F = Open Feed Menu
Alt + S = Open Settings Menu
Alt + A = Open Add to Favorites
Alt + H = Open Help
Ctrl + Q = Quit the application

Note: All interface items are navigable via Tab and arrow keys.

Troubleshooting Tips

- Ensure .NET Framework 4.8 or higher is installed
- Check audio output and internet connection
- Menu items may be inactive if their dialogs aren't finished

Contributing

Pull requests and forks are welcome!

We're looking for help with:
- WinForms UI work
- Installer creation
- Screen reader detection logic
- .chm Help packaging

Please check the open issues and tag one to work on.

License

Licensed under the GNU General Public License v3.0.

Contact

Email: 911scannersuite@gmail.com
GitHub: github.com/robfarabaugh

This project was designed by a blind developer using assistive tools. Your help makes this truly accessible tech possible.
"""

# Save to plain .txt file
readme_txt_path = Path("/mnt/data/README_plain_text.txt")
readme_txt_path.write_text(readme_plain_text)
readme_txt_path.name


