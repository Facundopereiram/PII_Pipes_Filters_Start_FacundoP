using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>

    /// </remarks>
    public class FilterSave : IFilter
    {
        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        public IPicture Filter(IPicture image)
        {
            PictureProvider p = new PictureProvider();
             p.SavePicture(image,@"C:\Users\facun\programacion\PII_Pipes_Filters_Start_FacundoP\src\Program\Elbicho.jpg");

            return image;
        }
    
    }
}