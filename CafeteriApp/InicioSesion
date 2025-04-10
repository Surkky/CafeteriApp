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

        public bool ValidarCredenciales()
        {
            if (Usuario == "admin" && Contrasena == "1234")
            {
                return true;
            }
            return false;
        }
    }
}