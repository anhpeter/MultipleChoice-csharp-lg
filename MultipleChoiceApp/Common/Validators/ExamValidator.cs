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
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Easy qty"))
                .Must(v => v > -1).WithMessage(string.Format(Msg.VLD_NUMBER, "Easy qty"))
                .Must((ex, easyQty) => ex.HardQty+easyQty<=ex.Subject.TotalQuestion).WithMessage((ex)=>$"Easy question qty + hard question qty must <= {ex.Subject.TotalQuestion}");

            RuleFor(p => p.HardQty)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Hard qty"))
                .Must(v => v > -1).WithMessage(string.Format(Msg.VLD_NUMBER, "Hard qty"));
        }
    }
}
