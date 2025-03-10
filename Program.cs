class Program
{
    static void Main()
    {
        OrdenaTexto();
    }

    static string OrdenaTexto()
    {
        Dictionary<Int32, String> listaPalavras = [];
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
                linha = reader.ReadLine();
                foreach (string palavra in palavras)
                {
                    if (listaPalavras.ContainsValue(palavra.Replace(",","")))
                    {
                    }
                    else
                    {
                        listaPalavras.Add(repeticoes++, palavra.Replace(",", ""));
                    }
                }
            }
            Console.WriteLine(String.Join(",", listaPalavras));


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