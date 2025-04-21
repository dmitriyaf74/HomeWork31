using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackBuilder.Classes
{
    internal abstract class Part
    {

        protected int PrevPartRow(ImmutableList<string> APoem)
        {
            for (int i = APoem.Count - 1; i >= 0; i--)
                if (APoem[i] == "")
                    return i;
            return -1;
        }

        public abstract Part AddPart(ImmutableList<string> APoem);
        public abstract ImmutableList<string> GetPoem();
        public ImmutableList<string> Poem { get { return GetPoem(); } }
        protected Part AddCustomPart(ImmutableList<string> APrevPoem, ref ImmutableList<string> A_poem)
        {
            var startCount = A_poem.Count;

            for (int i = 0; i < APrevPoem.Count; i++)
            {
                A_poem = A_poem.Insert(i, APrevPoem[i]);
            }

            A_poem = A_poem.Insert(APrevPoem.Count, "");

            for (int i = PrevPartRow(APrevPoem) + startCount; i < APrevPoem.Count; i++)
            {
                A_poem = A_poem.Insert(A_poem.Count, APrevPoem[i]);
            }
            return this;
        }

    }

    internal class Part1 : Part
    {
        public Part1(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part2 : Part
    {
        public Part2(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part3 : Part
    {
        public Part3(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part4 : Part
    {
        public Part4(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part5 : Part
    {
        public Part5(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part6 : Part
    {
        public Part6(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part7 : Part
    {
        public Part7(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }

        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part8 : Part
    {
        public Part8(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
    internal class Part9 : Part
    {
        public Part9(string[] Poem) { _poem = _poem.AddRange(Poem); }

        private ImmutableList<string> _poem = ImmutableList<string>.Empty;
        public override ImmutableList<string> GetPoem() { return _poem; }
        public override Part AddPart(ImmutableList<string> APoem) { return AddCustomPart(APoem, ref _poem); }
    }
}
