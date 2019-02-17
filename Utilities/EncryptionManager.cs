using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharepointHelper.Utilities
{
    public static class EncryptionManager
    {
        private static Random random;
        private static int seed = 0;

        public static string Encrypt(string text)
        {
            random = new Random(seed);

            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
                newText += (char)((int)text[i] + random.Next(1024));

            return newText;
        }

        public static string Decrypt(string text)
        {
            random = new Random(seed);

            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
                newText += (char)((int)text[i] - random.Next(1024));

            return newText;
        }
    }
}
