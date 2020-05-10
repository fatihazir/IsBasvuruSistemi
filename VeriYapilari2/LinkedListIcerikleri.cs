﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public abstract class LinkedListIcerikleri
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(string value);
        public abstract void InsertLast(string value);
        public abstract void InsertPos(int position, string value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract Node GetElement(int position);

        public abstract string DisplayElements();
    }
}
