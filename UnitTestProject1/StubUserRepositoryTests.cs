using Authorizations;
using FsCheck.Experimental;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Authorization.Tests
{
    [TestClass]
    public class StubUserRepositoryTests
    {
        private StubUserRepository _stubUserRepo;

        [TestInitialize]
        public void Setup()
        {
            _stubUserRepo = new StubUserRepository();
        }

        [TestMethod]
        public void Authenticate_ValidAdminCredentials_ReturnsTrue()
        {
            Assert.IsTrue(_stubUserRepo.Authenticate("Admin", "Admin123"));
        }
    }
}
