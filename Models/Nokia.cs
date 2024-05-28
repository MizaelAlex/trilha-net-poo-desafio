namespace DesafioPOO.Models
{
    // Classe Nokia que herda da classe base Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia, utilizando o construtor da classe base
         public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }
        // Implementação do método abstrato para instalar um aplicativo no Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando WhatsApp");
        }
    }
}