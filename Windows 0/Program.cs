using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Windows_0
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private const int WH_KEYBOARD_LL = 13;
        //private const int WM_KEYDOWN = 0x0100;
        //private const int WM_SYSKEYDOWN = 0x0104;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYUP = 0x0105;

        private const int VK_SHIFT = 0x10;
        private const int VK_CONTROL = 0x11;
        private const int VK_MENU = 0x12; // ALT
        private const int VK_CAPITAL = 0x14; // CAPS LOCK

        private static HookHandlerDelegate proc;
        private static IntPtr hookID = IntPtr.Zero;
        internal delegate IntPtr HookHandlerDelegate(
            int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

        internal struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }


        [STAThread]
        static void Main()
        {
            hookID = KeyboardHook();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            //Explorer mainform = new Explorer(new Form1(false,false));
            //CreateButton mainform = new CreateButton();
            Form1 mainform= new Form1(false,false);
            Application.Run(mainform);
            api.UnhookWindowsHookEx(hookID);

        }

        public static IntPtr KeyboardHook()
        {
            proc = new HookHandlerDelegate(HookCallback);
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return api.SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    api.GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static bool Syskey(int keycode)
        {
            switch (keycode)
            {
                case VK_CAPITAL: //CAPSLOCK is ON
                    return (api.GetKeyState(VK_CAPITAL) & 0x0001) != 0;

                case VK_SHIFT: //SHIFT is pressed
                    return (api.GetKeyState(VK_SHIFT) & 0x8000) != 0;

                case VK_CONTROL: //CONTROL is pressed
                    return (api.GetKeyState(VK_CONTROL) & 0x8000) != 0;

                case VK_MENU: //ALT is pressed
                    return (api.GetKeyState(VK_MENU) & 0x8000) != 0;

                default:
                    return (api.GetKeyState(VK_MENU) != 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
        {


            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
                {
                    /*
                    if (lParam.vkCode == 85 && Syskey(VK_SHIFT))
                    {
                        DateTime myDT = new DateTime();
                        myDT = DateTime.Now;
                        MessageBox.Show("\"SHIFT + U\" pressed at " + myDT.Millisecond);
                        return (System.IntPtr)1;
                    }
                    */
                    if (lParam.vkCode == 16 && Syskey(VK_SHIFT))
                    {
                        Form1 form = new Form1(false, false);

                        form.ChangeLangLabel();
                    }



                }




            }
            return api.CallNextHookEx(hookID, nCode, wParam, ref lParam);
        }

        internal class api
        {
            #region DLLimport
            [ComVisibleAttribute(false), System.Security.SuppressUnmanagedCodeSecurity()]

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
                IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern IntPtr SetWindowsHookEx(int idHook, HookHandlerDelegate lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            internal static extern short GetKeyState(int keyCode);
            #endregion
        }


    }
}