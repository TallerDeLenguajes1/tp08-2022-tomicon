// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el path de la carpeta:");
string path= Console.ReadLine();
if (Directory.Exists(path))
{
    List<string> archivos = new List<string>();
    archivos = Directory.GetFiles(path).ToList();
    Console.WriteLine("Estos son los archivos que se encuentran dentro del path:");
    foreach (string item in archivos)
    {
        Console.WriteLine(item);
    }
} else
{
    Console.WriteLine("La ruta ingresada no existe");
}
if (File.Exists(@"C:\tp08-2022-tomicon\index.csv"))
{
    File.Create(@"C:\tp08-2022-tomicon\index.csv");    
}