using Newtonsoft.Json.Linq;
using System.Reflection;

namespace SharedMauiXamlStylesLibrary.SampleApp.Utilities
{
    /// <summary>
    /// A helper class to read the <c>secrets.json</c> file
    /// Source: https://github.com/ncarandini/XFUserSecrets/blob/master/TPCWare.XFUserSecrets/Utils/UserSecretsManager.cs
    /// Changed: Yes
    /// </summary>
    public class UserSecretsManager
    {
        #region Variables
        private static UserSecretsManager _instance;
        private JObject _secrets;

        // Default namespace of the project
        private const string Namespace = "SharedMauiXamlStylesLibrary.SampleApp";

        // Filename of the embedded resource file
        private const string UserSecretsFileName = "secrets.json";
        #endregion

        #region Ctor
        private UserSecretsManager()
        {
            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(UserSecretsManager)).Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{Namespace}.{UserSecretsFileName}");
            using StreamReader reader = new(stream);
            string json = reader.ReadToEnd();
            _secrets = JObject.Parse(json);
        }
        #endregion

        #region Methods
        public static UserSecretsManager Settings
        {
            get
            {
                _instance ??= new UserSecretsManager();
                return _instance;
            }
        }

        public string this[string name]
        {
            get
            {
                try
                {
                    var path = name.Split(':');
                    JToken node = _secrets[path[0]];
                    for (int index = 1; index < path.Length; index++)
                    {
                        node = node[path[index]];
                    }
                    return node.ToString();
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
        #endregion
    }
}
