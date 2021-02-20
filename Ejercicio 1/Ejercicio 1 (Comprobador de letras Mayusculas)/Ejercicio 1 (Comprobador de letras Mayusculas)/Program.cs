using System;

class Program
{

    
    static public void Main(string[] args)
    {
        
        string let = string.Empty;
        {
            

            
            Console.WriteLine("Escriba una letra: \n");
            let = Console.ReadLine();

            
            if (IsLetters(let))
            {
                if (let == "A" || let == "B" || let == "C" || let == "D" || let == "E" ||
                    let == "F" || let == "G" || let == "H" || let == "I" || let == "J" ||
                    let == "K" || let == "L" || let == "M" || let == "N" || let == "Ñ" ||
                    let == "O" || let == "P" || let == "Q" || let == "R" || let == "S" ||
                    let == "T" || let == "U" || let == "V" || let == "W" || let == "X" ||
                    let == "Y" || let == "Z") 
                  { Console.WriteLine("####### LA LETRA SI ES MAYUSCULA #########"); }
                    else { Console.WriteLine("no es mayuscula :("); }

            }
            else
            {
                Console.WriteLine("Solo se aceptan letras");
                return;
            }
            Console.ReadLine();
        }
        //Metodo que permite identificar si los caracteres son letras o no
        static bool IsLetters(string let)
        {
            foreach (char ch in let)
            {
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
