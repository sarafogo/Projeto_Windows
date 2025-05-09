using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_Windows; // Namespace do seu projeto Windows Forms

namespace Projeto_Windows
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Soma_DeveRetornarSomaCorreta()
        {
            // Arrange
            var form = new Form1();
            int a = 5;
            int b = 3;

            // Act
            int resultado = form.Soma(a, b);

            // Assert
            Assert.AreEqual(8, resultado);
        }
    }
    // Add this method to the Form1 class in WindowsFormsApp_fw/Form1.cs
    public partial class Form1 : Form1Tests
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
