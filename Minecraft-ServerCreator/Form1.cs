using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minecraft_ServerCreator
{
    public partial class Form1 : Form
    {
        private string selectedDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectDirectoryButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    selectedDirectory = folderBrowserDialog.SelectedPath;
                    selectedDirectoryTextBox.Text = selectedDirectory;

                    // Call UseSelectedDirectory method after selecting the directory
                    UseSelectedDirectory();
                }
            }
        }


        // Example method using the selected directory
        private void UseSelectedDirectory()
        {
            if (!string.IsNullOrEmpty(selectedDirectory))
            {
                // Use the selected directory variable here
                AppendOutput("Selected directory: " + selectedDirectory);
            }
            else
            {
                AppendOutput("No directory selected.");
            }
        }

        // Call UseSelectedDirectory method when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            UseSelectedDirectory();
        }

        private void InstallServer_Click(object sender, EventArgs e)
        {
            try
            {
                string powerShellScript = $@"
                    $url='https://www.minecraft.net/en-us/download/server'
                    $link=(Invoke-WebRequest -Uri $url).Links | Where-Object {{$_.innerText -like '*minecraft_server*.jar'}} | Select-Object -First 1 -ExpandProperty href
                    Invoke-WebRequest -Uri $link -OutFile '{selectedDirectory}\minecraft_server_latest.jar'
                ";

                using (Process process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-ExecutionPolicy Bypass -Command \"{powerShellScript}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    process.Start();
                    AppendOutput("Installing Required Jar File, Wait A Second...");
                    process.WaitForExit();

                    AppendOutput(process.ExitCode == 0 ? "Minecraft server installed successfully! Please proceed to run Auto Setup." : "Installation Failed: Make sure you have a directory set and a stable internet connection!");
                }
            }
            catch (Exception ex)
            {
                AppendOutput($"An error occurred: {ex.Message}");
            }
        }

        private void SetupServer_Click(object sender, EventArgs e)
        {
            try
            {

                // Construct the full path to minecraft_server_latest.jar
                string jarFilePath = System.IO.Path.Combine(selectedDirectory, "minecraft_server_latest.jar");

                if (System.IO.File.Exists(jarFilePath))
                {
                    // Prepare process start info
                    // Prepare process start info
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "java.exe",
                        Arguments = $"-jar \"{jarFilePath}\"",
                        WorkingDirectory = selectedDirectory, // Set the working directory
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true, // Redirect standard error
                        CreateNoWindow = true
                    };

                    // Start the process
                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();

                        // Read standard output and error streams asynchronously
                        Task<string> outputTask = process.StandardOutput.ReadToEndAsync();
                        Task<string> errorTask = process.StandardError.ReadToEndAsync();

                        // Wait for both tasks to complete
                        Task.WaitAll(outputTask, errorTask);

                        // Check if any error occurred
                        if (!string.IsNullOrEmpty(errorTask.Result))
                        {
                            AppendOutput($"An error occurred: {errorTask.Result}");
                        }
                        else
                        {
                            // Display standard output if needed
                            string output = outputTask.Result;
                            AppendOutput(output);
                            Console.WriteLine(output);


                            CreateTextFile(selectedDirectory, "eula.txt", "eula=true");
                            AppendOutput("Manual EULA Bypassed ✅");
                            AppendOutput("Jar File Executed Properly, You Can Now Start Your Server!");
                        }

                        process.WaitForExit();
                    }
                }
                else
                {
                    MessageBox.Show("minecraft_server_latest.jar not found in the selected directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AppendOutput($"An error occurred: {ex.Message}");
            }
        }

        static void CreateTextFile(string selectedDirectory, string filename, string content)
        {
            // Set the name of the file
            string fileName = filename;

            // Construct the full file path
            string filePath = Path.Combine(selectedDirectory, fileName);

            // Create a StreamWriter to write text to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the content to the file
                writer.Write(content);
            }
        }

        private void RunServer_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct the full path to minecraft_server_latest.jar
                string jarFilePath = Path.Combine(selectedDirectory, "minecraft_server_latest.jar");

                if (File.Exists(jarFilePath))
                {
                    // Prepare process start info
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "java.exe",
                        Arguments = $"-jar \"{jarFilePath}\"",
                        WorkingDirectory = selectedDirectory,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;

                        AppendOutput("Server Started!");
                        process.Start();

                        // Wait for the process to exit
                        process.WaitForExit();

                        AppendOutput("Server Stopped!");
                    }
                }
                else
                {
                    MessageBox.Show("minecraft_server_latest.jar not found in the selected directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AppendOutput($"An error occurred: {ex.Message}");
            }
        }

        // Method to append individual lines of output to the ListBox
        private void AppendOutput(string output)
        {
            if (outputListBox.InvokeRequired)
            {
                outputListBox.Invoke(new Action<string>(AppendOutput), output);
            }
            else
            {
                // Split the output by newline characters
                string[] lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Add each line as a separate item in the ListBox
                foreach (string line in lines)
                {
                    outputListBox.Items.Add(line);
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void discordjoin_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the Discord invite link in the default web browser
                Process.Start("https://discord.gg/gtadev");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void InstallPlayItButton_Click(object sender, EventArgs e)
        {
            try
            {
                string downloadUrl = "https://github.com/playit-cloud/playit-agent/releases/download/v0.15.12/playit-windows-x86_64-signed.msi";
                string downloadPath = Path.Combine(selectedDirectory, "playit-windows-x86_64-signed.msi");

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(downloadUrl, downloadPath);
                }

                // Once downloaded, you can start the installation process
                Process.Start(downloadPath);
            }
            catch (Exception ex)
            {
                AppendOutput($"An error occurred: {ex.Message}");
            }
        }
    }
}