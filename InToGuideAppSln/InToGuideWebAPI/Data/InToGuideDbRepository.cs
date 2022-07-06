namespace InToGuideWebAPI.Data
{
    public class InToGuideDbRepository: IInToGuideDbRepository
    {
        private InToGuideContext _inToGuideContext;

        public InToGuideDbRepository(InToGuideContext inToGuideContext)
        {
            _inToGuideContext = inToGuideContext;
        }
    }
   
}
