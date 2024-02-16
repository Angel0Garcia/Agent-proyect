//Diccionarios para almacenar los datos de los contactos 
Dictionary<int, string> nombres = new Dictionary<int, string>();
Dictionary<int, string> correos = new Dictionary<int, string>();
Dictionary<int, string> numeros = new Dictionary<int, string>();
Dictionary<int, string> direcciones = new Dictionary<int, string>();
List<int> ids = new List<int>();

//Menu del usuario
Console.WriteLine("Mi agenda perróna.");
bool activo = true;

while (activo)
{
    Console.WriteLine("Bienvenido a la agenda, que desa hacer?");
    Console.WriteLine("1.Agregar Contacto 2.Mostrar contactos 3.Editar Contacto 4.Eliminar Contacto 5.Salir ");
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
            editContacs(ref nombres, ref numeros, ref correos, ref direcciones, ref ids);
            break;
        case 4:
            deleteContacs(ref nombres, ref numeros, ref correos, ref direcciones, ref ids);
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
    int id = ids.Count() + 1;
    ids.Add(id);
    Console.WriteLine("Agregar contacto");
    Console.Write("Nombre: ");
    var nombre = Console.ReadLine();
    nombres.Add(id, nombre);
    Console.Write("Numero de telefono: ");
    var numero = Console.ReadLine();
    numeros.Add(id, numero);
    Console.Write("Direccion de Correo Electronico: ");
    var correo = Console.ReadLine();
    correos.Add(id, correo);
    Console.Write("Direccion de residencia: ");
    var direccion = Console.ReadLine();
    direcciones.Add(id, direccion);
    Console.WriteLine(" ");
}

static void viewContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> correos, ref List<int> ids)
{
    Console.WriteLine("Estos son los contactos agregados");
    Console.WriteLine("---------------------------------");

    foreach (var id in ids)
    {
        Console.WriteLine("  Id:             Nombre:            Numero:            Correo:     ");
        Console.WriteLine($"{ids}       {nombres[id]}      {numeros[id]}      {correos[id]}");
        Console.WriteLine();
    }
}

static void editContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> direcciones, ref Dictionary<int, string> correos, ref List<int> ids)
{
    
}

static void deleteContacs(ref Dictionary<int, string> nombres, ref Dictionary<int, string> numeros, ref Dictionary<int, string> direcciones, ref Dictionary<int, string> correos, ref List<int> ids)
{
    
}