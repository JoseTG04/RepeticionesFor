namespace BucleFor.Repeticion
{
    public class RepeticionFor
    {
        public void Mayores1000()
        {
            int cantidad;
            int valor;
            int nMil = 0;
            int nMenor = 0;
            int nMayor = 0;

            try
            {
                Console.Write("Digite la cantidad de numeros a leer: ");
                cantidad = Convert.ToInt32(Console.ReadLine());
                

                if ((cantidad == 0) || (cantidad >= 50))
                {
                    Console.WriteLine("Por favor digite un número menor a 50");
                    return;
                }

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write($"Digite el {i} número a leer: ");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor == 1000)
                    {
                        nMil++;
                    }
                    else if (valor > 1000)
                    {
                        nMayor++;
                    }
                    else
                    {
                        nMenor++;
                    }
                }

                Console.Clear();    

                Console.WriteLine("------------------------------------");

                Console.WriteLine($"Cantidad de números iguales a mil {nMil}");

                Console.WriteLine($"Cantidad de números mayores a mil {nMayor}");

                Console.WriteLine($"Cantidad de números menores a mil {nMenor}");

                Console.WriteLine("------------------------------------");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al comprobar los números");
            }
            
        }
    }
}
