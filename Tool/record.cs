using System.Collections.Generic;

namespace treelvy
{
    class record
    {
        public static string Voice(int enable)
        {
            if(enable==0)
            {
                RecordController.StartRecord(@".\temp\recordvoice.wav");
                return "";
            }
            else
            {
                RecordController.StopRecord();
                string source = voice.AsrData();
                string[] temp = source.Split(']');
                List<string> list = new List<string>();
                foreach (string str in temp)
                {
                    if (str.Contains("["))
                    {
                        int index = str.IndexOf('[');
                        list.Add(str.Substring(index + 1, str.Length - index - 1));
                    }
                }
                temp = list[0].Split('。');
                list = new List<string>();
                foreach (string str in temp)
                {
                    if (str.Contains("\""))
                    {
                        int index = str.IndexOf('"');
                        list.Add(str.Substring(index + 1, str.Length - index - 1));
                    }
                }
                return list[0];
            }
        }
    }
}
