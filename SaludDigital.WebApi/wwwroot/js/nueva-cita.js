async function cargarHorarios() {
    try {
        const doctorId = document.getElementById('doctor').value;
        const fecha = document.getElementById('fecha').value;

        if (!doctorId || !fecha) {
            return;
        }

        const response = await fetch(`https://localhost:7218/api/Cita/horarios-disponibles/${doctorId}?fecha=${fecha}`);

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();

        if (!data.success) {
            throw new Error(data.message || 'Error al cargar horarios');
        }

        const horariosGrid = document.getElementById('horariosGrid');
        horariosGrid.innerHTML = '';

        data.data.forEach(hora => {
            const button = document.createElement('button');
            button.classList.add('horario-btn');
            button.textContent = hora;
            button.addEventListener('click', () => {
                seleccionarHorario(button);
            });
            horariosGrid.appendChild(button);
        });
    } catch (error) {
        console.error('Error en cargarHorarios:', error);
        mostrarError(`Error al cargar horarios: ${error.message}`);
    }
}

function seleccionarHorario(button) {
    const selectedHorario = document.querySelector('.horario-btn.selected');
    if (selectedHorario) {
        selectedHorario.classList.remove('selected');
    }
    button.classList.add('selected');
    citaData.hora = button.textContent;
}

function nextStep(currentStep) {
    if (currentStep === 1) {
        citaData.especialidadId = document.getElementById('especialidad').value;
        citaData.doctorId = document.getElementById('doctor').value;

        if (!citaData.especialidadId || !citaData.doctorId) {
            mostrarError('Por favor, seleccione una especialidad y un doctor');
            return;
        }
    } else if (currentStep === 2) {
        citaData.fecha = document.getElementById('fecha').value;
        citaData.hora = document.querySelector('.horario-btn.selected')?.textContent;

        if (!citaData.fecha || !citaData.hora) {
            mostrarError('Por favor, seleccione una fecha y un horario');
            return;
        }

        mostrarResumenCita();
    }

    const currentStepElement = document.getElementById(`step${currentStep}`);
    const nextStepElement = document.getElementById(`step${currentStep + 1}`);

    currentStepElement.classList.remove('active');
    nextStepElement.classList.add('active');

    const currentStepDot = document.querySelector(`.step-dot[data-step="${currentStep}"]`);
    const nextStepDot = document.querySelector(`.step-dot[data-step="${currentStep + 1}"]`);

    currentStepDot.classList.remove('active');
    currentStepDot.classList.add('completed');
    nextStepDot.classList.add('active');
}

function prevStep(currentStep) {
    const currentStepElement = document.getElementById(`step${currentStep}`);
    const prevStepElement = document.getElementById(`step${currentStep - 1}`);

    currentStepElement.classList.remove('active');
    prevStepElement.classList.add('active');

    const currentStepDot = document.querySelector(`.step-dot[data-step="${currentStep}"]`);
    const prevStepDot = document.querySelector(`.step-dot[data-step="${currentStep - 1}"]`);

    currentStepDot.classList.remove('active');
    prevStepDot.classList.remove('completed');
    prevStepDot.classList.add('active');
}

function mostrarResumenCita() {
    const resumenCita = document.getElementById('resumenCita');
    resumenCita.innerHTML = `
        <div class="resumen-item">
            <div class="resumen-label">Especialidad:</div>
            <div class="resumen-value">${document.getElementById('especialidad').selectedOptions[0].textContent}</div>
        </div>
        <div class="resumen-item">
            <div class="resumen-label">Doctor:</div>
            <div class="resumen-value">${document.getElementById('doctor').selectedOptions[0].textContent}</div>
        </div>
        <div class="resumen-item">
            <div class="resumen-label">Fecha:</div>
            <div class="resumen-value">${citaData.fecha}</div>
        </div>
        <div class="resumen-item">
            <div class="resumen-label">Hora:</div>
            <div class="resumen-value">${citaData.hora}</div>
        </div>
    `;
}

async function confirmarCita() {
    try {
        const response = await fetch('https://localhost:7218/api/Cita', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                pacienteId: sessionService.getUserInfo().idPaciente,
                doctorId: citaData.doctorId,
                fechaCita: citaData.fecha,
                horaCita: citaData.hora,
            }),
        });

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();

        if (!data.success) {
            throw new Error(data.message || 'Error al confirmar cita');
        }

        mostrarExito('Cita agendada exitosamente');
        setTimeout(() => {
            window.location.href = '/paciente.html';
        }, 2000);
    } catch (error) {
        console.error('Error en confirmarCita:', error);
        mostrarError(`Error al confirmar cita: ${error.message}`);
    }
}