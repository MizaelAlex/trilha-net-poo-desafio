namespace DesafioPOO.Models
{
    // Classe Iphone que herda da classe base Smartphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone, utilizando o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }
        // Implementação do método abstrato para instalar um aplicativo no Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Instagram");
        }
    }
}