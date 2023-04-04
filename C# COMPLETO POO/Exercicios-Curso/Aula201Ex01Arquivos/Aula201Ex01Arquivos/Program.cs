using Aula201Ex01Arquivos.Entities;
using System.Globalization;

namespace Aula201Ex01Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho para o arquivo: ");
            string sourceFilePath = Console.ReadLine();

            string[] lines = File.ReadAllLines(sourceFilePath);

            string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
            string targetFolderPath = sourceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\summary.csv";

            Directory.CreateDirectory(targetFolderPath);

            try
            {
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double value = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, value, quantity);

                        sw.WriteLine(product.Name + ", " + product.Total().ToString("F2", CultureInfo.InvariantCulture));

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }


        }
    }
}
