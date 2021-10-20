using System;
using System.Drawing;
using TwitterUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    
    /// </remarks>
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            twitter.PublishToTwitter("El bicho",@"C:\Users\facun\programacion\PII_Pipes_Filters_Start_FacundoP\src\Program\Elbicho.jpg");
            return image;
        }
    }
}