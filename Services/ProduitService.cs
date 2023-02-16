using Gestion_de_Produit.models;
using Gestion_de_Produit.Utils;

namespace Gestion_de_Produit.Services
{
    public class ProduitService : IProduit
    {
        
        public Task<Produit> GetProduitById(int produitId)
        {
            var res=  NorthwindAPI.GetProduitById<Produit>(produitId);
            return res;
           
        }

        public Task<Produit> GetProduitByItem(string item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produit>> GetProduitList()
        {
            return await NorthwindAPI.Downloading<Produit>();
        }
    }
}
