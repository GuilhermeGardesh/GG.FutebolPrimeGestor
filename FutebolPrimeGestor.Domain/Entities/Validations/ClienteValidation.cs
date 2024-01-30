using FluentValidation;
using FutebolPrimeGestor.Domain.Entities.Validations.ValidationDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Domain.Entities.Validations
{
    internal class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.Nome)
                .NotNull().WithMessage("o campo nome deve ser preenchido.")
                .NotEmpty().WithMessage("o campo nome não pode ser espaços em branco.")
                .Length(2,100).WithMessage("O campo Nome precisa tem entre {MinLength} e {MaxLength caracteres.}");

            RuleFor(x => CpfValidation.Validar(x.CPF))
                .Equal(true).WithMessage("O CPF fornecido não é um CPF válido.");

            RuleFor(x => x.CPF.Length)
                .Equal(CpfValidation.TamanhoCpf).WithMessage("O CPF deve conter {ComparisonValue} caracteres.");
        }
    }
}
