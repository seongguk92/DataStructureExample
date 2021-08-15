using System;
using System.Collections.Generic;

namespace Non_Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Part> parts = new List<Part>();
            parts.Add(new Part() { PartName = "A_Part", PartId = 1 });
            parts.Add(new Part() { PartName = "B_Part", PartId = 2 });
            parts.Add(new Part() { PartName = "C_Part", PartId = 3 });
            parts.Add(new Part() { PartName = "D_Part", PartId = 4 });
            parts.Add(new Part() { PartName = "E_Part", PartId = 5 });

            foreach (Part part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine();
            parts.Contains(new Part { PartName = "", PartId = 6 });
            parts.Insert(2, new Part() { PartName = "F_Part", PartId = 6 });

            foreach (Part part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine();
            parts.Remove(new Part() { PartId = 3, PartName = "C_Part_1" });
            foreach (Part part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine();
            parts.RemoveAt(3);
            foreach (Part part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
