using System.Runtime.ExceptionServices;
using System.Collections.Generic;
using System;
namespace DLMSAssignment2
{
    //get-set-
    public class MeterObject
    {
        public byte[] Obis { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class Dlms
    {
        private readonly MeterObject[] _meterObjects = new MeterObject[]
        {
        new MeterObject { Obis = new byte[] { 1, 0, 96, 1, 0, 255 }, Name = "Active Energy (Total)", Value = 12345 },
        new MeterObject { Obis = new byte[] { 1, 0, 96, 1, 1, 255 }, Name = "Active Energy (Phase A)", Value = 67890 }
        };

        public void Get(byte[] obis)
        {
            var meterObject = _meterObjects.FirstOrDefault(mo => mo.Obis.SequenceEqual(obis));

            if (meterObject != null)
            {
                Console.WriteLine($"[GET] {meterObject.Name} = {meterObject.Value}");
            }
            else
            {
                Console.WriteLine("[GET] OBIS not found.");
            }
        }

        public void Set(byte[] obis, int newValue)
        {
            
            var meterObject = _meterObjects.FirstOrDefault(mo => mo.Obis.SequenceEqual(obis));

            if (meterObject != null)
            {
                meterObject.Value = newValue;
                Console.WriteLine($"[SET] {meterObject.Name} updated to {newValue}");
            }
            else
            {
                Console.WriteLine("[SET] OBIS not found.");
            }
        }

        public void Action(byte[] obis, string method)
        {
            if (method.ToUpper() == "RESET")
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                foreach (var meterObject in _meterObjects)
                {
                    meterObject.Value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (method.ToUpper() == "SYNC_TIME")
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock...");
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown action.");
            }
        }

        public void ReadShortName(ushort shortName)
        {
            Console.WriteLine($"[READ-SN] Reading object with short name: 0x{shortName:X4}");
        }

        public void WriteShortName(ushort shortName, int newValue)
        {
            Console.WriteLine($"[Write-SN] Writing value {newValue} to object with short name: 0x{shortName:X4}");
        }
    }
}
