namespace CafeteriApp
{
    public class InicioSesion
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public InicioSesion(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }

        public bool ValidarCredenciales(List<Usuario> usuarios)
        {
        /*   
            Console.WriteLine("Usuario: ");
            nombre= Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            contrasena= Console.ReadLine();
            // Aquí puedes implementar la lógica para validar las credenciales con los usuarios cargados.
            // Por ejemplo, podrías buscar el usuario en la lista de usuarios y comparar la contraseña.
            
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return true;
                }
            }
            
            // Si no se encuentra el usuario o la contraseña no coincide, retorna false.
            return false;
        }
        */

            if (Usuario == "admin" && Contrasena == "1234")
            {
                return true;
            }
            return false;
        }
        
    }
}