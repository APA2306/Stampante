using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Anelli.Alessandro._4I.stampante
{
    public class Stampante
    {
        public int Ciano { get; set; }
        public int Nero { get; set; } 
        public int Giallo { get; set; }
        public int Magenta { get; set; }
        public int Fogli { get; set; }


        public Stampante()
        {
            Ciano = Nero = Giallo = Magenta = 100;
            Fogli = 200;
        }

        public bool Stampa(Pagina pagina)
        {
            if(Ciano - pagina.Ciano > 0 && Nero - pagina.Nero > 0 && Giallo - pagina.Giallo > 0 && Magenta - pagina.Magenta > 0 && Fogli - 1 > 0)
            {
                Ciano = Ciano - pagina.Ciano;
                Nero = Nero - pagina.Nero;
                Giallo = Giallo - pagina.Giallo;
                Magenta = Magenta - pagina.Magenta;
                Fogli = Fogli--;
                return true;
            }
            else
            {
                return false;
            }  
        }
        public int StatoInchiostro(string C) 
        {
            if (C.ToLower() == "Ciano")
                return Ciano;
            else if (C.ToLower() == "nero")
                return Nero;
            else if (C.ToLower() == "giallo")
                return Giallo;
            else if (C.ToLower() == "magenta")
                return Magenta;
            else
            {
                MessageBox.Show("Colore invalido");
                return 0;
            }
        }
        public void SostituisciColore(String C)
        {
            if (C.ToLower() == "ciano")
                Ciano = 100;
            else if (C.ToLower() == "nero")
                Nero = 100;
            else if (C.ToLower() == "giallo")
                Giallo = 100;
            else if (C.ToLower() == "magenta")
                Magenta = 100;
            else
            {
                MessageBox.Show("Tipo di colore invalido.");
                return;
            }
        }
        public int StatoCarta()
        {
            return Fogli;
        }
        public void AggiungiCarta(int q)
        {
            if (q > 0)
            {
                MessageBox.Show("Impossibile caricare un numero negativo di carta");
                return;
            }
            else if (Fogli + q <= 200)
                Fogli = Fogli + q;
            else
                Fogli = 200;

            MessageBox.Show("Carta caricata");

        }
    }
}
    