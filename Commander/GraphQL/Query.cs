using Commander.Data;
using Commander.MediaterQueries;
using Commander.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Commander.GraphQL
{
    public class Query
    {
        public async Task<IQueryable<Platform>> GetPlatforms([Service]ILogger<Query> _logger,[Service] ISender _sender)
        {
            try
            {
                var platforms = await _sender.Send(new GetPlatformQueries());
                if (platforms is not null)
                {
                    return platforms;
                }
                return Enumerable.Empty<Platform>().AsQueryable();
            }
            catch (Exception ex) 
            {
                _logger.LogError("Exception", ex.Message);
                return Enumerable.Empty<Platform>().AsQueryable();
            }
            

            //return context.Platforms.Where(p=>p.Id==1);
        }
    }
}
