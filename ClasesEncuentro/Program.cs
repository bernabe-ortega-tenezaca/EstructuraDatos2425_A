
Cabecera();

while (true)
{
    Menu();
    string opcion = Console.ReadLine(); //Readline lee una tecla

    switch (opcion)  //select case
    {
        case "0":
            titulo("Salir");
            return;
        case "1":
            //Console.WriteLine("En desarrollo - ha pulsado el 1");
            titulo("Tipos de datos básicos - Desarrollo");
            break;
        case "2":
            //Console.WriteLine("Estamos trabajando - ha pulsado el 2");
            titulo("POO");
            break;
        case "3":
            titulo("Arrays y Matrices");
            ArraysMatrices.Run();
            break;
        default:
            Console.WriteLine("Opción no válida, pulse una tecla para continuar");
            break;
    }
    PiePagina();
}

static void PiePagina(){
    Console.WriteLine("------------------------------");
    Console.WriteLine("Programado por @Estudiante");
    Console.WriteLine();
}

static void Cabecera(){
    //Console.Clear(); //limpia la pantalla pero da un error
    Console.WriteLine("\f\u001b\x1b[3J");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("+     UNIVERSIDAD ESTATAL AMAZONICA     +");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine();
    Console.WriteLine(" Menú de Opciones - Seleccione un número");
    Console.WriteLine();
}

static void Menu(){
    Console.WriteLine("1 Tipos básicos");
    Console.WriteLine("2 POO");
    Console.WriteLine("3 Array y Matrices");
    Console.WriteLine("------------------");
    Console.WriteLine("0 Salir");
    // Seguir incrementando cada semana
}

static void titulo(string titulo){
    Console.WriteLine("===================");
    Console.WriteLine(titulo);
    Console.WriteLine("===================");
}