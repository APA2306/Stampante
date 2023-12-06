using System;
using System.CodeDom;
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
        public Colore StatoInchiostro(Colore C) 
        {
            return C;
        }
        public void SostituisciColore(Colore C)
        {
            switch (C)
            {
                case Colore.Ciano:
                    Ciano = 100;
                    return;
                case Colore.Nero:
                    Nero = 100;
                    return;
                case Colore.Giallo:
                    Giallo = 100;
                    return;
                case Colore.Magenta:
                    Magenta = 100;
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
    