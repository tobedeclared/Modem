using Modem.Controls;
using Modem.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace Modem.Classes
{
    internal class ModemService: IModemService
    {
        private SerialPort _serialPort;
        public string PortName { 
            get { return _serialPort.PortName; }
            set { _serialPort.PortName = value; }
        }
        public int BaudRate
        {
            get { return _serialPort.BaudRate; }
            set { _serialPort.BaudRate = value; }
        }
        public int ReadTimeout
        {
            get { return _serialPort.ReadTimeout; }
            set { _serialPort.ReadTimeout = value; }
        }
        public int WriteTimeout
        {
            get { return _serialPort.WriteTimeout; }
            set { _serialPort.WriteTimeout = value; }
        }

        public event Action<string> OnDataReceived;
        public event Action<string> OnError;

        public ModemService()
        {
            _serialPort = new SerialPort();
            _serialPort.DataReceived += DataReceived;
        }

        public void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadExisting();
                OnDataReceived?.Invoke(data);
            }
            catch (Exception error)
            {
                OnError?.Invoke(error.Message);
            }
        }
        public bool PortIsOpen()
        {
            if (_serialPort == null)
            {
                return false;
            } else
            {
                return _serialPort.IsOpen;
            }
        }
        public void PortOpen(NotificationTablet notification)
        {
            if (PortIsOpen() == false)
            {
                try
                {
                    _serialPort.Open();
                }
                catch (Exception error)
                {
                    notification.Set("Ошибка", error.Message);
                }
            }
        }
        public void PortClose(NotificationTablet notification)
        {
            if (PortIsOpen() == true)
            {
                try
                {
                    _serialPort.DiscardInBuffer();
                    _serialPort.DiscardOutBuffer();
                    _serialPort.Close();
                }
                catch (Exception error)
                {
                    notification.Set("Ошибка", error.Message);
                }
            }
        }
        public void SetPortName(string portName, NotificationTablet notification)
        {
            try
            {
                _serialPort.PortName = portName;
            } catch (Exception error)
            {
                notification.Set("Ошибка", error.Message);
            }
        }
        public void SetPortName(string portName, int baudRate, NotificationTablet notification)
        {
            try
            {
                _serialPort.PortName = portName;
                _serialPort.BaudRate = baudRate;
            }
            catch (Exception error)
            {
                notification.Set("Ошибка", error.Message);
            }
        }
        public void Timeouts(int writeTimeout, int readTimeout, NotificationTablet notification)
        {
            try
            {
                _serialPort.ReadTimeout = readTimeout;
                _serialPort.WriteTimeout = writeTimeout;
            }
            catch (Exception error)
            {
                notification.Set("Ошибка", error.Message);
            }
        }
        public string[] GetPortNames(NotificationTablet notification)
        {
            try
            {
                string[] portNames = SerialPort.GetPortNames();
                if (portNames.Length == 0) return new string[] { "Нет доступных портов" };

                return portNames;
            }
            catch (Exception error)
            {
                notification.Set("Ошибка", error.Message);
                return new string[] { "Нет доступных портов" };
            }
        }
        public bool WriteData(string data, NotificationTablet notification)
        {
            try
            {
                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();
                _serialPort.WriteLine(data);
                return true;
            }
            catch (Exception error)
            {
                notification.Set("Ошибка", error.Message);
                return false;
            }
        }
    }
}