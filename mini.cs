using System;
using System.Management.Automation;
using System.Collections.ObjectModel;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
        PowerShell ps = PowerShell.Create();    
        string command;        

        Collection<PSObject> PSOutput;        

        while (true)

        {

        command = Console.ReadLine();

        PSOutput = ps.AddScript(command).Invoke();  

        if (command == "exit")

        {

            break;

        }

        for (int i=0; i<PSOutput.Count; i++)

        {

        Console.WriteLine(PSOutput[i].ToString());  

        }    

        }

        Console.ReadLine();

        }

    }

}  
