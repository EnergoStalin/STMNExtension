using System.IO;
using System.Text.Json;
using static mpvnet.Global;

namespace STMNExtension
{
    internal class Config
    {
        public double DefaultDelay = -0.5;
        public string Translator = "google";
        public bool TranslatedOnly = true;
        public bool PrimaryOriginal = false;
        public string FromLang = "en";
        public string ToLang = "ru";
        public string OsdFont = "Arial";
        public bool AutoEnableTranslator = false;

        private Config() { }

        public static Config Load(string name)
        {
            try
            {
                return JsonSerializer.Deserialize<Config>(Path.Combine(Core.ConfigFolder, "script-opts", name));
            }
            catch
            {
                return new Config();
            }
        }
    }
}
