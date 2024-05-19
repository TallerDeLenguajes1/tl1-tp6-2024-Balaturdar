// See https://aka.ms/new-console-template for more information
/*
    Construir un programa que permita invertir un número. Verifique que el
    texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
    número sólo si éste es mayor a 0.
    Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
    "nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
    la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.
*/
int num;
int inverso = 0;

do{
    Console.WriteLine("Ingrese un numero positivo");
    //string numero =  Console.ReadLine();
    int.TryParse(Console.ReadLine(), out num);
} while (num <= 0);
while (num != 0){
    int digi = num % 10 ;
    inverso = inverso * 10 + digi;
    num /= 10 ;
}
Console.WriteLine("El inverso del número ingresado es:" + inverso) ;