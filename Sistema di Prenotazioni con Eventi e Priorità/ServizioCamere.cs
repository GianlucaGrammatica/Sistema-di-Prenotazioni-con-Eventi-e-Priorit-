using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_di_Prenotazioni_con_Eventi_e_Priorità
{
    internal class ServizioCamere
    {
        public ServizioCamere() { }

        public void OnPrenotazioneGestita(string nomeCliente, int priorità)
        {
            Console.WriteLine($"[Servizio Camere] Camera pronta per {nomeCliente}.");
        }
    }
}
