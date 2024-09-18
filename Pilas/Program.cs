using System;

namespace Pilas
{
    internal class Program
    {
        class Stack<T>
        {
            class Node
            {
                public T Value { get; set; }
                public Node Next { get; set; }
                public Node Previous { get; set; }

                public Node(T value)
                {
                    Value = value;  
                    Next = null;
                    Previous = null;
                }
            }
            private Node Head {  get; set; }    
            private Node Top { get; set; }
            private int Count { get; set; }

            public void Push(T value)
            {
                if (Head == null)
                {
                    Node newNode = new Node(value); 
                    Head = newNode;
                    Top = newNode;
                    Count++;
                }
                else
                {
                    Node newNode = new Node(value);
                    newNode.Previous = Top;
                    Top.Next = newNode;
                    Top.Next = newNode;
                    Top = newNode;
                    Count = Count + 1;
                }
            }
            public void Pop()
            {
                if(Head == null)
                {
                    throw new NullReferenceException("No hay nodos para borrar");
                }
                else if(Head == Top)
                {
                    Head = null;
                    Top = null;
                    Count = 0;
                }
                else
                {
                    Node previousNode = Top.Previous;
                    previousNode.Next = null;
                    Top.Previous = null;
                    Top = previousNode; 
                    Count = Count - 1;  
                }
            }
            public void PrintStack()
            {
                Node tmp = Head;
                while (tmp != null)
                {
                    Console.Write(tmp.Value + " - ");
                    tmp = tmp.Next;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            stack.PrintStack();

            Console.ReadLine();
        }
    }
}
