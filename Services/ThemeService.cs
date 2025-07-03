using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace library_homepage.Services
{
    public class ThemeService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string ThemeKey = "theme";

        public ThemeService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task InitializeAsync()
        {
            var theme = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", ThemeKey);
            if (string.IsNullOrEmpty(theme))
            {
                theme = "light"; // Default theme
            }
            await SetThemeAsync(theme);
        }

        public async Task ToggleThemeAsync()
        {
            var currentTheme = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", ThemeKey);
            var newTheme = currentTheme == "dark" ? "light" : "dark";
            await SetThemeAsync(newTheme);
        }

        private async Task SetThemeAsync(string theme)
        {
            await _jsRuntime.InvokeVoidAsync("document.body.classList.remove", "light", "dark");
            await _jsRuntime.InvokeVoidAsync("document.body.classList.add", theme);
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", ThemeKey, theme);
        }
    }
}