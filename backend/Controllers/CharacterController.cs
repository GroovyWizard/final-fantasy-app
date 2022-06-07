using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
    public CharacterController()
    { }

    [HttpGet]
    public IEnumerable<CharacterModel> GetAll() =>
        CharacterModelService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<CharacterModel> Get(int id)
    {
        var character = CharacterModelService.Get(id);

        if (character == null)
            return NotFound();

        return character;
    }

    [HttpPost]
    public IActionResult Create(CharacterModel character)
    {
        CharacterModelService.Add(character);
        return CreatedAtAction(nameof(Create), new { id = character.Id }, character);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var character = CharacterModelService.Get(id);
    
        if (character is null)
            return NotFound();
        
        CharacterModelService.Delete(id);
    
        return NoContent();
    }

    [HttpPut("{id}/{name}")]
    public IActionResult Update(int id, string name )
    {
        if (name is null)
            return BadRequest();
        Console.WriteLine(name);
            
        var existingCharacter = CharacterModelService.Get(id);
        if(existingCharacter is null)
            return NotFound();
        Console.WriteLine(name);
        CharacterModelService.Update(existingCharacter, name);           
    
        return NoContent();
}




}