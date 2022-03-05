using SOLID_Principles._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.DIP.GoodExample.Concrete
{
    public class Music : IFormat
    {
        public string FilePlay()
        {
            return "Music file is playing.";
        }
    }
}
