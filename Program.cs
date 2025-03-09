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
        String[] palavras = [];
        try
        {
            StreamReader reader = new StreamReader("C:\\Users\\Isaque\\Desktop\\Arquivos\\arquivo_teste.txt");
            linha = reader.ReadLine();
            
            while (linha != null)
            {
                palavras = linha.Split();
                listaPalavras.Add(repeticoes++, palavras);
                linha = reader.ReadLine();
                foreach (string palavra in palavras)
                {
                    Console.WriteLine(palavra);
                }
            }


            reader.Close();
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