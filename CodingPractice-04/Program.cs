using System;

Console.WriteLine();
Console.WriteLine("## 1. 열거형과 switch 문");

Animal animal = Animal.Dog;

switch (animal)
{
    case Animal.Chicken:
        Console.WriteLine("닭");
        break;
    case Animal.Dog:
        Console.WriteLine("개");
        break;
    case Animal.Pig:
        Console.WriteLine("돼지");
        break;
}



Console.WriteLine();
Console.WriteLine("## 2. 캐릭터 상태 관리");

CharacterState status = CharacterState.Idle;
status = CharacterState.Attacking;
Update();

void Update()
{
    switch (status)
    {
        case CharacterState.Idle:
            Console.WriteLine("대기 애니메이션 재생");
            break;
        case CharacterState.Walking:
            Console.WriteLine("걷기 애니메이션 재생");
            break;
        case CharacterState.Attacking:
            Console.WriteLine("공격 애니메이션 재생");
            break;
    }
}



Console.WriteLine();
Console.WriteLine("## 3. 아이템 등급");

PrintItemInfo("전설의 검", ItemRarity.Legendary);

void PrintItemInfo(string name, ItemRarity rarity)
{
    Console.WriteLine($"아이템: {name}");
    Console.WriteLine($"등급: {rarity}"); 
}



Console.WriteLine();
Console.WriteLine("## 4. 방향 처리");

Move(Direction.Up);
Move(Direction.Right);

void Move(Direction direction)
{
    switch (direction)
    {
        case Direction.Up:
            Console.WriteLine("위로 이동 (y + 1)");
            break;
        case Direction.Down:
            Console.WriteLine("아래로 이동 (y - 1)");
            break;
        case Direction.Left:
            Console.WriteLine("왼쪽으로 이동 (x - 1)");
            break;
        case Direction.Right:
            Console.WriteLine("오른쪽으로 이동 (x + 1)");
            break;
    }
}



enum Animal
{
    Chicken,
    Dog,
    Pig
}

enum CharacterState
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}

enum ItemRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

enum Direction
{
    Up,
    Down,
    Left, 
    Right
}