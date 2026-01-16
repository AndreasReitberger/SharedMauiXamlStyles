using AndreasReitberger.Shared.Core.Utilities;
using SharedMauiXamlStylesLibrary.SampleApp.SourceGeneration;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SharedMauiXamlStylesLibrary.SampleApp.Utilities
{
    /// <summary>
    /// A helper class to read the secrets for api keys
    /// </summary>
    public class SecretAppSettingReader
    {
        public static Assembly? Assembly { get; set; }

        /// <summary>
        /// Source: https://www.programmingwithwolfgang.com/use-net-secrets-in-console-application/ 
        /// </summary>
        /// <typeparam name="T">The <c>Type</c> for parsing the <c>secrets.json</c> to</typeparam>
        /// <param name="sectionName">The section name</param>
        /// <returns></returns>
        public static T? ReadSection<T>(string sectionName, JsonSerializerContext? context = null)
        {
            // It seems that this way makes problems if the app is published on Windows in Release mode
            // Needs the Directory.Build.targets in order to work (copies the secret.json as EmbeddedResource to the app)
            if (Assembly is null)
            {
                Assembly = IntrospectionExtensions.GetTypeInfo(typeof(MauiProgram)).Assembly;
                UserSecretsManager.Settings = new UserSecretsManager.UserSecretsManagerBuilder()
                    .WithAppNamespace("SharedMauiXamlStylesLibrary.SampleApp")
                    .WithCustomAssambly(Assembly)
                    .Build();
            }
            string settings = UserSecretsManager.Settings[sectionName].ToString();
            context ??= AppSourceGenerationContext.Default;
            return (T?)JsonSerializer.Deserialize(settings, typeof(T), context);
        }
    }
}
