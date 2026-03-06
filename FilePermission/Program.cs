using System;

Console.WriteLine("=== 파일 권한 관리 ===");

FilePermission permission = FilePermission.None;
Console.WriteLine();
Console.WriteLine($"현재 권한: {permission}");


Console.WriteLine();
Console.WriteLine("[권한 추가]");

permission |= FilePermission.Read;
Console.WriteLine($"+ Read 추가: {permission}");

permission |= FilePermission.Write;
Console.WriteLine($"+ Write 추가: {permission}");

permission |= FilePermission.Execute;
Console.WriteLine($"+ Execute 추가: {permission}");


Console.WriteLine();
Console.WriteLine("[권한 확인]");
Console.WriteLine($"Read 권한: {(permission&FilePermission.Read)!=0}");
Console.WriteLine($"Write 권한: {(permission & FilePermission.Write) != 0}");
Console.WriteLine($"Execute 권한: {(permission & FilePermission.Execute) != 0}");


Console.WriteLine();
Console.WriteLine("[권한 제거]");

permission &= ~FilePermission.Write;
Console.WriteLine($"+ Write 제거: {permission}");


Console.WriteLine();
Console.WriteLine("[제거후 확인]");
Console.WriteLine($"Read 권한: {(permission & FilePermission.Read) != 0}");
Console.WriteLine($"Write 권한: {(permission & FilePermission.Write) != 0}");
Console.WriteLine($"Execute 권한: {(permission & FilePermission.Execute) != 0}");



[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 1<<1,
    Execute = 1<<2
}