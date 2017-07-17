using System;

namespace StringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1 Texto delimitado | Demilited text
            var text = "col1;col2;col3\n" +
                       "1;data1;data1\n" +
                       "2;data2;data2\n" +
                       "3;data3;data3\n" +
                       "4;data4;data4\n" +
                       "5;data5;data5\n" +
                       "6;data6;data6\n" +
                       "7;data7;data7\n" +
                       "8;data8;data8\n" +
                       "9;data9;data9\n" +
                       "10;data10;data10\n" +
                       "11;data11;data11\n" +
                       "12;data12;data12\n" +
                       "13;data13;data13\n" +
                       "14;data14;data14\n" +
                       "15;data15;data15\n" +
                       "16;data16;data16\n" +
                       "17;data17;data17\n" +
                       "18;data18;data18\n";

            // #2 Declarando uma instância do objeto StringReader | Declare StringReader object instance
            var sr = new System.IO.StringReader(text);

            // #3 Lendo as linhas do texto | Read text lines
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            // #4 Concluindo a leitura | Read done
            Console.WriteLine("Read complete!");

            // #5 Fechando o leitor | Close the reader
            sr.Close();

            Console.ReadLine();
        }
    }
}
