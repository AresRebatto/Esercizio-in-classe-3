using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_in_classe_3
{
    internal class Istruttore
    {
        //3 Istruttori
        private string _nome;
        private string _cognome;
        private List<Corso> _listaCorsi = new List<Corso>();

        public Istruttore(string nome, string cognome) 
        {
            this._nome = nome;
            this._cognome = cognome;
        }

        public void AggiungiCorso(string nomeCorso, Palestra palestra)
        {
            foreach(Corso elementi in palestra.GetListCorsi())
            {
                if(elementi.GetNome() == nomeCorso)
                {
                    this._listaCorsi.Add(elementi);
                }
                else
                {
                    Console.WriteLine("Il corso non è tra quelli disponibili");
                }
            }
        }
    }
}
