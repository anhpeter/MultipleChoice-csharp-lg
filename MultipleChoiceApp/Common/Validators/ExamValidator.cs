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
    public class ExamValidator : AbstractValidator<Exam>
    {

        public ExamValidator()
        {
            RuleFor(p => p.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Name"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Name", 50));

            RuleFor(p => p.Semester)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Semester"))
                .InclusiveBetween(2131, 2134).WithMessage(string.Format(Msg.VLD_BETWEEN, "Semester", 2131, 2134));

            RuleFor(p => p.EasyQty)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must((ex, easyQty) => (easyQty >= 0 && easyQty <= ex.Subject.TotalQuestion - ex.HardQty)).WithMessage((ex) => string.Format(Msg.VLD_BETWEEN, "Easy question qty", 0, ex.Subject.TotalQuestion - (ex.HardQty >= 0 ? ex.HardQty : 0)))
                .Must((ex, easyQty) => ex.HardQty + easyQty <= ex.Subject.TotalQuestion).WithMessage((ex) => $"Easy and hard question quantity must not exeeding total question ({ex.Subject.TotalQuestion} questions).");

            RuleFor(p => p.HardQty)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must((ex, hardQty) => (hardQty >= 0 && hardQty <= ex.Subject.TotalQuestion - ex.EasyQty)).WithMessage((ex) => string.Format(Msg.VLD_BETWEEN, "Hard question qty", 0, ex.Subject.TotalQuestion - (ex.EasyQty >= 0 ? ex.EasyQty : 0)));
        }
    }
}
