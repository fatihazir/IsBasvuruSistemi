using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class HeapSort
    {
        private int[] dizi;
        public HeapSort(int[] dizi)
        {
            this.dizi = dizi;
        }

        public int[] Sort()
        {
            Heap newArray = new Heap(dizi.Length); // Heap sınıfından kalıtarak yeni bir dizi oluşturuyorum.
            HeapDugumu insertedNode; // HeapDugumu sınıfından diziye basılacak değer amacıyla bir değişken oluşturdum. 
            HeapDugumu removedNode; // HeapDugumu sınıfından diziden silinecek root değer amacıyla bir değişken oluşturdum. 
            int[] sonDizi = new int[dizi.Length]; // int cinsinden bir dizi daha oluşturdum. Bunun sebebi dönecek değerleri tutmaktı.
            for (int i = 0; i < dizi.Length; i++) // tüm dizi elemanlarını ağaca EKLEMEK için geziyorum
            {
                insertedNode = new HeapDugumu(dizi[i]); // ilgili dizi elemanını HeapDugumu sınıfının constructoruna yolluyorum. Dönen değer ise HeapDugumu ile bağlantılı
                newArray.Insert(insertedNode.Deger); // Dönen elemanın Deger özelliğini Heap'e ulaştığım newArray nesnesiyle Insert fonksiyonuna atıyorum.
            }
            for (int i = 0; i < dizi.Length; i++) // tüm dizi elemanlarını ağaçtan SİLMEK için geziyorum
            {
                removedNode = newArray.RemoveMax(); // newArray nesnem ile Heap sınıfındaki root silme metoduna erişiyorum. Dönen değeri silinecek düğüme atıyorum.
                sonDizi[i] = removedNode.Deger; // ilk başta oluşturduğum sonDizi dizisine teker teker rootları ekliyorum.
            }
            return sonDizi; // Elimde olan sonucu döndürmek geriye kalıyor.
        }

    }
}
