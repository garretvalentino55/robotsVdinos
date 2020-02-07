using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    class clockRadio
    {
        //member variales (Has A)
        public string radioTuner;
        public string clock;
        public bool hasAlarm;
        public bool alarmOn;
        public string setAlarm;
        public int clockFace;    
        public int time;
        public string alarmgoesoff;

        //constructor (spawner)
        public clockRadio(string radioTuner, string clock, string GetUpTime)
        {
            this.radioTuner = radioTuner;
            hasAlarm = true;
            this.clock = clock;
            alarmOn = true;
            clockFace = time;
            GetUpTime = setAlarm;
         
        }

        //member methods(can do)
        public void IsOn() 
        {
            alarmOn = true;
        }
        public void DisplayTime() 
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            Console.WriteLine(hour + ":" + minute);


        }
        public string RadioStation(string Power92) 
        {
           
            return radioTuner = Power92;
        }
        public string SetAlarm() 
        {
            string setAlarm = alarmgoesoff;
            string wakeUp = setAlarm;
            alarmgoesoff = Console.ReadLine();
            return null;

        }

        public void UpdateTime()
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            Console.WriteLine(hour + ":" + minute);
        }
    }
}
