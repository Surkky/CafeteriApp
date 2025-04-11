using System;

namespace CafeteriApp
{
    public class GestorApp
    {
        InicioSesion inicioSesion;
        public GestorApp()
        {
            IniciarApp();
        }

        public void IniciarApp()
        {
            inicioSesion = new InicioSesion();
            inicioSesion.IniciarSesion();
            if (inicioSesion.ValidarCredenciales())
            {
                Console.WriteLine("Bienvenido a la aplicación de cafetería.");
                // Aquí puedes agregar más lógica para la aplicación después de iniciar sesión.
            }
            else
            {
                Console.WriteLine("No se pudo iniciar sesión. Saliendo de la aplicación.");
            }
        }
    }
}