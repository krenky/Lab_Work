using System;
using System.Collections.Generic;
using System.Text;

namespace Abon_ocon
{
    class Book
    {
        Node_abon First = null;
        public Node_abon Add(Abon input_Abonent, Node_abon parent)
        {
            if (parent == null)
            {
                parent = new Node_abon(input_Abonent);
            }
            else
            {
                parent.right = Add(input_Abonent, parent.right);
            }
            return parent;
        }
        public
    }
    class Node_abon
    {
        private Abon _Abon;
        private Node_abon _left;
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
