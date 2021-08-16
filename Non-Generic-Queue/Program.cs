using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new ConcurrentQueue<int>();

            // 데이터를 큐에 넣는 쓰레드
            Task tEnq = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    q.Enqueue(i);
                    Thread.Sleep(1000);
                }
            });


            //데이터를 큐에서 읽는 쓰레드
            Task tDeq = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (q.TryDequeue(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(1000);
                }
            });

            Task.WaitAll(tEnq, tDeq);
        }
    }
}
