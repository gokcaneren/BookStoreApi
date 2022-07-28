using BookStore.Core.DTOs.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Validations
{
    public class BookRequestValidator:AbstractValidator<AddBookRequest>
    {
        public BookRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} cant be null!").NotEmpty()
                .WithMessage("{PropertyName} cant be empty!");
            RuleFor(x => x.AuthorName).NotNull().WithMessage("{PropertyName} cant be null!").NotEmpty()
                .WithMessage("{PropertyName} cant be empty!");
            RuleFor(x => x.Stock).InclusiveBetween(1, 150).WithMessage("{PropertyName} cant be less than 0-{PropertyName} cant be greater than 150!")
                .NotEmpty().WithMessage("{PropertyName} cant be empty!");

        }
    }
}
