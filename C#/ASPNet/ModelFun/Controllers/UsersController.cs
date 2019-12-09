using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ModelFun.Models;
namespace ModelFun
{
    public class UsersController: Controller 
    {
        [HttpGet]
        [Route("")]
        public IActionResult getUsersPrime()
        {
            // User Test = new User()
            // {
            //     FirstName = "Paul",
            //     LastName = "Berts"
            // };
            List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            // DbConnector.Execute("INSERT INTO users (FirstName, LastName) VALUES ('Johnson', 'Charles')");
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes2");
            ViewBag.Users = AllUsers;
            ViewBag.Quotes = AllQuotes;
            return View("Index");
        }
        [HttpGet]
        [Route("words")]
        public IActionResult getWords()
        {
            string[] names = new string[]
            {
                "Barry", "Silas", "Milo", "Gin", "Duck"
            };
            return View("Index", names);
        }
        [HttpGet]
        [Route("numbers")]
        public IActionResult getNumbers()
        {
            string word = "This is a message being passed from a model...";
            int[] numbers = new int[]
            {
                1, 3, 5, 77, 106, 99
            };
            return View("Index", numbers);
        }
        [HttpGet]
        [Route("users")]
        public IActionResult getUsers()
        {
            List<User> users = new List<User>()
            {
                new User("Larry", "Burns"),
                new User("Jeremy", "Barloni"),
                new User("Paul", "Heyman"),
                new User("Rigatoni", "Pastoni")
            };
            return View("Index", users);
        }
        [HttpPost("sendQuote")]
        public IActionResult submitQuote(Quote submittedQuote)
        {
            string query = $"INSERT INTO quotes2(Title, Body, Time) VALUES ('{submittedQuote.Title}', '{submittedQuote.Body}', NOW())";
            DbConnector.Execute(query);
            return RedirectToAction("getUsersPrime");
        }
    }
}