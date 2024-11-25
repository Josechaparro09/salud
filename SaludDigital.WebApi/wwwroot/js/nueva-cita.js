// nueva-cita.js
const API_BASE_URL = 'https://localhost:7218/api';
let citaData = {
    especialidadId: null,
    doctorId: null,
    fecha: null,
    hora: null
};

document.addEventListener('DOMContentLoaded', async function () {
    console.log('Página cargada');
    await inicializarPagina();
    configurarEventListeners();
});

async function inicializarPagina() {
    try {
        if (!sessionService.isAuthenticated()) {
            window.location.href = '/index.html';
            return;
        }

        const userInfo = sessionService.getUserInfo();
        if (userInfo) {
            document.getElementById('userName').textContent = `${userInfo.nombres} ${userInfo.apellidos}`;
        }

        // Configurar fecha mínima (hoy) y máxima (3 meses adelante) para el input de fecha
        const fechaInput = document.getElementById('fecha');
        if (fechaInput) {
            const hoy = new Date();
            const tresMesesDespues = new Date();
            tresMesesDespues.setMonth(tresMesesDespues.getMonth() + 3);

            fechaInput.min = hoy.toISOString().split('T')[0];
            fechaInput.max = tresMesesDespues.toISOString().split('T')[0];
        }

        await cargarEspecialidades();

    } catch (error) {
        console.error('Error en inicialización:', error);
        mostrarError('Error al inicializar la página: ' + error.message);
    }
}

function configurarEventListeners() {
    const especialidadSelect = document.getElementById('especialidad');
    const doctorSelect = document.getElementById('doctor');
    const fechaInput = document.getElementById('fecha');

    if (especialidadSelect) {
        especialidadSelect.addEventListener('change', async function (e) {
            const idEspecialidad = e.target.value;
            console.log('Especialidad seleccionada:', idEspecialidad);

            citaData.especialidadId = idEspecialidad;
            citaData.doctorId = null; // Resetear doctor seleccionado

            if (idEspecialidad) {
                try {
                    await cargarDoctores(idEspecialidad);
                } catch (error) {
                    console.error('Error al cargar doctores:', error);
                    mostrarError('Error al cargar los doctores');
                }
            } else {
                resetearSelectDoctores();
            }
        });
    }

    if (doctorSelect) {
        doctorSelect.addEventListener('change', function (e) {
            citaData.doctorId = e.target.value;
            console.log('Doctor seleccionado:', e.target.value);
        });
    }

    if (fechaInput) {
        fechaInput.addEventListener('change', async function (e) {
            citaData.fecha = e.target.value;
            console.log('Fecha seleccionada:', e.target.value);
            if (citaData.doctorId && citaData.fecha) {
                await cargarHorarios();
            }
        });
    }
}

async function cargarEspecialidades() {
    const selectEspecialidad = document.getElementById('especialidad');
    const loadingIndicator = document.getElementById('especialidadLoadingIndicator');

    try {
        if (!selectEspecialidad) {
            throw new Error('No se encontró el elemento select de especialidades');
        }

        loadingIndicator.style.display = 'inline-block';
        selectEspecialidad.disabled = true;

        const response = await fetch(`${API_BASE_URL}/Especialidad`);
        const data = await response.json();

        // Limpiar el select
        selectEspecialidad.innerHTML = '<option value="">Seleccione una especialidad</option>';

        if (data.data && Array.isArray(data.data)) {
            data.data.forEach(especialidad => {
                const option = document.createElement('option');
                option.value = especialidad.IdEspecialidad;
                option.textContent = especialidad.NombreEspecialidad;
                selectEspecialidad.appendChild(option);
            });
        }

    } catch (error) {
        console.error('Error al cargar especialidades:', error);
        mostrarError('Error al cargar las especialidades: ' + error.message);
    } finally {
        selectEspecialidad.disabled = false;
        loadingIndicator.style.display = 'none';
    }
}

async function cargarDoctores(idEspecialidad) {
    const doctorSelect = document.getElementById('doctor');
    const loadingIndicator = document.getElementById('doctorLoadingIndicator');

    try {
        console.log('Iniciando carga de doctores para especialidad:', idEspecialidad);

        if (!doctorSelect) {
            throw new Error('No se encontró el elemento select de doctores');
        }

        // Mostrar indicador de carga
        loadingIndicator.style.display = 'inline-block';
        doctorSelect.disabled = true;
        doctorSelect.innerHTML = '<option value="">Cargando doctores...</option>';

        const response = await fetch(`${API_BASE_URL}/Doctor/por-especialidad/${idEspecialidad}`);
        const resultado = await response.json();

        console.log('Respuesta del servidor:', resultado);

        // Limpiar el select
        doctorSelect.innerHTML = '<option value="">Seleccione un doctor</option>';

        // Verificar si la respuesta es exitosa y contiene datos
        if (resultado.success && Array.isArray(resultado.data)) {
            if (resultado.data.length > 0) {
                console.log('Doctores encontrados:', resultado.data.length);
                resultado.data.forEach(doctor => {
                    const option = document.createElement('option');
                    option.value = doctor.IdDoctor;
                    option.textContent = doctor.Nombre;
                    doctorSelect.appendChild(option);
                });
                doctorSelect.disabled = false;
            } else {
                console.log('No se encontraron doctores');
                doctorSelect.innerHTML = '<option value="">No hay doctores disponibles</option>';
                doctorSelect.disabled = true;
            }
        } else {
            console.log('Respuesta inválida o sin datos');
            doctorSelect.innerHTML = '<option value="">No hay doctores disponibles</option>';
            doctorSelect.disabled = true;
        }

    } catch (error) {
        console.error('Error al cargar doctores:', error);
        doctorSelect.innerHTML = '<option value="">Error al cargar doctores</option>';
        doctorSelect.disabled = true;
        mostrarError('Error al cargar los doctores: ' + error.message);
    } finally {
        // Ocultar indicador de carga
        loadingIndicator.style.display = 'none';
    }
}

