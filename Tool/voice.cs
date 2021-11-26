using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace treelvy
{
    class voice
    {
        public static string AsrData()
        {
            var data = File.ReadAllBytes(@".\temp\recordvoice.wav");
            var APP_ID = "20076471";
            var API_KEY = "y0PPw9QqGXNkgvSqGyp1CVUd";
            var SECRET_KEY = "GTg6Gf1sbbPkkoy3QnusZGTHg6HyO7wU";

            var client = new Baidu.Aip.Speech.Asr(APP_ID, API_KEY, SECRET_KEY);
            // 可选参数
            var options = new Dictionary<string, object>
             {
                {"dev_pid", 1537}
             };
            client.Timeout = 120000;
            var result = client.Recognize(data, "wav", 16000, options);
            return result.ToString();
        }
    }
}
