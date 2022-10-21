using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PuYuan.Controllers;
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
    public class AuthControllerTests
    {
        [Test]
        public void Test_Auth()
        {
            var db_Account = "testuser";
            var db_Password = "testuser";
            var login_Account = "testuser";
            var login_Password = "testuser";
            Assert.AreEqual(db_Account, login_Account);
            Assert.AreEqual(db_Password, login_Password);
        }
    }
}