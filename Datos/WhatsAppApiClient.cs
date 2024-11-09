using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Cliente para interactuar con la API de WhatsApp Business
/// </summary>
public class ClienteWhatsApp
{
    private readonly HttpClient _clienteHttp;
    private readonly string _tokenAcceso;
    private readonly string _idTelefono;
    private const string UrlBase = "https://graph.facebook.com/v21.0/";

    /// <summary>
    /// Constructor del cliente de WhatsApp
    /// </summary>
    public ClienteWhatsApp()
    {
        _clienteHttp = new HttpClient();
        _tokenAcceso = "EAAILTRkdXQIBO8cB1vc2lGZCZA3HpPPBiJ9wAZBtgOAUlYsICaFh0qtFnxoZA95J8ytI3gCfljmzJZCXkg83hiIKsoE6hxTdLwZCBzefAkfgzSQE1lIDzhymHvuKBIZBXToNSkejXuZCaOhZBf09JbZBHOWvQ150F4ZCRCwl8cJPurfTNpKhBDy0bJAMB0iTLNE5JDdTWx2VV85cpu5f7oviBZAzQZAXQygZDZD";
        _idTelefono = "536741016181404";
        _clienteHttp.DefaultRequestHeaders.Add("Authorization", $"Bearer {_tokenAcceso}");
    }

    /// <summary>
    /// Envía un mensaje de texto simple
    /// </summary>
    /// <param name="numeroDestino">Número de teléfono del destinatario</param>
    /// <param name="mensaje">Contenido del mensaje</param>
    /// <returns>True si el envío fue exitoso</returns>
    public async Task<bool> EnviarMensajeTextoAsync(string numeroDestino, string mensaje)
    {
        try
        {
            var cuerpoSolicitud = new
            {
                messaging_product = "whatsapp",
                recipient_type = "individual",
                to = numeroDestino,
                type = "text",
                text = new { body = mensaje }
            };

            var json = JsonSerializer.Serialize(cuerpoSolicitud);
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");

            var respuesta = await _clienteHttp.PostAsync(
                $"{UrlBase}{_idTelefono}/messages",
                contenido
            );

            return respuesta.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al enviar mensaje: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Envía un mensaje usando una plantilla sin variables
    /// </summary>
    /// <param name="numeroDestino">Número de teléfono del destinatario</param>
    /// <param name="nombrePlantilla">Nombre de la plantilla a utilizar</param>
    /// <param name="idioma">Código de idioma (por defecto 'es' para español)</param>
    

    public async Task<bool> EnviarMensajePlantillaSimpleAsync(string numeroDestino, string nombrePlantilla, string idioma = "es_MX")
    {
        try
        {
            var cuerpoSolicitud = new
            {
                messaging_product = "whatsapp",
                to = numeroDestino,
                type = "template",
                template = new
                {
                    name = nombrePlantilla,
                    language = new { code = idioma }
                }
            };

            var json = JsonSerializer.Serialize(cuerpoSolicitud);
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");

            var respuesta = await _clienteHttp.PostAsync(
                $"{UrlBase}{_idTelefono}/messages",
                contenido
            );

            return respuesta.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al enviar mensaje de plantilla: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Envía una imagen mediante URL
    /// </summary>
    /// <param name="numeroDestino">Número de teléfono del destinatario</param>
    /// <param name="urlImagen">URL de la imagen a enviar</param>
    public async Task<bool> EnviarImagenAsync(string numeroDestino, string urlImagen)
    {
        try
        {
            var cuerpoSolicitud = new
            {
                messaging_product = "whatsapp",
                recipient_type = "individual",
                to = numeroDestino,
                type = "image",
                image = new { link = urlImagen }
            };

            var json = JsonSerializer.Serialize(cuerpoSolicitud);
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");

            var respuesta = await _clienteHttp.PostAsync(
                $"{UrlBase}{_idTelefono}/messages",
                contenido
            );

            return respuesta.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al enviar imagen: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Envía un mensaje usando una plantilla con variables
    /// </summary>
    /// <param name="numeroDestino">Número de teléfono del destinatario</param>
    /// <param name="nombrePlantilla">Nombre de la plantilla a utilizar</param>
    /// <param name="variablesPlantilla">Diccionario con las variables y sus valores</param>
    public async Task<bool> EnviarMensajePlantillaConVariablesAsync(string numeroDestino, string nombrePlantilla, Dictionary<string, string> variablesPlantilla)
    {
        try
        {
            // Construimos los componentes de la plantilla correctamente
            var cuerpoSolicitud = new
            {
                messaging_product = "whatsapp",
                to = numeroDestino,
                type = "template",
                template = new
                {
                    name = nombrePlantilla,
                    language = new { code = "en_US" },
                    components = new object[]
                    {
                    new
                    {
                        type = "body",
                        parameters = variablesPlantilla
                            .Select((kvp, index) => new
                            {
                                type = "text",
                                text = kvp.Value
                            })
                            .ToArray()
                    }
                    }
                }
            };

            var json = JsonSerializer.Serialize(cuerpoSolicitud, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            MessageBox.Show($"JSON a enviar:\n{json}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var contenido = new StringContent(json, Encoding.UTF8, "application/json");

            var respuesta = await _clienteHttp.PostAsync(
                $"{UrlBase}{_idTelefono}/messages",
                contenido
            );

            var responseContent = await respuesta.Content.ReadAsStringAsync();

            if (!respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    $"Error en la respuesta del servidor:\nCódigo: {respuesta.StatusCode}\nContenido: {responseContent}",
                    "Error de Respuesta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            MessageBox.Show(
                "Mensaje enviado exitosamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Error al enviar mensaje:\n{ex.Message}\n\nDetalles:\n{ex.StackTrace}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return false;
        }
    }    /// <summary>
         /// Marca un mensaje como leído
         /// </summary>
         /// <param name="idMensaje">ID del mensaje a marcar como leído</param>
    public async Task<bool> MarcarMensajeComoLeidoAsync(string idMensaje)
    {
        try
        {
            var cuerpoSolicitud = new
            {
                messaging_product = "whatsapp",
                status = "read",
                message_id = idMensaje
            };

            var json = JsonSerializer.Serialize(cuerpoSolicitud);
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");

            var respuesta = await _clienteHttp.PostAsync(
                $"{UrlBase}{_idTelefono}/messages",
                contenido
            );

            return respuesta.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al marcar mensaje como leído: {ex.Message}");
            return false;
        }
    }
}