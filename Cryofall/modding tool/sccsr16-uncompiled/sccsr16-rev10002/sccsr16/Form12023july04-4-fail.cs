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

            var _mainTasker00 = new Thread((tester0000) =>
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

            _mainTasker00.IsBackground = true;
            _mainTasker00.Priority = ThreadPriority.Normal; //AboveNormal
            _mainTasker00.SetApartmentState(ApartmentState.STA);
            _mainTasker00.Start();

            //_mainTasker00.Join();
        }



        //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.closing?view=windowsdesktop-7.0
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;


            int endthread0 = 0;

            var _mainTasker00 = new Thread((tester0000) =>
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

            _mainTasker00.IsBackground = true;
            _mainTasker00.Priority = ThreadPriority.Normal; //AboveNormal
            _mainTasker00.SetApartmentState(ApartmentState.STA);
            _mainTasker00.Start();

            //_mainTasker00.Join();

        }

        //public int startmultiplicationprocessmainswtc = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //startmultiplicationprocessmainswtc = 1;

            sccs.sccsgraphicssec.currentsccsgraphicssec.startmultiplicationprocessswtc = 1;

        }

        private void button2_Click(object sender, EventArgs e)
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
                    var _mainTasker00 = new Thread((tester0000) =>
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

                    _mainTasker00.IsBackground = true;
                    _mainTasker00.Priority = ThreadPriority.Normal; //AboveNormal
                    _mainTasker00.SetApartmentState(ApartmentState.STA);
                    _mainTasker00.Start();

                    break;
                }
            }












        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {

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


            //string pathroot = Directory.GetDirectoryRoot(dirinfo.Name);

            Console.WriteLine(dirinfo.FullName);






            listBox1.EndUpdate();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Stopwatch thetimer = new Stopwatch();
            thetimer.Start();

            //var dirinfo = Directory.GetCurrentDirectory();

            //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
            //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

            var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

            //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments);
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
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

                if (foldername.ToLower() == "multiplied")
                {
                    pathtomods = docPath + @"\" + foldername;

                    string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;



                    //dirs1last.Add(pathtomods);
                    dirs1last.Push(pathtomods);

                    int counter = 0;

                    //while (dirs1last.Count > 0) //while there are folders and files
                    //{
                    int endthread0 = 0;
                    var _mainTasker00 = new Thread((tester0000) =>
                    {


                        int folderiteratormain = 0;
                        //int folderiteratorsec = 0;

                        string thecurrentpathlast = "";
                        List<string> dirs1 = null;
                        string[] arrayoffiles = null;
                        string foldername2 = "";
                        itsalmostastack<string> listoffiles = new itsalmostastack<string>();
                        string thepathtocopyfolder = "";

                    _thread_main_loop:

                        if (dirs1last.Count > 0)
                        {




                            if (folderiteratormain >= dirs1last.Count)
                            {
                                folderiteratormain = 0;
                            }


                  

                            



                            //for (int fo = dirs1last.Count - 1; fo >= 0; fo--)
                            //for (int fo = 0; fo < dirs1last.Count; fo++)
                            {
                                string thecurrentpath = dirs1last.Peek(folderiteratormain);

                                if (dirs1last.Count > 0)
                                {
                                    string foldername1 = $"{thecurrentpath.Substring(thecurrentpath.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                                    if (Directory.Exists(thecurrentpath))
                                    {


                                     
                                        if (thecurrentpath != thecurrentpathlast)
                                        {
                                            dirs1 = new List<string>(Directory.EnumerateDirectories(thecurrentpath));

                                            if (dirs1 != null)
                                            {
                                                if (dirs1.Count > 0)
                                                {
                                                    /*DirectoryInfo directoryFolder = new DirectoryInfo(dirs1[folderiteratorsec]);
                                                    directoryFolder.Refresh();

                                                    //Console.WriteLine(dir1);
                                                    foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                                    //Console.WriteLine(foldername2);
                                                    thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                                    arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);

                                                    listoffiles = new itsalmostastack<string>();

                                                    if (arrayoffiles.Length > 0)
                                                    {
                                                        //listoffiles = new List<string>();
                                                        for (int i = 0; i < arrayoffiles.Length; i++)
                                                        {
                                                            //listoffiles.Add(arrayoffiles[i]);
                                                            listoffiles.Push(arrayoffiles[i]);

                                                        }
                                                    }*/
                                                }
                                            }
                                            else
                                            {
                                                //listoffiles.Pop();
                                            }
                                        }






                                        for (int folderiteratorsec = 0; folderiteratorsec < dirs1.Count; folderiteratorsec++)
                                        //foreach (var dir1 in dirs1)
                                        {
                                            DirectoryInfo directoryFolder = new DirectoryInfo(dirs1[folderiteratorsec]);
                                            directoryFolder.Refresh();

                                            //Console.WriteLine(dir1);
                                            foldername2 = $"{dirs1[folderiteratorsec].Substring(dirs1[folderiteratorsec].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                            //Console.WriteLine(foldername2);
                                            thepathtocopyfolder = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);

                                            arrayoffiles = Directory.GetFiles(dirs1[folderiteratorsec]);

                                            listoffiles = new itsalmostastack<string>();

                                            if (arrayoffiles.Length > 0)
                                            {
                                                //listoffiles = new List<string>();
                                                for (int i = 0; i < arrayoffiles.Length; i++)
                                                {
                                                    //listoffiles.Add(arrayoffiles[i]);
                                                    listoffiles.Push(arrayoffiles[i]);

                                                }
                                            }
                                            //string thecurrentfolderinmod = pathtomodsinprojectfolder + @"\" + foldername1;

                                            //if (!Directory.Exists(thecurrentfolderinmod))
                                            //{
                                            //    Directory.CreateDirectory(thecurrentfolderinmod);
                                            //}


                                            //Console.WriteLine(arrayoffiles.Length);



                                            //Console.WriteLine(thepathtocopyfolder);
                                            if (foldername2.ToLower() != "multiplied")
                                            {
                                                
                                                //string thecurrentfolderinmod = pathtomodsinprojectfolder + @"\" + foldername2;
                                                //if (!Directory.Exists(thecurrentfolderinmod))
                                                //{
                                                //    Directory.CreateDirectory(thecurrentfolderinmod);
                                                //}
                                                

                                                string thepathtomultiplied = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);
                                                //Console.WriteLine(thepathtomultiplied);
                                                Console.WriteLine("new dir:" + pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2);

                                                string thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2;

                                                if (!Directory.Exists(thefinalpath))
                                                {
                                                    Directory.CreateDirectory(thefinalpath);
                                                }

                                                dirs2last.Add(thecurrentpath + @"\" + foldername2);
                                                //dirs1last.Add(thecurrentpath + @"\" + foldername2);
                                                dirs1last.Push(thecurrentpath + @"\" + foldername2);

                                                //astack.Push(dirs1last[fo] + @"\" + foldername2);

                                                //Console.WriteLine(dirs1last[fo]);
                                                //Console.WriteLine("counttheproblem:" + counttheproblem);
                                                //if (dirs1last.Count > 0 && fo >= 0)
                                                //{

                                                //}

                                                counttheproblem++;
                                            }
                                            
                                            if (listoffiles != null)
                                            {
                                                if (listoffiles.Count > 0)
                                                {

                                                    for (int f = listoffiles.Count-1; f >= 0; f--)
                                                    //for (int f = 0; f < listoffiles.Count; f++)
                                                    {
                                                        string poppedstring = listoffiles.Pop();


                                                        if (!string.IsNullOrEmpty(poppedstring) && !string.IsNullOrWhiteSpace(poppedstring))
                                                        {
                                                            string thefilemobname1 = poppedstring.Substring(dirs1[folderiteratorsec].Length + 1, (poppedstring.Length) - dirs1[folderiteratorsec].Length - 1);

                                                            string thepathtomultiplied = thecurrentpath.Substring(pathtomods.Length, thecurrentpath.Length - pathtomods.Length);
                                                            //Console.WriteLine(thepathtomultiplied);
                                                            //Console.WriteLine("new dir:" + pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2);

                                                            string thefinalpath = pathtomodsinprojectfolder + thepathtocopyfolder + @"\" + foldername2 + @"\" + thefilemobname1;
                                                            //Console.WriteLine(finalpath);
                                                            if (File.Exists(thefinalpath))
                                                            {
                                                                Program.MessageBox((IntPtr)0, "the file already exists", "sccsmsg", 0);
                                                                //dirs1last.Pop();
                                                                //File.Delete(thefinalpath);

                                                                //File.Copy(poppedstring, thefinalpath);

                                                            }
                                                            else
                                                            {
                                                                File.Copy(poppedstring, thefinalpath);

                                                            }
                                                        }
                                                        else
                                                        {
                                                            Program.MessageBox((IntPtr)0, "the file already exists1", "sccsmsg", 0);
                                                        }

                                                        //if (listoffiles.Count > 0)
                                                        //{
                                                        //    listoffiles.Remove(poppedstring);
                                                        //}
                                                    }
                                                }
                                            }
                                            else
                                            {

                                            }


                                            folderiteratorsec++;

                                            if (dirs1 != null)
                                            {
                                                if (folderiteratorsec >= dirs1.Count)
                                                {
                                                    folderiteratormain++;

                                                    folderiteratorsec = 0;
                                                }
                                            }
                                        }

                                        thecurrentpathlast = thecurrentpath;

                                    }
                                    //break;

                                }

                            }
                            //folderiteratormain++;



                            /*
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
                            */

                            /*
                            for (int fo = dirs2last.Count - 1; fo >= 0; fo--)
                            {
                                if (Directory.Exists(dirs2last[fo]))
                                {
                                    //Directory.Delete(dirs2last[fo]);
                                    dirs2last.Remove(dirs2last[fo]);
                                }
                            }*/

                            counter++;
                        }

                        //Console.WriteLine(dirs1last.Count);
                        /*
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
                        }*/

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

                            Program.MessageBox((IntPtr)0, "end of copy files.", "sccsmsg", 0);
                            //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);
                        }

                    }, 0); //100000 //999999999

                    _mainTasker00.IsBackground = true;
                    _mainTasker00.Priority = ThreadPriority.Normal; //AboveNormal
                    _mainTasker00.SetApartmentState(ApartmentState.STA);
                    _mainTasker00.Start();

                    break;
                }
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
            public void Remove(int itemAtPosition)
            {
                items.RemoveAt(itemAtPosition);
            }
        }


    }
}
















