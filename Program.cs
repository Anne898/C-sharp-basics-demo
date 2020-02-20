using System;

namespace C_sharp_basics_demo
{
    class Program
    {
       static void PrintVariable(String nombreVariable, Object variable, Type tipoVariable){  //metodo para devolver nombre y tipo

         Console.WriteLine($"Nombre: {nombreVariable}, Valor: {variable}, Tipo: {tipoVariable} ");
           
       } 
       static void OperacionesComparacion(String resultado ){  //metodo para devolver nombre y tipo

         Console.WriteLine($"Resultado: {resultado}");
           
       } 
      
         static void Operaciones(Int32 res ){  //metodo para devolver nombre y tipo

         Console.WriteLine($"Resultado: {res}");
           
       } 

        static void Main(string[] args)
        {
           
           int variableInt=5; 
           long variableLong=76876;
           float variableFloat=5.78f;
           double variableDouble=687.9;
           decimal variableDecimal=545.777m;
           char variableChar='A';
           string variableString="Hola";
           Boolean variableBoolean=true;


            PrintVariable(nameof(variableInt),variableInt,variableInt.GetType());
            PrintVariable(nameof(variableLong),variableLong,variableLong.GetType());
            PrintVariable(nameof(variableFloat),variableFloat,variableFloat.GetType());
            PrintVariable(nameof(variableDouble),variableDouble,variableDouble.GetType());
            PrintVariable(nameof(variableDecimal),variableDecimal,variableDecimal.GetType());
            PrintVariable(nameof(variableChar),variableChar,variableChar.GetType());
            PrintVariable(nameof(variableString),variableString,variableString.GetType());
            PrintVariable(nameof(variableBoolean),variableBoolean,variableBoolean.GetType());

        int num1=36, num2=4;

            if(num1==num2){
               OperacionesComparacion("son iguales");
            }
            else{
              OperacionesComparacion("No son iguales");
            }

            if(num1<num2)
            {
               OperacionesComparacion(num2+" es mayor");
            }
            else
            {
               OperacionesComparacion(num1+" es mayor");
            }

        
          OperacionesComparacion("suma: "+(num1+num2));
          OperacionesComparacion("resta: "+(num1-num2)); 
          OperacionesComparacion("multiplicación: "+(num1*num2));
          OperacionesComparacion("división: "+(num1/num2));  
          OperacionesComparacion("potencia: "+(num1^num2));      
          OperacionesComparacion("raiz cuadrada de "+num1+" es: "+Math.Sqrt(num1));      
          OperacionesComparacion("raiz cuadrada de "+num2+" es: "+Math.Sqrt(num2));
         
        }
    }
}

