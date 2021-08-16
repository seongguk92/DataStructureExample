using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ConcurrentStack<int>();

            // 데이터를 스택에 넣는 쓰레드
            Task tPush = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    s.Push(i);
                    Thread.Sleep(100);
                }
            });

            // 데이터를 스택에서 읽는 쓰레드
            Task tPop = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (s.TryPop(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(150);
                }
            });

            // 두 쓰레드가 끝날 때까지 대기
            Task.WaitAll(tPush, tPush);
        }
    }
}
