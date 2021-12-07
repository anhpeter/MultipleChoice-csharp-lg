using FluentValidation;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Validators
{
    public class AnswerValidator : AbstractValidator<Answer>
    {

        public AnswerValidator()
        {
            RuleFor(x => x.Content)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage((x) => $"Answer {x.No}  is required");
        }
    }
}
