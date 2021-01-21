using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TacoCat.Models;

namespace TacoCat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //GET
        public IActionResult Index()
        {
            //Object initialization
            var model = new Palindrome();
            return View(model);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Palindrome input)
        {
            //Input word = Frank
            string inputWord = input.InputWord.ToLower();
            //inputWord = frank
            inputWord = inputWord.Replace(" ", "");
            //inputWord = frank
            string revWord = "";
            //rev Word = 
            var test = input.IsPalindrome;

            // InputWord = 
            for (int i = inputWord.Length -1; i >= 0; i--)
            {
                revWord += inputWord[i];
            }
            //revWord = knarf
            if(revWord == inputWord)
            {
                input.IsPalindrome = true;
                input.Message = $"Success, {input.InputWord} is a Palindrome!";
            }
            else
            {
                input.Message = $"Sorry, {input.InputWord} is NOT a Palindrome!";
            }

            return View(input);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
