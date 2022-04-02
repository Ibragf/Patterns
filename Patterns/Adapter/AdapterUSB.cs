using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class AdapterUSB : USB
    {
        MemoryCard memoryCard;
        public AdapterUSB(MemoryCard memoryCard)
        {
            this.memoryCard = memoryCard;
        }
        public override void Connect()
        {
            memoryCard.connectCard();
        }
    }
}
