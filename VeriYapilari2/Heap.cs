namespace VeriYapilari2
{
    public class Heap
    {
        public HeapDugumu[] heapArray;
        public int maxSize;
        private int currentSize;

        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            heapArray = new HeapDugumu[maxSize];
            currentSize = 0;
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public bool Insert(int ilanNumarasi, KisiBilgileri kisi, int iseUygunluk)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(ilanNumarasi, kisi, iseUygunluk);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }

        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].IlanNumarasi < bottom.IlanNumarasi)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }

    }
}