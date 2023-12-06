using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Anelli.Alessandro._4I.stampante
{
    public class Pagina
    {
        private int nero;
        private int ciano;
        private int giallo;
        private int magenta;

        public int Nero { get => nero; set => nero = value; }
        public int Ciano { get => ciano; set => ciano = value; }
        public int Giallo { get => giallo; set => giallo = value; }
        public int Magenta { get => magenta; set => magenta = value; }

        public Pagina(int N, int C, int G, int M)
        {
            if (N <= 3 && C <= 3 && G <= 3 && M <= 3 && N > 0 && C > 0 && G > 0 && M > 0)
            {
                Nero = N;
                Ciano = C;
                Giallo = G;
                Magenta = M;
            }
            else
            {
                MessageBox.Show("I valori devono essere compresi fra 0 e 3");
                throw new ArgumentException();
            }

        }
        public Pagina()
        {
            Random random = new Random();
            Nero = random.Next(4);
            Ciano = random.Next(4);
            Giallo = random.Next(4);
            Magenta = random.Next(4);
        }
    }
}
