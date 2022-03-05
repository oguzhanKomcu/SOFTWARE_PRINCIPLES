using SOLID_Principles._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.DIP.GoodExample.Concrete
{
    public class Video : IFormat
    {
        public string FilePlay()
        {
            return "Video file is playing.";
        }
    }
}
