﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class HashChainEntry
    {
        private string durum;

        private int anahtar;

        private object deger;

        private HashChainEntry next;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }

        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }


        public HashChainEntry Next
        {
            get { return next; }
            set { next = value; }
        }


        public HashChainEntry(int anahtar, object deger, string durum)
        {
            this.anahtar = anahtar;
            this.durum = durum;
            this.deger = deger;
            this.next = null;
        }
    }
}