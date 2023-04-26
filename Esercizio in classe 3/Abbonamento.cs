using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_in_classe_3
{
    internal class Abbonamento
    {
        private DateTime _dataInizio;
        private DateTime _dataFine;

        public Abbonamento(DateTime inizio, DateTime fine)
        { 
            this._dataInizio = inizio;
            this._dataFine = fine;
        }
    }
}
