using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electronicShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]  snm= Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(snm[0]);
            int n = Convert.ToInt32(snm[1]);
            int m = Convert.ToInt32(snm[2]);
            string[] key = Console.ReadLine().Split(' ');
            int[] keyP = Array.ConvertAll(key, Int32.Parse);
            string[] usb = Console.ReadLine().Split(' ');
            int[] usbP = Array.ConvertAll(usb, Int32.Parse);
            int sumP = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((keyP[i]+usbP[j])<=s && (keyP[i] + usbP[j])>sumP) { sumP = Math.Max(sumP,keyP[i] + usbP[j]); }
                }
            }
            if (sumP < 1)
                Console.WriteLine("-1");
            else
                Console.WriteLine(sumP);
            Console.ReadKey();
        }
    }
}