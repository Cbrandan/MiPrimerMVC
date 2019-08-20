using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiPrimerMVC.Models;
using MiPrimerMVC.Services;

namespace MiPrimerMVC.Controllers
{
    public class PacientesController : Controller
    {
        private readonly IPacienteItemService _PacienteItemService;
        public PacientesController(IPacienteItemService PacienteItemService)
        {
            _PacienteItemService = PacienteItemService;
        }

         public async Task<IActionResult> PacientesAsync()
        {
            var ItemsPacientes = await _PacienteItemService.GetIncompleteItemsAsync();
            var model = new PacientesViewModel(){
                ListaPacientes = ItemsPacientes
            };

            return View(model);
        }
    }
}