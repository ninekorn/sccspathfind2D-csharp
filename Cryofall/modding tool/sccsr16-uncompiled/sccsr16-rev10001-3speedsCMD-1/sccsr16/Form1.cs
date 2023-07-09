////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//DEVELOPED BY STEVE CHASSÉ using xoofx's sharpdx original deferred rendering sample. This is a software of mixed architecture//
//using rastertek c# github user dan6040's sample architecture and smartrak's sample architecture and xoofx sharpdx samples/////
//architecture./////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel 
//  
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions: 
//  
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software. 
//  
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE. 


//The MIT License (MIT)
//
//Copyright(c) 2016 Smartrak

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.


//https://github.com/Dan6040/SharpDX-Rastertek-Tutorials
//https://github.com/Smartrak/WpfSharpDxControl
//https://github.com/sharpdx/SharpDX-Samples


using sccs.sccore;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static sccsr16.Form1;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;




namespace sccsr16
{
    public partial class Form1 : Form
    {
        public static Form1 currentform;
        public static IntPtr theHandle;

        public static Button thebutton20;
        public static Button thebutton21;
        public static Button thebutton22;
        public static Button thebutton4;
        public static Button thebutton16;
        public static Button thebutton18;

        public static Button thebutton3;
        public static Button thebutton17;
        public static Button thebutton19;

        public static Button thebutton1;

        public static Button thebutton2;
        public static Button thebutton6;
        public Form1()
        {
            currentform = this;
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_Closing;
            this.FormClosed += Form1_Closed;
            /*
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;*/

            //this.comboBox2.Visible = false;

            this.Move += Form1_Move;


            buttonlist.Add(button15);
            buttonlist.Add(button13);
            buttonlist.Add(button14);
            buttonlist.Add(button12);

            listbuttonswtc.Add(0);
            listbuttonswtc.Add(0);
            listbuttonswtc.Add(0);
            listbuttonswtc.Add(0);

            button4.BackColor = System.Drawing.Color.Red;
            button4.Refresh();
            button16.BackColor = System.Drawing.Color.Red;
            button16.Refresh();

            button3.BackColor = System.Drawing.Color.Red;
            button3.Refresh();
            button17.BackColor = System.Drawing.Color.Red;
            button17.Refresh();

            button20.Text = "D" + "\n" + ">>>";
            button20.Refresh();
            button21.Text = "M" + "\n" + ">>>";
            button21.Refresh();
            button22.Text = "C" + "\n" + ">>>";
            button22.Refresh();

            thebutton20 = button20;
            thebutton21 = button21;
            thebutton22 = button22;

            thebutton4 = button4;
            thebutton16 = button16;
            thebutton18 = button18;

            thebutton3 = button3;
            thebutton17 = button17;
            thebutton19 = button19;

            thebutton1 = button1;

            thebutton2 = button2;
            thebutton6 = button6;


            /*
            this.comboBox1.LostFocus += ComboBox1_LostFocus;
            this.comboBox1.SelectionChangeCommitted += ComboBox1_ChangeCommitted;
            this.comboBox1.GotFocus += ComboBox1_GotFocus;*/



            /*//https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=windowsdesktop-7.0
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog1.Description = "Select the directory that you want to use as the default.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // Default to the My Documents folder.
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = folderName;
                    openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }
            }*/
            //Size somesize = new Size(1096, 600);
            //this.ClientSize = somesize;
            //this.openMenuItem.Text = "Open...";
            //this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);

        }


        /*
        private MainMenu mainMenu1;
        private MenuItem fileMenuItem, openMenuItem;
        private MenuItem folderMenuItem, closeMenuItem;*/

        private string openFileName, folderName;

        private bool fileOpened = false;

        /*// Bring up a dialog to open a file.
        private void openMenuItem_Click(object sender, System.EventArgs e)
        {
            // If a file is not opened, then set the initial directory to the
            // FolderBrowserDialog.SelectedPath value.
            if (!fileOpened)
            {
                openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                openFileDialog1.FileName = null;
            }

            // Display the openFile dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;
                try
                {
                    // Output the requested file in richTextBox1.
                    //Stream s = openFileDialog1.OpenFile();
                    //richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
                    //s.Close();

                    fileOpened = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                    + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    fileOpened = false;
                }
                Invalidate();

                //closeMenuItem.Enabled = fileOpened;
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        // Close the current file.
        private void closeMenuItem_Click(object sender, System.EventArgs e)
        {
            //richTextBox1.Text = "";
            fileOpened = false;

            //closeMenuItem.Enabled = false;
        }

        // Bring up a dialog to chose a folder path in which to open or save a file.
        private void folderMenuItem_Click(object sender, System.EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = folderName;
                    openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }
            }
        }
        */








        public int formwasloadedswtc = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            theHandle = this.Handle;
            formwasloadedswtc = 1;






            sccsr16.Form1.RECT rectmainprogram;

            rectmainprogram = new sccsr16.Form1.RECT();
            sccsr16.Form1.GetWindowRect(sccsr16.Form1.theHandle, ref rectmainprogram);

            //Console.WriteLine("Left:" + rectmainprogram.Left + "/Bottom:" + rectmainprogram.Bottom);

            if (Program.SCGLOBALSACCESSORS != null)
            {
                if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE != null)
                {



                    if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle != IntPtr.Zero)
                    {
                        var Rectsccscapturedwindow = new sccsr16.Form1.RECT();
                        //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                        sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccscapturedwindow);



                        //Console.WriteLine("Left:" + Rectsccscapturedwindow.Left + "/Bottom:" + Rectsccscapturedwindow.Bottom);



                        IntPtr id;
                        sccsr16.Form1.RECT Rect = new sccsr16.Form1.RECT();
                        //Thread.Sleep(2000);
                        /*id = sccsr16.Form1.currentform.Handle;// GetForegroundWindow();
                        Random myRandom = new Random();
                        sccsr16.Form1.GetWindowRect(id, ref Rect);
                        sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccs);
                        */

                        int screenWidth = sccsr16.Form1.GetSystemMetrics(0);
                        int screenHeight = sccsr16.Form1.GetSystemMetrics(1);




                        screenWidth = sccsr16.Form1.GetSystemMetrics(0);
                        screenHeight = sccsr16.Form1.GetSystemMetrics(1);






                        int iHandle = sccsr16.Form1.FindWindow(null, Console.Title);// "VoidExpanse");

                        //Console.WriteLine("******************************:" + iHandle + "/title:" + Console.Title);

                        //Console.WriteLine(capturedwindowname);
                        //Program.SetWindowPos(vewindowsfoundedz, (IntPtr)Program.SpecialWindowHandles.HWND_NOTOPMOST, Rectsccs.Left, Rectsccs.Top, Rectsccs.Right, Rectsccs.Bottom, (uint)Program.SetWindowPosFlags.SWP_SHOWWINDOW); //SetWindowPosFlags.SWP_SHOWWINDOW
                        //Program.SetWindowPos(vewindowsfoundedz, (IntPtr)Program.SpecialWindowHandles.HWND_NOTOPMOST, lastRectsccsformovement.Left, lastRectsccsformovement.Top, Rectsccscapturedwindow.Right, Rectsccscapturedwindow.Bottom, (uint)Program.SetWindowPosFlags.SWP_SHOWWINDOW); //SetWindowPosFlags.SWP_SHOWWINDOW


                        //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, Rectsccs.Left, Rectsccs.Top, (Rectsccs.Right - Rectsccs.Left), Rectsccs.Bottom - Rectsccs.Top, sccsr16.Form1.SWP_ASYNCWINDOWPOS);
                        //Console.SetWindowPosition(Rectsccs.Left, Rectsccs.Top);
                        //MoveWindow(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, Rectsccs.Left, Rectsccs.Top, (Rectsccs.Right - Rectsccs.Left), Rectsccs.Bottom - Rectsccs.Top,true);

                        /*
                        Console.WindowWidth = 50;
                        Console.WindowHeight = 3;
                        Console.BufferWidth = 50;
                        Console.BufferHeight = 3;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                        var width = screen.Width;
                        var height = screen.Height;

                        SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, IntPtr.Zero,100, height - 300, 500, 100);
                        */




                        //https://stackoverflow.com/questions/27715004/position-a-small-console-window-to-the-bottom-left-of-the-screen
                        /*// Get this console window's hWnd (window handle).
                        IntPtr hWnd = GetConsoleWindow();

                        // Get information about the monitor (display) that the window is (mostly) displayed on.
                        // The .rcWork field contains the monitor's work area, i.e., the usable space excluding
                        // the taskbar (and "application desktop toolbars" - see https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx)
                        var mi = MONITORINFO.Default;
                        GetMonitorInfo(MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY), ref mi);

                        // Get information about this window's current placement.
                        var wp = WINDOWPLACEMENT.Default;
                        GetWindowPlacement(hWnd, ref wp);

                        // Calculate the window's new position: lower left corner.
                        // !! Inexplicably, on W10, work-area coordinates (0,0) appear to be (7,7) pixels 
                        // !! away from the true edge of the screen / taskbar.
                        int fudgeOffset = 7;
                        wp.NormalPosition = new RECT()
                        {
                            Left = -fudgeOffset,
                            Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                            Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                            Bottom = fudgeOffset + mi.rcWork.Bottom
                        };

                        // Place the window at the new position.
                        SetWindowPlacement(hWnd, ref wp);*/






                        //https://stackoverflow.com/questions/27715004/position-a-small-console-window-to-the-bottom-left-of-the-screen
                        // Get this console window's hWnd (window handle).
                        IntPtr hWnd = GetConsoleWindow();

                        // Get information about the monitor (display) that the window is (mostly) displayed on.
                        // The .rcWork field contains the monitor's work area, i.e., the usable space excluding
                        // the taskbar (and "application desktop toolbars" - see https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx)
                        var mi = sccsr16.Form1.MONITORINFO.Default;
                        sccsr16.Form1.GetMonitorInfo(sccsr16.Form1.MonitorFromWindow(hWnd, sccsr16.Form1.MONITOR_DEFAULTTOPRIMARY), ref mi);

                        // Get information about this window's current placement.
                        var wp = sccsr16.Form1.WINDOWPLACEMENT.Default;
                        sccsr16.Form1.GetWindowPlacement(hWnd, ref wp);

                        // Calculate the window's new position: lower left corner.
                        // !! Inexplicably, on W10, work-area coordinates (0,0) appear to be (7,7) pixels 
                        // !! away from the true edge of the screen / taskbar.
                        int fudgeOffset = 7;

                        //Console.WriteLine(rectmainprogram.Left);
                        wp.NormalPosition = new sccsr16.Form1.RECT()
                        {
                            Left = rectmainprogram.Left + sccsr16.Form1.currentform.Width,// - fudgeOffset,
                            Top = rectmainprogram.Top,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                            Right = rectmainprogram.Left + sccsr16.Form1.currentform.Width + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left),
                            Bottom = (rectmainprogram.Bottom) + 600 - 400,//fudgeOffset + mi.rcWork.Bottom
                        };

                        /*wp.NormalPosition = new RECT()
                        {
                            Left = -fudgeOffset,
                            Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                            Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                            Bottom = fudgeOffset + mi.rcWork.Bottom
                        };*/

