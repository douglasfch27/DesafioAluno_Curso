using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioZamba1
{
    internal static class Desafio1
    {
        /// <summary>
        /// Programa para cadastrar aluno e curso e exibir lista ordenada
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void bolha(List<Aluno> lista)
        {
            int i;


            for (i = 0; i < lista.Count - 1; i++)
            {
                posMenor = i;
                for (j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[posMenor])
                    {
                        posMenor = j;
                    }
                }

                if (i != posMenor)
                {
                    tmp = lista[i];
                    lista[i] = lista[posMenor];
                    lista[posMenor] = tmp;
                }
            }
        }
    }
}
