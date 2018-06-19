using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.Collections.ArrayList
            //System.Collections.Queue
            //System.Collections.Stack
            //System.Collections.Hashtable

            System.Collections.ArrayList a = new System.Collections.ArrayList();
            a.Add("a");
            a.Add("b");
            a.Add("d");
            a.Insert(2, "c");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("a");
            q.Enqueue("b");
            var kunde = q.Dequeue();

            System.Collections.Stack s = new System.Collections.Stack();
            s.Push("a");
            s.Push("b");
            s.Push("c");
            var t = s.Pop();

            System.Collections.Hashtable h = new System.Collections.Hashtable();
            h.Add("211111", "a");
            h.Add("123432", "b");
            var p = h["211111"];

            System.Collections.ArrayList a2 = new System.Collections.ArrayList();
            a2.Add("a");
            a2.Add(3);
            a2.Add(new DateTime());
            a2.Add(new Hund());

            // <>

            System.Collections.Generic.List<string> l2 = new System.Collections.Generic.List<string>();
            l2.Add("2");
            string v2 = l2[0];

            Console.WriteLine();
            List<Hund> hunde = new List<Hund>();
            hunde.Add(new Hund() { Navn = "a" });
            hunde.Add(new Hund() { Navn = "b" });
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
            for (int i = 0; i < hunde.Count; i++)
            {
                Console.WriteLine(hunde[i].Navn);
            }
            //hunde.Sort();

            Queue<int> q2 = new Queue<int>();
            q2.Enqueue(6);
            q2.Enqueue(1);
            int y = q2.Dequeue();

            Dictionary<string, Hund> d2 = new Dictionary<string, Hund>();
            d2.Add("2121", new Hund());
            Hund h3 = d2["2121"];


        }
    }

    class Hund {
        public string Navn { get; set; }
    }
}
