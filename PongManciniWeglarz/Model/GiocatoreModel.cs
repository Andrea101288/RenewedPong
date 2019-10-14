using System;

namespace PongManciniWeglarz.Model
{
    class GiocatoreModel
    {
        // Dichiarazione attributi privati della classe
        private string nome;
        private long punteggio;

        /* Costruttore */
        public GiocatoreModel(string nome, long punteggio)
        {
            this.nome = nome;
            this.Punteggio = punteggio;
        }

        // Cambia il nome del giocatore
        public GiocatoreModel CambiaNome(string nome)
        {
            this.nome = nome;
            return this;
        }

        // Proprietà che ritorna il nome del giocatore
        public string GetNome { get => nome; }

        // Proprietà che legge/imposta il punteggio del gioco
        public long Punteggio { get => punteggio; set => punteggio = value; }
    }
}
