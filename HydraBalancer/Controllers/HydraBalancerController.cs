using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Balancer;

namespace HydraBalancer.Controllers
{
    class HydraBalancerController : SrvBalancer.SrvBalancerBase
    {
        MainCore _ = new MainCore();

        public override Task<ChooseO> Choose(ChooseI request, ServerCallContext context)
        {
            var _out = _.Choose(request.ServiceName, request.Metodo);
            return Task.FromResult(new ChooseO { 
             Id = _out.Id,
             Ip = _out.Ip,
             Port = _out.Port,
             Name = _out.Name,
             Status = _out.Status
            });
        }

    }
}
