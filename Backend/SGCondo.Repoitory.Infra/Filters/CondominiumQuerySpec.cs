using SGCondo.Framework.Filter;

namespace SGCondo.Repository.Infra.Filters
{
    public class CondominiumQuerySpec : IPaginated
    {
        public string Name { get; set; }
    }
}
