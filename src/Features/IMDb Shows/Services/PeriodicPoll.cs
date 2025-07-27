using Conesoft.Hosting;
using System;
using System.Threading.Tasks;

namespace Conesoft.Services.PollSources.Features.IMDbShows.Services;

class PeriodicPoll() : PeriodicCache<PeriodicPoll.Data>(TimeSpan.FromMinutes(5))
{
    protected override Task<Data> Generate()
    {
        throw new NotImplementedException();
    }

    public record Data();
}