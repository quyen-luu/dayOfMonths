﻿public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập tháng bạn cần kiểm tra ngày: ");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
            Console.WriteLine($"Tháng {month} có 31 ngày.");
            break;
            case 2:
            Console.WriteLine($"Tháng {month} có 28 hoặc 29 ngày.");
            break;
            case 4:
            case 6:
            case 9:
            case 11:
            Console.WriteLine($"Tháng {month} có 30 ngày.");
            break;
            default:
            Console.WriteLine("Vui lòng nhập lại.");
            break;
        }
    }
}