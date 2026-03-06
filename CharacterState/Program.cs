using System;

Console.WriteLine("=== 캐릭터 상태 관리 ===");

int input = 0;
CharacterState characterState = CharacterState.Idle;

while(input != 4)
{
    Console.WriteLine($"현재 상태: {characterState}");
    Console.WriteLine();

    Console.WriteLine("1. 상태 변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");
    Console.Write("선택: ");
    string inputString = Console.ReadLine();

    if(int.TryParse(inputString, out input))
    {
        Console.WriteLine();

        if (!Enum.IsDefined(typeof(MainMenuInput), input))
        {
            Console.WriteLine("잘못된 입력입니다.");
            Console.WriteLine();
            continue;
        }

        switch ((MainMenuInput)input)
        {
            case MainMenuInput.ChangeStatus:
                Console.Write($"변경할 상태 번호 입력 (0-{Enum.GetValues(typeof(CharacterState)).Length-1}): ");
                
                int changeStatus;
                string changeStatusInput = Console.ReadLine();

                if(int.TryParse(changeStatusInput, out changeStatus))
                {
                    if (!Enum.IsDefined(typeof(CharacterState), changeStatus))
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.WriteLine();
                        continue;
                    }

                    characterState = (CharacterState)changeStatus;
                    Console.WriteLine($"상태가 {characterState}(으)로 변경되었습니다.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                    continue;
                }

                break;

            case MainMenuInput.ShowStatusList:
                Console.WriteLine("=== 상태 목록 ===");
                foreach(CharacterState state in Enum.GetValues(typeof(CharacterState)))
                {
                    Console.WriteLine($"{state} = {(int)state}");
                }
                break;

            case MainMenuInput.ShowCurrentStatus:

                switch (characterState)
                {
                    case CharacterState.Idle:
                        Console.WriteLine("[행동] 아무것도 하지 않습니다!");
                        break;
                    case CharacterState.Walking:
                        Console.WriteLine("[행동] 걷습니다!");
                        break;
                    case CharacterState.Running:
                        Console.WriteLine("[행동] 뜁니다!");
                        break;
                    case CharacterState.Jumping:
                        Console.WriteLine("[행동] 점프합니다!");
                        break;
                    case CharacterState.Attacking:
                        Console.WriteLine("[행동] 적을 공격합니다!");
                        break;
                    case CharacterState.Dead:
                        Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
                        break;
                }
                Console.WriteLine();
                break;

            case MainMenuInput.Exit:
                Console.WriteLine("프로그램을 종료합니다.");
                break;
        }

        if ((MainMenuInput)input == MainMenuInput.Exit)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("잘못된 입력입니다.");
        Console.WriteLine();
        continue;
    }
}


enum MainMenuInput
{
    ChangeStatus = 1,
    ShowStatusList,
    ShowCurrentStatus,
    Exit,
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