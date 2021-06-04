using SGCondo.Framework.Model;

namespace SGCondo.Framework.Service
{
    public interface IErrorNotification
    {
        void Add(ErrorDetails error);

        void Add(string resourceId, string domain);

        bool Has();

        Error Get();
    }
}
