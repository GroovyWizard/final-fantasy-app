using backend.Models;
using System.Linq;
using backend.Models;

namespace backend.Services;
public static class CharacterModelService
{
    static List<CharacterModel> CharacterModels { get; }
    static int nextId = 3;
    static CharacterContext db = new CharacterContext();


    static CharacterModelService()
    {
        CharacterModels = new List<CharacterModel>
        {
            new CharacterModel { Id = 1,
                Name = "Sephiroth",
                Game = "Final Fantasy VII",
                ImgUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.mariowiki.com%2Fimages%2Fthumb%2Fd%2Fd6%2FSSBU_Sephiroth.png%2F1200px-SSBU_Sephiroth.png&f=1&nofb=1"
                },
            new CharacterModel { Id = 2, 
                Name = "Cloud", 
                Game = "FFVII",
                ImgUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvignette.wikia.nocookie.net%2Ffinalfantasy%2Fimages%2F6%2F69%2FSSBU_Cloud_Strife_render_002.png%2Frevision%2Flatest%2Fscale-to-width-down%2F2000%3Fcb%3D20180918182717&f=1&nofb=1"
                },
            new CharacterModel { Id = 3, 
                Name = "Garland", 
                Game = "FF",
                ImgUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvignette.wikia.nocookie.net%2Ffinalfantasy%2Fimages%2F0%2F0e%2FDFF2015_Garland_Render.png%2Frevision%2Flatest%3Fcb%3D20160811183610&f=1&nofb=1"  
                },
        };
    }
    

    public static IEnumerable<CharacterModel> GetAll() => db.Characters.OrderBy(C => C.Id);

    public static CharacterModel? Get(int id) => db.Characters.FirstOrDefault(p => p.Id == id);

    public static void Add(CharacterModel CharacterModel)
    {
        db.Add(CharacterModel);
        db.SaveChanges();
    }

    public static void Delete(int id)
    {
        var CharacterModel = db.Characters.Find(id);
        if (CharacterModel is null)
            return;

        db.Remove(CharacterModel);
    }

    // public static void Update(CharacterModel CharacterModel)
    // {
    //     var index = CharacterModels.FindIndex(c => c.Id == CharacterModel.Id);
    //     if (index == -1)
    //         return;

    //     CharacterModels[index] = CharacterModel;
    // }
}