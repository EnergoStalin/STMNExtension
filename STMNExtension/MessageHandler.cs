using System;
using System.Collections.Generic;
using System.Text;

namespace STMNExtension
{
    internal class MessageHandler
    {
        private Config _config;
        private Loader _loader;

        public MessageHandler(Config config, Loader loader)
        {
            _config = config;
            _loader = loader;
        }

        public void ClientMessage(string[] args)
        {
            foreach(var arg in args)
            {
                switch(arg)
                {
                    case nameof(EnableTranslator):
                        EnableTranslator(args);
                    break;
                    case nameof(DisableTranslator):
                        DisableTranslator(args);
                    break;
                    case nameof(PrimaryOriginal):
                        PrimaryOriginal(args);
                    break;
                    case nameof(TranslatedOnly):
                        TranslatedOnly(args);
                    break;
                }
            }
        }

        private void TranslatedOnly(string[] args) => _config.TranslatedOnly = !_config.TranslatedOnly;

        private void PrimaryOriginal(string[] args) => _config.PrimaryOriginal = !_config.PrimaryOriginal;

        private void EnableTranslator(string[] args) => _loader.Load();

        private void DisableTranslator(string[] args) => _loader.Unload();
    }
}
