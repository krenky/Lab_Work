using System;
using System.Collections.Generic;
using System.Text;

namespace Abon_ocon
{
    class Book
    {
        Node_abon First = null;
        public Node_abon Add(string Name_Abonent, Node_abon parent)
        {
            if (parent == null)
            {
                Abon input_Abonent = new Abon(Name_Abonent);
                parent = new Node_abon(input_Abonent);
            }
            else
            {
                parent.right = Add(Name_Abonent, parent.right);
            }
            return parent;
        }
        public Abon Search(string Name_Abonent, Node_abon parent)
        {
            Abon Not = new Abon("Не найден");
            if (parent != null)
            {
                if (parent.abon.Name == Name_Abonent)
                {
                    return parent.abon;
                }
                else
                {
                    Search(Name_Abonent, parent.right);
                }
            }
            else
            {
                Abon Not_found = new Abon("Не найден");
                return Not_found;
            }
            return Not;
        }
        
    }
    class Node_abon
    {
        private Abon _Abon;
        //private Node_abon _left;
        private Node_abon _right;

        public Abon abon
        {
            get
            {
                return _Abon;
            }
            set
            {
                _Abon = abon;
            }
        }
        public Node_abon right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = right;
            }
        }
 
        public Node_abon()
        {
        }
 
        public Node_abon(Abon inputDataNode)
        {
            _Abon = inputDataNode;
        }

        public Node_abon(Abon data, Node_abon right)
        {
            _Abon = data;
            _right = right;
        }
    }
}
