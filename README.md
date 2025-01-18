# 🏥 Salud Digital

Sistema integral para la gestión de servicios médicos que incluye una aplicación de escritorio para personal administrativo y médico, junto con una plataforma web para pacientes.

![Estado del Proyecto](https://img.shields.io/badge/Estado-En%20Desarrollo-green)

## 📋 Características Principales

### Aplicación de Escritorio
- **Módulo Administrativo**
  - Gestión completa de usuarios (doctores y pacientes)
  - Creación y administración de cuentas de acceso
  - Panel de control administrativo
  
- **Módulo Médico**
  - Gestión de horarios y disponibilidad
  - Sistema de atención a pacientes
  - Creación y gestión de historias clínicas
  - Generación de recetas médicas

### Plataforma Web para Pacientes
- Visualización de horarios disponibles
- Agendamiento de citas médicas
- Consulta de historial médico
- Interfaz intuitiva y responsive

### Integraciones
- Integración con API de WhatsApp (Meta) para notificaciones automáticas
- Sistema de recordatorios de citas
- Base de datos SQL Server para almacenamiento seguro

## 🚀 Tecnologías Utilizadas

- **Backend**: C# .NET
- **Frontend Desktop**: Windows Forms / WPF
- **Frontend Web**: React
- **Base de Datos**: SQL Server
- **API**: WhatsApp Business API

## 💻 Requisitos Previos

- Visual Studio 2019 o superior
- SQL Server 2019 o superior
- .NET Framework [versión]
- Cuenta de desarrollador de Meta para WhatsApp Business API

## ⚙️ Configuración del Proyecto

1. **Clonar el Repositorio**
   ```bash
   git clone [URL del repositorio]
   cd [nombre-del-proyecto]
   ```

2. **Configuración de la Base de Datos**
   ```sql
   -- Ejecutar el script de inicialización
   [Incluir pasos específicos para la configuración de la BD]
   ```

3. **Configuración del Archivo App.config**
   ```xml
   <!-- Actualizar las cadenas de conexión -->
   <connectionStrings>
     <add name="DefaultConnection" 
          connectionString="Server=YOUR_SERVER;Database=YOUR_DB;..." />
   </connectionStrings>
   ```

4. **Configuración de WhatsApp API**
   - Agregar las credenciales de WhatsApp Business API en el archivo de configuración
   - Configurar los webhooks necesarios

## 📱 Roles y Funcionalidades

### 👨‍💼 Administrador
- Gestión de usuarios
- Creación de cuentas
- Asignación de roles
- Monitoreo del sistema

### 👨‍⚕️ Doctor
- Gestión de horarios
- Atención de pacientes
- Creación de historias clínicas
- Generación de recetas

### 🏃 Paciente
- Agendamiento de citas
- Visualización de horarios
- Recepción de notificaciones
- Acceso a historial médico

## 👨‍💻 Creadores

| [<img src="https://github.com/Jassia627.png" width="100px;"/><br/><sub><b>Juan Assia</b></sub>](https://github.com/Jassia627) | [<img src="https://github.com/Josechaparro09.png" width="100px;"/><br/><sub><b>Jose Chaparro</b></sub>](https://github.com/Josechaparro09) |
|:---:|:---:|

## 📞 Contacto

- Juan Assia - [LinkedIn](https://www.linkedin.com/in/juan-assia-813a9926b/)
- Jose Chaparro - [LinkedIn](https://www.linkedin.com/in/jachaparroo/)

## 🙏 Agradecimientos
- Equipo de desarrollo
- Colaboradores
- [Otros agradecimientos específicos]

---
⌨️ con ❤️ por NETXEL
