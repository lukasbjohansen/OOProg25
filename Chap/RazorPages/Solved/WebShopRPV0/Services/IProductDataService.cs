
public interface IProductDataService
{
    List<Product> GetAll();
    int Create(Product product);
    Product? Read(int id);
    bool Update(int id, Product product);
    bool Delete(int id);
}

