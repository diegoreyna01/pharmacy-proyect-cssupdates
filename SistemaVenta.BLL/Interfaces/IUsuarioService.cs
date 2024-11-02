﻿using SistemaVenta.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.BLL.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Lista();
        Task<List<Usuario>> Crear(Usuario entidad, Stream Foto = null, string NombreFoto = "", string UrlPlantillaCorrero = "");

        Task<List<Usuario>> Editar(Usuario entidad, Stream Foto = null, string NombreFoto = "");

        Task<bool> Eliminar(int idUsuario);

        Task<Usuario> ObtenerPorCredenciales(string correo, string clave);


        Task<Usuario> ObtenerPorId(int idUsuario);


        Task<bool> GuardarPerfil(Usuario entidad);

        Task<bool> CambiarClave(int idUsuario, string ClaveActual, string ClaveNueva);

        Task<bool> RestablecerClave(string Correo, string UrlPlantillaCorreo);






    }
}