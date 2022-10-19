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

            Note nota = new Note();
            var controller = new ToDoController();
            controller.NewNote(nota);

            Note result = controller.ReadNote(nota.ID);
            
            Assert.That(result.ID, Is.EqualTo(nota.ID));
        }

        [Test]
        public void ReadNote_IncorrectNoteId_ReturnsMessage()
        {
            int ID = 22;

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
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = "2023-01-01",
                DateOfCompletion = "",
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };


            var controller = new ToDoController();
            controller.NewNote(note);
            controller.ModifyDescription(note.ID, newDescr);
            Note result = controller.ReadNote(note.ID);

            Assert.That(result.Description, Is.EqualTo(newDescr));
        }
        [Test]
        public void ModifyText_NewDescription_SuccesfullyModifiesTheNote()
        {
            string newText = "aaa";

            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = "2023-01-01",
                DateOfCompletion = "",
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };


            var controller = new ToDoController();
            controller.NewNote(note);
            controller.ModifyText(note.ID, newText);
            Note result = controller.ReadNote(note.ID);

            Assert.That(result.Text, Is.EqualTo(newText));
        }

        [Test]
        public void ModifyEstimatedCompletion_NewExtimatedCompletion_SuccesfullyModifiesTheNote()
        {
            string newExtimatedCompletion = "2050-01-01";

            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = "2023-01-01",
                DateOfCompletion = "",
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };


            var controller = new ToDoController();
            controller.NewNote(note);
            controller.ModifyEstimatedCompletion(note.ID, newExtimatedCompletion);
            Note result = controller.ReadNote(note.ID);

            Assert.That(result.Text, Is.EqualTo(newExtimatedCompletion));
        }
    }
}
