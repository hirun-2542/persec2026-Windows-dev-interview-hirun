# Persec Windows Developer Interview

คำตอบสำหรับโจทย์ Windows Developer Interview เขียนด้วย C# และมี unit tests ด้วย xUnit

## Requirements

- .NET SDK 10.0+

## Run

รันตัวอย่างของแต่ละข้อ โดยเปลี่ยนเลขท้ายเป็น `1` ถึง `6`:

```bash
dotnet run -- 1
```

## Test

รัน unit tests ทั้งหมด:

```bash
dotnet test tests/PersecInterview.Tests
```

รันเฉพาะข้อ 1:

```bash
dotnet test tests/PersecInterview.Tests --filter "FullyQualifiedName~Task1Tests"
```

## Structure

- `Task1.cs` — ตรวจวงเล็บเปิด–ปิด
- `Task2.cs` — เรียงรหัสตัวอักษรและตัวเลข
- `Task3.cs` — autocomplete แบบไม่สนตัวพิมพ์เล็ก–ใหญ่
- `Task4.cs` — แปลง Roman numerals ไป–กลับ
- `Task5.cs` — เรียงเลขโดดจากมากไปน้อย
- `Task6.cs` — สร้าง Tribonacci sequence
- `tests/PersecInterview.Tests/` — unit tests แยกตามข้อ
