# WPFStampante
Sistema semplificato che replica il funzionamento di una stampante a colori. Il programma possiede due classi. 

la classe stampante che possiede cinque attributi: Fogli che conta il numero di fogli nel cassetto della stampante partendo da 200 e i quattro attributi dei colori della stampante (ciano, nero, giallo e magenta) tutti e quattro partono da un massimo di 100. La classe possiede anche cinque metodi uno per stampare un foglio, due per controllare lo stato dell'inchiostro e della carta e due per sostituire un colore o la carta.

```c#
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
```

La classe Pagina invece possiede quattro attributi che rappresentano l'inchiostro necessario per essere stampate e possiede due costruttori, uno in cui le quantita di inchiostro vengono inserite dall'utente con un massimo di tre per colore e uno che genera una pagina casualmente.

```c#
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
        Nero = random.Next(3);
        Ciano = random.Next(3);
        Giallo = random.Next(3);
        Magenta = random.Next(3);
    }
}
```
