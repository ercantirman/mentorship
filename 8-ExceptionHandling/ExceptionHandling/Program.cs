
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("ercan");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
