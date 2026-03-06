# 파일 권한 관리

`[Flags]` 열거형을 사용하여 파일 권한을 관리하는 프로그램을 작성하세요.

파일 권한은 다음과 같이 정의됨:

- `None` - 값: 0 (권한 없음)
- `Read` - 값: 1 (읽기)
- `Write` - 값: 2 (쓰기)
- `Execute` - 값: 4 (실행)

**요구사항:**

1. `[Flags]` 특성이 적용된 `FilePermission` 열거형을 정의할 것
2. 초기 권한은 `None`으로 설정할 것
3. `|=` 연산자로 권한을 추가할 것
4. `HasFlag()` 메서드로 특정 권한이 있는지 확인할 것
5. `&= ~` 연산자로 권한을 제거할 것
6. 각 단계마다 현재 권한 상태를 출력할 것

## 예상 실행 결과

```
=== 파일 권한 관리 ===

현재 권한: None

[권한 추가]
+ Read 추가: Read
+ Write 추가: Read, Write
+ Execute 추가: Read, Write, Execute

[권한 확인]
Read 권한: True
Write 권한: True
Execute 권한: True

[권한 제거]
- Write 제거: Read, Execute

[제거 후 확인]
Read 권한: True
Write 권한: False
Execute 권한: True
```
