//Diccionarios para almacenar los datos de los contactos 
Dictionary<int, string> nombres = new Dictionary<int, string>();
Dictionary<int, string> correos = new Dictionary<int, string>();
Dictionary<int, string> numeros = new Dictionary<int, string>();
Dictionary<int, string> direcciones = new Dictionary<int, string>();
List<int> ids = new List<int>();

Console.WriteLine("Mi agenda perróna.");
bool activo = true;

while (activo)
{
    //Menu del usuario
    Console.WriteLine("Bienvenido a la agenda, que desa hacer?");
    Console.WriteLine("1.Agregar Contacto ");
    Console.WriteLine("2.Mostrar contactos ");
    Console.WriteLine("3.Editar Contacto ");
    Console.WriteLine("4.Eliminar Contacto ");
    Console.WriteLine("5.Salir ");
    Console.Write("Digite la opcion elegida: > ");
    int select = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");



    switch (select)
    {
        case 1:
            addContacs(ref nombres, ref numeros, ref correos, ref direcciones, ref ids);
            break;
        case 2:
            viewContacs(ref nombres, ref numeros, ref correos, ref ids);
            break;
        case 3:
            editContacs(ref nombres, ref numeros, ref correos, ref direcciones);
            break;
        case 4:
            deleteContacs(ref nombres, ref numeros, ref correos, ref direcciones, ref ids);
            viewContacs(ref nombres, ref numeros, ref correos, ref ids);
            break;
        case 5:
            activo = false;
            break;
        default:
            Console.WriteLine("No es una opcion");
            break;
    }
}
static void addContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> correos, ref Dictionary<int, string> direcciones, ref List<int> ids)
{
    int id = ids.Count();
    Console.WriteLine("\nAgregar contacto");
    Console.WriteLine("----------------");
    Console.Write("Nombre: ");
    var nombre = Console.ReadLine();
    Console.Write("Numero de telefono: ");
    var numero = Console.ReadLine();
    Console.Write("Direccion de Correo Electronico: ");
    var correo = Console.ReadLine();
    Console.Write("Direccion de residencia: ");
    var direccion = Console.ReadLine();
    Console.WriteLine(" ");

    //guardando los datos de Conacto
    ids.Add(id);
    nombres.Add(id, nombre);
    numeros.Add(id, numero);
    correos.Add(id, correo);
    direcciones.Add(id, direccion);

}

static void viewContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> correos, ref List<int> ids)
{
    if (ids.Count() > 0)
    {
        Console.WriteLine("Estos son los contactos agregados");
        Console.WriteLine("---------------------------------");

        for (int i = 0; i < ids.Count(); i++)
        {
            int idContacto = ids[i];
            Console.WriteLine($"Id: {ids[idContacto]}\nNombre: {nombres[idContacto]}\nNumero: {numeros[idContacto]}\nCorreo: {correos[idContacto]}");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("No hay contactos agregados... ");
    }
}

static void editContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> direcciones, ref Dictionary<int, string> correos)
{
    Console.WriteLine("\nEditar contacto");
    Console.WriteLine("----------------");
    Console.Write("Ingrese el ID del contacto a editar: > ");
    int contactoEdiar = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine($"Haz selecionaddo el contacto {nombres[contactoEdiar]} \n");

    while (true)
    {
        Console.WriteLine("Desea seguir? (1. Si 0. No)");
        Console.Write("> ");
        int opcionSeguir = Convert.ToInt32(Console.ReadLine());

        if (opcionSeguir == 1)
        {
            Console.WriteLine("Que desea editar?");
            Console.WriteLine("1. Nombre 2. Numero 3. Correo 4. Direccion");
            Console.Write("> ");
            int opcionEditar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (opcionEditar)
            {
                case 1:
                    Console.WriteLine($"El nombre actual es {nombres[contactoEdiar]}");
                    Console.Write("Ingrese el nuevo nombre: ");
                    nombres[contactoEdiar] = Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 2:
                    Console.WriteLine($"El numero actual es {numeros[contactoEdiar]}");
                    Console.Write("Ingrese el nuevo numero: ");
                    numeros[contactoEdiar] = Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 3:
                    Console.WriteLine($"El correo actual es {correos[contactoEdiar]}");
                    Console.Write("Ingrese el nuevo correo: ");
                    correos[contactoEdiar] = Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 4:
                    Console.WriteLine($"La direccion actual es {direcciones[contactoEdiar]}");
                    Console.Write("Ingrese la nueva direccion: ");
                    direcciones[contactoEdiar] = Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                default:
                    Console.WriteLine("No es una opcion...!");
                    break;
            }
        }
        else { break; }
    }
}

static void deleteContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> direcciones, ref Dictionary<int, string> correos, ref List<int> ids)
{
    Console.WriteLine("\nEliminar Contacto");
    Console.WriteLine("-----------------");

    Console.WriteLine("Que contacto desea eliminar?");
    Console.WriteLine("Ingrese el ID del contacto a eliminar");
    Console.Write("> ");
    int contactoEliminar = Convert.ToInt32(Console.ReadLine());

    if (ids.Contains(contactoEliminar))
    {
        Console.WriteLine($"\nHaz selecionaddo el contacto {nombres[contactoEliminar]} \n");

        ids.RemoveAt(contactoEliminar);
        nombres.Remove(contactoEliminar);
        numeros.Remove(contactoEliminar);
        correos.Remove(contactoEliminar);
        direcciones.Remove(contactoEliminar);

        Console.WriteLine("El contacto se ha eliminado correctamente \n");
    }
    else
    {
        Console.WriteLine("El contacto no existe\n");
    }

}
