namespace AndreasReitberger.Shared.Syncfusion.FontIcons
{
    public sealed class UIFontInitializer : IMauiInitializeService
    {
        public void Initialize(IServiceProvider services)
        {
            var registrar = services.GetService<IFontRegistrar>();
            if (registrar is null) return;
            foreach (var cfg in IconFontConfigs.All)
            {
                registrar.Register(cfg.FontFile, cfg.FontAlias);
            }
        }
    }
}
