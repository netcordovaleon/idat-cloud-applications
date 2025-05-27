using idat.entities;
using idat.shared;

namespace idat.services;


public interface IProductServices {
    Task<Product> SaveProduct(Product product);
    Task<IEnumerable< Product>> GetAll();

}

public class ProductServices : IProductServices
{
    private IUnitOfWork _unitOfWork;
    public ProductServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _unitOfWork.GetRepository<Product>().GetAll();
    }

    public async Task<Product> SaveProduct(Product product) {
        var result = await _unitOfWork.GetRepository<Product>().Save(product);
        _unitOfWork.SaveChanges();
        return result;
    }



}
