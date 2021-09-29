using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string decodemessage = Console.ReadLine();

            string comand = Console.ReadLine();

            while (comand != "Decode")
            {
                string[] splited = comand.Split("|");

                if (splited[0]== "Move")
                {
                    int count = int.Parse(splited[1]);

                    if (count >= 0 &&  count <= decodemessage.Length)
                    {
                        string move = decodemessage.Substring(0, count);
                        decodemessage = decodemessage.Insert(decodemessage.Length, move);
                        decodemessage = decodemessage.Remove(0, count);
                    }
                }
                else if (splited[0]== "Insert")
                {
                    int index = int.Parse(splited[1]);
                    string value = splited[2];
                    if (index >= 0 && index <= decodemessage.Length)
                    {
                        decodemessage = decodemessage.Insert(index, value);
                    }
                }
                else if (splited[0]== "ChangeAll")
                {
                    string old = splited[1];
                    string curent = splited[2];
                    if (decodemessage.Contains(old))
                    {
                        decodemessage = decodemessage.Replace(old, curent);
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {decodemessage}");
        }
    }
}
