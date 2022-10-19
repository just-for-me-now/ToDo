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
                EstimatedCompletion = DateTime.Parse("2023-01-01"),
                DateOfCompletion = null,
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
                EstimatedCompletion = DateTime.Parse("2023-01-01"),
                DateOfCompletion = null,
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
            DateTime newExtimatedCompletion = DateTime.Parse("2050-01-01");

            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = DateTime.Parse("2023-01-01"),
                DateOfCompletion = null,
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };


            var controller = new ToDoController();
            controller.NewNote(note);
            controller.ModifyEstimatedCompletion(note.ID, newExtimatedCompletion);
            Note result = controller.ReadNote(note.ID);

            Assert.That(result.EstimatedCompletion, Is.EqualTo(newExtimatedCompletion));
        }

        [Test]
        public void CreateNewNote_EstimatedDateLessThanCreatingDate_ThrowExceptionIfLower()
        {
            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = DateTime.Parse("2020-01-01"),
                DateOfCompletion = null,
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };

            var controller = new ToDoController();

            Assert.Catch(() => { controller.NewNote(note); });
        }

        [Test]
        public void ModifyEstimatedCompletion_EstimatedDateLessThanCreatingDate_ThrowExceptionIfLower()
        {
            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = DateTime.Parse("2030-01-01"),
                DateOfCompletion = null,
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };

            var controller = new ToDoController();
            controller.NewNote(note);

            Assert.Catch(() => {  controller.ModifyEstimatedCompletion(note.ID, DateTime.Parse("1999-12-31")); });
        }
        [Test]
        public void ModifyPriority_WhenCalled_CorrectlyChangePriority()
        {
            Priority lowPriority = Priority.Low;
            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = DateTime.Parse("2030-01-01"),
                DateOfCompletion = null,
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };
            var controller = new ToDoController();
            controller.NewNote(note);
            controller.ModifyPriority(note.ID, lowPriority);
            Note result = controller.ReadNote(note.ID);
            Assert.That(result.Priority, Is.EqualTo(lowPriority));
        }

        [Test]
        public void Database_exists()
        {
            var note = new Note()
            {
                Description = "Money expenses",
                Text = "To be paid to Kentucky Chicken Wings: 2000€",
                EstimatedCompletion = DateTime.Parse("2030-01-01"),
                DateOfCompletion = null,
                Link = "",
                Mentions = null,
                Priority = Priority.High
            };
            var controller = new ToDoController();
            controller.NewNote(note);

            controller =new ToDoController();
            Note result = controller.ReadNote(note.ID);
            Assert.That(result, Is.Not.Null);
        }
    }
}
