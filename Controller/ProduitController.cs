using Gestion_de_Produit;
using Gestion_de_Produit.models;
using Gestion_de_Produit.Services;
using Gestion_de_Produit.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_Produit
{

    public class ProduitController : Controller
    {
        private IProduit _produitService;
        public ProduitController(IProduit produitService)
        {
           _produitService = produitService;
        }

        [HttpGet("/")]
        public  async Task<IActionResult> Index()
        {
            var data = await _produitService.GetProduitList();
            Console.WriteLine(data);
            return View(data);  
        }
        [HttpGet("/Details/{id}")]
        public async Task<IActionResult> details(int id )
        {
            var data = await _produitService.GetProduitById(id);
            Console.WriteLine(data);
            return View(data);  
        }



    }
}
