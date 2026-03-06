using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine();
Console.WriteLine("## 1. 열거형을 사용한 조건 분기");

Priority priority = Priority.High;

if (priority == Priority.High)
{
    Console.WriteLine("높은 우선순위");
}



Console.WriteLine();
Console.WriteLine("## 2. 열거형 변수 선언과 비교");

Animal animal = Animal.Tiger;

Console.WriteLine(animal);
if(animal == Animal.Tiger)
{
    Console.WriteLine("호랑이");
}



Console.WriteLine();
Console.WriteLine("## 3. 열거형 항목에 특정 값 지정");

Console.WriteLine($"Red: {(int)Color.Red}, Green: {(int)Color.Green}, Blue: {(int)Color.Blue}");



Console.WriteLine();
Console.WriteLine("## 4. 기반 타입 지정");

Console.WriteLine(sizeof(SmallEnum));



Console.WriteLine();
Console.WriteLine("## 5. Enum.GetNames - 열거형 이름 목록");

Console.WriteLine("ConsoleColor 열거형의 색상들:");
foreach(string name in Enum.GetNames(typeof(ConsoleColor)))
{
    Console.WriteLine(name);
}


Console.WriteLine();
Console.WriteLine("## 6. Enum.Parse - 문자열을 열거형으로 변환");

ConsoleColor parsedColor = Enum.Parse<ConsoleColor>("Red");

Console.ForegroundColor = parsedColor;
Console.WriteLine("빨간색 텍스트");
Console.ResetColor();
Console.WriteLine("기본 색상 텍스트");



Console.WriteLine();
Console.WriteLine("## 7. Enum.TryParse - 안전한 문자열 변환");

Direction direction;
if(Enum.TryParse<Direction>("Up", out direction))
{
    Console.WriteLine($"변환 성공: {direction}");
}

if(Enum.TryParse<Direction>("Forward", out direction))
{
    Console.WriteLine($"변환 성공: {direction}");
}
else
{
    Console.WriteLine("'Forward'은(는) 유효하지 않은 값");
}



Console.WriteLine();
Console.WriteLine("## 8. Enum.IsDefined - 값 유효성 검사");

Console.WriteLine($"1은 유효한 Animal 값인가? {Enum.IsDefined(typeof(Animal), 1)}");
Console.WriteLine($"100은 유효한 Animal 값인가? {Enum.IsDefined(typeof(Animal), 100)}");
Console.WriteLine($"'Tiger'는 유효한 Animal 값인가? {Enum.IsDefined(typeof(Animal), "Tiger")}");



Console.WriteLine();
Console.WriteLine("## 9. 열거형과 정수 간 변환");

Console.WriteLine($"Right = {(int)Direction.Right}");
Console.WriteLine($"2 = {(Direction)2}");



Console.WriteLine();
Console.WriteLine("## 10. 정의되지 않은 정수를 열거형으로 변환");

Animal animal1 = (Animal)100;
Console.WriteLine(animal1);



enum Priority
{
    Low,
    Medium,
    High
}

enum Animal
{
    Mouse,
    Cow,
    Tiger
}

enum Color
{
    Red = 10,
    Green,
    Blue=20
}


enum SmallEnum : Byte
{
    Left,
    Right,
    Top,
    Bottom
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}