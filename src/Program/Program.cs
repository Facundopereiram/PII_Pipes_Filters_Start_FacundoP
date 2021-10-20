using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {   
            //De aca saco la imagen a la cual le aplico los filtros//
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"C:\Users\facun\programacion\PII_Pipes_Filters_Start_FacundoP\src\Program\Elbicho.jpg");
            
            IPipe pipenull = new PipeNull();
            IFilter filtronegativo= new FilterNegative();
            IPipe  pipeserial2 = new PipeSerial(filtronegativo,pipenull);
            IFilter filtrotwitter= new FilterTwitter();
            IPipe pipeserial4 = new PipeSerial(filtrotwitter,pipeserial2);
            IFilter filtroguardar = new FilterSave();
            IPipe pipeserial3=new PipeSerial(filtroguardar,pipeserial4);
            IFilter filtrodegrises= new FilterGreyscale();
            IPipe pipeserial1=new PipeSerial(filtrodegrises,pipeserial3);
            
            picture=pipeserial1.Send(picture);

        }
    }
}
  