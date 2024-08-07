using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public abstract class Details : IEnumerable
    {
        SortedDictionary<int, Details> goods = new SortedDictionary<int, Details>();

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return goods.GetEnumerator();
        }
       
    }
}