function resetearSelectDoctores() {
    const doctorSelect = document.getElementById('doctor');
    if (doctorSelect) {
        doctorSelect.innerHTML = '<option value="">Primero seleccione una especialidad</option>';
        doctorSelect.disabled = true;
    }
}

async function cargarHorarios() {
    const horariosGrid = document.getElementById('horariosGrid');

    try {
        if (!citaData.doctorId || !citaData.fecha) {
            horariosGrid.innerHTML = '<p>Seleccione doctor y fecha para ver horarios disponibles</p>';
            return;
        }

        horariosGrid.innerHTML = '<p>Cargando horarios...</p>';

        const response = await fetch(
            `${API_BASE_URL}/Cita/horarios-disponibles?idDoctor=${citaData.doctorId}&fecha=${citaData.fecha}`
        );
        const data = await response.json();

        horariosGrid.innerHTML = '';

        if (data.success && Array.isArray(data.data)) {
            if (data.data.length === 0) {
                horariosGrid.innerHTML = '<p>No hay horarios disponibles para esta fecha</p>';
                return;
            }

            data.data.forEach(hora => {
                const button = document.createElement('button');
                button.type = 'button';
                button.className = 'horario-btn';
                button.textContent = hora.substring(0, 5);
                button.onclick = () => seleccionarHorario(button);
                horariosGrid.appendChild(button);
            });
        } else {
            horariosGrid.innerHTML = '<p>No se pudieron cargar los horarios</p>';
        }

    } catch (error) {
        console.error('Error al cargar horarios:', error);
        horariosGrid.innerHTML = '<p>Error al cargar los horarios</p>';
        mostrarError('Error al cargar los horarios: ' + error.message);
    }
}

function seleccionarHorario(button) {
    document.querySelectorAll('.horario-btn').forEach(btn => {
        btn.classList.remove('selected');
    });
    button.classList.add('selected');
    citaData.hora = button.textContent;
}

function nextStep(currentStep) {
    if (validarPasoActual(currentStep)) {
        const currentStepElement = document.getElementById(`step${currentStep}`);
        const nextStepElement = document.getElementById(`step${currentStep + 1}`);

        if (currentStepElement && nextStepElement) {
            currentStepElement.classList.remove('active');
            nextStepElement.classList.add('active');
            actualizarIndicadorPasos(currentStep, currentStep + 1);

            if (currentStep === 2) {
                mostrarResumenCita();
            }
        }
    }
}

function prevStep(currentStep) {
    const currentStepElement = document.getElementById(`step${currentStep}`);
    const prevStepElement = document.getElementById(`step${currentStep - 1}`);

    if (currentStepElement && prevStepElement) {
        currentStepElement.classList.remove('active');
        prevStepElement.classList.add('active');
        actualizarIndicadorPasos(currentStep, currentStep - 1);
    }
}

function validarPasoActual(step) {
    switch (step) {
        case 1:
            if (!citaData.especialidadId || !citaData.doctorId) {
                mostrarError('Por favor seleccione especialidad y doctor');
                return false;
            }
            return true;
        case 2:
            if (!citaData.fecha || !citaData.hora) {
                mostrarError('Por favor seleccione fecha y horario');
                return false;
            }
            return true;
        default:
            return true;
    }
}

function actualizarIndicadorPasos(currentStep, newStep) {
    document.querySelectorAll('.step-dot').forEach(dot => {
        const step = parseInt(dot.getAttribute('data-step'));
        dot.classList.remove('active', 'completed');
        if (step === newStep) {
            dot.classList.add('active');
        } else if (step < newStep) {
            dot.classList.add('completed');
        }
    });
}

