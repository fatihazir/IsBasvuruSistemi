using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class LinkedList : LinkedListIcerikleri

    {
        public override void DeleteFirst()
        {
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next; // Baglantiyi korumak icin silecegimiz verinin nextini gecici degere atiyoruz.
                if (tempHeadNext == null)
                {
                    Head = null;  // head tek elemansa yani baska eleman yoksa direkt head i sildik.
                }
                else
                {
                    Head = tempHeadNext; // Artik headimiz eski headimizin nexti. Yani ikinci veri.
                }
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node lastNode = Head;
            Node lastPrevNode = null; // Bir onceki nodun nexti.

            while (lastNode.Next != null)
            {
                lastPrevNode = lastNode;
                lastNode = lastPrevNode.Next;
            }
            Size--;

            lastNode = null;

            if (lastPrevNode != null) // last nodenin bir onceki nodu varsa onun nexti null olacak. Yokza tek kayit var demektir. O da headin kendisidir.
            {
                lastPrevNode.Next = null;
            }
            else
            {
                Head = null;
            }
        }

        public override void DeletePos(int position)
        {
            throw new NotImplementedException(); // Gerekirse yazarim.
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += " --> " + item.Data;
                item = item.Next;
            }

            return temp;
        }

        public override Node GetElement(int position)
        {
            //Geri dönülecek eleman
            Node retNode = null;
            //Head'den başlanarak Next node'a gidilecek
            Node tempNode = Head;
            int count = 0;

            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                //Next node'a git
                tempNode = tempNode.Next;
                count++;
            }
            return retNode;
        }

        public override void InsertFirst(string value)
        {
            Node tempHead = new Node();
            tempHead.Data = value;

            if(Head == null)
            {
                Head = tempHead; //Head boşsa ilk degeri head olarak aliyoruz.
            }
            else
            {
                tempHead.Next = Head; // Eger head boş değilse demek ki daha önceden bir veri girilmiş. İnsert first olduğu için şimdi eklediğimizin sağına bir önceki head degerini atiyoruz.

                Head = tempHead; // Artik yeni head degerimiz en son girdigimiz deger oldu.
            }

            Size++;
        }

        public override void InsertLast(string value)
        {
            Node oldLast = Head; //Bir önceki head ile calismak icin onu oldLast degerine atadik.

            if (Head == null)
            {
                InsertFirst(value);  //Head boşsa ilk degeri atamak icin dogru fonksiyonu cagiriyoruz.
            }
            else
            {
                Node newLast = new Node();
                newLast.Data = value;

                while (oldLast.Next != null) // listede soldan baslayip saga dogru gidiyoruz. Taaaaa ki sonuncuyu bulana kadar. Onun nexti bos olacak zaten. Orada duruyor ve
                {
                    oldLast = oldLast.Next;
                }

                oldLast.Next = newLast;  // sonuncunun nextine atamak istedigimiz veriyi atiyoruz.

                Size++;
            }
        }

        public override void InsertPos(int position, string value)
        {
            throw new NotImplementedException();// Gerekirse yazarim.
        }
    }
}
