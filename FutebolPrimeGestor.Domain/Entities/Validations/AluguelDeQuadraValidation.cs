using FluentValidation;

namespace FutebolPrimeGestor.Domain.Entities.Validations
{
    public class AluguelDeQuadraValidation : AbstractValidator<AluguelDeQuadra>
    {
        public AluguelDeQuadraValidation()
        {
            RuleFor(x => x.ValorFinalAluguel)
                .GreaterThan(0).WithMessage("Houve um erro ao confirmar o valor final do Aluguel, verifique o valor da Quadra, se o problema persister entre em contato com o suporte.");
        }
    }
}
