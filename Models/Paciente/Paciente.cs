using System;
using System.ComponentModel.DataAnnotations;
namespace MiPrimerMVC.Models
{
public class Paciente : Persona
{
    public DateTimeOffset? Fecha_Alta { get; set; }

        public Paciente(int dni, string apellido, string nombre, char sexo, DateTimeOffset? fecha_nacimiento, DateTimeOffset? fecha_alta)
        : base(dni, apellido, nombre, sexo, fecha_nacimiento)
        {
            this.Fecha_Alta = fecha_alta;
        }
    }
}