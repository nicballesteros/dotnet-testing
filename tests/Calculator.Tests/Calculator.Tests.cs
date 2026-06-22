namespace Calculator.Tests;
using Bogus;


public class UnitTest1
{
    [Fact]
    public void Calculator_add_sumtwonumbers()
    {
        //Assemble
        var calculator = new Calculator();
        var faker = new Faker();

        int a = faker.Random.Int();
        int b = faker.Random.Int();

        //Act
        int sum = calculator.Add(a, b);

        //Assert
        Assert.Equal(a + b, sum);
    }

    [Fact]
    public void Calculator_divide_twoIntsNotZero()
    {
        //Arrange
        var calculator = new Calculator();
        var faker = new Faker();

        int a = faker.Random.Int();
        int b = 0;
        while (b == 0)
        {
            b = faker.Random.Int();
        }

        //Act
        int quotient = calculator.Divide(a, b);

        //Assert
        Assert.Equal(a / b, quotient);
    }

    [Fact]
    public void Calculator_divide_anIntByZero()
    {
        //Arrange
        var calculator = new Calculator();
        var faker = new Faker();

        int a = faker.Random.Int();
        int b = 0;

        //Act
        //Assert
        Assert.Throws<DivideByZeroException>(
            () => calculator.Divide(a, b)
        );
    }
}