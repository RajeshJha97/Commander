using Commander.Models;
using MediatR;

namespace Commander.MediaterQueries
{
    public class GetPlatformQueries:IRequest<IQueryable<Platform>>
    {
    }
}
