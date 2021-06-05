using SGCondo.Domain.Base;

namespace SGCondo.Domain
{
    public class User : BaseDomain
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
