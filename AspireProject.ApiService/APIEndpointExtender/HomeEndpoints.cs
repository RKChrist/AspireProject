namespace AspireProject.ApiService.APIEndpointExtender
{
    public static class HomeEndpoints
    {

        public static void AddHomeEndpoints(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
