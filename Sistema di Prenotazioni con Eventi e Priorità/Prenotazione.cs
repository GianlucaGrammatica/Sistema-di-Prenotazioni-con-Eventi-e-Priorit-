using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_di_Prenotazioni_con_Eventi_e_Priorità
{
    internal class Prenotazione
    {
        public string NomeCliente;
        public int Priorità;

        public Prenotazione()
        {
            NomeCliente = "";
            Priorità = 0;
        }

        public Prenotazione(string nomeCliente, int priorità)
        {
            NomeCliente = nomeCliente;
            Priorità = priorità;
        }
    }
}
