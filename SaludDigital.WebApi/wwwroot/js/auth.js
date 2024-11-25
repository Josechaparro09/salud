// auth.js
const API_BASE_URL = 'https://localhost:7218/api';

// Función para alternar entre formularios
function toggleForm(formType) {
    const loginForm = document.getElementById('sisas');
    const registerForm = document.getElementById('registerForm');
    const formDescription = document.getElementById('formDescription');

    if (formType === 'register') {
        loginForm.classList.remove('active');
        registerForm.classList.add('active');
        formDescription.textContent = 'Crea tu cuenta';
    } else {
        registerForm.classList.remove('active');
        loginForm.classList.add('active');
        formDescription.textContent = 'Ingrese sus credenciales';
    }

    // Limpiar mensajes
    hideMessages();
}

// Función para iniciar sesión
async function iniciarSesion() {
    hideMessages();
    const username = document.getElementById('loginUsername').value;
    const password = document.getElementById('loginPassword').value;

    if (!username || !password) {
        mostrarError('Por favor complete todos los campos');
        return;
    }

    try {
        const response = await fetch(`${API_BASE_URL}/Auth/login`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ nombreUsuario: username, contraseña: password })
        });

        const data = await response.json();

        if (data.success) {
            sessionService.guardarSesion(data.data);
            mostrarExito('Inicio de sesión exitoso');
            setTimeout(() => {
                window.location.href = determinarRedireccion(data.data.rol);
            }, 1000);
        } else {
            mostrarError(data.message || 'Error al iniciar sesión');
        }
    } catch (error) {
        mostrarError('Error al conectar con el servidor');
        console.error('Error:', error);
    }
}

// Función para registrar usuario
async function registrarUsuario() {
    hideMessages();
    const nombres = document.getElementById('regNombres').value.trim();
    const apellidos = document.getElementById('regApellidos').value.trim();
    const username = document.getElementById('regUsername').value.trim();
    const password = document.getElementById('regPassword').value.trim();
    const sexo = document.getElementById('regSexo').value.trim();

    console.log(nombres,apellidos,sexo,username,password,sexo);

    if (!nombres || !apellidos || !username || !password || !sexo) {
        mostrarError('Por favor complete todos los campos');
        return;
    }
    if (password.length < 6) {
        mostrarError('La contraseña debe tener al menos 6 caracteres');
        return;
    }

    try {
        const response = await fetch(`${API_BASE_URL}/Usuario/registro-paciente`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                Nombres: nombres,
                Apellidos: apellidos,
                NombreUsuario: username,
                Contraseña: password,
                Sexo: sexo
            })
        });
        const data = await response.json();
        if (data.success) {
            mostrarExito('Registro exitoso. Ahora puedes iniciar sesión');
            setTimeout(() => {
                toggleForm('login');
                limpiarFormularioRegistro();
            }, 2000);
        } else {
            mostrarError(data.message || 'Error en el registro');
        }
    } catch (error) {
        mostrarError('Error al conectar con el servidor');
        console.error('Error:', error);
    }
}
function limpiarFormularioRegistro() {
    document.getElementById('regNombres').value = '';
    document.getElementById('regApellidos').value = '';
    document.getElementById('regUsername').value = '';
    document.getElementById('regPassword').value = '';
    document.getElementById('regSexo').value = '';
}

function determinarRedireccion(rol) {
    switch (rol) {
        case 'Administrador':
            return '/admin.html';
        case 'Doctor':
            return '/doctor.html';
        case 'Paciente':
            return '/paciente.html';
        default:
            return '/index.html';
    }
}

function mostrarError(mensaje) {
    const errorMessage = document.getElementById('errorMessage');
    errorMessage.textContent = mensaje;
    errorMessage.style.display = 'block';
}

function mostrarExito(mensaje) {
    const successMessage = document.getElementById('successMessage');
    successMessage.textContent = mensaje;
    successMessage.style.display = 'block';
}

function hideMessages() {
    document.getElementById('errorMessage').style.display = 'none';
    document.getElementById('successMessage').style.display = 'none';
}