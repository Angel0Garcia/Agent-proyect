

//Console.WriteLine("Mi Agenda Perrón");
//Console.WriteLine("Bienvenido a tu lista de contactes");

//Dictionary<int, string> names = new Dictionary<int, string>();
//Dictionary<int, string> phones = new Dictionary<int, string>();
//Dictionary<int, string> emails = new Dictionary<int, string>();
//List<string> addresses = new List<string>();
//List<int> ids = new List<int>();

//bool running = true;
//while (running)
//{

//    Console.Write("1. Agregar Contacto      ");
//    Console.Write("2. Ver Contactos     ");
//    Console.Write("3. Buscar Contactos      ");
//    Console.Write("4. Modificar Contacto        ");
//    Console.Write("5. Eliminar Contacto     ");
//    Console.WriteLine("6. Salir");
//    Console.Write("Elige una opción: ");

//    int choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            AddContact(ref names, ref phones, ref emails, ref addresses, ref ids);
//            break;
//        case 2:
//            ViewContacts(ref names, ref phones, ref emails, ref ids);
//            break;
//        case 4:
//            EditContact();
//            break;
//        case 5:
//            DeleteContact();
//            break;
//        case 3: //esto es intencional, no importa el orden en que pongan los cases, pero, traten de ser siempre lo mas ordenados posible
//            SearchContact();
//            break;
//        case 6:
//            running = false;
//            break;
//        default:
//            Console.WriteLine("Opción no válida");
//            break;
//    }
//}

//static void AddContact(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<string> addresses, ref List<int> ids)
//{
//    Console.WriteLine("Vamos a agregar ese contacte que te trae loco.");

//    int id = ids.Count() + 1;
//    ids.Add(id);
//    Console.Write("Digite el Nombre: ");
//    var name = Console.ReadLine();
//    names.Add(id, name);
//    Console.Write("Digite el Teléfono: ");
//    var telefono = Console.ReadLine();
//    phones.Add(id, telefono);

//    Console.Write("Digite el Email: ");
//    var email = Console.ReadLine();
//    emails.Add(id, email);
//    Console.Write("Digite la dirección: ");
//    var address = Console.ReadLine();
//    addresses.Add(address);
//    Console.WriteLine();

//}

//static void ViewContacts(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<int> ids)
//{
//    Console.WriteLine("Id           Nombre          Telefono            Email");
//    Console.WriteLine("___________________________________________");

//    foreach (var id in ids)
//    {
//        Console.WriteLine($"{id}        {names[id]}      {phones[id]}      {emails[id]}");
//    }
//}

//static void EditContact()
//{
//    // Implementar lógica para editar un contacto.
//}

//static void DeleteContact()
//{
//    // Implementar lógica para eliminar un contacto.
//}

//static void SearchContact()
//{
//    // Implementar lógica para eliminar un contacto.
//}