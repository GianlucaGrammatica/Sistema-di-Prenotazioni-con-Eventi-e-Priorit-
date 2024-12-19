using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_di_Prenotazioni_con_Eventi_e_Priorità
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gestore = new GestorePrenotazioni();
            var reception = new Reception();
            var servizioCamere = new ServizioCamere();

            gestore.PrenotazioneGestita += reception.OnPrenotazioneGestita;
            gestore.PrenotazioneGestita += servizioCamere.OnPrenotazioneGestita;

            gestore.AggiungiPrenotazione(new Prenotazione("Marco Rossi", 1));
            gestore.AggiungiPrenotazione(new Prenotazione("Giulia Bianchi", 6));
            gestore.AggiungiPrenotazione(new Prenotazione("Luca Verdi", 2));
            gestore.AggiungiPrenotazione(new Prenotazione("Anna Neri", 4));
            gestore.AggiungiPrenotazione(new Prenotazione("Paolo Blu", 5));

            Console.ReadKey();
        }
    }

}
