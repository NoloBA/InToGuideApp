namespace InToGuideWebAPI.Data
{
    public class DbInitializer
    {

        private readonly InToGuideContext _context;

        public DbInitializer(InToGuideContext context)
        {
            _context = context;
        }
    }
}
