namespace Delegates
{
    // Is part of the framework
    public class PhotoProcessor
    {
        // If a new filter is developed it has to be added here. After that the framework has to be recompiled and 
        // deployed. User can then apply the PhotoProcessor and it is applying all the filters
        
        // public void Process(string path)
        // {
        //     var photo = Photo.Load(path);
        //
        //     var filters = new PhotoFilters();
        //     filters.ApplyBrightness(photo);
        //     filters.ApplyContrast(photo);
        //     filters.Resize(photo);
        //
        //     photo.Save();
        // }

        // End of initial code
        
        // In this approach the PhotoProcessor gets all the filters to be applied as a method parameter 

        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {
            var photo = Photo.Load(path);
            
            photoFilterHandler(photo);

            photo.Save();
        }
    }
}