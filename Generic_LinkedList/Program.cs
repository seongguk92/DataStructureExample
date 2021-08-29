using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            //끝에 계속 추가
            list.AddLast("Apple");
            list.AddLast("Banana");
            list.AddLast("Lemon");

            LinkedListNode<string> node = list.Find("Banana");
            LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

            //새 Grape 노드를 Banana 노드 뒤에 추가
            list.AddAfter(node, newNode);

            // 리스트 출력
            list.ToList<string>().ForEach(p => Console.WriteLine(p));            

            // Enumerator 리스트 출력
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
