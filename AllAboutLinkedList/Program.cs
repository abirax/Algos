using System;
using System.Collections.Generic;
/// <summary>
/// all about linkedlist, how to add node, how to add node in sorted manner
/// </summary>
namespace AllAboutLinkedList
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int val)
            {
                data = val;
                next = null;
            }
            public void Print()
            {
                Console.Write("|" + data + "|-->");
                if (next != null)
                    next.Print();
            }
            public void AddNode(int val)
            {
                if (next == null)
                    next = new Node(val);
                else
                    next.AddNode(val);
            }
            public void AddSorted(int val)
            {
                if (next == null)
                    next = new Node(val);
                else if (this.next.data > val)
                {
                    Node temp = new Node(val);
                    temp.next = this.next;
                    this.next = temp;
                }
                else
                {
                    if (next == null)
                        next = new Node(val);
                    else
                    next.AddSorted(val);
                }
               
            }
        }
        public class MyList
        {
            public Node head;
            public MyList()
            {
                head = null;
            }
            public void AddToList(int data)

            {
                if (head == null)
                    head = new Node(data);
                else
                    head.AddNode(data);
            }

            public void AddSorted(int val)

            {
                if (head == null)
                    head = new Node(val);
                else if (head.data> val)
                {
                    Node temp = new Node(val);
                    temp.next = head;
                    head = temp;
                }
                else
                    head.AddSorted(val);
            }
            public void PrintList()
            {
                if (head == null)
                    return;
                else
                    head.Print();
            }

            public void RemoveDuplicates(Node root)
            {
                HashSet<int> content = new HashSet<int>();
                Node node = root;
                while (node.next != null)
                {
                    if (content.Contains(node.next.data))
                    {
                        if (node.next.next != null)
                            node.next = node.next.next;
                        else
                            node.next = null;
                        continue;
                    }
                    content.Add(node.next.data);
                    node = node.next;

                }
            }
            }
        static void Main(string[] args)
        {
            Node myNode = new Node(7);
            //new Node(7);
            //myNode.next = new Node(8);
            //myNode.next.next = new Node(10);

            //myNode.AddNode(8);
            //myNode.AddNode(10);
            //myNode.AddNode(5);

            //myNode.AddNode(12);
            //myNode.AddNode(9);
            //myNode.Print();

            myNode.AddSorted(8);
            myNode.AddSorted(10);
            myNode.AddSorted(5);
            myNode.AddSorted(99);
            myNode.AddSorted(6);

            myNode.AddSorted(12);
            myNode.AddSorted(9);
            myNode.Print();

            Console.WriteLine("Above is sorted via node");
            MyList myList = new MyList();
            myList.AddToList(8);
            myList.AddToList(10);
            myList.AddToList(5);

                myList.AddToList(12);
                myList.AddToList(9);

                myList.AddToList(12);
            myList.AddToList(9);

                myList.AddToList(12);

            myList.AddToList(1172);
            myList.AddToList(9);
            myList.AddToList(112);
            myList.AddToList(5);
            myList.AddToList(93);
            myList.AddToList(93);
            myList.AddToList(5);

            myList.PrintList();
                 Console.WriteLine("Above Contains duplicate World!");

                myList.RemoveDuplicates(myList.head);
                myList.PrintList();
                Console.WriteLine("removing duplicates ");
                Console.WriteLine("now comes sorrted");
            MyList myList1 = new MyList();
            myList1.AddSorted(8);
            myList1.AddSorted(10);
            myList1.AddSorted(5);
            myList1.AddSorted(99);
            myList1.AddSorted(12);
            myList1.AddSorted(7);
            myList1.AddSorted(9);
            myList1.PrintList();

            Console.WriteLine("lets comes sorrted");


            Console.ReadLine();

            
        }
    }
}
