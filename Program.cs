// See https://aka.ms/new-console-template for more information
/*
    Construir un programa que permita invertir un número. Verifique que el
    texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
    número sólo si éste es mayor a 0.
    Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
    "nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
    la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/
//int num;
//int inverso = 0;
//
//do{
//    Console.WriteLine("Ingrese un numero positivo");
//    //string numero =  Console.ReadLine();
//    int.TryParse(Console.ReadLine(), out num);
//} while (num <= 0);
//while (num != 0){
//    int digi = num % 10 ;
//    inverso = inverso * 10 + digi;
//    num /= 10 ;
//}
//Console.WriteLine("El inverso del número ingresado es:" + inverso) ;

/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) 
a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/


using System.Xml;

int opcion;
float num1, num2;

do
{
    Console.WriteLine("***********************");
    Console.WriteLine("**      1- Suma      **");
    Console.WriteLine("**      2- resta     **");
    Console.WriteLine("** 3- multiplicacion **");
    Console.WriteLine("**    4- division    **");
    Console.WriteLine("**      5- salir     **");
    Console.WriteLine("***********************");
    Console.WriteLine("Elija un Opcion: ");
    int.TryParse(Console.ReadLine(),out opcion);
    Console.WriteLine("Ingrese el primer numero: ");
    float.TryParse(Console.ReadLine(),out num1);
    Console.WriteLine("Ingrese el segundo numero: ");
    float.TryParse(Console.ReadLine(),out num2);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("La suma de es: " + suma(num1, num2));
            break;
        case 2:
            Console.WriteLine("La resta es : " + Resta(num1, num2));
            break;
        case 3:
            Console.WriteLine("El producto es: " + multiplicacion(num1, num2));
            break;
        case 4:
            if(num2 == 0){
                Console.WriteLine("El divisor no debe ser cero");
                break;
            }
            Console.WriteLine("El cociente es:  " + division(num1, num2));
            break;
    }
    if(opcion == 5){
        break;
    }else{
        Console.WriteLine("¿Desea realizar otro calculo? S/N");
        opcion = ("N".Equals(Console.ReadLine()))? 5 : 0;
    }

} while(opcion != 5);


float suma(float num1, float num2)
{
    return num1 + num2;
}

float Resta(float num1, float num2)
{
    return num1 - num2;
}
float multiplicacion(float num1, float num2)
{
    return num1 * num2;
}

float division(float num1, float num2)
{
    return num1 * num2;
}