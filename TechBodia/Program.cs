using System;
using System.Linq;

Console.WriteLine("Enter an IP address:");
var input = Console.ReadLine();
bool isValid = ValidateIpAddress(input ?? "");
Console.WriteLine($"The IP address {input} is {(isValid ? "valid" : "invalid")}");

bool ValidateIpAddress(string ipAddress)
{
    string[] octets = ipAddress.Split('.');
    if (octets.Length != 4)
    {
        return false;
    }

    foreach (string octet in octets)
    {
        if (!byte.TryParse(octet, out byte result) || result.ToString() != octet || result < 0 || result > 255)
        {
            return false;
        }
    }

    return true;
}
