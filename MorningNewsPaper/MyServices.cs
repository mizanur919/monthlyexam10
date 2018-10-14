using Microsoft.AspNetCore.Mvc;
using MorningNewsPaper.Models;
using MorningNewsPaper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorningNewsPaper
{
    interface MyServices
    {
        IActionResult Get();
        IActionResult Create(NewsInfoVM vm);
        IActionResult Edit(int id, NewsInfo nw);
        IActionResult Delete(int id);
    }
}
