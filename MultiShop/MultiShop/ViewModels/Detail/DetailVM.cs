using MultiShop.Models;
namespace MultiShop.ViewModels.Detail
{
    public class DetailVM
    {
        public Products Products { get; set; }
        public List<Products> RelatedProducts { get; set; }
    }
}
