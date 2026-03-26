namespace AndreasReitberger.Shared.FontIcons
{
    // Source: https://github.com/jfversluis/IconFont.Maui.Template/blob/main/src/IconFont.Maui.Template/FluentIconsInitializer.cs
    public sealed class MaterialDesignFontInitializer : IMauiInitializeService
    {
        public void Initialize(IServiceProvider services)
        {
            IFontRegistrar? registrar = services.GetService<IFontRegistrar>();
            if (registrar is null) return;
            foreach (IconFontConfig? cfg in IconFontConfigs.All)
            {
                registrar.Register(cfg.FontFile, cfg.FontAlias);
            }
        }
    }
}
