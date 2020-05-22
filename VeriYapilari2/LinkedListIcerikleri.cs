namespace VeriYapilari2
{
    public abstract class LinkedListIcerikleri
    {
        public Node Head;
        public int Size = 0;

        public abstract void InsertFirst(IsDeneyimi isDeneyimi);

        public abstract void InsertLast(IsDeneyimi isDeneyimi);

        public abstract Node GetElement(int position);
    }
}