using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HydraBingoClient = HydraBingo.Client.MainCore;
using Bingo;


namespace HydraBalancer
{
    public class MainCore
    {
        public MainCore()
        {
            #region Cliente Hydra Bingo

            HeartbeatI config = new HeartbeatI
            {
                Data = new RegistryService
                {
                    Id = Guid.NewGuid().ToString(),
                    Status = 0,
                    Name = "HydraBalancer",
                    Packages = "com.hydraframework.balancer",
                    Port = 1004,
                    Version = "1.0.0-0",
                    Group = "Lobby"
                }
            };
            _HydraBingo = new HydraBingoClient("localhost", "1002", config);

            #endregion          
        }

        IDictionary<string, int> robin = new Dictionary<string, int>();
        public HydraBingoClient _HydraBingo;

        public RegistryService Choose(string serviceName, int metodo)
        {

            var servicesBingo = _HydraBingo.BalancerResume.BingoResume.ToList<RegistryService>();
            switch (metodo)
            {
                case 1:
                    var robinValue = 0;
                    RegistryService _out;
                    if(robin.ContainsKey(serviceName) == true)
                    {
                        robinValue = robin[serviceName];
                    }
                    else
                    {
                        robin.Add(serviceName, 1);
                        robinValue = 1; // no es necesario, se declara arriba
                    }

                    //Extraemos de servicesBingo el servicio que tenga el valor de robbin
                    try
                    {
                        _out = servicesBingo.FindAll(x=> x.Name == serviceName)[robinValue-1];
                    }
                    catch
                    {                       
                        try {
                            _out = servicesBingo.Find(x => x.Name == serviceName);
                        }
                        catch {
                            return null;
                        }
                    }

                    robin[serviceName]++;
                    var countService = servicesBingo.FindAll(x => x.Name == serviceName).Count;

                    if (robin[serviceName] > countService) {
                        robin[serviceName] = 1;
                        Console.WriteLine("> Robin Round " + _out.Name + "@" + _out.Id + " correct");
                        return _out;
                    }
                    else
                    {
                        Console.WriteLine("> Robin Round " + _out.Name + "@" + _out.Id + " correct");
                        return _out;
                    }
                    
                    break;
                default:
                    Console.WriteLine("Metodo no valido");
                    break;
            }
            return null;
        }
    }
}