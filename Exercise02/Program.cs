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
  Console.Write ("Câu 3.6\t\tNhập số thứ 1:");
  int soThuNhat = int.Parse(Console.ReadLine());
  Console.Write ("Câu 3.6\t\tNhập số thứ 2:");
  int soThuHai = int.Parse(Console.ReadLine());
  Console.Write ("Câu 3.6\t\tNhập số thứ 3:");
  int soThuBa = int.Parse(Console.ReadLine());
  int tich = soThuNhat * soThuHai * soThuBa;
  Console.WriteLine ($"Tích của 3 số: {soThuNhat} * {soThuHai} * {soThuBa} = {tich}");

 //4.Bài 7. Arithmetic Operations
Console.Write("Input the first number:");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Input the second number:");
int secondNum = int.Parse(Console.ReadLine());
int adding = firstNum + secondNum;
int subtracting = firstNum - secondNum;
int multiplying = firstNum * secondNum;
int dividing = firstNum / secondNum;
int modding = firstNum % secondNum;
    
Console.WriteLine ($"Phép cộng: {firstNum} + {secondNum} = {adding}");
Console.WriteLine ($"Phép trừ: {firstNum} - {secondNum} = {subtracting}");
Console.WriteLine ($"Phép nhân: {firstNum} * {secondNum} = {multiplying}");
Console.WriteLine ($"Phép chia: {firstNum} / {secondNum} = {dividing}");
Console.WriteLine ($"Số dư: {firstNum} mod {secondNum} = {modding}");

//5.Bài 8. Multiplication Table
Console.Write ("Enter a number: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i <= 10; i++)
{Console.WriteLine ("{0} * {1,2} = {2,2}",n,i,n*i);
 }
//6.Bài 9. Average of Four Numbers
Console.Write("Input the first number:");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Input the second number:");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Input the third number:");
int n3 = int.Parse(Console.ReadLine());
Console.Write("Input the fourth number:");
int n4 = int.Parse(Console.ReadLine());
int average = (n1 + n2 + n3 + n4 )/4;
Console.WriteLine ($"The average of {n1}, {n2}, {n3}, {n4} is {average}");

//7.Bài 10. Specified Formula with Three Numbers
Console.Write("Enter the first number x=");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter the second number y=");
int y = int.Parse(Console.ReadLine());
Console.Write("Enter the third number z=");
int z = int.Parse(Console.ReadLine());
int result1 = (x+y)*z;
int result2 = x*y + y*z;
Console.WriteLine ($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");

//8.Bài 11. Print Age Message
Console.Write ("Enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"You look younger than {age}");

//9.Bài 12. Repeat Number in Rows
Console.Write ("Enter a number: ");
int d = int.Parse(Console.ReadLine());
Console.WriteLine ("{0} {0} {0} {0}",d);
Console.WriteLine ("{0}{0}{0}{0}",d);
Console.WriteLine ("{0} {0} {0} {0}",d);
Console.WriteLine ("{0}{0}{0}{0}",d);

//10.Bài 13. Rectangle Pattern with Number
Console.Write("Enter a number: ");
int nb = int.Parse(Console.ReadLine());
Console.WriteLine("{0}{0}{0}", nb);
for (int i = 0; i < 3; i++)
    { Console.WriteLine("{0} {0}", nb);
        }
Console.WriteLine("{0}{0}{0}", nb);
  
}
}
