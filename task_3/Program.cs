using System;
using System.Collections.Generic;
using task_3.device;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomDeviceGenerator randomDeviceGenerator = new RandomDeviceGenerator();
            List<Device> devices = new List<Device>();
            for (int i = 0; i < 20; i++) { 
            devices.Add(randomDeviceGenerator.GenerateDevice());
            }
            devices.Sort();
            foreach (Device device in devices)
            {
                Console.WriteLine(device.ToString());
            }


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Введите минимальное значение мощности прибора:");
            string input = Console.ReadLine();
            int minPwr = int.Parse(input);
            Console.WriteLine("Введите максимальное значение мощности прибора:");
            input = Console.ReadLine();
            int maxPwr = int.Parse(input);
            Console.WriteLine("Введите 1 - если прибор должен быть включен, 2 - если выключен:");
            input = Console.ReadLine();
            int state = int.Parse(input);
            bool boolState = false;
            if(state == 1) {
                boolState = true;
            }
            DeviceHelper helper = new DeviceHelper();
            List<Device> filteredDevices = helper.FindDevices(devices, minPwr, maxPwr, boolState);
            foreach (Device device in filteredDevices)
            {
                Console.WriteLine(device.ToString());
            }


            Console.WriteLine("--------------------------------------------");

            devices.Sort(new SortByPower());

            foreach (Device device in devices)
            {
                Console.WriteLine(device.ToString());
            }

            Console.WriteLine("--------------------------------------------");

            helper.ToggleDevice(devices);
            Console.ReadKey();


        }
    }


}
