using System;
using System.Collections.Generic;
using System.Text;

namespace DDTree
{
    class Dtree
    {
        private DTreeNode root;
        public DTreeNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public Dtree()
        {
            root = null;
        }
        public DTreeNode DFind(int key, DTreeNode root)
        {
            DTreeNode a;
            if (root == null) a = null;
            {
                if (key < root.Key) a = DFind(key, root.Left);
                else if (key > root.Key) a = DFind(key, root.Right);
                else a = root;
            }
            return a;
        }
        public DTreeNode InsertFind(int key, DTreeNode root)
        {
            if (root != null)
            {
                if (key < root.Key) root.Left = InsertFind(key, root.Left);
                else if (key > root.Key) root.Right = InsertFind(key, root.Right);
            }
            else
            {
                char a;
                char.TryParse(Console.ReadLine(), out a);
                root = new DTreeNode(a, key, null, null);
            }
            return root;
        }


    }
}
