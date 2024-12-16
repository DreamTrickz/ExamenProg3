using System;
using System.Collections.Generic;
using System.Linq;
using TallerFinal.DAL.CONF;
using TallerFinal.DTO.CONF;

namespace TallerFinal.BL.INV
{
    public class ParticipacionBL
    {
        private readonly ParticipacionDAL _participacionDAL;

        public ParticipacionBL()
        {
            _participacionDAL = new ParticipacionDAL();
        }

        // Obtener todas las participaciones
        public List<Participacion> ObtenerParticipaciones()
        {
            return _participacionDAL.ObtenerParticipaciones();
        }

        // Obtener participaciones con un filtro
        public List<Participacion> ObtenerParticipacionesConFiltro(string filtro)
        {
            return _participacionDAL.ObtenerParticipacionesConFiltro(filtro);
        }

        // Guardar una nueva participación
        public void GuardarParticipacion(int idParticipante, int idConferencia, string sesion, string usuarioCrea)
        {
            var participacion = new Participacion
            {
                IdParticipante = idParticipante,
                IdConferencia = idConferencia,
                Sesion = sesion,
                UsuarioCrea = usuarioCrea,
                FechaCreacion = DateTime.Now
            };
            _participacionDAL.InsertarParticipacion(participacion);
        }

        // Obtener una participación por ID
        public Participacion ObtenerParticipacionPorId(int id)
        {
            return _participacionDAL.ObtenerParticipacionPorId(id);
        }

        // Actualizar una participación existente
        public void ActualizarParticipacion(Participacion participacion)
        {
            _participacionDAL.ActualizarParticipacion(participacion);
        }

        // Eliminar una participación
        public void EliminarParticipacion(int id)
        {
            _participacionDAL.EliminarParticipacion(id);
        }
    }
}
