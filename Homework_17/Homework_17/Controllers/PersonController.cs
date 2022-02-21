using FluentValidation;
using Homework_17.data;
using Homework_17.domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace Homework_17.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly PersonContext _context;
        public PersonController(PersonContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(Person person)
        {
            var personValidator = new PersonValidator();
            var result = personValidator.Validate(person);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetPersons", new { id = person.ID }, person);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
        {
            return await _context.Persons.ToListAsync();
        }

        [HttpGet("persons/{id}")]
        public IActionResult GetPersonsById(int id)
        {
            return Ok(_context.Persons.Find(id));
        }

        [HttpGet("Filter Person")]
        public IActionResult FilterPersons([FromQuery] Person person)
        {
            return Ok(_context.Persons.Where(x => x.Salary > person.Salary && x.CreateDate > person.CreateDate));
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeletePersonsById(int id)
        {
            var person = _context.Persons.Find(id);
            _context.Persons.Remove(person);
            _context.SaveChanges();
            return Ok(_context.Persons);
        }

        // mokled, aq ra agar vcade mara exception mianc ver movishore :dd
        [HttpPut("Update/{id}")]
        public IActionResult UpdatePerson([FromBody] Person person, int id)
        {           
            try
            {
                using (PersonContext context = new PersonContext())
                {
                    var entity = context.Persons.FirstOrDefault(p => p.ID == id);
                    if (entity == null)
                    {
                        return BadRequest("Employee with Id " + id.ToString() + " not found to update");
                    }
                    else
                    {
                        entity.FirstName = person.FirstName;
                        entity.LastName = person.LastName;
                        entity.CreateDate = person.CreateDate;
                        entity.Salary = person.Salary;
                        entity.JobPosition = person.JobPosition;
                        entity.WorkExperience = person.WorkExperience;
                        entity.Adresses = person.Adresses;

                        context.SaveChanges();
                        return Ok(context);
                    }
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
