using Homework_14.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_14.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpPost("adduser")]
        public IActionResult AddRespodent(Person person)
        {
            var validator = new PersonValidator();
            var result = validator.Validate(person);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            var respodentsList = new List<Person> { };
            Person myPerson = new Person()
            {
                CreateDate = person.CreateDate,
                FirstName = person.FirstName,
                LastName = person.LastName,
                JobPosition = person.JobPosition,
                Salary = person.Salary,
                WorkExperience = person.WorkExperience,
                Country = person.Country,
                City = person.City,
                HomeNumber = person.HomeNumber
            };
            respodentsList.Add(myPerson);
            if (respodentsList.Count == 0)
            {
                return BadRequest("Sorry, respodent was not added");
            }
            else
            {
                return Ok(respodentsList);
            }
        }

        [HttpGet("respodent")]
        public IActionResult GetRespodent()
        {
            var GetrespodentList = new List<object>
            {
                new { user = "Tom", age = 5 },
                new { user = "Sam", age = 35 },
                new { user = "Bill", age = 25 },
                new { user = "Holland", age = 55},
                new { user = "Smith", age = 70},
                new { user = "david", age = 10}
            };
            return Ok(GetrespodentList);
        }

        [HttpGet("respodent/{id}")]
        public IActionResult GetRespodentById(int id)
        {
            var GetrespodentList = new List<object>
            {
                new { user = "Tom", age = 5, id = 1},
                new { user = "Sam", age = 35, id = 2 },
                new { user = "Bill", age = 25, id = 3},
                new { user = "Holland", age = 55, id = 4},
                new { user = "Smith", age = 70, id = 5},
                new { user = "david", age = 10, id = 6}
            };
            return Ok(GetrespodentList[id]);
        }


        [HttpGet("filteruser")]
        public IActionResult FilterRespodent([FromQuery] Person person)
        {
            var respodentsList = new List<Person>
            {
                new Person()
                {
                    CreateDate = DateTime.Parse("2022-02-07"),
                    FirstName = "Json",
                    LastName = "Jonson",
                    JobPosition = "Manager",
                    Salary = 8500,
                    WorkExperience = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur. ",
                    Country = "German",
                    City = "Berlin",
                    HomeNumber = 581357
                },
                new Person()
                {
                    CreateDate = DateTime.Parse("2022-01-28"),
                    FirstName = "Lamar",
                    LastName = "Bagaturia",
                    JobPosition = "Actor",
                    Salary = 3500,
                    WorkExperience = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur. ",
                    Country = "Georgia",
                    City = "Tbilisi",
                    HomeNumber = 438156
                },
                new Person()
                {
                    CreateDate = DateTime.Parse("2022-01-15"),
                    FirstName = "Bondo",
                    LastName = "Agenti",
                    JobPosition = "Agenti",
                    Salary = 6000,
                    WorkExperience = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur. ",
                    Country = "India",
                    City = "Dell",
                    HomeNumber = 5379812
                }
            };
            return Ok(respodentsList.Where(x => x.Salary > person.Salary && x.CreateDate > person.CreateDate));
        }


        [HttpDelete("deleterespodent/{id}")]
        public IActionResult DeleteRespodentById(int id)
        {
            var GetrespodentList = new List<object>
            {
                new { user = "Tom", age = 5, id = 1},
                new { user = "Sam", age = 35, id = 2 },
                new { user = "Bill", age = 25, id = 3},
                new { user = "Holland", age = 55, id = 4},
                new { user = "Smith", age = 70, id = 5},
                new { user = "david", age = 10, id = 6}
            };

            GetrespodentList.RemoveAt(--id);
            if (GetrespodentList.Count == 6)
            {
                return BadRequest("Sorry, respodent was not deleted");
            }
            else
            {
                return Ok(GetrespodentList);
            }
        }


        [HttpPut("updaterespodent/{listindex}")]
        public IActionResult UpdateRespodent(int listindex, Person person)
        {
            var respodentsList = new List<Person>
            {
                new Person()
                {
                    CreateDate = DateTime.Parse("2022-02-07"),
                    FirstName = "Json",
                    LastName = "Jonson",
                    JobPosition = "Manager",
                    Salary = 8500,
                    WorkExperience = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur. ",
                    Country = "German",
                    City = "Berlin",
                    HomeNumber = 581357
                },
                new Person()
                {
                    CreateDate = DateTime.Parse("2022-01-28"),
                    FirstName = "Lamar",
                    LastName = "Bagaturia",
                    JobPosition = "Actor",
                    Salary = 3500,
                    WorkExperience = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur. ",
                    Country = "Georgia",
                    City = "Tbilisi",
                    HomeNumber = 438156
                },
                new Person()
                {
                    CreateDate = DateTime.Parse("2022-01-15"),
                    FirstName = "Bondo",
                    LastName = "Agenti",
                    JobPosition = "Agenti",
                    Salary = 6000,
                    WorkExperience = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur. ",
                    Country = "India",
                    City = "Dell",
                    HomeNumber = 5379812
                }
            };
            respodentsList[listindex].CreateDate = person.CreateDate;
            respodentsList[listindex].FirstName = person.FirstName;
            respodentsList[listindex].LastName = person.LastName;
            respodentsList[listindex].JobPosition = person.JobPosition;
            respodentsList[listindex].Salary = person.Salary;
            respodentsList[listindex].WorkExperience = person.WorkExperience;
            respodentsList[listindex].Country = person.Country;
            respodentsList[listindex].City = person.City;
            respodentsList[listindex].HomeNumber = person.HomeNumber;

            return Ok(respodentsList);
        }
    }
}

