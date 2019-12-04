using Microsoft.AspNetCore.Mvc;
using System;

namespace ProDevOps.WebService.Controller
{
    public class DOController : ControllerBase
    {
        [HttpGet]
        public int GetRandomNumber() 
        {
            Random random = new Random();
            int rangedNumber = random.Next(101,200);
            return rangedNumber;
        }

        [HttpGet]
        public int UnTestedFunction() 
        {
            return 0;
        }
    }
}