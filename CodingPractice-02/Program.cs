using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine();
Console.WriteLine("## 1. 열거형의 기본 값");

Console.WriteLine($"Animal.Dragon: {(int)Animal.Dragon}, {Animal.Dragon}");



Console.WriteLine();
Console.WriteLine("## 2. Enum.GetValues - 열거형 값 목록");

Console.WriteLine("Priority 열거형의 값들:");

foreach (var priority in Enum.GetValues(typeof(Priority)))
{
    Console.WriteLine($"{priority} = {(int)priority}");
}



enum Animal
{
    Rabbit,
    Dragon,
    Horse
}

enum Priority
{
    High=1,
    Medium=5,
    Low=10,
}