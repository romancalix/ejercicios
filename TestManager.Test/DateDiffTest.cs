using InterviewTest;
using InterviewTest.Strategies;


namespace TestManager.Test
{
    public class DateDiffTest
    {
        // Aquí irían los métodos de prueba para la clase DiasDiff
        [Theory]
        // Casos básicos
        [InlineData("01/01/2024", "01/01/2024", 0)]
        [InlineData("01/01/2024", "02/01/2024", 1)]
        [InlineData("31/12/2023", "01/01/2024", 1)]

        // Meses completos
        [InlineData("01/01/2024", "01/02/2024", 31)]  // Enero completo
        [InlineData("01/03/2024", "01/04/2024", 31)]  // Marzo completo
        [InlineData("01/04/2024", "01/05/2024", 30)]  // Abril completo
        [InlineData("01/05/2024", "01/06/2024", 31)]  // Mayo completo
        public void TestDateDiff(string date1, string date2, int dayDiff) 
        {
            //arrange
            IStrategy<int> strategy = new DiasDiff(date1,date2);
            var context = new Context<int>(strategy);

            //act
            context.ExecuteStrategy();
            int response = context.GetResponse();
            //assert
            Assert.Equal(dayDiff, response);
        }
    }
}
