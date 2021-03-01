using System;
using System.Collections.Generic;
using System.Text;

namespace Hesh
{
    class Hesh_table
    {
        private const int V = 10;
        private List<string>[] Table = new List<string>[V];
        private int Key;
        private int Count = 0;

        public Hesh_table()
        {
            Key = V;
            for (int i = 0; i < Table1.Length; i++)
            {
                Table1[i] = new List<string>();
            }
        }
        public Hesh_table(int key)
        {
            Key = key;
        }

        public List<string>[] Table1 { get => Table; set => Table = value; }

        public int Key1 { get => Key; set => Key = value; }
        public int Count1 { get => Count; set => Count = value; }

        public void AddItem(string Item)
        {
            int SumItem = Hesh_Fun(Item);            
            if(Count*2 < Table.Length)
            {
                if (Table[SumItem] == null)
                {
                    Table[SumItem].Insert(Table1[SumItem].Count-1, Item);
                    Count++;
                }  // развилка если ячейка занята
                else
                {
                    /*for(int i = 0; i < V/2; i++)
                    {
                        if(Table[Hesh_Fun(Item, i)] == null)
                        {
                            Table[Hesh_Fun(Item, i)] = Item;
                            break;
                        }
                    }*/
                    Table1[SumItem].Add(Item);
                }
            } // развилка если закончится массив
            else
            {
                Array.Resize(ref Table, Table.Length*2);
                if (Table[SumItem] == null)
                {
                    Table[SumItem].Insert(Table1[SumItem].Count - 1, Item);
                    Count++;
                }
                else
                {
                    for (int i = 0; i < V / 2; i++)
                    {
                        if (Table[Hesh_Fun(Item, i)] == null)
                        {
                            Table[Hesh_Fun(Item, i)].Insert(Table1[Hesh_Fun(Item, i)].Count - 1, Item);
                            break;
                        }
                    }
                }
            }
        }
        public int Hesh_Fun(string Item)
        {
            int Hash = 0;
            foreach (int i in Item)
            {
                Hash = Hash + i;
            }
             return Hash % V;
        }
        public int Hesh_Fun(string Item, int Index)
        {
            int Hash = 0;
            foreach (int i in Item)
            {
                Hash = Hash + i;
            }
            Hash = ((Hash + Index) % V);
            return Hash;
        }
        public bool Search(string Item)
        {
            /*if (Table[Hesh_Fun(Item)] == Item)
            {
                return true;
            }
            else
            {
                for(int i = 0; i < Table.Length; i++)
                {
                    if (Hesh_Fun(Item, i) < Table.Length)
                    {
                        if (Table[Hesh_Fun(Item, i)] == Item)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }*/
            if (Table1[Hesh_Fun(Item)].Contains(Item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Out()
        {
            /*string Str = "";
            for(int i = 0; i < Table.Length; i++)
            {
                if (Table[i] != null)
                {
                    Str = Str + "|| " + Table[i] + " ";
                }
            }
            return Str;*/
            string Ot = "";
            foreach(List<string> i in Table1)
            {
                foreach(string it in i)
                {
                    Ot = Ot + "||" + it;
                }
                Console.WriteLine(Ot);
                Ot = "";
            }
        }
    }
}
