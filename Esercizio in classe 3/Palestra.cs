using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_in_classe_3
{
    internal class Palestra
    {
        private string _nome;
        Dictionary<Cliente, Corso> _cliente = new Dictionary<Cliente, Corso>();
        List<Corso> _corso = new List<Corso>();

        public Palestra(string nome)
        {
            this._nome = nome;
        }

        public void AggiungiCorso(string nome, string descrizione, Istruttore istruttore, string[] giorni)
        {
            Corso corso = new Corso(nome, descrizione, istruttore, giorni);
            this._corso.Add(corso);
        } 

        public void AggiungiCliente(string nome, string cognome, DateTime born, char sesso, DateTime inizio, DateTime fine, string nomeCorso)
        {
            Cliente nuovoCliente = new Cliente(nome, cognome, born, sesso, inizio, fine);
            foreach(Corso corsi in  _corso) 
            {   
                //Verifica se il corso esiste
                if(corsi.GetNome() == nomeCorso)
                {
                    _cliente.Add(nuovoCliente, corsi);
                }else
                {
                    Console.WriteLine("Corso inesistente");
                }
            }

        }

        public List<Corso> GetListCorsi()
        {
            return _corso;
        }
    }
}
