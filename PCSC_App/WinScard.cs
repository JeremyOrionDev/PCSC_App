using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PCSC_App
{
    class WinScard
    {
        [DllImport("WinScard.dll")]
         static extern int SCardEstablishContext(uint dwScope,IntPtr notUsed1,IntPtr notUsed2,out IntPtr phContext);

        [DllImport("WinScard.dll")]

        static extern int SCardReleaseContext(IntPtr phContext);

        [DllImport("WinScard.dll")]

        static extern int SCardConnect(IntPtr hContext,string cReaderName,uint dwShareMode,uint dwPrefProtocol,ref IntPtr phCard,ref IntPtr ActiveProtocol);
    }
}
