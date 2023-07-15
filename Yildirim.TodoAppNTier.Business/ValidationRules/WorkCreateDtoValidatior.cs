using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yildirim.TodoAppNTier.DataAccess.Configurations;
using Yildirim.TodoAppNTier.Dtos.WorkDtos;

namespace Yildirim.TodoAppNTier.Business.ValidationRules
{
    public class WorkCreateDtoValidatior : AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidatior()
        {
            RuleFor(X => X.Definition).NotEmpty();
        }

    }
}
