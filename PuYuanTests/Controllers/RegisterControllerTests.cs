using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PuYuan.Controllers;
using PuYuan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace PuYuan.Controllers.Tests
{
    [TestFixture]
    public class RegisterControllerTests
    {
        [Test]
        public void Test_Register()
        {
            string Account = "testuser";
            string Password = "testuser";
            string Email = "testuser@gmail.com";
            string Phone = "1234567890";
            Assert.IsNotNull(Account);
            Assert.IsNotNull(Password);
            Assert.IsNotNull(Email);
            Assert.IsNotNull(Phone);
        }
    }
}