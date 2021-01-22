using HelloWorld.Services;

namespace HelloWorld.Services.impl
{
    public class BarkServiceImpl : BarkSerivce
    {
        public string Bark()
        {

            return "Injection dependencyy!";
        }
    }
}