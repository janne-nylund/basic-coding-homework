using System;

namespace Exercise
{


    public class TemperatureSensor : Sensor
    {
        private Random rnd;
        private Boolean onOff;
        public TemperatureSensor()
        {
            this.rnd = new Random();
            this.onOff = false;
        }
        public bool IsOn()
        {
            return this.onOff;
        }


        public void SetOn()
        {
          this.onOff = true;
        }


        public void SetOff()
        {
          this.onOff = false;
        }


        public int Read()
        {
          if (IsOn())
          {
            int temp = this.rnd.Next(-30, 30);
            return temp;
          }
          throw new InvalidOperationException("Sensor not on!");
        }
    }
}