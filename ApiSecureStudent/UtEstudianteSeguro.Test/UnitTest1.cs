using ApiSecureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodGetStudent()
        {
            //arrange
            StudentsController studentsController = new StudentsController();

            //act 

            var ListaEstudiante = studentsController.GetStudents();

            //assert
            Assert.IsNotNull(ListaEstudiante);
        }
    }
}
