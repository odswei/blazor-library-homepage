# Library Homepage

## Overview
This project is a Blazor-based library homepage that features a responsive, accessible, and themable design. It provides two layout options for the homepage, allowing users to switch between light and dark themes seamlessly.

## Project Structure
```
library-homepage
├── Pages
│   ├── IndexA.razor        # Layout A for the library homepage
│   ├── IndexB.razor        # Layout B for the library homepage
│   ├── Index.razor         # Final version based on selected layout
│   └── ToggleTheme.razor    # Theme toggle button component
├── Services
│   └── ThemeService.cs      # Manages light/dark mode functionality
├── Shared
│   └── MainLayout.razor     # Main layout for the application
├── wwwroot
│   ├── css
│   │   ├── style.css        # Base styles for the light theme
│   │   └── theme-dark.css    # Dark theme overrides
│   └── js
│       ├── main.js          # JavaScript interactivity
│       └── theme.js         # Theme interop functionality
├── library-homepage.csproj   # Project file for the Blazor application
└── README.md                 # Setup and customization instructions
```

## Setup Instructions
1. Clone the repository to your local machine.
2. Open the project in your preferred IDE.
3. Restore the project dependencies by running:
   ```
   dotnet restore
   ```
4. Build the project using:
   ```
   dotnet build
   ```
5. Run the application:
   ```
   dotnet run
   ```
6. Navigate to `http://localhost:5000` in your web browser to view the library homepage.

## Customization Instructions
- To modify the light and dark themes, edit the CSS variables defined in `wwwroot/css/style.css` and `wwwroot/css/theme-dark.css`.
- For layout changes, update the `IndexA.razor` and `IndexB.razor` files as needed.
- The theme toggle functionality can be customized in `ToggleTheme.razor` and `theme.js`.

## Features
- Two layout options for the homepage.
- Responsive design using Flexbox/Grid.
- Accessibility support with ARIA roles.
- Theme toggle functionality with persisted user preference.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.