using Modem.Controls;
using System;

namespace Modem.Interfaces
{
    public interface IModemService
    {
        string PortName { get; set; }
        int BaudRate { get; set; }
        int ReadTimeout { get; set; }
        int WriteTimeout { get; set; }
        event Action<string> OnDataReceived;
        event Action<string> OnError;
        bool PortIsOpen();
        void PortOpen(NotificationTablet notification);
        void PortClose(NotificationTablet notification);
        void SetPortName(string portName, NotificationTablet notification);
        void SetPortName(string portName, int baudRate, NotificationTablet notification);
        void Timeouts(int writeTimeout, int readTimeout, NotificationTablet notification);
        string[] GetPortNames(NotificationTablet notification);
        bool WriteData(string data, NotificationTablet notification);
    }
}