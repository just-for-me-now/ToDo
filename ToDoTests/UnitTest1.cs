using NUnit.Framework;
using System;
using System.ComponentModel.Design;

namespace ToDoTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void ReadTransaction_CorrectTransactionId_ReturnsATransactionObjectWithACorrectId()
        {
            string id = "123";

            Transaction result = ReadTransaction(id);

            Assert.That(result.Id, Is.EqualTo("123"));
        }
    }
}
