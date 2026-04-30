using System;
public class Program
{public static void Main()
    {
  // 1. Cho phép gõ tiếng Việt có dấu
    Console.OutputEncoding = System.Text.Encoding.UTF8;
  //Exercise 02: Chọn 20 bài trong basic exercise
  //1.Bài 1. Print Hello and Name --- Write a C# Sharp program to print Hello and your name in a separate line.
  string name = "Ánh Dương";
  Console.WriteLine ($"Câu 1.1\tPrint Hello and Name in separate line: \n\t\tHello \n\t\t{name}");
  //2.Bài 4. Specified Operations Results
  int ketQua1 = -1 + 4 * 6;
  int ketQua2 = (35+ 5 ) % 7;
  int ketQua3 = 14 + -4 * 6 / 11;
  int ketQua4 = 2 + 15 / 6 * 1 - 7 % 2;
  
  Console.WriteLine ($"Câu 2.4.1\t {ketQua1}");
  Console.WriteLine ($"Câu 2.4.2\t {ketQua2}");
  Console.WriteLine ($"Câu 2.4.3\t {ketQua3}");
  Console.WriteLine ($"Câu 2.4.4\t {ketQua4}");

  //3.Bài 6. Multiply Three Numbers
  Console.Write ("Nhập số thứ 1:");
  
}
}
