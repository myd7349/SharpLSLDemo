using SharpLSL;

Random rnd = new Random();

// create stream info and outlet
using StreamInfo info = new StreamInfo("TestCSharp", "EEG", 8, 100, ChannelFormat.Float, "sddsfsdf");
using StreamOutlet outlet = new StreamOutlet(info);
float[] data = new float[8];
while (!Console.KeyAvailable)
{
    // generate random data and send it
    for (int k = 0; k < data.Length; k++)
        data[k] = rnd.Next(-100, 100);
    outlet.PushSample(data);
    Thread.Sleep(10);
}