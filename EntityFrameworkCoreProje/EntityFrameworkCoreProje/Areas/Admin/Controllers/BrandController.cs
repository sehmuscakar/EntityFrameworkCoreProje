using EntityFrameworkCoreProje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BrandController : Controller
    {
        private readonly DatabaseContext _context; //dependis enjekşın ,_context sağ tıkla Quick actions ... seçeneğine tıkla sonra contsatır olanına tıkla

        public BrandController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: BrandController
        public async  Task<IActionResult> Index()
        {
            var model = await _context.Brands.AsNoTracking().ToListAsync();//AsNoTracking() bu metot la beraber daha hızlı listeler 
            return View(model);
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            try
            { // _context.Add<Brand>(brand); //buda ekleme yöntemi 
              //  _context.Entry<Brand>(brand).State=EntityState.Added;//buda ekleme yöntemi
                _context.Attach<Brand>(brand);//buda ekleme yöntemi
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            //  var marka = _context.Brands.Where(b => b.Id == id).FirstOrDefault();// markayı getirmede bu da yontem 
            //  var marka =_context.Brands.Where(b=>b.Id== id).SingleOrDefault();// bu da markayı getirmede bi yontem 
            var marka = _context.Brands.FirstOrDefault(b => b.Id == id); // boylede veriyi getirebilirsin 

            return View(marka);
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Brand brand)
        {
            try
            {
                // _context.Attach<Brand>(brand).State=EntityState.Modified; //buda bir güncellleme yontemi 
                //   _context.Brands.Update(brand); // buda başka bir güncelleme yöntemi
               //  _context.Update(brand); //buda başka bir güncelleme yöntemi
                _context.Entry<Brand>(brand).State = EntityState.Modified; // buda başka bir güncelleme yöntemi
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Delete/5
        public async Task<ActionResult> Delete(int id) // silinenecek değeri ekrana getirdik
        {
            var marka = await _context.Brands.FindAsync(id);
            return View(marka);
        }

        // POST: BrandController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Brand brand)
        {
            try
            {
                //  _context.Brands.Remove(brand); // buda silme yöntemi
                //  _context.Attach<Brand>(brand).State=EntityState.Deleted;//buda başka silme yöntemi

              //  _context.Entry<Brand>(brand).State = EntityState.Deleted;//buda başka bir silme yöntemi

              _context.Remove(brand);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
