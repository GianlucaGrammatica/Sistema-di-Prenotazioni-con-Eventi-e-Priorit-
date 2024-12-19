using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_di_Prenotazioni_con_Eventi_e_Priorità
{
    internal class Reception
    {
        public Reception() { }

        public void OnPrenotazioneGestita(string nomeCliente, int priorità)
        {
            Console.WriteLine($"[Reception] Benvenut* {nomeCliente}");
        }
    }
}
