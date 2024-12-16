using TallerFinal.DAL.CONF;
using TallerFinal.DTO.CONF;
using System;
using System.Collections.Generic;

namespace TallerFinal.BL.CONF
{
    public class ConferenciasBL
    {
        private readonly ConferenciasDAL _conferenciasDAL;

        public ConferenciasBL()
        {
            _conferenciasDAL = new ConferenciasDAL();
        }

        // Obtener todas las conferencias
        public List<Conferencia> ObtenerConferencias()
        {
            return _conferenciasDAL.ObtenerConferencias();
        }

        // Obtener conferencias con un filtro
        public List<Conferencia> ObtenerConferenciasConFiltro(string filtro)
        {
            return _conferenciasDAL.ObtenerConferenciasConFiltro(filtro);
        }

        // Guardar una nueva conferencia
        public void GuardarConferencia(string titulo, DateTime fecha, string lugar, DateTime fechaCreacion, string usuarioCrea)
        {
            var conferencia = new Conferencia
            {
                Titulo = titulo,
                Fecha = fecha,
                Lugar = lugar,
                FechaCreacion = fechaCreacion,
                UsuarioCrea = usuarioCrea,
                Estado = true // Se puede ajustar según las reglas de negocio
            };

            _conferenciasDAL.InsertarConferencia(conferencia);
        }

        // Obtener una conferencia por ID
        public Conferencia ObtenerConferenciaPorId(int id)
        {
            return _conferenciasDAL.ObtenerConferenciaPorId(id);
        }

        // Actualizar una conferencia existente
        public void ActualizarConferencia(int id, string titulo, DateTime fecha, string lugar, string usuarioModifica)
        {
            var conferencia = _conferenciasDAL.ObtenerConferenciaPorId(id);

            if (conferencia != null)
            {
                conferencia.Titulo = titulo;
                conferencia.Fecha = fecha;
                conferencia.Lugar = lugar;
                conferencia.UsuarioModifica = usuarioModifica;
                conferencia.FechaModificacion = DateTime.Now;

                _conferenciasDAL.ActualizarConferencia(conferencia);
            }
        }

        // Eliminar una conferencia por ID
        public void EliminarConferencia(int id)
        {
            _conferenciasDAL.EliminarConferencia(id);
        }
    }
}
