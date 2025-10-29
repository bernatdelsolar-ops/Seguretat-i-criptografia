using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

/*          String textIn = null;
            Console.Write("Entra text: ");
            while (string.IsNullOrEmpty(textIn))
            {
                Console.Clear();
                Console.Write("Entra text: "); 
                textIn = Console.ReadLine();
            }
            // Convertim l'string a un array de bytes
            byte[] bytesIn = Encoding.UTF8.GetBytes(textIn);
            // Instanciar classe per fer hash

            // fent servir using ja es delimita el seu àmbit i no cal fer dispose
            using (SHA512Managed SHA512 = new SHA512Managed())
            {
                // Calcular hash
                byte[] hashResult = SHA512.ComputeHash(bytesIn);

                // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
                // cal convertir-lo a un string

                String textOut = BitConverter.ToString(hashResult).Replace("-", string.Empty);
                Console.WriteLine("Hash del text{0}", textIn);
                Console.WriteLine(textOut);
                Console.ReadKey();

                }

            */

namespace hash01
{


    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. llegir fitxer de text");
                    Console.WriteLine("2. Guardar fitxer hash");
                    Console.WriteLine("3. provar inyegritat fitxer");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            
                            
                                // Specifying a file
                                string path = @"file.txt";

                                // Calling the ReadAllText() function
                                string readFile = File.ReadAllText(path);

                                // Printing the file contents
                                Console.WriteLine(readFile);

                                byte[] bytesIn = Encoding.UTF8.GetBytes(readFile);

                                using (SHA512Managed SHA512 = new SHA512Managed())
                                {
                                    // Calcular hash
                                    byte[] hashResult = SHA512.ComputeHash(bytesIn);

                                     String textOut = BitConverter.ToString(hashResult).Replace("-", string.Empty);
                                    Console.WriteLine("Hash del text{0}", textOut);
                                    Console.WriteLine(textOut);

                                }



                            

                            break;

                        case 2:
                           
                            Console.WriteLine("Has elegido la opción 2");
                            // Specifying a file
                             path = @"file.sha";

                            // Creating a string
                             readFile = "Guardant" + Environment.NewLine;

                            // Writing the string to the file
                            File.WriteAllText(path, readFile);

                            // Reading the contents of the file
                            string readText = File.ReadAllText(path);
                            Console.WriteLine(readText);
                            break;

                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            bool bEqual = false;

                            path = @"file.sha";

                            readFile = File.ReadAllText(path);

                            readText = File.WriteAllText(path,readFile); 

                            if (readText == readFile)
                            {
                                bEqual = true;
                            }

                                if (bEqual)
                                Console.WriteLine("The two hash values are the same");
                            else
                                Console.WriteLine("The two hash values are not the same");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
          
          



        }

    

            }

        }
    
