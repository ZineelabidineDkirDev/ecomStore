using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using storeback.API.Entities;

namespace API.Controllers
{
    public class ProductController: ControllerBase
    {
        
    private readonly StoreContext context;
        public ProductController(StoreContext context)
        {
            this.context=context;
        }

    [HttpGet]
    public ActionResult<List<Product>> GetAll(){
        var product = context.Products.ToList();
        return Ok(product);
    }

    [HttpGet("{id}")]

    public ActionResult<Product> GetById(int id){
        return context.Products.Find(id);
    }

    public ActionResult<Product> GetById(int id){
        return context.Products.Find(id);
    }
    }
}