﻿using System;
using System.Threading.Tasks;
using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("=== Chat Producer ===");

        while (true)
        {
            Console.Write("You: ");
            string message = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(message))
                break;

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
        }
    }
}
