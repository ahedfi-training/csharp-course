using System;

namespace PhotoManager
{
    public class PhotoProcessor
    {
       // public delegate void PhotoFilterHandler(Photo photo); // 3.5

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
       
        // New Method
        //public void Process(string path, PhotoFilterHandler filterHandler)
        //{
        //    Action<,>;
        //    Func<int,,int>;

        //    var photo = Photo.Load(path);
        //    filterHandler(photo);
        //    photo.Save();
        //}

        // old Method
        //public void Process(string path)
        //{
        //    var photo = Photo.Load(path);
        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.Resize(photo);
        //    filters.ApplyContrast(photo);
        //    photo.Save();
        //}
    }
}
