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


using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using static sccsr16.Form1;

namespace sccsr16
{
    public partial class Form1 : Form
    {
        public static Form1 currentform;
        public static IntPtr theHandle;
        public Form1()
        {
            currentform = this;
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_Closing;
            this.FormClosed += Form1_Closed;



            Size somesize = new Size(1096, 600);

            this.ClientSize = somesize;

        }
        public int formwasloadedswtc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            theHandle = this.Handle;
            formwasloadedswtc = 1;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            //startmultiplicationprocessmainswtc = 1;

            sccs.sccsgraphicssec.currentsccsgraphicssec.startmultiplicationprocessswtc = 1;

        }




        int deletetypeofmethod = 1;
        private void button2_Click(object sender, EventArgs e)
        {



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


            if (deletetypeofmethod == 1)
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
                                Thread.Sleep(0);
                                mainninesmodsfoldercounter++;

                                goto _thread_main_loop;
                            }
                            else
                            {
                                for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                                {
                                    var poppedvalue = dirs1last.Pop();
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
                                                /*if (Directory.Exists(poppedvalue))
                                                {
                                                    Directory.Delete(poppedvalue);
                                                    //dirs1.Remove(poppedvalue);
                                                }*/
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


                                thetimer.Stop();
                                Console.WriteLine("timer:" + thetimer.Elapsed.TotalSeconds);
                                Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
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
            else if (deletetypeofmethod == 0)
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
                                Console.WriteLine("dirs1last.Count:" + dirs1last.Count);
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
                                thetimer.Stop();
                                Console.WriteLine("timer:" + thetimer.Elapsed.TotalSeconds);

                                Program.MessageBox((IntPtr)0, "end of delete files.", "sccsmsg", 0);
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {

            Stopwatch thetimer = new Stopwatch();
            thetimer.Start();

            //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
            //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

            var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen";


            //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files

            //var currentdirinfo = Directory.GetCurrentDirectory();

            //var theprocess = Process.GetCurrentProcess();




            //Console.WriteLine(Environment.CurrentDirectory);// theprocess.ProcessName);// theprocess.StartInfo.FileName);//currentdirinfo);





            string docPath = pathtomodsinprojectfolder ;//Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied" //Environment.SpecialFolder.Desktop);// 
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
            itsalmostastack<string> dirs1last = new itsalmostastack<string>();

            string pathtomods = "";

            int counttheproblem = 0;

            int mainninesmodsfoldercounter = 0;

            //foreach (var dir in dirs)
            {
                //DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                //directoryFolder0.Refresh();

                string foldername = "multiplied";// $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                //if (foldername.ToLower() == "multiplied")
                {
                    //pathtomods = docPath + @"\" + foldername;
                    pathtomods = docPath + @"\" + foldername;

                    // @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods" + @"\" 

                    //Console.WriteLine(docPath);// Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                    //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                    pathtomodsinprojectfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

                    //Console.WriteLine(pathtomodsinprojectfolder);// 

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
                                            //Directory.Move(thecurrentpath + @"\" + foldername2, thefinalpath);
                                        }
                                        else
                                        {
                                            //Directory.Move(thecurrentpath + @"\" + foldername2, thefinalpath);
                                        }
                  
                                        dirs1last.Push(thecurrentpath + @"\" + foldername2);

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
                                                            //File.Copy(poppedstring, thecopiedfilepath);
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
                            for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                            {
                                var poppedvalue = dirs1last.Pop();
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
                                            /*if (Directory.Exists(poppedvalue))
                                            {
                                                Directory.Delete(poppedvalue);
                                                //dirs1.Remove(poppedvalue);
                                            }*/
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


                            thetimer.Stop();
                            Console.WriteLine("timer:" + thetimer.Elapsed.TotalSeconds);
                            Program.MessageBox((IntPtr)0, "end of move files.", "sccsmsg", 0);
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

        private void button4_Click(object sender, EventArgs e)
        {

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

            foreach (var dir in dirs)
            {
                DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                directoryFolder0.Refresh();

                string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                if (foldername.ToLower() == "multiplied")
                {
                    pathtomods = docPath + @"\" + foldername;

                    //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                    string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

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


                            thetimer.Stop();
                            Console.WriteLine("timer:" + thetimer.Elapsed.TotalSeconds);
                            Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
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

        private void button6_Click(object sender, EventArgs e)
        {

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