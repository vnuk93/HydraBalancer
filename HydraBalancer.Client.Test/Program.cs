using System;
using HydraBalancerClient = HydraBalancer.Client.MainCore;
namespace HydraBalancer.Client.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HydraBalancer Client Test");
            HydraBalancerClient _HydraBalancer = new HydraBalancerClient("localhost", "1004");
            
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.WriteLine(_HydraBalancer.Choose(new Balancer.ChooseI { ServiceName = "HydraBingoClient", Metodo = 1 }).Id);
            Console.ReadLine();

        }
    }
}
