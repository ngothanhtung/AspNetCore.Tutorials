﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Tutorials
{
	//Cách 1: public class CitySummary : ViewComponent
	//Cách 2: public class CitySummaryViewComponent : ViewComponent
	//Cách 3: Dùng attribute [ViewComponent(Name = "CitySummary")]
	public class CitySummaryViewComponent : ViewComponent
    {
        public CitySummaryViewComponent()
        {
        }

        /*
        public string Invoke() 
        {
            return $"Danang City";
        }
        */

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var people = new[] {
                "Peter", "John"
            };
            return View(people);
        }
    }
}
