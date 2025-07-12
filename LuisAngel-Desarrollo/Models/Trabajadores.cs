using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LuisAngel_Desarrollo.Models;

public partial class Trabajadores
{
    public int Id { get; set; }


    [Required(ErrorMessage = "El tipo de documento es obligatorio.")]
    public string? TipoDocumento { get; set; }

    [Required(ErrorMessage = "El número de documento es obligatorio.")]
    public string? NumeroDocumento { get; set; }

    [Required(ErrorMessage = "Los nombres son obligatorios.")]
    public string? Nombres { get; set; }

    [Required(ErrorMessage = "Debe seleccionar el sexo.")]
    public string? Sexo { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un departamento.")]
    public int? IdDepartamento { get; set; }

    [Required(ErrorMessage = "Debe seleccionar una provincia.")]
    public int? IdProvincia { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un distrito.")]
    public int? IdDistrito { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    public virtual Distrito? IdDistritoNavigation { get; set; }

    public virtual Provincia? IdProvinciaNavigation { get; set; }

}
