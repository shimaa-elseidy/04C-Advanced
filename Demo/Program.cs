using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTables category overview
            // Collection :: Built in data structure in C#
            // Hashtables 
            #endregion
            #region Non-Generic Collection - Hashtable
            // Non-Generic Collection - Hashtable
            // key must be unique - not null
            //Hashtable ht = new Hashtable();
            //ht.Add("ahmed", 3);
            //ht.Add("ali", 5);  // maynf3sh a3ml repeat ll key
            //ht.Add("shimaa", 0);
            //ht.Add("amr", 33);
            //ht.Add(33, 2);
            //Console.WriteLine(ht.Count); // 5
            //Console.WriteLine(ht.IsFixedSize); // false // dynamic
            //Console.WriteLine(ht.IsReadOnly); // false
            //ht["shimaa"] = 44;// assign new value aw law msh mawgood b set as new key & value
            //Console.WriteLine(ht[33]); // this[] ==> take key and return value
            //ht.Remove(null);// law b3tlha null ---> exception
            //foreach (DictionaryEntry item in ht) // bucket -> private so i used DictionaryEntry 
            //{
            //    Console.WriteLine($"{item} ");
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Generic Collection [ Dictionary ]
            //Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            //PhoneBook.Add("shimaa", 015678009098765);
            //PhoneBook.Add("ali", 0108996754009);
            //// PhoneBook.Add(null, 015678009098765);// exception
            //bool flag = PhoneBook.Remove("ali", out long result);// law el key mawgood hay3ml remove we b3deen hy assign el value ll result 
            //Console.WriteLine(result);// 108996754009
            //Console.WriteLine(flag); // true
            //foreach (KeyValuePair<string,long> item in PhoneBook)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
