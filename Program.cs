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
    return num1 / num2;
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
/*
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
*/
//------------------------------------------------------------------------------------------------
/*
Ejercicio 4.
Realizar los siguientes ejercicios
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
tarea:
*/
Console.WriteLine("Ingrese una cadena de texto");
string cadena = Console.ReadLine();

//● Obtener la longitud de la cadena y muestre por pantalla.

Console.WriteLine("Longitud de la cadena es: " +cadena.Length);


//● A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.

Console.WriteLine("Ingrese una segunda cadena de texto");
string cadena2 = Console.ReadLine();

string cadenasConcatendas = string.Concat(cadena, cadena2);
Console.WriteLine("Cadenas concatenadas: " + cadenasConcatendas);

//● Extraer una subcadena de la cadena ingresada.
string subcadena = cadena2.Substring(0, cadena2.Length/2);
Console.WriteLine("Una subcadena de la cadena 2: " + subcadena);

/*● Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado. Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente.
Nota: Busque el comportamiento del Método ToString();*/

int opc;
float num1, num2;
bool aux;

do{
    Console.WriteLine("***********************");
    Console.WriteLine("**      1- Suma      **");
    Console.WriteLine("**      2- resta     **");
    Console.WriteLine("** 3- multiplicacion **");
    Console.WriteLine("**    4- division    **");
    Console.WriteLine("**      5- salir     **");
    Console.WriteLine("***********************");

    do{
    Console.WriteLine("elija una opcion");
    aux = int.TryParse(Console.ReadLine(), out opc);
    if(!aux){
        Console.WriteLine("Debe ingresar un numero");
    }
    } while (!aux);
    
    do{
    Console.WriteLine("Ingrese el primer numero: ");
    aux = float.TryParse(Console.ReadLine(), out num1);
    if(!aux){
        Console.WriteLine("Debe ingresar un numero");
    }
    } while (!aux);

    do{
    Console.WriteLine("Ingrese el segundo numero: ");
    aux = float.TryParse(Console.ReadLine(), out num2);
    if(!aux){
        Console.WriteLine("Debe ingresar un numero");
    }
    } while (!aux);

    switch (opc){
        case 1:
            Console.WriteLine("La suma entre "+ num1.ToString() + " y " + num2.ToString() + " es: " + (num1+num2).ToString());
            break;
        case 2:
            Console.WriteLine("La Resta entre "+ num1.ToString() + " y " + num2.ToString() + " es: " + (num1-num2).ToString());
            break;
        case 3:
            Console.WriteLine("El producto entre "+ num1.ToString() + " y " + num2.ToString() + " es: " + (num1*num2).ToString());
            break;
        case 4:
            if(num2 == 0){
                Console.WriteLine("El divisor no debe ser cero");
                break;
            }
            Console.WriteLine("La division de "+ num1.ToString() + " en " + num2.ToString() + " es: " + (num1/num2).ToString());
            break;
    }
    if(opc == 5){
        break;
    }else{
        Console.WriteLine("¿Desea realizar otro calculo? S/N");
        opc = ("N".Equals(Console.ReadLine()))? 5 : 0;
    }

} while(opc != 5);


//● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla

Console.WriteLine("Recorriendo cadena");
foreach (char c in cadena)
{
    Console.WriteLine(c);
}

//● Buscar la ocurrencia de una palabra determinada en la cadena ingresada

Console.WriteLine("Buscando Ocurrencia de una palabra deerminada en la cadena ingresada");
Console.WriteLine("Ingrese la palabra a buscar:");
string palabra = Console.ReadLine();
int posicion = cadena.IndexOf(palabra);
if (posicion != -1)
{
    Console.WriteLine($"La palabra '{palabra}' se encuentra en la posición {posicion}");
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no se encuentra en la cadena");
}


//● Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine("Cadena en mayusculas: " + cadena.ToUpper());
Console.WriteLine("Cadena en minusculas: " + cadena.ToLower());

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())

Console.WriteLine("Ingrese una cadena separada por guion '-'':");
string cadenaSeparada = Console.ReadLine();
string[] partes = cadenaSeparada.Split('-');
    //recorro la matriz
    foreach (string parte in partes)
    {
        Console.WriteLine(parte);
    }

//● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingresepor pantalla “582+2” y que le devuelva la suma de 582 con 2

Console.WriteLine("Ingrese una ecuación simple con un operador '+' o '-' o '*' o '/'(por ejemplo 582+2): ");
string ecuacionCadena = Console.ReadLine();
int a, b;

if (ecuacionCadena.Contains("+"))
{
    partes = ecuacionCadena.Split('+'); //string [] partes ya declarado lo vuelvo a usar
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a + b));
}
else 
if (ecuacionCadena.Contains("-"))
{
    partes = ecuacionCadena.Split('-');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a - b));
}
else if (ecuacionCadena.Contains("*"))
{
    partes = ecuacionCadena.Split('*');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a * b));
}
else if (ecuacionCadena.Contains("/"))
{
    partes = ecuacionCadena.Split('/');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a / b));
}