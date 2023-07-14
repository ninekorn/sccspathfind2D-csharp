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


using SharpDX.Windows;
using System.Threading;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.Diagnostics;

using SharpDX.DirectInput;

using sccs;


using sccsmessageobject = sccsmessage.sc_message_object;
using sccsmessageobjectjitter = sccsmessage.sc_message_object_jitter;
using System.Reflection.Metadata;
using System.Net.Sockets;
using static sccsr16.Form1;
using sccsmessage;
using sccs.sccore;

namespace sccsr16
{
    internal static class Program
    {







        //https://stackoverflow.com/questions/5836176/docking-window-inside-another-window
        /*
        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        private static Process pDocked;
        private static IntPtr hWndOriginalParent;
        private static IntPtr hWndDocked;

        private static IntPtr hWndParent;

        private static void dockIt()
        {
            //hWndDocked = consoleHandle;

            /*if (hWndDocked != IntPtr.Zero) //don't do anything if there's already a window docked.
                return;
            hWndParent = IntPtr.Zero;

            //pDocked = sccsr16.Form1.currentform.theconsolehandle;// Process.Start(@"notepad");
            while (hWndDocked == IntPtr.Zero)
            {
                /*pDocked.WaitForInputIdle(1000); //wait for the window to be ready for input;
                pDocked.Refresh();              //update process info
                if (pDocked.HasExited)
                {
                    return; //abort if the process finished before we got a handle.
                }
                hWndDocked = sccsr16.Form1.currentform.theconsolehandle;// pDocked.MainWindowHandle;  //cache the window handle
            }
            //Windows API call to change the parent of the target window.
            //It returns the hWnd of the window's parent prior to this call.
            hWndOriginalParent = SetParent(sccsr16.Form1.currentform.theconsolehandle, sccsr16.Form1.currentform.Handle); //Panel1.Handle

            //Wire up the event to keep the window sized to match the control
            sccsr16.Form1.currentform.SizeChanged += new EventHandler(Panel1_Resize);
            //Perform an initial call to set the size.
            Panel1_Resize(new Object(), new EventArgs());
        }

        private static void undockIt()
        {
            //Restores the application to it's original parent.
            SetParent(hWndDocked, hWndOriginalParent);
        }
        
        private static void Panel1_Resize(object sender, EventArgs e)
        {
            //Change the docked windows size to match its parent's size. 
            MoveWindow(hWndDocked, 0, 0, sccsr16.Form1.currentform.Width, sccsr16.Form1.currentform.Height, true);
        }*/





        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hWnd);

        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/3295e38d-2267-425a-a7f8-9e6035331e53/how-to-capture-closing-of-c-console-apps?forum=csharpgeneral
       public static void OnProcessExit()
        {
            CloseWindow(sccsr16.Form1.currentform.theconsolehandle);

            //sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;

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
            //Environment.Exit(0);
            //Application.Exit();
            Console.WriteLine("OnProcessExit - console program:");
            //Console.WriteLine("OnProcessExitProgram.cs - console program:" + SCGLOBALSACCESSORS.SCCONSOLECORE.handle);
            //Program.MessageBox((IntPtr)0, "OnProcessExit - console program:" + SCGLOBALSACCESSORS.SCCONSOLECORE.handle, "sccsmsg", 0);


            //string path = @"D:\OnProcessExitRecording.txt";
            /*if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("This program has exited at " + DateTime.Now.ToString());
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine("This program has exited at " + DateTime.Now.ToString());
                tw.Close();
            }*/
        }
        static bool ConsoleEventCallback(int eventType)
        {
            if (eventType == 2)
            {
                Console.WriteLine("ConsoleEventCallback - console program:");
                //Console.WriteLine("OnProcessExitProgram.cs - console program:" + SCGLOBALSACCESSORS.SCCONSOLECORE.handle);

                System.Windows.Forms.Application.ExitThread();
                System.Windows.Forms.Application.Exit();
                var process = System.Diagnostics.Process.GetCurrentProcess();

                process.Kill();
                process.Dispose();

                CloseWindow(sccsr16.Form1.currentform.theconsolehandle);
                sccsr16.Form1.currentform.Close();
                sccsr16.Form1.currentform.Dispose();

                //InputSimulator inputsim = new InputSimulator();
                //InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                //inputsim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
                //inputsim = null;

                System.Environment.Exit(1);

                System.Environment.Exit(0);

                //Application.Exit();
                //CloseWindow(consoleHandle);

                //Environment.Exit(0);
                Application.Exit();
                //OnProcessExit();

                //Program.MessageBox((IntPtr)0, "OnProcessExit - console program:" + SCGLOBALSACCESSORS.SCCONSOLECORE.handle, "sccsmsg", 0);
            }

            return false;
        }
        static ConsoleEventDelegate handler;   // Keeps it from getting garbage collected
                                               // Pinvoke
        private delegate bool ConsoleEventDelegate(int eventType);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);

        static sccsmessageobjectjitter[][] sccsjittertasks = null;

        public static int worlditerations = 3; // as high as possible normally for higher precision
        public static int worldsmalliterations = 3; // as high as possible normally for higher precision
        public static float worldallowedpenetration = 0.00123f; //0.00123f  _world_gravity = new JVector(0, -9.81f, 0);
        public static bool allowdeactivation = true;

        public static int physicsengineinstancex = 0;
        public static int physicsengineinstancey = 0;
        public static int physicsengineinstancez = 0;

        public static int useOculusRift = 0;

        public static int createikrig = 1;

        public static int activatenotyetinfinitevoxelterrain = 0;

        public static int usethirdpersonview = 0;
        public static float offsetthirdpersonview = 0.5f;//at or over 1 to get a decent ootb working 3rdpersonview.

        public static int useArduinoOVRTouchKeymapper = 0;


        public static int worldwidth = 1;
        public static int worldheight = 1;
        public static int worlddepth = 1;

        //public static IntPtr consoleHandle;

        public static int usejitterphysics = 0;
        public static float paddingformaps = 0.0f;

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);

        public static bool runthreadedapp = false;

        public static bool somerunapptype = false;
        public static bool lastrunapptype = false;
        //runapptype == 0 => running in a system.thread
        //runapptype == 1 => running in sharpdx renderloop
        static int canworkuithread = 1;
        static int canworksysthread = 2;

        static Thread mainthreadloop;
        /*
        public static directx directx;
        public static updatePrim updateprim;*/
        //public static updateSec updatesec;

        static int startmainthread = 0;
        public static Stopwatch clock;
        public static Stopwatch fpsTimer;

        static int createtimers = 0;
        public static int fpsCounter = 0;
        static int hasfinishedwork = 0;
        static int hasfinishedworkuithread = 0;
        static int hasfinishedworksystemthread = 0;

        static int lasthasfinishedworkuithread = 0;
        static int lasthasfinishedworksystemthread = 0;

        public static keyboardinput keyboardinput;


        //public static updatePrim.threaddata[][] arrayofthreaddata = new updatePrim.threaddata[6][];

        public static sccsgraphicssec sccsgraphicssec;

        static sccsmessage.sc_message_object[] mainreceivedmessages;//

        public static sccs.sccore.scglobalsaccessor SCGLOBALSACCESSORS;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            //ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // sccsr14sc.Form1.someform = new Form1();
            sccsr16.Form1.currentform = new Form1();

            AppDomain.CurrentDomain.ProcessExit += ProcessExitHandler;

            if (!runthreadedapp)
            {
                canworkuithread = 1;
                canworksysthread = 2;
            }
            if (runthreadedapp)
            {
                canworkuithread = 2;
                canworksysthread = 1;
            }

            keyboardinput = new keyboardinput();


            //0 show
            //1 hide
            int createconsole = 0;

            if (sccsr16.Form1.currentform != null)
            {
                if (sccsr16.Form1.currentform.Handle != IntPtr.Zero)
                {

                    SCGLOBALSACCESSORS = new sccs.sccore.scglobalsaccessor(mainreceivedmessages, createconsole);
                    if (SCGLOBALSACCESSORS == null)
                    {
                        //System.Windows.MessageBox.Show("SCGLOBALSACCESSORS NULL", "Console");
                    }
                    else
                    {
                        //System.Windows.MessageBox.Show("SCGLOBALSACCESSORS !NULL", "Console");
                    }
                }
            }






            //Application.Run(sccsr16.Form1.currentform);
            RenderLoop.Run(sccsr16.Form1.currentform, () =>
            {
                keyboardinput.ReadKeyboard();

                /*
                if (updateprim!= null)
                {
                    if (useOculusRift == 0)
                    {
                        if (updateprim.camera != null)
                        {
                            updateprim.updatecamera();
                        }
                    }
                    //else if (useOculusRift == 1)
                    //{
                    //    updateprim.updatecontrolsovr();
                    //}

                }*/



                /*
                if (sccsr16.Form1.currentform.lastpicturebox1regiondirtypixelrgb != sccsr16.Form1.currentform.picturebox1regiondirtypixelrgb)
                {
                    //Console.WriteLine("frame arrives here0");                             
                    var refreshDXEngineAction = new Action(delegate
                    {
                        sccsr16.Form1.currentform.thepicturebox1.Invoke((MethodInvoker)delegate
                        {
                            //sccsr16.Form1.drawString = "test";

                            sccsr16.Form1.currentform.lastpicturebox1regiondirtypixelrgb = sccsr16.Form1.currentform.picturebox1regiondirtypixelrgb;
                            sccsr16.Form1.currentform.thepicturebox1.Refresh();
                        });
                    });
                    System.Windows.Threading.Dispatcher.CurrentDispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, refreshDXEngineAction);
                }*/



                if (sccsr16.Form1.currentform.startmultiplicationprocesslistenswtc == 1)
                {
                    if (sccsr16.Form1.thebutton2.Enabled)
                    {
                        sccsr16.Form1.thebutton2.Enabled = false;
                    }

                    if (sccsr16.Form1.thebutton1.Enabled)
                    {
                        
                        sccsr16.Form1.thebutton1.Enabled = false;
                    }
                    if (sccsr16.Form1.currentform.startmultiplicationprocessthreadswtc == 2)
                    {
                        if (!sccsr16.Form1.thebutton2.Enabled)
                        {
                            sccsr16.Form1.thebutton2.Enabled = true;
                        }

                        if (!sccsr16.Form1.thebutton1.Enabled)
                        {
                            sccsr16.Form1.thebutton1.Enabled = true;
                        }
                        sccsr16.Form1.currentform.startmultiplicationprocesslistenswtc = 0;
                    }
                }




                if (sccsr16.Form1.currentform.button18swtc == 1)
                {
                    if (sccsr16.Form1.currentform.copymethodstartedornot == 2)
                    {

                        if (!sccsr16.Form1.thebutton4.Enabled)
                        {
                            sccsr16.Form1.thebutton4.Enabled = true;
                        }
                        if (!sccsr16.Form1.thebutton18.Enabled)
                        {
                            sccsr16.Form1.thebutton18.Enabled = true;
                        }

                        if (!sccsr16.Form1.thebutton16.Enabled)
                        {
                            sccsr16.Form1.thebutton16.Enabled = true;
                        }



                        if (!sccsr16.Form1.thebutton22.Enabled)
                        {
                            sccsr16.Form1.thebutton18.Enabled = true;
                            sccsr16.Form1.thebutton16.Enabled = true;
                            sccsr16.Form1.thebutton4.Enabled = true;
                            sccsr16.Form1.thebutton22.Enabled = true;
                        }
                        sccsr16.Form1.currentform.button18swtc = 0;
                        sccsr16.Form1.currentform.copymethodstartedornot = 0;

                        sccsr16.Form1.thebutton18.Refresh();
                        sccsr16.Form1.thebutton16.Refresh();
                        sccsr16.Form1.thebutton4.Refresh();
                        sccsr16.Form1.thebutton22.Refresh();
                    }
                    else
                    {
                        if (sccsr16.Form1.thebutton18.Enabled)
                        {
                            sccsr16.Form1.thebutton18.Enabled = false;
                        }
                        if (sccsr16.Form1.thebutton16.Enabled)
                        {
                            sccsr16.Form1.thebutton16.Enabled = false;
                        }
                        if (sccsr16.Form1.thebutton4.Enabled)
                        {
                            sccsr16.Form1.thebutton4.Enabled = false;
                        }
                        if (sccsr16.Form1.thebutton22.Enabled)
                        {
                            sccsr16.Form1.thebutton18.Enabled = false;
                            sccsr16.Form1.thebutton16.Enabled = false;
                            sccsr16.Form1.thebutton4.Enabled = false;
                            sccsr16.Form1.thebutton22.Enabled = false;
                        }
                        sccsr16.Form1.thebutton18.Refresh();
                        sccsr16.Form1.thebutton16.Refresh();
                        sccsr16.Form1.thebutton4.Refresh();
                        sccsr16.Form1.thebutton22.Refresh();

                    }
                }







                if (sccsr16.Form1.currentform.button19swtc == 1)
                {
                    if (sccsr16.Form1.currentform.movemethodstartedornot == 2)
                    {
                        if (!sccsr16.Form1.thebutton21.Enabled)
                        {
                            sccsr16.Form1.thebutton3.Enabled = true;
                            sccsr16.Form1.thebutton17.Enabled = true;
                            sccsr16.Form1.thebutton19.Enabled = true;
                            sccsr16.Form1.thebutton21.Enabled = true;
                        }
                        sccsr16.Form1.currentform.button19swtc = 0;
                        sccsr16.Form1.currentform.movemethodstartedornot = 0;

                        sccsr16.Form1.thebutton21.Refresh();
                        sccsr16.Form1.thebutton3.Refresh();
                        sccsr16.Form1.thebutton17.Refresh();
                        sccsr16.Form1.thebutton19.Refresh();
                    }
                    else
                    {
                        if (sccsr16.Form1.thebutton21.Enabled)
                        {
                            sccsr16.Form1.thebutton3.Enabled = false;
                            sccsr16.Form1.thebutton17.Enabled = false;
                            sccsr16.Form1.thebutton19.Enabled = false;
                            sccsr16.Form1.thebutton21.Enabled = false;
                        }
                        sccsr16.Form1.thebutton21.Refresh();
                        sccsr16.Form1.thebutton3.Refresh();
                        sccsr16.Form1.thebutton17.Refresh();
                        sccsr16.Form1.thebutton19.Refresh();
                    }
                }






                if (sccsr16.Form1.currentform.button2swtc == 1)
                {
                    if (sccsr16.Form1.currentform.deletemethodstartedornotmuls == 2)
                    {
                        if (!sccsr16.Form1.thebutton20.Enabled)
                        {
                            sccsr16.Form1.thebutton20.Enabled = true;
                        }

                        if (sccsr16.Form1.currentform.button2swtc == 1)
                        {
                            sccsr16.Form1.currentform.button2swtc = 0;
                        }
                        if (!sccsr16.Form1.thebutton2.Enabled)
                        {
                            sccsr16.Form1.thebutton2.Enabled = true;
                        }


                        sccsr16.Form1.currentform.deletemethodstartedornotmuls = 0;

                        sccsr16.Form1.thebutton20.Refresh();
                        sccsr16.Form1.thebutton2.Refresh();
                    }
                    else
                    {

                        if (sccsr16.Form1.thebutton20.Enabled)
                        {
                            sccsr16.Form1.thebutton20.Enabled = false;
                        }

                        if (sccsr16.Form1.thebutton2.Enabled)
                        {
                            sccsr16.Form1.thebutton2.Enabled = false;
                        }

                        sccsr16.Form1.thebutton20.Refresh();
                        sccsr16.Form1.thebutton2.Refresh();
                    }

                }





                if (sccsr16.Form1.currentform.button6swtc == 1)
                {
                    if (sccsr16.Form1.currentform.deletemethodstartedornotmods == 2)
                    {
                        if (!sccsr16.Form1.thebutton6.Enabled) //delete mods button
                        {
                            sccsr16.Form1.thebutton6.Enabled = true;
                        }

                        if (!sccsr16.Form1.thebutton20.Enabled) //delete speed delete button
                        {
                            sccsr16.Form1.thebutton20.Enabled = true;
                        }

                        if (sccsr16.Form1.currentform.button6swtc == 1)
                        {
                            sccsr16.Form1.currentform.button6swtc = 0;
                        }

                        sccsr16.Form1.currentform.deletemethodstartedornotmods = 0;

                        sccsr16.Form1.thebutton20.Refresh();
                        sccsr16.Form1.thebutton6.Refresh();
                    }
                    else
                    {
                        if (sccsr16.Form1.thebutton6.Enabled)
                        {
                            sccsr16.Form1.thebutton6.Enabled = false;
                        }

                        if (sccsr16.Form1.thebutton20.Enabled)
                        {
                            sccsr16.Form1.thebutton20.Enabled = false;
                        }
                        sccsr16.Form1.thebutton20.Refresh();
                        sccsr16.Form1.thebutton6.Refresh();
                    }

                }


















                if (sccsr16.Form1.currentform.formwasloadedswtc == 1 && startmainthread == 0)
                {
                   sccsr16.Form1.currentform.theconsolehandle = sccsr16.Form1.theHandle;


                    Console.WriteLine("hwnd:" + sccsr16.Form1.currentform.theconsolehandle);

                    //https://social.msdn.microsoft.com/Forums/vstudio/en-US/3295e38d-2267-425a-a7f8-9e6035331e53/how-to-capture-closing-of-c-console-apps?forum=csharpgeneral
                    var handler = new ConsoleEventDelegate(ConsoleEventCallback);
                    SetConsoleCtrlHandler(handler, true);
                    //Console.ReadLine();



                    sccsgraphicssec = new sccsgraphicssec();



                    if (usejitterphysics == 1)
                    {
                        sccsjittertasks = new sccsmessageobjectjitter[physicsengineinstancex * physicsengineinstancey * physicsengineinstancez][];

                        for (int xx = 0; xx < physicsengineinstancex; xx++)
                        {
                            for (int yy = 0; yy < physicsengineinstancey; yy++)
                            {
                                for (int zz = 0; zz < physicsengineinstancez; zz++)
                                {
                                    var indexer00 = xx + physicsengineinstancex * (yy + physicsengineinstancey * zz);
                                    //_jitter_physics[indexer00] = DoSpecialThing();
                                    sccsjittertasks[indexer00] = new sccsmessageobjectjitter[worldwidth * worldheight * worlddepth];

                                    for (int x = 0; x < worldwidth; x++)
                                    {
                                        for (int y = 0; y < worldheight; y++)
                                        {
                                            for (int z = 0; z < worlddepth; z++)
                                            {
                                                var indexer01 = x + worldwidth * (y + worldheight * z);
                                                sccsjittertasks[indexer00][indexer01] = new sccsmessageobjectjitter();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Console.WriteLine("built0");
                        //jitter_sc = create_jitter_instances(jitter_sc, _sc_jitter_data);

                        for (int xx = 0; xx < physicsengineinstancex; xx++)
                        {
                            for (int yy = 0; yy < physicsengineinstancey; yy++)
                            {
                                for (int zz = 0; zz < physicsengineinstancez; zz++)
                                {
                                    var indexer00 = xx + physicsengineinstancex * (yy + physicsengineinstancey * zz);


                                    //if (jitter_sc.Length > 0)
                                    //{
                                    //    Console.WriteLine("built00");
                                    //}
                                    //
                                    //Console.WriteLine("index: " + indexer00);


                                    for (int x = 0; x < worldwidth; x++)
                                    {
                                        for (int y = 0; y < worldheight; y++)
                                        {
                                            for (int z = 0; z < worlddepth; z++)
                                            {
                                                var indexer1 = x + worldwidth * (y + worldheight * z);

                                                sccsjittertasks[indexer00][indexer1]._world_data = new object[2];
                                                sccsjittertasks[indexer00][indexer1]._work_index = -1;
                                                sccsjittertasks[indexer00][indexer1]._world_data[0] = null;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //, consoleHandle
                        sccsjittertasks = sccsdirectx.D3D.initscriptvariables(sccsjittertasks); //, SCGLOBALSACCESSORS.SCCONSOLEWRITER*/
                    }
                    else if (usejitterphysics == 0)
                    {
                        sccsjittertasks = new sccsmessageobjectjitter[1][];
                        sccsjittertasks[0] = new sccsmessageobjectjitter[1];
                        sccsjittertasks[0][0] = new sccsmessageobjectjitter();
                        for (int xx = 0; xx < physicsengineinstancex; xx++)
                        {
                            for (int yy = 0; yy < physicsengineinstancey; yy++)
                            {
                                for (int zz = 0; zz < physicsengineinstancez; zz++)
                                {
                                    var indexer00 = xx + physicsengineinstancex * (yy + physicsengineinstancey * zz);
                                    //_jitter_physics[indexer00] = DoSpecialThing();
                                    sccsjittertasks[indexer00] = new sccsmessageobjectjitter[worldwidth * worldheight * worlddepth];

                                    for (int x = 0; x < worldwidth; x++)
                                    {
                                        for (int y = 0; y < worldheight; y++)
                                        {
                                            for (int z = 0; z < worlddepth; z++)
                                            {
                                                var indexer01 = x + worldwidth * (y + worldheight * z);
                                                sccsjittertasks[indexer00][indexer01] = new sccsmessageobjectjitter();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //, consoleHandle
                        sccsjittertasks = sccs.sccsdirectx.D3D.initscriptvariables(sccsjittertasks); //, SCGLOBALSACCESSORS.SCCONSOLEWRITER
                    }


                    /*
                    directx = new directx();
                    updateprim = new updatePrim(directx);*/
                    //updatesec = new updateSec(updateprim, directx);

                    /*
                    arrayofthreaddata[0] = new updatePrim.threaddata[updateprim.thechunkbundlefractionx * updateprim.thechunkbundlefractiony * updateprim.thechunkbundlefractionz];
                    arrayofthreaddata[1] = new updatePrim.threaddata[updateprim.thechunkbundlefractionx * updateprim.thechunkbundlefractiony * updateprim.thechunkbundlefractionz];
                    arrayofthreaddata[2] = new updatePrim.threaddata[updateprim.thechunkbundlefractionx * updateprim.thechunkbundlefractiony * updateprim.thechunkbundlefractionz];
                    arrayofthreaddata[3] = new updatePrim.threaddata[updateprim.thechunkbundlefractionx * updateprim.thechunkbundlefractiony * updateprim.thechunkbundlefractionz];
                    arrayofthreaddata[4] = new updatePrim.threaddata[updateprim.thechunkbundlefractionx * updateprim.thechunkbundlefractiony * updateprim.thechunkbundlefractionz];
                    arrayofthreaddata[5] = new updatePrim.threaddata[updateprim.thechunkbundlefractionx * updateprim.thechunkbundlefractiony * updateprim.thechunkbundlefractionz];

                    for (int f = 0; f < arrayofthreaddata.Length; f++)
                    {
                        //thevaluereturn[f] = new threaddata[thechunkbundlefractionx * thechunkbundlefractiony * thechunkbundlefractionz];


                        for (int i = 0; i < arrayofthreaddata[f].Length; i++)
                        {
                            //thevaluereturn[f][i] = new threaddata();
                            arrayofthreaddata[f][i] = new updatePrim.threaddata();
                            //arrayofthreaddata[f][i].indexofswtcdirtyarea = i;
                        }
                    }*/

                    /*if (updateprim != null)
                    {
                        if (updateprim.camera != null)
                        {
                            updateprim.updatecamera();
                        }
                    }
                    */
                    if (createtimers == 0)
                    {
                        // Use clock 
                        clock = new Stopwatch();
                        clock.Start();
                        fpsTimer = new Stopwatch();
                        fpsTimer.Start();
                        createtimers = 1;
                    }



                    //Console.WriteLine(directx.MaxNumberOfCubes);
                    // Install keys handlers 
                    /*sccsr16.Form1.currentform.KeyDown += (target, arg) =>
                    {
                        if (arg.KeyCode == Keys.PageUp && updatesec.nextState.CountCubes > 1)
                            updatesec.nextState.CountCubes--;
                        if (arg.KeyCode == Keys.PageDown && updatesec.nextState.CountCubes < updatesec.MaxNumberOfCubes)
                            updatesec.nextState.CountCubes++;

                        if (arg.KeyCode == Keys.F1)
                            updatesec.nextState.Type = (updateSec.TestType)((((int)updatesec.nextState.Type) + 1) % 3);
                        if (arg.KeyCode == Keys.F2)
                            updatesec.nextState.UseMap = !updatesec.nextState.UseMap;
                        if (arg.KeyCode == Keys.F3)
                        {
                            //Console.WriteLine("pressed F3");
                            updatesec.nextState.SimulateCpuUsage = !updatesec.nextState.SimulateCpuUsage;
                        }
                        if (arg.KeyCode == Keys.F4)
                        {
                            runthreadedapp = runthreadedapp == false ? true : false;
                        }

                        if (updatesec.nextState.Type == updateSec.TestType.Deferred)
                        {
                            if (arg.KeyCode == Keys.Home && updatesec.nextState.ThreadCount > 1)
                                updatesec.nextState.ThreadCount--;
                            if (arg.KeyCode == Keys.End && updatesec.nextState.ThreadCount < updateSec.MaxNumberOfThreads)
                                updatesec.nextState.ThreadCount++;
                        }
                        if (arg.KeyCode == Keys.Escape)
                            updatesec.nextState.Exit = true;
                        updatesec.switchToNextState = true;
                    };*/

                    sccsr16.Form1.currentform.formwasloadedswtc = 2;
                }

                hasfinishedwork = 0;

                

                if (lastrunapptype != runthreadedapp)
                {
                    if (!runthreadedapp)
                    {
                        canworkuithread = 1;
                        canworksysthread = 0;
                    }
                    else if (runthreadedapp)
                    {
                        canworkuithread = 0;
                        canworksysthread = 1;

                    }
                }

                if (runthreadedapp)
                {
                    //STARTS ONLY ONCE AND STARTS A THREAD THAT SLEEPS WHEN THERE ISN'T WORK AND THAT RUNS WHEN THE SWITCH TO THREADED IS ENABLED
                    //STARTS ONLY ONCE AND STARTS A THREAD THAT SLEEPS WHEN THERE ISN'T WORK AND THAT RUNS WHEN THE SWITCH TO THREADED IS ENABLED
                    if (startmainthread == 0)
                    {
                        somethreadwork();
                        startmainthread = 1;
                    }
                    //STARTS ONLY ONCE AND STARTS A THREAD THAT SLEEPS WHEN THERE ISN'T WORK AND THAT RUNS WHEN THE SWITCH TO THREADED IS ENABLED
                    //STARTS ONLY ONCE AND STARTS A THREAD THAT SLEEPS WHEN THERE ISN'T WORK AND THAT RUNS WHEN THE SWITCH TO THREADED IS ENABLED
                }
                else //if (!runapptype)
                {

                    if (canworkuithread == 1 && canworksysthread == 2)
                    {
                        //if (updatesec.hasfinishedSetupPipeline == 1 && updatesec.hasfinishedRenderRow == 1 && updatesec.hasfinishedRenderDeferred == 1)
                        {
                            if (useOculusRift == 0)
                            {
                                sccsgraphicssec.startrenderdirectx();
                                sccsjittertasks = sccsdirectx.D3D.Update( sccsjittertasks);
                                sccsgraphicssec.stoprenderdirectx();
                            }
                            else if (useOculusRift == 1)
                            {
                                if (sccsgraphicssec != null)
                                {
                                    sccsgraphicssec.startrenderdirectxovr();
                                    sccsjittertasks = sccsdirectx.D3D.Update(sccsjittertasks);
                                    //sccsjittertasks = updatescript.Update(jitter_sc, sccsjittertasks);
                                    sccsgraphicssec.stoprenderdirectxovr();
                                }
                            }
                        }
                    }
                }

                if (canworkuithread == 0)
                {
                    /*for (int i = 0; i < updatesec.currentState.ThreadCount; i++)
                    {
                        var commandList = updatesec.commandsList[i];
                        // Execute the deferred command list on the immediate context
                        directx.DeviceContext.ExecuteCommandList(commandList, false);

                        // For classic deferred we release the command list. Not for frozen
                        if (updatesec.currentState.Type == updateSec.TestType.Deferred)
                        {
                            if (commandList != null)
                            {
                                // Release the command list
                                commandList.Dispose();
                            }

                            updatesec.commandsList[i] = null;
                        }
                    }

                    if (updatesec != null)
                    {
                        if (updatesec.tasks != null)
                        {
                            for (int t = 0; t < updatesec.tasks.Length; t++)
                            {
                                if (updatesec.tasks[t] != null)
                                {
                                    updatesec.tasks[t].Wait();
                                    updatesec.tasks[t].Dispose();
                                }

                            }
                        }
                    */

                    canworkuithread = 2;

                    Console.WriteLine("starting UI thread. disposing systhread stuff");
                }

                fpsCounter++;
                if (fpsTimer.ElapsedMilliseconds > 1000)
                {
                    //var typeStr = updatesec.currentState.Type.ToString();
                    //if (updatesec.currentState.Type != updateSec.TestType.Immediate && !updatesec.supportCommandList) typeStr += "*";

                    //sccsr16.Form1.currentform.Text = string.Format("SharpDX - Threaded MultiCube D3D11  - (F1) {0} - (F2) {1} - (F3) {2} - Threads ↑↓{3} - Count ←{4}→ - FPS: {5:F2} ({6:F2}ms)  - Threaded: (F4) {7}", typeStr, updatesec.currentState.UseMap ? "Map/UnMap" : "UpdateSubresource", updatesec.currentState.SimulateCpuUsage ? "BurnCPU On" : "BurnCpu Off", updatesec.currentState.Type == updateSec.TestType.Deferred ? updatesec.currentState.ThreadCount : 1, updatesec.currentState.CountCubes * updatesec.currentState.CountCubes, 1000.0 * fpsCounter / fpsTimer.ElapsedMilliseconds, (float)fpsTimer.ElapsedMilliseconds / fpsCounter, runthreadedapp);
                    fpsTimer.Reset();
                    fpsTimer.Stop();
                    fpsTimer.Start();
                    fpsCounter = 0;
                }


                /*
                if (updatesec != null)
                {
                    fpsCounter++;
                    if (fpsTimer.ElapsedMilliseconds > 1000)
                    {
                        var typeStr = updatesec.currentState.Type.ToString();
                        if (updatesec.currentState.Type != updateSec.TestType.Immediate && !updatesec.supportCommandList) typeStr += "*";

                        sccsr16.Form1.currentform.Text = string.Format("SharpDX - Threaded MultiCube D3D11  - (F1) {0} - (F2) {1} - (F3) {2} - Threads ↑↓{3} - Count ←{4}→ - FPS: {5:F2} ({6:F2}ms)  - Threaded: (F4) {7}", typeStr, updatesec.currentState.UseMap ? "Map/UnMap" : "UpdateSubresource", updatesec.currentState.SimulateCpuUsage ? "BurnCPU On" : "BurnCpu Off", updatesec.currentState.Type == updateSec.TestType.Deferred ? updatesec.currentState.ThreadCount : 1, updatesec.currentState.CountCubes * updatesec.currentState.CountCubes, 1000.0 * fpsCounter / fpsTimer.ElapsedMilliseconds, (float)fpsTimer.ElapsedMilliseconds / fpsCounter, runthreadedapp);
                        fpsTimer.Reset();
                        fpsTimer.Stop();
                        fpsTimer.Start();
                        fpsCounter = 0;
                    }

                }*/

                //Console.WriteLine("UIThread:" + updateprim.counteruithread + "/SystemThread:" + updateprim.countersystemthread);

                lastrunapptype = runthreadedapp;

                lasthasfinishedworkuithread = hasfinishedworkuithread;
                lasthasfinishedworksystemthread = hasfinishedworksystemthread;

              

                Thread.Sleep(1);
            });


            Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);

        }


        static int threadfpsCounter = 0;

        public static void somethreadwork()
        {
            mainthreadloop = new Thread(() =>
            {

            loopgoto:

                if (lastrunapptype != runthreadedapp && runthreadedapp == false)
                {
                    Thread.Sleep(1);
                }
                else
                {
                    if (canworksysthread == 1 && canworkuithread == 2) // && updateprim.hasfinishedcreatingchunks == 1
                    {
                        //if (updatesec.hasfinishedSetupPipeline == 1 && updatesec.hasfinishedRenderRow == 1 && updatesec.hasfinishedRenderDeferred == 1)
                        {
                            if (useOculusRift == 0)
                            {
                                sccsgraphicssec.startrenderdirectx();
                                sccsjittertasks = sccsdirectx.D3D.Update(sccsjittertasks);
                                sccsgraphicssec.stoprenderdirectx();
                            }
                            else if (useOculusRift == 1)
                            {
                                if (sccsgraphicssec != null)
                                {
                                    sccsgraphicssec.startrenderdirectxovr();
                                    sccsjittertasks = sccsdirectx.D3D.Update(sccsjittertasks);
                                    //sccsjittertasks = updatescript.Update(jitter_sc, sccsjittertasks);
                                    sccsgraphicssec.stoprenderdirectxovr();
                                }
                            }
                            /*
                            if (useOculusRift == 0)
                            {
                                updateprim.startrenderdirectx();
                                //updateprim.renderthemeshes();
                                //updateprim.updatescriptsupdatetext(directx.DeviceContext);
                                //hasfinishedworksystemthread = updateprim.updatescriptssec(somerunapptype, SharpDX.Matrix.Identity, null) ;
                                updateprim.stoprenderdirectx();
                            }
                            else if (useOculusRift == 1)
                            {
                                updateprim.startrenderdirectxovr();
                                //updateprim.updatescriptsupdatetext(directx.DeviceContext);
                                //hasfinishedworksystemthread = updatesec.updatescriptssec(somerunapptype);
                                updateprim.stoprenderdirectxovr();
                            }*/
                        }

                    }

                    if (canworksysthread == 0)
                    {
                        /*for (int i = 0; i < updatesec.currentState.ThreadCount; i++)
                        {
                            var commandList = updatesec.commandsList[i];
                            // Execute the deferred command list on the immediate context
                            directx.DeviceContext.ExecuteCommandList(commandList, false);

                            // For classic deferred we release the command list. Not for frozen
                            if (updatesec.currentState.Type == updateSec.TestType.Deferred)
                            {
                                if (commandList != null)
                                {
                                    // Release the command list
                                    commandList.Dispose();
                                }

                                updatesec.commandsList[i] = null;
                            }
                        }


                        if (updatesec != null)
                        {
                            if (updatesec.tasks != null)
                            {
                                for (int t = 0; t < updatesec.tasks.Length; t++)
                                {
                                    if (updatesec.tasks[t] != null)
                                    {
                                        updatesec.tasks[t].Wait();
                                        updatesec.tasks[t].Dispose();
                                    }

                                }
                            }
                        }*/
                        canworksysthread = 2;
                        Console.WriteLine("starting sys thread. disposing UI stuff");
                    }
                }

                /*if (updatesec != null)
                {
                    threadfpsCounter++;
                    if (clock.ElapsedMilliseconds > 1000)
                    {
                        var typeStr = updatesec.currentState.Type.ToString();
                        if (updatesec.currentState.Type != updateSec.TestType.Immediate && !updatesec.supportCommandList) typeStr += "*";

                        //sccsr16.Form1.currentform.Text = string.Format("SharpDX - Threaded MultiCube D3D11  - (F1) {0} - (F2) {1} - (F3) {2} - Threads ↑↓{3} - Count ←{4}→ - FPS: {5:F2} ({6:F2}ms)  - Threaded: (F4) {7}", typeStr, updatesec.currentState.UseMap ? "Map/UnMap" : "UpdateSubresource", updatesec.currentState.SimulateCpuUsage ? "BurnCPU On" : "BurnCpu Off", updatesec.currentState.Type == directx.TestType.Deferred ? updatesec.currentState.ThreadCount : 1, updatesec.currentState.CountCubes * updatesec.currentState.CountCubes, 1000.0 * fpsCounter / fpsTimer.ElapsedMilliseconds, (float)fpsTimer.ElapsedMilliseconds / fpsCounter, runthreadedapp);
                        Console.WriteLine(1000.0 * threadfpsCounter / clock.ElapsedMilliseconds);
                        clock.Reset();
                        clock.Stop();
                        clock.Start();
                        threadfpsCounter = 0;
                    }

                }*/
                threadfpsCounter++;
                if (fpsTimer.ElapsedMilliseconds > 1000)
                {
                    //var typeStr = updatesec.currentState.Type.ToString();
                    //if (updatesec.currentState.Type != updateSec.TestType.Immediate && !updatesec.supportCommandList) typeStr += "*";

                    //sccsr16.Form1.currentform.Text = string.Format("SharpDX - Threaded MultiCube D3D11  - (F1) {0} - (F2) {1} - (F3) {2} - Threads ↑↓{3} - Count ←{4}→ - FPS: {5:F2} ({6:F2}ms)  - Threaded: (F4) {7}", typeStr, updatesec.currentState.UseMap ? "Map/UnMap" : "UpdateSubresource", updatesec.currentState.SimulateCpuUsage ? "BurnCPU On" : "BurnCpu Off", updatesec.currentState.Type == updateSec.TestType.Deferred ? updatesec.currentState.ThreadCount : 1, updatesec.currentState.CountCubes * updatesec.currentState.CountCubes, 1000.0 * fpsCounter / fpsTimer.ElapsedMilliseconds, (float)fpsTimer.ElapsedMilliseconds / fpsCounter, runthreadedapp);
                    fpsTimer.Reset();
                    fpsTimer.Stop();
                    fpsTimer.Start();
                    fpsCounter = 0;
                }


                //Console.WriteLine("UIThread:" + updateprim.counteruithread + "/SystemThread:" + updateprim.countersystemthread);
                Thread.Sleep(1);
                goto loopgoto;

            }, 0); //100000

            mainthreadloop.IsBackground = true;
            mainthreadloop.Priority = ThreadPriority.Lowest;
            mainthreadloop.SetApartmentState(ApartmentState.STA);
            mainthreadloop.Start();
        }













        static void ProcessExitHandler(object sender, EventArgs e)
        {

            sccs.sccsgraphicssec.currentsccsgraphicssec.endthread0 = 1;




            /*
            updateprim.swtcturnoffthread = 1;

            
            if (updatePrim.currentupdatePrim != null)
            {
                updatePrim.currentupdatePrim.Dispose();
            }
          
            if (directx.D3D != null)
            {
                directx.D3D.Dispose();
            }

         

            GC.SuppressFinalize(updatePrim.currentupdatePrim);
            GC.SuppressFinalize(directx.D3D);

            updatePrim.currentupdatePrim = null;
            directx.D3D = null;*/



            Environment.Exit(0);
            Application.Exit();

            //Console.WriteLine("closing app");
            //MessageBox((IntPtr)0, "closing app", "window name", 0);
        }


    }
}










/*
if (sccsr16.Form1.currentform.button2swtc == 1)
{
    if (sccsr16.Form1.currentform.deletemethodstartedornotmuls == 2)
    {
        if (!sccsr16.Form1.thebutton2.Enabled)
        {
            sccsr16.Form1.thebutton2.Enabled = true;
        }
        sccsr16.Form1.currentform.button2swtc = 0;
        sccsr16.Form1.currentform.deletemethodstartedornotmuls = 0;

        sccsr16.Form1.thebutton2.Refresh();
    }
    else
    {                  
        if (sccsr16.Form1.thebutton2.Enabled)
        {
            sccsr16.Form1.thebutton2.Enabled = false;
        }
        sccsr16.Form1.thebutton2.Refresh();
    }
}*/


/*
if (sccsr16.Form1.currentform.button4swtc == 1)
{
    if (sccsr16.Form1.currentform.deletemethodstartedornotmods == 2)
    {
        if (!sccsr16.Form1.thebutton4.Enabled)
        {
            sccsr16.Form1.thebutton4.Enabled = true;
        }
        sccsr16.Form1.currentform.button4swtc = 0;
        sccsr16.Form1.currentform.deletemethodstartedornotmods = 0;

        sccsr16.Form1.thebutton4.Refresh();
    }
    else
    {
        if (sccsr16.Form1.thebutton4.Enabled)
        {
            sccsr16.Form1.thebutton4.Enabled = false;
        }
        sccsr16.Form1.thebutton4.Refresh();
    }
}*/


