// apiService.js
const API_BASE_URL = 'https://localhost:7218/api';

class ApiService {
    constructor() {
        this.baseUrl = API_BASE_URL;
    }

    async login(credentials) {
        try {
            const response = await fetch(`${this.baseUrl}/login`, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json'
                },
                body: JSON.stringify(credentials)
            });

            if (!response.ok) {
                const errorData = await response.json();
                throw new Error(errorData.message || 'Error en el inicio de sesión');
            }

            const data = await response.json();

            // Guardar el token si tu API lo devuelve
            if (data.token) {
                sessionStorage.setItem('authToken', data.token);
            }

            return data;
        } catch (error) {
            console.error('Error en login:', error);
            throw error;
        }
    }

    // Método para obtener los headers de autenticación
    getAuthHeaders() {
        const token = sessionStorage.getItem('authToken');
        return {
            'Content-Type': 'application/json',
            'Accept': 'application/json',
            ...(token ? { 'Authorization': `Bearer ${token}` } : {})
        };
    }

    async getCurrentUser() {
        const userInfo = sessionStorage.getItem('userInfo');
        return userInfo ? JSON.parse(userInfo) : null;
    }

    async logout() {
        // Limpiar toda la información de sesión
        sessionStorage.removeItem('userInfo');
        sessionStorage.removeItem('authToken');
        window.location.href = '/index.html';
    }

    // Método para verificar si hay una sesión activa
    isAuthenticated() {
        const userInfo = sessionStorage.getItem('userInfo');
        const token = sessionStorage.getItem('authToken');
        return !!(userInfo && token);
    }
}

// Exportar una instancia única del servicio
window.apiService = new ApiService();