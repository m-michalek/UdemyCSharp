using System;

namespace Delegates
{
    // Is part of thr framework
    public class Photo
    {
        public static Photo Load(string path)
        {
            Console.WriteLine($"Loading photo from: {path}");
            
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine($"Saving photo...");
        }
    }
}