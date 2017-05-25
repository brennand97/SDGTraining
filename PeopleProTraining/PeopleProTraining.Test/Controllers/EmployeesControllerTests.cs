using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using PeopleProTraining.Controllers;
using PeopleProTraining.Dal.Interfaces;
using Moq;

namespace PeopleProTraining.Test.Controllers
{
    [TestClass]
    public class EmployeesControllerTests
    {
        [TestMethod]
        public void TestIndexView()
        {
            var mock = new Mock<IPeopleProContext>();
            mock.Setup(framework => framework.Employees);
            IPeopleProContext context = mock.Object;
            var controller = new EmployeesController(context);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
