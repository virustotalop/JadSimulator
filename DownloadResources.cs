using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace JadSimulator
{
    class DownloadResources
    {
        private static string resourceFolder = "resources";

        public static string prayerBookLocalLocation = resourceFolder + "\\prayerbook.png";
        private static string prayerBookWebLocation = "http://vignette4.wikia.nocookie.net/2007scape/images/3/30/Prayer_tab.png/revision/latest";
        private static Boolean prayerBookIsDownloaded = false;

        public static string rangePrayerLocalLocation = resourceFolder + "\\rangeprayer.png";
        private static string rangePrayerWebLocation = "http://vignette2.wikia.nocookie.net/2007scape/images/5/59/Protect_from_missiles.png/revision/latest";
        private static Boolean rangePrayerIsDownloaded = false;

        public static string magePrayerLocalLocation = resourceFolder + "\\mageprayer.png";
        private static string magePrayerWebLocation = "http://vignette2.wikia.nocookie.net/2007scape/images/b/b1/Protect_from_magic.png/revision/latest";
        private static Boolean magePrayerIsDownloaded = false;

        public static void DownloadAll()
        {
            if(!Directory.Exists(resourceFolder))
            {
                Directory.CreateDirectory(resourceFolder);
            }

            DownloadPrayerBook();
            DownloadRangePrayer();
            DownloadMagePrayer();
        }

        private static void DownloadPrayerBook()
        {
            if(!File.Exists(prayerBookLocalLocation))
            {
                Thread PrayerBookThread = new Thread(StartPrayerBookDownload);
                PrayerBookThread.Start();
            }
            else
            {
                prayerBookIsDownloaded = true;
            }
            
            //if file is downloaded
            //Set PrayerBookIsDownloaded to true
        }

        private static void StartPrayerBookDownload()
        {
            WebClient webClient = new WebClient();
            try
            {
                Console.WriteLine("Starting prayer book image download.");
                webClient.DownloadFile(prayerBookWebLocation, prayerBookLocalLocation);
                prayerBookIsDownloaded = true;
            }
            catch(WebException e)
            {
                throw e;
            }
        }

        private static void DownloadRangePrayer()
        {
            if (!File.Exists(rangePrayerLocalLocation))
            {
                Thread rangePrayerThread = new Thread(StartRangePrayerDownload);
                rangePrayerThread.Start();
            }
            else
            {
                rangePrayerIsDownloaded = true;
            }
        }

        private static void StartRangePrayerDownload()
        {
            WebClient webClient = new WebClient();
            try
            {
                Console.WriteLine("Starting range prayer image download.");
                webClient.DownloadFile(rangePrayerWebLocation, rangePrayerLocalLocation);
                rangePrayerIsDownloaded = true;
            }
            catch (WebException e)
            {
                throw e;
            }
        }

        private static void DownloadMagePrayer()
        {
            if (!File.Exists(magePrayerLocalLocation))
            {
                Thread magePrayerThread = new Thread(StartMagePrayerDownload);
                magePrayerThread.Start();
            }
            else
            {
                magePrayerIsDownloaded = true;
            }
        }

        private static void StartMagePrayerDownload()
        {
            WebClient webClient = new WebClient();
            try
            {
                Console.WriteLine("Starting mage prayer image download.");
                webClient.DownloadFile(magePrayerWebLocation, magePrayerLocalLocation);
                magePrayerIsDownloaded = true;
            }
            catch (WebException e)
            {
                throw e;
            }
        }

        public static Boolean AllDownloaded()
        {
            return prayerBookIsDownloaded && rangePrayerIsDownloaded && magePrayerIsDownloaded;
        }
    }
}
