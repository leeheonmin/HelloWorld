using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text.Json.Serialization.Metadata;

namespace HelloWorld;

class Program
{   
    static void Main(string[] args)
    {
        // Study0918();

        // 스택 오버플로우 에러
        Test();

    }

    static void Test()
    {
        Test();
    }
    static void Study0918()
    {
        // Data type
        // 정수 
        int value = int.MaxValue; // MinValue

        Console.WriteLine(value);

        Console.WriteLine(char.MaxValue + " " + char.MinValue);

        // 크기
        Console.WriteLine(sizeof(int) + " " + sizeof(char) + " " + sizeof(bool));

        String str = "abc deg";
        Console.WriteLine(str.Length);
    }
    static int a;
    static void Study0917()
    {
        // 정수 
        int score = default(int);
        Console.WriteLine("int :" + score);

        // 문자열
        string name = default(string);
        Console.WriteLine("string : " + name);

        // bool
        bool isStudent = default(bool); 
        Console.WriteLine("boolean : " + isStudent);

        // 문자
        char alpha = default(char);
        Console.WriteLine("char : " + alpha);
        Console.WriteLine(alpha == '?'); // (int)'?'); // (int)alpha);

        // if (isStudent == true) 
        if (!isStudent)
            Console.WriteLine("학생 맞음");
        else if (isStudent == false) 
            Console.WriteLine("학생 아님");

        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(" " + i);
        }
            
    }
    static void Study0916(int num)
    {
         for (int i = 1; i < num; i++)
        {
            // 왼쪽 공백
            for (int j = 0; j < num - i - 1; j++)
            {
                Console.Write(" ");
            }

            // 왼쪽 별
            for (int j = 0; j < i * 2 + 1; j++)
            {
                Console.Write("*");
            }

            // 가운데 공백
            for (int j = 0; j < (num - i - 1) * 2 + 1; j++)
            {
                Console.Write(" ");
            }

            // 오른쪽 별
            for (int j = 0; j < i * 2 + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // 하트 아랫부분
        for (int i = 0; i < num * 2; i++)
        {
            // 왼쪽 공백
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            // 별
            for (int j = 0; j < num * 4 - 1 - i * 2; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
    static void Study0915()
    {
        // C샵 프로젝트 만들기
        // 1. 프로젝트 이름으로 폴더를 만든다
        // 2. VS CODE를 연다
        // 3. Terminal > Dotnet new console --use-Program-Main
        // 4. [프로젝트명.csproj]와 [Program.cs] 파일이 생성된다.
        // 5. Github desktop > new Repository로 github에 올린다.

        // Console.WriteLine("Hello, World!"+"\n" + DateTime.Now);

        // 할당
        int age = 5;
        int ageNext = 0;
        // 비교
        // int ageNext = Console.Read();

        // if(age > ageNext)
        // {
        //     Console.WriteLine("나이가 더 많다");
        // } else if(age == ageNext)
        // {
        //     Console.WriteLine("나이가 같다.");
        // } else
        // {
        //     Console.WriteLine("나이가 더 작다.");
        // }
        // 반복
        for (int i = 0; i < 5; i++)
        {
            ageNext = ageNext + 2;
            Console.WriteLine(ageNext);
        }

        // int i = 0;
        // while(true)
        // {
        //     ageNext = ageNext + 2;
        //     Console.WriteLine(ageNext);
            
        //     i++;
        //     if (i >= 5)
        //         break;
            
        // }

        // Console.WriteLine(age);

    }
}
