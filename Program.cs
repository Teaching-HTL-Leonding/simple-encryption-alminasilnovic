// Caesar Cipher
{
string encryptedtext = "";
string decryptedtext = "";
string text = "";
int shift = 0;
string direction = "";

System.Console.WriteLine($"The encrypted text is: {Encrypt(text, encryptedtext, out shift, out direction)}");
System.Console.WriteLine($"The decrypted text is: {Decrypt(text, decryptedtext, shift, direction)}");
}

string Encrypt(string text, string encryptedtext, out int shift, out string direction)
{
    int ascii = 0;
    System.Console.Write("Enter a text: ");
    text = Console.ReadLine()!;
    System.Console.Write("What shift? ");
    shift = int.Parse(Console.ReadLine()!);
    System.Console.Write("right or left? ");
    direction = (Console.ReadLine()!);
    for (int i = 0; i < text.Length; i++)
    {
        if (!char.IsLetter(text[i]))
        //if ((int)text[i] < 65 || (int)text[i] > 90 && (int)text[i] < 97 || (int)text[i] > 122)
        {
            ascii = (int)text[i];
        }
        else
        {
            if (direction == "right")
            { ascii = (int)text[i] + shift; }
            else
            { ascii = (int)text[i] - shift; }
            if (char.IsLower(text[i]))
            //if ((int)text[i] > 96 && (int)text[i] < 123)
            {
                if (ascii > 122)
                {
                    ascii = ascii - 122 + 96;
                }
                else if (ascii < 97)
                {
                    ascii = ascii + 122 - 96;
                }
            }
            else
            {
                if (ascii > 90)
                {
                    ascii = ascii - 90 + 64;
                }
                else if (ascii < 65)
                {
                    ascii = ascii + 90 - 64;
                }
            }
        }
        encryptedtext += (char)ascii;
    }
    return encryptedtext;
}

string Decrypt(string text, string decryptedtext, int shift, string direction)
{
    int ascii = 0;
    System.Console.Write("Enter a decrypted text: ");
    text = Console.ReadLine()!;
    for (int i = 0; i < text.Length; i++)
    {
        if (!char.IsLetter(text[i]))
        {
            ascii = (int)text[i];
        }
        else
        {
            if (direction == "right")
            { ascii = (int)text[i] + shift; }
            else
            { ascii = (int)text[i] - shift; }
            if (char.IsLower(text[i]))
            {
                if (ascii > 122)
                {
                    ascii = ascii - 122 + 96;
                }
                else if (ascii < 97)
                {
                    ascii = ascii + 122 - 96;
                }
            }
            else
            {
                if (ascii > 90)
                {
                    ascii = ascii - 90 + 64;
                }
                else if (ascii < 65)
                {
                    ascii = ascii + 90 - 64;
                }
            }
        }
        decryptedtext += (char)ascii;
    }
    return decryptedtext;
}
