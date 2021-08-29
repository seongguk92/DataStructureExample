using System;
using System.Collections.Generic;

namespace Generic_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. 키가 숫자일 경우 숫자 정렬

            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(1, "One");
            sortedList1.Add(2, "Two");
            sortedList1.Add(4, "Four");

            foreach (KeyValuePair<int, string> kvp in sortedList1)
            {
                Console.WriteLine($"{kvp.Key} / {kvp.Value}");
            }

            foreach (var kvp in sortedList1)
            {
                Console.Write("{0, -10} ", kvp);
            }
            Console.WriteLine();

            #endregion

            #region 2. 키가 문자일 경우 문자정렬

            SortedList<string, int> sortedList2 = new SortedList<string, int>();
            sortedList2.Add("Three", 3);
            sortedList2.Add("One", 1);
            sortedList2.Add("Two", 2);
            sortedList2.Add("Four", 4);

            foreach (KeyValuePair<string, int> kvp in sortedList2)
            {
                Console.WriteLine($"{kvp.Key} / {kvp.Value}");
            }

            foreach (var kvp in sortedList2)
            {
                Console.Write("{0, -10} ", kvp);
            }
            Console.WriteLine();

            #endregion

            #region 3. TryGetValue 함수 사용

            SortedList<string, int> sortedList3 = new SortedList<string, int>();
            sortedList3.Add("Three", 3);
            sortedList3.Add("One", 1);
            sortedList3.Add("Two", 2);
            sortedList3.Add("Four", 4);

            int val;
            if(sortedList3.TryGetValue("Ten", out val))
            {
                Console.WriteLine($"key : Ten, value : {val}");
            }
            else
            {
                Console.WriteLine("[Ten] : key is not valid");
            }

            if(sortedList3.TryGetValue("One", out val))
            {
                Console.WriteLine($"key : One, value : {val}");
            }

            #endregion

            #region 4. 매개변수를 키로 하는 요소 / 매개변수를 값으로 하는 요소

            SortedList<string, int> sortedList4 = new SortedList<string, int>();
            sortedList4.Add("Three", 3);
            sortedList4.Add("One", 1);
            sortedList4.Add("Two", 2);
            sortedList4.Add("Four", 4);

            //매개변수를 키로
            Console.WriteLine(sortedList4.ContainsKey("One"));
            Console.WriteLine(sortedList4.ContainsKey("Ten"));
            //매개변수를 값으로
            Console.WriteLine(sortedList4.ContainsValue(2));
            Console.WriteLine(sortedList4.ContainsValue(6));

            #endregion  

            #region 5. 삭제하는 법

            SortedList<string, int> sortedList5 = new SortedList<string, int>();
            sortedList5.Add("Three", 3);
            sortedList5.Add("One", 1);
            sortedList5.Add("Two", 2);
            sortedList5.Add("Four", 4);

            sortedList5.Remove("Three");//키가 "Three" 삭제
            sortedList5.RemoveAt(0);//첫번째 요소

            foreach (KeyValuePair<string, int> kvp in sortedList5)
            {
                Console.Write("{0, -10} ", kvp);
            }

            Console.WriteLine();

            #endregion  
        }
    }
}
