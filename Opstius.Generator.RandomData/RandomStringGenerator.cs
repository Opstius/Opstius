using System.Text;

namespace Opstius.Generator.RandomData
{
    public static class RandomStringGenerator
    {
        private static readonly Random random = new Random();

        public static string Generate(string supportedChars, int length)
        {
            if (supportedChars == null || supportedChars == string.Empty)
            {
                return string.Empty;
            }
            if (length <= 0)
            {
                return string.Empty;
            }

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, supportedChars.Length);
                builder.Append(supportedChars[index]);
            }

            return builder.ToString();
        }
    }
}
