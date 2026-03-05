Dictionary<int, string> ciudades = new Dictionary<int, string>();

int codigo;

for(int x = 0; x < 5; x++)
{
    Console.WriteLine("Ingrese el código de la ciudad: ");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre de la ciudad: ");
    string ciudad = Console.ReadLine();

    ciudades.Add(codigo, ciudad);
}

Console.WriteLine("Ingrese el còdigo: ");
codigo = int.Parse(Console.ReadLine());

if (ciudades.ContainsKey(codigo) == true)
{
    Console.WriteLine(ciudades[codigo]);
}

else
{
    Console.WriteLine("Ingreso un codigo invalido. ");
}