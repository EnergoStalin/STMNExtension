using System;
using static mpvnet.Global;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace STMNExtension
{
    internal class Loader
    {

        public Loader() { }

        public void AutoLoad()
        {
            var track = Core.MediaTracks
                .Where(e => e.Type == "sub" && e.Text.Contains(""))
                .FirstOrDefault();

            if (track == null)
            {
                return;
            }
        }

        public void Load()
        {
        }

        public void Unload()
        {

        }
    }
}
