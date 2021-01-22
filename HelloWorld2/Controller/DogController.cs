using System;
using HelloWorld.Facade;
using HelloWorld.Model;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controller
{   
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {

        private readonly BarkFacade _barkFacade;

        public DogController(BarkFacade barkFacade)
        {
            _barkFacade = barkFacade;
        }

        [HttpGet("Bark"), ActionName("Bark")]
        public string DogBark()
        {
            
            return _barkFacade.BarkDog();
        }

    }   
}