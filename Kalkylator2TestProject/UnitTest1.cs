using System;
using Xunit;
using Kalkylator2;

namespace Kalkylator2TestProject
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            double[] numbers = new double[3];

            double num1 = 4;
            double num2 = 3;
            numbers[0] = num1;
            numbers[1] = num2;
            
            double expectedSumma = 7;
            double[] summa = new double[3];

            summa = program.Addition(numbers);

            Assert.Equal(summa[2], expectedSumma);
        }
        [Fact]
        public void Test2()
        {
            double num1 = 4;
            double num2 = 3;
            double expectedSumma = 7;

            double summa = program.Addition(num1, num2);

            Assert.Equal(summa, expectedSumma);
        }

        [Fact]
        public void Test3()
        {
            double[] numbers = new double[3];

            double num1 = 4;
            double num2 = 3;
            numbers[0] = num1;
            numbers[1] = num2;
            
            double expectedSumma = 1;
            double[] summa = new double[3];

            summa = program.Subtraktion(numbers);

            Assert.Equal(summa[2], expectedSumma);
        }

        [Fact]
        public void Test4()
        {
            var num1 = 4;
            double num2 = 3;
            double expectedSumma = 1;

            double summa = program.Subtraktion(num1, num2);

            Assert.Equal(summa, expectedSumma);
        }

        [Fact]
        public void Test5()
        {
            double num1 = 4;
            double num2 = 3;
            double expectedSumma = 12;

            double summa = program.Multiplikation(num1, num2);

            Assert.Equal(summa, expectedSumma);
        }

        [Fact]
        public void Test6()
        {
            double num1 = 5;
            double num2 = 1;
            double expectedSumma = 5;

            double summa = program.Division(num1, num2);

            Assert.Equal(summa, expectedSumma);
        }

        [Fact]
        public void Test7()
        {
            double num1 = 5;
            double num2 = 0;
            string resultat = "";
            String expectedString = "Odefinierat";

            double summa = program.Division(num1, num2);


            if (summa == 0)
            {
                resultat = "Odefinierat";
            }

            Assert.Equal(resultat, expectedString);
        }

        [Fact]
        public void Test8()
        {
            double num1 = 3;
            double num2 = 3;
            double expectedSumma = 27;

            double summa = program.Elevation(num1, num2);

            Assert.Equal(summa, expectedSumma);
        }
    }
}