function mostrarResumenCita() {
    const resumenDiv = document.getElementById('resumenCita');
    const especialidadSelect = document.getElementById('especialidad');
    const doctorSelect = document.getElementById('doctor');

    const especialidadNombre = especialidadSelect.options[especialidadSelect.selectedIndex].text;
    const doctorNombre = doctorSelect.options[doctorSelect.selectedIndex].text;

    resumenDiv.innerHTML = `
        <div class="resumen-item">
            <div class="resumen-label">Especialidad:</div>
            <div class="resumen-value">${especialidadNombre}</div>
        </div>
        <div class="resumen-item">
            <div class="resumen-label">Doctor:</div>
            <div class="resumen-value">${doctorNombre}</div>
        </div>
        <div class="resumen-item">
            <div class="resumen-label">Fecha:</div>
            <div class="resumen-value">${formatearFecha(citaData.fecha)}</div>
        </div>
        <div class="resumen-item">
            <div class="resumen-label">Hora:</div>
            <div class="resumen-value">${citaData.hora}</div>
        </div>
    `;
}

function formatearFecha(fecha) {
    if (!fecha) return '';
    const [year, month, day] = fecha.split('-');
    return `${day}/${month}/${year}`;
}

let citaConfirmada = null;

async function confirmarCita() {
    try {
        const userInfo = sessionService.getUserInfo();
        if (!userInfo) {
            throw new Error('No se encontró información del usuario');
        }

        // Obtener información del paciente
        const pacienteResponse = await fetch(`${API_BASE_URL}/Paciente/por-usuario/${userInfo.idUsuario}`);
        if (!pacienteResponse.ok) {
            throw new Error('Error al obtener información del paciente');
        }

        const pacienteData = await pacienteResponse.json();
        if (!pacienteData.success || !pacienteData.data) {
            throw new Error('No se encontró la información del paciente');
        }

        // Preparar datos de la cita
        const horaFormateada = citaData.hora.includes(':') ?
            citaData.hora + ':00' :
            `${citaData.hora}:00:00`;

        const fechaFormateada = new Date(citaData.fecha);
        fechaFormateada.setHours(parseInt(citaData.hora.split(':')[0]));
        fechaFormateada.setMinutes(parseInt(citaData.hora.split(':')[1]));

        const citaRequest = {
            cita: {
                IdCita: 0,
                FechaCita: fechaFormateada.toISOString(),
                HoraCita: horaFormateada,
                PacienteId: pacienteData.data.IdPaciente,
                DoctorId: parseInt(citaData.doctorId),
                Estado: "Pendiente"
            }
        };

        const response = await fetch(`${API_BASE_URL}/Cita`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            body: JSON.stringify(citaRequest)
        });

        if (!response.ok) {
            const errorData = await response.json();
            throw new Error(errorData.title || 'Error al agendar la cita');
        }

        const resultado = await response.json();

        if (resultado.success) {
            citaConfirmada = {
                nombrePaciente: pacienteData.data.Nombre,
                especialidad: document.querySelector('#especialidad option:checked').text,
                fechaCita: fechaFormateada,
                horaCita: horaFormateada,
                nombreDoctor: document.querySelector('#doctor option:checked').text
            };

            mostrarModalConfirmacion();
        } else {
            throw new Error(resultado.message || 'Error al agendar la cita');
        }
    } catch (error) {
        console.error('Error detallado al confirmar cita:', error);
        mostrarError('Error al agendar la cita: ' + (error.message || 'Error desconocido'));
    }
}

function mostrarModalConfirmacion() {
    document.getElementById('confirmacionModal').style.display = 'block';
}

function cerrarModal() {
    document.getElementById('confirmacionModal').style.display = 'none';
    window.location.href = '/paciente.html';
}

async function enviarConfirmacion() {
    const telefono = document.getElementById('telefono').value;
    if (!telefono || telefono.length !== 10) {
        mostrarError('Por favor ingrese un número de teléfono válido de 10 dígitos');
        return;
    }

    try {
        const response = await fetch(`${API_BASE_URL}/WhatsApp/enviar-confirmacion`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                numeroTelefono: telefono,
                nombrePaciente: citaConfirmada.nombrePaciente,
                especialidad: citaConfirmada.especialidad,
                fechaCita: citaConfirmada.fechaCita,
                horaCita: citaConfirmada.horaCita,
                nombreDoctor: citaConfirmada.nombreDoctor
            })
        });

        const resultado = await response.json();

        if (resultado.success) {
            mostrarExito('Confirmación enviada por WhatsApp');
        } else {
            mostrarError('Error al enviar la confirmación: ' + resultado.message);
        }
    } catch (error) {
        mostrarError('Error al enviar la confirmación por WhatsApp');
        console.error(error);
    } finally {
        setTimeout(() => {
            window.location.href = '/paciente.html';
        }, 2000);
    }
}

function mostrarError(mensaje) {
    const errorMessage = document.getElementById('errorMessage');
    if (errorMessage) {
        errorMessage.textContent = mensaje;
        errorMessage.style.display = 'block';
        setTimeout(() => {
            errorMessage.style.display = 'none';
        }, 5000);
    }
}

function mostrarExito(mensaje) {
    const successMessage = document.getElementById('successMessage');
    if (successMessage) {
        successMessage.textContent = mensaje;
        successMessage.style.display = 'block';
        setTimeout(() => {
            successMessage.style.display = 'none';
        }, 5000);
    }
}