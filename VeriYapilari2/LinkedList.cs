using System.Collections.Generic;

namespace VeriYapilari2
{
    public class LinkedList : LinkedListIcerikleri
    {
        public List<IsDeneyimi> isDeneyimleriNextiListesi = new List<IsDeneyimi>();
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

        public void NextliIsdeneyiminiAl(Node gelenNode)
        {
            
            while (gelenNode != null)
            {
                if (gelenNode.Next != null)
                {
                    gelenNode = gelenNode.Next;
                    isDeneyimleriNextiListesi.Add(gelenNode.Data);
                }
                else
                {
                    break;
                }
                

            }

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
    }
}