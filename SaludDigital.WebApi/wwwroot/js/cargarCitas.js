
async function cargarCitas() {
    try {
        const pacienteResponse = await fetch(`${API_BASE_URL}/Paciente/por-usuario/${userInfo.idUsuario}`);
        if (!pacienteResponse.ok) {
            throw new Error('Error al obtener información del paciente');
        }

        const pacienteData = await pacienteResponse.json();
        if (!pacienteData.success || !pacienteData.data) {
            throw new Error('No se encontró la información del paciente');
        }

        const response = await fetch(`${API_BASE_URL}/Cita/${pacienteData.IdPaciente}/mis-citas`);
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
