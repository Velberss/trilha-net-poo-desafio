namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string model, string imei, string memoria) : base(numero, model, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp+" no Nokia!");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}