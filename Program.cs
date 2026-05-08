using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main()
    {
        // Ex4Bai1();
        // Ex4Bai2();
        // Ex4Bai3();
        // Ex4Bai4();
        // Ex4Bai5();
        //static void Ex4Slide21Cau1();
        //static void Ex4Slide21Cau2();
        //static void Ex4Slide21Cau3();
        //Ex4Slide22Cau1();
        //Ex4Slide22Cau2();
        //Ex4Slide22Cau3();
        //Ex4Slide22Cau4();
        Ex4Slide22Cau5();
        //Ex4Slide22Cau6();
        //Ex4Slide22Cau7();
        //Ex4Slide22Cau8();


        static void Ex4Bai1()
        {
            //Write a C# Sharp program that takes two numbers as input and performs an operation(+, -, *, x,/) on them and displays the result of that operation.
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                case "x":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine("The result is: " + result);
        }

        static void Ex4Bai2()
        {
            //Write a C# Sharp program to display certain values of the function x = y2+2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            Console.WriteLine("\nValues of the function x = y^2 + 2y + 1 for y from -5 to 5:");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1; // This is equivalent to (y + 1) * (y + 1)       
                Console.WriteLine($"y: {y}, x: {x}");
            }
        }

        static void Ex4Bai3()
        {
            //Write a C# Sharp program that takes distance and time (hours, minutes,seconds) as input and displays speed in kilometers per hour(km / h) and miles per hour(miles/ h).
            Console.WriteLine("\nEnter distance in kilometers: ");
            double distancekm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in hours: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in minutes: ");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in seconds: ");
            double seconds = Convert.ToDouble(Console.ReadLine());
            double totalHours = hours + (minutes / 60) + (seconds / 3600);
            double speedKmh = distancekm / totalHours;
            double speedMh = speedKmh / 1.609; // Convert km/h to miles/h
            Console.WriteLine($"Speed in km/h: {speedKmh:F2}");
            Console.WriteLine($"Speed in miles/h: {speedMh:F2}");
        }

        static void Ex4Bai4()
        {
            //Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere. V = 4 / 3 * π * r^3
            Console.WriteLine("\nEnter the radius of the sphere: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Surface area: {surface:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
        }
        static void Ex4Bai5()
        {

            //Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.WriteLine("\nEnter a character: ");
            Char inputChar = Console.ReadKey().KeyChar; // Read a single character from the user
            Char lowerChar = Char.ToLower(inputChar); // Convert to lowercase for easier comparison
                                                      // Check if the character is a vowel
            if (lowerChar == 'a' || lowerChar == 'u' || lowerChar == 'e' || lowerChar == 'o' || lowerChar == 'i')
            {
                Console.WriteLine($"\n{inputChar} is a vowel");
            }
            else if (Char.IsDigit(lowerChar))
            {
                Console.WriteLine($"\n{inputChar} is a digit");
            }
            else
            {
                Console.WriteLine($"\n{inputChar} is a symbol");
            }
        }
        //Control flow statements slide 21st
        static void Ex4Slide21Cau1()
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("\n Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            { Console.WriteLine($"\n {number} is an even number"); }
            else { Console.WriteLine($"\n {number} is an odd number"); }
        }
        static void Ex4Slide21Cau2()
        {
            //Write a C# Sharp program to find the largest of three numbers.
            Console.Write("\n Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("\n Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("\n Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            int largest = num1;
            if (num2 > largest)
            {
                largest = num2;
            }
            if (num3 > largest)
            {
                largest = num3;
            }
            Console.WriteLine($"\nThe largest number is: {largest}");
        }
        static void Ex4Slide21Cau3()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.Write("\n Enter the X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("\n Enter the Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            // Kiểm tra logic để xác định vị trí
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0}, {1}) lies in the First quadrant.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0}, {1}) lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point ({0}, {1}) lies in the Third quadrant.", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point ({0}, {1}) lies in the Fourth quadrant.", x, y);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("The coordinate point ({0}, {1}) is at the Origin.", x, y);
            }
            else
            {
                Console.WriteLine("The coordinate point ({0}, {1}) lies on the axis.", x, y);
            }
        }

        static void Ex4Slide22Cau1()
            {
                // Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
                Console.Write("\n Enter the length of the first side: ");
                    double side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Enter the length of the second side: ");
                    double side2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Enter the length of the third side: ");
                    double side3 = Convert.ToDouble(Console.ReadLine());
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("\n The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("\n The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("\n The triangle is Scalene.");
                }

            }
        static void Ex4Slide22Cau2()
        {
            //Write a program to read 10 numbers and find their average and sum.
            int i;
            double n, sum = 0, avg;

            Console.WriteLine("----- Calculate Sum and Average of 10 numbers -----");
            Console.WriteLine("Input the 10 numbers:");

            // Vòng lặp chạy 10 lần để nhận dữ liệu
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} : ", i);
                n = Convert.ToDouble(Console.ReadLine());

                // Cộng dồn vào biến sum
                sum += n;
            }

            // Tính trung bình cộng
            avg = sum / 10.0;

            // Hiển thị kết quả
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("The sum of 10 numbers is : {0}", sum);
            Console.WriteLine("The average is : {0}", avg);
        }
        static void Ex4Slide22Cau3()
        {
            //Write a program to display the multiplication table of a given integer.
            int j, n;

            Console.WriteLine("----- Display the multiplication table -----");
            Console.Write("Input the number (Table to be calculated): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplication table for {0}:", n);

            // Vòng lặp chạy từ 1 đến 10
            for (j = 1; j <= 10; j++)
            {
                // In theo định dạng: số x thứ_tự = kết_quả
                Console.WriteLine("{0} X {1} = {2}", n, j, n * j);
            }
        }
        static void Ex4Slide22Cau4()
        {
            //Write a program to display a pattern like triangles with a number.
            Console.Write("Input number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++) // Vòng lặp hàng
            {
                for (int j = 1; j <= i; j++) // Vòng lặp cột (số lượng số trong hàng)
                {
                    Console.Write(i);
                }
                Console.WriteLine(); // Xuống dòng sau khi in xong một hàng
            }

        }
        static void Ex4Slide22Cau5()
        {
            int n = 4; // Số hàng muốn in
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            };
            int n1 = 4;
            int k1 = 1; // Biến tích lũy tăng dần
            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k1 + " ");
                    k1++;
                }
                Console.WriteLine();
            };
            int n2 = 4;
            int k2 = 1;
            for (int i = 1; i <= n2; i++)
            {
                // 1. Vòng lặp in khoảng trắng (số khoảng trắng giảm dần theo hàng)
                for (int space = 1; space <= n2  - i; space++)
                {
                    Console.Write(" ");
                }

                // 2. Vòng lặp in số (giống hình 2)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k2 + " ");
                    k2++;
                }
                Console.WriteLine();
            };
        }
        static void Ex4Slide22Cau6()
        {
            //Write a program to display the n terms of harmonic series and their sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            int i, n;
            double s = 0.0;

            Console.WriteLine("----- Calculate n terms of Harmonic Series -----");
            Console.Write("Input the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDisplaying the series:");

            for (i = 1; i <= n; i++)
            {
                // In định dạng phân số
                if (i < n)
                {
                    Console.Write("1/{0} + ", i);
                }
                else
                {
                    Console.Write("1/{0}", i);
                }

                // Cộng dồn vào tổng
                // Lưu ý: Phải dùng 1.0 để máy tính hiểu là phép chia số thực
                s += 1.0 / i;
            }

            Console.WriteLine("\n\nSum of Series up to {0} terms: {1:F6}", n, s);

        }
        static void Ex4Slide22Cau7()
        {
            //Write a program to find the ‘perfect’ numbers within a given number range.
            int n, i, j, sum;
            int start, end;

            Console.WriteLine("----- Find Perfect Numbers within a range -----");

            Console.Write("Input starting range: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending range: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe perfect numbers in the given range are:");

            // Vòng lặp duyệt qua từng số trong khoảng từ start đến end
            for (n = start; n <= end; n++)
            {
                sum = 0;

                // Tìm các ước số của n (chạy từ 1 đến n-1)
                for (i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }

                // Nếu tổng các ước bằng chính số đó thì đó là số hoàn hảo
                if (sum == n && n != 0)
                {
                    Console.Write("{0} ", n);
                }
            }
            Console.WriteLine();
        }
        static void Ex4Slide22Cau8()
        {

            int n, i, count = 0;

            Console.WriteLine("----- Check whether a number is prime or not -----");
            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Số nguyên tố phải lớn hơn 1
            if (n <= 1)
            {
                Console.WriteLine("{0} is not a prime number.", n);
                return;
            }

            // Kiểm tra các ước số từ 2 đến căn bậc hai của n
            // Cách viết i * i <= n tương đương với i <= sqrt(n) nhưng chạy nhanh hơn
            for (i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                    break; // Tìm thấy một ước là đủ để kết luận không phải số nguyên tố
                }
            }

            if (count == 0)
                Console.WriteLine("{0} is a prime number.", n);
            else
                Console.WriteLine("{0} is not a prime number.", n);
        }
        }


}