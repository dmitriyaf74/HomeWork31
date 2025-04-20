using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackBuilder.Classes
{
    internal abstract class Part
    {

        protected int PrevPartRow(List<string> APoem)
        {
            for (int i = APoem.Count - 1; i >= 0; i--)
                if (APoem[i] == "")
                    return i;
            return -1;
        }

        public abstract Part AddPart(List<string> APoem);
        public abstract List<string> GetPoem();
        public List<string> Poem { get { return GetPoem(); } }
        protected Part AddCustomPart(List<string> APoem, List<string> A_poem)
        {
            var startCount = A_poem.Count;

            for (int i = 0; i < APoem.Count; i++)
            {
                A_poem.Insert(i, APoem[i]);
            }

            A_poem.Insert(APoem.Count, "");

            for (int i = PrevPartRow(APoem) + startCount; i < APoem.Count; i++)
            {
                A_poem.Insert(A_poem.Count, APoem[i]);
            }
            return this;
        }

    }

    internal class Part1 : Part
    {
        public Part1(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part2 : Part
    {
        public Part2(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part3 : Part
    {
        public Part3(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part4 : Part
    {
        public Part4(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part5 : Part
    {
        public Part5(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part6 : Part
    {
        public Part6(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part7 : Part
    {
        public Part7(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }

        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part8 : Part
    {
        public Part8(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
    internal class Part9 : Part
    {
        public Part9(string[] Poem) { _poem.AddRange(Poem); }

        private List<string> _poem = new List<string>();
        public override List<string> GetPoem() { return _poem; }
        public override Part AddPart(List<string> APoem) { return AddCustomPart(APoem, _poem); }
    }
}
