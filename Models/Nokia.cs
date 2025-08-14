namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei) : base(numero, modelo, imei)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia.");

        }
        public override string ToString()
        {
            return $"Nokia - Modelo: {GetModelo()}, IMEI: {GetIMEI()}, Memória: {GetMemoria()}, Número: {Numero}";
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

    }
}