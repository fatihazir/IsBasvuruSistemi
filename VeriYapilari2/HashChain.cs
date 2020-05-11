using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class HashChain
    {
        int TABLE_SIZE = 10;

        HashChainEntry[] table;


        public HashChain()
        {
            table = new HashChainEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
            {
                table[i] = null;
            }
        }
        public bool AddIsIlani(int key, object value)
        {
            int hash = (key % TABLE_SIZE);
            string durum = "Aktif";
            bool basarilimi = false;
            if (table[hash] == null)
            {
                table[hash] = new HashChainEntry(key, value, durum);
                basarilimi = true;
                return basarilimi;
            }
            else
            {
                HashChainEntry entry = table[hash];
                if (entry.Durum == "Silindi")
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
                    entry.Next = new HashChainEntry(key, value, durum);
                    basarilimi = true;
                    return basarilimi;
                }
            }
        }
        public IsIlani GetIsIlani(int key)
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
                    return (IsIlani)entry.Deger;
            }
        }

        public IsIlani DeleteIsIlani(int key)
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
                    return (IsIlani)entry.Deger;
                }

            }
        }
    }
}
