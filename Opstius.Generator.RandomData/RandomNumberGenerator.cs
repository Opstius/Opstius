namespace Opstius.Generator.RandomData
{
    public static class RandomNumberGenerator
    {
        public static string Generate(int length)
        {
            return RandomStringGenerator.Generate("0123456789", length);
        }
    }
}
