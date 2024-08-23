using EcomFinal_usingaspDotNetCoreMvc.Data;
using EcomFinal_usingaspDotNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcomFinal_usingaspDotNetCoreMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;
        private IWebHostEnvironment env;
        public ProductController(ApplicationDbContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
            var data = db.Products.ToList();
            return View(data);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel p)
        {
            var path = env.WebRootPath;
            var directoryPath = Path.Combine(path, "Content", "Images");

            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var filepath = Path.Combine(directoryPath, p.Image.FileName);
            uploadFile(p.Image, filepath);

            var obj = new Product()
            {
                Name = p.Name,
                Category = p.Category,
                Price = p.Price,
                Description = p.Description,
                Image = $"/Content/Images/{p.Image.FileName}"
            };

            db.Products.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public void uploadFile(IFormFile picture, string fullpath)
        {
            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                picture.CopyTo(stream);
            }
        }
    }

    
}

