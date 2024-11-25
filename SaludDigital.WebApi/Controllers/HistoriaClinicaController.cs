// HistoriaClinicaController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using Logica;
using Entidades;

[Route("api/[controller]")]
[ApiController]
public class HistoriaClinicaController : ControllerBase
{
    private readonly HistoriaClinicaBLL _historiaClinicaBLL;

    public HistoriaClinicaController(HistoriaClinicaBLL historiaClinicaBLL)
    {
        _historiaClinicaBLL = historiaClinicaBLL;
    }

    [HttpGet("paciente/{idPaciente}")]
    public IActionResult GetHistoriasPorPaciente(int idPaciente)
    {
        try
        {
            var historias = _historiaClinicaBLL.ObtenerHistoriasClinicasPorPaciente(idPaciente);
            return Ok(historias);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al obtener historias clínicas: {ex.Message}");
        }
    }

    [HttpGet("cita/{idCita}")]
    public IActionResult GetHistoriaPorCita(int idCita)
    {
        try
        {
            var historia = _historiaClinicaBLL.ObtenerHistoriaClinicaPorIdCita(idCita);
            return Ok(historia);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al obtener historia clínica: {ex.Message}");
        }
    }
}