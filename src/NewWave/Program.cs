using System;
using System.Linq;

namespace AcidChicken.NewWave
{
    class Program
    {
        static void Main(string[] args)
        {
            #if CSHARP8
            Random random = new ();
            int step = default;
            #else
            var random = new Random();
            var step = 0;
            #endif
            Span<char> message = stackalloc [] { '大', '石', '泉', 'す', 'き' };
            do
            {
                var current = random.Next(message.Length);
                Console.Write(message[current]);
                if (current == step)
                {
                    if (++step == message.Length)
                        break;
                }
                else
                    step = 0;
            } while (true);
            Console.WriteLine();
        }
    }
}
