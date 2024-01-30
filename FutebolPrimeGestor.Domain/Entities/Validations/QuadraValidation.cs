using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Domain.Entities.Validations
{
    public class QuadraValidation : AbstractValidator<Quadra>
    {
        public QuadraValidation()
        {
            RuleFor(x => x.Numero)
                .NotNull().WithMessage("O número da quadra precisa ser definido.")
                .GreaterThan(0).WithMessage("O número da quadra precisa ser maior que 0.");

            RuleFor(x => x.Valor)
                .GreaterThan(0).WithMessage("O número da quadra precisa ser maior que 0.");
        }
    }
}
