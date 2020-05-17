using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    class Tree <T>
    {
        public Node1<T> Top { get; set; }

        public void Add(params T[] value)
        {

            var _values = new List<T>(value);
            var middle = _values.OrderBy(e => e).Skip(_values.Count / 2).First();
            _values.Remove(middle);
            _values.Insert(0, middle);

            foreach (var values in _values)
            {
                if (this.Top == null)
                {
                    Top = new Node1<T>() { Value = values };

                    continue;
                }

                var current = this.Top;
                var added = false;

                do
                {
                    if (Comparer<T>.Default.Compare(values, current.Value) == -1)
                    {
                        // go for left
                        if (current.Left == null)
                        {
                            current.Left = new Node1<T>() { Value = values };
                            added = true;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                    else
                    {
                        // go for right
                        if (current.Right == null)
                        {
                            current.Right = new Node1<T>() { Value = values };
                            added = true;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                } while (!added);
            }
        }
    }
}
