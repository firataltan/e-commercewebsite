using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
       Product GetProductDetails(string url);
       List<Product> GetProductsByCategory(string name,int page,int pageSize);
       List<Product> GetSearchResult(string searchString);
       List<Product> GetHomePageProducts();
       int GetCountByCategory(string category);
    }
}