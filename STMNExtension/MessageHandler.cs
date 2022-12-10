using System;
using System.Collections.Generic;
using System.Text;

namespace STMNExtension
{
    internal class MessageHandler
    {
        public MessageHandler(Config config, Loader loader)
        {

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
                }
            }
        }

        public void EnableTranslator(string[] args)
        {

        }

        public void DisableTranslator(string[] args)
        {

        }
    }
}
