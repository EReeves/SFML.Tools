using System.Collections.Generic;
using SFML.Graphics;

namespace SFML.Tools
{
    /// <summary>
    /// Simple class for storing textures.
    /// </summary>
    class TextureVault
    {
        private static readonly Dictionary<string, Texture> textures = new Dictionary<string, Texture>();

        public TextureVault()
        {

        }

        /// <summary>
        /// Add a texture to the vault.
        /// </summary>
        /// <param name="key">"redblock"</param>
        /// <param name="path">"C:/Sprites/RedBlock.png"</param>
        public static void AddTexture(string key, string path)
        {
            LoadTexture(key, path);
        }

        /// <summary>
        /// Be careful with this, don't unload a texture that is in use.
        /// </summary>
        /// <param name="key">"TextureName.png"</param>
        public static void UnloadTexture(string key)
        {
            textures.Remove(key.ToUpper());
        }

        /// <summary>
        /// Gets a texture from vault, if Texture is not found it will attempt to load it. 
        /// </summary>
        /// <param name="key">"redblock"</param>
        /// <param name="path">C:/Sprites/RedBlock.png</param>
        /// <returns>Texture</returns>
        public static Texture GetTexture(string key, string path)
        {
            return LoadTexture(key, path);
        }

        private static Texture LoadTexture(string key, string path)
        {
            string k = path.ToUpper();
            if (!textures.ContainsKey(k))
                textures.Add(k, new Texture(path));
            return textures[k];
        }

    }
}