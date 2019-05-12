using Newtonsoft.Json;
using System;

namespace DumpsvilleLib
{
    public static class DumpExtension
    {
        public static void Dump(this object item)
        {
            if (item == null) { Console.WriteLine("[null]"); return; }
            if (item is string itemString)
            {
                if (itemString == string.Empty)
                {
                    Console.WriteLine("[empty string]");
                    return;
                }

                Console.WriteLine(itemString);
                return;
            }

            var contents = JsonConvert.SerializeObject(item, Formatting.Indented);
            Console.WriteLine(contents);
        }
    }
}
