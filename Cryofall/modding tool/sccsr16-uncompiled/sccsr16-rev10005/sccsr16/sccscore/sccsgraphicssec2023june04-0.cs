﻿using System;
using System.Collections.Generic;
using System.Text;

using SharpDX;
using Jitter;
using Jitter.Dynamics;
using Jitter.Collision;
using Jitter.LinearMath;
using Jitter.Collision.Shapes;
using Jitter.Forces;

using sccsmessageobject = sccsmessage.sc_message_object;
using sccsmessageobjectjitter = sccsmessage.sc_message_object_jitter;

using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

using System.IO;


using Jitter.DataStructures;
using SingleBodyConstraints = Jitter.Dynamics.Constraints.SingleBody;
//using Jitter.Dynamics.Constraints.SingleBody;
//using Jitter.LinearMath;
using Jitter.Dynamics.Constraints;
//using Jitter.Dynamics.Joints;
//using Jitter.Forces;

//using DeltaEngine.Datatypes;
//using DeltaEngine.Core;
//using DeltaEngine.Extensions;

using Vector2 = SharpDX.Vector2;
using Vector3 = SharpDX.Vector3;
using Vector4 = SharpDX.Vector4;
using Quaternion = SharpDX.Quaternion;
using Matrix = SharpDX.Matrix;
using Plane = SharpDX.Plane;
using Ray = SharpDX.Ray;

using System.Text;
using System.IO;
using SharpDX.Multimedia;
using SharpDX.IO;
using System.Xml;
using SharpDX.XAudio2;
using System.Linq;

//using System.Windows.Forms;
using System.IO.Ports;

using sccsmessage = sccsmessage.sc_message_object;
using sccsmessageobjectjiter = sccsmessage.sc_message_object_jitter;
using System.Text.RegularExpressions;


using SharpDX;
using SharpDX.DXGI;
using SharpDX.Direct3D11;
using SharpDX.DirectInput;
using SharpDX.Multimedia;
using SharpDX.IO;
using SharpDX.XAudio2;

using System.Windows.Forms;
using System.Drawing.Imaging;

using WindowsInput;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using SCCoreSystems;
using System.Security.AccessControl;
using SharpDX.Direct2D1;
using SharpDX.WIC;
using SharpDX.RawInput;

namespace sccs
{
    public class sccsgraphicssec: sccsdirectx, IDisposable
    {
        //public abstract class Direct2DComponent : DirectXComponent

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        public override void startrenderdirectx()
        {
            base.startrenderdirectx();
        }
        public override void stoprenderdirectx()
        {
            base.stoprenderdirectx();
        }




        public override void startrenderdirectxovr()
        {
            base.startrenderdirectxovr();
        }
        public override void stoprenderdirectxovr()
        {
            base.stoprenderdirectxovr();
        }




        Output1 _output1;
        Adapter1 _adapter;
        SharpDX.Direct3D11.Device device;
        static Texture2D _texture2D;
        static Texture2D _texture2DFinal;
        public byte[] _textureByteArray;
        Texture2DDescription _textureDescription;
        Texture2DDescription _textureDescriptionFinal;

        
        int _bytesTotal;
        //static int _width = 0;
        //static int _height = 0;
        int bitmapcounter = 0;

