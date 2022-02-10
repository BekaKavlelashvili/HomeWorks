using FluentValidation;
using Homework_14.Models;

namespace Homework_14
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.CreateDate).LessThan(System.DateTime.Today);
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("The firstName column is empty").Length(0, 50).WithMessage("Length is not correct");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("The lastName column is empty").Length(0, 50).WithMessage("Length is not correct");
            RuleFor(x => x.JobPosition).NotEmpty().WithMessage("The job position column is empty").Length(0, 50).WithMessage("Length is not correct");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("The salary column is empty").LessThan(10000).WithMessage("Quantity is not correct");
            RuleFor(x => x.WorkExperience).NotEmpty().WithMessage("The work experience column is empty").Length(0, 150).WithMessage("Length is not correct");
            RuleFor(x => x.Country).NotEmpty().WithMessage("The country column is empty");
            RuleFor(x => x.City).NotEmpty().WithMessage("The city column is empty");
            RuleFor(x => x.HomeNumber).NotEmpty().WithMessage("The home number column is empty");
        }
    }
}
