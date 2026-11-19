namespace AndreasReitberger.Shared.Helpers
{
    public static class ContrastTextColorHelper
    {
        public static readonly BindableProperty EnableAutoTextColorProperty =
            BindableProperty.CreateAttached(
                "EnableAutoTextColor",
                typeof(bool),
                typeof(ContrastTextColorHelper),
                false,
                propertyChanged: OnEnableAutoTextColorChanged);

        public static readonly BindableProperty LightTextColorProperty =
            BindableProperty.CreateAttached(
                "LightTextColor",
                typeof(Color),
                typeof(ContrastTextColorHelper),
                Microsoft.Maui.Graphics.Colors.White);

        public static readonly BindableProperty DarkTextColorProperty =
            BindableProperty.CreateAttached(
                "DarkTextColor",
                typeof(Color),
                typeof(ContrastTextColorHelper),
                Microsoft.Maui.Graphics.Colors.Black);

        public static bool GetEnableAutoTextColor(BindableObject view) =>
            (bool)view.GetValue(EnableAutoTextColorProperty);

        public static void SetEnableAutoTextColor(BindableObject view, bool value) =>
            view.SetValue(EnableAutoTextColorProperty, value);

        public static Color GetLightTextColor(BindableObject view) =>
            (Color)view.GetValue(LightTextColorProperty);

        public static void SetLightTextColor(BindableObject view, Color value) =>
            view.SetValue(LightTextColorProperty, value);

        public static Color GetDarkTextColor(BindableObject view) =>
            (Color)view.GetValue(DarkTextColorProperty);

        public static void SetDarkTextColor(BindableObject view, Color value) =>
            view.SetValue(DarkTextColorProperty, value);

        static void OnEnableAutoTextColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VisualElement element && newValue is bool isEnabled && isEnabled)
            {
                element.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == nameof(VisualElement.BackgroundColor) || e.PropertyName == nameof(VisualElement.Background))
                    {
                        UpdateTextColor(element);
                    }
                };
                // Initial call
                UpdateTextColor(element);
            }
        }

        static void UpdateTextColor(VisualElement element)
        {
            if (element is not Button button)
                return;

            Brush background = button.Background;
            if (background is not SolidColorBrush backgroundColor)
                return;

            Color lightColor = GetLightTextColor(button);
            Color darkColor = GetDarkTextColor(button);
            button.TextColor = GetContrastColor(backgroundColor.Color, lightColor, darkColor);
        }

        static Color GetContrastColor(Color bgColor, Color lightTextColor, Color darkTextColor)
        {
            double luminance = (0.299 * bgColor.Red + 0.587 * bgColor.Green + 0.114 * bgColor.Blue);
            return luminance > 0.5 ? darkTextColor : lightTextColor;
        }
    }
}
