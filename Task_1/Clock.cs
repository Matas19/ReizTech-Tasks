using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public Clock(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public double GetAngle()
        {
            //gets angle between hours and minutes arrows
            double angle = GetHoursAngle() - GetMinutesAngle();
            //check if given angle is negative number. If so, makes him positive
            if (angle < 0)      
            {
                angle = -angle;
            }
            //checks, if angle we got, is greater one. If so, takes other angle
            if(angle > 180)
            {
                angle = 360 - angle;
            }
            return angle;
        }
        //gets angle between 0 and hours arrow
        private double GetHoursAngle()
        {
            //because, there are 24 hours in day, but only 12 numbers on clock, we have to make some adjustments
            if(Hours == 24)
            {
                return 0;
            }
            if (Hours >= 12)
            {
                return (Hours - 12) * 30;
            }
            return Hours * 30;
        }
        //gets angle between 0 and hminutes arrow
        private double GetMinutesAngle()
        {
            return Minutes * 6;
        }
    }
}
