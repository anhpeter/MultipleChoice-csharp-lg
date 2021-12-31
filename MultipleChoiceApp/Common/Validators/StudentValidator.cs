using FluentValidation;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Bi.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {

        StudentServiceSoapClient studentS = new StudentServiceSoapClient();
        public StudentValidator()
        {
            RuleFor(p => p.Code)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Student code"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Student code", 50))
                .Must((Code) => {
                    Student student = studentS.getByCode(Code);
                    bool result =  student == null;
                    return result;
                }).WithMessage((ex) => "Student code must be unique"); 

            RuleFor(p => p.FullName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Full name"))
                .MaximumLength(50).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Full name", 50));

            RuleFor(p => p.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Address"))
                .MaximumLength(200).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Address", 200));

            RuleFor(p => p.Major)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(string.Format(Msg.VLD_REQURIED, "Major"))
                .MaximumLength(20).WithMessage(string.Format(Msg.VLD_MAX_LENGTH, "Major", 20));
        }
    }
}
