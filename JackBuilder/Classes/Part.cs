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

    internal class Part1 : Part
    {
        public Part1(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part2 : Part
    {
        public Part2(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part3 : Part
    {
        public Part3(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part4 : Part
    {
        public Part4(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part5 : Part
    {
        public Part5(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part6 : Part
    {
        public Part6(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part7 : Part
    {
        public Part7(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part8 : Part
    {
        public Part8(string[] Poem) : base(Poem)
        {
        }
    }
    internal class Part9 : Part
    {
        public Part9(string[] Poem) : base(Poem)
        {
        }
    }
}
