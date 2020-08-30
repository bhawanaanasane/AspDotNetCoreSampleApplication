using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeApplication.Models;
using PracticeApplication.Models.CoreTable;
using PracticeApplication.Models.ViewModel;
using System.Threading.Tasks;

namespace PracticeApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly dbContext _dbContext;
        public UserController(dbContext DbContext)
        {
            this._dbContext = DbContext;
        }
        public async Task<IActionResult> Index()
        {
            
            return View(await _dbContext.UserTable.ToListAsync());
        }

        public IActionResult CreateEditUSer(int Id = 0)
        {
           
             
                if(Id== 0)
            {
                return View(new UserTable());
            }
                else
            {
                return View(_dbContext.UserTable.Find(Id));
            }
            
           
        }
        [HttpPost]
        public IActionResult CreateEditUSer(UserTable model)
        {           
            if(model.Id == 0)
            {
                _dbContext.Add(model);
               
            }
            else
            {
                _dbContext.Update(model);
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete (int Id)
        {
            var userData = _dbContext.UserTable.Find(Id);
            _dbContext.Remove(userData);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
