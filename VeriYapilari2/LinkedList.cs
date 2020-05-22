using System;

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

        public override void DeletePos(int isDeneyimId)
        {
            Node lastNode = Head;
            Node lastPrevNode = null;

            while (lastNode.Next.Data.IsDeneyimId != isDeneyimId)
            {
                lastPrevNode = lastNode;
                lastNode = lastPrevNode.Next;
            }
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

        public override Node GetElement(int isDeneyimId)
        {
            //Geri dönülecek eleman
            Node retNode = null;
            //Head'den başlanarak Next node'a gidilecek
            Node tempNode = Head;

            while (tempNode != null)
            {
                if (tempNode.Data.IsDeneyimId == isDeneyimId)
                {
                    retNode = tempNode;
                    break;
                }
                //Next node'a git
                tempNode = tempNode.Next;
            }
            return retNode;
        }

        public override void InsertFirst(IsDeneyimi isDeneyimi)
        {
            Node tempHead = new Node();
            tempHead.Data = isDeneyimi;

            if (Head == null)
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

        public override void InsertLast(IsDeneyimi isDeneyimi)
        {
            Node oldLast = Head; //Bir önceki head ile calismak icin onu oldLast degerine atadik.

            if (Head == null)
            {
                InsertFirst(isDeneyimi);  //Head boşsa ilk degeri atamak icin dogru fonksiyonu cagiriyoruz.
            }
            else
            {
                Node newLast = new Node();
                newLast.Data = isDeneyimi;

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