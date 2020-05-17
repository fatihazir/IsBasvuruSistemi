using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class Node1<T>
    {
        public Node1<T> Left { get; set; }
        public Node1<T> Right { get; set; }
        public T Value { get; set; }
    }
}
