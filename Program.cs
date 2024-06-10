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
/*
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
*/

/*
    Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no
ingrese un número válido.
*/

bool aux = true;
float num,num2;

do{
    Console.WriteLine("Ingresar un numero");
    aux = float.TryParse(Console.ReadLine(), out num);
    if(!aux){
        Console.WriteLine("Debe ingresar un numero");
    }
} while (!aux);

Console.WriteLine("El valor absoluto del numero es: " + Math.Abs(num));
Console.WriteLine("El cuadrado del numero ingresado es: " + (num*num));
Console.WriteLine("La raiz cuadrada del numero ingresado es: " + Math.Sqrt(num));
Console.WriteLine("El seno del numero ingresado es: " +  Math.Sin(num));
Console.WriteLine("El coseno del numero ingresado es: " + Math.Cos(num));
Console.WriteLine("La parte entera del numero ingresado es: " + Math.Truncate(num));

do{
    Console.WriteLine("Ingresar el primer numero");
    aux = float.TryParse(Console.ReadLine(), out num);
    if(!aux){
        Console.WriteLine("Debe ingresar un numero");
    }
} while (!aux);
do{
    Console.WriteLine("Ingresar el segundo numero");
    aux = float.TryParse(Console.ReadLine(), out num2);
    if(!aux){
        Console.WriteLine("Debe ingresar un numero");
    }
} while (!aux);

if (num > num2){
    Console.WriteLine("El maximo entre los dos numeros es el primer numero: " + num);
    Console.WriteLine("El minimo entre los dos numeros es el segundo numero: " + num2);
}else if (num<num2){
    Console.WriteLine("El maximo entre los dos numeros es el segundo numero: " + num2);
    Console.WriteLine("El minimo entre los dos numeros es el primer numero: " + num);
}else{
    Console.WriteLine("Ambos numeros ingresados son iguales: " + num + " y " + num2);
}

