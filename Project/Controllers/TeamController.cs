using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer.Entities;

namespace Project.Controllers
{
    public class TeamController : Controller
    {
        private DataManager _dataManager;
        public TeamController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Team team)
        {
            _dataManager.Teams.TeamCreate(team);
            return RedirectToAction("Create", "Home");
        }
    }
}
