class SessionService {
    static saveUserSession(userData) {
        // Asegurarse de que el ID del paciente esté disponible
        let userInfo = {
            ...userData,
            idPaciente: userData.idPaciente || null // Asegúrate de que este campo existe en la respuesta del login
        };
        localStorage.setItem('userInfo', JSON.stringify(userInfo));
        localStorage.setItem('isAuthenticated', 'true');
    }

    static clearSession() {
        localStorage.clear();
    }

    static getUserInfo() {
        const userInfo = localStorage.getItem('userInfo');
        return userInfo ? JSON.parse(userInfo) : null;
    }

    static isAuthenticated() {
        return localStorage.getItem('isAuthenticated') === 'true' && this.getUserInfo() !== null;
    }

    static getPacienteId() {
        const userInfo = this.getUserInfo();
        return userInfo ? userInfo.idPaciente : null;
    }
}

window.sessionService = SessionService;