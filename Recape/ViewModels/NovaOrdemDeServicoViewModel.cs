﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Recape.ViewModels;

public class NovaOrdemDeServicoViewModel : DataViewModel
{
    public SelectList Servicos { get; set; }

    [Required(ErrorMessage = "Um serviço deve ser selecionado")]
    public int ServicoId { get; set; }


    public SelectList TiposVeiculo { get; set; }

    public string TipoSelecionado { get; set; }

    public SelectList Horarios { get; set; }

    [Required(ErrorMessage = "Um horário deve ser selecionado")]
    public int HorarioId { get; set; }

    public bool ExisteConflito { get; set; }

    public string Valor { get; set; }

    public string Placa { get; set; }
    public string Modelo { get; set; }
}
