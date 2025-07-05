# Unit Testing with xUnit – PowerConverterApp v1.4

This project contains unit tests for the Power Converter application (`UNIT TEST 1.3`), implemented using the **xUnit** testing framework and .NET 8.0.

## 🧪 Technologies Used:
- .NET 8.0
- xUnit 2.5.3
- Microsoft.NET.Test.Sdk
- Coverlet Collector (code coverage)
- Visual Studio 2022

## 📋 Description:
This test project:
- References the `PowerConverterApp` logic from version 1.3
- Validates the correctness of the `KwHpConverter` method
- Uses **xUnit** for test organization and assertions
- Can be executed directly within Visual Studio or via CLI

## ▶️ How to Run Tests:

### 🔹 Visual Studio:
1. Open the solution containing both projects (`UNIT TEST 1.3` and `UNIT TEST 1.4`)
2. Build the solution
3. Open `Test Explorer` (`Test > Test Explorer`)
4. Run all tests or selected ones

### 🔹 .NET CLI:
```bash
dotnet test
✅ Example Test Method:
csharp

[Fact]
public void ConvertsKwToHpCorrectly()
{
    double result = Program.KwHpConverter(74.57, "hp");
    Assert.Equal(100, Math.Round(result));
}

📈 Code Coverage:
This project uses coverlet.collector to generate code coverage metrics.
To collect coverage from CLI:
dotnet test /p:CollectCoverage=true
