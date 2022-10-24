using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class mydictionary<K,V>
    {
        V[] v;
        K[] k;
       
        public mydictionary()
        {
            k = new K[0];
            v = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] ktemparray = k;
            k = new K[k.Length+1];
            V[] vtemparray = v;
            v = new V[v.Length + 1];
            for (int i = 0; i <ktemparray.Length; i++)
            {
               
                k[i] = ktemparray[i];
                v[i] = vtemparray[i];
            }
            v[v.Length - 1] = value;
            k[k.Length - 1] = key;

        }
        public int Length
        {
            get { return v.Length; }
          
        }

    }
}
