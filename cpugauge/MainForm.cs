/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/16/2020
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace cpugauge
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public class ProcessorUsage
{
    const float sampleFrequencyMillis = 1000;

    protected object syncLock = new object();
    protected PerformanceCounter counter;
    protected float lastSample;
    protected DateTime lastSampleTime;

    /// <summary>
    /// 
    /// </summary>
    public ProcessorUsage()
    {
        this.counter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public float GetCurrentValue()
    {
        if ((DateTime.UtcNow - lastSampleTime).TotalMilliseconds > sampleFrequencyMillis)
        {
            lock (syncLock)
            {
                if ((DateTime.UtcNow - lastSampleTime).TotalMilliseconds > sampleFrequencyMillis)
                {
                    lastSample = counter.NextValue();
                    lastSampleTime = DateTime.UtcNow;
                }
            }
        }

        return lastSample;
    }
}
		
		
		 public PerformanceCounter cpuCounter = new PerformanceCounter();
		public PerformanceCounter ramCounter = new PerformanceCounter();
int totalHits = 0;
		
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		public string getbatterystatus()
		{
			return SystemInformation.PowerStatus.ToString();
		}
		public string getcomputername()
		 {
			 return SystemInformation.ComputerName.ToString();
		 }
		public void getcpuloadlevel()
		{
			
			cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
			
		}
		
		public void getramloadlevel(){
			
			ramCounter = new PerformanceCounter("Memory", "Available MBytes");
			
		}
		
		private static void RunTest(string appName)
{
    bool done = false;
    PerformanceCounter total_cpu = new PerformanceCounter("Process", "% Processor Time", "_Total");
    PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time", appName);
    while (!done)
    {
        float t = total_cpu.NextValue();
        float p = process_cpu.NextValue();
        Console.WriteLine(String.Format("_Total = {0}  App = {1} {2}%\n", t, p, p / t * 100));
        System.Threading.Thread.Sleep(1000);
    }
}
		
		/*
		 private void button1_Click(object sender, EventArgs e)
{
    selectedServer = "JS000943";
    listBox1.Items.Add(GetProcessorIdleTime(selectedServer).ToString());
}

private static int GetProcessorIdleTime(string selectedServer)
{
    try
    {
        var searcher = new
           ManagementObjectSearcher
             (@"\\"+ selectedServer +@"\root\CIMV2",
              "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name=\"_Total\"");

        ManagementObjectCollection collection = searcher.Get();
        ManagementObject queryObj = collection.Cast<ManagementObject>().First();

        return Convert.ToInt32(queryObj["PercentIdleTime"]);
    }
    catch (ManagementException e)
    {
        MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
    }
    return -1;
}
		 */

    public object getCPUCounter()
    {

       
        cpuCounter.CategoryName = "Processor";
        cpuCounter.CounterName = "% Processor Time";
        cpuCounter.InstanceName = "_Total";

                     // will always start at 0
        dynamic firstValue = cpuCounter.NextValue();
        System.Threading.Thread.Sleep(1000);
                    // now matches task manager reading
        dynamic secondValue = cpuCounter.NextValue();

        return secondValue;

    }

    
		public string getCurrentCpuUsage(){
            return cpuCounter.NextValue()+"%";
		}

		public string getAvailableRAM(){
            return ramCounter.NextValue()+"MB";
		} 
		void Timer1Tick(object sender, EventArgs e)
		{
			
			
		}
		void Label1Click(object sender, EventArgs e)
		{
			Close();
		}
		void MainFormShown(object sender, EventArgs e)
		{
			/*
 			getcpuloadlevel();
			getramloadlevel();
			label1.Text = getCurrentCpuUsage();
			label1.Text += "\r\n ";
			label1.Text += getbatterystatus();
			label1.Text += " ";
			label1.Text += getAvailableRAM();
			
			
			error addressing
			
			unsafe
{
    fixed (byte* p = readBuffer)
    {
         IntPtr intPtr = (IntPtr)p;
         this.ReadFile(ref sourceFile, (ulong)buffer_size, intPtr, ref nNumBytesRead);

         if (intPtr != IntPtr.Zero)
         {
             try
             {
                 FunctionSqudf.CloseHandle(intPtr);
             }
             catch (Exception ex)
             {
                  Hardware.LogHardware.Error("CloseHandle", ex);
             }
         }
      }
  }


    [SecuritySafeCritical]
    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool CloseHandle(IntPtr hObject);
    
    
			
			
			int cpuPercent = (int)getCPUCounter();
        if (cpuPercent >= 90)
        {
            totalHits = totalHits + 1;
            if (totalHits == 60)
            {
                //Interaction.MsgBox("ALERT 90% usage for 1 minute");
                totalHits = 0;
            }                        
        }
        else
        {
            totalHits = 0;
        }
        label1.Text = cpuPercent + " % CPU";
        label2.Text = ramCounter + " RAM Free";
        label3.Text = totalHits + " seconds over 20% usage";
        */
            label1.Text = GetCpuUsage().ToString();
		}
		public Int64 GetCpuUsage()
{
    PerformanceCounter cpuCounter2  = new  PerformanceCounter();
    try
    {
         cpuCounter2 = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
        cpuCounter2.NextValue();
        System.Threading.Thread.Sleep(1000);
    }
    catch { }
return (Int64)cpuCounter2.NextValue();
}
	}
}
