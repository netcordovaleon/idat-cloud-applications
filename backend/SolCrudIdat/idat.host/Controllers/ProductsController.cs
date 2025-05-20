using idat.entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace idat.host.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    //BEST PRACTICE = [www.algo.com]/api/products/100
    //BAD PRACTICE = www.algo.com/api/products/getproductbyId/1
    [Route("{id}")]
    [HttpGet]
    public Product Get(int id) {
        throw new NotImplementedException();
    }

    //BEST PRACTICE = [www.algo.com]/api/products
    [Route("")]
    [HttpGet]
    public IEnumerable<Product> GetProducts() {
        throw new NotImplementedException();
    }


    //BEST PRACTICE = [www.algo.com]/api/products
    [Route("")]
    [HttpPost]
    public Product SaveProduct(Product entity)
    {
        throw new NotImplementedException();
    }

    //BEST PRACTICE = [www.algo.com]/api/products
    [Route("")]
    [HttpPatch]
    public Product UpdateProduct(Product entity)
    {
        throw new NotImplementedException();
    }

    //BEST PRACTICE = [www.algo.com]/api/products/100
    [Route("{id}")]
    [HttpDelete]
    public Product DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

}

