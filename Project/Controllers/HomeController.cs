using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataLayer.Entities;
using Newtonsoft.Json;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private DataManager _dataManager;
        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager; 
        }

        public IActionResult Index()
        {
            ViewBag.TeamId = JsonConvert.SerializeObject(_dataManager.Teams.GetAllTeams());
            return View(_dataManager.Players.GetAllPlayers());
        }

        public IActionResult Delete(int id)
        {
            _dataManager.Players.PlayerDelete(id);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.TeamId = _dataManager.Teams.GetAllTeams();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Player player)
        {
            _dataManager.Players.PlayerCreate(player);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        { 
            return View(_dataManager.Players.PlayerById(id));
        }

        [HttpPost]
        public IActionResult Edit(Player player)
        {
            _dataManager.Players.PlayerSave(player);
            return RedirectToAction("Index", "Home");
        }
    }
}
