namespace DesafioPOO.Models
{
    // Inheriting from the "Smartphone" class
    public class Iphone : Smartphone
    {
        // Constructor for the Iphone class
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Additional initialization for the Iphone class if needed
        }

        // Overriding the abstract method from the base class
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
            // Additional implementation for installing the application on iPhone
        }
    }
}
