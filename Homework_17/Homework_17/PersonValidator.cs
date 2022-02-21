using FluentValidation;
using Homework_17.domain;

namespace Homework_17
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.CreateDate).LessThan(System.DateTime.Today);
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("The firstName column is empty").Length(0, 50).WithMessage("FirstName Length is more than 50");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("The lastName column is empty").Length(0, 50).WithMessage("LastName Length is more than 50");
            RuleFor(x => x.JobPosition).NotEmpty().WithMessage("The job position column is empty").Length(0, 50).WithMessage("Job Position Length is more than 50");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("The salary column is empty").LessThan(10000).WithMessage("Salary quantity is more than 10000 ");
            RuleFor(x => x.WorkExperience).NotEmpty().WithMessage("The work experience column is empty").Length(0, 150).WithMessage(" work experience Length is more than 150");
            RuleFor(x=> x.Adresses.Country).NotEmpty().WithMessage("The country column is empty");
            RuleFor(x => x.Adresses.City).NotEmpty().WithMessage("The city column is empty");
            RuleFor(x => x.Adresses.Homenumber).NotEmpty().WithMessage("The home number column is empty");
        }
    }
}
