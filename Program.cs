using System.Diagnostics.CodeAnalysis;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
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
