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
            SayaMusicTrack track = new SayaMusicTrack("Lagu Favorit");

            track.IncreasePlayCount(10);
            track.PrintTrackDetails();
        }
    }
}
