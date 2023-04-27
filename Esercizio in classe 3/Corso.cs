using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_in_classe_3
{
    internal class Corso
    {
        private string _nome;
        private string _descrizione;
        private Istruttore _istruttore;
        private string[] _giorniDisponibili;
    
        public Corso(string nome, string descrizione, Istruttore istruttore, string[] giorniDisponibili)
        {
            this._nome = nome;
            this._descrizione = descrizione;
            this._istruttore = istruttore;
            _giorniDisponibili = giorniDisponibili;
        }

        public string GetNome()
        { return _nome; }
        public string[] GetGiorniDisponibili() 
        { return this._giorniDisponibili; }
    }
}
