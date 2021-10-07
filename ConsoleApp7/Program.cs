using System;

namespace ConsoleApp7
{
    class Program
    {
        public static void nhapMang(int[] Mang)
        {
            for(int i = 0; i < Mang.Length; i++)
            {
                Console.WriteLine("Nhap vao phan tu thu: " + i);
                Mang[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void xoaPhanTu(int[] Mang, ref int n)
        {
            n--;

            Console.WriteLine("nhap vi tri phan tu muon xoa");
            int x = Int32.Parse(Console.ReadLine());
            while(x < n)
            {
                Mang[x] = Mang[x + 1];
                x++;
            }
        }

        public static void themPhanTu(int[] Mang, ref int n)
        {
            n++;
            Console.WriteLine("nhap vi tri phan tu muon them");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri phan tu");
            int value = Int32.Parse(Console.ReadLine());
            for (int i = Mang.Length - 1; i > x; i--)
            {
                Mang[i] = Mang[i - 1];
            }

            Mang[x] = value;
        }

        static void Main(string[] args)
        {
            int[] Mang;
            Console.WriteLine("Nhap so phan tu trong mang");
            int n = Int32.Parse(Console.ReadLine());
            Mang = new int[n];

            nhapMang(Mang);
            themPhanTu(Mang, ref n);
        }
    }
}
