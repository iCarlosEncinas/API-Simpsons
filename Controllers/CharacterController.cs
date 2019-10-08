using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web_api_simpsons.Modules;
using web_api_simpsons.Dependencies;
using Microsoft.AspNetCore.Cors;

namespace web_api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CharacterController : ICharacter
    {
        List<Character> listOfCharacters => new List<Character>
        {
            new Character
            {
                FirstName = "Homero",
                SecondName = "Jay",
                LastName = "Simpsons",
                Age = 34
            },
            new Character
            {
                FirstName = "Bartolomeo",
                SecondName = " ",
                LastName = "Simpsons",
                Age = 10
            }
        };
        
        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacters[id];
        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            return listOfCharacters;
        }
    }
}