/*
if (dirs2last.Count > 0)
{
    for (int fo2 = 0; fo2 < dirs2last.Count; fo2++)
    {
        var foldername1 = $"{dirs2last[fo2].Substring(dirs2last[fo2].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

       // List<string> dirs11 = new List<string>(Directory.EnumerateDirectories(dirs2last[fo2]));
        /*
        foreach (var dir1 in dirs11)
        {
            Console.WriteLine(dir1);
        }
    }
}*/
/*

if (dirs2last.Count > 0)
{
    for (int f = 0; f < dirs2last.Count; f++)
    {
        if (dirs2last.Count > 0)
        {
            Console.WriteLine(dirs2last[f]);
        }
    }
}

*/







/*foreach (var dir1 in dirs1)
{
    //string modmpkname = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
    //listBox1.Items.Add(modmpkname);

    //File.Delete(dir1);
    Directory.Delete(dir1);
}*/







//sccs.sccsgraphicssec.currentsccsgraphicssec.hastodeletefilesswtc = 1;





/*
for (int fo2 = 0; fo2 < dirs2last.Count; fo2++)
{
   var foldername1 = $"{dirs1last[fo].Substring(dirs1last[fo].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

    List<string> dirs11 = new List<string>(Directory.EnumerateDirectories(dirs1last[fo]));

    foreach (var dir1 in dirs11)
    {
        //Console.WriteLine(dir1);
        string foldername2 = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
        Console.WriteLine(foldername2);

        var arrayoffiles = Directory.GetFiles(dir1);

        //Console.WriteLine(arrayoffiles.Length);

        for (int f = 0; f < arrayoffiles.Length; f++)
        {
            File.Delete(arrayoffiles[f]);
        }

        if (foldername2.ToLower() != "multiplied")
        {
            dirs2last.Add(dirs1last[fo] + @"\" + foldername2);

            Console.WriteLine(dirs1last[fo] + @"\" + foldername2);
        }
    }
}*/






