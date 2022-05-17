using System;
using System.Text;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        //string fileLoc2 = @"C:\Users\matth\Desktop\passwords.txt";
        string fileLoc2 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\passwords.txt";

        string[] readText = File.ReadAllLines(fileLoc2);
        Console.WriteLine("Please enter a USER: ");
        string USER = "USER";
        USER = Console.ReadLine();

        Console.WriteLine("Please enter a password to hash/login: ");
        string source = "password";
        source = Console.ReadLine();
        string hash = "Nothing";
        using (MD5 md5Hash = MD5.Create())
        {
            hash = GetMd5Hash(md5Hash, source);
            Console.WriteLine("The MD5 hash of " + source + " is: " + hash + ".");
        }
        



        int counter = 0;
        //for (int i = 0; i < readText.Length; i++)
        //{
        // Printing the string array containing
        //Console.WriteLine($"{i} = {readText[i]} Source is: {source} ");
        // all lines of the file.
        int matched = 0;
        string[] lineSplit = { "Test" };
        var dbuser = "Test";
        var dbPassword = "Test";
        int count = 0;

        foreach (string s in readText)
        { 
            
                lineSplit = readText[count].Split('|');
                dbuser = lineSplit[0].ToString().Trim();
                dbPassword = lineSplit[1].ToString().Trim();
            count++;
                
                //Console.WriteLine("DBUSER: " + dbuser);
                //Console.WriteLine("DBPASS: " + dbPassword);

                    if (dbuser == USER && hash == dbPassword && matched == 0)
                    {
                        Console.WriteLine("The passwords matched");
                    matched = 1;
                    }
                    else
                    {
                        counter++;
                        if (counter >= readText.Length)
                        {
                            Console.WriteLine("The password is incorrect");
                        }
                    }

           // }

            
        }

            //string correctpsw = "GetMd5Hash(md5Hash, source)";

        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

}

