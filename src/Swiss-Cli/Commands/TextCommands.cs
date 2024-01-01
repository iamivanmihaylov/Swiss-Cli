using Cocona;
using Swiss_Cli.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Cli.Commands
{
    public class TextCommands : ICommand
    {
        [Command("upper")]
        public void Uppercase([Argument] string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        [Command("lower")]
        public void LowerCase([Argument] string text)
        {
            Console.WriteLine(text.ToLower());
        }

        [Command("title")]
        public void TitleCase([Argument] string text)
        {
            Console.WriteLine(string.Join(' ',text.Split().Select(x =>
            {
                var a = x.ToCharArray();
                if (a.Length == 0)
                {
                    return string.Empty;
                }
                a[0] = char.Parse(a[0].ToString().ToUpper());
                return string.Join(string.Empty, a);
            })));
        }

        [Command("reverse")]
        public void Reverse([Argument] string text)
        {
            Console.WriteLine(string.Join(string.Empty, text.Reverse()));
        }

        [Command("is-palindrome")]
        public void IsPalindrome([Argument] string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    Console.WriteLine(false);
                    return;
                }
            }

            Console.WriteLine(true);
        }
    }
}
