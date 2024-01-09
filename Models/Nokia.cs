namespace DesafioPOO.Models
{
    // Inheriting from the "Smartphone" class
    public class Nokia : Smartphone
    {
        // Constructor for the Nokia class
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Additional initialization for the Nokia class if needed
        }

        // Overriding the abstract method from the base class
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
            // Additional implementation for installing the application on Nokia
        }
    }
}
