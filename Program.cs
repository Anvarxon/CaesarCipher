using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to encrypt or decrypt the message? Please write the name of your operation: ");
            string answer = Console.ReadLine();
            if (answer == "encrypt")
            {
                Console.Write("Enter your message to encrypt: ");
                string enteredMessage = Console.ReadLine();

                Encrypt(enteredMessage);
            }
            else if (answer == "decrypt")
            {
                Console.Write("Enter your message to decrypt: ");
                string enteredMessage = Console.ReadLine();

                Decrypt(enteredMessage);
            }
            else
            {
                Console.Write("Invalid value");
            }

        }

        static void Encrypt(string message)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string loweredMessage = message.ToLower();
            char[] secretMessage = loweredMessage.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                int encryptedLetterPosition = (letterPosition + 3) % alphabet.Length;
                char letterEncoded = alphabet[encryptedLetterPosition];
                encryptedMessage[i] = letterEncoded;
            }
            Console.WriteLine($"Encrypted message: {String.Join("", encryptedMessage)}");
        }

        // MEthod for decryption of message
        static void Decrypt(string message)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string loweredMessage = message.ToLower();
            char[] readableMessage = loweredMessage.ToCharArray();
            char[] decryptedMessage = new char[readableMessage.Length];

            for (int i = 0; i < readableMessage.Length; i++)
            {
                char letter = readableMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                int decryptedLetterPosition = (letterPosition - 3) % alphabet.Length;

                char letterDecoded = alphabet[decryptedLetterPosition];
                decryptedMessage[i] = letterDecoded;
            }
            Console.WriteLine($"Decrypted message: {String.Join("", decryptedMessage)}");
        }
    }
}