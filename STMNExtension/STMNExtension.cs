using static mpvnet.Global;
using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using mpvnet;
using System.ComponentModel;
using System.Linq;

namespace STMNExtension
{
    [Export(typeof(IExtension))]
    public class STMNExtension : IExtension
    {
        private readonly Config _config;
        private readonly Loader _loader = new Loader();
        private readonly MessageHandler _messageHandler;

        public STMNExtension()
        {
            _config = Config.Load($"{nameof(STMNExtension)}.json");

            _messageHandler = new MessageHandler(_config, _loader);

            if (_config.AutoEnableTranslator)
                Core.FileLoadedAsync += _loader.AutoLoad;


            Core.Shutdown += Shutdown;
            Core.ClientMessageAsync += _messageHandler.ClientMessage;
        }

        public void Shutdown()
        {
            
        }
    }
}
