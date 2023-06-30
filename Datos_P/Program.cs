// See https://aka.ms/new-console-template for more information

string Nombre,Apellido;
int Edad;
float Altura;

Console.WriteLine("Por favor digite su nombre ");
Nombre=Console.ReadLine();
Console.WriteLine("Por favor digite su apellido ");
Apellido=Console.ReadLine();
Console.WriteLine("Por favor digite su edad en años ");
Edad=int.Parse(Console.ReadLine());
Console.WriteLine("Por favor digite su altura en cm ");
Altura=float.Parse(Console.ReadLine());

Console.WriteLine("Mi nombre es: "+Nombre+" "+Apellido+" tengo "+Edad+" Años y mido "+Altura+" cm");

