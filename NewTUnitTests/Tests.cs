using CodeLibrary;

namespace OldTUnitTests;

public class Tests
{
    [Test]
    [Arguments(1, 2, 3)]
    [Arguments(5, -3, 2)]
    [Arguments(0, 0, 0)]
    public async Task Add_WithArguments(int a, int b, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Sum(a, b);

        await Assert.That(result).IsEqualTo(expected);
    }
}