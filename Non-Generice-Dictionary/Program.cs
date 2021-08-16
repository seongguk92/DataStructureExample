using System;
using System.Collections.Generic;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicColor = new Dictionary<string, string>();

            dicColor.Add("Red", "빨강");
            dicColor.Add("Green", "초록");
            dicColor.Add("Blue", "파랑");

            try
            {
                if (dicColor.ContainsKey("Red"))//RED 들어있는지 체크
                {
                    Console.WriteLine($"dicColor[Red] 이미 존재합니다. -> {dicColor["Red"]}");
                }
                else
                {
                    dicColor.Add("Red", "빨강");
                }
                if (!dicColor.ContainsKey("Yellow"))//YELLOW 들어있는지 체크
                {
                    dicColor.Add("Yellow", "노랑");
                }
                foreach (var keyValuePair in dicColor)
                {
                    Console.WriteLine($"dicColor[{keyValuePair.Key}] = {keyValuePair.Value}");
                }

                
                if (dicColor.ContainsKey("Red"))//RED 들어있으면 꺼내기
                {
                    Console.WriteLine($"dicColor[Red] = {dicColor["Red"]}");
                }
                dicColor.Add("Blue", "파랑");//BLUE 들어있는지 체크 (Exception)
                Console.WriteLine($"dicColor[Pink] = {dicColor["Pink"]}");//Yellow 있으면 출력 (Exception)
            }
            catch(Exception ex)
            {
                Console.WriteLine($"error {ex.Message}");
            }
        }
    }
}
