using HelloWorld.Services;

namespace HelloWorld.Facade
{
    public class BarkFacade
    {

        private readonly BarkSerivce _barkService;

        public BarkFacade(BarkSerivce barkService)
        {

            _barkService = barkService;
        }

        public string BarkDog()
        {
           return _barkService.Bark();
        }
        
    }
}