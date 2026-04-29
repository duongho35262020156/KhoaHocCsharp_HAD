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
        Console.WriteLine("6.1\tKích thước của kiểu int là: " + sizeof(int) + " bytes");
        Console.WriteLine("6.2\tKích thước của kiểu float là: " + sizeof(float) + " bytes");
        Console.WriteLine("6.3\tKích thước của kiểu double là: " + sizeof(double) + " bytes");
        Console.WriteLine("6.4\tKích thước của kiểu char là: " + sizeof(char) + " bytes");
        
        // --- BÀI 7. to Print ASCII Value ---
        // 1. Thông báo cho người dùng nhập ký tự
        Console.Write("7.\tNhap mot ky tu bat ky: ");
        // 2. Đọc ký tự từ bàn phím
        // Console.ReadKey().KeyChar giúp lấy đúng 1 ký tự duy nhất
        char inputChar = Console.ReadKey().KeyChar;
        // 3. Ép kiểu từ char sang int để lấy mã ASCII
        int asciiValue = (int)inputChar;
        // 4. In kết quả
        Console.WriteLine("\n7.1\tKy tu ban vua nhap la: " + inputChar);
        Console.WriteLine("7.2\tGia tri ASCII tuong ung la: " + asciiValue);
        
        // --- BÀI 8: to find the area of a circle ---
        float radius = 5.0f;
        float pi = (float)Math.PI; // Sử dụng Math.PI để lấy giá trị chính xác của π
        float area = (float)(pi * Math.Pow(radius, 2));
        Console.WriteLine($"8.\tDiện tích hình tròn có bán kính r = {radius} là {area}");
        
        // --- BÀI 9: to Calculate Area of Square ---
        float side = 4.0f;
        float areaSquare = side * side;
        Console.WriteLine($"9.\tDiện tích hình vuông có cạnh = {side} là {areaSquare}");

        // --- BÀI 10: to convert days to years, weeks and days ---
        int ngay = 400;
        int nam = ngay / 365;
        int remainingDays = ngay % 365;
        int tuan = remainingDays / 7;
        int finalDay = remainingDays % 7;
        Console.WriteLine($"10.\t{ngay} ngày bằng {nam} năm, {tuan} tuần, {finalDay} ngày");

    }
}