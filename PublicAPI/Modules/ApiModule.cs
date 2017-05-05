using Nancy;

namespace PublicAPI.Modules
{
    public sealed class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get("/ping", args => new Response {StatusCode = HttpStatusCode.OK});
            Get("/healthcheck", args => new Response { StatusCode = HttpStatusCode.OK });
            Get("/test", args => "hello world!");
            Get("/test2", args => "hello world 2!");
        }
    }
}
