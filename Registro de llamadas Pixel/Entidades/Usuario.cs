namespace Entidades
{
    public class Usuario
    {
        private static List<Usuario> listaUsuarios;
        private string id;
        private string contraseña;

        public Usuario(string id, string contraseña)
        {
            this.id = id;
            this.contraseña = contraseña;
        }

        static Usuario()
        {   
            listaUsuarios = new List<Usuario>();
            Usuario usuarioGerman = new Usuario("gmolinar", "Canarias.2023");
            listaUsuarios.Add(usuarioGerman);
        }

        public string Id { get => id; set => id = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public static bool ValidarLogin(string id, string contraseña)
        {
            foreach (var Usuario in listaUsuarios)
            {
                if (contraseña == Usuario.Contraseña && id == Usuario.Id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}