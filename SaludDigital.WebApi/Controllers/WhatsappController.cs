using Microsoft.AspNetCore.Mvc;
using System.Globalization;

[Route("api/[controller]")]
[ApiController]
public class WhatsAppController : ControllerBase
{
    private readonly ClienteWhatsApp _whatsappCliente;

    public WhatsAppController()
    {
        _whatsappCliente = new ClienteWhatsApp();
    }

    [HttpPost("enviar-confirmacion")]
    public async Task<IActionResult> EnviarConfirmacionCita([FromBody] ConfirmacionCitaRequest request)
    {
        try
        {
            var variables = new Dictionary<string, string>
            {
                { "1", request.NombrePaciente },
                { "2", request.Especialidad },
                { "3", FormatearFecha(request.FechaCita) },
                { "4", FormatearHora(request.HoraCita) },
                { "5", request.NombreDoctor }
            };

            var numeroCompleto = $"57{request.NumeroTelefono}";
            var respuesta = await _whatsappCliente.EnviarMensajePlantillaConImagenYVariablesAsync(
                numeroCompleto,
                "citainfo",
                variables
            );

            return Ok(new { success = respuesta, message = respuesta ? "Mensaje enviado con éxito" : "Error al enviar mensaje" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { success = false, message = ex.Message });
        }
    }

    private string FormatearFecha(DateTime fecha)
    {
        return fecha.ToString("dd 'de' MMMM 'del' yyyy", new CultureInfo("es-ES"));
    }

    private string FormatearHora(string hora)
    {
        // Convertir la hora string (HH:mm:ss) a TimeSpan
        if (TimeSpan.TryParse(hora, out TimeSpan horaCita))
        {
            // Crear un DateTime con la hora
            DateTime dateTime = DateTime.Today.Add(horaCita);
            return dateTime.ToString("hh:mm tt").ToLower();
        }

        return hora; // Retornar la hora original si hay error en el parseo
    }
}

public class ConfirmacionCitaRequest
{
    public string NumeroTelefono { get; set; }
    public string NombrePaciente { get; set; }
    public string Especialidad { get; set; }
    public DateTime FechaCita { get; set; }
    public string HoraCita { get; set; }
    public string NombreDoctor { get; set; }
}