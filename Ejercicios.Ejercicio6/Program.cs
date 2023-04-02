 Console.WriteLine("Escribe algo y presiona Ctrl+Shift+F para finalizar el programa.");

 while (true)
 {
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Shift) && keyInfo.Key == ConsoleKey.F)
    {
        Console.WriteLine("\nPrograma finalizado.");
        break;
    }
    else
    {
        Console.Write(keyInfo.KeyChar);
    }
 }

