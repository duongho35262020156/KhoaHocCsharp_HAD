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
    {Console.WriteLine ("{0} * {1,2} = {2,2}",n,i,n*i);}
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
    
//11.Bài 15. Remove Character by Index
    string h = "w3resource";
    string h1 = h.Remove(1,1);
    string h2 = h.Remove(9,1);
    string h3 = h.Remove(0,1);
    Console.WriteLine (h1);
    Console.WriteLine (h2);
    Console.WriteLine (h3);

//12.Bài 16. Swap First and Last Characters
    string chuoi1 = "w3resource";
        string firstChar1 = chuoi1.Substring(0,1);
        string lastChar1 = chuoi1.Substring(9,1);
        string middlePart1 = chuoi1.Substring(1,8);
    Console.WriteLine ($"Swap First and Last Characters of {chuoi1} is {lastChar1}{middlePart1}{firstChar1}");
    string chuoi2 = "Python";
        string firstChar2 = chuoi2.Substring(0,1);
        string lastChar2 = chuoi2.Substring(5,1);
        string middlePart2 = chuoi2.Substring(1,4);
    Console.WriteLine ($"Swap First and Last Characters of {chuoi2} is {lastChar2}{middlePart2}{firstChar2}");

//13.Bài 17. Add First Character to Front and Back
    string str = "The quick brown fox jumps over the lazy dog.";
    string firstStr = str.Substring(0,1);
    Console.WriteLine ($"Add First Character to Front and Back of \"{str}\" is: {firstStr}{str}{firstStr}");

//14.Bài 18. Check Positive and Negative Pair
        Console.WriteLine("Input first integer:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int second = int.Parse(Console.ReadLine());

        bool result = (first < 0 && second > 0) || (first > 0 && second < 0);

        Console.WriteLine("Check if one is negative and one is positive:");
        Console.WriteLine(result);

//15.Bài 19. Sum or Triple Sum of Integers
        Console.WriteLine("Input first integer:");
        int firstIn = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int secondIn = int.Parse(Console.ReadLine());
        int sumIn = firstIn + secondIn;
        if ( firstIn == secondIn )
            {Console.WriteLine (sumIn * 3);
            }
        else { Console.WriteLine (sumIn);}

//16.Bài 20. Absolute Difference or Double It
    Console.WriteLine("Input first integer:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int num2 = int.Parse(Console.ReadLine());
        int absDiff = Math.Abs (num1 - num2);
        if ( num1 > num2 )
            {Console.WriteLine (absDiff * 2);
            }
        else { Console.WriteLine (absDiff);}

//17.Bài 21. Check for 20 or Sum Equals 20
Console.WriteLine("Input first integer:");
        int numb1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int numb2 = int.Parse(Console.ReadLine());
        bool ketQua = (numb1 == 20) || (numb2 == 20) || (numb1+numb2 == 20); 
        
        Console.WriteLine(ketQua);
//18.Bài 22. Check Within 20 of 100 or 200
    Console.Write("Input an integer: ");
int n = int.Parse(Console.ReadLine());

// Kiểm tra khoảng cách từ n đến 100 có <= 20 HOẶC từ n đến 200 có <= 20 không
bool result = Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20;

Console.WriteLine(result);

//19.Bài 23. Convert String to Lowercase
string input = "WRITE A C# SHARP PROGRAM TO DISPLAY THE FOLLOWING PATTERN USING THE ALPHABET.";

// Chuyển toàn bộ chuỗi sang chữ thường
string lowercaseResult = input.ToLower();

Console.WriteLine(lowercaseResult);
  
//20.Bài 24. Find Longest Word in String
string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
        
        // Bước 1: Tách chuỗi thành mảng các từ
        string[] words = line.Split(' ');

        // Bước 2: Biến để lưu trữ từ dài nhất
        string longestWord = "";

        // Bước 3: Duyệt qua từng từ trong mảng
        foreach (string word in words)
        {
            // Nếu độ dài từ hiện tại lớn hơn độ dài từ dài nhất đã biết
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
        
}
 
}
