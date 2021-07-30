using APIBank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBank.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        public List<Person> data; 
        public PersonsController()
        {
            data = Mocks.FillData();
        }
        [HttpGet]
        public async Task<IActionResult> GetPersons(string email, string phoneNumber)
        {
            if(email != null && phoneNumber == null)
            {
                return Ok(data.Select(p => new Person
                {
                    DocumentID = p.DocumentID,
                    Email = p.Email,
                    ID = p.ID,
                    Name = p.Name,
                    LastName = p.LastName,
                    PhoneNumber = p.PhoneNumber
                }).Where(x=>x.Email == email).FirstOrDefault());
            }
            if (email == null && phoneNumber != null)
            {
                return Ok(data.Select(p => new Person
                {
                    DocumentID = p.DocumentID,
                    Email = p.Email,
                    ID = p.ID,
                    Name = p.Name,
                    LastName = p.LastName,
                    PhoneNumber = p.PhoneNumber
                }).Where(x => x.PhoneNumber == phoneNumber).FirstOrDefault());
            }
            if (email == null && phoneNumber == null)
            {
                return Ok(data.Select(p => new Person
                {
                    DocumentID = p.DocumentID,
                    Email = p.Email,
                    ID = p.ID,
                    Name = p.Name,
                    LastName = p.LastName,
                    PhoneNumber = p.PhoneNumber
                }).ToList());
            }
            if (email != null && phoneNumber != null)
            {
                return Ok(data.Select(p => new Person
                {
                    DocumentID = p.DocumentID,
                    Email = p.Email,
                    ID = p.ID,
                    Name = p.Name,
                    LastName = p.LastName,
                    PhoneNumber = p.PhoneNumber
                }).Where(x => x.Email == email && x.PhoneNumber == phoneNumber).FirstOrDefault());
            }
            return Conflict("Error Desconocido");
        }
        [HttpGet("{documentId}")]
        public async Task<IActionResult> GetPerson(string documentId)
        {
            return Ok(data.Select(p => new Person
            {
                DocumentID = p.DocumentID,
                Email = p.Email,
                ID = p.ID,
                Name = p.Name,
                LastName = p.LastName,
                PhoneNumber = p.PhoneNumber
            }).Where(x=>x.DocumentID == documentId).FirstOrDefault());
        }
        [HttpGet("{documentId}/Accounts")]
        public async Task<IActionResult> GetAccounts(string documentId)
        {
            var person = data.Where(p => p.DocumentID == documentId).FirstOrDefault();
            if(person == null)
            {
                return NoContent();
            }
            return Ok(person.Accounts);
        }
    }
}
