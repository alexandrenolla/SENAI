using aula01.Controllers;
using FluentValidation;
using aula01.Dtos;

namespace aula01.Validators;

public class FilmeCriacaoDtoValidator : AbstractValidator<FilmeCriacaoDto>
{

    public FilmeCriacaoDtoValidator()
    {
        RuleFor(x => x.Titulo).NotEmpty().NotNull().WithMessage("Título inválido.").Length(2,200).WithMessage("O tamanho do título deve ser de 2 a 200 caracteres.");
        RuleFor(x => x.DataDeLancamento).NotEmpty().NotNull().WithMessage("Data de lançamento inválida.").GreaterThan(DateTime.Now).WithMessage("O lançamento deve ser posterior à data de hoje.");
        RuleFor(x => x.Genero).NotEmpty().NotNull().WithMessage("Genero inválido.").Length(2,10).WithMessage("O tamanho do Genero deve ser de 2 a 10 caracteres.");
        
    }
    
} 