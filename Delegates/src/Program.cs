using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imagine PhotoProcessor and PhotoFilters are both part of a framework. Not it is not possible to define
            // which filters to apply.
            // 
            // var photoProcessor = new PhotoProcessor();
            
            // End of initial code
            
            
            // Here it is possible as the user of the framework to specify which filters to apply and even define own
            // filters and apply them.
            var photoProcessor = new PhotoProcessor();

            var filters = new PhotoFilters();
            // PhotoProcessor.PhotoFilterHandler photoFilterHandler = filters.ApplyBrightness;
            Action<Photo> photoFilterHandler = filters.ApplyBrightness;
            photoFilterHandler += filters.ApplyContrast;
            photoFilterHandler += filters.Resize;
            photoFilterHandler += RemoveRedEyeFilter;
            
            photoProcessor.Process("./Image.png", photoFilterHandler);
        }
        
        // Now the the framework can be extended without recompiling the code of the framework and redeploy it
        // The signature has to fit the signature of the delegate (PhotoFilterHandler) in PhotoProcessor
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Applying red eye filter...");
        }
    }
}