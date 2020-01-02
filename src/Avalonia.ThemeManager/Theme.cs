// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.ThemeManager
{
    public class Theme : ReactiveObject, ITheme
    {
        private string _name = string.Empty;
        private IStyle? _style;
        private IThemeSelector? _selector;

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        public IStyle? Style
        {
            get => _style;
            set => this.RaiseAndSetIfChanged(ref _style, value);
        }

        public IThemeSelector? Selector
        {
            get => _selector;
            set => this.RaiseAndSetIfChanged(ref _selector, value);
        }

        public void ApplyTheme()
        {
            Selector?.ApplyTheme(this);
        }
    }
}
