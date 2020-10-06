using System;
using System.Text.RegularExpressions;

namespace SampleEmailFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternOfEmail = "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
            string[] sampleEmail = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                    "abc@1.com","abc@gmail.com.com","abc+100@gmail.com","Abc","abc@.com.my" ,"abc123@gmail.1a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            foreach(string sample in sampleEmail)
            {
                if(Regex.IsMatch(sample,patternOfEmail))
                    Console.WriteLine(sample);

            }
        }
    }
}
