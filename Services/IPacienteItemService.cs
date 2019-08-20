using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiPrimerMVC.Models;

namespace MiPrimerMVC.Services
{
    public interface IPacienteItemService
    {
        Task<Paciente[]> GetIncompleteItemsAsync();
    }
}