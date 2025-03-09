class Program
{
    static void Main()
    {
        OrdenaTexto();
    }

    static string OrdenaTexto()
    {
        Dictionary<Int32, String[]> listaPalavras = [];
        int repeticoes = 0;
        String linha;
        String[] palavra;
        try
        {
            StreamReader reader = new StreamReader("C:\\Users\\Isaque\\Desktop\\Arquivos\\arquivo_teste.txt");
            linha = reader.ReadLine();
            
            while (linha != null)
            {
                palavra = linha.Split();
                listaPalavras.Add(repeticoes++, palavra);
                linha = reader.ReadLine();
            }

            reader.Close();
            Console.WriteLine(String.Join(",", listaPalavras));
        }
        catch(Exception e)
        {

        }
        finally
        {

        }

        return "";
    }
}