using System;
using System.Collections.Generic;
using System.IO;

namespace CafeteriApp
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Permisos { get; set; }

        public Usuario(string permisos, string username, string contrasena)
        {
            Permisos = permisos;
            Nombre = username;
            Contrasena = contrasena;
        }

        public static List<Usuario> CargarUsuarios(string rutaFichero)
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                foreach (string linea in File.ReadAllLines(rutaFichero))
                {
                    var datos = linea.Trim().Split(':');
                    if (datos.Length == 3)
                    {
                        string permisos = datos[0];
                        string username = datos[1];
                        string contrasena = datos[2];
                        usuarios.Add(new Usuario(permisos, username, contrasena));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"El fichero {rutaFichero} no existe.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al leer el fichero: {e.Message}");
            }
            return usuarios;
        }
    }
}