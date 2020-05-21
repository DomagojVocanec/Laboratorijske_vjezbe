using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Time : Zabiljeska
    {
        private DateTime time;
        public Time()
        {
            time = DateTime.Now;
        }
        public Time(string tekst, string autor, int vaznost, DateTime time) : base(tekst, string.Empty, vaznost)
        {
            this.time = time;
        }
        public DateTime Public_Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public override string ToString()
        {
            return base.ToString() + ($"Zabiljeska je stvorena u {Public_Time} sati.");
        }
    }
}