        public sccsgraphicssec()
        {
            Console.WriteLine("sccsgraphicssec started");




            //CREATING A SHARPDX DIRECT3D11 device.
            int _numAdapter = 0;
            int _numOutput = 0;

            _numAdapter = 0;//  adapter;
            _numOutput = 0;// numOutput;

            try
            {
                using (var _factory = new SharpDX.DXGI.Factory1())
                {
                    //_factory.MakeWindowAssociation(Program.vewindowsfoundedz, WindowAssociationFlags.Valid);
                    this._adapter = _factory.GetAdapter1(_numAdapter);
                }
            }
            catch (SharpDXException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            try
            {
                this.device = new SharpDX.Direct3D11.Device(_adapter);
                //this._device = sccs.SC_Console_DIRECTX._dxdevice.device;
            }
            catch (SharpDXException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
            //CREATING A SHARPDX DIRECT3D11 device.




            if (this.device == null)
            {
                Console.WriteLine("null device");
            }
            else
            {
                Console.WriteLine("!null device");
            }



            createvariantpngs();




            //SCCoreSystems.sccstextureloader loadbitmap = new SCCoreSystems.sccstextureloader();

            //loadbitmap.LoadFromFile();

            /*
            var currentdir =  System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine("dir:" + currentdir);*/


            /* sctextureloader texturetoload = new sctextureloader();
             var textureinit = texturetoload.Initialize(D3D.device, "../../../1x1_pink_color.png");
            */


        }




        public unsafe void createvariantpngs()
        {
            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Console.WriteLine("2_mainThreadStarter");
            string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
            DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
            directoryFolder.Refresh();
            //string pathToDesktopFolder = pathToDesktop + @"\" + folderName;


            string folderNameOriginalPNGS = "original";
            DirectoryInfo dirnameOriginal = new DirectoryInfo(folderNameOriginalPNGS);
            dirnameOriginal.Refresh();
            //Console.WriteLine("2_mainThreadStarter");
            if (!Directory.Exists(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder))
            {
                Console.WriteLine("1the directory !exists");
                Directory.CreateDirectory(folderNameOriginalPNGS);
            }
            else
            {
                Console.WriteLine("1the directory exists");
            }

            //string finalpathoriginalPNGSback = "Back";
            //string finalpathoriginalPNGSfront = "Front";

            string finalPathOriginalBack = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNameOriginalPNGS + @"\" + "Back" + @"\" + "Male" + @"\";
            string finalPathOriginalFront = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNameOriginalPNGS + @"\" + "Front" + @"\" + "Male" + @"\";


            if (!Directory.Exists(finalPathOriginalFront))
            {
                Console.WriteLine("00the directory !exists");
                //Directory.CreateDirectory(folderNameOriginalPNGS);
            }
            else
            {
                Console.WriteLine("11the directory exists");
            }

            string folderNamemulPNGS = "multiplied";
            DirectoryInfo dirnamemul = new DirectoryInfo(folderNamemulPNGS);
            dirnamemul.Refresh();
            //Console.WriteLine("2_mainThreadStarter");
            if (!Directory.Exists(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS))
            {
                Console.WriteLine("1the directory !exists");
                Directory.CreateDirectory(folderNamemulPNGS);
            }
            else
            {
                //Console.WriteLine("1the directory exists");

                if (!Directory.Exists(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Back"))
                {
                    Console.WriteLine("1the directory !exists");
                    Directory.CreateDirectory(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Back");
                }
                else
                {
                    //Console.WriteLine("1the directory exists");
                }

                if (!Directory.Exists(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Back" + @"\" + "Male" + @"\"))
                {
                    Console.WriteLine("1the directory !exists");
                    Directory.CreateDirectory(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Back" + @"\" + "Male" + @"\");
                }
                else
                {
                    //Console.WriteLine("1the directory exists");
                }

                if (!Directory.Exists(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Front"))
                {
                    Console.WriteLine("1the directory !exists");
                    Directory.CreateDirectory(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Front");
                }
                else
                {
                    //Console.WriteLine("1the directory exists");
                }

                if (!Directory.Exists(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Front" + @"\" + "Male" + @"\"))
                {
                    Console.WriteLine("1the directory !exists");
                    Directory.CreateDirectory(pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Front" + @"\" + "Male" + @"\");
                }
                else
                {
                    //Console.WriteLine("1the directory exists");
                }
            }

            string finalPathmulBack = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Back" + @"\" + "Male" + @"\";
            string finalPathmulFront = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Front" + @"\" + "Male" + @"\";

            //Console.WriteLine(finalPathOriginal);
            sccstextureloader texturetoload;

            var arrayoforiginalpngfiles = Directory.GetFiles(finalPathOriginalFront);

            for (int i = 0; i < arrayoforiginalpngfiles.Length; i++)
            {
                texturetoload = new sccstextureloader();
                var textureinit = texturetoload.Initialize(device, arrayoforiginalpngfiles[i]);

                if (textureinit)
                {
                    Console.WriteLine("texture initialiased");

                    var factory = new SharpDX.WIC.ImagingFactory();
                    var filename = arrayoforiginalpngfiles[i];// "OnBoardComputer.png";


                    string finalfilename = arrayoforiginalpngfiles[i].Substring(finalPathmulFront.Length-2, (arrayoforiginalpngfiles[i].Length-1 - finalPathmulFront.Length - 1));

                    var bitmapDecoder = new SharpDX.WIC.BitmapDecoder(
                        factory,
                        filename,
                        SharpDX.WIC.DecodeOptions.CacheOnDemand
                    );

                    var bitmapsourceresult = new SharpDX.WIC.FormatConverter(factory);

                    bitmapsourceresult.Initialize(
                        bitmapDecoder.GetFrame(0),
                        SharpDX.WIC.PixelFormat.Format32bppPRGBA,
                        SharpDX.WIC.BitmapDitherType.None,
                        null,
                        0.0,
                        SharpDX.WIC.BitmapPaletteType.Custom);


                    SharpDX.Direct3D11.Texture2D thetexture2d;


                    int stride = bitmapsourceresult.Size.Width * 4;
                    texturetoload.bufferfortests = new SharpDX.DataStream(bitmapsourceresult.Size.Height * stride, true, true);
                    //using (SharpDX.DataStream buffer = new SharpDX.DataStream(bitmapSource.Size.Height * stride, true, true))
                    {

                        bitmapsourceresult.CopyPixels(stride, texturetoload.bufferfortests);
                        thetexture2d = new SharpDX.Direct3D11.Texture2D(device, new SharpDX.Direct3D11.Texture2DDescription()
                        {
                            CpuAccessFlags = CpuAccessFlags.Read,
                            BindFlags = BindFlags.None,//BindFlags.None, //| BindFlags.RenderTarget
                            Format = SharpDX.DXGI.Format.B8G8R8A8_UNorm,
                            Width = bitmapsourceresult.Size.Width,
                            Height = bitmapsourceresult.Size.Height,
                            OptionFlags = ResourceOptionFlags.None,
                            MipLevels = 1,
                            ArraySize = 1,
                            SampleDescription = { Count = 1, Quality = 0 },
                            Usage = ResourceUsage.Staging
                        }, new SharpDX.DataRectangle(texturetoload.bufferfortests.DataPointer, stride));
                    }

                    var _textureDescriptionFINAL = new Texture2DDescription
                    {
                        CpuAccessFlags = CpuAccessFlags.Read,
                        BindFlags = BindFlags.None,//BindFlags.None, //| BindFlags.RenderTarget //BindFlags.ShaderResource | BindFlags.RenderTarget, //
                        Format = SharpDX.DXGI.Format.B8G8R8A8_UNorm,
                        Width = texturetoload.texture.Description.Width,
                        Height = texturetoload.texture.Description.Height,
                        OptionFlags = ResourceOptionFlags.None,
                        MipLevels = 1,
                        ArraySize = 1,
                        SampleDescription = { Count = 1, Quality = 0 },
                        Usage = ResourceUsage.Staging // ResourceUsage.Default//
                    };

                    //sccs.Program.MessageBox((IntPtr)0, "width:" + texturetoload.texture.Description.Width, "sccsmsg", 0);

                    var theonboardcomputertextureFINAL = new Texture2D(device, _textureDescriptionFINAL);

                    device.ImmediateContext.CopyResource(thetexture2d, theonboardcomputertextureFINAL);

                    //DISCARDED
                    //DISCARDED
                    //DISCARDED
                    var dataBox1 = device.ImmediateContext.MapSubresource(theonboardcomputertextureFINAL, 0, SharpDX.Direct3D11.MapMode.Read, SharpDX.Direct3D11.MapFlags.None);

                    //device.ImmediateContext.UnmapSubresource(theonboardcomputertextureFINAL, 0);

                    var memoryBitmapStrideonboardcomputer = theonboardcomputertextureFINAL.Description.Width * 4;

                    var columnsonboardcomputer = theonboardcomputertextureFINAL.Description.Width;
                    var rowsonboardcomputer = theonboardcomputertextureFINAL.Description.Height;
                    IntPtr interptr1 = dataBox1.DataPointer;

                    var onboardcomputeiconpixeldata = new byte[memoryBitmapStrideonboardcomputer * theonboardcomputertextureFINAL.Description.Height];

                    // It can happen that the stride on the GPU is bigger then the stride on the bitmap in main memory (_width * 4)
                    if (dataBox1.RowPitch == memoryBitmapStrideonboardcomputer)
                    {
                        //sccs.Program.MessageBox((IntPtr)0, "Stride is the same", "sccsmsg", 0);
                        // Stride is the same
                        Marshal.Copy(interptr1, onboardcomputeiconpixeldata, 0, memoryBitmapStrideonboardcomputer * theonboardcomputertextureFINAL.Description.Height);
                    }
                    else
                    {
                        // Stride not the same - copy line by line
                        for (int y = 0; y < theonboardcomputertextureFINAL.Description.Height; y++)
                        {
                            Marshal.Copy(interptr1 + y * dataBox1.RowPitch, onboardcomputeiconpixeldata, y * memoryBitmapStrideonboardcomputer, memoryBitmapStrideonboardcomputer);
                        }
                    }

                    /*
                    float brightnessmultiplierb = 0.95f; //green
                    float brightnessmultiplierg = 0.95f; //blue
                    float brightnessmultiplierr = 1.15f; //red

                    float lastbrightnessmul = 1.25f;*/

                    float brightnessmultiplierb = 0.95f; //green
                    float brightnessmultiplierg = 0.95f; //blue
                    float brightnessmultiplierr = 1.15f; //red

                    float lastbrightnessmul = 1.30f;

                    int countgreenscreenpixelsareweinanoptiontransition = 0;

                    fixed (byte* textureByteArray = onboardcomputeiconpixeldata) //, totalArray = _totalArray
                    {
                        int posY = 0;
                        for (int yyyy = 0; yyyy < theonboardcomputertextureFINAL.Description.Height; yyyy++)
                        {
                            for (int xxxx = 0; xxxx < theonboardcomputertextureFINAL.Description.Width; xxxx++)
                            {
                                var bytePoser = ((yyyy * theonboardcomputertextureFINAL.Description.Width) + xxxx) * 4;

                                byte originalg = textureByteArray[bytePoser + 0];
                                byte originalb = textureByteArray[bytePoser + 1];
                                byte originalr = textureByteArray[bytePoser + 2];

                                float percentg = (textureByteArray[bytePoser + 0] / 255);
                                float percentb = (textureByteArray[bytePoser + 1] / 255);
                                float percentr = (textureByteArray[bytePoser + 2] / 255);

                                int valuereducedtoahundredg = (byte)(255 * percentg);
                                int valuereducedtoahundredb = (byte)(255 * percentg);
                                int valuereducedtoahundredr = (byte)(255 * percentg);


                                textureByteArray[bytePoser + 0] = (byte)(textureByteArray[bytePoser + 0] * brightnessmultiplierg * lastbrightnessmul);
                                textureByteArray[bytePoser + 1] = (byte)(textureByteArray[bytePoser + 1] * brightnessmultiplierb * lastbrightnessmul);
                                textureByteArray[bytePoser + 2] = (byte)(textureByteArray[bytePoser + 2] * brightnessmultiplierr * lastbrightnessmul);

                                posY++;
                            }
                        }
                    }

                    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
                    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
                    somebitmap.Save(finalPathmulFront + finalfilename + ".png");                  

                    bitmapcounter++;
                   
                    device.ImmediateContext.UnmapSubresource(theonboardcomputertextureFINAL, 0);
                    DeleteObject(interptr1);
                    //DISCARDED
                    //DISCARDED
                    //DISCARDED


                }
            }
        }














        static int someInitItems = 0;
        //UI THREAD TEST
        //////////////////////////////////
        //////////////////////////////////
        public static void sccsScriptAutoCorrectNMultiply()
        {
            //Console.WriteLine("0_mainThreadStarter");
            if (someInitItems == 0)
            {
                //Console.WriteLine("1_mainThreadStarter");
                var updateMainUITitle2 = new Action(() =>
                {



                    //_mainUpdateThread();
                });
                // XmlDocument doc = new XmlDocument();
                //doc.Load("");

                string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                //Console.WriteLine("2_mainThreadStarter");
                string folderName = "#Cryofallscriptgen";
                DirectoryInfo directoryFolder = new DirectoryInfo(folderName);
                directoryFolder.Refresh();
                string pathToDesktopFolder = pathToDesktop + @"\" + folderName;

                //Console.WriteLine("2_mainThreadStarter");
                if (!Directory.Exists(pathToDesktopFolder))
                {
                    Console.WriteLine("0the directory !exists");
                    Directory.CreateDirectory(pathToDesktopFolder);
                }
                else
                {
                    Console.WriteLine("0the directory exists");
                }



                string folderNameOriginal = "original";
                DirectoryInfo dirnameOriginal = new DirectoryInfo(folderNameOriginal);
                dirnameOriginal.Refresh();
                //Console.WriteLine("2_mainThreadStarter");
                if (!Directory.Exists(pathToDesktop + @"\" + folderName))
                {
                    Console.WriteLine("1the directory !exists");
                    Directory.CreateDirectory(folderNameOriginal);
                }
                else
                {
                    Console.WriteLine("1the directory exists");
                }

                string finalPathOriginal = pathToDesktop + @"\" + folderName + @"\" + folderNameOriginal;
                Console.WriteLine(finalPathOriginal);




                string folderNameMul = "multiplied";
                string mulPath = pathToDesktop + @"\" + folderName + @"\" + folderNameMul;
                if (!Directory.Exists(mulPath))
                {
                    Console.WriteLine("2the directory !exists");
                    Directory.CreateDirectory(mulPath);
                }
                else
                {
                    Console.WriteLine("2the directory exists");
                }


                var arrayOfFiles = Directory.GetFiles(finalPathOriginal);


                if (arrayOfFiles.Length > 0)
                {
                    Console.WriteLine("Got Files");
                }
                else
                {
                    //Console.WriteLine("!Got Files");
                }

                DirectoryInfo dirnameMulNewFiles = new DirectoryInfo(mulPath);

                string[] arrayOfOnlyfileNamesFormationOne = new string[arrayOfFiles.Length];
                string[] arrayOfOnlyfileNamesFormationORIGINAL = new string[arrayOfFiles.Length];

                var indexToChange = 0;
                var mainIterator = 0;

                var formationLength = 5;


                for (int i = 0; i < arrayOfOnlyfileNamesFormationORIGINAL.Length; i++)
                {
                    arrayOfOnlyfileNamesFormationORIGINAL[i] = arrayOfFiles[i];
                }


                for (int f = 0; f < formationLength; f++)
                {

                    var indexMain = f + 1;
                    for (int i = 0; i < arrayOfFiles.Length; i++)
                    {
                        arrayOfFiles[i] = arrayOfOnlyfileNamesFormationORIGINAL[i];
                        /*if (mainIterator >= arrayOfFiles.Length)
                        {
                            mainIterator = 0;
                            indexToChange += 1;
                        }*/
                        //Console.WriteLine("3the directory exists");

                        var filenewPath = folderNameMul + @"\" + arrayOfFiles[i];

                        var someString = pathToDesktop + @"\" + folderName + @"\" + folderNameOriginal + @"\";
                        //var test = arrayOfFiles[i];
                        var newstring = arrayOfFiles[i].Substring(someString.Length);
                        arrayOfOnlyfileNamesFormationOne[i] = newstring;

                        //var removedExtension = arrayOfFiles[i].Substring(someString.Length);

                        var someOtherString = Path.ChangeExtension(newstring, "");
                        //Console.WriteLine(newstring);

                        var somePathOri = Path.Combine(pathToDesktop + @"\" + folderName + @"\" + folderNameOriginal, newstring);
                        var somePathMul = Path.Combine(pathToDesktop + @"\" + folderName + @"\" + folderNameMul, newstring);

                        var someStringOri = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\";
                        var somestuff = Path.ChangeExtension(somePathMul, ".xml");

                        somestuff = somestuff.Substring(someStringOri.Length);

                        var arrayOfFilesToMod = somestuff;
                        string st = "_" + (indexMain);
                        //arrayOfFilesToMod.Replace("_1", st);

                        /*Regex regex = new Regex(@"cc_");
                        var input = arrayOfFilesToMod;
                        var output = regex.Replace(input, "Mining_");*/

                        Regex regex2 = new Regex(@"_1");
                        var input2 = arrayOfFilesToMod; //output
                        var output2 = regex2.Replace(input2, "_" + indexMain);

                        /*foreach (var test in arrayOfFilesToMod.Where(x => x == "_1"))
                        {
                            
                        }*/

                        //File.ReadAllText(arrayOfFilesToMod).Replace("_1", st);
                        //Console.WriteLine(output);

                        var lastPath = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\" + output2;
                        File.Copy(arrayOfFiles[i], lastPath, true);//Path.ChangeExtension(lastPath, ".xml")
                    }
                }

                dirnameMulNewFiles.Refresh();

                arrayOfOnlyfileNamesFormationOne = Directory.GetFiles(mulPath);

                string[] arrayOfFilesNames = new string[arrayOfOnlyfileNamesFormationOne.Length];
                for (int i = 0; i < arrayOfOnlyfileNamesFormationOne.Length; i++)
                {
                    arrayOfFilesNames[i] = arrayOfOnlyfileNamesFormationOne[i];// Replace("1", "2");
                }

                /*string[] arrayOfOnlyfileNamesFormationTwo = new string[arrayOfOnlyfileNamesFormationOne.Length];
                string[] arrayOfOnlyfileNamesFormationThree = new string[arrayOfOnlyfileNamesFormationOne.Length];
                string[] arrayOfOnlyfileNamesFormationFour = new string[arrayOfOnlyfileNamesFormationOne.Length];
                string[] arrayOfOnlyfileNamesFormationFive = new string[arrayOfOnlyfileNamesFormationOne.Length];

                for (int i = 0; i < arrayOfOnlyfileNamesFormationOne.Length; i++)
                {
                    arrayOfOnlyfileNamesFormationTwo[i] = arrayOfOnlyfileNamesFormationOne[i];// Replace("1", "2");
                    arrayOfOnlyfileNamesFormationThree[i] = arrayOfOnlyfileNamesFormationOne[i];// .Replace("2", "3");
                    arrayOfOnlyfileNamesFormationFour[i] = arrayOfOnlyfileNamesFormationOne[i];// .Replace("3", "4");
                    arrayOfOnlyfileNamesFormationFive[i] = arrayOfOnlyfileNamesFormationOne[i];// .Replace("4", "5");
                }*/




                for (int f = 0; f < formationLength; f++)
                {
                    var indexMain = f + 1;

                    var currentStringIndexMain = "_" + indexMain;

                    for (int i = 0; i < arrayOfOnlyfileNamesFormationOne.Length; i++)
                    {
                        if (arrayOfOnlyfileNamesFormationOne[i].Contains(currentStringIndexMain))
                        {
                            var someString = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\";
                            var newstring = arrayOfOnlyfileNamesFormationOne[i].Substring(someString.Length);
                            var someLastString = someString + newstring;

                            Console.WriteLine(someLastString);


                            var menuOption = 1;

                            if (menuOption == 0)
                            {

                                var lastString = "Mining_";
                                var lastString2 = "_" + indexMain;
                                File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("Combat_cc_", lastString).Replace("_1", lastString2));



                                if (File.Exists(someLastString))
                                {
                                    //Console.WriteLine("02File.Exists");
                                    FileInfo filinfo = new FileInfo(someLastString);
                                    filinfo.Refresh();
                                }


                                //var newString = File.ReadAllText(someLastString);

                                lastString = "Mining_";
                                lastString2 = "_" + indexMain;
                                File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("cc_", lastString).Replace("_1", lastString2));

                            }
                            else
                            {
                                /*var lastString = "Mining_";
                                var lastString2 = "_" + indexMain;
                                File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("Combat_cc_", lastString).Replace("_1", lastString2));*/



                                if (File.Exists(someLastString))
                                {
                                    //Console.WriteLine("02File.Exists");
                                    FileInfo filinfo = new FileInfo(someLastString);
                                    filinfo.Refresh();
                                }


                                //var newString = File.ReadAllText(someLastString);

                                //lastString = "Mining_";
                                var lastString2 = "_" + indexMain;
                                File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("_1", lastString2));
                            }














                            //Console.WriteLine(someLastString);

                            //File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("_1", lastString));

                            //Regex regex2 = new Regex(@"_1");
                            // var input2 = arrayOfFilesToMod;
                            //var output2 = regex2.Replace(input2, "_" + indexMain);


                            //Regex regex = new Regex(@"cc_1");
                            //var input = someLastString;
                            //var output = regex.Replace(input, "Mining_" + indexMain);

                            //File.WriteAllText(someLastString, output);

                            File.Copy(someLastString, someLastString, true); //Path.ChangeExtension(someLastString, ".js")
                        }
                    }
                }

                dirnameMulNewFiles.Refresh();

                //arrayOfOnlyfileNamesFormationOne = Directory.GetFiles(mulPath);



                for (int i = 0; i < arrayOfFilesNames.Length; i++)
                {
                    //Console.WriteLine(arrayOfFilesNames[i]);
                    //Directory.Fil(mulPath + @"\" + arrayOfOnlyfileNamesFormationOne[i]);
                    if (File.Exists(arrayOfOnlyfileNamesFormationOne[i]))
                    {
                        //Console.WriteLine("02File.Exists");
                        FileInfo filinfo = new FileInfo(arrayOfOnlyfileNamesFormationOne[i]);
                        filinfo.Delete();
                    }

                }



                dirnameMulNewFiles.Refresh();





                Console.WriteLine("ended scripts multiplication");

                //var someString = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\";
                //var test = arrayOfFiles[i];
                //var newstring = arrayOfFiles[i].Substring(someString.Length);
                //var someTest = newstring; // arrayOfOnlyfileNamesFormationOne[i] 



                /*for (int i = 0; i < arrayOfOnlyfileNamesFormationOne.Length; i++)
                {
                    if (arrayOfOnlyfileNamesFormationOne[i].Contains(""))
                    {

                    }
                    //Console.WriteLine(arrayOfOnlyfileNamesFormationFive[i]);

                    if (File.Exists(arrayOfOnlyfileNamesFormationOne[i]))
                    {
                        //Console.WriteLine("02File.Exists");
                        FileInfo filinfo = new FileInfo(arrayOfOnlyfileNamesFormationOne[i]);
                        filinfo.Refresh();
                    }
                    var filenewPath = folderNameMul + @"\" + arrayOfOnlyfileNamesFormationOne[i];

                    var someString = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\";
                    //var test = arrayOfOnlyfileNamesFormationOne[i];
                    var newstring = arrayOfOnlyfileNamesFormationOne[i].Substring(someString.Length);

                    //newstring = newstring+ ".xml";

                    //var somePathMul = Path.Combine(pathToDesktop + @"\" + folderName + @"\" + folderNameMul, newstring);

                    var someLastString = someString + newstring;

                    //Console.WriteLine(someLastString);

                    if (File.Exists(someLastString))
                    {
                        //Console.WriteLine("02File.Exists");
                        FileInfo filinfo = new FileInfo(someLastString);
                        filinfo.Refresh();

                        var someResults = File.ReadAllText(someLastString);

                        someResults.Replace("_1", "_5");

                        //File.WriteAllText(someLastString, someResults);

                        File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("_1", "_5"));
                    }
                    else
                    {
                       // Console.WriteLine("02File.!Exists");
                    }
                }*/

























                //arrayOfOnlyfileNames[i]
                //Console.WriteLine(someResults);








                /*using (XmlReader xmlreader = new XmlTextReader(someLastString))
                {
                    //Console.WriteLine("element: ");
                    while (xmlreader.Read())
                    {
                        Console.WriteLine("element: ");
                        //var element = xmlreader.Name;
                        //Console.WriteLine("element: " + element);
                    }
                }*/
                /*XDocument doc = XDocument.Load(someLastString);

                using (var reader = XmlReader.Create(someLastString))
                {
                    reader.Dispose();
                    //doc = XDocument.Load(lastPath2);
                }*/



                //XDocument doc = new XDocument();
                //string xmlString = "<book><title>Oberon's Legacy</title></book>";
                //doc.Load(new StringReader(someLastString));
                //var lastPath2 = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\" + someOtherString + ".xml";
                //XmlDocument doc = new XmlDocument();
                //doc.Load(lastPath);










                //File.Move(arrayOfFiles[i], Path.ChangeExtension(lastPath, ".xml"));
                //dirnameMulNewFiles.Refresh();

                // Console.WriteLine("4the directory exists " + arrayOfFiles[i]);

                /*if (!File.Exists(lastPath))
                {
                    Console.WriteLine("00!File.Exists");
                    FileInfo filinfo = new FileInfo(lastPath);
                    filinfo.Refresh();
                }
                else
                {
                    Console.WriteLine("01File.Exists");
                }*/
                //var result = Path.ChangeExtension(lastPath, ".xml");


                /*var lastPath2 = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\" + someOtherString + ".xml";
                //XmlDocument doc = new XmlDocument();
                //doc.Load(lastPath);


                if (File.Exists(lastPath2))
                {
                    Console.WriteLine("02File.Exists");
                    FileInfo filinfo = new FileInfo(lastPath2);
                    filinfo.Refresh();
                }
                else
                {
                    Console.WriteLine("02File.!Exists");
                }*/
                //XDocument doc = XDocument.Load(lastPath2);
                //doc.Save(lastPath2);


                /*using (XmlTextReader textReader = new XmlTextReader(lastPath2))
                {
                    while (textReader.Read())
                    {
                        var element = textReader.Name;
                        //Console.WriteLine(element + "");

                    }
                    textReader.Close();
                }*/


                //XmlDocument doc = new XmlDocument();
                //doc.Load(lastPath2);


                //                   System.Text.Encoding.UTF8







                //textReader.Read();




                /*XDocument doc = XDocument.Load(lastPath2);

                using (var reader = XmlReader.Create(lastPath2))
                {
                    reader.Dispose();
                    //doc = XDocument.Load(lastPath2);
                }*/



                //XDocument doc = XDocument.Load(lastPath);
                //doc.Save(lastPath2);




                //System.Xml.XmlText

                //XmlReader xmlreader = new XmlReader();

                //XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8);
                /*using (XmlTextReader xmlreader = new XmlTextReader(lastPath2))
                {
                    while (xmlreader.Read())
                    {

                    }
                }*/
                //new StringReader(lastPath2))

                //File.Move();

                /*if (File.Exists(arrayOfFiles[i]))
                {
                    FileInfo filinfo = new FileInfo(arrayOfFiles[i]);
                    filinfo.Refresh();
                }*/

                /*var result = Path.ChangeExtension(lastPath,".xml");
                Console.WriteLine(result);
                if (File.Exists(lastPath))
                {
                    FileInfo filinfo = new FileInfo(lastPath);
                    filinfo.Refresh();
                }*/




                /*for (int i = 0; i < arrayOfOnlyfileNamesFormationOne.Length; i++)
                {
                    arrayOfOnlyfileNamesFormationTwo[i].Replace("1", "2");
                    arrayOfOnlyfileNamesFormationThree[i].Replace("1", "3");
                    arrayOfOnlyfileNamesFormationFour[i].Replace("1", "4");
                    arrayOfOnlyfileNamesFormationFive[i].Replace("1", "5");
                }*/






                //XmlDocument doc = new XmlDocument();
                //doc.Load("");










                //Console.WriteLine("3_mainThreadStarter");
                //System.Windows.Threading.Dispatcher.Invoke(updateMainUITitle2);

                /*if (!File.Exists(folderName))
                {
                    FileInfo filinfo = new FileInfo(folderName);
                    filinfo.Refresh();
                }*/

                //threadOneGrammarLoad();
                someInitItems = 3;
            }






            //Console.Title = "" + _mainThreadFrameCounter.ToString();

            //SC_GCGollect.GCCollectUtility(100);
        }
        //////////////////////////////////
        //////////////////////////////////















        public override sccsmessageobjectjitter[][] initscriptvariables(sccsmessageobjectjiter[][] _sc_jitter_tasks)
        {
            Console.WriteLine("sccsgraphicssec init_update_variables");
            return _sc_jitter_tasks;
        }


        public override sccsmessageobjectjitter[][] createworldobjects(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            Console.WriteLine("sccsgraphicssec _sc_create_world_objects");


            return _sc_jitter_tasks;
        }


        public override sccsmessageobjectjiter[][] Update(jitter_sc[] jitter_sc, sccsmessageobjectjiter[][] _sc_jitter_tasks)
        {
            //Console.WriteLine("sccsgraphicssec Update");

            //_sc_jitter_tasks = sccsgraphicssec._sc_create_world_objects(_sc_jitter_tasks);

            return _sc_jitter_tasks;
        }


        protected override sccsmessageobjectjitter[][] looprigidbody(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            Console.WriteLine("sccsgraphicssec loop_worlds");

            return _sc_jitter_tasks;
        }

        protected override sccsmessageobjectjitter[][] workOnSomething(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            Console.WriteLine("sccsgraphicssec workOnSomething");

            return _sc_jitter_tasks;
        }


        protected override sccsmessageobjectjitter[][] writetobuffer(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            Console.WriteLine("sccsgraphicssec sc_write_to_buffer");


            return _sc_jitter_tasks;
        }


        /*
        private void _oculus_touch_controls(double percentXRight, double percentYRight, Vector2f[] thumbStickRight, double percentXLeft, double percentYLeft, Vector2f[] thumbStickLeft, double realMousePosX, double realMousePosY) //
        {
            
        }

        private void _MicrosoftWindowsMouseRight(double percentXRight, double percentYRight, Vector2f[] thumbStickRight, double percentXLeft, double percentYLeft, Vector2f[] thumbStickLeft, double realMousePosX, double realMousePosY) //, double realOculusRiftCursorPosX, double realOculusRiftCursorPosY
        {
           
        }*/

        ~sccsgraphicssec()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // so that Dispose(false) isn't called later
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        
        protected override void ShutDownGraphics()
        {

        }



    }
}





/*
Vector3 current_handposR = new Vector3(_player_rght_hnd[0][0]._arrayOfInstances[0].current_pos.M41, _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos.M42, _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos.M43);

Matrix tempmatter = _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos;
Quaternion quater;
Quaternion.RotationMatrix(ref tempmatter, out quater);

var rayDirForward = sc_maths._getDirection(SharpDX.Vector3.ForwardRH, quater);
rayDirForward.Normalize();
var rayDirUp = sc_maths._getDirection(SharpDX.Vector3.Up, quater);
rayDirUp.Normalize();
var rayDirRight = sc_maths._getDirection(SharpDX.Vector3.Right, quater);
rayDirRight.Normalize();

Vector3 movingPointer = current_handposR + (-rayDirForward * _grab_rigid_data.dirDiffZ);
movingPointer = movingPointer + (rayDirRight * _grab_rigid_data.dirDiffX);
//movingPointer = movingPointer + (-rayDirUp * _grab_rigid_data.dirDiffY);

Matrix tempMat = _grab_rigid_data.position;// translationMatrix;
tempMat.M41 = 0;
tempMat.M42 = 0;
tempMat.M43 = 0;
tempMat.M44 = 1;

Quaternion.RotationMatrix(ref tempmatter, out quater);
JQuaternion _other_quatter = new JQuaternion(quater.X, quater.Y, quater.Z, quater.W);

Matrix anothertempmat = _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos;
anothertempmat.M41 = 0;
anothertempmat.M42 = 0;
anothertempmat.M43 = 0;
anothertempmat.M44 = 1;

var xq = _other_quatter.X;
var yq = _other_quatter.Y;
var zq = _other_quatter.Z;
var wq = _other_quatter.W;

var pitcha = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq);
var yawa = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq);
var rolla = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq);

double currentGrabrotDiffX = (pitcha - grabrotX);
double currentGrabrotDiffY = (yawa - grabrotY);
double currentGrabrotDiffZ =  (rolla - grabrotZ);

tempMatrix = SharpDX.Matrix.RotationYawPitchRoll((float)currentGrabrotDiffY, (float)currentGrabrotDiffX, (float)currentGrabrotDiffZ);

//_grab_rigid_data.position.Invert();

tempMatrix = _grab_rigid_data.position;// tempMatrix * _grab_rigid_data.position;


tempMatrix.M41 = movingPointer.X;
tempMatrix.M42 = movingPointer.Y;
tempMatrix.M43 = movingPointer.Z;

//anothertempmat.Invert();
//Matrix addMat = _grab_rigid_data.position;
//Matrix addresultMat;
//Matrix.Add(ref anothertempmat, ref addMat, out addresultMat);

Quaternion.RotationMatrix(ref tempMatrix, out quater);
body.Position = new JVector(movingPointer.X, movingPointer.Y, movingPointer.Z);
JQuaternion _other_quat = new JQuaternion(quater.X, quater.Y, quater.Z, quater.W);
var matrixIn = JMatrix.CreateFromQuaternion(_other_quat);
body.Orientation = matrixIn;*/





















/*
Matrix grabbedBodyMatrix = _grab_rigid_data.position;

var MOVINGPOINTER = new Vector3(_player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M41, _player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M42, _player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M43);
Matrix someMatRight = _rightTouchMatrix;
someMatRight.M41 = handPoseRight.Position.X + MOVINGPOINTER.X;
someMatRight.M42 = handPoseRight.Position.Y;// + MOVINGPOINTER.Y;
someMatRight.M43 = handPoseRight.Position.Z + MOVINGPOINTER.Z;
var diffNormPosX = (MOVINGPOINTER.X) - someMatRight.M41;
var diffNormPosY = (MOVINGPOINTER.Y) - someMatRight.M42;
var diffNormPosZ = (MOVINGPOINTER.Z) - someMatRight.M43;
MOVINGPOINTER = MOVINGPOINTER + -(current_rotation_of_torso_pivot_right* (diffNormPosX));
MOVINGPOINTER = MOVINGPOINTER + -(current_rotation_of_torso_pivot_up* (diffNormPosY));
MOVINGPOINTER = MOVINGPOINTER + (current_rotation_of_torso_pivot_forward* (diffNormPosZ));
Matrix finalHRMat = _rightTouchMatrix * OriginRot * RotatingMatrix * RotatingMatrixForPelvis;// ; //finalRotationMatrix
MOVINGPOINTER.X += SC_Update.OFFSETPOS.X;
MOVINGPOINTER.Y += SC_Update.OFFSETPOS.Y;
MOVINGPOINTER.Z += SC_Update.OFFSETPOS.Z;
Matrix handMatrix = _rightTouchMatrix;// _rightTouchMatrix * OriginRot * RotatingMatrix * RotatingMatrixForPelvis;
Quaternion quater;
Quaternion.RotationMatrix(ref handMatrix, out quater);
var xq = quater.X;
var yq = quater.Y;
var zq = quater.Z;
var wq = quater.W;
var pitchaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var yawaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var rollaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var pitchTouchR = (float)(Math.PI * (grabrotX - pitchaHand) / 180.0f);
var yawTouchR = (float)(Math.PI * (grabrotY - yawaHand) / 180.0f);
var rollTouchR = (float)(Math.PI * (grabrotZ - rollaHand) / 180.0f);
var rotatingMatrixForTouchR = SharpDX.Matrix.RotationYawPitchRoll(yawTouchR, pitchTouchR, rollTouchR);
var pitch = (float)(Math.PI * (SC_Update.RotationGrabbedX) / 180.0f);
var yaw = (float)(Math.PI * (SC_Update.RotationGrabbedY) / 180.0f);
var roll = (float)(Math.PI * (SC_Update.RotationGrabbedZ) / 180.0f);
var rotatingMatrixForGrabber = SharpDX.Matrix.RotationYawPitchRoll(yaw, pitch, roll);
var matrixerer = _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos * grabbedBodyMatrix; //rotatingMatrixForGrabber
matrixerer.M41 = MOVINGPOINTER.X;
matrixerer.M42 = MOVINGPOINTER.Y;
matrixerer.M43 = MOVINGPOINTER.Z;
matrixerer.M44 = 1;
body.Position = new JVector(MOVINGPOINTER.X, MOVINGPOINTER.Y, MOVINGPOINTER.Z);
Quaternion.RotationMatrix(ref matrixerer, out quater);
JQuaternion _other_quat = new JQuaternion(quater.X, quater.Y, quater.Z, quater.W);
var matrixIn = JMatrix.CreateFromQuaternion(_other_quat);
body.Orientation = matrixIn;
*/



/*
Matrix grabbedBodyMatrix = _grab_rigid_data.position;
var MOVINGPOINTER = new Vector3(_player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M41, _player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M42, _player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M43);
Matrix someMatRight = _rightTouchMatrix;
someMatRight.M41 = handPoseRight.Position.X + MOVINGPOINTER.X;
someMatRight.M42 = handPoseRight.Position.Y;// + MOVINGPOINTER.Y;
someMatRight.M43 = handPoseRight.Position.Z + MOVINGPOINTER.Z;
var diffNormPosX = (MOVINGPOINTER.X) - someMatRight.M41;
var diffNormPosY = (MOVINGPOINTER.Y) - someMatRight.M42;
var diffNormPosZ = (MOVINGPOINTER.Z) - someMatRight.M43;
MOVINGPOINTER = MOVINGPOINTER + -(current_rotation_of_torso_pivot_right * (diffNormPosX));
MOVINGPOINTER = MOVINGPOINTER + -(current_rotation_of_torso_pivot_up * (diffNormPosY));
MOVINGPOINTER = MOVINGPOINTER + (current_rotation_of_torso_pivot_forward * (diffNormPosZ));
Matrix finalHRMat = _rightTouchMatrix * OriginRot * RotatingMatrix * RotatingMatrixForPelvis;// ; //finalRotationMatrix
MOVINGPOINTER.X += SC_Update.OFFSETPOS.X;
MOVINGPOINTER.Y += SC_Update.OFFSETPOS.Y;
MOVINGPOINTER.Z += SC_Update.OFFSETPOS.Z;
Matrix handMatrix = _rightTouchMatrix;// _rightTouchMatrix * OriginRot * RotatingMatrix * RotatingMatrixForPelvis;
Quaternion quater;
Quaternion.RotationMatrix(ref handMatrix, out quater);
var xq = quater.X;
var yq = quater.Y;
var zq = quater.Z;
var wq = quater.W;
var pitchaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var yawaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var rollaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var pitchTouchR = (float)(Math.PI * (grabrotX - pitchaHand) / 180.0f);
var yawTouchR = (float)(Math.PI * (grabrotY - yawaHand) / 180.0f);
var rollTouchR = (float)(Math.PI * (grabrotZ - rollaHand) / 180.0f);
var rotatingMatrixForTouchR = SharpDX.Matrix.RotationYawPitchRoll(yawTouchR, pitchTouchR, rollTouchR);
var pitch = (float)(Math.PI * (SC_Update.RotationGrabbedX) / 180.0f);
var yaw = (float)(Math.PI * (SC_Update.RotationGrabbedY) / 180.0f);
var roll = (float)(Math.PI * (SC_Update.RotationGrabbedZ) / 180.0f);
var rotatingMatrixForGrabber = SharpDX.Matrix.RotationYawPitchRoll(yaw, pitch, roll);
var matrixerer = grabbedBodyMatrix * rotatingMatrixForGrabber* _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos; //rotatingMatrixForGrabber //_player_rght_hnd[0][0]._arrayOfInstances[0].current_pos * 
matrixerer.M41 = MOVINGPOINTER.X;
matrixerer.M42 = MOVINGPOINTER.Y;
matrixerer.M43 = MOVINGPOINTER.Z;
matrixerer.M44 = 1;
body.Position = new JVector(MOVINGPOINTER.X, MOVINGPOINTER.Y, MOVINGPOINTER.Z);
Quaternion.RotationMatrix(ref matrixerer, out quater);
JQuaternion _other_quat = new JQuaternion(quater.X, quater.Y, quater.Z, quater.W);
var matrixIn = JMatrix.CreateFromQuaternion(_other_quat);
body.Orientation = matrixIn;*/






/*
Matrix grabbedBodyMatrix = _grab_rigid_data.position;
Matrix handMatrix = _player_r_hand_grab[0][0]._arrayOfInstances[0]._TEMPPOSITION;// _rightTouchMatrix * OriginRot * RotatingMatrix * RotatingMatrixForPelvis * hmdmatrixRot_;
//_player_rght_hnd[0][0]._arrayOfInstances[0]._TEMPPOSITION; 

handMatrix.M41 = 0;
handMatrix.M42 = 0;
handMatrix.M43 = 0;
handMatrix.M44 = 1;

grabbedBodyMatrix.M41 = 0;
grabbedBodyMatrix.M42 = 0;
grabbedBodyMatrix.M43 = 0;
grabbedBodyMatrix.M44 = 1;

finalRotationMatrix.M41 = 0;
finalRotationMatrix.M42 = 0;
finalRotationMatrix.M43 = 0;
finalRotationMatrix.M44 = 1;

var MOVINGPOINTER = new Vector3(_player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M41, _player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M42, _player_torso[0][0]._arrayOfInstances[0]._ORIGINPOSITION.M43);
Matrix someMatRight = _rightTouchMatrix;// * OriginRot * RotatingMatrix * RotatingMatrixForPelvis * hmdmatrixRot_;
someMatRight.M41 = handPoseRight.Position.X + MOVINGPOINTER.X;
someMatRight.M42 = handPoseRight.Position.Y;// + MOVINGPOINTER.Y;
someMatRight.M43 = handPoseRight.Position.Z + MOVINGPOINTER.Z;
var diffNormPosX = (MOVINGPOINTER.X) - someMatRight.M41;
var diffNormPosY = (MOVINGPOINTER.Y) - someMatRight.M42;
var diffNormPosZ = (MOVINGPOINTER.Z) - someMatRight.M43;
MOVINGPOINTER = MOVINGPOINTER + -(current_rotation_of_torso_pivot_right* (diffNormPosX));
MOVINGPOINTER = MOVINGPOINTER + -(current_rotation_of_torso_pivot_up* (diffNormPosY));
MOVINGPOINTER = MOVINGPOINTER + (current_rotation_of_torso_pivot_forward* (diffNormPosZ));

MOVINGPOINTER.X += SC_Update.OFFSETPOS.X;
MOVINGPOINTER.Y += SC_Update.OFFSETPOS.Y;
MOVINGPOINTER.Z += SC_Update.OFFSETPOS.Z;

//Matrix matrixerer = _rightTouchMatrix;
//matrixerer.Invert();

Quaternion quater;
Quaternion.RotationMatrix(ref handMatrix, out quater);
var xq = quater.X;
var yq = quater.Y;
var zq = quater.Z;
var wq = quater.W;

var pitchaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var yawaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var rollaHand = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);

var pitchTouchR = (float)(Math.PI * (grabrotX - pitchaHand) / 180.0f);
var yawTouchR = (float)(Math.PI * (grabrotY - yawaHand) / 180.0f);
var rollTouchR = (float)(Math.PI * (grabrotZ - rollaHand) / 180.0f);

Matrix rotatingMatrixForTouchR = SharpDX.Matrix.RotationYawPitchRoll((float)yawTouchR, (float)pitchTouchR, (float)rollTouchR);
//Matrix rotatingMatrixForTouchR = Matrix.Scaling(1.0f) * Matrix.RotationX(pitchTouchR) * Matrix.RotationY(yawTouchR) * Matrix.RotationZ(rollTouchR);

var pitch = (float)(Math.PI * (-SC_Update.RotationGrabbedX) / 180.0f);
var yaw = (float)(Math.PI * (SC_Update.RotationGrabbedY) / 180.0f);
var roll = (float)(Math.PI * (SC_Update.RotationGrabbedZ) / 180.0f);

var rotatingMatrixForGrabber = SharpDX.Matrix.RotationYawPitchRoll(yaw, pitch, roll);




handMatrix = _player_r_hand_grab[0][0]._arrayOfInstances[0].current_pos;// * finalRotationMatrix;
//Quaternion quater;
Quaternion.RotationMatrix(ref handMatrix, out quater);

var rayDirForward = sc_maths._getDirection(SharpDX.Vector3.ForwardRH, quater);
rayDirForward.Normalize();
var rayDirUp = sc_maths._getDirection(SharpDX.Vector3.Up, quater);
rayDirUp.Normalize();
var rayDirRight = sc_maths._getDirection(SharpDX.Vector3.Right, quater);
rayDirRight.Normalize();

//handMatrix = _player_rght_hnd[0][0]._arrayOfInstances[0].current_pos;
var current_handposRR = new Vector3(MOVINGPOINTER.X,//_player_r_hand_grab[0][0]._arrayOfInstances[0].current_pos.M41,
MOVINGPOINTER.Y,//_player_r_hand_grab[0][0]._arrayOfInstances[0].current_pos.M42,
MOVINGPOINTER.Z);                //_player_r_hand_grab[0][0]._arrayOfInstances[0].current_pos.M43);

MOVINGPOINTER = current_handposRR + (rayDirForward* _grab_rigid_data.grabHitPointLength);
handMatrix = _player_r_hand_grab[0][0]._arrayOfInstances[0]._TEMPPOSITION* finalRotationMatrix;
var pitchTouchRer = (float)(Math.PI * ((float)SC_Update.RotationX4Pelvis) / 180.0f);
var yawTouchRer = (float)(Math.PI * ((float)SC_Update.RotationY4Pelvis) / 180.0f);
var rollTouchRer = (float)(Math.PI * ((float)SC_Update.RotationZ4Pelvis) / 180.0f);

var rotter = SharpDX.Matrix.RotationYawPitchRoll((float)yawTouchRer, (float)pitchTouchRer, (float)rollTouchRer);
Matrix matrixerer = handMatrix;
matrixerer.M41 = MOVINGPOINTER.X;
matrixerer.M42 = MOVINGPOINTER.Y;
matrixerer.M43 = MOVINGPOINTER.Z;
matrixerer.M44 = 1;

body.Position = new JVector(MOVINGPOINTER.X, MOVINGPOINTER.Y, MOVINGPOINTER.Z);
Quaternion.RotationMatrix(ref matrixerer, out quater);
JQuaternion _other_quat = new JQuaternion(quater.X, quater.Y, quater.Z, quater.W);
var matrixIn = JMatrix.CreateFromQuaternion(_other_quat);
body.Orientation = matrixIn;*/




//Matrix matrixerer = _rightTouchMatrix;
//matrixerer.Invert();





/*Quaternion.RotationMatrix(ref grabbedBodyMatrix, out quater);
xq = quater.X;
yq = quater.Y;
zq = quater.Z;
wq = quater.W;

var pitchaHand1 = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq) * (180 / Math.PI);
var yawaHand1 = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq)  * (180 / Math.PI);
var rollaHand1 = (float)Math.Atan2(2 * yq * wq - 2 * xq * zq, 1 - 2 * yq * yq - 2 * zq * zq)  * (180 / Math.PI);

var pitchTouchR = (float)(Math.PI * (pitchaHand1) / 180.0f); // - (grabrotX- pitchaHand)
var yawTouchR = (float)(Math.PI * (yawaHand1) / 180.0f);
var rollTouchR = (float)(Math.PI * (rollaHand1) / 180.0f); // - (grabrotZ - rollaHand)

Matrix rotatingMatrixForTouchR = SharpDX.Matrix.RotationYawPitchRoll((float)yawTouchR, (float)pitchTouchR, (float)rollTouchR);
//Matrix rotatingMatrixForTouchR = Matrix.Scaling(1.0f) * Matrix.RotationX(pitchTouchR) * Matrix.RotationY(yawTouchR) * Matrix.RotationZ(rollTouchR);
*/
//var pitch = (float)(Math.PI * (-SC_Update.RotationGrabbedX) / 180.0f);
//var yaw = (float)(Math.PI * (SC_Update.RotationGrabbedY) / 180.0f);
//var roll = (float)(Math.PI * (SC_Update.RotationGrabbedZ) / 180.0f);
//var rotatingMatrixForGrabber = SharpDX.Matrix.RotationYawPitchRoll(yaw, pitch, roll);




//handMatrix = _player_r_hand_grab[0][0]._arrayOfInstances[0].current_pos;// * finalRotationMatrix;
//Quaternion quater;






/*float timeSinceStart = (float)(DateTime.Now - SC_Update.startTime).TotalSeconds;


var pitcher = (float)(Math.PI * (pitchaHand - touchRX) / 180.0f);
var yawer = (float)(Math.PI * (yawaHand - touchRY) / 180.0f);
var roller = (float)(Math.PI * (rollaHand - touchRZ) / 180.0f);
var rotatingMatrixF = SharpDX.Matrix.RotationYawPitchRoll(yawer, pitcher, roller);

totalDiffX = pitcher;
totalDiffY = yawer;
totalDiffZ = roller;

//rotatingMatrixF *= RotatingMatrixForPelvis;

var pitch = (float)(Math.PI * (-SC_Update.RotationGrabbedX) / 180.0f);
var yaw = (float)(Math.PI * (SC_Update.RotationGrabbedY) / 180.0f);
var roll = (float)(Math.PI * (SC_Update.RotationGrabbedZ) / 180.0f);
var rotatingMatrixForGrabber = SharpDX.Matrix.RotationYawPitchRoll(yaw, pitch, roll);

///Quaternion.RotationMatrix(ref rotatingMatrixF, out quaterNion);

Quaternion.RotationMatrix(ref handMatrix, out quater);

var rayDirForwardGrab = sc_maths._getDirection(SharpDX.Vector3.ForwardRH, quater);
rayDirForwardGrab.Normalize();
var rayDirUpGrab = sc_maths._getDirection(SharpDX.Vector3.Up, quater);
rayDirUpGrab.Normalize();
var rayDirRightGrab = sc_maths._getDirection(SharpDX.Vector3.Right, quater);
rayDirRightGrab.Normalize();

Vector3 grabPos = new Vector3(grabbedBodyMatrix.M41,
grabbedBodyMatrix.M42,
grabbedBodyMatrix.M43);

Vector3 lookAt = Vector3.TransformCoordinate(Vector3.ForwardRH, rotatingMatrixHand);
Vector3 up = Vector3.TransformCoordinate(Vector3.Up, rotatingMatrixHand);

Quaternion currentRot;
Quaternion.RotationMatrix(ref grabbedBodyMatrix, out currentRot);
matrixerer = Matrix.Scaling(1.0f)* grabbedBodyMatrix * Matrix.RotationY(totalDiffY);
matrixerer.Invert();
*/
/*Quaternion quatYaw = new Quaternion(0, , 0,1);
quatYaw.Normalize();
//quatYaw *= currentRot;
//quatYaw.Normalize();
currentRot *= quatYaw;
currentRot.Normalize();


//Quaternion quatPitch = new Quaternion(pitchaHand, 0, 0, 1);
//currentRot *= quatPitch;
//currentRot.Normalize();
                                                                
Matrix.RotationQuaternion(ref currentRot, out matrixerer);*/

//Vector3 lookAt = Vector3.TransformCoordinate(rayDirForwardGrab, rotatingMatrixHand);
//Vector3 up = Vector3.TransformCoordinate(rayDirUpGrab, rotatingMatrixHand);

//Vector3 positionDisplacement = Vector3.TransformCoordinate(MOVINGPOINTER, rotatingMatrixHand);

// Finally create the view matrix from the three updated vectors.

//matrixerer = Matrix.LookAtRH(MOVINGPOINTER, MOVINGPOINTER + lookAt, up);
//matrixerer.Invert();

/*//https://stackoverflow.com/questions/29571093/sharpdx-vector3-transform-method-doesnt-seem-to-rotate-vector-correctly
Vector3 eyePos = MOVINGPOINTER;// new Vector3(0, 1, 0);
Vector3 target = MOVINGPOINTER + rayDirForward; //Vector3.Zero;



Quaternion lookAt = Quaternion.LookAtRH(eyePos, target, rayDirUp);
lookAt.Normalize();

Vector3 newForward = Vector3.Transform(rayDirForward, lookAt);
newForward.Normalize();

Vector3 newUp = Vector3.Transform(rayDirUp, lookAt);
newUp.Normalize();


//MOVINGPOINTER += newForward;

Matrix matrixerer = Matrix.LookAtRH(MOVINGPOINTER, MOVINGPOINTER + newForward, newUp);*/

//matrixerer *= _rightTouchMatrix * finalRotationMatrix;





//JUNK OF MICROSOFT NOT WORKING - the piece of shits of microsoft.
//https://stackoverflow.com/questions/2929255/unable-to-launch-onscreen-keyboard-osk-exe-from-a-32-bit-process-on-win7-x64
//https://www.dreamincode.net/forums/topic/174949-open-on-screen-keyboard-in-c%23/
/*Process[] p = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(OnScreenKeyboardExe));

if (p.Length == 0)
{
    // we must start osk from an MTA thread
    if (Thread.CurrentThread.GetApartmentState() == ApartmentState.STA)
    {
        ThreadStart start = new ThreadStart(StartOsk);
        Thread thread = new Thread(start);
        thread.SetApartmentState(ApartmentState.MTA);
        thread.Start();
        thread.Join();
    }
    else
    {
        StartOsk();
    }
}
else
{
    // there might be a race condition if the process terminated 
    // meanwhile -> proper exception handling should be added
    //
    SendMessage(p[0].MainWindowHandle, WM_SYSCOMMAND, new IntPtr(SC_RESTORE), new IntPtr(0)); //MainWindowHandle
}*/


//StartOsk();

/*string windowsKeyboard = "osk";

foreach (Process clsProcess in Process.GetProcesses())
{
    if (clsProcess.ProcessName.ToLower().Contains(windowsKeyboard.ToLower()))
    {
        break;
    }
    else
    {
        Process proc = new Process();
        proc.StartInfo.FileName = windowsKeyboard + ".exe";
        proc.Start();
        break;
    }
}*/

/* ProcessStartInfo startInfo = new ProcessStartInfo();
 startInfo.CreateNoWindow = false;
 startInfo.UseShellExecute = true;
 startInfo.WorkingDirectory = @"c:\WINDOWS\system32\";
 startInfo.FileName = "osk.exe";
 startInfo.Verb = "runas";
 startInfo.WindowStyle = ProcessWindowStyle.Normal;

 try
 {
     using (Process process = Process.Start(startInfo))
     {
         process.WaitForExit();
     }
 }
 catch (Exception)
 {
     //throw;
 }*/



//System.Diagnostics.Process.Start("osk.exe");
/*string windir = Environment.GetEnvironmentVariable("windir");

Process p = new Process();
p.StartInfo.FileName = windir + @"\System32\cmd.exe";
p.StartInfo.Arguments = "/C " + windir + @"\System32\osk.exe";
p.StartInfo.CreateNoWindow = true;
p.StartInfo.UseShellExecute = false;
p.Start();
p.Dispose();*/





/*
if (textureByteArray[bytePoser + 0] > 255)
{
    textureByteArray[bytePoser + 0] = 255;
}


if (textureByteArray[bytePoser + 1] > 255)
{
    textureByteArray[bytePoser + 1] = 255;
}


if (textureByteArray[bytePoser + 2] > 255)
{
    textureByteArray[bytePoser + 2] = 255;
}*/




/*
textureByteArray[bytePoser + 0] = (byte)(textureByteArray[bytePoser + 0] - (255 - valuereducedtoahundredg));
textureByteArray[bytePoser + 1] = (byte)(textureByteArray[bytePoser + 1] - (255 - valuereducedtoahundredb));
textureByteArray[bytePoser + 2] = (byte)(textureByteArray[bytePoser + 2] - (255 - valuereducedtoahundredr));
*/
/*
textureByteArray[bytePoser + 0] = (byte)(textureByteArray[bytePoser + 0] - (255 - valuereducedtoahundredg));
textureByteArray[bytePoser + 1] = (byte)(textureByteArray[bytePoser + 1] - (255 - valuereducedtoahundredb));
textureByteArray[bytePoser + 2] = (byte)(textureByteArray[bytePoser + 2] - (255 - valuereducedtoahundredr));
*/














/*if (textureByteArray[bytePoser + 0] < 25 && textureByteArray[bytePoser + 1] >= 240 && textureByteArray[bytePoser + 2] < 25)
{
    textureByteArray[bytePoser + 0] = 255;
    textureByteArray[bytePoser + 1] = 0;
    textureByteArray[bytePoser + 2] = 0;
    countgreenscreenpixelsareweinanoptiontransition++;
}

if (textureByteArray[bytePoser + 0] >= 125 && textureByteArray[bytePoser + 0] < 200 && textureByteArray[bytePoser + 1] < 125 && textureByteArray[bytePoser + 2] >= 125)
{
    textureByteArray[bytePoser + 0] = 0; //g
    textureByteArray[bytePoser + 1] = 0; //b 
    textureByteArray[bytePoser + 2] = 0; //r
    textureByteArray[bytePoser + 3] = 0;
}*/

























/*var _bitmap = new System.Drawing.Bitmap(texturetoload.width, texturetoload.height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
var boundsRect = new System.Drawing.Rectangle(0, 0, texturetoload.width, texturetoload.height);
var bmpData = _bitmap.LockBits(boundsRect, ImageLockMode.ReadOnly, _bitmap.PixelFormat);
_bytesTotal = Math.Abs(bmpData.Stride) * _bitmap.Height;
_bitmap.UnlockBits(bmpData);
_textureByteArray = new byte[_bytesTotal];
bmpData = null;

this._textureDescription = new Texture2DDescription
{
    CpuAccessFlags = CpuAccessFlags.Read,
    BindFlags = BindFlags.None,//BindFlags.None, //| BindFlags.RenderTarget
    Format = Format.B8G8R8A8_UNorm,
    Width = texturetoload.width,
    Height = texturetoload.height,
    OptionFlags = ResourceOptionFlags.None,
    MipLevels = 1,
    ArraySize = 1,
    SampleDescription = { Count = 1, Quality = 0 },
    Usage = ResourceUsage.Staging
};

this._textureDescriptionFinal = new Texture2DDescription
{
    CpuAccessFlags = CpuAccessFlags.None,
    BindFlags = BindFlags.ShaderResource | BindFlags.RenderTarget,
    Format = Format.B8G8R8A8_UNorm,
    Width = texturetoload.width,
    Height = texturetoload.height,
    OptionFlags = ResourceOptionFlags.GenerateMipMaps,
    MipLevels = 1,
    ArraySize = 1,
    SampleDescription = { Count = 1, Quality = 0 },
    Usage = ResourceUsage.Default
};

_texture2D = new Texture2D(device, _textureDescription);

_texture2DFinal = new Texture2D(device, _textureDescriptionFinal);


device.ImmediateContext.CopyResource(texturetoload.texture, _texture2DFinal);
device.ImmediateContext.CopyResource(_texture2DFinal, _texture2D);


var dataBox1 = device.ImmediateContext.MapSubresource(_texture2D, 0, SharpDX.Direct3D11.MapMode.Read, SharpDX.Direct3D11.MapFlags.None);

int memoryBitmapStride = _textureDescription.Width * 4;

int columns = _textureDescription.Width;
int rows = _textureDescription.Height;
IntPtr interptr1 = dataBox1.DataPointer;

// It can happen that the stride on the GPU is bigger then the stride on the bitmap in main memory (_width * 4)
if (dataBox1.RowPitch == memoryBitmapStride)
{
    // Stride is the same
    Marshal.Copy(interptr1, _textureByteArray, 0, _bytesTotal);
}
else
{
    // Stride not the same - copy line by line
    for (int y = 0; y < texturetoload.height; y++)
    {
        Marshal.Copy(interptr1 + y * dataBox1.RowPitch, _textureByteArray, y * memoryBitmapStride, memoryBitmapStride);
    }
}
var somebitmap = new System.Drawing.Bitmap(columns, rows, columns * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, interptr1);
somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rows.ToString("00") + columns.ToString("00") + ".png");
bitmapcounter++;
device.ImmediateContext.UnmapSubresource(_texture2D, 0);
DeleteObject(interptr1);
*/













/*
this._textureDescription = new Texture2DDescription
{
    CpuAccessFlags = CpuAccessFlags.Read,
    BindFlags = BindFlags.None,//BindFlags.None, //| BindFlags.RenderTarget
    Format = Format.B8G8R8A8_UNorm,
    Width = _width,
    Height = _height,
    OptionFlags = ResourceOptionFlags.None,
    MipLevels = 1,
    ArraySize = 1,
    SampleDescription = { Count = 1, Quality = 0 },
    Usage = ResourceUsage.Staging
};*/



//sctextureloader texturetoload = new sctextureloader();
//var textureinit = texturetoload.Initialize(D3D.device, "../../../1x1_pink_color.png");

/*
if (arrayoforiginalpngfiles[i].Contains("WeaponMelee"))
{
    //Console.WriteLine(arrayoforiginalpngfiles[i]);

}
else
{
    continue;
}*/
