# 코딩 연습 - 열거형 (2)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

이 프로젝트에서 사용할 열거형 정의 (파일 하단에 작성):

- `Animal` - Rabbit, Dragon, Snake
- `Priority` - High = 1, Normal = 5, Low = 10

---

## 1. 열거형의 기본 값

`Animal.Dragon`을 정수와 문자열로 각각 변환하여 출력하세요.
Rabbit은 0, Dragon은 1, Snake는 2의 값을 가집니다.

**실행 결과**

```
Animal.Dragon: 1, Dragon
```

---

## 2. Enum.GetValues - 열거형 값 목록

`Enum.GetValues`로 `Priority` 열거형의 모든 값과 정수 값을 함께 출력하세요.

**실행 결과**

```
Priority 열거형의 값들:
High = 1
Normal = 5
Low = 10
```
