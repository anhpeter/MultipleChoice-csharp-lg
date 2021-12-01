using FluentValidation;
using MultipleChoiceApp.Common.Helpers;
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
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Question"))
                .Length(2, 300).WithMessage(string.Format(Msg.VLD_LENGTH_BETWEEN, "Question", 2, 300));

            RuleForEach(p => p.Answers).SetValidator(new AnswerValidator());

            RuleFor(p => p.Chapter)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Chapter"))
                .InclusiveBetween(1, 100).WithMessage(string.Format(Msg.VLD__BETWEEN, "Chapter", 1, 100));

        }
    }
}
