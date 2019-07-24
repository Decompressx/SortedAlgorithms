using System;
using System.Collections.Generic;
using System.Text;

namespace SearchElement
{
    public abstract class SearchAlg
    {
        protected int[] array;
        public abstract int Search(int element);
    }
}
