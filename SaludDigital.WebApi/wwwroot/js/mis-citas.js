// mis-citas.js
const API_BASE_URL = 'https://localhost:7218/api';

document.addEventListener('DOMContentLoaded', async function () {
    if (!sessionService.isAuthenticated()) {
        window.location.href = '/index.html';
        return;
    }

    const userInfo = sessionService.getUserInfo();
    if (userInfo) {
        document.getElementById('userName').textContent = `${userInfo.nombres} ${userInfo.apellidos}`;
    }

    await cargarCitas();
    setupFiltros();
});

async function cargarCitas() {
    try {
        const userInfo = sessionService.getUserInfo();
        if (!userInfo) {
            throw new Error('No se encontró información del usuario');
        }
        const pacienteResponse = await fetch(`${API_BASE_URL}/Paciente/por-usuario/${userInfo.idUsuario}`);
        if (!pacienteResponse.ok) {
            throw new Error('Error al obtener información del paciente');
        }

        const pacienteData = await pacienteResponse.json();
        if (!pacienteData.success || !pacienteData.data) {
            throw new Error('No se encontró la información del paciente');
        }
        console.log(pacienteData.IdPaciente);
        console.log(pacienteData);

        const response = await fetch(`${API_BASE_URL}/Cita/${pacienteData.data.IdPaciente}/mis-citas`);
        console.log(response);
        const resultado = await response.json();
        console.log(resultado);


        if (resultado.success && Array.isArray(resultado.data)) {
            mostrarCitas(resultado.data);
            cargarEspecialidades(resultado.data);
        } else {
            mostrarMensajeNoCitas();
        }
    } catch (error) {
        console.error('Error al cargar citas:', error);
        mostrarMensajeError();
    }
}

function mostrarCitas(citas) {
    const container = document.getElementById('citasContainer');
    container.innerHTML = '';

    if (citas.length === 0) {
        mostrarMensajeNoCitas();
        return;
    }

    citas.forEach(cita => {
        const card = crearTarjetaCita(cita);
        container.appendChild(card);
    });
}

function crearTarjetaCita(cita) {
    const citaCard = document.createElement('div');
    citaCard.className = 'cita-card';

    citaCard.innerHTML = `
        <div class="cita-header">
            <span class="cita-fecha">${new Date(cita.Fecha).toLocaleDateString()}</span>
            <span class="cita-estado estado-${cita.Estado.toLowerCase()}">${cita.Estado}</span>
        </div>
        <div class="cita-info">
            <div class="cita-info-item">
                <span class="cita-label">Doctor:</span>
                <span class="cita-value">${cita.Doctor.Nombre}</span>
            </div>
            <div class="cita-info-item">
                <span class="cita-label">Especialidad:</span>
                <span class="cita-value">${cita.Doctor.Especialidad.NombreEspecialidad}</span>
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

function cargarEspecialidades(citas) {
    const especialidades = new Set();
    citas.forEach(cita => {
        if (cita.Doctor && cita.Doctor.Especialidad) {
            especialidades.add(cita.Doctor.Especialidad.NombreEspecialidad);
        }
    });

    const select = document.getElementById('filterEspecialidad');
    especialidades.forEach(especialidad => {
        const option = document.createElement('option');
        option.value = especialidad;
        option.textContent = especialidad;
        select.appendChild(option);
    });
}

function setupFiltros() {
    const filterEstado = document.getElementById('filterEstado');
    const filterFecha = document.getElementById('filterFecha');
    const filterEspecialidad = document.getElementById('filterEspecialidad');

    const filtros = [filterEstado, filterFecha, filterEspecialidad];
    filtros.forEach(filtro => {
        filtro.addEventListener('change', aplicarFiltros);
    });
}

async function aplicarFiltros() {
    const estado = document.getElementById('filterEstado').value;
    const fecha = document.getElementById('filterFecha').value;
    const especialidad = document.getElementById('filterEspecialidad').value;

    try {
        const response = await fetch(`${API_BASE_URL}/Cita/mis-citas`);
        const resultado = await response.json();

        if (resultado.success && Array.isArray(resultado.data)) {
            let citasFiltradas = resultado.data;

            if (estado) {
                citasFiltradas = citasFiltradas.filter(cita => cita.Estado === estado);
            }

            if (fecha) {
                citasFiltradas = citasFiltradas.filter(cita =>
                    cita.FechaCita.substring(0, 10) === fecha
                );
            }

            if (especialidad) {
                citasFiltradas = citasFiltradas.filter(cita =>
                    cita.Doctor.Especialidad.NombreEspecialidad === especialidad
                );
            }

            mostrarCitas(citasFiltradas);
        }
    } catch (error) {
        console.error('Error al aplicar filtros:', error);
    }
}

async function cancelarCita(idCita) {
    if (!confirm('¿Está seguro de que desea cancelar esta cita?')) {
        return;
    }

    try {
        const response = await fetch(`${API_BASE_URL}/Cita/${idCita}/cancelar`, {
            method: 'PUT'
        });

        if (response.ok) {
            await cargarCitas();
        } else {
            alert('Error al cancelar la cita');
        }
    } catch (error) {
        console.error('Error al cancelar cita:', error);
        alert('Error al cancelar la cita');
    }
}

function formatearFecha(fecha) {
    const opciones = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
    return fecha.toLocaleDateString('es-ES', opciones);
}

function mostrarMensajeNoCitas() {
    const container = document.getElementById('citasContainer');
    container.innerHTML = `
        <div class="no-citas">
            <i class="fas fa-calendar-times fa-3x" style="color: var(--text-color); margin-bottom: 1rem;"></i>
            <h2>No tienes citas programadas</h2>
            <p>Programa una nueva cita médica para comenzar</p>
        </div>
    `;
}

function mostrarMensajeError() {
    const container = document.getElementById('citasContainer');
    container.innerHTML = `
        <div class="no-citas">
            <i class="fas fa-exclamation-triangle fa-3x" style="color: var(--danger-color); margin-bottom: 1rem;"></i>
            <h2>Error al cargar las citas</h2>
            <p>Por favor, intente nuevamente más tarde</p>
        </div>
    `;
}
function agregarBotonHistoriaClinica(citaElement, idCita) {
    const actionsDiv = citaElement.querySelector('.cita-actions');
    const botonHistoria = document.createElement('button');
    botonHistoria.className = 'btn btn-primary';
    botonHistoria.innerHTML = '<i class="fas fa-notes-medical"></i> Ver Historia';
    botonHistoria.onclick = () => verHistoriaClinica(idCita);
    actionsDiv.appendChild(botonHistoria);
}