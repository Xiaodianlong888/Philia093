using Terraria.ModLoader;

namespace Amphoreus
{
    public class Amphoreus : Mod
    {
        public static Amphoreus Instance { get; private set; }

        public override void Load()
        {
            Instance = this;

            // 如果准备了音乐文件，取消下面这行的注释
            // MusicLoader.AddMusic(this, "Assets/Sounds/Music/BlackDomainTheme");
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}