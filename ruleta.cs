using System;
using System.Collections.Generic;
namespace ruleta{

class Program
{
    static void Main(string[] args) {
        Random random = new Random();
      
        int saldo = 300;
        
     while(saldo>0){
            Console.WriteLine("Tu saldo es de $" + saldo + ".");
            Console.WriteLine();
            Console.WriteLine("\tMenú de apuestas:");
            Console.WriteLine("1. Apostar a un número específico");
            Console.WriteLine("2. Apostar a color (rojo o negro)");
            Console.WriteLine("3. Apostar a par o impar");
            Console.WriteLine("4. Salir del juego");
            Console.WriteLine();    
            
            Console.Write("Elige una opción (1-4): ");
           // int opcion = int.Parse(Console.ReadLine());
            
            switch(Console.ReadLine())
            {
                case "1":
                 // Apostar a un número específico
                 Console.Write("Elige un número (0-36): ");
                 int numero = int.Parse(Console.ReadLine());
                 
                 //desidir lo que se apuesta
                 Console.Write("¿Cuánto quieres apostar? (en múltiplos de 10): ");
                 int apuesta = int.Parse(Console.ReadLine());
                 
                 //nuemro random
                 int randomNumber = random.Next(1, 37);
                 
                 Console.WriteLine("El resultado del giro es: " + randomNumber);
                  if (randomNumber == numero ) {
                      
                    Console.WriteLine("Ganaste!!");
                    saldo= saldo+apuesta;
                    
                 } else {
                    Console.WriteLine("perdiste");
                    saldo = saldo-apuesta;
                 }
                 break;
                case "2":
                    int[] Neg={ 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33 , 35};
                    int[] roj={ 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34 , 36};
                    
                    Console.Write("Elige rojo= 1 o negro= 2 :\n ");
                    int color= int.Parse(Console.ReadLine());
                    
                    Console.Write("cuanto apuestas? :\n ");
                     apuesta = int.Parse(Console.ReadLine());
                    
                     randomNumber = random.Next(1, 37);
                     
                    //recorree lista y compara 
                    for(int x=0; x<=17;x++){
                        //random negro  y apostar negro
                        if (randomNumber == Neg[x] && color==2){
                            Console.Write($"resultado es negro {randomNumber}:\n ");
                            Console.Write("\t Gano!!:\n ");
                            saldo= saldo+apuesta;
                            
                        //random rojo  y apostar rojo    
                        }else if(randomNumber == roj[x] && color==1){
                            Console.Write($"resultado es rojo {randomNumber}:\n ");
                            Console.Write("\t Gano!!:\n ");
                            saldo= saldo+apuesta;
                        }
                    }
                    //si no ganaste entonces perdiste 
                    Console.Write("\t perdiste!!:\n ");
                    saldo= saldo-apuesta;
                  break;
                case "3":
                    Console.Write("Apuestas Par= 1   Inpar= 2 :\n ");
                    numero = int.Parse(Console.ReadLine());
                    
                    Console.Write("cuanto apuestas? :\n ");
                    apuesta = int.Parse(Console.ReadLine());
                    
                    randomNumber = random.Next(1, 37);
                    
                    if(randomNumber % 2 ==0 && numero == 1){
                        Console.Write($"resultado par {randomNumber} :\n ");
                        Console.Write("\t Ganaste!!:\n ");
                            saldo= saldo+apuesta;
                            
                    }else if (randomNumber % 2 ==0 && numero == 2){
                        Console.Write($"resultado par {randomNumber} :\n ");
                        Console.Write("\t perdiste!!:\n ");
                            saldo= saldo-apuesta;
                    }else if(randomNumber%2 >0 && numero == 2){
                        Console.Write($"resultado Impar {randomNumber} :\n ");
                        Console.Write("\t Ganastee!!:\n ");
                            saldo= saldo+apuesta;
                    }else{
                        Console.Write($"resultado Inpar {randomNumber} :\n ");
                        Console.Write("\t perdiste!!:\n ");
                            saldo= saldo-apuesta;
                        
                    }
                    
                    
                break;
                case "4":
                
                
                
                break;
                
            }//switch
        }//while

    }//main
}//class

}