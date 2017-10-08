namespace Fake.Core.Extensions
{
    public interface IRequest
    {
        string GetPropertyValueBy(string path);
        string GetPropertyValueBy(int index);
    }
}
