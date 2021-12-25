using FluentValidation;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Bi.Subject;

namespace MultipleChoiceApp.Common.Validators
{
    public class SubjectValidator : AbstractValidator<Subject>
    {

        public SubjectValidator()
        {
            RuleFor(p => p.Code)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Subject code"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Subject code", 50));

            RuleFor(p => p.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Subject name"))
                .MaximumLength(200).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Subject name", 200));

            RuleFor(p => p.Lecturer)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Lecturer"))
                .MaximumLength(200).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Lecturer", 200));

            RuleFor(p => p.TotalQuestion)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Total question"))
                .InclusiveBetween(5, 100).WithMessage(string.Format(Msg.VLD_BETWEEN, "Total Question", 5, 40));

            RuleFor(p => p.Duration)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Duration"))
                .InclusiveBetween(1, 300).WithMessage(string.Format(Msg.VLD_BETWEEN, "Duration", 1, 300));

        }
    }
}
