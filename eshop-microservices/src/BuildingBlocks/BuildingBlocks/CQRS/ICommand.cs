using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    // CQRS Pattern for Command : Si la arquitectura Clean tiene su SOLID principles, 
    // La arquitectura vertical tiene su CQRS Pattern a partir de Building Blocks
    public interface ICommand : ICommand<Unit>
    {

    }
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
