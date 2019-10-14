using System;
using System.Collections.Generic;
using System.IO;

namespace PongManciniWeglarz.Model
{
    class PunteggioModel
    {
        // Dichiarazione attributi privati della classe
        private List<GiocatoreModel> highscore;           // Lista di giocatori nella classifica
        private FileStream fs;
        private StreamWriter sw;
        private StreamReader sr;
        private string file;                             // File su cui leggere/scrivere l'highscore

        /* Costruttore */
        public PunteggioModel()
        {
            highscore = new List<GiocatoreModel>();
            file = Directory.GetCurrentDirectory() + "\\highscore.txt";

            // Controlla se il file esiste
            if (!File.Exists(this.file))
            {
                for (int k = 0; k < 10; k++)
                {
                    this.highscore.Add(new GiocatoreModel("AAA", 0));
                }
                
                try
                {
                    // Se manca, viene creato
                    fs = File.Open(this.file, FileMode.CreateNew, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    // ed è riempito con i valori di default
                    for (int k = 0; k < 10; k++)
                    {
                        sw.WriteLine("AAA 0");
                    }
                }
                catch { }
                finally
                {
                    sw.Close();
                    fs.Close();
                }
            }
            else
            {
                string line;
                try
                {
                    // Se il file esiste viene letto
                    fs = File.Open(file, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    // A ogni riga vengono caricati i dati in una matrice di stringhe [nome, punteggio]
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] s = line.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        this.highscore.Add(new GiocatoreModel(s[0], Int64.Parse(s[1])));
                    }
                }
                catch { }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }
        }

        // * Metodo che ritorna la posizione in classifica del giocatore
        public GiocatoreModel TrovaGiocatore(int posizione)
        {
            GiocatoreModel giocatore;
            
            if (posizione <= 9)
                giocatore = this.highscore[posizione];
            else
                giocatore = null;
            
            return giocatore;
           
        }

        // * Inserisce il giocatore nella classifica
        public void InserisciGiocatore(int posizione, GiocatoreModel giocatore)
        {
            // Controlla se la lunghezza del nome è diversa da zero
            if (giocatore.GetNome.Length != 0)
            {
                // Viene passata la posizione
                int j = posizione;
                try
                {
                    sw = new StreamWriter(file);
                    // Viene aggiornata la matrice
                    for (int i = 9; i > j; i--)
                    {
                        highscore[i] = highscore[i - 1];
                    }
                    highscore[j] = giocatore;

                    // Vengono riportate le posizioni aggiornate nel file
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine(highscore[i].GetNome + " " + highscore[i].Punteggio);
                    }
                }
                catch { }
                finally
                {
                    // Viene chiuso il file
                    sw.Close();
                }
            }
        }
    }
}
