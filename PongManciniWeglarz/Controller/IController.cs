namespace PongManciniWeglarz.Controller
{
    public interface IController
    {
        // Dichiarazione dei vari metodi di Interfaccia
        void Esci();
        void Pausa();
        void MovimentoGiocatore();
        void MovimentoAvversario();
        void MovimentoPallina();
        void CollisioniRacchette();
    }
}
