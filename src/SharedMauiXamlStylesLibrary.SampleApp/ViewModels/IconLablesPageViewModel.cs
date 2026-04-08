using CommunityToolkit.Mvvm.ComponentModel;
using IconFont.Maui.MaterialDesignIcons;
using IconFont.Maui.TablerIcons;
using SharedMauiXamlStylesLibrary.SampleApp.Icons;
using System.Collections.ObjectModel;
using System.Reflection;

namespace SharedMauiXamlStylesLibrary.SampleApp.ViewModels
{
    public partial class IconLablesPageViewModel : BaseViewModel
    {

        private static readonly HashSet<string> SkipFields = ["FontFamily"];
        #region Properties

        [ObservableProperty] 
        public partial ObservableCollection<IconGlyph> Icons { get; set; } = [];

        #endregion

        #region Constructor, LoadSettings

        public IconLablesPageViewModel(IDispatcher dispatcher, IServiceProvider provider, string? fontClass = null) : base(dispatcher, provider)
        {
            Dispatcher = dispatcher;
            UpdateVersionBuild();
            if (!string.IsNullOrWhiteSpace(fontClass))
            { 
                if (fontClass.StartsWith("MaterialDesign"))
                    ParseMaterialDesignFont(fontClass);
                else if(fontClass.StartsWith("TablerIcons"))
                    ParseTablerIconFont(fontClass);
            }
        }

        #endregion

        #region Methods

        void ParseMaterialDesignFont(string fontClass)
        {
            var asm = typeof(MaterialDesignIconsOutlined).Assembly;
            foreach (var cfg in IconFont.Maui.MaterialDesignIcons.IconFontConfigs.All)
            {
                if (fontClass is not null && !string.Equals(cfg.ClassName, fontClass, StringComparison.Ordinal))
                    continue;

                // Each OTF may produce multiple generated sub-classes (e.g. Regular, Filled, Rtl).
                // Prefer the "Regular" sub-class which contains the main icon set.
                // Fall back to exact match or first StartsWith match.
                var matchingTypes = asm.GetTypes()
                    .Where(t => t.IsAbstract && t.IsSealed
                        && t.Namespace == cfg.Namespace
                        && t.Name.StartsWith(cfg.ClassName, StringComparison.Ordinal))
                    .OrderBy(t => t.Name, StringComparer.Ordinal)
                    .ToList();

                var primary = matchingTypes.FirstOrDefault(t => t.Name == cfg.ClassName + "Regular")
                           ?? matchingTypes.FirstOrDefault(t => t.Name == cfg.ClassName)
                           ?? matchingTypes.FirstOrDefault();

                if (primary is not null)
                {
                    AddIcons(primary, cfg.FontAlias, cfg.ClassName);
                }
            }
        }

        void ParseTablerIconFont(string fontClass)
        {
            var asm = typeof(TablerIconsRegular).Assembly;
            foreach (var cfg in IconFont.Maui.TablerIcons.IconFontConfigs.All)
            {
                if (fontClass is not null && !string.Equals(cfg.ClassName, fontClass, StringComparison.Ordinal))
                    continue;

                // Each OTF may produce multiple generated sub-classes (e.g. Regular, Filled, Rtl).
                // Prefer the "Regular" sub-class which contains the main icon set.
                // Fall back to exact match or first StartsWith match.
                var matchingTypes = asm.GetTypes()
                    .Where(t => t.IsAbstract && t.IsSealed
                        && t.Namespace == cfg.Namespace
                        && t.Name.StartsWith(cfg.ClassName, StringComparison.Ordinal))
                    .OrderBy(t => t.Name, StringComparer.Ordinal)
                    .ToList();

                var primary = matchingTypes.FirstOrDefault(t => t.Name == cfg.ClassName + "Regular")
                           ?? matchingTypes.FirstOrDefault(t => t.Name == cfg.ClassName)
                           ?? matchingTypes.FirstOrDefault();

                if (primary is not null)
                {
                    AddIcons(primary, cfg.FontAlias, cfg.ClassName);
                }
            }
        }

        // Source: https://github.com/jfversluis/IconFont.Maui.MaterialDesignIcons/blob/main/samples/IconFont.Maui.MaterialDesignIcons.Sample/ViewModels/IconsViewModel.cs
        private void AddIcons(Type type, string fontFamily, string identifierPrefix)
        {
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach (var field in fields)
            {
                if (field.FieldType != typeof(string)) continue;
                if (SkipFields.Contains(field.Name)) continue;
                var glyph = field.GetValue(null) as string;
                if (string.IsNullOrEmpty(glyph)) continue;
                Icons.Add(new IconGlyph
                {
                    Glyph = glyph!,
                    FontFamily = fontFamily,
                    Identifier = $"{identifierPrefix}.{field.Name}",
                    XamlIdentifier = $"icons:{identifierPrefix}.{field.Name}"
                });
            }
        }
        #endregion

    }
}
