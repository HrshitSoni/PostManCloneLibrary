
namespace PostManCloneLibrary
{
    public interface IApiAccess
    {
        bool validateUrl(string url);

        Task<string> CallApi(string url, httpMethods method, string? jsonBody);
    }
}