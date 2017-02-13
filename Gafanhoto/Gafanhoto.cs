/*
	@title - APPLICATION OPEN .TXT FILE, EDIT AND SAVE TO A NEW FILE
	@author - ELIDIOMAR RODRIGUES
	@email - ELIDIOMAR.RODRIGUES@GMAIL.COM
	@language - PT-BR
	@version - 1.0
*/

using System.IO;

namespace Gafanhoto
{
    class Gafanhoto
    {
        private int contador = 0;
        private string lineRead;
        private int total = 0;

        public int comerFolhas(string strFile)
        {

            // ABRE ARQUIVO
            StreamReader fileRead = new StreamReader(strFile);

            // SALVA ARQUIVO
            StreamWriter fileWriter = new StreamWriter(strFile.Replace(".txt", "_Gerado.txt"));

            // LER ARQUIVO - LINHA POR LINHA
            while ((lineRead = fileRead.ReadLine()) != null)
            {

                //LER LINHA - CARACTER POR CARACTER
                for (int i = 0; i < lineRead.Length; i++)
                {

                    // SE FOR INICIO DE LINHA E O ARRAY COMEÇAR COM 0 IMPRIME POSIÇÃO REFERENTE
                    if (i == 0 && lineRead[i] == '0')
                    {                 
                        fileWriter.Write(i +1);
                        total++;
                    }

                    // SE O CONTADOR FOR IGUAL A DOIS E O ARRAY FOR IGUAL A 0 IMPRIME POSIÇÃO E ZERA O CONTADOR
                    if (contador == 2 && lineRead[i] == '0')
                    {
                        fileWriter.Write("," + (i + 1));
                        contador = 0;
                        total++;
                    }

                    // ACRESCENTA MAIS UM NO CONTADOR CASO O ARRAY SEJA IGUAL A "1"
                    if (contador < 2 && lineRead[i] == '0')
                    {
                        contador++;
                    }
                }

                // QUEBRA DE LINHA E ZERA O CONTADOR
                fileWriter.WriteLine('\n');
                contador = 0;
            }

            // FECHA OS ARQUIVOS
            fileRead.Close();
            fileWriter.Close();
            return total;
        }
    }
}
