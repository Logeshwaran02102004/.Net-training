using AssignmentDemo.Models;
using AssignmentDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AssignmentDemo.Controllers
{
    public class ContactController : Controller
    {
       
       
        
            IContactRepository _contactRepository = null;
        


        public ContactController()
        {
            _contactRepository = new ContactRepository();
        }

      
        public async Task<ActionResult> Index()
        {
            var contacts = await _contactRepository.GetAllAsync();
            return View(contacts);
        }

 
        public ActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _contactRepository.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

    
        public async Task<ActionResult> Delete(long id)
        {
            await _contactRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}