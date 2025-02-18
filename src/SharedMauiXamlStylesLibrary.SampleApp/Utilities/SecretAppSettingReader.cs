using Newtonsoft.Json;

namespace SharedMauiXamlStylesLibrary.SampleApp.Utilities
{
    /// <summary>
    /// A helper class to read the secrets for api keys
    /// </summary>
    public class SecretAppSettingReader
    {

        /// <summary>
        /// Source: https://www.programmingwithwolfgang.com/use-net-secrets-in-console-application/ 
        /// </summary>
        /// <typeparam name="T">The <c>Type</c> for parsing the <c>secrets.json</c> to</typeparam>
        /// <param name="sectionName">The section name</param>
        /// <returns></returns>
        public static T? ReadSection<T>(string sectionName)
        {
            // It seems that this way makes problems if the app is published on Windows in Release mode
            // Needs the Directory.Build.targets in order to work (copies the secret.json as EmbeddedResource to the app)
            string settings = UserSecretsManager.Settings[sectionName].ToString();
            return JsonConvert.DeserializeObject<T>(settings);
        }
    }
}
