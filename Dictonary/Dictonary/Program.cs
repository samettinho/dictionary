using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> takimlar = new MyDictionary<string>();
            takimlar.Add("Fenerbahce");
            takimlar.Add("Galatasaray");
            takimlar.Add("Besiktas");
            Console.WriteLine(takimlar.Count);
        }
    }
    class MyDictionary <T>
    {
        T[] array;
        T[] temparray;

        public MyDictionary()
        {
            array = new T[0];

        }
        public void Add(T item)
        {
            temparray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < temparray.Length; i++)
            {
                array[i] = temparray[i];
            }
            array[array.Length - 1] = item; 
        }
        public int Count
        {
            get { return array.Length; }
        }
    }
    }
