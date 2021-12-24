using FluentValidation;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Validators
{
    public class ManagerValidator : AbstractValidator<Manager>
    {

        public ManagerValidator()
        {
            RuleFor(p => p.Code)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Manager code"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Manager code", 50));

            RuleFor(p => p.FullName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Full name"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Full name", 50));

            RuleFor(p => p.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Address"))
                .MaximumLength(200).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Address", 200));

            RuleFor(p => p.PhoneNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Phone"))
                .Matches("[0-9]{10}").WithMessage(string.Format(Msg.VLD_INVALID, "Phone"));

            RuleFor(p => p.Position)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Position"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Position", 50));
        }
    }
}
