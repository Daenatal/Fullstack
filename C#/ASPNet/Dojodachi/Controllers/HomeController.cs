using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;

namespace Dojodachi
{
    public class HomeController: Controller 
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            
            if(HttpContext.Session.GetString("Pet") == null)
            {
                DojodachiPet Critter = new DojodachiPet();
                HttpContext.Session.SetObjectAsJson("Pet", Critter);
            }
            ViewBag.Critter = HttpContext.Session.GetObjectFromJson<DojodachiPet>("Pet");
            if(TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }
            return View();
        }
        [HttpGet("feed")]
        public List<object> addFullness()
        {
            List<object> Values = new List<object>();
            bool End = false;
            bool Win = false;
            Random rand = new Random();
            int Dislike = rand.Next(0,101);
            DojodachiPet Critter = HttpContext.Session.GetObjectFromJson<DojodachiPet>("Pet");
            if(Critter.Meals > 0 && Dislike > 25)
            {
                Critter.Meals -= 1;
                int amount = rand.Next(5, 11);
                Critter.Fullness += amount;
                HttpContext.Session.SetString("Picture", "/images/slime_eat.jpg");
                TempData["Message"] = $"Your Dojodachi ate some delicious food and gained {amount} fullness!";

            } else if(Critter.Meals > 0 && Dislike <= 25)
            {
                Critter.Meals -= 1;
                Critter.Fullness -= 5;
                HttpContext.Session.SetString("Picture", "/images/sad_slime.png");
                TempData["Message"] = "Your Dojodachi refuses to eat the food -5 fullness...";
            } else
            {
                TempData["Message"] = "Sorry you don't have any meals";
            }
            HttpContext.Session.SetObjectAsJson("Pet", Critter);
            Values.Add(Critter.Fullness);
            Values.Add(Critter.Meals);
            Values.Add(TempData["Message"]);
            Values.Add(HttpContext.Session.GetString("Picture"));
            if(Critter.Fullness <= 0)
            {
                End = true;
            }
            if(Critter.Fullness >= 100 && Critter.Happiness >= 100 && Critter.Energy >= 100)
            {
                Win = true;
            }
            Values.Add(End);
            Values.Add(Win);

            return Values;
        }
        [HttpGet("play")]
        public List<object> addHappiness()
        {
            List<object> Values = new List<object>();
            bool End = false;
            bool Win = false;
            Random rand = new Random();
            int Dislike = rand.Next(0, 101);
            DojodachiPet Critter = HttpContext.Session.GetObjectFromJson<DojodachiPet>("Pet");
            if(Critter.Energy > 0 && Dislike > 25)
            {
                Critter.Energy -= 5;
                int amount = rand.Next(5,11);
                Critter.Happiness += amount;
                TempData["Message"] = $"You played with your Dojodachi and gained {amount} happiness!";
                HttpContext.Session.SetString("Picture", "/images/happyslime.png");
            } else if (Critter.Energy > 0 && Dislike <= 25)
            {
                Critter.Energy -=5;
                Critter.Happiness -= 5;
                TempData["Message"] = "Dojodachi did not have fun playing -5 happiness...";
                HttpContext.Session.SetString("Picture", "/images/sad_slime.png");
            } else
            {
                TempData["Message"] = "Dojodachi is too tired to play right now...";
            }
            HttpContext.Session.SetObjectAsJson("Pet", Critter);
            Values.Add(Critter.Happiness);
            Values.Add(Critter.Energy);
            Values.Add(TempData["Message"]);
            Values.Add(HttpContext.Session.GetString("Picture"));
            if(Critter.Happiness <= 0)
            {
                End = true;
            }
            if(Critter.Fullness >= 100 && Critter.Happiness >= 100 && Critter.Energy >= 100)
            {
                Win = true;
            }
            Values.Add(End);
            Values.Add(Win);

            return Values;

        }
        [HttpGet("work")]
        public List<object> addMeals()
        {
            List<object> Values = new List<object>();
            Random rand = new Random();
            DojodachiPet Critter = HttpContext.Session.GetObjectFromJson<DojodachiPet>("Pet");
            if(Critter.Energy > 0)
            {
                Critter.Energy -= 5;
                int amount = rand.Next(1, 4);
                Critter.Meals += amount;
                TempData["Message"] = $"Your Dojodachi put in some hard work and earned {amount} meals!";
                HttpContext.Session.SetString("Picture", "/images/slimework.png");
            } else 
            {
                TempData["Message"] = "Your Dojodachi is too tired to work right now...";
                HttpContext.Session.SetString("Picture", "/images/sad_slime.png");
            }
            HttpContext.Session.SetObjectAsJson("Pet", Critter);
            Values.Add(Critter.Meals);
            Values.Add(Critter.Energy);
            Values.Add(TempData["Message"]);
            Values.Add(HttpContext.Session.GetString("Picture"));
            return Values;
        }
        [HttpGet("sleep")]
        public List<object> addEnergy()
        {
            List<object> Values = new List<object>();
            bool End = false;
            bool Win = false;
            Random rand = new Random();
            DojodachiPet Critter = HttpContext.Session.GetObjectFromJson<DojodachiPet>("Pet");
            if(Critter.Happiness > 0 && Critter.Fullness > 0)
            {
                Critter.Happiness -= 5;
                Critter.Fullness -= 5;
                Critter.Energy += 15;
                TempData["Message"] = $"Your Dojodachi got some quality rest! It looks a little hungry though...";
                HttpContext.Session.SetString("Picture", "/images/slimesleep.gif");
            } else 
            {
                TempData["Message"] = "Your Dojodachi isn't feeling up to resting at the moment...";
                HttpContext.Session.SetString("Picture", "/images/sad_slime.png");
            }
            HttpContext.Session.SetObjectAsJson("Pet", Critter);
            Values.Add(Critter.Happiness);
            Values.Add(Critter.Fullness);
            Values.Add(Critter.Energy);
            Values.Add(TempData["Message"]);
            Values.Add(HttpContext.Session.GetString("Picture"));
            if(Critter.Fullness <= 0 || Critter.Happiness <= 0)
            {
                End = true;
            }
            if(Critter.Fullness >= 100 && Critter.Happiness >= 100 && Critter.Energy >= 100)
            {
                Win = true;
            }
            Values.Add(End);
            Values.Add(Win);
            return Values;
        }
        [HttpGet("restart")]
        public IActionResult gameOver()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}