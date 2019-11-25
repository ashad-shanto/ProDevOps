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
            int rangedNumber = random.Next(0,100);
            return rangedNumber;
        }
    }
}