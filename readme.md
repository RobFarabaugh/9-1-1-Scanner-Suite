{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil Verdana;}}
{\*\generator Riched20 10.0.27842}\viewkind4\paperw11906\paperh16838\psz9
{\*\jarte object RichPersist
  Version = 2
  LMarg = 1440
  RMarg = 1440
  TMarg = 1440
  BMarg = 1440
  Equal = True
  Orient = 1
  Size = 9
  Width = 2100
  Height = 2970
  LHdr = '$3B'
  MHdr = '$3B'
  RHdr = '$3B'
  LFtr = '$3B'
  MFtr = '$3B'
  RFtr = '$3B'
  PrtHdr = True
  PrtFtr = True
  HdrMarg = 1440
  FtrMarg = 1440
  HdrFont.Charset = DEFAULT_CHARSET
  HdrFont.Color = clWindowText
  HdrFont.Height = -11
  HdrFont.Name = 'MS Sans Serif'
  HdrFont.Style = []
  Wrap = 2
  WMark = 'None'
  WColor = 13822463
  Collate = True
  SpellDict = 'ssceam2.clx'
end
}\uc1 
\pard\f0\fs20 9-1-1 Scanner Suite is a Windows desktop application intended to provide an accessible interface for managing scanner-related tasks, especially for users relying on screen readers like JAWS.\par
\par
?? Current Features\par
\par
Menu bar with the following items:\par
\par
Feed\par
\par
Favorites\par
\par
Settings\par
\par
Help\par
\par
?? What's Not Working / Needs Fixing\par
\par
Submenus under the main menu items (e.g., under Feed, Help, etc.) are not yet implemented.\par
\par
A leftover menu item labeled "ToolStripMenuItem1" needs to be removed.\par
\par
The Windows Form title still says "Form1" instead of "ScannerSuite".\par
\par
Designer is not currently viewable in Visual Studio.\par
\par
MenuStrip is not fully accessible with JAWS or NVDA yet.\par
\par
Proper project structure and file associations (missing .sln file in some builds).\par
\par
Needs to be packaged as a .exe installer with full functionality.\par
\par
\par
\par
Broadcastify API key needs to be obtained.\par
\par
?? Project Structure Notes\par
\par
The project was started using Windows Forms in C#.\par
\par
The menu bar is initialized in Form1.Designer.cs.\par
\par
The main class is in Form1.cs.\par
\par
? What Needs to Happen\par
\par
Fix the menu bar so submenu items can be added and accessed via screen readers.\par
\par
Clean up project file structure (remove unused or incorrect files).\par
\par
Ensure all accessibility elements are screen-reader friendly.\par
\par
Add meaningful functionality to menu items (future step).\par
\par
Build and test a working .exe Windows Installer.\par
\par
?? How You Can Help\par
\par
If you're comfortable with C# and Windows Forms:\par
\par
Clone this repo.\par
\par
Open the solution in Visual Studio.\par
\par
Help add working submenus and fix layout/accessibility issues.\par
\par
Submit a pull request when ready.\par
\par
Thank you!\par
}
 