using FluentValidation;
using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Validators
{
    public class QuestionValidator : AbstractValidator<Question>
    {

        public QuestionValidator()
        {
            RuleFor(p => p.Content)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Question is required")
                .Length(2, 300).WithMessage("{PropertyName} length must between 2-300");

            RuleForEach(p => p.Answers).SetValidator(new AnswerValidator());
        }
    }
}
