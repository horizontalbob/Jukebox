using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class CDNode : StackNode
    {
        public string Artist { get; set; }
        public string PlaybackLength { get; set; }
        public int NumberOfTracks { get; set; }
    }
}
