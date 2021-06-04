namespace SGCondo.Framework.Filter
{
    public abstract class IPaginated
    {
        public int Page { get; set; } = 1;

        public int Results { get; set; } = 15;

        public bool SkipPagination { get; set; } = false;

        public int Offset
        {
            get
            {
                if (Results <= 0 || Page <= 0)
                    return 0;

                return Page * Results;
            }
        }
    }
}
