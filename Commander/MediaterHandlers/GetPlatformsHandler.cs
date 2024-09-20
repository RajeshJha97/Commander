using Commander.Data;
using Commander.MediaterQueries;
using Commander.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Commander.MediaterHandlers
{
    public class GetPlatformsHandler (AppDbContext _db,ILogger<GetPlatformsHandler>_logger): IRequestHandler<GetPlatformQueries, IQueryable<Platform>>
    {       
        public async Task<IQueryable<Platform>> Handle(GetPlatformQueries request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("GetPlatformsHandler command executed Successfully");
            return   _db.Platforms.AsQueryable();
        }
    }
}
