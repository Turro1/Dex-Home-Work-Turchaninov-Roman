using HomeWork_10;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HomeWork_10_UnitTesting_
{
    public class CalcTest
    {
        [Fact]
        public void GetSum_10_Plus_2_Eq_12()
        {
            //Arrange
            var calc = new Calc();

            //Act
            var result = calc.GetSum(10, 2);

            //Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void GetSubstraction_12_Minus_2_Eq_10()
        {
            //Arrange
            var calc = new Calc();
            //Act
            var result = calc.GetSubstruct(12, 2);
            //Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void GetMultiplication_5_Times_4_Eq_20()
        {
            //Arrange
            var calc = new Calc();
            //Act
            var result = calc.GetMultiplication(5, 4);
            //Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void GetDivision_9_Divided_By_3_Eq_3()
        {
            //Arrange
            var calc = new Calc();
            //Act
            var result = calc.GetDivide(9, 3);
            //Assert
            Assert.Equal(3, result);
        }
    }
}
