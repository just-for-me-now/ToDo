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
        public void ReadNote_CorrectNoteId_ReturnsANoteObjectWithACorrectId()
        {

            string ID = "123";
            var controller = new ToDoController();
            controller.NewNote("123");

            Note result = controller.ReadNote(ID);
            
            Assert.That(result.ID, Is.EqualTo("123"));
        }

        [Test]
        public void ReadNote_IncorrectNoteId_ReturnsMessage()
        {
            string ID = "22";

            var controller = new ToDoController();

            Note result = controller.ReadNote(ID);
            //$"{result.ID} does not exist"
            Assert.That(result, Is.Null);
        }
    }
}
