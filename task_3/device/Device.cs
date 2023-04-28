using System;
using System.Text;

namespace task_3
{
    public class Device : IDevice, IComparable<IDevice>
    {

        private string typeOfDevice;
        private int powerOfDevice;
        private bool stateOfDevice;

        public Device(string typeOfDevice, int powerOfDevice, bool stateOfDevice)
        {
            this.typeOfDevice = typeOfDevice;
            this.powerOfDevice = powerOfDevice;
            this.stateOfDevice = stateOfDevice;
        }

       

        public int CompareTo(IDevice other)
        {
            if (this.isOn() && !other.isOn())
            {
                return -1;
            }
            else if (!this.isOn() && other.isOn())
            {
                return 1;
            }
            else
            {
                int powerComparison = this.getPower().CompareTo(other.getPower());
                if (powerComparison != 0)
                {
                    return powerComparison;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int getPower()
        {
            return powerOfDevice;
        }

        public bool isOn()
        {
            return stateOfDevice;
        }

        public bool TurnOn()
        {
            return stateOfDevice = true;
        }

        public bool TurnOff()
        {
            return stateOfDevice = false;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(").Append(this.typeOfDevice)
                    .Append(" : ")
                    .Append(this.powerOfDevice).Append("Вт : ")
                    .Append(this.isOn() ? "Device is on" : "Device is off").Append(")");
            return sb.ToString();
        }

    }
}
