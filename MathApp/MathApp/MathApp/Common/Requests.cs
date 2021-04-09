using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp.Common
{
    public static class Requests
    {
        // Uncomment this for emulator testing
        public const string BASE_URL = "http://10.0.2.2:5000/";
        //public const string BASE_URL = "http://192.168.43.19:5000/";

        public const string Test = BASE_URL + "weatherforecast";
    }
}
