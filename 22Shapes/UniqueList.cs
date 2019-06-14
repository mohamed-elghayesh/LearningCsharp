using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class UniqueList<T> : List<T>
    {
        public void RemoveDuplicates()
        {
            base.Sort();

            for (int i = this.Count - 1; i > 0; i--)
            {
                if (this[i].Equals(this[i - 1]))
                {
                    this.RemoveAt(i);
                }
            }
        }
    }
}
