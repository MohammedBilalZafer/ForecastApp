using System;

public class Class1
{
	public ConfigureServices()
	{
        // Register Forecast repository
        services.AddScoped<IForecastRepository, ForecastRepository>();
    }
}
