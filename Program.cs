
/*Variables Escribe un programa que reciba datos de una persona y genera un
mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, 
    edad, sabe programar, etc. */

Console.WriteLine("Introduce tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Introduce tu apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Introduce tu edad: ");
string edad = Console.ReadLine();


Console.WriteLine("Hola " + nombre + " " + apellido + " " + edad + " " + "sabe programar");

/*Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color */

public class auto {
    string mar = "4c";
    int puertas;
    int ruedas;
}

/*Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

    */
int num = 5;
bool numeroMayor = num > 18;

char letra = 'a';
if(letra.Length == 1)
{
    Console.WriteLine("letra es un char);
}