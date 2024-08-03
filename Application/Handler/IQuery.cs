using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Handler
{
    public interface IQuery<TResult> : IRequest<TResult>
    {
    }

    public interface IQuery : IRequest
    {
    }
}
