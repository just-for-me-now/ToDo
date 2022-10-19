using NUnit.Framework;
using System;
using System.ComponentModel.Design;
using ToDo;
using ToDo.Controllers;

namespace ToDoTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void ReadTransaction_CorrectNoteId_ReturnsANoteObjectWithACorrectId()
        {
            string ID = "123";

            var controller = new ToDoController();

            Note result = controller.ReadNote(ID);
            
            Assert.That(result.ID, Is.EqualTo("123"));
        }
    }
}
