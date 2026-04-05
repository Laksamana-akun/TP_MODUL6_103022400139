using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL6_103022400139
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaMusicTrack track = new SayaMusicTrack("Lagu Favorit");

                track.IncreasePlayCount(5000000);

                for (int i = 0; i < 100; i++)
                {
                    track.IncreasePlayCount(10000000);
                }

                track.PrintTrackDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }
        }
    }
}
