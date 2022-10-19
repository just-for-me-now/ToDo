using NUnit.Framework;
using System;
using System.ComponentModel.Design;

namespace ToDoTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void ReadTransaction_CorrectNoteId_ReturnsANoteObjectWithACorrectId()
        {
            string id = "123";

            Note result = ReadNote(id);

            Assert.That(result.Id, Is.EqualTo("123"));
        }
    }
}
