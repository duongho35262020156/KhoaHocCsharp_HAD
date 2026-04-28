using System;

public class Program
{
    public static void Main()
    {
        // 1. Cho phép gõ tiếng Việt có dấu
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // --- BÀI 1: TÍNH TỔNG ---
        int a = 12, b = 9;
        Console.WriteLine($"1.\tTổng của {a} và {b} là: {a + b}");

        // --- BÀI 2: HOÁN ĐỔI GIÁ TRỊ ---
        int x = 16, y = 10, temp;
        Console.WriteLine($"2.1\tTrước khi hoán đổi: x = {x}, y = {y}");
        temp = x; x = y; y = temp;
        Console.WriteLine($"2.2\tSau khi hoán đổi: x = {x}, y = {y}");

        // --- BÀI 3: NHÂN SỐ THỰC ---
        float f1 = 1.5f, f2 = 2.5f;
        Console.WriteLine($"3.\tTích hai số thực {f1} * {f2} là: {f1 * f2}");

        // Giữ màn hình
        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}