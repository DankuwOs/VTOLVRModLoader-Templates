global using static VtolModTemplate.Logger;
using System.IO;
using System.Reflection;
using ModLoader.Framework;
using ModLoader.Framework.Attributes;

namespace VtolModTemplate;

[ItemId("name.modname")] // Harmony ID for your mod, make sure this is unique
public class Main : VtolMod
{
    public string ModFolder;

    private void Awake()
    {
        ModFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Log($"Awake at {ModFolder}");
    }

    public override void UnLoad()
    {
        // Destroy any objects
    }
}