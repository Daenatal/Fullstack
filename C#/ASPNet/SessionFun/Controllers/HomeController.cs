using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SessionFun.Models;
namespace SessionFun
{
    public class HomeController: Controller 
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            if(HttpContext.Session.GetString("Fruit") == null)
            {
                return View("GetFruit");
            }
            ViewBag.Fruit = HttpContext.Session.GetString("Fruit");
            if(HttpContext.Session.GetInt32("numOfFruits") == null)
            {
                HttpContext.Session.SetInt32("numOfFruits", 0);
            }
            ViewBag.FruitAmount = HttpContext.Session.GetInt32("numOfFruits");
            return View();
        }
        [HttpPost("fruit")]
        public IActionResult getFruit(string newFruit)
        {
            HttpContext.Session.SetString("Fruit", newFruit);
            return RedirectToAction("Index");
        }
        [HttpGet("add")]
        public IActionResult addCount()
        {
            int? currentCount = HttpContext.Session.GetInt32("numOfFruits");
            currentCount += 1;
            HttpContext.Session.SetInt32("numOfFruits", (int)currentCount);
            return RedirectToAction("Index");
        }
        [HttpGet("clear")]
        public IActionResult clearFruit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        [HttpGet("animals")]
        public IActionResult showAnimals()
        {
            Animal Bear = new Animal()
            {
                Name = "Bear",
                Age = 5,
                Species = "Ursus Arctos"
            };
            HttpContext.Session.SetObjectAsJson("Animal", Bear);
            ViewBag.Animal = HttpContext.Session.GetObjectFromJson<Animal>("Animal");
            return View("AnimalDisplay", Bear);
        }
        [HttpGet("animals2")]
        public IActionResult getAnimal()
        {
            Animal Wolf = new Animal()
            {
                Name = "Wolf",
                Age = 7,
                Species = "Canis Lupus"
            };

            List<Animal> Zoo = new List<Animal>();
            if(HttpContext.Session.GetString("Zoo") == null)
            {
                Zoo.Add(Wolf);
                HttpContext.Session.SetObjectAsJson("Zoo", Zoo);
            }
            return RedirectToAction("getAnimals");
        }
        [HttpGet("zoo")]
        public List<Animal> getAnimals()
        {
            List<Animal> Zoo = HttpContext.Session.GetObjectFromJson<List<Animal>>("Zoo");
            return Zoo; 
        }
        [HttpPost("animalsPost")]
        public IActionResult placeAnimal(Animal newAnimal)
        {
            List<Animal> Zoo = HttpContext.Session.GetObjectFromJson<List<Animal>>("Zoo");
            Zoo.Add(newAnimal);
            HttpContext.Session.SetObjectAsJson("Zoo", Zoo);
            return Json(newAnimal);
        }
    }
}