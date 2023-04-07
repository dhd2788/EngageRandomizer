using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Logging;

namespace EngageRandomizerUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Logger.TryGet(LogEventLevel.Fatal, LogArea.Control)?.Log(this, "Avalonia Infrastructure");
            System.Diagnostics.Debug.WriteLine("System Diagnostics Debug");
            InitializeComponent();
        }


        public void btnRandomize_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            button.Content = "You clicked me!";

            string command1 = "cd C:\\Users\\darad\\Desktop\\\"Switch Hacking\"\\FEE\\EngageAssetsModified";
            string command2 = "C:\\Users\\darad\\Desktop\\\"Switch Hacking\"\\FEE\\EngageXML\\EngageXml.exe calculator.xml";

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command1);
            cmd.StandardInput.Flush();

            cmd.StandardInput.WriteLine(command2);
            cmd.StandardInput.Flush();

            cmd.StandardInput.Close();
            cmd.WaitForExit();
            System.Diagnostics.Debug.WriteLine(cmd.StandardOutput.ReadToEnd());


            /*ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c" + command);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = false;
            

            // wrap IDisposable into using (in order to release hProcess) 
            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();

                // Add this: wait until process does its work
                process.WaitForExit();

                // and only then read the result
                string result = process.StandardOutput.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(result);
            }*/


        }
    }
}