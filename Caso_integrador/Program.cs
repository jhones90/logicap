// See https://aka.ms/new-console-template for more information

string Nombre,Apellido;
int Salario_base,ValorHED=0,ValorHEN=0,ValorHEDF=0,ValorHENF=0,i,Cant_empleados;

Console.WriteLine("Empleados a liquidar en este periodo");
Cant_empleados=int.Parse(Console.ReadLine());

for(i=1;i<=Cant_empleados;i++);
{
    Console.WriteLine("Digite el Nombre del empleado"+i);
    Nombre=Console.ReadLine();
}
Console.WriteLine("Hello, World!");
