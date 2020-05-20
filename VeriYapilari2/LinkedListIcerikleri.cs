namespace VeriYapilari2
{
    public abstract class LinkedListIcerikleri
    {
        public Node Head;
        public int Size = 0;

        public abstract void InsertFirst(IsDeneyimi isDeneyimi);

        public abstract void InsertLast(IsDeneyimi isDeneyimi);

        public abstract void InsertPos(int position, string value);

        public abstract void DeleteFirst();

        public abstract void DeleteLast();

        public abstract void DeletePos(int position);

        public abstract Node GetElement(int position);

        public abstract string DisplayElements();
    }
}