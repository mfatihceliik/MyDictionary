using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is Original Dictionary
            /*Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(06, "Ankara");
            cities.Add(07, "Antalya");
            cities.Add(34, "İstanbul");
            cities.Add(35, "İzmir");

            foreach(KeyValuePair<int, string> city in cities)
            {
                Console.WriteLine("City Id: " + city.Key);
                Console.WriteLine("City: " + city.Value);
                Console.WriteLine("*******");
            }*/

            // My Dictionary
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(06, "Ankara");
            cities.Add(07, "Antalya");
            cities.Add(34, "İstanbul");
            cities.Add(35, "İzmir");

            for (int i = 0; i < cities.Keys.Length; i++)
            {
                Console.WriteLine("City Id: " + cities.Keys[i]);
                Console.WriteLine("City: " + cities.Values[i]);
                Console.WriteLine("***********");
            }
        }

        class MyDictionary<TKey, TValue>
        {
            TKey[] keys;
            TValue[] values;
            public MyDictionary()
            {
                keys = new TKey[0];
                values = new TValue[0];
            }
            public void Add(TKey key, TValue value)
            {
                TKey[] tempKey = keys;
                TValue[] tempValue = values;

                keys = new TKey[keys.Length + 1];
                values = new TValue[values.Length + 1];

                for(int i = 0; i < tempKey.Length; i++)
                {
                    keys[i] = tempKey[i];
                }

                for(int i = 0; i < tempValue.Length; i++)
                {
                    values[i] = tempValue[i];
                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }

            public TKey[] Keys
            {
                get { return keys; }
            }
            public TValue[] Values
            {
                get { return values; }
            }
        }
    }
}
