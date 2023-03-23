using System;
using System.Text;


namespace ApplicationToLearnTest
{
    public class Randomize : IRandomize
    {
        public Random _random { get; set; }

        public Randomize(Random random)
        {
            _random = random;
        }
        public int RandomNumber(int min, int max)
        {
            if (min > max)
            {
                throw new Exception();
            }
            return _random.Next(min, max + 1);
        }

        public string RandomString(int size, bool lowerCase)
        {
            if (size < 0)
            {
               throw new Exception();
            }
            Random rnd = new Random();
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var value = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(value);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public string RandomPassword(bool numbers, bool specialCharacter, int smallLetters, int bigLetters)
        {
            if(smallLetters < 0||bigLetters < 0)
            {
                throw new Exception();
            }
            var passwordBuilder = new StringBuilder();
            passwordBuilder.Append(RandomString(smallLetters, true));
            if (numbers)
            {
                passwordBuilder.Append(RandomNumber(0, 10));
            }
            passwordBuilder.Append(RandomString(bigLetters, false));
            if (specialCharacter)
            {
                passwordBuilder.Append("@");
            }
            return passwordBuilder.ToString();
        }
    }
}
