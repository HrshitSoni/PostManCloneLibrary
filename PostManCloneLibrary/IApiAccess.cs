
namespace PostManCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApi(string url, httpMethods method = httpMethods.GET);
        bool validateUrl(string url);
    }
}