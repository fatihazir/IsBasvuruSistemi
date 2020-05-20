using System.Collections.Generic;

namespace VeriYapilari2
{
    public class HashChain
    {
        private int TABLE_SIZE = 10;

        private HashChainEntry[] table;

        private List<Ilan> Ilanlar = new List<Ilan>();

        public HashChain()
        {
            table = new HashChainEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
            {
                table[i] = null;
            }
        }

        public bool AddIsIlani(int key, object value, Sirket sirket)
        {
            int hash = (key % TABLE_SIZE);
            string durum = "Aktif";
            bool basarilimi = false;
            if (table[hash] == null)
            {
                table[hash] = new HashChainEntry(key, value, durum, sirket);
                basarilimi = true;
                return basarilimi;
            }
            else
            {
                HashChainEntry entry = table[hash];
                if (entry.Durum == "İlana Erişilemiyor")
                {
                    entry.Deger = value;
                    entry.Anahtar = key;
                    entry.Durum = "Aktif";
                    basarilimi = true;
                    return basarilimi;
                }
                while (entry.Next != null && entry.Anahtar != key)
                {
                    entry = entry.Next;
                }
                if (entry.Anahtar == key)
                {
                    if (entry.Durum == "Aktif")
                    {
                        basarilimi = false;
                        return basarilimi;
                    }
                    entry.Deger = value;
                    entry.Durum = "Aktif";
                    basarilimi = true;
                    return basarilimi;
                }
                else
                {
                    entry.Next = new HashChainEntry(key, value, durum, sirket);
                    basarilimi = true;
                    return basarilimi;
                }
            }
        }

        public Ilan GetIsIlani(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                return null;
            else
            {
                HashChainEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return (Ilan)entry.Deger;
            }
        }

        public Ilan GetIsIlaniForEditingAndListing(int index)
        {
            if (table[index] == null)
                return null;
            else
            {
                HashChainEntry entry = table[index];
                return (Ilan)entry.Deger;
            }
        }
        //public List<Ilan> GetIsIlaniForEditingAndListing()
        //{
        //    if (table == null)
        //        return null;
        //    else
        //    {

        //        for (int i = 0; i < table.Length; i++)
        //        {
        //            object temp = table[i].Deger;
        //            Ilanlar.Add((Ilan)temp);
        //        }

        //        return Ilanlar;
        //    }
        //}

        public Ilan DeleteIsIlani(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                return null;
            else
            {
                HashChainEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                {
                    entry.Deger = null;
                    entry.Durum = "Silindi";
                    return (Ilan)entry.Deger;
                }
            }
        }
        

        
    }
}