                        // Place the window at the new position.
                        sccsr16.Form1.SetWindowPlacement(hWnd, ref wp);
                    }
                }
            }


            button13.PerformClick();
        }

        /*
        internal struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }*/

        /*[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetForegroundWindow();
        */
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        internal static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        internal static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int smIndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /*[DllImport("user32.dll")]
        public static extern int FindWindow(
        string lpClassName, // class name 
        string lpWindowName // window name 
        );*/
        const int SWP_NOZORDER = 0x4;
        const int SWP_NOACTIVATE = 0x10;

        [DllImport("kernel32")]
        static extern IntPtr GetConsoleWindow();


        [DllImport("user32")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int x, int y, int cx, int cy, int flags);

        //[DllImport("kernel32.dll")]
        //static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);

        public const int MONITOR_DEFAULTTOPRIMARY = 1;

        [DllImport("user32.dll")]
        public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

        [StructLayout(LayoutKind.Sequential)]
        public struct MONITORINFO
        {
            public uint cbSize;
            public RECT rcMonitor;
            public RECT rcWork;
            public uint dwFlags;
            public static MONITORINFO Default
            {
                get { var inst = new MONITORINFO(); inst.cbSize = (uint)Marshal.SizeOf(inst); return inst; }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x, y;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPlacement(IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

        const uint SW_RESTORE = 9;

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public uint Length;
            public uint Flags;
            public uint ShowCmd;
            public POINT MinPosition;
            public POINT MaxPosition;
            public RECT NormalPosition;
            public static WINDOWPLACEMENT Default
            {
                get
                {
                    var instance = new WINDOWPLACEMENT();
                    instance.Length = (uint)Marshal.SizeOf(instance);
                    return instance;
                }
            }
        }


        [Flags]
        public enum SetWindowPosFlags : uint
        {
            // ReSharper disable InconsistentNaming

            /// <summary>
            ///     If the calling thread and the thread that owns the window are attached to different input queues, the system posts the request to the thread that owns the window. This prevents the calling thread from blocking its execution while other threads process the request.
            /// </summary>
            SWP_ASYNCWINDOWPOS = 0x4000,

            /// <summary>
            ///     Prevents generation of the WM_SYNCPAINT message.
            /// </summary>
            SWP_DEFERERASE = 0x2000,

            /// <summary>
            ///     Draws a frame (defined in the window's class description) around the window.
            /// </summary>
            SWP_DRAWFRAME = 0x0020,

            /// <summary>
            ///     Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
            /// </summary>
            SWP_FRAMECHANGED = 0x0020,

            /// <summary>
            ///     Hides the window.
            /// </summary>
            SWP_HIDEWINDOW = 0x0080,

            /// <summary>
            ///     Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).
            /// </summary>
            SWP_NOACTIVATE = 0x0010,

            /// <summary>
            ///     Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.
            /// </summary>
            SWP_NOCOPYBITS = 0x0100,

            /// <summary>
            ///     Retains the current position (ignores X and Y parameters).
            /// </summary>
            SWP_NOMOVE = 0x0002,

            /// <summary>
            ///     Does not change the owner window's position in the Z order.
            /// </summary>
            SWP_NOOWNERZORDER = 0x0200,

            /// <summary>
            ///     Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent window uncovered as a result of the window being moved. When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
            /// </summary>
            SWP_NOREDRAW = 0x0008,

            /// <summary>
            ///     Same as the SWP_NOOWNERZORDER flag.
            /// </summary>
            SWP_NOREPOSITION = 0x0200,

            /// <summary>
            ///     Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
            /// </summary>
            SWP_NOSENDCHANGING = 0x0400,

            /// <summary>
            ///     Retains the current size (ignores the cx and cy parameters).
            /// </summary>
            SWP_NOSIZE = 0x0001,

            /// <summary>
            ///     Retains the current Z order (ignores the hWndInsertAfter parameter).
            /// </summary>
            SWP_NOZORDER = 0x0004,

            /// <summary>
            ///     Displays the window.
            /// </summary>
            SWP_SHOWWINDOW = 0x0040,

            // ReSharper restore InconsistentNaming
        }
        /*
        private void ComboBox1_ChangeCommitted(object sender, System.EventArgs e)
        {
            //this.comboBox1.Size = new Size(this.comboBox1.Size.Width - 50, this.comboBox1.Size.Height);
            //this.comboBox1.Refresh();
            //Console.WriteLine("Change Committed");
        }

        private void ComboBox1_GotFocus(object sender, System.EventArgs e)
        {
            //this.comboBox1.Size = new Size(this.comboBox1.Size.Width + 50, this.comboBox1.Size.Height);
            //this.comboBox1.Refresh();

            //Console.WriteLine("Got Focus");
        }

        private void ComboBox1_LostFocus(object sender, System.EventArgs e)
        {
            //Console.WriteLine("Lost Focus");
        }*/

        private void Form1_Move(object sender, System.EventArgs e)
        {

            if (Program.SCGLOBALSACCESSORS != null)
            {
                if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE != null)
                {
                    if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle != IntPtr.Zero)
                    {

                        var rectprogram = new RECT();
                        //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                        sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);
                        lastrectl = rectprogram.Left;
                        lastrectt = rectprogram.Top;
                        lastrectrl = rectprogram.Right - rectprogram.Left;
                        lastrectbt = rectprogram.Bottom - rectprogram.Top;

                    }
                }
            }



            if (consoleshoworhide == 0 && consolestickornot == 0)
            {


                RECT rectmainprogram;

                rectmainprogram = new RECT();
                sccsr16.Form1.GetWindowRect(sccsr16.Form1.theHandle, ref rectmainprogram);



                //Console.WriteLine("Left:" + rectmainprogram.Left + "/Bottom:" + rectmainprogram.Bottom);

                if (Program.SCGLOBALSACCESSORS != null)
                {
                    if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE != null)
                    {



                        if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle != IntPtr.Zero)
                        {
                            var Rectsccscapturedwindow = new RECT();
                            //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                            sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccscapturedwindow);



                            //Console.WriteLine("Left:" + Rectsccscapturedwindow.Left + "/Bottom:" + Rectsccscapturedwindow.Bottom);



                            IntPtr id;
                            RECT Rect = new RECT();
                            //Thread.Sleep(2000);
                            /*id = sccsr16.Form1.currentform.Handle;// GetForegroundWindow();
                            Random myRandom = new Random();
                            sccsr16.Form1.GetWindowRect(id, ref Rect);
                            sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccs);
                            */

                            int screenWidth = sccsr16.Form1.GetSystemMetrics(0);
                            int screenHeight = sccsr16.Form1.GetSystemMetrics(1);




                            screenWidth = sccsr16.Form1.GetSystemMetrics(0);
                            screenHeight = sccsr16.Form1.GetSystemMetrics(1);






                            int iHandle = sccsr16.Form1.FindWindow(null, Console.Title);// "VoidExpanse");

                            //Console.WriteLine("******************************:" + iHandle + "/title:" + Console.Title);

                            //Console.WriteLine(capturedwindowname);
                            //Program.SetWindowPos(vewindowsfoundedz, (IntPtr)Program.SpecialWindowHandles.HWND_NOTOPMOST, Rectsccs.Left, Rectsccs.Top, Rectsccs.Right, Rectsccs.Bottom, (uint)Program.SetWindowPosFlags.SWP_SHOWWINDOW); //SetWindowPosFlags.SWP_SHOWWINDOW
                            //Program.SetWindowPos(vewindowsfoundedz, (IntPtr)Program.SpecialWindowHandles.HWND_NOTOPMOST, lastRectsccsformovement.Left, lastRectsccsformovement.Top, Rectsccscapturedwindow.Right, Rectsccscapturedwindow.Bottom, (uint)Program.SetWindowPosFlags.SWP_SHOWWINDOW); //SetWindowPosFlags.SWP_SHOWWINDOW


                            //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, Rectsccs.Left, Rectsccs.Top, (Rectsccs.Right - Rectsccs.Left), Rectsccs.Bottom - Rectsccs.Top, sccsr16.Form1.SWP_ASYNCWINDOWPOS);
                            //Console.SetWindowPosition(Rectsccs.Left, Rectsccs.Top);
                            //MoveWindow(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, Rectsccs.Left, Rectsccs.Top, (Rectsccs.Right - Rectsccs.Left), Rectsccs.Bottom - Rectsccs.Top,true);

                            /*
                            Console.WindowWidth = 50;
                            Console.WindowHeight = 3;
                            Console.BufferWidth = 50;
                            Console.BufferHeight = 3;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                            var width = screen.Width;
                            var height = screen.Height;

                            SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, IntPtr.Zero,100, height - 300, 500, 100);
                            */




                            //https://stackoverflow.com/questions/27715004/position-a-small-console-window-to-the-bottom-left-of-the-screen
                            /*// Get this console window's hWnd (window handle).
                            IntPtr hWnd = GetConsoleWindow();

                            // Get information about the monitor (display) that the window is (mostly) displayed on.
                            // The .rcWork field contains the monitor's work area, i.e., the usable space excluding
                            // the taskbar (and "application desktop toolbars" - see https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx)
                            var mi = MONITORINFO.Default;
                            GetMonitorInfo(MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY), ref mi);

                            // Get information about this window's current placement.
                            var wp = WINDOWPLACEMENT.Default;
                            GetWindowPlacement(hWnd, ref wp);

                            // Calculate the window's new position: lower left corner.
                            // !! Inexplicably, on W10, work-area coordinates (0,0) appear to be (7,7) pixels 
                            // !! away from the true edge of the screen / taskbar.
                            int fudgeOffset = 7;
                            wp.NormalPosition = new RECT()
                            {
                                Left = -fudgeOffset,
                                Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                                Bottom = fudgeOffset + mi.rcWork.Bottom
                            };

                            // Place the window at the new position.
                            SetWindowPlacement(hWnd, ref wp);*/






                            //https://stackoverflow.com/questions/27715004/position-a-small-console-window-to-the-bottom-left-of-the-screen
                            // Get this console window's hWnd (window handle).
                            IntPtr hWnd = GetConsoleWindow();

                            // Get information about the monitor (display) that the window is (mostly) displayed on.
                            // The .rcWork field contains the monitor's work area, i.e., the usable space excluding
                            // the taskbar (and "application desktop toolbars" - see https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx)
                            var mi = MONITORINFO.Default;
                            GetMonitorInfo(MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY), ref mi);

                            // Get information about this window's current placement.
                            var wp = WINDOWPLACEMENT.Default;
                            GetWindowPlacement(hWnd, ref wp);

                            // Calculate the window's new position: lower left corner.
                            // !! Inexplicably, on W10, work-area coordinates (0,0) appear to be (7,7) pixels 
                            // !! away from the true edge of the screen / taskbar.
                            int fudgeOffset = 7;

                            if (maindocksidetype == 0)
                            {
                                //Console.WriteLine(rectmainprogram.Left);
                                wp.NormalPosition = new RECT()
                                {
                                    Left = rectmainprogram.Left,// - fudgeOffset,
                                    Top = rectmainprogram.Top - sccsr16.Form1.currentform.Height - 200,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                    Right = rectmainprogram.Left + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left), //+ sccsr16.Form1.currentform.Width + 800
                                    Bottom = (rectmainprogram.Top),//fudgeOffset + mi.rcWork.Bottom
                                };
                            }
                            else if (maindocksidetype == 1)
                            {
                                //Console.WriteLine(rectmainprogram.Left);
                                wp.NormalPosition = new RECT()
                                {
                                    Left = rectmainprogram.Left + sccsr16.Form1.currentform.Width,// - fudgeOffset,
                                    Top = rectmainprogram.Top,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                    Right = rectmainprogram.Left + sccsr16.Form1.currentform.Width + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left),
                                    Bottom = (rectmainprogram.Bottom) + 600 - 400,//fudgeOffset + mi.rcWork.Bottom
                                };
                            }
                            else if (maindocksidetype == 2)
                            {
                                //Console.WriteLine(rectmainprogram.Left);
                                wp.NormalPosition = new RECT()
                                {
                                    Left = rectmainprogram.Left,// - fudgeOffset,
                                    Top = rectmainprogram.Top + sccsr16.Form1.currentform.Height,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                    Right = rectmainprogram.Left + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left), //+ sccsr16.Form1.currentform.Width + 800
                                    Bottom = (rectmainprogram.Bottom) + 600,//fudgeOffset + mi.rcWork.Bottom
                                };
                            }
                            else if (maindocksidetype == 3)
                            {
                                //Console.WriteLine(rectmainprogram.Left);
                                wp.NormalPosition = new RECT()
                                {
                                    Left = rectmainprogram.Left - sccsr16.Form1.currentform.Width - 800 + 200,// - fudgeOffset,
                                    Top = rectmainprogram.Top,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                    Right = rectmainprogram.Left, //(wp.NormalPosition.Right - wp.NormalPosition.Left),
                                    Bottom = (rectmainprogram.Bottom) + 600 - 400,//fudgeOffset + mi.rcWork.Bottom
                                };
                            }

                            var rectprogram = new RECT();

                            rectprogram.Left = wp.NormalPosition.Left;
                            rectprogram.Top = wp.NormalPosition.Top;
                            rectprogram.Right = wp.NormalPosition.Right;
                            rectprogram.Bottom = wp.NormalPosition.Bottom;

                            /*wp.NormalPosition = new RECT()
                            {
                                Left = -fudgeOffset,
                                Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                                Bottom = fudgeOffset + mi.rcWork.Bottom
                            };*/

                            // Place the window at the new position.
                            //SetWindowPlacement(hWnd, ref wp);


                            //var rectprogram = new RECT();
                            //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                            //sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);

                            //ALTHOUGH THIS PROGRAM ISN'T SET TO GO UNDERNEATH ANOTHER WINDOW, THE FACT THAT A CALL TO SWP_SHOWWINDOW|NOACTIVATE IS DONE MAKES SOMEHOW THE WINDOWS FORMS NOT BE TOPMOST ANYMORE WHICH IS BENEFICIAL WHERE NO CALLS TO NOTOPMOST NEEDS TO BE DONE TO THE WINDOWS FORMS AS IT ALREADY ISN'T TOPMOST ANYMORE. FOR SOME REASONS...
                            //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW);
                            sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW | SWP_NOACTIVATE);


                        }
                    }
                }
            }
        }

        const int SW_HIDE = 0;
        const int SW_SHOWNORMAL = 1;
        const int SW_NORMAL = 1;
        const int SW_SHOWMINIMIZED = 2;
        const int SW_SHOWMAXIMIZED = 3;
        const int SW_MAXIMIZE = 3;
        const int SW_SHOWNOACTIVATE = 4;
        const int SW_SHOW = 5;
        const int SW_MINIMIZE = 6;
        const int SW_SHOWMINNOACTIVE = 7;
        const int SW_SHOWNA = 8;
        //const int SW_RESTORE = 9;
        const int SW_SHOWDEFAULT = 10;
        const int SW_FORCEMINIMIZE = 11;
        const int SW_MAX = 11;
        public const UInt32 SWP_NOSIZE = 0x0001;
        public const UInt32 SWP_NOMOVE = 0x0002;
        //public const UInt32 SWP_NOZORDER = 0x0004;
        public const UInt32 SWP_NOREDRAW = 0x0008;
        //public const UInt32 SWP_NOACTIVATE = 0x0010;
        //public const UInt32 SWP_FRAMECHANGED = 0x0020;
        public const UInt32 SWP_SHOWWINDOW = 0x0040;
        public const UInt32 SWP_HIDEWINDOW = 0x0080;
        public const UInt32 SWP_NOCOPYBITS = 0x0100;
        public const UInt32 SWP_NOOWNERZORDER = 0x0200;
        public const UInt32 SWP_NOSENDCHANGING = 0x0400;
        //public const UInt32 SWP_DRAWFRAME = SWP_FRAMECHANGED;
        public const UInt32 SWP_NOREPOSITION = SWP_NOOWNERZORDER;

        public const UInt32 SWP_DEFERERASE = 0x2000;
        public const UInt32 SWP_ASYNCWINDOWPOS = 0x4000;
        /// <summary>
        ///     Special window handles
        /// </summary>
        public enum SpecialWindowHandles
        {
            // ReSharper disable InconsistentNaming
            /// <summary>
            ///     Places the window at the top of the Z order.
            /// </summary>
            HWND_TOP = 0,
            /// <summary>
            ///     Places the window at the bottom of the Z order. If the hWnd parameter identifies a topmost window, the window loses its topmost status and is placed at the bottom of all other windows.
            /// </summary>
            HWND_BOTTOM = 1,
            /// <summary>
            ///     Places the window above all non-topmost windows. The window maintains its topmost position even when it is deactivated.
            /// </summary>
            HWND_TOPMOST = -1,
            /// <summary>
            ///     Places the window above all non-topmost windows (that is, behind all topmost windows). This flag has no effect if the window is already a non-topmost window.
            /// </summary>
            HWND_NOTOPMOST = -2
            // ReSharper restore InconsistentNaming
        }





        public IntPtr theconsolehandle;


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;
        private const UInt32 SC_CLOSE = 0xF060;
        private const UInt32 WM_SYSCOMMAND = 0x0112;


        void CloseWindow(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }


        [DllImport("user32.dll")]
        public static extern int SendMessage(
      int hWnd, // handle to destination window 
      uint Msg, // message 
      int wParam, // first message parameter 
      int lParam // second message parameter 
  );


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg,
           IntPtr wParam, IntPtr lParam);


        /*[DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd,
                           UInt32 Msg,
                           IntPtr wParam,
                           IntPtr lParam);*/


        /*[DllImport("User32.dll", EntryPoint = "SendMessage", SetLastError = true)]
        //private static extern Int32 SendMessageByString(IntPtr hwnd, UInt32 msg, Int32 WParam, StringBuilder output);
        private static extern Int32 SendMessageByString(IntPtr hwnd, uint msg, Int32 WParam, StringBuilder output);
        const int WM_GETTEXTLENGTH = 0x000e;
        const int WM_GETTEXT = 0x000d;

        public static string GetText(int lparam)
        {
            int len = SendMessageByString(Program.vewindowsfoundedz, WM_GETTEXTLENGTH, 0, null);
            var sb = new StringBuilder(len + 1);
            //sb.Append(lparam.ToString());

            SendMessageByString(Program.vewindowsfoundedz, WM_LBUTTONDOWN, sb.Capacity, sb);
            SendMessageByString(Program.vewindowsfoundedz, WM_LBUTTONUP, sb.Capacity, sb);
            //SendMessageByString(Program.vewindowsfoundedz, WM_GETTEXT,sb.Capacity,sb);
            return sb.ToString();
        }*/


        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);



        //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closing?view=windowsdesktop-7.0
        private void Form1_Closed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;


            int endthread0 = 0;

            var maincopythread = new Thread((tester0000) =>
            {
            _thread_main_loop:

                if (sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 == 2)
                {
                    CloseWindow(sccsr16.Form1.currentform.theconsolehandle);

                    endthread0 = 1;

                    int iHandle = FindWindow(null, Console.Title);

                    SendMessage(iHandle, 0x0010, 0, 0);


                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                    var process = System.Diagnostics.Process.GetCurrentProcess();

                    process.Kill();
                    process.Dispose();


                    sccsr16.Form1.currentform.Close();
                    sccsr16.Form1.currentform.Dispose();

                    //InputSimulator inputsim = new InputSimulator();
                    //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim = null;

                    System.Environment.Exit(1);

                    System.Environment.Exit(0);


                    //sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;



                    /*Program.OnProcessExit();
                    //CloseWindow(theconsolehandle);


                    Program.CloseWindow(theconsolehandle);
                    Application.Exit();
                    
                    var theprocess = Process.GetCurrentProcess();

                    theprocess.CloseMainWindow();
                    //theprocess.Close();
                    //theprocess.WaitForExit();

                    

                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                    var process = System.Diagnostics.Process.GetCurrentProcess();

                    process.Kill();
                    process.Dispose();


                    sccsr16.Form1.currentform.Close();
                    sccsr16.Form1.currentform.Dispose();

                    //InputSimulator inputsim = new InputSimulator();
                    //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim = null;

                    System.Environment.Exit(1);

                    System.Environment.Exit(0);


                    int iHandle = FindWindow(null, Console.Title);


                    Program.MessageBox((IntPtr)0, "iHandle:" + iHandle, "sccsmsg", 0);

                    SendMessage(iHandle, 0x0010, 0, 0);*/
                    endthread0 = 1;
                }





                if (endthread0 == 0)
                {
                    Thread.Sleep(1);

                    goto _thread_main_loop;
                }
                else
                {
                    //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);

                }

            }, 0); //100000 //999999999

            maincopythread.IsBackground = true;
            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
            maincopythread.SetApartmentState(ApartmentState.STA);
            maincopythread.Start();

            //maincopythread.Join();
        }



        //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closing?view=windowsdesktop-7.0
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;


            int endthread0 = 0;

            var maincopythread = new Thread((tester0000) =>
            {
            _thread_main_loop:

                if (sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 == 2)
                {

                    CloseWindow(theconsolehandle);
                    endthread0 = 1;

                    int iHandle = FindWindow(null, Console.Title);

                    SendMessage(iHandle, 0x0010, 0, 0);


                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                    var process = System.Diagnostics.Process.GetCurrentProcess();

                    process.Kill();
                    process.Dispose();


                    sccsr16.Form1.currentform.Close();
                    sccsr16.Form1.currentform.Dispose();

                    //InputSimulator inputsim = new InputSimulator();
                    //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim = null;

                    System.Environment.Exit(1);

                    System.Environment.Exit(0);









                    /*
                    Program.OnProcessExit();
                    //CloseWindow(theconsolehandle);


                    Program.CloseWindow(theconsolehandle);
                    Application.Exit();

                    var theprocess = Process.GetCurrentProcess();

                    theprocess.CloseMainWindow();
                    //theprocess.Close();
                    //theprocess.WaitForExit();


                    
                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                    var process = System.Diagnostics.Process.GetCurrentProcess();

                    process.Kill();
                    process.Dispose();


                    sccsr16.Form1.currentform.Close();
                    sccsr16.Form1.currentform.Dispose();

                    //InputSimulator inputsim = new InputSimulator();
                    //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim = null;

                    System.Environment.Exit(1);

                    System.Environment.Exit(0);


                    int iHandle = FindWindow(null, Console.Title);


                    Program.MessageBox((IntPtr)0, "iHandle:" + iHandle, "sccsmsg", 0);

                    SendMessage(iHandle, 0x0010, 0, 0);*/

                    endthread0 = 1;
                }





                if (endthread0 == 0)
                {
                    Thread.Sleep(1);

                    goto _thread_main_loop;
                }
                else
                {
                    //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);

                }

            }, 0); //100000 //999999999

            maincopythread.IsBackground = true;
            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
            maincopythread.SetApartmentState(ApartmentState.STA);
            maincopythread.Start();

            //maincopythread.Join();

        }

        //public int startmultiplicationprocessmainswtc = 0;


        public int startmultiplicationprocessthreadswtc = -1;
        public int startmultiplicationprocesslistenswtc = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            //startmultiplicationprocessmainswtc = 1;
            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 0;
            sccs.sccsgraphicssec.currentsccsgraphicssec.startmultiplicationprocessswtc = 1;
            sccs.sccsgraphicssec.currentsccsgraphicssec.startmultiplicationprocess();
            startmultiplicationprocesslistenswtc = 1;
            //startmultiplicationprocessthreadswtc = 1;
            button1.Enabled = false;
        }





        //DELETE BUTTON
        //DELETE BUTTON
        //DELETE BUTTON

        public int button2swtc = -1;
        //public int indexofdeleteoptiontype = 0;
        public int deletemethodstartedornotmuls = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //button20.Enabled = false;

            //indexofdeleteoptiontype = indexofdeleteoptiontype;

            deletemethodstartedornotmuls = 1;
            //button20.Enabled = false;
            button2swtc = 1;
            /*
            Stopwatch thetimer = new Stopwatch();
            thetimer.Start();
            //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
            //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");
            var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
            itsalmostastack<string> dirs1last = new itsalmostastack<string>();
            string pathtomods = "";
            int counttheproblem = 0;
            int mainninesmodsfoldercounter = 0;

            */

            if (indexofdeleteoptiontype == 2)
            {
                Stopwatch thetimer = new Stopwatch();
                thetimer.Start();

                //var dirinfo = Directory.GetCurrentDirectory();

                //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));
                //List<string> dirs1last = new List<string>();
                itsalmostastack<string> dirs1last = new itsalmostastack<string>();
                //itsalmostastack<string> dirs2last = new itsalmostastack<string>();

                List<string> dirs2lastlist = new List<string>();

                List<string> dirs2 = new List<string>();

                string pathtomods = "";

                int counttheproblem = 0;

                int mainninesmodsfoldercounter = 0;

                foreach (var dir in dirs)
                {
                    DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                    directoryFolder0.Refresh();

                    string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    if (foldername.ToLower() == "#cryofallscriptgen")
                    {
                        pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

                        dirs1last.Push(pathtomods);

                        int counter = 0;

                        int endthread0 = 0;
                        var maincopythread = new Thread((tester0000) =>
                        {
                            int folderiteratormainlast = -1;
                            int folderiteratormain = 0;
                            int folderiteratorsec = 0;
                            int folderiteratorseclast = -1;

                            string thecurrentpathlast = "";
                            List<string> dirs1 = null;
                            string[] arrayoffiles = null;
                            string foldername2 = "";
                            itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                            string thepathtocopyfolder = "";

                            int listoffilescounter = 0;
                            int listoffilesorigincount = 0;

                            int dirs1count = 0;
                            int disr1swtc = 0;

                            int folderiteratorsecswtc = 0;
                            DirectoryInfo directoryFolder;
                            string poppedstring = "";
                            string anotherpath = "";
                            string ateststring = "";
                            string thecopiedfilepath = "";
                            string thefinalpath = "";
                            string thecurrentpath = "";
                            string foldername1 = "";
                            int deletingfilecounter = 0;

                        _thread_main_loop:

                            for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count //dirs1last.Count
                            {
                                if (dirs1last.Count <= 0)
                                {
                                    Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                }

                                if (dirs1last.Count > 0)
                                {

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                        folderiteratormain = 0;
                                    }

                                    thecurrentpath = dirs1last.Peek(folderiteratormain);

                                    if (Directory.Exists(thecurrentpath))
                                    {
                                        if (disr1swtc == 0)
                                        {
                                            dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                            dirs1count = dirs1.Count;
                                            disr1swtc = 1;
                                        }

                                        thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                        if (dirs1count > 0)
                                        {
                                            foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                            thefinalpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;

                                            directoryFolder = new DirectoryInfo(thefinalpath);
                                            directoryFolder.Refresh();

                                            if (Directory.Exists(thefinalpath))
                                            {
                                                dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                            }

                                            if (folderiteratorsecswtc == 0)
                                            {
                                                deletingfilecounter = 0;
                                                arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                listoffilesorigincount = arrayoffiles.Length;
                                                folderiteratorsecswtc = 1;
                                            }

                                            if (folderiteratorsecswtc == 1)
                                            {
                                                if (arrayoffiles != null)
                                                {
                                                    if (arrayoffiles.Length > 0)
                                                    {
                                                        if (arrayoffiles[listoffilescounter] != null)
                                                        {
                                                            poppedstring = arrayoffiles[listoffilescounter];
                                                            anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                            ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                            thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                            if (File.Exists(thecopiedfilepath))
                                                            {
                                                                File.Delete(thecopiedfilepath);
                                                            }
                                                            deletingfilecounter++;
                                                            arrayoffiles[listoffilescounter] = null;
                                                        }
                                                        listoffilescounter++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (listoffilescounter >= listoffilesorigincount)
                                {


                                    folderiteratorsec++;
                                    folderiteratorsecswtc = 0;
                                    listoffilescounter = 0;
                                }

                                if (folderiteratorsec >= dirs1count)
                                {
                                    disr1swtc = 0;
                                    folderiteratormain++;
                                    folderiteratorsec = 0;
                                }

                                if (dirs1last != null)
                                {
                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                            }

                            if (endthread0 == 0)
                            {
                                Thread.Sleep(1);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                {
                                    var poppedvalue = dirs1last.Pop();

                                    if (poppedvalue != "multiplied")
                                    {


                                        if (Directory.Exists(poppedvalue))
                                        {
                                            var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                            if (currentdirsinfolder != null)
                                            {
                                                if (currentdirsinfolder.Count == 0)
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                                else
                                                {
                                                    for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                    {

                                                        if (currentdirsinfolder[i] != "multiplied")
                                                        {
                                                            var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                            var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                            if (folderemptyornot == null)
                                                            {
                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (folderemptyornot.Length > 0)
                                                                {

                                                                }
                                                                else
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (Directory.Exists(poppedvalue))
                                                {
                                                    Directory.Delete(poppedvalue);
                                                }
                                            }
                                        }
                                    }
                                }


                                /*
                                for (int fo = dirs2lastlist.Count - 1; fo >= 0; fo--)
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/

                                /*
                                for (int fo = 0; fo < dirs2lastlist.Count; fo++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/


                                if (listoffiles != null)
                                {
                                    listoffiles.Clear();
                                    listoffiles = null;
                                }

                                if (dirs1 != null)
                                {
                                    dirs1.Clear();
                                    dirs1 = null;
                                }

                                arrayoffiles = null;

                                if (dirs1last != null)
                                {
                                    dirs1last.Clear();
                                    dirs1last = null;
                                }

                                deletemethodstartedornotmuls = 2;
                                thetimer.Stop();
                                Console.WriteLine("end of delete files. timer:" + thetimer.Elapsed.TotalSeconds);
                                //Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
                            }

                        }, 0); //100000 //999999999

                        maincopythread.IsBackground = true;
                        maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                        maincopythread.SetApartmentState(ApartmentState.STA);
                        maincopythread.Start();

                        break;
                    }
                }
            }
            else if (indexofdeleteoptiontype == 1)
            {

                Stopwatch thetimer = new Stopwatch();
                thetimer.Start();

                Console.WriteLine("start of delete files in mul. timer:" + thetimer.Elapsed.TotalSeconds);

                //var dirinfo = Directory.GetCurrentDirectory();

                //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));
                //List<string> dirs1last = new List<string>();
                itsalmostastack<string> dirs1last = new itsalmostastack<string>();
                //itsalmostastack<string> dirs2last = new itsalmostastack<string>();

                List<string> dirs2lastlist = new List<string>();

                List<string> dirs2 = new List<string>();

                string pathtomods = "";

                int counttheproblem = 0;

                int mainninesmodsfoldercounter = 0;

                foreach (var dir in dirs)
                {
                    DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                    directoryFolder0.Refresh();

                    string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    if (foldername.ToLower() == "#cryofallscriptgen")
                    {
                        pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

                        dirs1last.Push(pathtomods);

                        int counter = 0;

                        int endthread0 = 0;
                        var maincopythread = new Thread((tester0000) =>
                        {
                            int folderiteratormainlast = -1;
                            int folderiteratormain = 0;
                            int folderiteratorsec = 0;
                            int folderiteratorseclast = -1;

                            string thecurrentpathlast = "";
                            List<string> dirs1 = null;
                            string[] arrayoffiles = null;
                            string foldername2 = "";
                            itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                            string thepathtocopyfolder = "";

                            int listoffilescounter = 0;
                            int listoffilesorigincount = 0;

                            int dirs1count = 0;
                            int disr1swtc = 0;

                            int folderiteratorsecswtc = 0;
                            DirectoryInfo directoryFolder;
                            string poppedstring = "";
                            string anotherpath = "";
                            string ateststring = "";
                            string thecopiedfilepath = "";
                            string thefinalpath = "";
                            string thecurrentpath = "";
                            string foldername1 = "";
                            int deletingfilecounter = 0;

                        _thread_main_loop:

                            for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count //dirs1last.Count
                            {
                                if (dirs1last.Count <= 0)
                                {
                                    Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                }

                                if (dirs1last.Count > 0)
                                {

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                        folderiteratormain = 0;
                                    }

                                    thecurrentpath = dirs1last.Peek(folderiteratormain);

                                    if (Directory.Exists(thecurrentpath))
                                    {
                                        if (disr1swtc == 0)
                                        {
                                            dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                            dirs1count = dirs1.Count;
                                            disr1swtc = 1;
                                        }

                                        thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                        if (dirs1count > 0)
                                        {
                                            foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                            thefinalpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;

                                            directoryFolder = new DirectoryInfo(thefinalpath);
                                            directoryFolder.Refresh();

                                            if (Directory.Exists(thefinalpath))
                                            {
                                                dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                            }

                                            if (folderiteratorsecswtc == 0)
                                            {
                                                deletingfilecounter = 0;
                                                arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                listoffilesorigincount = arrayoffiles.Length;
                                                folderiteratorsecswtc = 1;
                                            }

                                            if (folderiteratorsecswtc == 1)
                                            {
                                                if (arrayoffiles != null)
                                                {
                                                    if (arrayoffiles.Length > 0)
                                                    {
                                                        if (arrayoffiles[listoffilescounter] != null)
                                                        {
                                                            poppedstring = arrayoffiles[listoffilescounter];
                                                            anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                            ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                            thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                            if (File.Exists(thecopiedfilepath))
                                                            {
                                                                File.Delete(thecopiedfilepath);
                                                            }
                                                            deletingfilecounter++;
                                                            arrayoffiles[listoffilescounter] = null;
                                                        }
                                                        listoffilescounter++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (listoffilescounter >= listoffilesorigincount)
                                {


                                    folderiteratorsec++;
                                    folderiteratorsecswtc = 0;
                                    listoffilescounter = 0;
                                }

                                if (folderiteratorsec >= dirs1count)
                                {
                                    disr1swtc = 0;
                                    folderiteratormain++;
                                    folderiteratorsec = 0;
                                }

                                if (dirs1last != null)
                                {
                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                            }

                            if (endthread0 == 0)
                            {
                                Thread.Sleep(0);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                Console.WriteLine("end of delete files in mul. timer:" + thetimer.Elapsed.TotalSeconds);
                                Console.WriteLine("start of delete folders in mul. timer:" + thetimer.Elapsed.TotalSeconds);

                                for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                {
                                    var poppedvalue = dirs1last.Pop();

                                    if (poppedvalue != "multiplied")
                                    {


                                        if (Directory.Exists(poppedvalue))
                                        {
                                            var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                            if (currentdirsinfolder != null)
                                            {
                                                if (currentdirsinfolder.Count == 0)
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                                else
                                                {
                                                    for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                    {

                                                        if (currentdirsinfolder[i] != "multiplied")
                                                        {
                                                            var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                            var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                            if (folderemptyornot == null)
                                                            {
                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (folderemptyornot.Length > 0)
                                                                {

                                                                }
                                                                else
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (Directory.Exists(poppedvalue))
                                                {
                                                    Directory.Delete(poppedvalue);
                                                }
                                            }
                                        }
                                    }
                                }

                                /*
                                for (int fo = dirs2lastlist.Count - 1; fo >= 0; fo--)
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/

                                /*
                                for (int fo = 0; fo < dirs2lastlist.Count; fo++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/


                                if (listoffiles != null)
                                {
                                    listoffiles.Clear();
                                    listoffiles = null;
                                }

                                if (dirs1 != null)
                                {
                                    dirs1.Clear();
                                    dirs1 = null;
                                }

                                arrayoffiles = null;

                                if (dirs1last != null)
                                {
                                    dirs1last.Clear();
                                    dirs1last = null;
                                }

                                deletemethodstartedornotmuls = 2;
                                thetimer.Stop();
                                Console.WriteLine("end of delete folders in mul. timer:" + thetimer.Elapsed.TotalSeconds);
                                //Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
                            }

                        }, 0); //100000 //999999999

                        maincopythread.IsBackground = true;
                        maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                        maincopythread.SetApartmentState(ApartmentState.STA);
                        maincopythread.Start();

                        break;
                    }
                }
            }
            else if (indexofdeleteoptiontype == 0)
            {

                Stopwatch thetimer = new Stopwatch();
                thetimer.Start();

                //var dirinfo = Directory.GetCurrentDirectory();

                //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));
                //List<string> dirs1last = new List<string>();
                itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                List<string> dirs2last = new List<string>();

                List<string> dirs2 = new List<string>();

                string pathtomods = "";

                int counttheproblem = 0;

                int mainninesmodsfoldercounter = 0;





                foreach (var dir in dirs)
                {
                    DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                    directoryFolder0.Refresh();

                    string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    if (foldername.ToLower() == "#cryofallscriptgen")
                    {
                        pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

                        //dirs1last.Add(pathtomods);
                        dirs1last.Push(pathtomods);

                        int counter = 0;

                        //while (dirs1last.Count > 0) //while there are folders and files
                        //{
                        int endthread0 = 0;
                        var maincopythread = new Thread((tester0000) =>
                        {
                        _thread_main_loop:

                            if (dirs1last.Count > 0)
                            {
                                //for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                                for (int fo = 0; fo < dirs1last.Count; fo++)
                                {
                                    string thecurrentpath = dirs1last.Peek(fo);

                                    if (dirs1last.Count > 0)
                                    {
                                        string foldername1 = $"{thecurrentpath.Substring(thecurrentpath.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));

                                            foreach (var dir1 in dirs1)
                                            {
                                                DirectoryInfo directoryFolder = new DirectoryInfo(dir1);
                                                directoryFolder.Refresh();

                                                //Console.WriteLine(dir1);
                                                string foldername2 = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                //Console.WriteLine(foldername2);

                                                var arrayoffiles = Directory.GetFiles(dir1);

                                                //Console.WriteLine(arrayoffiles.Length);


                                                if (arrayoffiles != null && arrayoffiles.Length > 0)
                                                {
                                                    for (int f = 0; f < arrayoffiles.Length; f++)
                                                    {
                                                        File.Delete(arrayoffiles[f]);
                                                    }
                                                }
                                                else
                                                {

                                                }

                                                if (foldername2.ToLower() != "multiplied")
                                                {

                                                    dirs2last.Add(thecurrentpath + @"\" + foldername2);
                                                    //dirs1last.Add(thecurrentpath + @"\" + foldername2);
                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);

                                                    //astack.Push(dirs1last[fo] + @"\" + foldername2);

                                                    //Console.WriteLine(dirs1last[fo]);
                                                    //Console.WriteLine("counttheproblem:" + counttheproblem);
                                                    /*if (dirs1last.Count > 0 && fo >= 0)
                                                    {

                                                    }*/

                                                    counttheproblem++;
                                                }
                                            }
                                        }
                                        //break;

                                    }
                                }





                                //for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                                for (int fo = 0; fo < dirs1last.Count; fo++)
                                {
                                    string thecurrentpath = dirs1last.Peek(fo);


                                    if (dirs1last.Count > 0)
                                    {
                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            string foldername1 = $"{thecurrentpath.Substring(thecurrentpath.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                                            List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));

                                            foreach (var dir1 in dirs1)
                                            {
                                                //Console.WriteLine(dir1);
                                                string foldername2 = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                //Console.WriteLine(foldername2);

                                                DirectoryInfo directoryFolder = new DirectoryInfo(dir1);
                                                directoryFolder.Refresh();

                                                var arrayoffiles = Directory.GetFiles(dir1);

                                                if (arrayoffiles == null || arrayoffiles.Length == 0)
                                                {
                                                    if (dirs1last.Count > 0 && fo >= 0)
                                                    {
                                                        //Console.WriteLine("popping");
                                                        dirs1last.Pop();

                                                        //dirs1last.RemoveAt(fo);
                                                        //dirs1last[fo]
                                                        //continue;
                                                        //dirs1last.Remove(dirs1last[fo]);
                                                        //dirs1last.RemoveAt(dirs1last.Count-1);
                                                    }
                                                    //Directory.Delete(dir1);
                                                }
                                            }

                                        }
                                        else
                                        {
                                            //dirs1last.Pop();
                                        }
                                        //break;
                                    }
                                }
                                //NOT WORKING. CANNOT REMOVE FROM LIST. MAYBE USE ITSALMOSTASTACK



                                for (int fo = dirs2last.Count - 1; fo >= 0; fo--)
                                {
                                    if (Directory.Exists(dirs2last[fo]))
                                    {
                                        Directory.Delete(dirs2last[fo]);
                                        dirs2last.Remove(dirs2last[fo]);
                                    }
                                }

                                counter++;
                            }

                            //Console.WriteLine(dirs1last.Count);

                            if (dirs2last.Count <= 0)
                            {
                                //Console.WriteLine("dirs1last.Count:" + dirs1last.Count);
                                endthread0 = 1;
                            }

                            if (dirs1last.Count <= 0)
                            {
                                endthread0 = 1;
                            }
                            else if (dirs1last.Count == 1)
                            {
                                var thepath = dirs1last.Pop();
                                var arrayoffiles = Directory.GetFiles(thepath);

                                if (arrayoffiles == null || arrayoffiles.Length <= 0)
                                {
                                    endthread0 = 1;
                                }
                            }

                            if (endthread0 == 0)
                            {
                                Thread.Sleep(1);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                deletemethodstartedornotmuls = 2;
                                thetimer.Stop();
                                Console.WriteLine("end of delete files. timer:" + thetimer.Elapsed.TotalSeconds);

                                //Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
                                //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);
                            }

                        }, 0); //100000 //999999999

                        maincopythread.IsBackground = true;
                        maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                        maincopythread.SetApartmentState(ApartmentState.STA);
                        maincopythread.Start();

                        break;
                    }
                }

            }
            //button20.Enabled = true;

        }
        //DELETE BUTTON
        //DELETE BUTTON
        //DELETE BUTTON





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {

            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=windowsdesktop-7.0
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog5 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog5.Description = "Select the directory that you want to use as the default.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog5.ShowNewFolderButton = false;
            // Default to the My Documents folder.
            this.folderBrowserDialog5.RootFolder = Environment.SpecialFolder.Personal;
            // Show the FolderBrowserDialog.

            var dirinfom = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
            string thepaththisprogramulfolder = dirinfom.FullName + @"\" + "#Cryofallscriptgen" + @"\" + "multiplied";


            DialogResult result = folderBrowserDialog5.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialog5.SelectedPath == null || folderBrowserDialog5.SelectedPath == "" || folderBrowserDialog5.SelectedPath == string.Empty)
                {
                    folderBrowserDialog5.SelectedPath = thepaththisprogramulfolder;
                    theselectedfoldermovein = folderBrowserDialog5.SelectedPath;// Environment.GetFolderPath(Environment.SpecialFolder.Personal);//this.folderBrowserDialog5.RootFolder.ToString();
                }
                else
                {
                    theselectedfoldermovein = folderBrowserDialog5.SelectedPath;
                }

                /*if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = theselectedfolderin;
                    openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }*/
                button3.BackColor = System.Drawing.Color.Green;
                button3.Refresh();
            }
            else
            {
                theselectedfoldermovein = "";
                button3.BackColor = System.Drawing.Color.Red;
                button3.Refresh();
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();

            if (listBox1.Items != null)
            {
                listBox1.Items.Clear();
            }

            /*//https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// Environment.SpecialFolder.MyDocuments);
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));

            int mainninesmodsfoldercounter = 0;
            foreach (var dir in dirs)
            {
                string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                if (foldername.ToLower() == "atomictorchstudio")
                {
                    string pathtomods = docPath + @"\" +foldername + @"\" + "CryoFall\\Mods";

                    List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));
                    
                    foreach (var dir1 in dirs1)
                    {
                        string modmpkname = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                        listBox1.Items.Add(modmpkname);
                    }
                }
            }*/


            /*
            //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));

            int mainninesmodsfoldercounter = 0;
            foreach (var dir in dirs)
            {
                string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                if (foldername.ToLower() == "#cryofallscriptgen")
                {
                    //string pathtomods = docPath + @"\" + foldername + @"\" + "CryoFall\\Mods";

                    string pathtomods = docPath + @"\" + foldername + @"\"+ "original";

                    List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));

                    foreach (var dir1 in dirs1)
                    {
                        string modmpkname = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                        listBox1.Items.Add(modmpkname);
                    }
                }
            }*/


            var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

            //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));

            int mainninesmodsfoldercounter = 0;
            foreach (var dir in dirs)
            {
                string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                if (foldername.ToLower() == "#cryofallscriptgen")
                {
                    //string pathtomods = docPath + @"\" + foldername + @"\" + "CryoFall\\Mods";

                    string pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "original";

                    List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));

                    foreach (var dir1 in dirs1)
                    {
                        string modmpkname = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                        listBox1.Items.Add(modmpkname);
                    }
                }
            }

            Console.WriteLine(dirinfo.FullName);

            listBox1.EndUpdate();

        }


        //private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;

        int fastorslowcopy = 0;



        string theselectedfolderin = "";


        private void button4_Click(object sender, EventArgs e)
        {


            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=windowsdesktop-7.0
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog1.Description = "Select the directory that you want to use as the default.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // Default to the My Documents folder.
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            // Show the FolderBrowserDialog.

            var dirinfom = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
            string thepaththisprogramulfolder = dirinfom.FullName + @"\" + "#Cryofallscriptgen" + @"\" + "multiplied";


            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath == null || folderBrowserDialog1.SelectedPath == "" || folderBrowserDialog1.SelectedPath == string.Empty)
                {
                    folderBrowserDialog1.SelectedPath = thepaththisprogramulfolder;
                    theselectedfolderin = folderBrowserDialog1.SelectedPath;// Environment.GetFolderPath(Environment.SpecialFolder.Personal);//this.folderBrowserDialog1.RootFolder.ToString();
                }
                else
                {
                    theselectedfolderin = folderBrowserDialog1.SelectedPath;
                }

                /*if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = theselectedfolderin;
                    openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }*/

                button4.BackColor = System.Drawing.Color.Green;
                button4.Refresh();

            }
            else
            {
                button4.BackColor = System.Drawing.Color.Red;
                button4.Refresh();
                theselectedfolderin = "";
            }






            /*
            if (button4swtc == 0)
            {
                button4.BackColor = System.Drawing.Color.Red;
                button4.Refresh();
                button4swtc = 1;
            }
            else if (button4swtc == 1)
            {
                button4.BackColor = System.Drawing.Color.Green;
                button4.Refresh();

                button4swtc = 0;
            }
            */


        }




        //DELETE MODS
        //DELETE MODS
        //DELETE MODS
        public int button6swtc = 0;
        //public int button6swtc = 0;
        public int deletemethodstartedornotmods = 0;
        private void button6_Click(object sender, EventArgs e)
        {

            deletemethodstartedornotmods = 1;
            //button20.Enabled = false;
            button6swtc = 1;





            if (indexofdeleteoptiontype == 2)
            {



                Stopwatch thetimer = new Stopwatch();
                thetimer.Start();

                //var dirinfo = Directory.GetCurrentDirectory();

                //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
                //List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));
                //List<string> dirs1last = new List<string>();
                itsalmostastack<string> dirs1last = new itsalmostastack<string>();
                //itsalmostastack<string> dirs2last = new itsalmostastack<string>();

                List<string> dirs2lastlist = new List<string>();

                List<string> dirs2 = new List<string>();

                string pathtomods = "";

                int counttheproblem = 0;

                int mainninesmodsfoldercounter = 0;

                //foreach (var dir in dirs)
                {
                    //DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                    //directoryFolder0.Refresh();

                    //string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    //if (foldername.ToLower() == "#cryofallscriptgen")
                    {
                        pathtomods = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername; //dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

                        dirs1last.Push(pathtomods);

                        int counter = 0;

                        int endthread0 = 0;
                        var maincopythread = new Thread((tester0000) =>
                        {
                            int folderiteratormainlast = -1;
                            int folderiteratormain = 0;
                            int folderiteratorsec = 0;
                            int folderiteratorseclast = -1;

                            string thecurrentpathlast = "";
                            List<string> dirs1 = null;
                            string[] arrayoffiles = null;
                            string foldername2 = "";
                            itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                            string thepathtocopyfolder = "";

                            int listoffilescounter = 0;
                            int listoffilesorigincount = 0;

                            int dirs1count = 0;
                            int disr1swtc = 0;

                            int folderiteratorsecswtc = 0;
                            DirectoryInfo directoryFolder;
                            string poppedstring = "";
                            string anotherpath = "";
                            string ateststring = "";
                            string thecopiedfilepath = "";
                            string thefinalpath = "";
                            string thecurrentpath = "";
                            string foldername1 = "";
                            int deletingfilecounter = 0;

                        _thread_main_loop:

                            for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count //dirs1last.Count
                            {
                                if (dirs1last.Count <= 0)
                                {
                                    Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                }

                                if (dirs1last.Count > 0)
                                {

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                        folderiteratormain = 0;
                                    }

                                    thecurrentpath = dirs1last.Peek(folderiteratormain);

                                    if (Directory.Exists(thecurrentpath))
                                    {
                                        if (disr1swtc == 0)
                                        {
                                            dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                            dirs1count = dirs1.Count;
                                            disr1swtc = 1;
                                        }

                                        thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                        if (dirs1count > 0)
                                        {
                                            foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                            thefinalpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;

                                            directoryFolder = new DirectoryInfo(thefinalpath);
                                            directoryFolder.Refresh();

                                            if (Directory.Exists(thefinalpath))
                                            {
                                                dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                            }

                                            if (folderiteratorsecswtc == 0)
                                            {
                                                deletingfilecounter = 0;
                                                arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                listoffilesorigincount = arrayoffiles.Length;
                                                folderiteratorsecswtc = 1;
                                            }

                                            if (folderiteratorsecswtc == 1)
                                            {
                                                if (arrayoffiles != null)
                                                {
                                                    if (arrayoffiles.Length > 0)
                                                    {
                                                        if (arrayoffiles[listoffilescounter] != null)
                                                        {
                                                            poppedstring = arrayoffiles[listoffilescounter];
                                                            anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                            ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                            thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                            if (File.Exists(thecopiedfilepath))
                                                            {
                                                                File.Delete(thecopiedfilepath);
                                                            }
                                                            deletingfilecounter++;
                                                            arrayoffiles[listoffilescounter] = null;
                                                        }
                                                        listoffilescounter++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (listoffilescounter >= listoffilesorigincount)
                                {


                                    folderiteratorsec++;
                                    folderiteratorsecswtc = 0;
                                    listoffilescounter = 0;
                                }

                                if (folderiteratorsec >= dirs1count)
                                {
                                    disr1swtc = 0;
                                    folderiteratormain++;
                                    folderiteratorsec = 0;
                                }

                                if (dirs1last != null)
                                {
                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                            }

                            if (endthread0 == 0)
                            {
                                Thread.Sleep(1);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                {
                                    var poppedvalue = dirs1last.Pop();

                                    if (poppedvalue != "multiplied")
                                    {


                                        if (Directory.Exists(poppedvalue))
                                        {
                                            var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                            if (currentdirsinfolder != null)
                                            {
                                                if (currentdirsinfolder.Count == 0)
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                                else
                                                {
                                                    for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                    {

                                                        if (currentdirsinfolder[i] != "multiplied")
                                                        {
                                                            var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                            var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                            if (folderemptyornot == null)
                                                            {
                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (folderemptyornot.Length > 0)
                                                                {

                                                                }
                                                                else
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (Directory.Exists(poppedvalue))
                                                {
                                                    Directory.Delete(poppedvalue);
                                                }
                                            }
                                        }
                                    }
                                }


                                /*
                                for (int fo = dirs2lastlist.Count - 1; fo >= 0; fo--)
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/

                                /*
                                for (int fo = 0; fo < dirs2lastlist.Count; fo++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/


                                if (listoffiles != null)
                                {
                                    listoffiles.Clear();
                                    listoffiles = null;
                                }

                                if (dirs1 != null)
                                {
                                    dirs1.Clear();
                                    dirs1 = null;
                                }

                                arrayoffiles = null;

                                if (dirs1last != null)
                                {
                                    dirs1last.Clear();
                                    dirs1last = null;
                                }

                                deletemethodstartedornotmods = 2;

                                thetimer.Stop();
                                Console.WriteLine("end of delete files. timer:" + thetimer.Elapsed.TotalSeconds);
                                //Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
                            }

                        }, 0); //100000 //999999999

                        maincopythread.IsBackground = true;
                        maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                        maincopythread.SetApartmentState(ApartmentState.STA);
                        maincopythread.Start();

                        //break;
                    }
                }
            }
            else if (indexofdeleteoptiontype == 1)
            {



                Stopwatch thetimer = new Stopwatch();
                thetimer.Start();

                //var dirinfo = Directory.GetCurrentDirectory();

                //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
                //List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));
                //List<string> dirs1last = new List<string>();
                itsalmostastack<string> dirs1last = new itsalmostastack<string>();
                //itsalmostastack<string> dirs2last = new itsalmostastack<string>();

                List<string> dirs2lastlist = new List<string>();

                List<string> dirs2 = new List<string>();

                string pathtomods = "";

                int counttheproblem = 0;

                int mainninesmodsfoldercounter = 0;

                //foreach (var dir in dirs)
                {
                    //DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                    //directoryFolder0.Refresh();

                    //string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    //if (foldername.ToLower() == "#cryofallscriptgen")
                    {
                        pathtomods = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername; //dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

                        dirs1last.Push(pathtomods);

                        int counter = 0;

                        int endthread0 = 0;
                        var maincopythread = new Thread((tester0000) =>
                        {
                            int folderiteratormainlast = -1;
                            int folderiteratormain = 0;
                            int folderiteratorsec = 0;
                            int folderiteratorseclast = -1;

                            string thecurrentpathlast = "";
                            List<string> dirs1 = null;
                            string[] arrayoffiles = null;
                            string foldername2 = "";
                            itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                            string thepathtocopyfolder = "";

                            int listoffilescounter = 0;
                            int listoffilesorigincount = 0;

                            int dirs1count = 0;
                            int disr1swtc = 0;

                            int folderiteratorsecswtc = 0;
                            DirectoryInfo directoryFolder;
                            string poppedstring = "";
                            string anotherpath = "";
                            string ateststring = "";
                            string thecopiedfilepath = "";
                            string thefinalpath = "";
                            string thecurrentpath = "";
                            string foldername1 = "";
                            int deletingfilecounter = 0;

                        _thread_main_loop:

                            for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count //dirs1last.Count
                            {
                                if (dirs1last.Count <= 0)
                                {
                                    Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                }

                                if (dirs1last.Count > 0)
                                {

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                        folderiteratormain = 0;
                                    }

                                    thecurrentpath = dirs1last.Peek(folderiteratormain);

                                    if (Directory.Exists(thecurrentpath))
                                    {
                                        if (disr1swtc == 0)
                                        {
                                            dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                            dirs1count = dirs1.Count;
                                            disr1swtc = 1;
                                        }

                                        thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                        if (dirs1count > 0)
                                        {
                                            foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                            thefinalpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;

                                            directoryFolder = new DirectoryInfo(thefinalpath);
                                            directoryFolder.Refresh();

                                            if (Directory.Exists(thefinalpath))
                                            {
                                                dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                            }

                                            if (folderiteratorsecswtc == 0)
                                            {
                                                deletingfilecounter = 0;
                                                arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                listoffilesorigincount = arrayoffiles.Length;
                                                folderiteratorsecswtc = 1;
                                            }

                                            if (folderiteratorsecswtc == 1)
                                            {
                                                if (arrayoffiles != null)
                                                {
                                                    if (arrayoffiles.Length > 0)
                                                    {
                                                        if (arrayoffiles[listoffilescounter] != null)
                                                        {
                                                            poppedstring = arrayoffiles[listoffilescounter];
                                                            anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                            ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                            thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                            if (File.Exists(thecopiedfilepath))
                                                            {
                                                                File.Delete(thecopiedfilepath);
                                                            }
                                                            deletingfilecounter++;
                                                            arrayoffiles[listoffilescounter] = null;
                                                        }
                                                        listoffilescounter++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (listoffilescounter >= listoffilesorigincount)
                                {


                                    folderiteratorsec++;
                                    folderiteratorsecswtc = 0;
                                    listoffilescounter = 0;
                                }

                                if (folderiteratorsec >= dirs1count)
                                {
                                    disr1swtc = 0;
                                    folderiteratormain++;
                                    folderiteratorsec = 0;
                                }

                                if (dirs1last != null)
                                {
                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                            }

                            if (endthread0 == 0)
                            {
                                Thread.Sleep(0);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                {
                                    var poppedvalue = dirs1last.Pop();

                                    if (poppedvalue != "multiplied")
                                    {


                                        if (Directory.Exists(poppedvalue))
                                        {
                                            var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                            if (currentdirsinfolder != null)
                                            {
                                                if (currentdirsinfolder.Count == 0)
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                                else
                                                {
                                                    for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                    {

                                                        if (currentdirsinfolder[i] != "multiplied")
                                                        {
                                                            var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                            var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                            if (folderemptyornot == null)
                                                            {
                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (folderemptyornot.Length > 0)
                                                                {

                                                                }
                                                                else
                                                                {
                                                                    if (currentdirsinfolder1 == null)
                                                                    {
                                                                        if (Directory.Exists(currentdirsinfolder[i]))
                                                                        {
                                                                            Directory.Delete(currentdirsinfolder[i]);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1.Count > 0)
                                                                        {

                                                                        }
                                                                        else
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (Directory.Exists(poppedvalue))
                                                {
                                                    Directory.Delete(poppedvalue);
                                                }
                                            }
                                        }
                                    }
                                }


                                /*
                                for (int fo = dirs2lastlist.Count - 1; fo >= 0; fo--)
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/

                                /*
                                for (int fo = 0; fo < dirs2lastlist.Count; fo++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (Directory.Exists(dirs2lastlist[fo]))
                                    {
                                        Directory.Delete(dirs2lastlist[fo]);
                                        //dirs2last.Remove(dirs2last[fo]);
                                    }
                                }*/


                                if (listoffiles != null)
                                {
                                    listoffiles.Clear();
                                    listoffiles = null;
                                }

                                if (dirs1 != null)
                                {
                                    dirs1.Clear();
                                    dirs1 = null;
                                }

                                arrayoffiles = null;

                                if (dirs1last != null)
                                {
                                    dirs1last.Clear();
                                    dirs1last = null;
                                }

                                deletemethodstartedornotmods = 2;

                                thetimer.Stop();
                                Console.WriteLine("end of delete files. timer:" + thetimer.Elapsed.TotalSeconds);
                                //Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
                            }

                        }, 0); //100000 //999999999

                        maincopythread.IsBackground = true;
                        maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                        maincopythread.SetApartmentState(ApartmentState.STA);
                        maincopythread.Start();

                        //break;
                    }
                }
            }
            else if (indexofdeleteoptiontype == 0)
            {

                Stopwatch thetimer = new Stopwatch();
                thetimer.Start();

                //var dirinfo = Directory.GetCurrentDirectory();

                //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirinfo.FullName));
                //List<string> dirs1last = new List<string>();
                itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                List<string> dirs2last = new List<string>();

                List<string> dirs2 = new List<string>();

                string pathtomods = "";

                int counttheproblem = 0;

                int mainninesmodsfoldercounter = 0;





                //foreach (var dir in dirs)
                {
                    //DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                    //directoryFolder0.Refresh();

                    //string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    //if (foldername.ToLower() == "#cryofallscriptgen")
                    {
                        pathtomods = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername; //dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";


                        if (!Directory.Exists(pathtomods))
                        {
                            Directory.CreateDirectory(pathtomods);
                        }




                        //dirs1last.Add(pathtomods);
                        dirs1last.Push(pathtomods);

                        int counter = 0;

                        //while (dirs1last.Count > 0) //while there are folders and files
                        //{
                        int endthread0 = 0;
                        var maincopythread = new Thread((tester0000) =>
                        {
                        _thread_main_loop:

                            if (dirs1last.Count > 0)
                            {
                                //for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                                for (int fo = 0; fo < dirs1last.Count; fo++)
                                {
                                    string thecurrentpath = dirs1last.Peek(fo);

                                    if (dirs1last.Count > 0)
                                    {
                                        string foldername1 = $"{thecurrentpath.Substring(thecurrentpath.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));

                                            foreach (var dir1 in dirs1)
                                            {
                                                DirectoryInfo directoryFolder = new DirectoryInfo(dir1);
                                                directoryFolder.Refresh();

                                                //Console.WriteLine(dir1);
                                                string foldername2 = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                //Console.WriteLine(foldername2);

                                                var arrayoffiles = Directory.GetFiles(dir1);

                                                //Console.WriteLine(arrayoffiles.Length);


                                                if (arrayoffiles != null && arrayoffiles.Length > 0)
                                                {
                                                    for (int f = 0; f < arrayoffiles.Length; f++)
                                                    {
                                                        File.Delete(arrayoffiles[f]);
                                                    }
                                                }
                                                else
                                                {

                                                }

                                                if (foldername2.ToLower() != "multiplied")
                                                {

                                                    dirs2last.Add(thecurrentpath + @"\" + foldername2);
                                                    //dirs1last.Add(thecurrentpath + @"\" + foldername2);
                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);

                                                    //astack.Push(dirs1last[fo] + @"\" + foldername2);

                                                    //Console.WriteLine(dirs1last[fo]);
                                                    //Console.WriteLine("counttheproblem:" + counttheproblem);
                                                    /*if (dirs1last.Count > 0 && fo >= 0)
                                                    {

                                                    }*/

                                                    counttheproblem++;
                                                }
                                            }
                                        }
                                        //break;

                                    }
                                }





                                //for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                                for (int fo = 0; fo < dirs1last.Count; fo++)
                                {
                                    string thecurrentpath = dirs1last.Peek(fo);


                                    if (dirs1last.Count > 0)
                                    {
                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            string foldername1 = $"{thecurrentpath.Substring(thecurrentpath.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                                            List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));

                                            foreach (var dir1 in dirs1)
                                            {
                                                //Console.WriteLine(dir1);
                                                string foldername2 = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                //Console.WriteLine(foldername2);

                                                DirectoryInfo directoryFolder = new DirectoryInfo(dir1);
                                                directoryFolder.Refresh();

                                                var arrayoffiles = Directory.GetFiles(dir1);

                                                if (arrayoffiles == null || arrayoffiles.Length == 0)
                                                {
                                                    if (dirs1last.Count > 0 && fo >= 0)
                                                    {
                                                        //Console.WriteLine("popping");
                                                        dirs1last.Pop();

                                                        //dirs1last.RemoveAt(fo);
                                                        //dirs1last[fo]
                                                        //continue;
                                                        //dirs1last.Remove(dirs1last[fo]);
                                                        //dirs1last.RemoveAt(dirs1last.Count-1);
                                                    }
                                                    //Directory.Delete(dir1);
                                                }
                                            }

                                        }
                                        else
                                        {
                                            //dirs1last.Pop();
                                        }
                                        //break;
                                    }
                                }
                                //NOT WORKING. CANNOT REMOVE FROM LIST. MAYBE USE ITSALMOSTASTACK



                                for (int fo = dirs2last.Count - 1; fo >= 0; fo--)
                                {
                                    if (Directory.Exists(dirs2last[fo]))
                                    {
                                        Directory.Delete(dirs2last[fo]);
                                        dirs2last.Remove(dirs2last[fo]);
                                    }
                                }

                                counter++;
                            }

                            //Console.WriteLine(dirs1last.Count);

                            if (dirs2last.Count <= 0)
                            {
                                //Console.WriteLine("dirs1last.Count:" + dirs1last.Count);
                                endthread0 = 1;
                            }

                            if (dirs1last.Count <= 0)
                            {
                                endthread0 = 1;
                            }
                            else if (dirs1last.Count == 1)
                            {
                                var thepath = dirs1last.Pop();
                                var arrayoffiles = Directory.GetFiles(thepath);

                                if (arrayoffiles == null || arrayoffiles.Length <= 0)
                                {
                                    endthread0 = 1;
                                }
                            }

                            if (endthread0 == 0)
                            {
                                Thread.Sleep(1);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                deletemethodstartedornotmods = 2;

                                thetimer.Stop();
                                Console.WriteLine("end of delete files. timer:" + thetimer.Elapsed.TotalSeconds);

                                //Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
                                //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);






                            }

                        }, 0); //100000 //999999999

                        maincopythread.IsBackground = true;
                        maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                        maincopythread.SetApartmentState(ApartmentState.STA);
                        maincopythread.Start();

                        //break;
                    }
                }

            }


            //button20.Enabled = true;
        }





        public int indexofdeleteoptiontype = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox comboBox = (ComboBox)sender;
            string selectedscreencaptureindex = (string)comboBox1.SelectedItem;
            indexofdeleteoptiontype = comboBox1.FindStringExact(selectedscreencaptureindex);
            */
            //this.comboBox1.Text = "THIS IS A TEXT MESSAGE";



        }









        private void button7_Click(object sender, EventArgs e)
        {
            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;
            //sccsr16.Program.OnProcessExit();

            int endthread0 = 0;

            var maincopythread = new Thread((tester0000) =>
            {
            _thread_main_loop:

                //if (sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 == 2)
                {
                    endthread0 = 1;

                    int iHandle = FindWindow(null, Console.Title);

                    SendMessage(iHandle, 0x0010, 0, 0);

                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                    var process = System.Diagnostics.Process.GetCurrentProcess();

                    process.Kill();
                    process.Dispose();


                    sccsr16.Form1.currentform.Close();
                    sccsr16.Form1.currentform.Dispose();

                    //InputSimulator inputsim = new InputSimulator();
                    //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim = null;

                    System.Environment.Exit(1);

                    System.Environment.Exit(0);


                    /*Program.OnProcessExit();
                    //CloseWindow(theconsolehandle);


                    Program.CloseWindow(theconsolehandle);
                    Application.Exit();
                    
                    var theprocess = Process.GetCurrentProcess();

                    theprocess.CloseMainWindow();
                    //theprocess.Close();
                    //theprocess.WaitForExit();

                    

                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                    var process = System.Diagnostics.Process.GetCurrentProcess();

                    process.Kill();
                    process.Dispose();


                    sccsr16.Form1.currentform.Close();
                    sccsr16.Form1.currentform.Dispose();

                    //InputSimulator inputsim = new InputSimulator();
                    //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                    //inputsim = null;

                    System.Environment.Exit(1);

                    System.Environment.Exit(0);


                    int iHandle = FindWindow(null, Console.Title);


                    Program.MessageBox((IntPtr)0, "iHandle:" + iHandle, "sccsmsg", 0);

                    SendMessage(iHandle, 0x0010, 0, 0);*/
                    endthread0 = 1;
                }





                if (endthread0 == 0)
                {
                    Thread.Sleep(1);

                    goto _thread_main_loop;
                }
                else
                {
                    //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);

                }

            }, 0); //100000 //999999999

            maincopythread.IsBackground = true;
            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
            maincopythread.SetApartmentState(ApartmentState.STA);
            maincopythread.Start();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //sccs.sccsgraphicssec.currentsccsgraphicssec.mainsccsgraphicssecthread.Abort();
            //sccs.sccsgraphicssec.currentsccsgraphicssec.mainsccsgraphicssecthread.Suspend();

            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;
        }


        public int lastrectl = 0;
        public int lastrectt = 0;
        public int lastrectrl = 0;
        public int lastrectbt = 0;

        public int consoleshoworhide = 0;
        private void button9_Click(global::System.Object sender, global::System.EventArgs e)
        {

            if (consolestickornot == 0)
            {
                resetconsoledockpos();

            }





            if (consoleshoworhide == 0)
            {
                button9.Text = "Show";
                button9.Refresh();
                var rectprogram = new RECT();
                //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);

                sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_BOTTOM, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_HIDEWINDOW);



                consoleshoworhide = 1;
            }
            else if (consoleshoworhide == 1)
            {
                button9.Text = "Hide";
                button9.Refresh();

                var rectprogram = new RECT();
                //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);

                //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW);
                sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_TOP, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW);

                this.TopMost = true;

                consoleshoworhide = 0;
            }


        }




        public void resetconsoledockpos()
        {

            RECT rectmainprogram;

            rectmainprogram = new RECT();
            sccsr16.Form1.GetWindowRect(sccsr16.Form1.theHandle, ref rectmainprogram);

            //Console.WriteLine("Left:" + rectmainprogram.Left + "/Bottom:" + rectmainprogram.Bottom);

            if (Program.SCGLOBALSACCESSORS != null)
            {
                if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE != null)
                {
                    if (Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle != IntPtr.Zero)
                    {
                        var Rectsccscapturedwindow = new RECT();
                        //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                        sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccscapturedwindow);



                        //Console.WriteLine("Left:" + Rectsccscapturedwindow.Left + "/Bottom:" + Rectsccscapturedwindow.Bottom);



                        IntPtr id;
                        RECT Rect = new RECT();
                        //Thread.Sleep(2000);
                        /*id = sccsr16.Form1.currentform.Handle;// GetForegroundWindow();
                        Random myRandom = new Random();
                        sccsr16.Form1.GetWindowRect(id, ref Rect);
                        sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccs);
                        */

                        int screenWidth = sccsr16.Form1.GetSystemMetrics(0);
                        int screenHeight = sccsr16.Form1.GetSystemMetrics(1);




                        screenWidth = sccsr16.Form1.GetSystemMetrics(0);
                        screenHeight = sccsr16.Form1.GetSystemMetrics(1);






                        int iHandle = sccsr16.Form1.FindWindow(null, Console.Title);// "VoidExpanse");

                        //Console.WriteLine("******************************:" + iHandle + "/title:" + Console.Title);

                        //Console.WriteLine(capturedwindowname);
                        //Program.SetWindowPos(vewindowsfoundedz, (IntPtr)Program.SpecialWindowHandles.HWND_NOTOPMOST, Rectsccs.Left, Rectsccs.Top, Rectsccs.Right, Rectsccs.Bottom, (uint)Program.SetWindowPosFlags.SWP_SHOWWINDOW); //SetWindowPosFlags.SWP_SHOWWINDOW
                        //Program.SetWindowPos(vewindowsfoundedz, (IntPtr)Program.SpecialWindowHandles.HWND_NOTOPMOST, lastRectsccsformovement.Left, lastRectsccsformovement.Top, Rectsccscapturedwindow.Right, Rectsccscapturedwindow.Bottom, (uint)Program.SetWindowPosFlags.SWP_SHOWWINDOW); //SetWindowPosFlags.SWP_SHOWWINDOW


                        //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, Rectsccs.Left, Rectsccs.Top, (Rectsccs.Right - Rectsccs.Left), Rectsccs.Bottom - Rectsccs.Top, sccsr16.Form1.SWP_ASYNCWINDOWPOS);
                        //Console.SetWindowPosition(Rectsccs.Left, Rectsccs.Top);
                        //MoveWindow(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, Rectsccs.Left, Rectsccs.Top, (Rectsccs.Right - Rectsccs.Left), Rectsccs.Bottom - Rectsccs.Top,true);

                        /*
                        Console.WindowWidth = 50;
                        Console.WindowHeight = 3;
                        Console.BufferWidth = 50;
                        Console.BufferHeight = 3;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                        var width = screen.Width;
                        var height = screen.Height;

                        SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, IntPtr.Zero,100, height - 300, 500, 100);
                        */




                        //https://stackoverflow.com/questions/27715004/position-a-small-console-window-to-the-bottom-left-of-the-screen
                        /*// Get this console window's hWnd (window handle).
                        IntPtr hWnd = GetConsoleWindow();

                        // Get information about the monitor (display) that the window is (mostly) displayed on.
                        // The .rcWork field contains the monitor's work area, i.e., the usable space excluding
                        // the taskbar (and "application desktop toolbars" - see https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx)
                        var mi = MONITORINFO.Default;
                        GetMonitorInfo(MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY), ref mi);

                        // Get information about this window's current placement.
                        var wp = WINDOWPLACEMENT.Default;
                        GetWindowPlacement(hWnd, ref wp);

                        // Calculate the window's new position: lower left corner.
                        // !! Inexplicably, on W10, work-area coordinates (0,0) appear to be (7,7) pixels 
                        // !! away from the true edge of the screen / taskbar.
                        int fudgeOffset = 7;
                        wp.NormalPosition = new RECT()
                        {
                            Left = -fudgeOffset,
                            Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                            Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                            Bottom = fudgeOffset + mi.rcWork.Bottom
                        };

                        // Place the window at the new position.
                        SetWindowPlacement(hWnd, ref wp);*/






                        //https://stackoverflow.com/questions/27715004/position-a-small-console-window-to-the-bottom-left-of-the-screen
                        // Get this console window's hWnd (window handle).
                        IntPtr hWnd = GetConsoleWindow();

                        // Get information about the monitor (display) that the window is (mostly) displayed on.
                        // The .rcWork field contains the monitor's work area, i.e., the usable space excluding
                        // the taskbar (and "application desktop toolbars" - see https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947(v=vs.85).aspx)
                        var mi = MONITORINFO.Default;
                        GetMonitorInfo(MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY), ref mi);

                        // Get information about this window's current placement.
                        var wp = WINDOWPLACEMENT.Default;
                        GetWindowPlacement(hWnd, ref wp);

                        // Calculate the window's new position: lower left corner.
                        // !! Inexplicably, on W10, work-area coordinates (0,0) appear to be (7,7) pixels 
                        // !! away from the true edge of the screen / taskbar.
                        int fudgeOffset = 7;



                        if (maindocksidetype == 0)//UP
                        {
                            //Console.WriteLine(rectmainprogram.Left);
                            wp.NormalPosition = new RECT()
                            {
                                Left = rectmainprogram.Left,// - fudgeOffset,
                                Top = rectmainprogram.Top - sccsr16.Form1.currentform.Height - 200,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                Right = rectmainprogram.Left + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left), //+ sccsr16.Form1.currentform.Width + 800
                                Bottom = (rectmainprogram.Top),//fudgeOffset + mi.rcWork.Bottom
                            };
                        }
                        else if (maindocksidetype == 1)//RIGHT
                        {
                            //Console.WriteLine(rectmainprogram.Left);
                            wp.NormalPosition = new RECT()
                            {
                                Left = rectmainprogram.Left + sccsr16.Form1.currentform.Width,// - fudgeOffset,
                                Top = rectmainprogram.Top,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                Right = rectmainprogram.Left + sccsr16.Form1.currentform.Width + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left),
                                Bottom = (rectmainprogram.Bottom) + 600 - 400,//fudgeOffset + mi.rcWork.Bottom
                            };
                        }
                        else if (maindocksidetype == 2)//BOTTOM
                        {
                            //Console.WriteLine(rectmainprogram.Left);
                            wp.NormalPosition = new RECT()
                            {
                                Left = rectmainprogram.Left,// - fudgeOffset,
                                Top = rectmainprogram.Top + sccsr16.Form1.currentform.Height,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                Right = rectmainprogram.Left + 800, //(wp.NormalPosition.Right - wp.NormalPosition.Left), //+ sccsr16.Form1.currentform.Width + 800
                                Bottom = (rectmainprogram.Bottom) + 600,//fudgeOffset + mi.rcWork.Bottom
                            };
                        }
                        else if (maindocksidetype == 3)//LEFT
                        {
                            //Console.WriteLine(rectmainprogram.Left);
                            wp.NormalPosition = new RECT()
                            {
                                Left = rectmainprogram.Left - sccsr16.Form1.currentform.Width - 800 + 200,// - fudgeOffset,
                                Top = rectmainprogram.Top,//mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                                Right = rectmainprogram.Left, //(wp.NormalPosition.Right - wp.NormalPosition.Left),
                                Bottom = (rectmainprogram.Bottom) + 600 - 400,//fudgeOffset + mi.rcWork.Bottom
                            };
                        }








                        /*wp.NormalPosition = new RECT()
                        {
                            Left = -fudgeOffset,
                            Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                            Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                            Bottom = fudgeOffset + mi.rcWork.Bottom
                        };*/

                        // Place the window at the new position.
                        //SetWindowPlacement(hWnd, ref wp);

                        //Rectsccscapturedwindow = new RECT();
                        //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                        //sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref Rectsccscapturedwindow);
                        var rectprogram = new RECT();

                        rectprogram.Left = wp.NormalPosition.Left;
                        rectprogram.Top = wp.NormalPosition.Top;
                        rectprogram.Right = wp.NormalPosition.Right;
                        rectprogram.Bottom = wp.NormalPosition.Bottom;

                        /*wp.NormalPosition = new RECT()
                        {
                            Left = -fudgeOffset,
                            Top = mi.rcWork.Bottom - (wp.NormalPosition.Bottom - wp.NormalPosition.Top),
                            Right = (wp.NormalPosition.Right - wp.NormalPosition.Left),
                            Bottom = fudgeOffset + mi.rcWork.Bottom
                        };*/

                        // Place the window at the new position.
                        //SetWindowPlacement(hWnd, ref wp);


                        //var rectprogram = new RECT();
                        //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                        //sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);

                        //ALTHOUGH THIS PROGRAM ISN'T SET TO GO UNDERNEATH ANOTHER WINDOW, THE FACT THAT A CALL TO SWP_SHOWWINDOW|NOACTIVATE IS DONE MAKES SOMEHOW THE WINDOWS FORMS NOT BE TOPMOST ANYMORE WHICH IS BENEFICIAL WHERE NO CALLS TO NOTOPMOST NEEDS TO BE DONE TO THE WINDOWS FORMS AS IT ALREADY ISN'T TOPMOST ANYMORE. FOR SOME REASONS...
                        //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW);
                        //sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_TOP, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW | SWP_NOACTIVATE);


                        if (consoleshoworhide == 1)
                        {
                            sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_BOTTOM, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_HIDEWINDOW);

                        }
                        else
                        {
                            sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_TOP, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW | SWP_NOACTIVATE);

                        }



                    }
                }
            }
        }









        int consolestickornot = 0;
        private void button10_Click(global::System.Object sender, global::System.EventArgs e)
        {

            if (consolestickornot == 0)
            {
                var rectprogram = new RECT();
                //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);

                /*
                lastrectl = rectprogram.Left;
                lastrectt = rectprogram.Top;
                lastrectrl = rectprogram.Right - rectprogram.Left;
                lastrectbt = rectprogram.Bottom - rectprogram.Top;*/

                button10.Text = "Dock";
                button10.Refresh();

                /*
                sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_SHOWWINDOW | SWP_NOACTIVATE);
                sccsr16.Form1.SetWindowPos(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_NOTOPMOST, rectprogram.Left, rectprogram.Top, (rectprogram.Right - rectprogram.Left), rectprogram.Bottom - rectprogram.Top, (uint)SWP_NOACTIVATE);



                var rectofthisprogram = new RECT();

                sccsr16.Form1.GetWindowRect(sccsr16.Form1.currentform.Handle, ref rectofthisprogram);

                sccsr16.Form1.SetWindowPos(sccsr16.Form1.currentform.Handle, (IntPtr)sccsr16.Form1.SpecialWindowHandles.HWND_TOPMOST, rectofthisprogram.Left, rectofthisprogram.Top, (rectofthisprogram.Right - rectofthisprogram.Left), rectofthisprogram.Bottom - rectofthisprogram.Top, (uint)SWP_NOACTIVATE);
                */
                sccsr16.Form1.currentform.TopMost = true;


                consolestickornot = 1;
            }
            else if (consolestickornot == 1)
            {
                var rectprogram = new RECT();
                //GetWindowRect(sccsr14sc.Form1.theHandle, ref Rectsccs);
                sccsr16.Form1.GetWindowRect(Program.SCGLOBALSACCESSORS.SCCONSOLECORE.handle, ref rectprogram);
                /*
                lastrectl = rectprogram.Left;
                lastrectt = rectprogram.Top;
                lastrectrl = rectprogram.Right - rectprogram.Left;
                lastrectbt = rectprogram.Bottom - rectprogram.Top;*/

                button10.Text = "UnDock";
                button10.Refresh();



                //if (consoleshoworhide == 0)
                {
                    resetconsoledockpos();
                }





                consolestickornot = 0;
            }
        }

        private void button11_Click(global::System.Object sender, global::System.EventArgs e)
        {
            resetconsoledockpos();

        }



        List<int> listbuttonswtc = new List<int>();

        int buttonlistswtc = 0;
        List<Button> buttonlist = new List<Button>();


        public void processbutton(int tocanceliterator)
        {
            buttonlist[tocanceliterator].Hide();
            buttonlist[tocanceliterator].Refresh();
            listbuttonswtc[tocanceliterator] = 0;


            for (int i = 0; i < buttonlist.Count; i++)
            {
                if (i == tocanceliterator)
                {
                    continue;
                }
                else
                {
                    buttonlist[i].Show();
                    buttonlist[i].Refresh();
                    listbuttonswtc[i] = 0;

                    /*
                    if (listbuttonswtc[i] == 1)
                    {
                        
                        listbuttonswtc[i] = 0;
                    }*/
                }
            }


        }





        int maindocksidetype = -1;

        private void button15_Click(global::System.Object sender, global::System.EventArgs e)
        {
            maindocksidetype = 0;

            processbutton(maindocksidetype);
            resetconsoledockpos();

            if (listbuttonswtc[0] == 0)
            {
                button15.Hide();
                button15.Refresh();

                listbuttonswtc[0] = 1;
            }
            else if (listbuttonswtc[0] == 1)
            {
                button15.Show();
                button15.Refresh();
                listbuttonswtc[0] = 0;
            }
        }


        private void button13_Click(global::System.Object sender, global::System.EventArgs e)
        {
            maindocksidetype = 1;
            processbutton(maindocksidetype);
            resetconsoledockpos();

            if (listbuttonswtc[1] == 0)
            {
                button13.Hide();
                button13.Refresh();
                listbuttonswtc[1] = 1;
            }
            else if (listbuttonswtc[1] == 1)
            {
                button13.Show();
                button13.Refresh();
                listbuttonswtc[1] = 0;
            }
        }

        private void button14_Click(global::System.Object sender, global::System.EventArgs e)
        {
            maindocksidetype = 2;
            processbutton(maindocksidetype);
            resetconsoledockpos();

            if (listbuttonswtc[2] == 0)
            {
                button14.Hide();
                button14.Refresh();
                listbuttonswtc[2] = 1;
            }
            else if (listbuttonswtc[2] == 1)
            {
                button14.Show();
                button14.Refresh();
                listbuttonswtc[2] = 0;
            }
        }

        private void button12_Click(global::System.Object sender, global::System.EventArgs e)
        {
            maindocksidetype = 3;
            processbutton(maindocksidetype);
            resetconsoledockpos();

            if (listbuttonswtc[3] == 0)
            {
                button12.Hide();
                button12.Refresh();
                listbuttonswtc[3] = 1;
            }
            else if (listbuttonswtc[3] == 1)
            {
                button12.Show();
                button12.Refresh();
                listbuttonswtc[3] = 0;
            }
        }
        /*
        private void comboBox2_SelectedIndexChanged(global::System.Object sender, global::System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedscreencaptureindex = (string)comboBox2.SelectedItem;
            fastorslowcopy = comboBox2.FindStringExact(selectedscreencaptureindex);
        }*/



        int fastorslowmove = 0;/*
        private void comboBox3_SelectedIndexChanged(global::System.Object sender, global::System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedscreencaptureindex = (string)comboBox3.SelectedItem;
            fastorslowmove = comboBox3.FindStringExact(selectedscreencaptureindex);
        }*/

        private void folderBrowserDialog1_HelpRequest(global::System.Object sender, global::System.EventArgs e)
        {

        }

        string theselectedfolderout = "";


        int button16swtc = 0;
        private void button16_Click(global::System.Object sender, global::System.EventArgs e)
        {

            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=windowsdesktop-7.0
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog4.Description = "Select the directory that you want to use as the default.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog4.ShowNewFolderButton = false;
            // Default to the My Documents folder.
            this.folderBrowserDialog4.RootFolder = Environment.SpecialFolder.Personal;
            // Show the FolderBrowserDialog.

            var dirinfom = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
            string thepaththisprogramulfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfom.FullName + @"\" + "#Cryofallscriptgen" + @"\" + "multiplied";


            DialogResult result = this.folderBrowserDialog4.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (this.folderBrowserDialog4.SelectedPath == null || this.folderBrowserDialog4.SelectedPath == "" || folderBrowserDialog4.SelectedPath == string.Empty)
                {
                    this.folderBrowserDialog4.SelectedPath = thepaththisprogramulfolder;
                    theselectedfolderout = this.folderBrowserDialog4.SelectedPath;// Environment.GetFolderPath(Environment.SpecialFolder.Personal);//this.folderBrowserDialog4.RootFolder.ToString();
                }
                else
                {
                    theselectedfolderout = this.folderBrowserDialog4.SelectedPath;
                }

                /*if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = theselectedfolderout;
                    openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }*/

                button16.BackColor = System.Drawing.Color.Green;
                button16.Refresh();
            }
            else
            {
                button16.BackColor = System.Drawing.Color.Red;
                button16.Refresh();
                theselectedfolderout = "";
            }


            /*
            if (button16swtc == 0)
            {
                button16.BackColor = System.Drawing.Color.Red;
                button16.Refresh();
                button16swtc = 1;
            }
            else if (button16swtc == 1)
            {
                button16.BackColor = System.Drawing.Color.Green;
                button16.Refresh();
                button16swtc = 0;
            }*/
            //Console.WriteLine("theselectedfolderin:" + theselectedfolderin + "/theselectedfolderout:" + theselectedfolderout);
        }

        private void button17_Click(global::System.Object sender, global::System.EventArgs e)
        {

            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=windowsdesktop-7.0
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog6 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog6.Description = "Select the directory that you want to use as the default.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog6.ShowNewFolderButton = false;
            // Default to the My Documents folder.
            this.folderBrowserDialog6.RootFolder = Environment.SpecialFolder.Personal;
            // Show the FolderBrowserDialog.

            var dirinfom = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
            string thepaththisprogramulfolder = dirinfom.FullName + @"\" + "#Cryofallscriptgen" + @"\" + "multiplied";


            DialogResult result = folderBrowserDialog6.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialog6.SelectedPath == null || folderBrowserDialog6.SelectedPath == "" || folderBrowserDialog6.SelectedPath == string.Empty)
                {
                    folderBrowserDialog6.SelectedPath = thepaththisprogramulfolder;
                    theselectedfoldermoveout = folderBrowserDialog6.SelectedPath;// Environment.GetFolderPath(Environment.SpecialFolder.Personal);//this.folderBrowserDialog6.RootFolder.ToString();
                }
                else
                {
                    theselectedfoldermoveout = folderBrowserDialog6.SelectedPath;
                }

                /*if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = theselectedfolderin;
                    openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }*/

                button17.BackColor = System.Drawing.Color.Green;
                button17.Refresh();

            }
            else
            {
                theselectedfoldermoveout = "";
                button17.BackColor = System.Drawing.Color.Red;
                button17.Refresh();
            }

        }

        private void openFileDialog2_FileOk(global::System.Object sender, global::System.ComponentModel.CancelEventArgs e)
        {

        }

        private void folderBrowserDialog4_HelpRequest(global::System.Object sender, global::System.EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(global::System.Object sender, global::System.ComponentModel.CancelEventArgs e)
        {

        }



        public int button18swtc = 0;
        public int copymethodstartedornot = 0;
        private void button18_Click(global::System.Object sender, global::System.EventArgs e)
        {
            button18swtc = 1;
            copymethodstartedornot = 1;
            //button22.Enabled = false;

            if (theselectedfolderin != "" && theselectedfolderout != "" && theselectedfolderin != null && theselectedfolderout != null && theselectedfolderin != string.Empty && theselectedfolderout != string.Empty)
            {


                if (fastorslowcopy == 0)
                {
                    /*
                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
                    string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen";
                    string docPath = pathtomodsinprojectfolder;*/

                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;


                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = theselectedfolderin;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                    itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                    string pathtomods = "";

                    int counttheproblem = 0;

                    int mainninesmodsfoldercounter = 0;

                    foreach (var dir in dirs)
                    {
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                        directoryFolder0.Refresh();

                        string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                        //if (foldername.ToLower() == "multiplied")
                        {
                            pathtomods = docPath;

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            //string pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = theselectedfolderout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                                                                                     //Console.WriteLine(theselectedfolderout);


                            dirs1last.Push(pathtomods);

                            int counter = 0;

                            int endthread0 = 0;
                            var maincopythread = new Thread((tester0000) =>
                            {
                                int folderiteratormainlast = -1;
                                int folderiteratormain = 0;
                                int folderiteratorsec = 0;
                                int folderiteratorseclast = -1;

                                string thecurrentpathlast = "";
                                List<string> dirs1 = null;
                                string[] arrayoffiles = null;
                                string foldername2 = "";
                                itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                                string thepathtocopyfolder = "";

                                int listoffilescounter = 0;
                                int listoffilesorigincount = 0;

                                int dirs1count = 0;
                                int disr1swtc = 0;

                                int folderiteratorsecswtc = 0;
                                DirectoryInfo directoryFolder;
                                string poppedstring = "";
                                string anotherpath = "";
                                string ateststring = "";
                                string thecopiedfilepath = "";
                                string thefinalpath = "";
                                string thecurrentpath = "";

                            _thread_main_loop:

                                for (int fi = 0; fi < dirs1last.Count; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (dirs1last.Count <= 0)
                                    {
                                        Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                    }

                                    if (dirs1last.Count > 0)
                                    {
                                        if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                        {
                                            Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                            folderiteratormain = 0;
                                        }

                                        thecurrentpath = dirs1last.Peek(folderiteratormain);

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            if (disr1swtc == 0)
                                            {
                                                dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                                dirs1count = dirs1.Count;
                                                disr1swtc = 1;
                                            }

                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            if (dirs1count > 0)
                                            {

                                                for (int d = 0; d < dirs1.Count; d++)
                                                {


                                                    foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                    thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                    directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
                                                    directoryFolder.Refresh();

                                                    if (!Directory.Exists(thefinalpath))
                                                    {
                                                        Directory.CreateDirectory(thefinalpath);
                                                        dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                                    }

                                                    if (folderiteratorsecswtc == 0)
                                                    {
                                                        arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                        listoffilesorigincount = arrayoffiles.Length;
                                                        folderiteratorsecswtc = 1;
                                                    }

                                                    if (folderiteratorsecswtc == 1)
                                                    {
                                                        if (arrayoffiles != null)
                                                        {
                                                            if (arrayoffiles.Length > 0)
                                                            {
                                                                for (int f = 0; f < arrayoffiles.Length; f++)
                                                                {
                                                                    if (arrayoffiles[listoffilescounter] != null)
                                                                    {
                                                                        poppedstring = arrayoffiles[listoffilescounter];
                                                                        anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                        ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                                        thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                        if (!File.Exists(thecopiedfilepath))
                                                                        {
                                                                            File.Copy(poppedstring, thecopiedfilepath);
                                                                        }

                                                                        arrayoffiles[listoffilescounter] = null;
                                                                    }
                                                                    listoffilescounter++;


                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (listoffilescounter >= listoffilesorigincount)
                                                    {
                                                        folderiteratorsec++;
                                                        folderiteratorsecswtc = 0;
                                                        listoffilescounter = 0;
                                                    }

                                                }
                                            }
                                        }
                                    }


                                    if (folderiteratorsec >= dirs1count)
                                    {
                                        disr1swtc = 0;
                                        folderiteratormain++;
                                        folderiteratorsec = 0;
                                    }

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        //Program.MessageBox((IntPtr)0, "reached end of copy files.", "sccsmsg", 0);
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                                if (endthread0 == 0)
                                {
                                    Thread.Sleep(1);
                                    mainninesmodsfoldercounter++;

                                    goto _thread_main_loop;
                                }
                                else
                                {
                                    if (listoffiles != null)
                                    {
                                        listoffiles.Clear();
                                        listoffiles = null;
                                    }

                                    if (dirs1 != null)
                                    {
                                        dirs1.Clear();
                                        dirs1 = null;
                                    }

                                    arrayoffiles = null;

                                    if (dirs1last != null)
                                    {
                                        dirs1last.Clear();
                                        dirs1last = null;
                                    }

                                    copymethodstartedornot = 2;
                                    thetimer.Stop();
                                    Console.WriteLine("end of copy files. timer:" + thetimer.Elapsed.TotalSeconds);
                                    //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                                }

                            }, 0); //100000 //999999999

                            maincopythread.IsBackground = true;
                            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                            maincopythread.SetApartmentState(ApartmentState.STA);
                            maincopythread.Start();

                            break;
                        }
                    }

                    if (dirs == null)
                    {
                        copymethodstartedornot = 2;
                    }
                    else
                    {
                        if (dirs.Count == 0)
                        {
                            copymethodstartedornot = 2;
                        }
                        else
                        {

                        }
                    }

                }
                else if (fastorslowcopy == 2)
                {


                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;


                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = theselectedfolderin;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                    itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                    string pathtomods = "";

                    int counttheproblem = 0;

                    int mainninesmodsfoldercounter = 0;

                    foreach (var dir in dirs)
                    {
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                        directoryFolder0.Refresh();

                        string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                        //if (foldername.ToLower() == "multiplied")
                        {
                            pathtomods = docPath; // + @"\" + foldername

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            //string pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = theselectedfolderout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

                            dirs1last.Push(pathtomods);

                            int counter = 0;

                            int endthread0 = 0;
                            var maincopythread = new Thread((tester0000) =>
                            {
                                int folderiteratormainlast = -1;
                                int folderiteratormain = 0;
                                int folderiteratorsec = 0;
                                int folderiteratorseclast = -1;

                                string thecurrentpathlast = "";
                                List<string> dirs1 = null;
                                string[] arrayoffiles = null;
                                string foldername2 = "";
                                itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                                string thepathtocopyfolder = "";

                                int listoffilescounter = 0;
                                int listoffilesorigincount = 0;

                                int dirs1count = 0;
                                int disr1swtc = 0;

                                int folderiteratorsecswtc = 0;
                                DirectoryInfo directoryFolder;
                                string poppedstring = "";
                                string anotherpath = "";
                                string ateststring = "";
                                string thecopiedfilepath = "";
                                string thefinalpath = "";
                                string thecurrentpath = "";

                            _thread_main_loop:

                                for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (dirs1last.Count <= 0)
                                    {
                                        Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                    }

                                    if (dirs1last.Count > 0)
                                    {
                                        if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                        {
                                            Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                            folderiteratormain = 0;
                                        }

                                        thecurrentpath = dirs1last.Peek(folderiteratormain);

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            if (disr1swtc == 0)
                                            {
                                                dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                                dirs1count = dirs1.Count;
                                                disr1swtc = 1;
                                            }

                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            if (dirs1count > 0)
                                            {

                                                foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
                                                directoryFolder.Refresh();

                                                if (!Directory.Exists(thefinalpath))
                                                {
                                                    Directory.CreateDirectory(thefinalpath);
                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                                }

                                                if (folderiteratorsecswtc == 0)
                                                {
                                                    arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                    listoffilesorigincount = arrayoffiles.Length;
                                                    folderiteratorsecswtc = 1;
                                                }

                                                if (folderiteratorsecswtc == 1)
                                                {
                                                    if (arrayoffiles != null)
                                                    {
                                                        if (arrayoffiles.Length > 0)
                                                        {
                                                            if (arrayoffiles[listoffilescounter] != null)
                                                            {
                                                                poppedstring = arrayoffiles[listoffilescounter];
                                                                anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                                thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                if (!File.Exists(thecopiedfilepath))
                                                                {
                                                                    File.Copy(poppedstring, thecopiedfilepath);
                                                                }

                                                                arrayoffiles[listoffilescounter] = null;
                                                            }
                                                            listoffilescounter++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (listoffilescounter >= listoffilesorigincount)
                                    {
                                        folderiteratorsec++;
                                        folderiteratorsecswtc = 0;
                                        listoffilescounter = 0;
                                    }

                                    if (folderiteratorsec >= dirs1count)
                                    {
                                        disr1swtc = 0;
                                        folderiteratormain++;
                                        folderiteratorsec = 0;
                                    }

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        //Program.MessageBox((IntPtr)0, "reached end of copy files.", "sccsmsg", 0);
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                                if (endthread0 == 0)
                                {
                                    Thread.Sleep(1);
                                    mainninesmodsfoldercounter++;

                                    goto _thread_main_loop;
                                }
                                else
                                {

                                    if (listoffiles != null)
                                    {
                                        listoffiles.Clear();
                                        listoffiles = null;
                                    }

                                    if (dirs1 != null)
                                    {
                                        dirs1.Clear();
                                        dirs1 = null;
                                    }

                                    arrayoffiles = null;

                                    if (dirs1last != null)
                                    {
                                        dirs1last.Clear();
                                        dirs1last = null;
                                    }

                                    copymethodstartedornot = 2;
                                    thetimer.Stop();
                                    Console.WriteLine("end of copy files. timer:" + thetimer.Elapsed.TotalSeconds);
                                    //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                                }

                            }, 0); //100000 //999999999

                            maincopythread.IsBackground = true;
                            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                            maincopythread.SetApartmentState(ApartmentState.STA);
                            maincopythread.Start();

                            break;
                        }
                    }

                    if (dirs == null)
                    {
                        copymethodstartedornot = 2;
                    }
                    else
                    {
                        if (dirs.Count == 0)
                        {
                            copymethodstartedornot = 2;
                        }
                        else
                        {

                        }
                    }
                }
                else if (fastorslowcopy == 1)
                {


                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;


                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = theselectedfolderin;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                    itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                    string pathtomods = "";

                    int counttheproblem = 0;

                    int mainninesmodsfoldercounter = 0;

                    foreach (var dir in dirs)
                    {
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                        directoryFolder0.Refresh();

                        string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                        //if (foldername.ToLower() == "multiplied")
                        {
                            pathtomods = docPath; // + @"\" + foldername

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            //string pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = theselectedfolderout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

                            dirs1last.Push(pathtomods);

                            int counter = 0;

                            int endthread0 = 0;
                            var maincopythread = new Thread((tester0000) =>
                            {
                                int folderiteratormainlast = -1;
                                int folderiteratormain = 0;
                                int folderiteratorsec = 0;
                                int folderiteratorseclast = -1;

                                string thecurrentpathlast = "";
                                List<string> dirs1 = null;
                                string[] arrayoffiles = null;
                                string foldername2 = "";
                                itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                                string thepathtocopyfolder = "";

                                int listoffilescounter = 0;
                                int listoffilesorigincount = 0;

                                int dirs1count = 0;
                                int disr1swtc = 0;

                                int folderiteratorsecswtc = 0;
                                DirectoryInfo directoryFolder;
                                string poppedstring = "";
                                string anotherpath = "";
                                string ateststring = "";
                                string thecopiedfilepath = "";
                                string thefinalpath = "";
                                string thecurrentpath = "";

                            _thread_main_loop:

                                for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (dirs1last.Count <= 0)
                                    {
                                        Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                    }

                                    if (dirs1last.Count > 0)
                                    {
                                        if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                        {
                                            Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                            folderiteratormain = 0;
                                        }

                                        thecurrentpath = dirs1last.Peek(folderiteratormain);

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            if (disr1swtc == 0)
                                            {
                                                dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                                dirs1count = dirs1.Count;
                                                disr1swtc = 1;
                                            }

                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            if (dirs1count > 0)
                                            {

                                                foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
                                                directoryFolder.Refresh();

                                                if (!Directory.Exists(thefinalpath))
                                                {
                                                    Directory.CreateDirectory(thefinalpath);
                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                                }

                                                if (folderiteratorsecswtc == 0)
                                                {
                                                    arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                    listoffilesorigincount = arrayoffiles.Length;
                                                    folderiteratorsecswtc = 1;
                                                }

                                                if (folderiteratorsecswtc == 1)
                                                {
                                                    if (arrayoffiles != null)
                                                    {
                                                        if (arrayoffiles.Length > 0)
                                                        {
                                                            if (arrayoffiles[listoffilescounter] != null)
                                                            {
                                                                poppedstring = arrayoffiles[listoffilescounter];
                                                                anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                                thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                if (!File.Exists(thecopiedfilepath))
                                                                {
                                                                    File.Copy(poppedstring, thecopiedfilepath);
                                                                }

                                                                arrayoffiles[listoffilescounter] = null;
                                                            }
                                                            listoffilescounter++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (listoffilescounter >= listoffilesorigincount)
                                    {
                                        folderiteratorsec++;
                                        folderiteratorsecswtc = 0;
                                        listoffilescounter = 0;
                                    }

                                    if (folderiteratorsec >= dirs1count)
                                    {
                                        disr1swtc = 0;
                                        folderiteratormain++;
                                        folderiteratorsec = 0;
                                    }

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        //Program.MessageBox((IntPtr)0, "reached end of copy files.", "sccsmsg", 0);
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                                if (endthread0 == 0)
                                {
                                    Thread.Sleep(0);
                                    mainninesmodsfoldercounter++;

                                    goto _thread_main_loop;
                                }
                                else
                                {

                                    if (listoffiles != null)
                                    {
                                        listoffiles.Clear();
                                        listoffiles = null;
                                    }

                                    if (dirs1 != null)
                                    {
                                        dirs1.Clear();
                                        dirs1 = null;
                                    }

                                    arrayoffiles = null;

                                    if (dirs1last != null)
                                    {
                                        dirs1last.Clear();
                                        dirs1last = null;
                                    }

                                    copymethodstartedornot = 2;
                                    thetimer.Stop();
                                    Console.WriteLine("end of copy files. timer:" + thetimer.Elapsed.TotalSeconds);
                                    //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                                }

                            }, 0); //100000 //999999999

                            maincopythread.IsBackground = true;
                            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                            maincopythread.SetApartmentState(ApartmentState.STA);
                            maincopythread.Start();

                            break;
                        }
                    }

                    if (dirs == null)
                    {
                        copymethodstartedornot = 2;
                    }
                    else
                    {
                        if (dirs.Count == 0)
                        {
                            copymethodstartedornot = 2;
                        }
                        else
                        {

                        }
                    }
                }
            }
            else
            {

                button18swtc = 1;
                copymethodstartedornot = 2;

                if (theselectedfolderin != "" || theselectedfolderin != null || theselectedfolderin != string.Empty)
                {
                    Console.WriteLine("you need to select a folder copy in.");
                    Program.MessageBox((IntPtr)0, "you need to select a folder copy in.", "sccsmsg", 0);
                }

                if (theselectedfolderout != "" || theselectedfolderout != null || theselectedfolderout != string.Empty)
                {
                    Console.WriteLine("you need to select a folder copy out.");
                    Program.MessageBox((IntPtr)0, "you need to select a folder copy out.", "sccsmsg", 0);
                }




                // Console.WriteLine("you need to select ");
                //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);




            }

            //button22.Enabled = true;
        }

        string theselectedfoldermovein = "";
        string theselectedfoldermoveout = "";




        public int button19swtc = 0;
        public int movemethodstartedornot = 0;
        private void button19_Click(global::System.Object sender, global::System.EventArgs e)
        {

            movemethodstartedornot = 1;
            button19swtc = 1;

            //Console.WriteLine("theselectedfoldermovein:" + theselectedfoldermovein + "/theselectedfoldermoveout:" + theselectedfoldermoveout);

            //button21.Enabled = false;
            if (theselectedfoldermovein != "" && theselectedfoldermoveout != "" && theselectedfoldermovein != null && theselectedfoldermoveout != null && theselectedfoldermovein != string.Empty && theselectedfoldermoveout != string.Empty)
            {

                if (fastorslowmove == 0)
                {
                    /*
                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
                    string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen";
                    string docPath = pathtomodsinprojectfolder;*/

                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;


                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = theselectedfoldermovein;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                    itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                    string pathtomods = "";

                    int counttheproblem = 0;

                    int mainninesmodsfoldercounter = 0;

                    foreach (var dir in dirs)
                    {
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                        directoryFolder0.Refresh();

                        string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                        //if (foldername.ToLower() == "multiplied")
                        {
                            pathtomods = docPath;

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            //string pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = theselectedfoldermoveout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                                                                                         //Console.WriteLine(theselectedfolderout);


                            dirs1last.Push(pathtomods);

                            int counter = 0;

                            int endthread0 = 0;
                            var maincopythread = new Thread((tester0000) =>
                            {
                                int folderiteratormainlast = -1;
                                int folderiteratormain = 0;
                                int folderiteratorsec = 0;
                                int folderiteratorseclast = -1;

                                string thecurrentpathlast = "";
                                List<string> dirs1 = null;
                                string[] arrayoffiles = null;
                                string foldername2 = "";
                                itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                                string thepathtocopyfolder = "";

                                int listoffilescounter = 0;
                                int listoffilesorigincount = 0;

                                int dirs1count = 0;
                                int disr1swtc = 0;

                                int folderiteratorsecswtc = 0;
                                DirectoryInfo directoryFolder;
                                string poppedstring = "";
                                string anotherpath = "";
                                string ateststring = "";
                                string thecopiedfilepath = "";
                                string thefinalpath = "";
                                string thecurrentpath = "";

                            _thread_main_loop:

                                for (int fi = 0; fi < dirs1last.Count; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (dirs1last.Count <= 0)
                                    {
                                        Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                    }

                                    if (dirs1last.Count > 0)
                                    {
                                        if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                        {
                                            Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                            folderiteratormain = 0;
                                        }

                                        thecurrentpath = dirs1last.Peek(folderiteratormain);

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            if (disr1swtc == 0)
                                            {
                                                dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                                dirs1count = dirs1.Count;
                                                disr1swtc = 1;
                                            }

                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            if (dirs1count > 0)
                                            {

                                                for (int d = 0; d < dirs1.Count; d++)
                                                {


                                                    foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                    thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                    directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
                                                    directoryFolder.Refresh();

                                                    if (!Directory.Exists(thefinalpath))
                                                    {
                                                        Directory.CreateDirectory(thefinalpath);
                                                        dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                                    }

                                                    if (folderiteratorsecswtc == 0)
                                                    {
                                                        arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                        listoffilesorigincount = arrayoffiles.Length;
                                                        folderiteratorsecswtc = 1;
                                                    }

                                                    if (folderiteratorsecswtc == 1)
                                                    {
                                                        if (arrayoffiles != null)
                                                        {
                                                            if (arrayoffiles.Length > 0)
                                                            {
                                                                for (int f = 0; f < arrayoffiles.Length; f++)
                                                                {
                                                                    if (arrayoffiles[listoffilescounter] != null)
                                                                    {
                                                                        poppedstring = arrayoffiles[listoffilescounter];
                                                                        anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                        ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                                        thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                        if (!File.Exists(thecopiedfilepath))
                                                                        {
                                                                            File.Move(poppedstring, thecopiedfilepath);
                                                                        }

                                                                        arrayoffiles[listoffilescounter] = null;
                                                                    }
                                                                    listoffilescounter++;


                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (listoffilescounter >= listoffilesorigincount)
                                                    {
                                                        folderiteratorsec++;
                                                        folderiteratorsecswtc = 0;
                                                        listoffilescounter = 0;
                                                    }

                                                }
                                            }
                                        }
                                    }


                                    if (folderiteratorsec >= dirs1count)
                                    {
                                        disr1swtc = 0;
                                        folderiteratormain++;
                                        folderiteratorsec = 0;
                                    }

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        //Program.MessageBox((IntPtr)0, "reached end of copy files.", "sccsmsg", 0);
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                                if (endthread0 == 0)
                                {
                                    Thread.Sleep(1);
                                    mainninesmodsfoldercounter++;

                                    goto _thread_main_loop;
                                }
                                else
                                {

                                    for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                    {
                                        var poppedvalue = dirs1last.Pop();

                                        if (poppedvalue != "multiplied")
                                        {


                                            if (Directory.Exists(poppedvalue))
                                            {
                                                var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                                if (currentdirsinfolder != null)
                                                {
                                                    if (currentdirsinfolder.Count == 0)
                                                    {
                                                        if (Directory.Exists(poppedvalue))
                                                        {
                                                            Directory.Delete(poppedvalue);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                        {

                                                            if (currentdirsinfolder[i] != "multiplied")
                                                            {
                                                                var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                                var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                                if (folderemptyornot == null)
                                                                {
                                                                    if (Directory.Exists(currentdirsinfolder[i]))
                                                                    {
                                                                        if (currentdirsinfolder1 == null)
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (currentdirsinfolder1.Count > 0)
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                                {
                                                                                    Directory.Delete(currentdirsinfolder[i]);
                                                                                }

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (folderemptyornot.Length > 0)
                                                                    {

                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1 == null)
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (currentdirsinfolder1.Count > 0)
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                                {
                                                                                    Directory.Delete(currentdirsinfolder[i]);
                                                                                }

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (Directory.Exists(poppedvalue))
                                                        {
                                                            Directory.Delete(poppedvalue);
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (listoffiles != null)
                                    {
                                        listoffiles.Clear();
                                        listoffiles = null;
                                    }

                                    if (dirs1 != null)
                                    {
                                        dirs1.Clear();
                                        dirs1 = null;
                                    }

                                    arrayoffiles = null;

                                    if (dirs1last != null)
                                    {
                                        dirs1last.Clear();
                                        dirs1last = null;
                                    }

                                    movemethodstartedornot = 2;
                                    thetimer.Stop();
                                    Console.WriteLine("end of move files. timer:" + thetimer.Elapsed.TotalSeconds);
                                    //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                                }

                            }, 0); //100000 //999999999

                            maincopythread.IsBackground = true;
                            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                            maincopythread.SetApartmentState(ApartmentState.STA);
                            maincopythread.Start();

                            break;
                        }
                    }

                    if (dirs == null)
                    {
                        movemethodstartedornot = 2;
                    }
                    else
                    {
                        if (dirs.Count == 0)
                        {
                            movemethodstartedornot = 2;
                        }
                        else
                        {

                        }
                    }

                }
                else if (fastorslowmove == 2)
                {


                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;


                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = theselectedfoldermovein;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                    itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                    string pathtomods = "";

                    int counttheproblem = 0;

                    int mainninesmodsfoldercounter = 0;

                    foreach (var dir in dirs)
                    {
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                        directoryFolder0.Refresh();

                        string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                        //if (foldername.ToLower() == "multiplied")
                        {
                            pathtomods = docPath; // + @"\" + foldername

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            //string pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = theselectedfoldermoveout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

                            dirs1last.Push(pathtomods);

                            int counter = 0;

                            int endthread0 = 0;
                            var maincopythread = new Thread((tester0000) =>
                            {
                                int folderiteratormainlast = -1;
                                int folderiteratormain = 0;
                                int folderiteratorsec = 0;
                                int folderiteratorseclast = -1;

                                string thecurrentpathlast = "";
                                List<string> dirs1 = null;
                                string[] arrayoffiles = null;
                                string foldername2 = "";
                                itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                                string thepathtocopyfolder = "";

                                int listoffilescounter = 0;
                                int listoffilesorigincount = 0;

                                int dirs1count = 0;
                                int disr1swtc = 0;

                                int folderiteratorsecswtc = 0;
                                DirectoryInfo directoryFolder;
                                string poppedstring = "";
                                string anotherpath = "";
                                string ateststring = "";
                                string thecopiedfilepath = "";
                                string thefinalpath = "";
                                string thecurrentpath = "";

                            _thread_main_loop:

                                for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (dirs1last.Count <= 0)
                                    {
                                        Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                    }

                                    if (dirs1last.Count > 0)
                                    {
                                        if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                        {
                                            Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                            folderiteratormain = 0;
                                        }

                                        thecurrentpath = dirs1last.Peek(folderiteratormain);

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            if (disr1swtc == 0)
                                            {
                                                dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                                dirs1count = dirs1.Count;
                                                disr1swtc = 1;
                                            }

                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            if (dirs1count > 0)
                                            {

                                                foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
                                                directoryFolder.Refresh();

                                                if (!Directory.Exists(thefinalpath))
                                                {
                                                    Directory.CreateDirectory(thefinalpath);
                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                                }

                                                if (folderiteratorsecswtc == 0)
                                                {
                                                    arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                    listoffilesorigincount = arrayoffiles.Length;
                                                    folderiteratorsecswtc = 1;
                                                }

                                                if (folderiteratorsecswtc == 1)
                                                {
                                                    if (arrayoffiles != null)
                                                    {
                                                        if (arrayoffiles.Length > 0)
                                                        {
                                                            if (arrayoffiles[listoffilescounter] != null)
                                                            {
                                                                poppedstring = arrayoffiles[listoffilescounter];
                                                                anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                                thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                if (!File.Exists(thecopiedfilepath))
                                                                {
                                                                    File.Move(poppedstring, thecopiedfilepath);
                                                                }

                                                                arrayoffiles[listoffilescounter] = null;
                                                            }
                                                            listoffilescounter++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (listoffilescounter >= listoffilesorigincount)
                                    {
                                        folderiteratorsec++;
                                        folderiteratorsecswtc = 0;
                                        listoffilescounter = 0;
                                    }

                                    if (folderiteratorsec >= dirs1count)
                                    {
                                        disr1swtc = 0;
                                        folderiteratormain++;
                                        folderiteratorsec = 0;
                                    }

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        //Program.MessageBox((IntPtr)0, "reached end of copy files.", "sccsmsg", 0);
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                                if (endthread0 == 0)
                                {
                                    Thread.Sleep(1);
                                    mainninesmodsfoldercounter++;

                                    goto _thread_main_loop;
                                }
                                else
                                {
                                    for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                    {
                                        var poppedvalue = dirs1last.Pop();

                                        if (poppedvalue != "multiplied")
                                        {


                                            if (Directory.Exists(poppedvalue))
                                            {
                                                var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                                if (currentdirsinfolder != null)
                                                {
                                                    if (currentdirsinfolder.Count == 0)
                                                    {
                                                        if (Directory.Exists(poppedvalue))
                                                        {
                                                            Directory.Delete(poppedvalue);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                        {

                                                            if (currentdirsinfolder[i] != "multiplied")
                                                            {
                                                                var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                                var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                                if (folderemptyornot == null)
                                                                {
                                                                    if (Directory.Exists(currentdirsinfolder[i]))
                                                                    {
                                                                        if (currentdirsinfolder1 == null)
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (currentdirsinfolder1.Count > 0)
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                                {
                                                                                    Directory.Delete(currentdirsinfolder[i]);
                                                                                }

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (folderemptyornot.Length > 0)
                                                                    {

                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1 == null)
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (currentdirsinfolder1.Count > 0)
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                                {
                                                                                    Directory.Delete(currentdirsinfolder[i]);
                                                                                }

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (Directory.Exists(poppedvalue))
                                                        {
                                                            Directory.Delete(poppedvalue);
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    if (listoffiles != null)
                                    {
                                        listoffiles.Clear();
                                        listoffiles = null;
                                    }

                                    if (dirs1 != null)
                                    {
                                        dirs1.Clear();
                                        dirs1 = null;
                                    }

                                    arrayoffiles = null;

                                    if (dirs1last != null)
                                    {
                                        dirs1last.Clear();
                                        dirs1last = null;
                                    }

                                    movemethodstartedornot = 2;
                                    thetimer.Stop();
                                    Console.WriteLine("end of move files. timer:" + thetimer.Elapsed.TotalSeconds);
                                    //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                                }

                            }, 0); //100000 //999999999

                            maincopythread.IsBackground = true;
                            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                            maincopythread.SetApartmentState(ApartmentState.STA);
                            maincopythread.Start();

                            break;
                        }
                    }


                    if (dirs == null)
                    {
                        movemethodstartedornot = 2;
                    }
                    else
                    {
                        if (dirs.Count == 0)
                        {
                            movemethodstartedornot = 2;
                        }
                        else
                        {

                        }
                    }
                }
                else if (fastorslowmove == 1)
                {


                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;


                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = theselectedfoldermovein;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                    itsalmostastack<string> dirs1last = new itsalmostastack<string>();

                    string pathtomods = "";

                    int counttheproblem = 0;

                    int mainninesmodsfoldercounter = 0;

                    foreach (var dir in dirs)
                    {
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                        directoryFolder0.Refresh();

                        string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                        //if (foldername.ToLower() == "multiplied")
                        {
                            pathtomods = docPath; // + @"\" + foldername

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            //string pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = theselectedfoldermoveout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

                            dirs1last.Push(pathtomods);

                            int counter = 0;

                            int endthread0 = 0;
                            var maincopythread = new Thread((tester0000) =>
                            {
                                int folderiteratormainlast = -1;
                                int folderiteratormain = 0;
                                int folderiteratorsec = 0;
                                int folderiteratorseclast = -1;

                                string thecurrentpathlast = "";
                                List<string> dirs1 = null;
                                string[] arrayoffiles = null;
                                string foldername2 = "";
                                itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                                string thepathtocopyfolder = "";

                                int listoffilescounter = 0;
                                int listoffilesorigincount = 0;

                                int dirs1count = 0;
                                int disr1swtc = 0;

                                int folderiteratorsecswtc = 0;
                                DirectoryInfo directoryFolder;
                                string poppedstring = "";
                                string anotherpath = "";
                                string ateststring = "";
                                string thecopiedfilepath = "";
                                string thefinalpath = "";
                                string thecurrentpath = "";

                            _thread_main_loop:

                                for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                {
                                    if (dirs1last.Count <= 0)
                                    {
                                        Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                    }

                                    if (dirs1last.Count > 0)
                                    {
                                        if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                        {
                                            Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

                                            folderiteratormain = 0;
                                        }

                                        thecurrentpath = dirs1last.Peek(folderiteratormain);

                                        if (Directory.Exists(thecurrentpath))
                                        {
                                            if (disr1swtc == 0)
                                            {
                                                dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
                                                dirs1count = dirs1.Count;
                                                disr1swtc = 1;
                                            }

                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            if (dirs1count > 0)
                                            {

                                                foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
                                                directoryFolder.Refresh();

                                                if (!Directory.Exists(thefinalpath))
                                                {
                                                    Directory.CreateDirectory(thefinalpath);
                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);
                                                }

                                                if (folderiteratorsecswtc == 0)
                                                {
                                                    arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
                                                    listoffilesorigincount = arrayoffiles.Length;
                                                    folderiteratorsecswtc = 1;
                                                }

                                                if (folderiteratorsecswtc == 1)
                                                {
                                                    if (arrayoffiles != null)
                                                    {
                                                        if (arrayoffiles.Length > 0)
                                                        {
                                                            if (arrayoffiles[listoffilescounter] != null)
                                                            {
                                                                poppedstring = arrayoffiles[listoffilescounter];
                                                                anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                                                                thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                if (!File.Exists(thecopiedfilepath))
                                                                {
                                                                    File.Move(poppedstring, thecopiedfilepath);
                                                                }

                                                                arrayoffiles[listoffilescounter] = null;
                                                            }
                                                            listoffilescounter++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (listoffilescounter >= listoffilesorigincount)
                                    {
                                        folderiteratorsec++;
                                        folderiteratorsecswtc = 0;
                                        listoffilescounter = 0;
                                    }

                                    if (folderiteratorsec >= dirs1count)
                                    {
                                        disr1swtc = 0;
                                        folderiteratormain++;
                                        folderiteratorsec = 0;
                                    }

                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                    {
                                        //Program.MessageBox((IntPtr)0, "reached end of copy files.", "sccsmsg", 0);
                                        endthread0 = 1;
                                        folderiteratormain = 0;
                                    }
                                }

                                if (endthread0 == 0)
                                {
                                    Thread.Sleep(0);
                                    mainninesmodsfoldercounter++;

                                    goto _thread_main_loop;
                                }
                                else
                                {
                                    for (int fo = dirs1last.Count - 1; fo >= 1; fo--)
                                    {
                                        var poppedvalue = dirs1last.Pop();

                                        if (poppedvalue != "multiplied")
                                        {


                                            if (Directory.Exists(poppedvalue))
                                            {
                                                var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(poppedvalue));

                                                if (currentdirsinfolder != null)
                                                {
                                                    if (currentdirsinfolder.Count == 0)
                                                    {
                                                        if (Directory.Exists(poppedvalue))
                                                        {
                                                            Directory.Delete(poppedvalue);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        for (int i = 0; i < currentdirsinfolder.Count; i++)
                                                        {

                                                            if (currentdirsinfolder[i] != "multiplied")
                                                            {
                                                                var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                                                                var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                                                                if (folderemptyornot == null)
                                                                {
                                                                    if (Directory.Exists(currentdirsinfolder[i]))
                                                                    {
                                                                        if (currentdirsinfolder1 == null)
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (currentdirsinfolder1.Count > 0)
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                                {
                                                                                    Directory.Delete(currentdirsinfolder[i]);
                                                                                }

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (folderemptyornot.Length > 0)
                                                                    {

                                                                    }
                                                                    else
                                                                    {
                                                                        if (currentdirsinfolder1 == null)
                                                                        {
                                                                            if (Directory.Exists(currentdirsinfolder[i]))
                                                                            {
                                                                                Directory.Delete(currentdirsinfolder[i]);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (currentdirsinfolder1.Count > 0)
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                if (Directory.Exists(currentdirsinfolder[i]))
                                                                                {
                                                                                    Directory.Delete(currentdirsinfolder[i]);
                                                                                }

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (Directory.Exists(poppedvalue))
                                                        {
                                                            Directory.Delete(poppedvalue);
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (Directory.Exists(poppedvalue))
                                                    {
                                                        Directory.Delete(poppedvalue);
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    if (listoffiles != null)
                                    {
                                        listoffiles.Clear();
                                        listoffiles = null;
                                    }

                                    if (dirs1 != null)
                                    {
                                        dirs1.Clear();
                                        dirs1 = null;
                                    }

                                    arrayoffiles = null;

                                    if (dirs1last != null)
                                    {
                                        dirs1last.Clear();
                                        dirs1last = null;
                                    }

                                    movemethodstartedornot = 2;
                                    thetimer.Stop();
                                    Console.WriteLine("end of move files. timer:" + thetimer.Elapsed.TotalSeconds);
                                    //Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                                }

                            }, 0); //100000 //999999999

                            maincopythread.IsBackground = true;
                            maincopythread.Priority = ThreadPriority.Normal; //AboveNormal
                            maincopythread.SetApartmentState(ApartmentState.STA);
                            maincopythread.Start();

                            break;
                        }
                    }


                    if (dirs == null)
                    {
                        movemethodstartedornot = 2;
                    }
                    else
                    {
                        if (dirs.Count == 0)
                        {
                            movemethodstartedornot = 2;
                        }
                        else
                        {

                        }
                    }
                }

            }
            else
            {


                movemethodstartedornot = 2;
                button19swtc = 1;

                if (theselectedfoldermovein != "" || theselectedfoldermovein != null || theselectedfoldermovein != string.Empty)
                {
                    Console.WriteLine("you need to select a folder move in.");
                    Program.MessageBox((IntPtr)0, "you need to select a folder move in.", "sccsmsg", 0);
                }

                if (theselectedfoldermoveout != "" || theselectedfoldermoveout != null || theselectedfoldermoveout != string.Empty)
                {
                    Console.WriteLine("you need to select a folder move out.");
                    Program.MessageBox((IntPtr)0, "you need to select a folder move out.", "sccsmsg", 0);
                }


            }



            //button21.Enabled = true;

        }





        public int indexofdeleteoptiontypelast = 0;
        private void button20_Click(global::System.Object sender, global::System.EventArgs e)
        {
            //indexofdeleteoptiontype = 0;


            if (indexofdeleteoptiontype == 0)
            {
                button20.Text = "D" + "\n" + ">>";
                button20.Refresh();
                indexofdeleteoptiontype = 1;
            }
            else if (indexofdeleteoptiontype == 1)
            {
                button20.Text = "D" + "\n" + ">";
                button20.Refresh();
                indexofdeleteoptiontype = 2;
            }
            else if (indexofdeleteoptiontype == 2)
            {
                button20.Text = "D" + "\n" + ">>>";
                button20.Refresh();
                indexofdeleteoptiontype = 0;
            }
            //indexofdeleteoptiontypelast = indexofdeleteoptiontype;
            /*
            if (button20.Enabled)
            {
                button20.Enabled = false;
            }*/
        }

        private void button21_Click(global::System.Object sender, global::System.EventArgs e)
        {
            if (fastorslowmove == 0)
            {
                button21.Text = "M" + "\n" + ">>";
                button21.Refresh();
                fastorslowmove = 1;
            }
            else if (fastorslowmove == 1)
            {
                button21.Text = "M" + "\n" + ">";
                button21.Refresh();
                fastorslowmove = 2;
            }
            else if (fastorslowmove == 2)
            {
                button21.Text = "M" + "\n" + ">>>";
                button21.Refresh();
                fastorslowmove = 0;
            }
        }

        private void button22_Click(global::System.Object sender, global::System.EventArgs e)
        {
            if (fastorslowcopy == 0)
            {
                button22.Text = "C" + "\n" + ">>";
                button22.Refresh();
                fastorslowcopy = 1;
            }
            else if (fastorslowcopy == 1)
            {
                button22.Text = "C" + "\n" + ">";
                button22.Refresh();
                fastorslowcopy = 2;
            }
            else if (fastorslowcopy == 2)
            {
                button22.Text = "C" + "\n" + ">>>";
                button22.Refresh();
                fastorslowcopy = 0;
            }
        }



        //https://stackoverflow.com/questions/748387/how-to-remove-a-stack-item-which-is-not-on-the-top-of-the-stack-in-c-sharp
        public class itsalmostastack<T>
        {
            public int Count
            {
                get
                {
                    return items.Count;
                }
            }
            public void Clear()
            {
                items.Clear();
            }
            public T Peek(int index)
            {

                if (index < items.Count)
                {
                    return items[index];
                }
                return default(T);
            }

            private List<T> items = new List<T>();

            public void Push(T item)
            {
                items.Add(item);
            }

            public T Pop()
            {
                if (items.Count > 0)
                {
                    T temp = items[items.Count - 1];
                    items.RemoveAt(items.Count - 1);
                    return temp;
                }
                else
                {
                    return default(T);
                }
            }
            public T PopAtStart()
            {
                if (items.Count > 0)
                {
                    T temp = items[0];
                    items.RemoveAt(0);
                    return temp;
                }
                else
                {
                    return default(T);
                }
            }

            public void Remove(int itemAtPosition)
            {
                items.RemoveAt(itemAtPosition);
            }
        }


    }
}






/*
if (arrayoffiles == null)
{
    if (Directory.Exists(thefinalpath))
    {
        Directory.Delete(thefinalpath);
        //dirs1.Remove(thefinalpath);
    }
}*/

/*
if (deletingfilecounter >= listoffilesorigincount)
{

    var currentdirsinfolder = new List<string>(Directory.EnumerateDirectories(thefinalpath));

    if (currentdirsinfolder!= null)
    {
        if (currentdirsinfolder.Count == 0)
        {
            if (Directory.Exists(thefinalpath))
            {
                Directory.Delete(thefinalpath);
                //dirs1.Remove(thefinalpath);
            }
        }
        else
        {
            for (int i = 0;i < currentdirsinfolder.Count;i++)
            {
                var folderemptyornot = Directory.GetFiles(currentdirsinfolder[i]);
                var currentdirsinfolder1 = new List<string>(Directory.EnumerateDirectories(currentdirsinfolder[i]));

                if (folderemptyornot == null)
                {
                    if (Directory.Exists(thefinalpath))
                    {
                        Directory.Delete(thefinalpath);
                        //dirs1.Remove(thefinalpath);
                    }
                }
                else
                {
                    if (folderemptyornot.Length > 0)
                    {

                    }
                    else
                    {
                        if (currentdirsinfolder1 == null)
                        {
                            if (Directory.Exists(thefinalpath))
                            {
                                Directory.Delete(thefinalpath);
                                //dirs1.Remove(thefinalpath);
                            }
                        }
                        else
                        {
                            if (currentdirsinfolder1.Count > 0)
                            {

                            }
                            else
                            {
                                if (Directory.Exists(currentdirsinfolder[i]))
                                {
                                    Directory.Delete(currentdirsinfolder[i]);
                                    //dirs1.Remove(thefinalpath);
                                }
                            }
                        }
                    }
                }

            }
        }
    }
    else
    {
        if (Directory.Exists(thefinalpath))
        {
            Directory.Delete(thefinalpath);
            //dirs1.Remove(thefinalpath);
        }
    }







    /*
    if (Directory.Exists(thefinalpath))
    {
        Directory.Delete(thefinalpath);
        //dirs1.Remove(thefinalpath);
    }
}*/




/*
for (int fo = dirs2last.Count - 1; fo >= 0; fo--)
{
    var poppedvalue = dirs2last.Pop();
    if (Directory.Exists(poppedvalue))
    {
        Directory.Delete(poppedvalue);
        //dirs2last.Remove(poppedvalue);
    }
}
*/













/*
if (Directory.Exists(thefinalpath))
{
    Directory.Delete(thefinalpath);
}*/


//foldername1 = $"{thecurrentpath.Substring(thecurrentpath.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";








/*
if (Directory.Exists(thecurrentpath))
{
    if (disr1swtc == 0)
    {
        dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));
        dirs1count = dirs1.Count;
        disr1swtc = 1;
    }

    thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

    if (dirs1count > 0)
    {

        foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
        thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

        directoryFolder = new DirectoryInfo(thefinalpath);// dirs1[folderiteratorsec]);
        directoryFolder.Refresh();

        //if (!Directory.Exists(thefinalpath))
        //{
        //    Directory.CreateDirectory(thefinalpath);
        //    dirs1last.Push(thecurrentpath + @"\" + foldername2);
        //}

        if (folderiteratorsecswtc == 0)
        {
            arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);
            listoffilesorigincount = arrayoffiles.Length;
            folderiteratorsecswtc = 1;
        }

        if (folderiteratorsecswtc == 1)
        {
            if (arrayoffiles != null)
            {
                if (arrayoffiles.Length > 0)
                {
                    if (arrayoffiles[listoffilescounter] != null)
                    {
                        poppedstring = arrayoffiles[listoffilescounter];
                        anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                        ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);
                        thecopiedfilepath = thefinalpath + @"\" + ateststring;

                        if (File.Exists(thecopiedfilepath))
                        {
                            //File.Copy(poppedstring, thecopiedfilepath);

                            File.Delete(thecopiedfilepath);
                        }

                        arrayoffiles[listoffilescounter] = null;
                    }
                    listoffilescounter++;
                }
            }
        }
    }
}*/