/*DirectoryInfo directoryFolder = new DirectoryInfo(pathtomods);
directoryFolder.Refresh();

List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));

foreach (var dir1 in dirs1)
{
    var arrayoffiles = Directory.GetFiles(dir1);

    //Console.WriteLine(arrayoffiles.Length);

    for (int f = 0; f < arrayoffiles.Length; f++)
    {
        File.Delete(arrayoffiles[f]);

    }
}

dirs1last.Clear();

for (int folderi = 0; folderi < dirs1.Count; folderi++)
{
    dirs1last.Add(dirs1[folderi]);
}*/

//string pathtomods = docPath + @"\" + foldername + @"\" + "CryoFall\\Mods";


/*if (mainninesmodsfoldercounter == 0)
{
    pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";
    DirectoryInfo directoryFolder = new DirectoryInfo(pathtomods);
    directoryFolder.Refresh();
}
*/

/*
if (dirs1last.Count > 0)
{
    for (int fo = 0; fo < dirs1last.Count; fo++)
    {
        string foldername1 = $"{dirs1last[fo].Substring(dirs1last[fo].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

        //pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

        pathtomods += @"\" + foldername1;

        List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));

        foreach (var dir1 in dirs1)
        {
            var arrayoffiles = Directory.GetFiles(dir1);

            //Console.WriteLine(arrayoffiles.Length);

            for (int f = 0; f < arrayoffiles.Length; f++)
            {
                File.Delete(arrayoffiles[f]);

            }


        }

        dirs2.Clear();

        for (int folderi = 0; folderi < dirs1.Count; folderi++)
        {
            dirs2.Add(dirs1[folderi]);
        }
    }







    /*
   */
/*
pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";
DirectoryInfo directoryFolder = new DirectoryInfo(pathtomods);
directoryFolder.Refresh();

}
else
{

}*/




/*if (mainninesmodsfoldercounter == 0)
{

}*/


/*
if (dirs1last.Count > 0)
{
    for (int fo = 0; fo < dirs1last.Count; fo++)
    {
        string foldername1 = $"{dirs1last[fo].Substring(dirs1last[fo].LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
        dirs2.Add(pathtomods + @"\" + foldername1);
    }
}
else
{
    pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";
    DirectoryInfo directoryFolder = new DirectoryInfo(pathtomods);
    directoryFolder.Refresh();

    List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));

    foreach (var dir1 in dirs1)
    {
        var arrayoffiles = Directory.GetFiles(dir1);

        //Console.WriteLine(arrayoffiles.Length);

        for (int f = 0; f < arrayoffiles.Length; f++)
        {
            File.Delete(arrayoffiles[f]);

        }
    }

    dirs1last.Clear();

    for (int folderi = 0; folderi < dirs1.Count; folderi++)
    {
        dirs1last.Add(dirs1[folderi]);
    }
}*/