namespace ConsoleApp1
{
    class Atleta
    {
        string nome;
        string cognome;
        int eta;
        string sport;

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { this.cognome = value; }
        }
        public int Eta
        {
            get { return eta; }
            set { this.eta = value; }
        }
        public string Sport
        {
            get { return sport; }
            set { this.sport = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("L'atleta si chiama " + nome + " " + cognome + " ha " + eta + " anni e pratica " + sport);
        }
       
    }
    class Dipendente
    {
        string nome;
        string cognome;
        int eta;
        string lavoro;

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { this.cognome = value; }
        }
        public int Eta
        {
            get { return eta; }
            set { this.eta = value; }
        }
        public string Lavoro
        {
            get { return lavoro; }
            set { this.lavoro = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("Il dipendente si chiama " + nome + " " + cognome + " ha " + eta + " anni e fa il " + lavoro);
        }
    }
    class Animale
    {
        string nome;
        string colore;
        string razza;

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public string Colore
        {
            get { return colore; }
            set { this.colore = value; }
        }
        public string Razza
        {
            get { return razza; }
            set { this.razza = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("L'animale si chiama " + nome + " è di colore " + colore + " e di razza " + razza);
        }

    }
    class Veicolo
    {
        string marca;
        string modello;
        string colore;

        public string Marca
        {
            get { return marca; }
            set { this.marca = value; }
        }
        public string Modello
        {
            get { return modello; }
            set { this.modello = value; }
        }
        public string Colore
        {
            get { return colore; }
            set { this.colore = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("Il veicolo è della marca " + marca + " del modello " + modello + " ed è di colore " + colore);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta();
            atleta1.Nome = "Mario";
            atleta1.Cognome = "Rossi";
            atleta1.Eta = 30;
            atleta1.Sport = "calcio";
           atleta1.Descriviti();

            Dipendente dipendente = new Dipendente();
            dipendente.Nome = "Luca";
            dipendente.Cognome = "Bianchi";
            dipendente.Eta = 40;
            dipendente.Lavoro = "programmatore";    
            dipendente.Descriviti();

            Animale animale = new Animale();
            animale.Nome = "Fido";
            animale.Colore = "nero";
            animale.Razza = "labrador";
            animale.Descriviti();

            Veicolo veicolo = new Veicolo();
            veicolo.Marca = "Fiat";
            veicolo.Modello = "Panda";
            veicolo.Colore = "rosso";   
            veicolo.Descriviti();

        }
    }
}
