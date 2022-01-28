using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] tkey;
        TValue[] tvalue;
        public MyDictionary()
        {
            tkey = new TKey[0];
            tvalue = new TValue[0];
        }
        public void Add(TKey tkeyy, TValue tvaluee)
        {
            TKey[] tempKeyArray = tkey;
            tkey = new TKey[tkey.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                tkey[i] = tempKeyArray[i];
            }
            tkey[tkey.Length - 1] = tkeyy;

            TValue[] tempValueArray = tvalue;
            tvalue = new TValue[tempValueArray.Length + 1];
            for (int i = 0; i < tempValueArray.Length; i++)
            {
                tvalue[i] = tempValueArray[i];
            }
            tvalue[tvalue.Length - 1] = tvaluee;
        }

        public TValue[] Valuee
        {
            get { return tvalue; }
        }
        public TKey[] Keyy
        {
            get { return tkey; }
        }
    }
}
