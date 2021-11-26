using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace treelvy
{
	class RecordController
    {
		public static WaveIn mWavIn;
		public static WaveFileWriter mWavWriter;

		public static void StartRecord(string filePath)
		{ 
			mWavIn = new WaveIn();
			mWavIn.WaveFormat = new WaveFormat(16000, 16, 1);
			mWavIn.DataAvailable += MWavIn_DataAvailable;
			mWavWriter = new WaveFileWriter(filePath, mWavIn.WaveFormat);
			mWavIn.StartRecording();
		}

		public static void StopRecord()
		{
			mWavIn?.StopRecording();
			mWavIn?.Dispose();
			mWavIn = null;
			mWavWriter?.Close();
			mWavWriter = null;
		}

		private static void MWavIn_DataAvailable(object sender, WaveInEventArgs e)
		{
			mWavWriter.Write(e.Buffer, 0, e.BytesRecorded);
			int secondsRecorded = (int)mWavWriter.Length / mWavWriter.WaveFormat.AverageBytesPerSecond;
		}
	}
}
