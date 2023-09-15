/* internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> diccionario = new Dictionary<int, string>();
        Console.WriteLine("Total de elmentos del diccionario: {0}", diccionario.Count);
    }
}

//Propiedades.
//Count: Obtiene el numero de pares clave-valor.

 */


internal class Program
{
    private static void Main(string[] args)
    { Dictionary<string, string> openWith =new Dictionary<string, string>();

    openWith.Add("txt", "notepad.exe");
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");

/*     try
    {
        openWith.Add("txt", "winword.exe");
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Un elemento con la llave = \"txt\" ya existe.");
    } */

    /* Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;

    foreach (string key in keyColl){
        Console.WriteLine(key);
    }
    foreach (KeyValuePair<string, string> pair in openWith){
        Console.WriteLine("LLAVE {0} - VALOR {1}", pair.Key,pair.Value);
    } */

    Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
    foreach (string valor in valueColl){
        Console.WriteLine(valor);
    }
    openWith.Clear();

    Console.WriteLine("Total de datos en el diccionario: " +openWith.Count);

    }
}
