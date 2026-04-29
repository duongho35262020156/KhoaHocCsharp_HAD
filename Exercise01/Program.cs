using System;

public class Program
{
    public static void Main()
    {
        // 1. Cho phép gõ tiếng Việt có dấu
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Exercise 01: Các phép toán cơ bản
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
        // --- BÀI 4: to convert feet to meter ---
        float feet = 10.05f;
        float meter = 0.3048f * feet;
        Console.WriteLine($"4.\tConvert feet to meter: {feet} feet = {meter} meters");
        // --- BÀI 5: to convert Celsius to Fahrenheit and vice versa ---
        float celsius = 25.0f;
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"5.\tConvert Celsius to Fahrenheit: {celsius} Celsius = {fahrenheit} Fahrenheis");
        
        float F1 = 77.0f;
        float C1 = (F1 - 32) * 5 / 9; 
        Console.WriteLine($"5.\tConvert Fahrenheit to us Celsius :{F1} Fahrenheis={C1} Celsius");
        // --- BÀI 6: to find the Size of data types ---
        Console.WriteLine("Kích thước của kiểu int là: " + sizeof(int) + " bytes");
        Console.WriteLine("Kích thước của kiểu float là: " + sizeof(float) + " bytes");
        Console.WriteLine("Kích thước của kiểu double là: " + sizeof(double) + " bytes");
        Console.WriteLine("Kích thước của kiểu char là: " + sizeof(char) + " bytes");
        // --- BÀI 7. to Print ASCII Value ---
        // 1. Thông báo cho người dùng nhập ký tự
        Console.Write("Nhap mot ky tu bat ky: ");

        // 2. Đọc ký tự từ bàn phím
        // Console.ReadKey().KeyChar giúp lấy đúng 1 ký tự duy nhất
        char inputChar = Console.ReadKey().KeyChar;

        // Xuống dòng để kết quả in ra đẹp hơn
        Console.WriteLine();

        // 3. Ép kiểu từ char sang int để lấy mã ASCII
        int asciiValue = (int)inputChar;

        // 4. In kết quả
        Console.WriteLine("Ky tu ban vua nhap la: " + inputChar);
        Console.WriteLine("Gia tri ASCII tuong ung la: " + asciiValue);

        // thuc tap push va commit
        // Giữ màn hình
        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}