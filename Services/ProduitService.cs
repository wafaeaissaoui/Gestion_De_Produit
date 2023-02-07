using Gestion_de_Produit.models;

namespace Gestion_de_Produit.Services
{
    public class ProduitService : IProduit
    {
        public Task<Produit> GetProduitById(Guid produitId)
        {
            throw new NotImplementedException();
        }

        public Task<Produit> GetProduitByItem(string item)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produit>> GetProduitList()
        {
            throw new NotImplementedException();
        }
    }
}
