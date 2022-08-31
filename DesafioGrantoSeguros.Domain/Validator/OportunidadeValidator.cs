using DesafioGrantoSeguros.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Domain.Validator
{
    public class OportunidadeValidator : AbstractValidator<Oportunidade>
    {
        public OportunidadeValidator()
        {
            RuleFor(x => x.CNPJ)
                .NotNull()
                .NotEmpty()
                .Matches("([0-9]{14})|([0-9]{2}[\\.][0-9]{3}[\\.][0-9]{3}[\\/][0-9]{4}[-][0-9]{2})")
                .WithMessage("CNPJ deve estar no formato '00000000000000' ou '00.000.000/0000-00'"); 

            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.ValorMonetario)
                .NotNull()
                .NotEmpty();
        }
    }
}
