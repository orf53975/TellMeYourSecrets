﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace TellMeYourSecrets
{
    public class Base
    {
        protected StringBuilder stringBuilder = new StringBuilder();

        protected void WriteOutput(string output)
        {
            stringBuilder.Append(output + "\n");
        }

        protected void WriteOutputGood(string output)
        {
            stringBuilder.Append("[+] " + output + "\n");
        }

        protected void WriteOutputNeutral(string output)
        {
            stringBuilder.Append("[*] " + output + "\n");
        }

        protected void WriteOutputBad(string output)
        {
            stringBuilder.Append("[-] " + output + "\n");
            string errorMessage = new Win32Exception(Marshal.GetLastWin32Error()).Message;
            stringBuilder.Append("[-] " + errorMessage + "\n");
        }

        public string GetOutput()
        {
            return stringBuilder.ToString().Trim();
        }
    }
}
