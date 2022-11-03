// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

Console.WriteLine("Hello, World!");

//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
//Buon lavoro!
////Console.WriteLine("inserire un prezzo");
////int prezzo = Convert.ToInt32(Console.ReadLine());


////Console.WriteLine("inserire un nome prodotto");
////string nome = Console.ReadLine();

////Prodotto  prodotto = new Prodotto( prezzo, nome);




////Console.WriteLine(prodotto.GetCodice() + "codice prodotto" );
////Console.WriteLine(prodotto.prezzoConIva() + "prezzo con iva" );

////Console.WriteLine("nome esteso - " + prodotto.GetNomeCompleto());



////public class Prodotto
////{
////    private string codice;
////    public string nome;
////    public string descrizione;
////    public int prezzo;
////    public int iva;

////    public Prodotto(int prezzo ,string nome)
////    {
////       var Rand = new Random().Next(1,1000); 
////       string code = ""; 
////        if (Convert.ToString(Rand).Length < 8)
////        {

////            for (int i = 0; i < 8; i++)
////            {
////                int razione = 8 - Convert.ToString(Rand).Length  ;
////                if ( i < razione)
////                {
////                    code = code + "0";
////                }else
////                {
////                    code = code + Convert.ToString(Rand);
////                    break;
////                }
////            }
////        } else
////        {
////          code = Convert.ToString(Rand);
////        }

////       this.codice = code;
////       this.prezzo = prezzo;
////       this.nome = nome;
////       this.iva = 12;
////    }

////    public int prezzoConIva()
////    {
////        return prezzo + this.ivaProdotto();
////    }

////    public int ivaProdotto()
////    {
////        int percento = this.prezzo / 100;
////        int ivaTotale = this.iva * percento;

////        return ivaTotale;
////    }



////    public string GetCodice()
////    {
////        return this.codice;
////    }

////    public string GetNomeCompleto()
////    {
////        return this.nome + " " + this.codice;
////    }
////}



Prodotto prodotto = new Prodotto();
Console.WriteLine("inserire un prezzo");
prodotto.Prezzo = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("inserire un nome prodotto");
prodotto.Nome = Console.ReadLine();



Console.WriteLine(prodotto.GetCodice() + "codice prodotto");
Console.WriteLine(prodotto.prezzoConIva() + "prezzo con iva");

Console.WriteLine("nome esteso - " + prodotto.GetNomeCompleto());



public class Prodotto
{
    private string Codice {get;}
    public string Nome { get; set; }
    public string Descrizione {get; set; }
    public int Prezzo { get; set; }
    public int Iva { get; }

    public Prodotto()
    {
        this.Iva = 12;
        var Rand = new Random().Next(1, 1000);
        string code = "";
        if (Convert.ToString(Rand).Length < 8)
        {

            for (int i = 0; i < 8; i++)
            {
                int razione = 8 - Convert.ToString(Rand).Length;
                if (i < razione)
                {
                    code = code + "0";
                }
                else
                {
                    code = code + Convert.ToString(Rand);
                    break;
                }
            }
        }
        else
        {
            code = Convert.ToString(Rand);
        }
        this.Codice = code; 
    }

        public int prezzoConIva()
    {
        return Prezzo + this.ivaProdotto();
    }

    public int ivaProdotto()
    {
        int percento = this.Prezzo / 100;
        int ivaTotale = this.Iva * percento;

        return ivaTotale;
    }



    public string GetCodice()
    {
        return this.Codice;
    }

    public string GetNomeCompleto()
    {
        return this.Nome + " " + this.Codice;
    }
}

