using System;

namespace SensorDataLib
{
    public class SensorData
    {
        public string SensorName { get; set; }
        public int Speed { get; set; }
        public string TimeStamp { get; set; }

        public SensorData()
        {
        }

        public SensorData(string sensorName, int speed, string timeStamp)
        {
            SensorName = sensorName;
            Speed = speed;
            TimeStamp = timeStamp;
        }

        public SensorData(string sensorName, int speed)
        {
            SensorName = sensorName;
            Speed = speed;
        }

        public override string ToString()
        {
            return SensorName + " " + Speed + " " + TimeStamp;
        }
    }
}
