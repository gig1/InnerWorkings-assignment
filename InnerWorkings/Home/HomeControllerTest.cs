using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using InnerWorkings.Controllers;
using AutoMoq;

namespace InnerWorkings.Home
{
    [TestFixture]
    public class HomeControllerTest
    {
        private HomeController _controller;
        private AutoMoqer _mocker;
        
        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMoqer();

            _controller = _mocker.Create<HomeController>();
        } 

        [Test]
        public void TestGetIndexShouldReturnView()
        {
            var result = _controller.Index();

            Assert.That(result, Is.TypeOf<ViewResult>());
        }
    }
}