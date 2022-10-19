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

        [Test]
        public void ModifyDescription_NewDescription_SuccesfullyModifiesTheNote()
        {
            string newDescr = "Money spent";
            var note = new Note()
            {
                ID = "123",
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                Created = "2020-01-01",
                EstimatedCompletion = "2023-01-01",
                DateOfCompletion = "",
                Link = "",
                Mentions = null,
                Priority = NotePriorities.High
            };

            var controller = new ToDoController();
            controller.ModifDescription("123", newDescr);

            Note result = controller.ReadNote("123");

            Assert.That(result.Description, Is.EqualTo(newDescr));
        }
    }
}
