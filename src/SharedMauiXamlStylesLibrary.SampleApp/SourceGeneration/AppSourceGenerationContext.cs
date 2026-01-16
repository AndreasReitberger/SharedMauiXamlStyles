using SharedMauiXamlStylesLibrary.SampleApp.Utilities;
using System.Text.Json.Serialization;

namespace SharedMauiXamlStylesLibrary.SampleApp.SourceGeneration
{

    [JsonSerializable(typeof(SecretAppSetting))]
    [JsonSourceGenerationOptions(WriteIndented = true)]
    public partial class AppSourceGenerationContext : JsonSerializerContext { }
}
