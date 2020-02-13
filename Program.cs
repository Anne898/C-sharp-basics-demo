using System;

namespace C_sharp_basics_demo
{
    class Program
    {
       static void printVariable(String nombreVariable, Object variable, Type tipoVariable){  //metodo para devolver nombre y tipo

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
           
           int VariableInt=5; 
           long VariableLong=76876;
           float VariableFloat=5.78f;
           double VariableDouble=687.9;
           decimal VariableDecimal=545.777m;
           char VariableChar='A';
           string VariableString="Hola";
           Boolean VariableBoolean=true;


            printVariable(nameof(VariableInt),VariableInt,VariableInt.GetType());
            printVariable(nameof(VariableLong),VariableLong,VariableLong.GetType());
            printVariable(nameof(VariableFloat),VariableFloat,VariableFloat.GetType());
            printVariable(nameof(VariableDouble),VariableDouble,VariableDouble.GetType());
            printVariable(nameof(VariableDecimal),VariableDecimal,VariableDecimal.GetType());
            printVariable(nameof(VariableChar),VariableChar,VariableChar.GetType());
            printVariable(nameof(VariableString),VariableString,VariableString.GetType());
            printVariable(nameof(VariableBoolean),VariableBoolean,VariableBoolean.GetType());

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
