using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookGallery.Models
{
    public class book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string DescriptionHtml { get; set; }
        public Awards[] Awards { get; set; }
        public bool Fav { get; set; }


        public string DisplayText
        {
            get
            {
                return Title + " by " + Author;
            }
        }


        public string CoverImage
        {
            get
            {
                return Title.Replace(" ", "-").ToLower() + "-" + Author + ".jpg";
            }

        }


    }
}