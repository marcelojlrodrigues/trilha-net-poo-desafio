﻿using DesafioPOO.Models;

using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seu código de inicialização ou chamadas de classes aqui

            Console.WriteLine("Programa iniciado!");

            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone(numero: "456789", modelo: "Modelo 2", imei: "22222222222", memoria: 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("Telegram");

        }
    }
}
