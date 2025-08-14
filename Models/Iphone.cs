namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei) : base(numero, modelo, imei)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no iPhone.");
        }
        public override string ToString()
        {
            return $"iPhone - Modelo: {GetModelo()}, IMEI: {GetIMEI()}, Memória: {GetMemoria()}, Número: {Numero}";
        }
    }
}