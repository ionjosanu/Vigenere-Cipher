using Vigenere_Cipher;

Console.WriteLine("Vigenere Cipher");
Console.Write("Insert text : ");
string text = Console.ReadLine();
Console.WriteLine("\nInsert the keyword : ");
string key = Console.ReadLine();

Vigenere vigenere = new Vigenere(text, key);

string encryptedText = vigenere.Encrypt();
Console.WriteLine("\nEncrypted text : " + encryptedText);
Console.WriteLine("\nDecrypted text : " + vigenere.Decrypt(encryptedText));
