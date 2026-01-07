using AssignmentDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AssignmentDemo.Repository
{
    public class ContactRepository : IContactRepository
    {
        ContactContext _contactContext;

        public ContactRepository()
        {
            _contactContext = new ContactContext();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _contactContext.Contacts.ToListAsync();
        }

        public async Task CreateAsync(Contact contact)
        {
            _contactContext.Contacts.Add(contact);
            await _contactContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var contact = await _contactContext.Contacts.FindAsync(id);
            if (contact != null)
            {
                _contactContext.Contacts.Remove(contact);
                await _contactContext.SaveChangesAsync();
            }
        }
    }
}