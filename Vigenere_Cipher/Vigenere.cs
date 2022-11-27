using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_Cipher
{
    internal class Vigenere
    {
        public static string Text;
        public static string Key;

        public Vigenere(string text, string keyword)
        {
            Text = text;
            Key = keyword;
        }

        public string KeyGenerator(string text, string key)
        {
            int x = key.Length;
            for (int i = 0; i <= x; i++)
            {
                if (i == x)
                    i = 0;
                if (key.Length == text.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }

        public string Encrypt()
        {
            Key = KeyGenerator(Text, Key);
            string EncryptedText = "";
            int letter;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Char.IsLetter(Text[i]))
                {
                    letter = ((Text[i]) + Key[i]) % 26;
                    letter += 'A';
                    EncryptedText += (char)(letter);
                }
                else
                    EncryptedText += Text[i];
            }
            return EncryptedText;
        }

        public string Decrypt(string text)
        {
            string DecryptedText = "";
            int letter;
            for (int i = 0; i < text.Length && i < Key.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    letter = (text[i] - Key[i] + 26) % 26;
                    letter += 'A';
                    DecryptedText += (char)(letter);
                }
                else
                    DecryptedText += text[i];
            }
            return DecryptedText;
        }
    }
}
