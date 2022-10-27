using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfcCardDumpConverter.Models
{
    public class RawDump : NfcCard
    {
        public RawDump(string filePath)
        {
            Array.Copy(File.ReadAllBytes(filePath), RawData, RawData.Length);
            Console.WriteLine($"NFC Card (Raw format) has been read from {filePath}");
        }

        public override void Write(string filePath) => base.WriteAsRawFormat(filePath);
    }
}
