using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Braennbollsturnering;
using Braennbollsturnering.Controllers;
using Moq;
using Braennbollsturnering.Library.Interfaces;
using Braennbollsturnering.Models;

namespace Braennbollsturnering.Tests.Controllers
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

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.Contact() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void TeamsShowList()
        {
            // Arrange
            Mock<IDataService> mockDataService = new Mock<IDataService>();
            List<Player> listOfPlayers = new List<Player>();
            listOfPlayers.Add(new Player(){Name = "Robin Svahn"});
            listOfPlayers.Add(new Player() { Name = "Aron Svensson" });
            listOfPlayers.Add(new Player() { Name = "Sebastian Andersson" });
            listOfPlayers.Add(new Player() { Name = "Adam Björnsson" });
            listOfPlayers.Add(new Player() { Name = "Philip Gren" });
            listOfPlayers.Add(new Player() { Name = "Harald Sten" });


            List<Team> listOfTeams = new List<Team>();
            listOfTeams.Add(new Team()
            {
                Name = "Team Koalas",
                Players = listOfPlayers
            });

            mockDataService.Setup(x => x.GetTeams()).Returns(listOfTeams);

            HomeController controller = new HomeController(mockDataService.Object);

            // Act
            ViewResult result = controller.Teams() as ViewResult;

            // Assert
            Assert.AreEqual(listOfTeams, result.Model);     
        }
    }
}