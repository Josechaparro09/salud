using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class HorarioBLL
    {
        private HorarioDAL horarioDAL = new HorarioDAL();

        public string RegistrarHorario(Horario horario)
        {
            try
            {
                var horariosExistentes = horarioDAL.ObtenerHorariosPorDoctor(horario.IdDoctor);
                foreach (var h in horariosExistentes)
                {
                    if (h.DiaSemana == horario.DiaSemana &&
                        ((horario.HoraInicio >= h.HoraInicio && horario.HoraInicio < h.HoraFin) ||
                         (horario.HoraFin > h.HoraInicio && horario.HoraFin <= h.HoraFin)))
                    {
                        return "El horario se solapa con otro existente.";
                    }
                }

                horarioDAL.GuardarHorario(horario);
                return "Horario registrado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el horario: " + ex.Message);
            }
        }

        public string ActualizarHorario(Horario horario)
        {
            try
            {
                var horariosExistentes = horarioDAL.ObtenerHorariosPorDoctor(horario.IdDoctor);
                foreach (var h in horariosExistentes)
                {
                    if (h.IdHorario != horario.IdHorario &&
                        h.DiaSemana == horario.DiaSemana &&
                        ((horario.HoraInicio >= h.HoraInicio && horario.HoraInicio < h.HoraFin) ||
                         (horario.HoraFin > h.HoraInicio && horario.HoraFin <= h.HoraFin)))
                    {
                        return "El horario se solapa con otro existente.";
                    }
                }

                horarioDAL.ActualizarHorario(horario);
                return "Horario actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el horario: " + ex.Message);
            }
        }

        public string EliminarHorario(int idHorario)
        {
            try
            {
                horarioDAL.EliminarHorario(idHorario);
                return "Horario eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el horario: " + ex.Message);
            }
        }

        public List<Horario> ObtenerHorarios()
        {
            try
            {
                return horarioDAL.ObtenerHorarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los horarios: " + ex.Message);
            }
        }

        public Horario ObtenerHorarioPorId(int idHorario)
        {
            try
            {
                var horario = horarioDAL.ObtenerHorarioPorId(idHorario);
                if (horario == null)
                {
                    throw new Exception("No se encontró el horario especificado.");
                }
                return horario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el horario: " + ex.Message);
            }
        }

        public List<Horario> ObtenerHorariosPorDoctor(int idDoctor)
        {
            try
            {
                return horarioDAL.ObtenerHorariosPorDoctor(idDoctor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los horarios del doctor: " + ex.Message);
            }
        }
    }
}