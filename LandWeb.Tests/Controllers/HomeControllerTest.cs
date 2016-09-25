using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LandWeb;
using LandWeb.Controllers;
using LandWeb.Model;
using System.Collections.Generic;
using System.Diagnostics;

namespace LandWeb.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        //[TestMethod]
        //public void Index()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MemberTest()
        {
            // Arrange
            DAL mgr = new DAL();

            //mgr.GetMembers();


            //IEnumerable<justdates_Result> results = mgr.GetMembersTest(Convert.ToDateTime("5/11/2016 12:00:00"), Convert.ToDateTime("5/25/2016 12:00:00"));
            IEnumerable<member_list_Result> results = mgr.GetMembers(Convert.ToDateTime("5/11/2016 12:00:00"), Convert.ToDateTime("5/26/2016 12:00:00"));

            foreach (var r in results)
            {
                Debug.WriteLine(r.first_name);
            }

        }

        [TestMethod]
        public void FamilyTest()
        {
            // Arrange
            DAL db = new DAL();

            //mgr.GetMembers();


            //IEnumerable<justdates_Result> results = mgr.GetMembersTest(Convert.ToDateTime("5/11/2016 12:00:00"), Convert.ToDateTime("5/25/2016 12:00:00"));
            IEnumerable<family_get_Result> results = db.GetFamily(14133);

            foreach (var r in results)
            {
                Debug.WriteLine(r.first_name);
            }

        }
    }
}
