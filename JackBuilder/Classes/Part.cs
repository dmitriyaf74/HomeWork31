using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackBuilder.Classes
{
    internal class Part
    {
        private List<string> _poem = new List<string>();

        public Part(string[] Poem) { _poem.AddRange(Poem); }
        public List<string> Poem { get { return _poem; } }

        private int PrevPartRow(List<string> APoem)
        {
            for (int i = APoem.Count - 1; i >= 0; i--)
                if (APoem[i] == "")
                    return i;
            return -1;
        }
        public Part AddPart(List<string> APoem)
        {
            var startCount = _poem.Count;

            for (int i = 0; i < APoem.Count; i++) 
            {
                _poem.Insert(i, APoem[i]);
            }

             _poem.Insert(APoem.Count, "");

            for (int i = PrevPartRow(APoem) + startCount; i < APoem.Count; i++)
            {
                _poem.Insert(_poem.Count,APoem[i]);
            }
            return this;
        }

    }
}
