using SlugGenerator;

namespace ThucHanh01.Utilities
{
    public class Functions
    {
        public static string TitleSLugGeneration(string type, string title, long id)
        {
            string sTitle = type + "-" + SlugGenerator.SlugGenerator.GenerateSlug(title) + "-" + id.ToString() + ".html";
            return sTitle;
        }
    }
}
