﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoLibraryUWP.Model
{
    public class PhotoManager
    {
        public static void GetAllPhotos(ObservableCollection<Photo> photos)
        {
            var allPhotos = getPhotos();
            photos.Clear();
            allPhotos.ForEach(photo => photos.Add(photo));
        }

        public static void getPhotosByCategory(ObservableCollection<Photo> photos, PhotoCategory category)
        {
            var allPhotos = getPhotos();
            var filteredPhotos = allPhotos.Where(p => p.Category == category).ToList();
            photos.Clear();
            filteredPhotos.ForEach(photo => photos.Add(photo));
        }

        private static List<Photo> getPhotos()
        {
            var photos = new List<Photo>();
            photos.Add(new Photo("bear_cubs", PhotoCategory.Animals));
            photos.Add(new Photo("chinook", PhotoCategory.Animals));
            photos.Add(new Photo("elk", PhotoCategory.Animals));
            photos.Add(new Photo("foxes", PhotoCategory.Animals));

            photos.Add(new Photo("beach_sunset_people", PhotoCategory.Beaches));
            photos.Add(new Photo("hotel_beach", PhotoCategory.Beaches));
            photos.Add(new Photo("oregon", PhotoCategory.Beaches));
            photos.Add(new Photo("rocky_shore", PhotoCategory.Beaches));

            photos.Add(new Photo("eagle", PhotoCategory.Birds));
            photos.Add(new Photo("raven_closeup", PhotoCategory.Birds));
            photos.Add(new Photo("spotted_owl", PhotoCategory.Birds));
            
            photos.Add(new Photo("benicia", PhotoCategory.Bridges));
            photos.Add(new Photo("golden_gate", PhotoCategory.Bridges));
            photos.Add(new Photo("mystic_river", PhotoCategory.Bridges));
            photos.Add(new Photo("richmond_san_rafael", PhotoCategory.Bridges));

            photos.Add(new Photo("butterfly_blue", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_blue_red", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_fat", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_flower", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_green_white_black", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_orange", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_turquoise", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_white_black_orange", PhotoCategory.Butterflies));
            photos.Add(new Photo("butterfly_yellow_red_white", PhotoCategory.Butterflies));

            photos.Add(new Photo("city_night", PhotoCategory.Cities));
            photos.Add(new Photo("city_texas", PhotoCategory.Cities));
            photos.Add(new Photo("hongkong_night", PhotoCategory.Cities));
            photos.Add(new Photo("night_city", PhotoCategory.Cities));
            photos.Add(new Photo("portland_ore", PhotoCategory.Cities));

            photos.Add(new Photo("bear_grass", PhotoCategory.Flowers));
            photos.Add(new Photo("calif_poppies", PhotoCategory.Flowers));
            photos.Add(new Photo("flowers_veggies", PhotoCategory.Flowers));
            photos.Add(new Photo("pink", PhotoCategory.Flowers));
            photos.Add(new Photo("roses", PhotoCategory.Flowers));

            photos.Add(new Photo("gaza_kids", PhotoCategory.People));
            photos.Add(new Photo("girl_brown_eyes", PhotoCategory.People));
            photos.Add(new Photo("queen_of_pacific", PhotoCategory.People));

            photos.Add(new Photo("joshua_trees", PhotoCategory.Trees));
            photos.Add(new Photo("redwood_sunrays", PhotoCategory.Trees));
            photos.Add(new Photo("ski_slope", PhotoCategory.Trees));
            photos.Add(new Photo("sunlit_trees", PhotoCategory.Trees));
            photos.Add(new Photo("tall_trees", PhotoCategory.Trees));

            return photos;

        }
    }
}
