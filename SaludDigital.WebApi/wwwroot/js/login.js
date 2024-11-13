document.addEventListener('DOMContentLoaded', function () {
    // Limpiar cualquier sesión anterior
    sessionService.clearSession();

    const loginForm = document.getElementById('loginForm');
    const errorMessage = document.getElementById('errorMessage');
    const successMessage = document.getElementById('successMessage');

    loginForm.addEventListener('submit', async function (e) {
        e.preventDefault();

        // Ocultar mensajes previos
        errorMessage.style.display = 'none';
        successMessage.style.display = 'none';

        try {
            const username = document.getElementById('username').value;
            const password = document.getElementById('password').value;

            console.log('Iniciando login...'); // Debug

            const response = await fetch('https://localhost:7218/api/Login', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json'
                },
                body: JSON.stringify({
                    nombreUsuario: username,
                    contraseña: password
                })
            });

            console.log('Status:', response.status); // Debug

            const data = await response.json();
            console.log('Respuesta:', data); // Debug

            if (!response.ok) {
                throw new Error(data.message || 'Error en la autenticación');
            }

            if (data.success) {
                // Guardar información del usuario
                sessionService.saveUserSession(data.usuario);

                // Mostrar mensaje de éxito
                successMessage.textContent = data.message || '¡Login exitoso!';
                successMessage.style.display = 'block';

                // Redireccionar después de un breve delay
                setTimeout(() => {
                    window.location.href = data.redirectUrl;
                }, 1500);
            } else {
                throw new Error(data.message || 'Error en la autenticación');
            }
        } catch (error) {
            console.error('Error completo:', error);
            errorMessage.textContent = error.message || 'Error al conectar con el servidor';
            errorMessage.style.display = 'block';
        }
    });
});