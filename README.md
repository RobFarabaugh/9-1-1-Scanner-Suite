# 9-1-1 Scanner Suite

**An accessible, screen-reader-friendly Windows police scanner app.**

> Built with blind and visually impaired users in mind, so live police, fire, and EMS audio feeds don't depend on inaccessible web interfaces.

Initiated by Rob Farabaugh, a blind developer who guided the project using ChatGPT for prototyping and design. The goal is simple: make public safety tools accessible to everyone. This open-source project welcomes developers who care about accessibility, C#, and real-world inclusion.

---

## Project goals

- Work out of the box with NVDA, JAWS, and Narrator
- Stream live Broadcastify feeds
- Support keyboard-only navigation
- Provide dialogs for browsing feeds, genres, alerts, and manual entries
- Detect the active screen reader and fall back to Windows TTS

---

## ⚠️ Current status

This is an early prototype, not a working scanner yet. Please read this before filing a bug about a missing feature.

**What works today**

- The app launches on Windows and shows a menu bar: **Feed**, **Favorites**, **Settings**, **Help**.
- A `ByStateOrCountryDialog` exists with a state/country dropdown and OK/Cancel buttons.

**What does not work yet**

- The menus are empty and have no click handlers, so nothing in them can be selected.
- No audio streaming, feed lists, favourites, or settings are implemented.
- The By State Or Country dialog is not yet opened from the menu, and does not yet expose the selected value to a caller.
- The keyboard shortcuts listed below are planned, not active.

---

## Requirements

- **Windows 10 or 11** to run the app. It is a WinForms desktop application and cannot run on Linux or macOS.
- **.NET 8 SDK** to build. The project targets `net8.0-windows`.
- A screen reader if you want to test accessibility: NVDA or JAWS are used most often, and Narrator ships with Windows.

> The project sets `EnableWindowsTargeting`, so `dotnet build` also works on Linux and macOS, which is what the dev container uses. Running the app still requires Windows.

---

## 🚀 Getting started

1. Clone the repository:
   ```
   git clone https://github.com/RobFarabaugh/9-1-1-Scanner-Suite.git
   ```
2. Open `ScannerSuite.csproj` in Visual Studio 2022, or open the folder in VS Code with the C# extension.
3. Build and run.

From the command line:

```
dotnet build ScannerSuite.csproj
dotnet run --project ScannerSuite.csproj
```

The build output is `bin\Debug\net8.0-windows\`, containing `ScannerSuite.dll` plus `ScannerSuite.exe` on Windows. On Linux and macOS only the `.dll` is produced, since the Windows executable launcher is generated on Windows. In VS Code, pressing F5 runs the **Launch ScannerSuite** configuration, which builds first and then starts the app.

---

## 🎧 Keyboard shortcuts (planned)

These are the planned bindings. They are documented ahead of implementation, so treat them as the intended design rather than current behaviour.

| Shortcut | Action |
| --- | --- |
| `Ctrl + P` | Play or pause the current feed |
| `Ctrl + S` | Stop the current feed |
| `Esc` | Stop the feed and return to the feed list |
| `Esc` twice | Return to the main menu from the feed list |
| `Alt + F` | Open the Feed menu |
| `Alt + S` | Open the Settings menu |
| `Alt + A` | Add to Favorites |
| `Alt + H` | Open Help |
| `Ctrl + Q` | Quit the application |

All interface items are intended to be reachable with `Tab` and the arrow keys.

---

## 🗺️ Roadmap

- [ ] Finish the By State Or Country dialog, including returning the selected value
- [ ] Add a Genre selection dialog
- [ ] Add an Alert Feeds dialog
- [ ] Add an "Add Scanner Feed Manually" dialog
- [ ] Wire every menu item to its dialog
- [ ] Settings dialog: start with Windows, minimize to system tray, start minimized
- [ ] Screen reader detection (NVDA, JAWS, Narrator) with auto-switch and Windows TTS fallback
- [ ] Broadcastify stream playback
- [ ] NOAA weather alert streaming
- [ ] Uniden scanner programming integration
- [ ] Speech customization options
- [ ] Sound feedback for navigation
- [ ] Windows installer with a GPL acceptance screen, reboot prompts, and spoken instructions
- [ ] Windows Help file (`.chm`)
- [ ] Ship a signed `.exe`

Checked items land with the pull request that implements them, not before.

---

## Troubleshooting

- **`MSB1011`: more than one project file** — keep a single project file in the repository root.
- **The app builds but nothing in the menus responds** — expected at this stage; see Current status.
- **No audio** — audio playback is not implemented yet.
- **The app won't start on Linux or macOS** — building works there, but WinForms needs Windows to run. Use the dev container to edit and build, and Windows to run.

---

## 🤝 Contributing

Contributions are welcome: bug fixes, accessibility improvements, and new features alike.

1. Fork the project
2. Create a branch for your change
3. Open a pull request with a clear description

Help is especially welcome with WinForms UI work, screen reader detection logic, installer creation, and `.chm` help packaging. Look for `good first issue` in the Issues tab.

Accessibility changes should be tested with a real screen reader, and any new control needs a keyboard path and a meaningful accessible name.

---

## 📄 License

Licensed under the **GNU General Public License v3.0**. See [LICENSE](LICENSE) for the full text.

---

## 📣 Feedback and support

- Open a GitHub Issue for bugs and feature requests
- Share it in blind tech forums if you find it useful

**Contact:** 911scannersuite@gmail.com · [github.com/robfarabaugh](https://github.com/robfarabaugh)
