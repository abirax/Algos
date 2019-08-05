using System;

namespace SearchInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree tree = new Tree();
            Node root = null;
            int[] values = { 1, 7, 85, 5, 67, 74, 78, 4, 67 };
            foreach (int val in values)
                root=tree.Insert(root, val);

            tree.Traverse(root);
            Console.ReadKey();

        }
    }
    class Tree
    {
        public Node Insert(Node root,int value)
        {
            if (root==null)
            {
                root =new Node(value);
                
            }
            else if(value>root.data)
            {
                root=Insert(root.right, value);
            }
            else
            {
                root = Insert(root.left, value);
            }
            return root;
        }

        public void Traverse(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(" " + root.data.ToString());
            Traverse(root.left);
            Traverse(root.right);

        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
        }

    }


}
