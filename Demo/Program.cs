using System.Collections;
using Demo.FIFA;
using Demo.Youtube;

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
            #region Generic Collection - HashSet
            // Generic Collection - HashSet
            //HashSet<string> names = new HashSet<string>();
            //names.Add("shimaa");
            //names.Add("shimaa"); // hashSet bt ignore el repeat
            //names.Add("fatona");
            //names.Add("esraa");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region Generic Collection - Sorted DS - SortedDictionary
            //SortedDictionary<int, string> pairs = new SortedDictionary<int, string>();
            //pairs.Add(1, "shimaa");//1
            //pairs.Add(99, "ali");//4
            //pairs.Add(3, "shimaa");//2
            //pairs.Add(9, "shimaa");//3
            //foreach (KeyValuePair<int, string> item in pairs)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Generic Collection - Sorted DS - SortedList - SortedSet
            //SortedList<int, string> pairs = new SortedList<int, string>();
            //pairs.Add(3, "shimaa");
            //var item = pairs.GetKeyAtIndex(0);
            //Console.WriteLine(item);// 3
            //pairs.SetValueAtIndex(0, "salah");


            //SortedSet<int> values = new SortedSet<int>();
            //values.Add(1);
            //values.Add(2);

            #endregion
            #region Event Overview
            // Delegate :: C# feature 
            // Event :: functions related to another functions called automatically
            // 1. Functional programming 
            // 2. Event driven programming
            #endregion
            #region Event EX01
            //Ball ball = new Ball() { Id = 1};
            //Console.WriteLine(ball); // id: 1 , Location:  (0 , 0 , 0)
            //ball.Location = new location() { X = 3, Y = 5 , Z = 4};
            //Console.WriteLine(ball); // id: 1 , Location:  (3 , 5 , 4)

            //Player P01 = new Player() { name = "Messi" , teamName = "Miami"} ;
            //Player P02 = new Player() { name = "Alba"  , teamName = "Miami" };
            //Player P03 = new Player() { name = "Pedri" , teamName = "Barcelona" };
            //Player P04 = new Player() { name = "Gavi"  , teamName  = "Barcelona" };
            //Refree R01 = new Refree() { name = "Ibrahim Nour El-Din" };
            //Coach  C01 = new Coach() { name = "Flek", teamName = "Barcelona" };
            //ball.Players.Add(P01);
            //ball.Players.Add(P02);
            //ball.Players.Add(P03);
            //ball.Players.Add(P04);
            //ball.refrees.Add(R01);


            // Event btcreate fe Run Time :: invocation list (-=)(+=)

            //ball.BallLocationChanges += P01.Run;
            //ball.BallLocationChanges += P02.Run;
            //ball.BallLocationChanges += P03.Run;
            //ball.BallLocationChanges += P04.Run;
            //ball.BallLocationChanges += R01.look;
            //ball.BallLocationChanges += C01.Order;
            //ball.Location = new location() { X = 1, Y = 3, Z = 4 };
            //Console.WriteLine(ball);
            #endregion
            #region Event EX02
            //Channel channel = new Channel() { Title="ABC"};
            //channel.AddVideo(new video() { Title = "Title011"  , Description = "Des01" });
            //Subscribers S01 = new Subscribers() { Name = "SHIMAA"};
            //Subscribers S02 = new Subscribers() { Name = "Ali" };
            //Subscribers S03 = new Subscribers() { Name = "Fatema" };
            //Subscribers S04 = new Subscribers() { Name = "Aesha" };
            //channel.UploadVideo += S01.Notify;
            //channel.UploadVideo += S02.Notify;
            //channel.UploadVideo += S03.Notify;
            //channel.UploadVideo += S04.Notify;

            //channel.AddVideo(new video() { Title = "Title011", Description = "Des01" });
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~After Making UnSubscribe~~~~~~~~~~~~~~~~~~~~");
            //channel.UploadVideo -= S01.Notify;
            //channel.AddVideo(new video() { Title = "Title011", Description = "Des01" });
            #endregion
        }
    }
}
