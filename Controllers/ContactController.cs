using ContactManagementApi.Models;
using ContactManagementApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ContactManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly MockContactRepository _repository;

        public ContactsController(MockContactRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetContacts() => Ok(_repository.GetContacts());

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var contact = _repository.GetContact(id);
            if (contact == null) return NotFound();
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult CreateContact([FromBody] Contact contact)
        {
            if (contact == null || string.IsNullOrEmpty(contact.FirstName) || string.IsNullOrEmpty(contact.LastName) || !new EmailAddressAttribute().IsValid(contact.Email))
            {
                return BadRequest("Invalid contact data.");
            }
            var createdContact = _repository.AddContact(contact);
            return CreatedAtAction(nameof(GetContact), new { id = createdContact.Id }, createdContact);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] Contact contact)
        {
            if (contact == null || contact.Id != id || !new EmailAddressAttribute().IsValid(contact.Email))
            {
                return BadRequest("Invalid contact data.");
            }
            var updatedContact = _repository.UpdateContact(contact);
            if (updatedContact == null) return NotFound();
            return Ok(updatedContact);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var result = _repository.DeleteContact(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
