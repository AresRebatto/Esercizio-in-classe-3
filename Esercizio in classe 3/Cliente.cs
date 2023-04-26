using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_in_classe_3
{
    class Cliente
    {
        private string _nome;
        private string _cognome;
        private DateTime _bornDate;
        private char _sesso;
        private Abbonamento _abbonamento;

        public Cliente(string nome, string cognome, DateTime born, char sesso, DateTime inizio, DateTime fine)
        {
            this._abbonamento = new Abbonamento(inizio, fine);
            this._nome = nome;  
            this._cognome = cognome;
            this._bornDate = born;
            this._sesso = sesso;
        }
    }
}
