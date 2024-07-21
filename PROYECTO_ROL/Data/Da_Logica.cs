using PROYECTO_ROL.Models;

namespace PROYECTO_ROL.Data
{
    public class Da_Logica
    {
        public List<Usuario> ListaUsuario() 
        {
            return new List<Usuario> 
            {
                new Usuario{Nombre="jose", Correo="administrado@gmail.com",Clave="123", Roles=new string[] {"Administrador"}},
                new Usuario{Nombre="jose", Correo="administrado@gmail.com",Clave="123", Roles=new string[] {"Administrador"}},
                new Usuario{Nombre="jose", Correo="administrado@gmail.com",Clave="123", Roles=new string[] {"Administrador"}},
                new Usuario{Nombre="jose", Correo="administrado@gmail.com",Clave="123", Roles=new string[] {"Administrador"}},
            }
        }

    }
}
