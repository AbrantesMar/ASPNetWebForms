using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreCurso.Model;
using System;

namespace StoreCurso.Tests.UserTest
{
    [TestClass]
    public class UserTestUnit
    {

        [TestMethod]
        public void InstanciarUser()
        {
            User usuario = new User();
            Assert.IsNotNull(usuario);
        }

        [TestMethod]
        public void InstanciarUserNull()
        {
            User usuario = null;
            Assert.IsNotNull(usuario);
        }

        [TestMethod]
        public void CreateUserWithNameWithIdWithPasswordWithEmailAndValid()
        {
            var user = new User();
            var guid = Guid.NewGuid();
            user.Id = 0;//guid;
            user.Name = "M'arcio";
            user.Password = "123456";
            user.Email = "email@gmail.com";
            user.Valid = true;
            Assert.IsFalse(user.Id != 0);// guid);
            Assert.IsTrue(user.Valid);
            Assert.IsNotNull(user.Name);
            Assert.AreEqual(user.Id, guid);
        }

        [TestMethod]
        public void UserPassword()
        {
            var user = new User();
            var guid = Guid.NewGuid();
            user.Id = 0;//guid;
            user.Name = "M'arcio";
            user.Password = "123456A";
            user.Email = "email@gmail.com";
            user.Valid = true;
            Assert.IsFalse(user.Password.Contains("a"));
        }
    }
}
