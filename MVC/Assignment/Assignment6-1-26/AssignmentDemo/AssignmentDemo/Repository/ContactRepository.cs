using AssignmentDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace AssignmentDemo.Repository
{
    public class ContactRepository : IContactRepository
    {
        ContactContext Contcontext;

        public ContactRepository()
        {
            Contcontext = new ContactContext();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await Contcontext.Contacts.ToListAsync();
        }

        public async Task CreateAsync(Contact contact)
        {
            Contcontext.Contacts.Add(contact);
            await Contcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var contact = await Contcontext.Contacts.FindAsync(id);
            if (contact != null)
            {
                Contcontext.Contacts.Remove(contact);
                await Contcontext.SaveChangesAsync();
            }
        }
    }
}