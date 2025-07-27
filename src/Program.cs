using Conesoft.Hosting;
using Conesoft.Notifications;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenMeteo;
using Features = Conesoft.Services.PollSources.Features;

var builder = Host.CreateApplicationBuilder(args);

builder
    .AddHostConfigurationFiles()
    .AddHostEnvironmentInfo()
    .AddLoggingService()
    .AddNotificationService()
    ;

builder.Services
    .AddHttpClient()
    //.AddHostedService<Features.Calendars.Services.PeriodicPoll>()
    //.AddHostedService<Features.FeedSources.Services.PeriodicPoll>()
    //.AddHostedService<Features.IMDbShows.Services.PeriodicPoll>()
    .AddSingleton<OpenMeteoClient>()
    .AddHostedService<Features.Weather.Services.PeriodicPoll>()
    ;

var host = builder.Build();
host.Run();