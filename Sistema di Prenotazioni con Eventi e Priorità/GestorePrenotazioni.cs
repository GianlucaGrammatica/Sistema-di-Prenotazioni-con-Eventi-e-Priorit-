using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_di_Prenotazioni_con_Eventi_e_Priorità
{
    /*
        Descrizione: Implementa un sistema di gestione delle prenotazioni di un hotel che utilizza eventi per notificare i vari reparti dell'arrivo di un cliente, in base alla priorità della prenotazione.
        Istruzioni:Definisci un delegato PrenotazioneGestitaHandler che accetti il nome del cliente e il livello di priorità (int).Crea una classe Prenotazione con:
        Proprietà NomeCliente (string) e Priorita (int, dove valori più bassi indicano maggiore priorità).
        Crea una classe GestorePrenotazioni che:
        Contenga un evento PrenotazioneGestita.
        Un metodo AggiungiPrenotazione(Prenotazione p) che solleva l'evento.
        Mantenga un elenco ordinato delle prenotazioni in base alla priorità (usa SortedList o List con Sort).
        Crea due classi, Reception e ServizioCamere, che si sottoscrivono all'evento:
        Reception stampa un messaggio di benvenuto.
        ServizioCamere prepara la camera.
        Nel metodo Main:
        Aggiungi almeno 5 prenotazioni con priorità diverse.
        Visualizza i messaggi in ordine di priorità grazie agli eventi.
        Output Esempio:
        Nuova prenotazione per Marco Rossi con priorità 1.
        [Reception] Benvenuto Marco Rossi!
        [Servizio Camere] Camera pronta per Marco Rossi.

        Nuova prenotazione per Giulia Bianchi con priorità 3.
        [Reception] Benvenuta Giulia Bianchi!
        [Servizio Camere] Camera pronta per Giulia Bianchi.

        Nuova prenotazione per Luca Verdi con priorità 2.
        [Reception] Benvenuto Luca Verdi!
        [Servizio Camere] Camera pronta per Luca Verdi.
    */
    public delegate void PrenotazioneGestitaHandler(string nomeCliente, int priorità);

    internal class GestorePrenotazioni
    {
        public SortedList<int, Prenotazione> PrenotazioniList = new SortedList<int, Prenotazione>();

        public event PrenotazioneGestitaHandler PrenotazioneGestita;

        public GestorePrenotazioni()
        {

        }
        public void AggiungiPrenotazione(Prenotazione p)
        {
            if (p.NomeCliente.Length > 0 && p.Priorità >= 0)
            {
                PrenotazioniList.Add(p.Priorità, p);
                Console.WriteLine($"\nNuova prenotazione per {p.NomeCliente} con priorità {p.Priorità}.");
            }
            PrenotazioneGestita?.Invoke(p.NomeCliente, p.Priorità);
        }

        public void AggiungiPrenotazione(string nomeCliente, int priorità)
        {
            if (nomeCliente.Length > 0 && priorità >= 0)
            {
                PrenotazioniList.Add(priorità, new Prenotazione(nomeCliente, priorità));
            }
            PrenotazioneGestita?.Invoke(nomeCliente, priorità);
        }
    }
}
