using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Esercizio_in_classe_3
{
    class Cliente
    {
        private string _nome;
        private string _cognome;
        private DateTime _bornDate;
        private char _sesso;
        private Abbonamento _abbonamento;
        private Dictionary<Corso, List<string>> corsoSeguito = new Dictionary<Corso, List<string>>();

        public Cliente(string nome, string cognome, DateTime born, char sesso, DateTime inizio, DateTime fine)
        {
            this._abbonamento = new Abbonamento(inizio, fine);
            this._nome = nome;  
            this._cognome = cognome;
            this._bornDate = born;
            this._sesso = sesso;
        }

        public void PrenotaCorso(string nomeCorso, Palestra palestra)
        {
            foreach(Corso elemento in palestra.GetListCorsi())
            {
                if(elemento.GetNome() == nomeCorso)
                {
                    Console.WriteLine("I giorni disponibili sono: ");
                    foreach(string giorni in elemento.GetGiorniDisponibili())
                    {
                        Console.WriteLine(giorni);
                    }
                    List<string> giorniPrenotati = new List<string>();
                    string giorno;
                    int cnt = 0;
                    Console.WriteLine("Scegliere giorni in cui ci si vuole prenotare: ");
                        
                    do
                    {
                        giorno = Console.ReadLine();
                        foreach (string giorni in elemento.GetGiorniDisponibili())
                        {
                            if (giorno == giorni)
                            {
                                giorniPrenotati.Add(giorni);
                                cnt++;
                            }
                            else
                            {
                                Console.WriteLine("Giorno non disponibile per il corso");
                            }
                        }

                    } while (giorno != "*" && cnt <= 7);
                }
            }

        }
    }
}
