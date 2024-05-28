namespace DesafioPOO.Models
{
    // Classe abstrata representando um smartphone
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }

        // Construtor para inicializar as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        // Método para simular a ação de ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }


        // Método para simular a ação de receber uma ligação no smartphone
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }


        // Método abstrato para instalar um aplicativo, a ser implementado pelas subclasses
        public abstract void InstalarAplicativo(string nomeApp);
    }
}