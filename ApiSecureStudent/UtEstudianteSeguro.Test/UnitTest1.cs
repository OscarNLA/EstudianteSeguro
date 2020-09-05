using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
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
