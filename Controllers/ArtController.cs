using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtShop3.Models;
using ArtShop3.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArtShop3.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository _artRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ArtController(IArtRepository artRepository, ICategoryRepository categoryRepository)
        {
            _artRepository = artRepository;
            _categoryRepository = categoryRepository;

        }

        //public ViewResult List()
        //{
        //    ArtsListViewModel artsListViewModel = new ArtsListViewModel();
        //    artsListViewModel.Arts = _artRepository.AllArts;
        //    artsListViewModel.CurrentCategory = "Dead Inside";
        //    return View(artsListViewModel); 
        //}

        public IActionResult Details(int id)
        {
            var art = _artRepository.GetArtById(id);
            if (art == null)
                return NotFound();

            return View(art);
        }
        public ViewResult List(string category)
        {
            IEnumerable<Art> arts;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                arts = _artRepository.AllArts.OrderBy(p => p.ArtId);
                currentCategory = "All arts";
            }
            else
            {
                arts = _artRepository.AllArts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ArtId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ArtsListViewModel
            {
                Arts = arts,
                CurrentCategory = currentCategory
            });
        }
    }
}
