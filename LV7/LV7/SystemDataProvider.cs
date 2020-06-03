using System;
using System.Collections.Generic;
using System.Text;

namespace LV7
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float nowLoad = this.CPULoad;
            if (nowLoad != this.previousCPULoad && Math.Abs(nowLoad - this.previousCPULoad) >= 0.1 * this.previousCPULoad)
            {
                this.Notify();
            }
            this.previousCPULoad = nowLoad;
            return nowLoad;
        }
        public float GetAvailableRAM()
        {
            float nowRAM = this.AvailableRAM;
            if (nowRAM != this.previousRAMAvailable && Math.Abs(nowRAM - this.previousRAMAvailable) >= 0.1 * this.previousRAMAvailable)
            {
                this.Notify();
            }
            this.previousRAMAvailable = nowRAM;
            return nowRAM;

        }
    }
}
