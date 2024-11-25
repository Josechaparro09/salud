document.addEventListener('DOMContentLoaded', () => {
    const modal = document.getElementById('historiaClinicaModal');
    const closeBtn = document.querySelector('.close');

    if (closeBtn) {
        closeBtn.onclick = () => {
            modal.style.display = "none";
        };
    }

    window.onclick = (event) => {
        if (event.target === modal) {
            modal.style.display = "none";
        }
    };
});
async function verHistoriaClinica(idCita) {
    try {
        const response = await fetch(`/api/HistoriaClinica/cita/${idCita}`);
        if (!response.ok) {
            const errorText = await response.text();
            throw new Error(errorText);
        }

        const historia = await response.json();
        if (!historia) {
            throw new Error('No se encontró la historia clínica');
        }

        mostrarModalHistoriaClinica(historia);
    } catch (error) {
        console.error('Error completo:', error);
        alert('Error al cargar la historia clínica: ' + error.message);
    }
}

function mostrarModalHistoriaClinica(historia) {
    const modal = document.getElementById('historiaClinicaModal');
    const contenido = document.getElementById('historiaClinicaContenido');

    contenido.innerHTML = `
        <div class="historia-header">
            <h3>Historia Clínica #${historia.IdHistoriaClinica}</h3>
            <p><strong>Fecha:</strong> ${formatearFecha(historia.FechaCreacion)}</p>
        </div>
        <div class="historia-body">
            <div class="historia-section">
                <h4>Información del Paciente</h4>
                <p><strong>Nombre:</strong> ${historia.Paciente?.Nombre || 'N/A'} ${historia.Paciente?.Apellido || ''}</p>
                <p><strong>Cédula:</strong> ${historia.Paciente?.Cedula || 'N/A'}</p>
                <p><strong>Teléfono:</strong> ${historia.Paciente?.Telefono || 'N/A'}</p>
            </div>
            <div class="historia-section">
                <h4>Información del Doctor</h4>
                <p><strong>Nombre:</strong> ${historia.Doctor?.Nombre || 'N/A'}</p>
                <p><strong>Especialidad:</strong> ${historia.Doctor?.Especialidad?.NombreEspecialidad || 'N/A'}</p>
            </div>
            <div class="historia-section">
                <h4>Detalles Clínicos</h4>
                <p><strong>Diagnóstico:</strong> ${historia.Diagnostico || 'N/A'}</p>
                <p><strong>Tratamiento:</strong> ${historia.Tratamiento || 'N/A'}</p>
                <p><strong>Notas Adicionales:</strong> ${historia.NotasAdicionales || 'N/A'}</p>
            </div>
        </div>
    `;

    modal.style.display = 'block';
}
function logFecha(mensaje, fecha) {
    console.log(mensaje, {
        fechaOriginal: fecha,
        tipo: typeof fecha,
        valorString: String(fecha)
    });
}

function formatearFecha(fechaStr) {
    if (!fechaStr) return 'N/A';

    try {
        const fecha = fechaStr.split('T')[0]; // Obtiene YYYY-MM-DD
        const [año, mes, dia] = fecha.split('-');
        return `${dia}/${mes}/${año}`;
    } catch (error) {
        console.error('Error al formatear fecha:', fechaStr, error);
        return 'N/A';
    }
} ++


async function verHistoriaClinica(idCita) {
    try {
        console.log('Fetching historia for cita:', idCita);
        const response = await fetch(`/api/HistoriaClinica/cita/${idCita}`);

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Response not OK:', response.status, errorText);
            throw new Error(`Error del servidor: ${response.status}`);
        }

        const responseText = await response.text();
        console.log('Raw response:', responseText);

        if (!responseText) {
            throw new Error('Respuesta vacía del servidor');
        }

        const historia = JSON.parse(responseText);
        if (!historia) {
            throw new Error('No se encontró la historia clínica');
        }

        mostrarModalHistoriaClinica(historia);
    } catch (error) {
        console.error('Error completo:', error);
        alert('Error al cargar la historia clínica: ' + error.message);
    }
}
function formatearFecha(fechaStr) {
    if (!fechaStr) return 'N/A';

    try {
        // Manejo especial para fechas en formato string
        let fecha;
        if (typeof fechaStr === 'string') {
            // Remover la T y cualquier parte después de los segundos
            fechaStr = fechaStr.split('T')[0];
            const [año, mes, dia] = fechaStr.split('-');
            return `${dia}/${mes}/${año}`;
        } else {
            fecha = new Date(fechaStr);
            const dia = String(fecha.getDate()).padStart(2, '0');
            const mes = String(fecha.getMonth() + 1).padStart(2, '0');
            const año = fecha.getFullYear();
            return `${dia}/${mes}/${año}`;
        }
    } catch (error) {
        console.error('Error al formatear fecha:', fechaStr, error);
        return 'N/A';
    }
}

function crearTarjetaCita(cita) {
    console.log('Fecha original de la cita:', cita.FechaCita || cita.Fecha);
    const fechaFormateada = formatearFecha(cita.FechaCita || cita.Fecha);
    console.log('Fecha formateada:', fechaFormateada);

    const citaCard = document.createElement('div');
    citaCard.className = 'cita-card';

    citaCard.innerHTML = `
        <div class="cita-header">
            <span class="cita-fecha">${fechaFormateada}</span>
            <span class="cita-estado estado-${(cita.Estado || '').toLowerCase()}">${cita.Estado || 'N/A'}</span>
        </div>
        <div class="cita-info">
            <div class="cita-info-item">
                <span class="cita-label">Doctor:</span>
                <span class="cita-value">${cita.Doctor?.Nombre || 'N/A'}</span>
            </div>
            <div class="cita-info-item">
                <span class="cita-label">Especialidad:</span>
                <span class="cita-value">${cita.Doctor?.Especialidad?.NombreEspecialidad || 'N/A'}</span>
            </div>
        </div>
        <div class="cita-actions">
            <button class="btn btn-primary" onclick="verHistoriaClinica(${cita.IdCita})">
                <i class="fas fa-notes-medical"></i> Ver Historia
            </button>
        </div>
    `;

    return citaCard;
}