using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializar los datos del usuario
        string usuario = "miusuario";
        string contraseña = "micontraseña";

        // Pedir al usuario que se registre
        Console.WriteLine("Por favor, regístrese.");
        Console.Write("Ingrese un nombre de usuario: ");
        string nuevoUsuario = Console.ReadLine();
        Console.Write("Ingrese una contraseña: ");
        string nuevaContraseña = Console.ReadLine();

   
        if (nuevoUsuario == usuario && nuevaContraseña == contraseña)
        {
            Console.WriteLine("Registro exitoso.");
        }
        else
        {
            Console.WriteLine("Lo siento, el registro falló. Inténtelo de nuevo.");
            return;
        }

        Console.WriteLine("Por favor, inicie sesión.");
        Console.Write("Nombre de usuario: ");
        string usuarioInicio = Console.ReadLine();
        Console.Write("Contraseña: ");
        string contraseñaInicio = Console.ReadLine();

       
        if (usuarioInicio == usuario && contraseñaInicio == contraseña)
        {
            Console.WriteLine("Inicio de sesión exitoso. Bienvenido, " + usuario + "!");
        }
        else
        {
            Console.WriteLine("Lo siento, inicio de sesión fallido. Inténtelo de nuevo.");
        }
    }
}
