using System;

namespace task_3.device
{
    public class RandomDeviceGenerator
    {
        private readonly Random random;

        public RandomDeviceGenerator()
        {
            random = new Random();
        }

        public Device GenerateDevice()
        {
            
            string[] deviceTypes = { "Холодильник", "Телевизор", "Стиральная машина", "Чайник", "Микроволновка", "Компьютер" };

            
            string type = deviceTypes[random.Next(deviceTypes.Length)];

            
            int power = random.Next(100, 2000);

            
            bool isOn = random.Next(2) == 1;

            
            return new Device(type, power, isOn);
        }
    }
}
