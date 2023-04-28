
using System;
using System.Collections.Generic;
namespace task_3
{
    public class DeviceHelper
    {
        public List<Device> FindDevices(List<Device> devices, int minPower, int maxPower, bool isOn)
        {
            List<Device> filteredDevices = new List<Device>();

            foreach (Device device in devices)
            {
                if (device.getPower() >= minPower && device.getPower() <= maxPower && device.isOn() == isOn)
                {
                    filteredDevices.Add(device);
                }
            }

            return filteredDevices;
        }

        public void ToggleDevice(List<Device> devices)
        {
            // Выводим список доступных устройств
            Console.WriteLine("Выберите устройство для включения/выключения:");
            for (int i = 0; i < devices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {devices[i].ToString()} ({(devices[i].isOn() ? "включено" : "выключено")})");
            }

            // Считываем ввод пользователя и выбираем соответствующее устройство
            int deviceIndex;
            do
            {
                Console.Write("Введите номер устройства: ");
            }
            while (!int.TryParse(Console.ReadLine(), out deviceIndex) || deviceIndex < 1 || deviceIndex > devices.Count);
            Device selectedDevice = devices[deviceIndex - 1];

            // Предлагаем пользователю включить или выключить выбранное устройство
            Console.WriteLine($"Устройство {selectedDevice.ToString()} {(selectedDevice.isOn() ? "включено" : "выключено")}. Что вы хотите сделать?");
            Console.WriteLine("1. Включить");
            Console.WriteLine("2. Выключить");

            // Считываем ввод пользователя и включаем или выключаем устройство
            int option;
            do
            {
                Console.Write("Введите номер опции: ");
            }
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 2);
            if (option == 1)
            {
                selectedDevice.TurnOn();
            }
            else
            {
                selectedDevice.TurnOff();
            }

            // Обновляем состояние устройства в списке и выводим обновленный список на экран
            Console.WriteLine("Список устройств:");
            for (int i = 0; i < devices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {devices[i].ToString()} ({(devices[i].isOn() ? "включено" : "выключено")})");
            }
        }
    }
}
