namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){                  
        } 
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado no Nokia");
        }
    }
}