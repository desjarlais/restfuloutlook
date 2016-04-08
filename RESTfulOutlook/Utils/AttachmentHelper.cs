using System;

namespace RESTfulOutlook.Utils
{
    class AttachmentHelper
    {
        static readonly string[] sizeSuffixes = { "bytes", "KB", "MB", "GB" };

        /// <summary>
        /// this function takes a file size in bytes and converts it to the equivalent file size label
        /// </summary>
        /// <param name="value">the size in bytes of the attached file being added</param>
        /// <returns></returns>
        public static string SizeSuffix(long value)
        {
            if (value < 0)
            {
                return "-" + SizeSuffix(-value);
            }
            if (value == 0)
            {
                return "0.0 bytes";
            }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, sizeSuffixes[mag]);
        }

        /// <summary>
        /// this function takes in a byte array and returns the hex string
        /// </summary>
        /// <param name="byteArray">byte array to be converted</param>
        /// <returns></returns>
        public static string GetHexStringFromByteArray(byte[] byteArray)
        {
            return BitConverter.ToString(byteArray); 
        }
    }
}
