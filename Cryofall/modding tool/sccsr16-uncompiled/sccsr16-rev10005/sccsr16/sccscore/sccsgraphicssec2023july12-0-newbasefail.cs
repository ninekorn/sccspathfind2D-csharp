using System;
using SharpDX;
using System.Runtime.InteropServices;

using sccsmessage = sccsmessage.sc_message_object;
using sccsmessageobjectjitter = sccsmessage.sc_message_object_jitter;

using System.Text.RegularExpressions;

using SharpDX.DXGI;
using SharpDX.Direct3D11;
using SCCoreSystems;
using System.Reflection.Metadata;
using SharpDX.Win32;
using SharpDX.WIC;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace sccs
{
    public class sccsgraphicssec : sccsdirectx, IDisposable
    {
        SharpDX.Direct3D11.Texture2D thetexture2dlast;
        SharpDX.WIC.BitmapDecoder bitmapDecoderlast;
        SharpDX.WIC.ImagingFactory factorylast;
        Texture2D theonboardcomputertextureFINALlast;
        SharpDX.WIC.FormatConverter bitmapsourceresultlast;
        System.Drawing.Bitmap somebitmaplast;

        public IntPtr interptr1last;
        public int startmultiplicationprocessswtc = 0;
        public int endthread0 = 0;

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

        int debugtoconsole = 1;


        int swtcforonoff = 0; //only use zero. 0 is for current revision. 1 is for crap revision that doesn't work. 2 is for old revision.

       public Thread mainsccsgraphicssecthread;


        public static sccsgraphicssec currentsccsgraphicssec;

        public int hastodeletefilesswtc = 0;
        public sccsgraphicssec()
        {
           
            currentsccsgraphicssec = this;
            Console.Title = "Mobs variants builder/creator for Cryofall V1.33.1.15 - sccsr16-rev-0.11 - made by steve chassé aka ninekorn. updated 2023/july/07";

            if (debugtoconsole == 1)
            {
                Console.WriteLine("sccsgraphicssec started");

            }

        }

        public void startmultiplicationprocess()
        {
            Stopwatch thestopwatch = new Stopwatch();
            thestopwatch.Start();


            sccsr16.Form1.currentform.startmultiplicationprocessthreadswtc = 1;

            mainsccsgraphicssecthread = new Thread((tester0000) =>
            {
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
                    //Console.WriteLine(ex.ToString());
                    return;
                }

                try
                {
                    this.device = new SharpDX.Direct3D11.Device(_adapter);
                    //this._device = sccs.SC_Console_DIRECTX._dxdevice.device;
                }
                catch (SharpDXException ex)
                {
                    //Console.WriteLine(ex.ToString());
                    return;
                }
                //CREATING A SHARPDX DIRECT3D11 device.




                if (this.device == null)
                {
                    //Console.WriteLine("null device");
                }
                else
                {
                    //Console.WriteLine("!null device");
                }


            _thread_main_loop:


                /*
                if (hastodeletefilesswtc == 1)
                {
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

                            string pathtomods = dirinfo.FullName + @"\" + foldername + @"\" + "multiplied";

                            DirectoryInfo directoryFolder = new DirectoryInfo(pathtomods);
                            directoryFolder.Refresh();

                            List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(pathtomods));

                            foreach (var dir1 in dirs1)
                            {
                                //string modmpkname = $"{dir1.Substring(dir1.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                //listBox1.Items.Add(modmpkname);

                                File.Delete(dir1);

                            }
                        }
                    }
                    hastodeletefilesswtc = 0;
                }*/














                if (startmultiplicationprocessswtc == 1)
                {

                    if (swtcforonoff == 0)
                    {




                        var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                        /*
                        if (Directory.Exists(dirinfo))
                        {

                        }*/

                        //GET PATH TO #Cryofallscriptgen
                        string pathToDesktop = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
                        DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
                        directoryFolder.Refresh();
                        //GET PATH TO #Cryofallscriptgen

                        if (debugtoconsole == 1)
                        {
                            Console.WriteLine("desktop folder #Cryofallscriptgen found.");
                        }

                        //PREPARE STRING PATHS TO ORIGINAL AND MULTIPLIED
                        string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";
                        string prefinalpathtofilesmultiplied = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "multiplied";
                        string pathoforiginalfolder = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder;
                        int lengthofpath = pathoforiginalfolder.Length;
                        //PREPARE STRING PATHS TO ORIGINAL AND MULTIPLIED

                        ////Console.WriteLine(prefinalpathtofiles);
                        //var arrayoforiginalzonesscriptfiles = Directory.GetFiles(prefinalpathtofiles);

                        int numberofvariants = 9;
                        //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                        //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// Environment.SpecialFolder.MyDocuments);
                        List<string> dirs = new List<string>(Directory.EnumerateDirectories(pathToDesktop));



                        if (debugtoconsole == 1)
                        {
                            Console.WriteLine("Listing mods from Documents/Cryofall/Mods");
                        }

                        int mainninesmodsfoldercounter = 0;
                        foreach (var dir in dirs)
                        {
                            string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                            if (foldername.ToLower() == "#cryofallscriptgen")
                            {
                                List<string> dirsmod = new List<string>(Directory.EnumerateDirectories(pathToDesktop + @"\" + foldername + @"\" + "original"));

                                foreach (var thefolder in dirsmod)
                                {
                                    string thefoldernameinsideofcryofall = $"{thefolder.Substring(thefolder.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                                    thefoldernameinsideofcryofall = thefoldernameinsideofcryofall.Substring(0, thefoldernameinsideofcryofall.Length - 4);
                                    //sccsr16.Program.MessageBox((IntPtr)0, "foldername:" + thefoldernameinsideofcryofall, "sccsmsg", 0);
                                    string themodtogetmobsfrom = "Mobs";

                                    //string themodfoldernamewithoutextension = themodfoldername.Substring(0, themodfoldername.Length - 4);

                                    ////Console.WriteLine(themodfoldernamewithoutextension);

                                    string finalPathheader = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk"; // + @"\" + "images"
                                    var arrayoforiginalheader = Directory.GetFiles(finalPathheader);

                                    ////Console.WriteLine(arrayoforiginalweapon[i]);
                                    string finalPathanims1 = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk"; // + @"\" + "images"
                                    string finalPathanims2 = prefinalpathtofilesmultiplied + @"\" + thefoldernameinsideofcryofall + ".mpk"; // + @"\" + "images"

                                    if (!Directory.Exists(finalPathanims2))
                                    {
                                        Directory.CreateDirectory(finalPathanims2); // + @"\" + "Zones"
                                    }

                                    for (int i = 0; i < arrayoforiginalheader.Length; i++)
                                    {
                                        ////Console.WriteLine(finalPathanims1);
                                        ////Console.WriteLine(arrayoforiginalweapon[i]);

                                        string finalfilename = arrayoforiginalheader[i].Substring(finalPathanims1.Length, (arrayoforiginalheader[i].Length - (finalPathanims1.Length)));
                                        ////Console.WriteLine(finalfilename);
                                        File.Copy(arrayoforiginalheader[i], finalPathanims2 + @"\" + finalfilename, true);
                                    }


                                    if (thefoldernameinsideofcryofall.ToLower() == "sccspathfind")
                                    {

                                        Stopwatch thetimer = new Stopwatch();
                                        thetimer.Start();

                                        //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                                        //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                                        var dirinfo0 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
                                        string pathtomodsinprojectfolder = dirinfo0.FullName + @"\" + "#Cryofallscriptgen";


                                        //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files

                                        //var currentdirinfo = Directory.GetCurrentDirectory();

                                        //var theprocess = Process.GetCurrentProcess();

                                        //Console.WriteLine(Environment.CurrentDirectory);// theprocess.ProcessName);// theprocess.StartInfo.FileName);//currentdirinfo);

                                        string docPath = pathtomodsinprojectfolder;//Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied" //Environment.SpecialFolder.Desktop);// 
                                                                                   //List<string> dirs0 = new List<string>(Directory.EnumerateDirectories(docPath));
                                        sccsr16.Form1.itsalmostastack<string> dirs1last = new sccsr16.Form1.itsalmostastack<string>();

                                        string pathtomods = "";

                                        int counttheproblem = 0;

                                        int mainninesmodsfoldercounter1 = 0;

                                        //foreach (var dir in dirs)
                                        {
                                            //DirectoryInfo directoryFolder0 = new DirectoryInfo(dir);
                                            //directoryFolder0.Refresh();

                                            string foldername0 = "original";// $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //multiplied

                                            //if (foldername.ToLower() == "multiplied")
                                            {
                                                //pathtomods = docPath + @"\" + foldername;
                                                pathtomods = docPath + @"\" + foldername0;

                                                // @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods" + @"\" 

                                                //Console.WriteLine(docPath);// Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                                                //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                                                pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + "multiplied";// Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "AtomicTorchStudio" + @"\" + "CryoFall" + @"\" + "Mods"; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;

                                                //Console.WriteLine(pathtomodsinprojectfolder);// 

                                                dirs1last.Push(pathtomods);

                                                int counter = 0;

                                                int endthread00 = 0;
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
                                                    sccsr16.Form1.itsalmostastack<string> listoffiles = new sccsr16.Form1.itsalmostastack<string>();
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

                                                _thread_main_loop1:

                                                    for (int fi = 0; fi < 3; fi++) //dirs1last.Count //1 //9  //dirs1last.Count //dirs1last.Count
                                                    {
                                                        if (endthread0 == 0)
                                                        {
                                                            if (endthread00 == 0)
                                                            {




                                                                if (dirs1last.Count <= 0)
                                                                {
                                                                    sccsr16.Program.MessageBox((IntPtr)0, "The dirs1last is empty", "sccsmsg", 0);
                                                                }

                                                                if (dirs1last.Count > 0)
                                                                {
                                                                    if (folderiteratormain >= dirs1last.Count && folderiteratormain > 1)
                                                                    {
                                                                        sccsr16.Program.MessageBox((IntPtr)0, "reached end of dirs1last", "sccsmsg", 0);

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
                                                                                                File.Copy(poppedstring, thecopiedfilepath);
                                                                                                //File.Move(poppedstring, thecopiedfilepath);
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
                                                                    endthread00 = 1;
                                                                    folderiteratormain = 0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                endthread00 = 1;
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }

                                                    if (endthread00 == 0 && endthread0 == 0)
                                                    {
                                                        Thread.Sleep(1);
                                                        mainninesmodsfoldercounter1++;

                                                        goto _thread_main_loop1;
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
                                                        //Console.WriteLine("finished copying sccspathfind.mpk." + thetimer.Elapsed.TotalSeconds);
                                                        //sccsr16.Program.MessageBox((IntPtr)0, "end of move files.", "sccsmsg", 0);
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
                                    else if (thefoldernameinsideofcryofall.ToLower().Contains("skeleton!"))
                                    {






                                        /*float mobheight = 1.65f;
                                        double mobhp = 99;
                                        double mobspeed = 2.0;
                                        string mobname = "Skeleton";*/

                                        //string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";

                                        string pathtoanimationpngs = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Content\\Animations\\" + thefoldernameinsideofcryofall + "\\images"; //back/male and /front/male
                                        string pathtoscripts = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Scripts";
                                        string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Scripts";









                                        /*
                                        var arrayoforiginalscriptfilesCHARACTERSKELETON = Directory.GetFiles(pathtoscripts + @"\" + "CharacterSkeletons");

                                        //var arrayoforiginalscriptfilesCHARACTERSKELETON = Directory.GetFiles(finalpathmobskeletonscriptori);

                                        //MODIFY THE MOB CHARACTER SKELETON SCRIPT
                                        for (int i = 0; i < arrayoforiginalscriptfilesCHARACTERSKELETON.Length; i++)
                                        {
                                            string prefinalfilename = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscriptori.Length, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - finalpathmobskeletonscriptori.Length - 3));

                                            //string prefinalfilename = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscript.Length-2, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - 1 - finalpathmobskeletonscript.Length));
                                            string thefinalfilename = prefinalfilename + "Variant" + variantindex;

                                            ////Console.WriteLine(prefinalfilename);

                                            string filenamewithext = finalpathmobskeletonscript + (thefinalfilename) + ".cs";

                                            //////Console.WriteLine(finalfilename);
                                            File.Copy(arrayoforiginalscriptfilesCHARACTERSKELETON[i], filenamewithext, true);

                                            DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobskeletonscript);
                                            directoryFolder0.Refresh();

                                            //string scriptname = "MobSkeleton";
                                            string scriptcharacterskeletonstring = "Skeleton" + mobname;
                                            string scriptnamevariant = "Variant" + variantindex;

                                            string scriptcharacterskeletonpngpath = mobname + "/";
                                            string scriptcharacterskeletonpngpathreplacement = mobname;

                                            //string prefinalfilenamecorrect = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                                            File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).Replace(scriptcharacterskeletonpngpath, scriptcharacterskeletonpngpathreplacement + scriptnamevariant + "/"));
                                        }
                                        //MODIFY THE MOB CHARACTER SKELETON SCRIPT
                                        */









                                        for (int i = 0; i < numberofvariants; i++)
                                        {

                                            if (endthread0 == 0)
                                            {

                                                float rand;
                                                float randr;
                                                float randb;
                                                float randg;

                                                getrandvalues(out rand, out randr, out randb, out randg);



                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("start creating Content/ variants " + i + " color for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }

                                                createvariantpngsnew(i, pathtoanimationpngs, thefoldernameinsideofcryofall, 0, "", 0, rand, randr, randg, randb);


                                                createvariantpngsnew(i, pathtoanimationpngs, thefoldernameinsideofcryofall, 0, "", 1, rand, randr, randg, randb);

                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("end creating Content/ variants " + i + " color for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }

                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }

                                                createvariantscripts(i, thefoldernameinsideofcryofall, pathtoscripts, pathtoscriptsmul, thefoldernameinsideofcryofall, 0);

                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }
                                            }
                                            else
                                            {
                                                //endthread0 = 1;
                                                break;
                                            }

                                        }
                                    }
                                    else if (thefoldernameinsideofcryofall.ToLower().Contains("zombie!"))
                                    {

                                        /*
                                        float mobheight = 1.65f;
                                        double mobhp = 200;
                                        double mobspeed = 1.5;
                                        string mobname = "Zombie";
                                        */

                                        //string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";

                                        string pathtoanimationpngs = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Content\\Animations\\" + thefoldernameinsideofcryofall + "\\images"; //back/male and /front/male
                                        string pathtoscripts = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Scripts";
                                        string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Scripts";

                                        for (int i = 0; i < numberofvariants; i++)
                                        {



                                            if (endthread0 == 0)
                                            {

                                                float rand;
                                                float randr;
                                                float randb;
                                                float randg;

                                                getrandvalues(out rand, out randr, out randb, out randg);




                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("start creating Content/ variants " + i + " color for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }

                                                createvariantpngsnew(i, pathtoanimationpngs, thefoldernameinsideofcryofall, 0, "", 0, rand, randr, randg, randb);
                                                createvariantpngsnew(i, pathtoanimationpngs, thefoldernameinsideofcryofall, 0, "", 1, rand, randr, randg, randb);


                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("end creating Content/ variants " + i + " color for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }

                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }
                                                createvariantscripts(i, thefoldernameinsideofcryofall, pathtoscripts, pathtoscriptsmul, thefoldernameinsideofcryofall, 0);

                                                if (debugtoconsole == 1)
                                                {
                                                    Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + thefoldernameinsideofcryofall.ToLower() + ".");
                                                }
                                            }
                                            else
                                            {
                                                //endthread0 = 1;
                                                break;
                                            }
                                        }
                                    }
                                    else if (thefoldernameinsideofcryofall.ToLower() == "zones")
                                    {
                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("start creating Zones scripts for the mobs where all mobs variants and original will be spawned within a Cryofall game.");
                                        }

                                        string zonearctic = @"\" + "Zones" + @"\" + "Arctic";
                                        string zoneboreal = @"\" + "Zones" + @"\" + "Boreal";
                                        string zonegeneric = @"\" + "Zones" + @"\" + "Generic";
                                        string zonemobs = @"\" + "Zones" + @"\" + "Mobs";
                                        string zoneruins = @"\" + "Zones" + @"\" + "Ruins";
                                        string zonespecial = @"\" + "Zones" + @"\" + "Special";
                                        string zonetemperate = @"\" + "Zones" + @"\" + "Temperate";
                                        string zonetropical = @"\" + "Zones" + @"\" + "Tropical";

                                        string[] arrayofzones = new string[8];

                                        arrayofzones[0] = zonearctic;
                                        arrayofzones[1] = zoneboreal;
                                        arrayofzones[2] = zonegeneric;
                                        arrayofzones[3] = zonemobs;
                                        arrayofzones[4] = zoneruins;
                                        arrayofzones[5] = zonespecial;
                                        arrayofzones[6] = zonetemperate;
                                        arrayofzones[7] = zonetropical;

                                        int chosenindex = 0;

                                        string currentfolderzone = arrayofzones[chosenindex];

                                        //string pathtozones = "C:\\Users\\steve\\Desktop\\#Cryofallscriptgen\\original" + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + @"\" + "Zones" + @"\" + "Zones";

                                        string pathtozones = prefinalpathtofiles + @"\" + thefoldernameinsideofcryofall + ".mpk" + "\\Scripts" + @"\" + "Zones" + @"\" + "Zones";




                                        for (int i = 0; i < arrayofzones.Length; i++)
                                        {
                                            int indexofzone = i;

                                            zonearctic = "Arctic";
                                            zoneboreal = "Boreal";
                                            zonegeneric = "Generic";
                                            zonemobs = "Mobs";
                                            zoneruins = "Ruins";
                                            zonespecial = "Special";
                                            zonetemperate = "Temperate";
                                            zonetropical = "Tropical";

                                            string chosenzonefolder = "";

                                            if (indexofzone == 0)
                                            {
                                                chosenzonefolder = zonearctic;
                                            }
                                            else if (indexofzone == 1)
                                            {
                                                chosenzonefolder = zoneboreal;
                                            }
                                            else if (indexofzone == 2)
                                            {
                                                chosenzonefolder = zonegeneric;
                                            }
                                            else if (indexofzone == 3)
                                            {
                                                chosenzonefolder = zonemobs;
                                            }
                                            else if (indexofzone == 4)
                                            {
                                                chosenzonefolder = zoneruins;
                                            }
                                            else if (indexofzone == 5)
                                            {
                                                chosenzonefolder = zonespecial;
                                            }
                                            else if (indexofzone == 6)
                                            {
                                                chosenzonefolder = zonetemperate;
                                            }
                                            else if (indexofzone == 7)
                                            {
                                                chosenzonefolder = zonetropical;
                                            }

                                            string pathtozonescripts = pathtozones + @"\" + chosenzonefolder;


                                            //Console.WriteLine(arrayofthezonescripts.Length);

                                            string pathoriginal = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder;

                                            pathoriginal += @"\" + "original" + @"\";

                                            int lengthofpath0 = pathoriginal.Length;
                                            //string thepathtoremove = @"\" + "original" + "Zones" + @"\" + "Arctic";
                                            string strtoreplace = "//9SMODS" + @"\" + @"\";
                                            double densitymul = 0.09; // 0.03 // 0.09
                                            string densitymultiplier = densitymul + "";

                                            ////Console.WriteLine(arrayoforiginalpngfilesfront.Length);

                                            pathoriginal += @"\" + "original" + @"\";

                                            //string thepathtoremove = @"\" + "original" + "Zones" + @"\" + "Arctic";

                                            //GETTING THE SCRIPTS IN THE SPECIFIC FOLDER REGION.
                                            var arrayofthezonescripts = Directory.GetFiles(pathtozonescripts);
                                            for (int v = 0; v < arrayofthezonescripts.Length; v++)
                                            {

                                                if (endthread0 == 0)
                                                {


                                                    var substring = arrayofthezonescripts[v].Substring(lengthofpath0, arrayofthezonescripts[v].Length - lengthofpath0);

                                                    string pathtozonescripts1 = "Zones" + ".mpk" + @"\" + "Scripts" + @"\" + "Zones" + @"\" + "Zones" + @"\";

                                                    var substring1 = substring.Substring(pathtozonescripts1.Length + chosenzonefolder.Length + 1, substring.Length - pathtozonescripts1.Length - (chosenzonefolder.Length + 1));

                                                    string multipliedfilepath = prefinalpathtofilesmultiplied + @"\" + pathtozonescripts1 + @"\" + chosenzonefolder;
                                                    if (!Directory.Exists(multipliedfilepath))
                                                    {
                                                        Directory.CreateDirectory(multipliedfilepath);
                                                    }


                                                    //Console.WriteLine("substring1:" + substring1);


                                                    //string thepathtofilewithext = prefinalpathtofilesmultiplied + @"\" + pathtozonescripts1 + @"\" + substring1;

                                                    //string thepathtofilewithext = multipliedfilepath +  substring1;

                                                    string thepathtofilewithext = multipliedfilepath = prefinalpathtofilesmultiplied + @"\" + pathtozonescripts1 + @"\" + chosenzonefolder + @"\" + substring1;




                                                    //Console.WriteLine(thepathtofilewithext);

                                                    if (!File.Exists(thepathtofilewithext))
                                                    {
                                                        /*File.Copy(arrayofthezonescripts[v], multipliedfilepath + @"\" + substring1, true);
                                                        DirectoryInfo directoryFolder0 = new DirectoryInfo(multipliedfilepath + @"\" + substring1);
                                                        directoryFolder0.Refresh();*/




                                                        File.Copy(arrayofthezonescripts[v], thepathtofilewithext, true);


                                                        DirectoryInfo directoryFolder0 = new DirectoryInfo(thepathtofilewithext);
                                                        directoryFolder0.Refresh();
                                                    }




                                                    //Console.WriteLine("test");



                                                    if (substring1.ToLower() == "zonearcticcoastlake.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {


                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {

                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {

                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }




                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonearcticcoastocean.cs")
                                                    {
                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonearcticforest.cs")
                                                    {


                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "bearpolar" ||
                                                                              removetheextensionfrommobname.ToLower() == "broodnest" ||
                                                                              removetheextensionfrommobname.ToLower() == "wolfpolar" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "bearpolar" ||
                                                                              themodtogetmobsfrom.ToLower() == "broodnest" ||
                                                                              themodtogetmobsfrom.ToLower() == "wolfpolar" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "bearpolar" ||
                                                                              themodtogetmobsfrom.ToLower() == "broodnest" ||
                                                                              themodtogetmobsfrom.ToLower() == "wolfpolar" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneborealcoastlake.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "crab" ||
                                                                              removetheextensionfrommobname.ToLower() == "riversnail" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                              themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                              themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneborealcoastocean.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "crab" ||
                                                                              removetheextensionfrommobname.ToLower() == "riversnail" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                              themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                              themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneborealforest.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "bear" ||
                                                                              removetheextensionfrommobname.ToLower() == "mutantboar" ||
                                                                              removetheextensionfrommobname.ToLower() == "mutantwolf" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "snakeblue" ||
                                                                               removetheextensionfrommobname.ToLower() == "wildboar" ||
                                                                               removetheextensionfrommobname.ToLower() == "wolf" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "bear" ||
                                                                              themodtogetmobsfrom.ToLower() == "mutantboar" ||
                                                                              themodtogetmobsfrom.ToLower() == "mutantwolf" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower() == "snakeblue" ||
                                                                               themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                               themodtogetmobsfrom.ToLower() == "wolf" ||
                                                                               themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "bear" ||
                                                                             themodtogetmobsfrom.ToLower() == "mutantboar" ||
                                                                             themodtogetmobsfrom.ToLower() == "mutantwolf" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakeblue" ||
                                                                              themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                              themodtogetmobsfrom.ToLower() == "wolf" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneborealmountain.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "cloakedlizard" ||
                                                                              removetheextensionfrommobname.ToLower() == "crawler" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                              themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                               themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                             themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonegeneridpragmiumwasteland.cs")
                                                    {
                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonegenericroads.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonegenericvolcanic.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonemobspsigrove.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie") ||
                                                                            removetheextensionfrommobname.ToLower() == "psigrove")
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie") ||
                                                                            themodtogetmobsfrom.ToLower() == "psigrove")
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie") ||
                                                                            themodtogetmobsfrom.ToLower() == "psigrove")
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonemobsscorpion.cs")
                                                    {
                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie") ||
                                                                            removetheextensionfrommobname.ToLower() == "scorpion")
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie") ||
                                                                            themodtogetmobsfrom.ToLower() == "scorpion")
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie") ||
                                                                            themodtogetmobsfrom.ToLower() == "scorpion")
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonemobsspitter.cs")
                                                    {
                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie") ||
                                                                            removetheextensionfrommobname.ToLower() == "spitter")
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie") ||
                                                                            themodtogetmobsfrom.ToLower() == "spitter")
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie") ||
                                                                            themodtogetmobsfrom.ToLower() == "spitter")
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneruinslootindustrial.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneruinslootlaboratory.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneruinsmilitary.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneruinsresidential.cs")
                                                    {
                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneruinsmobsnormal.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zoneeventboss.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonespecialconstructionrestricted.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonespecialplayerspawn.cs")
                                                    {

                                                    }
                                                    else if (substring1.ToLower() == "zonespecialradiationtier1.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonespecialradiationtier2.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonespecialradiationtier3.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                            removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                      themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperatebarren.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "cloakedlizard" ||
                                                                              removetheextensionfrommobname.ToLower() == "honeybadger" ||
                                                                              removetheextensionfrommobname.ToLower() == "hyena" ||
                                                                              removetheextensionfrommobname.ToLower() == "mutanthyena" ||
                                                                              removetheextensionfrommobname.ToLower() == "pangolin" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "snakebrown" ||
                                                                              removetheextensionfrommobname.ToLower() == "thumper" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                             themodtogetmobsfrom.ToLower() == "honeybadger" ||
                                                                             themodtogetmobsfrom.ToLower() == "hyena" ||
                                                                             themodtogetmobsfrom.ToLower() == "mutanthyena" ||
                                                                             themodtogetmobsfrom.ToLower() == "pangolin" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakebrown" ||
                                                                             themodtogetmobsfrom.ToLower() == "thumper" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                            themodtogetmobsfrom.ToLower() == "honeybadger" ||
                                                                            themodtogetmobsfrom.ToLower() == "hyena" ||
                                                                            themodtogetmobsfrom.ToLower() == "mutanthyena" ||
                                                                            themodtogetmobsfrom.ToLower() == "pangolin" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower() == "snakebrown" ||
                                                                            themodtogetmobsfrom.ToLower() == "thumper" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperateclay.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "cloakedlizard" ||
                                                                              removetheextensionfrommobname.ToLower() == "crawler" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                            themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                            themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperatecoastlake.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "crab" ||
                                                                              removetheextensionfrommobname.ToLower() == "riversnail" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                               removetheextensionfrommobname.ToLower() == "turtle" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                              themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                               themodtogetmobsfrom.ToLower() == "turtle" ||
                                                                               themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                             themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                              themodtogetmobsfrom.ToLower() == "turtle" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperatecoastocean.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "crab" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "starfish" ||
                                                                               removetheextensionfrommobname.ToLower() == "turtle" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                           themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                           themodtogetmobsfrom.ToLower() == "starfish" ||
                                                                            themodtogetmobsfrom.ToLower() == "turtle" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crab" ||
                                                                          themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                          themodtogetmobsfrom.ToLower() == "starfish" ||
                                                                           themodtogetmobsfrom.ToLower() == "turtle" ||
                                                                           themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperateforest.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "chicken" ||
                                                                              removetheextensionfrommobname.ToLower() == "mutantboar" ||
                                                                              removetheextensionfrommobname.ToLower() == "mutantwolf" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "snakegreen" ||
                                                                               removetheextensionfrommobname.ToLower() == "wildboar" ||
                                                                               removetheextensionfrommobname.ToLower() == "wolf" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "chicken" ||
                                                                            themodtogetmobsfrom.ToLower() == "mutantboar" ||
                                                                            themodtogetmobsfrom.ToLower() == "mutantwolf" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                             themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                             themodtogetmobsfrom.ToLower() == "wolf" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "chicken" ||
                                                                            themodtogetmobsfrom.ToLower() == "mutantboar" ||
                                                                            themodtogetmobsfrom.ToLower() == "mutantwolf" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                             themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                             themodtogetmobsfrom.ToLower() == "wolf" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperatemeadow.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "chicken" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "snakegreen" ||
                                                                               removetheextensionfrommobname.ToLower() == "wildboar" ||
                                                                               removetheextensionfrommobname.ToLower() == "wolf" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "chicken" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                              themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                              themodtogetmobsfrom.ToLower() == "wolf" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "chicken" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                              themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                              themodtogetmobsfrom.ToLower() == "wolf" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperatemountain.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "cloakedlizard" ||
                                                                              removetheextensionfrommobname.ToLower() == "crawler" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                           themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                           themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                           themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                           themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperatesalt.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "cloakedlizard" ||
                                                                              removetheextensionfrommobname.ToLower() == "crawler" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                           themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                           themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "cloakedlizard" ||
                                                                           themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                           themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetemperateswamp.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "blackbeetle" ||
                                                                              removetheextensionfrommobname.ToLower() == "burrower" ||
                                                                              removetheextensionfrommobname.ToLower() == "riversnail" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "snakegreen" ||
                                                                               removetheextensionfrommobname.ToLower() == "wildboar" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "blackbeetle" ||
                                                                             themodtogetmobsfrom.ToLower() == "burrower" ||
                                                                             themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                              themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "blackbeetle" ||
                                                                             themodtogetmobsfrom.ToLower() == "burrower" ||
                                                                             themodtogetmobsfrom.ToLower() == "riversnail" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                              themodtogetmobsfrom.ToLower() == "wildboar" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetropicalforest.cs")
                                                    {

                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "chicken" ||
                                                                              removetheextensionfrommobname.ToLower() == "pangolin" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                              removetheextensionfrommobname.ToLower() == "snakegreen" ||
                                                                               removetheextensionfrommobname.ToLower() == "tropicalboar" ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "chicken" ||
                                                                            themodtogetmobsfrom.ToLower() == "pangolin" ||
                                                                            themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                            themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                             themodtogetmobsfrom.ToLower() == "tropicalboar" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {

                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "chicken" ||
                                                                             themodtogetmobsfrom.ToLower() == "pangolin" ||
                                                                             themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                             themodtogetmobsfrom.ToLower() == "snakegreen" ||
                                                                              themodtogetmobsfrom.ToLower() == "tropicalboar" ||
                                                                              themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {

                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (substring1.ToLower() == "zonetropicalmountain.cs")
                                                    {
                                                        for (int mpki = 0; mpki < 3; mpki++)
                                                        {
                                                            if (mpki == 0)
                                                            {
                                                                themodtogetmobsfrom = "Mobs";// "Skeleton";

                                                                string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                                                var arrayofthecharacterskeletonfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                                                //Console.WriteLine(arrayofthescriptfiles.Length);

                                                                string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                                int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                                                //GETTING THE NAME OF THE ORIGINAL MOBS AND WILL TRY AND INSERT IN EACH SCRIPTS, MOB PER MOB, THEIR SPAWN SCRIPT LINE.
                                                                for (int f = 0; f < arrayofthecharacterskeletonfiles.Length; f++)
                                                                {
                                                                    ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                                    string thefilemobname = arrayofthecharacterskeletonfiles[f].Substring(lengthofstringtoremove, (arrayofthecharacterskeletonfiles[f].Length) - lengthofstringtoremove);
                                                                    // Console.WriteLine(thefilemobname);
                                                                    string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                                    //Console.WriteLine(removetheextensionfrommobname);

                                                                    string skeletonfolderremoveskeletonfromscriptname = "skeleton";
                                                                    removetheextensionfrommobname = removetheextensionfrommobname.Substring(skeletonfolderremoveskeletonfromscriptname.Length, removetheextensionfrommobname.Length - skeletonfolderremoveskeletonfromscriptname.Length);





                                                                    if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                      removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                      removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                      removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                      removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                      removetheextensionfrommobname.ToLower() == "floater" ||
                                                                        removetheextensionfrommobname.ToLower() == "thumper")
                                                                    {
                                                                        //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                        continue;
                                                                    }
                                                                    else
                                                                    {

                                                                        if (removetheextensionfrommobname.ToLower() == "crawler" ||
                                                                              removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                               removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                                        {
                                                                            for (int varianti = 0; varianti < 1; varianti++)//9
                                                                            {
                                                                                File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + removetheextensionfrommobname + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                                   ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                            }
                                                                        }



                                                                    }

                                                                }
                                                            }
                                                            else if (mpki == 1)
                                                            {
                                                                themodtogetmobsfrom = "Skeleton";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                        themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {

                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (mpki == 2)
                                                            {
                                                                themodtogetmobsfrom = "Zombie";// "Skeleton";



                                                                if (themodtogetmobsfrom.ToLower() == "pragmiumqueen" ||
                                                                   themodtogetmobsfrom.ToLower() == "sandtyrant" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetle" ||
                                                                   themodtogetmobsfrom.ToLower() == "pragmiumbeetleminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumperminion" ||
                                                                   themodtogetmobsfrom.ToLower() == "broodguardian" ||
                                                                   themodtogetmobsfrom.ToLower() == "brooddrone" ||
                                                                   themodtogetmobsfrom.ToLower() == "floater" ||
                                                                   themodtogetmobsfrom.ToLower() == "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + themodtogetmobsfrom1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    if (themodtogetmobsfrom.ToLower() == "crawler" ||
                                                                        themodtogetmobsfrom.ToLower().Contains("skeleton") ||
                                                                        themodtogetmobsfrom.ToLower().Contains("zombie"))
                                                                    {
                                                                        for (int varianti = 0; varianti < 1; varianti++)//9
                                                                        {
                                                                            File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\n" + "\t" + "\t" + "\t" + @"/" + @"/" + themodtogetmobsfrom + "\n" + "\t" + "\t" + "\t" + "scripts" +
                                                                               ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                               "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                              "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }

                                                    }


                                                }
                                                else
                                                {
                                                    //endthread0 = 1;
                                                    break;
                                                }
                                            }


                                        }


                                    }
                                    else if (thefoldernameinsideofcryofall.ToLower() == "mobs")
                                    {


                                        string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                        var arrayofthescriptfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                        //Console.WriteLine(arrayofthescriptfiles.Length);

                                        string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                        int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;

                                        for (int f = 0; f < arrayofthescriptfiles.Length; f++)
                                        {



                                            if (endthread0 == 0)
                                            {

                                                ///Console.WriteLine(arrayofthescriptfiles[f]);

                                                string thefilemobname = arrayofthescriptfiles[f].Substring(lengthofstringtoremove, (arrayofthescriptfiles[f].Length) - lengthofstringtoremove);
                                                // Console.WriteLine(thefilemobname);
                                                string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);

                                                //Console.WriteLine(removetheextensionfrommobname);

                                                string theskeletonstr = "skeleton";

                                                removetheextensionfrommobname = removetheextensionfrommobname.Substring(theskeletonstr.Length, removetheextensionfrommobname.Length - theskeletonstr.Length);
                                                //Console.WriteLine(removetheextensionfrommobname);

                                                //removetheextensionfrommobname = removetheextensionfrommobname.Substring(0, "skeleton".Length);

                                                if (removetheextensionfrommobname == "BossPragmiumQueen")
                                                {
                                                    removetheextensionfrommobname = "PragmiumQueen";
                                                }

                                                if (removetheextensionfrommobname == "BossSandTyrant")
                                                {
                                                    removetheextensionfrommobname = "SandTyrant";
                                                }

                                                //if (removetheextensionfrommobname.ToLower() == "bear" ||
                                                //    removetheextensionfrommobname.ToLower() == "bearpolar")
                                                {
                                                    //FOR MAKING FOLDERS FOR SCRIPT FILES TO BE COPIED
                                                    string pathtocharactermobsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";
                                                    string pathtocharacterskeletonsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";
                                                    string pathtoitemsweaponsmobweaponsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\Items" + "\\Weapons" + "\\MobWeapons";
                                                    string pathtozonesscriptmobsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";
                                                    //FOR MAKING FOLDERS FOR SCRIPT FILES TO BE COPIED

                                                    //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED
                                                    string pathtoPNGSmobsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images";
                                                    string pathtoPNGSmobsbackmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Back";
                                                    string pathtoPNGSmobsfrontmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Front";
                                                    string pathtoPNGSmobsAnimationmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname;
                                                    //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED

                                                    Directory.CreateDirectory(pathtocharactermobsmul);
                                                    Directory.CreateDirectory(pathtocharacterskeletonsmul);
                                                    Directory.CreateDirectory(pathtoitemsweaponsmobweaponsmul);
                                                    Directory.CreateDirectory(pathtozonesscriptmobsmul);
                                                    Directory.CreateDirectory(pathtoPNGSmobsmul);
                                                    Directory.CreateDirectory(pathtoPNGSmobsbackmul);
                                                    Directory.CreateDirectory(pathtoPNGSmobsfrontmul);

                                                    string pathtocharactermobs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";
                                                    string pathtocharacterskeletons = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";
                                                    string pathtoitemsweaponsmobweapons = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\Items" + "\\Weapons" + "\\MobWeapons";
                                                    string pathtozonesscriptmobs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";
                                                    //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED

                                                    string pathtoPNGSmobs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images";
                                                    string pathtoPNGSmobsback = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Back";
                                                    string pathtoPNGSmobsfront = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Front";
                                                    string pathtoPNGSmobsAnimation = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\";

                                                    //Console.WriteLine(pathtoPNGSmobs);

                                                    var arrayoffiles0 = Directory.GetFiles(pathtocharactermobs);
                                                    var arrayoffiles1 = Directory.GetFiles(pathtocharacterskeletons);
                                                    var arrayoffiles2 = Directory.GetFiles(pathtoitemsweaponsmobweapons);
                                                    var arrayoffiles3 = Directory.GetFiles(pathtozonesscriptmobs);

                                                    string[] arrayoffiles4 = null;
                                                    string[] arrayoffiles5 = null;
                                                    string[] arrayoffiles6 = null;

                                                    var arrayoffiles7 = Directory.GetFiles(pathtoPNGSmobsAnimation);

                                                    //PNGS
                                                    //string removetheextensionfrommobname = themodfoldername.Substring(0, themodfoldername.Length - 4);




                                                    //if (removetheextensionfrommobname.ToLower().Contains("skeleton"))
                                                    {
                                                        //float mobheight = 1.65f;
                                                        // double mobhp = 99;
                                                        //double mobspeed = 2.0;
                                                        //string mobname = "Skeleton";

                                                        //string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";


                                                        string themobsfolder = "Mobs";

                                                        string pathtoanimationpngs = prefinalpathtofiles + @"\" + themobsfolder + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
                                                        string pathtoscripts = prefinalpathtofiles + @"\" + themobsfolder + ".mpk" + "\\Scripts";
                                                        string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themobsfolder + ".mpk" + "\\Scripts";

                                                        for (int i = 0; i < numberofvariants; i++)
                                                        {
                                                            if (endthread0 != 0)
                                                            {
                                                                break;
                                                            }
                                                            float rand;
                                                            float randr;
                                                            float randb;
                                                            float randg;

                                                            getrandvalues(out rand, out randr, out randb, out randg);

                                                            if (removetheextensionfrommobname.ToLower().Contains("bear") ||
                                                                removetheextensionfrommobname.ToLower().Contains("bearpolar") ||
                                                                removetheextensionfrommobname.ToLower().Contains("blackbeetle") ||
                                                                removetheextensionfrommobname.ToLower().Contains("brooddrone") ||
                                                                removetheextensionfrommobname.ToLower().Contains("broodguardian") ||
                                                                //removetheextensionfrommobname.ToLower()("broodnest") ||
                                                                removetheextensionfrommobname.ToLower().Contains("burrower") ||
                                                                removetheextensionfrommobname.ToLower().Contains("chicken") ||
                                                                removetheextensionfrommobname.ToLower().Contains("cloakedlizard") ||
                                                                //removetheextensionfrommobname.ToLower()("crab") ||
                                                                removetheextensionfrommobname.ToLower().Contains("crawler") ||
                                                                removetheextensionfrommobname.ToLower().Contains("firelizard") ||
                                                                //removetheextensionfrommobname.ToLower()("floater") ||
                                                                removetheextensionfrommobname.ToLower().Contains("honeybadger") ||
                                                                removetheextensionfrommobname.ToLower().Contains("hyena") ||
                                                                removetheextensionfrommobname.ToLower().Contains("mutantboar") ||
                                                                removetheextensionfrommobname.ToLower().Contains("mutanthyena") ||
                                                                removetheextensionfrommobname.ToLower().Contains("mutantwolf") ||
                                                                removetheextensionfrommobname.ToLower().Contains("pangolin") ||
                                                                removetheextensionfrommobname.ToLower().Contains("pragmiumbeetle") ||
                                                                removetheextensionfrommobname.ToLower().Contains("pragmiumqueen") ||
                                                                //removetheextensionfrommobname.ToLower()("psigrove") ||
                                                                removetheextensionfrommobname.ToLower().Contains("riversnail") ||
                                                                removetheextensionfrommobname.ToLower().Contains("sandtyrant") ||
                                                                removetheextensionfrommobname.ToLower().Contains("scorpion") ||
                                                                removetheextensionfrommobname.ToLower().Contains("skeleton") ||
                                                                removetheextensionfrommobname.ToLower().Contains("snakeblue") ||
                                                                removetheextensionfrommobname.ToLower().Contains("snakebrown") ||
                                                                removetheextensionfrommobname.ToLower().Contains("snakegreen") ||
                                                                //removetheextensionfrommobname.ToLower()("spitter") ||
                                                                //removetheextensionfrommobname.ToLower()("starfish") ||
                                                                //removetheextensionfrommobname.ToLower()("thumper") || <============================================ISSUES TO FIX
                                                                removetheextensionfrommobname.ToLower().Contains("tropicalboar") ||
                                                                removetheextensionfrommobname.ToLower().Contains("turtle") ||
                                                                removetheextensionfrommobname.ToLower().Contains("wildboar") ||
                                                                removetheextensionfrommobname.ToLower().Contains("wolf") ||
                                                                removetheextensionfrommobname.ToLower().Contains("wolfpolar") ||
                                                                removetheextensionfrommobname.ToLower().Contains("zombie"))
                                                            {
                                                                createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0, rand, randr, randg, randb);
                                                                createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 1, rand, randr, randg, randb);

                                                            }
                                                            else if (removetheextensionfrommobname.ToLower().Contains("broodnest") ||
                                                                removetheextensionfrommobname.ToLower().Contains("floater"))
                                                            {
                                                                createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 2, rand, randr, randg, randb);
                                                            }
                                                            else if (removetheextensionfrommobname.ToLower().Contains("spitter") ||
                                                                    removetheextensionfrommobname.ToLower().Contains("crab") ||
                                                                    removetheextensionfrommobname.ToLower().Contains("psigrove") ||
                                                                    removetheextensionfrommobname.ToLower().Contains("starfish"))
                                                            {
                                                                createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0, rand, randr, randg, randb);
                                                            }





                                                            if (debugtoconsole == 1)
                                                            {
                                                                Console.WriteLine("end creating Content/ variants " + i + " color for the original mob " + removetheextensionfrommobname.ToLower() + ".");
                                                            }
                                                        }
                                                    }
                                                    //PNGS
























                                                    //COPY THE ORIGINAL CHARACTER SCRIPTS.
                                                    for (int fi = 0; fi < arrayoffiles0.Length; fi++)
                                                    {
                                                        if (endthread0 == 0)
                                                        {

                                                            string thefilemobname1 = arrayoffiles0[fi].Substring(pathtocharactermobs.Length + 1, (arrayoffiles0[fi].Length) - pathtocharactermobs.Length - 1);

                                                            string removetheextensionfrommobname1 = thefilemobname1.Substring(0, thefilemobname1.Length - 3);

                                                            string theskeletonstr1 = "mob";
                                                            removetheextensionfrommobname1 = removetheextensionfrommobname1.Substring(theskeletonstr1.Length, removetheextensionfrommobname1.Length - theskeletonstr1.Length);

                                                            string pathtoremovetogetscriptmobname1 = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                            int lengthofstringtoremove1 = pathtoremovetogetscriptmobname1.Length;

                                                            if (removetheextensionfrommobname1 == "BossPragmiumQueen")
                                                            {
                                                                removetheextensionfrommobname1 = "PragmiumQueen";
                                                            }

                                                            if (removetheextensionfrommobname1 == "BossSandTyrant")
                                                            {
                                                                removetheextensionfrommobname1 = "SandTyrant";
                                                            }

                                                            if (removetheextensionfrommobname1.ToLower() == removetheextensionfrommobname.ToLower())
                                                            {
                                                                if (removetheextensionfrommobname1 == "PragmiumQueen" || removetheextensionfrommobname1 == "SandTyrant")
                                                                {
                                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul + @"\" + "Mob" + "Boss" + removetheextensionfrommobname + ".cs", true);
                                                                }
                                                                else
                                                                {
                                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul + @"\" + "Mob" + removetheextensionfrommobname + ".cs", true);
                                                                }


                                                                if (removetheextensionfrommobname.ToLower() != "thumper")
                                                                {
                                                                    string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                    string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                    string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
                                                                    string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
                                                                    string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

                                                                    for (int i = 0; i < numberofvariants; i++)
                                                                    {
                                                                        if (endthread0 != 0)
                                                                        {
                                                                            break;
                                                                        }
                                                                        if (debugtoconsole == 1)
                                                                        {
                                                                            Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character script" + removetheextensionfrommobname.ToLower() + ".");
                                                                        }
                                                                        createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 0);

                                                                        if (debugtoconsole == 1)
                                                                        {
                                                                            Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character script" + removetheextensionfrommobname.ToLower() + ".");
                                                                        }
                                                                    }
                                                                }



                                                            }
                                                        }
                                                        else
                                                        {
                                                            //endthread0 = 1;
                                                            break;
                                                        }
                                                    }










                                                    //for (int fi = 0; fi < arrayoffiles1.Length; fi++)
                                                    {
                                                        //string thefilemobname1 = arrayoffiles1[fi].Substring(pathtocharacterskeletons.Length + 1, (arrayoffiles1[fi].Length) - pathtocharacterskeletons.Length - 1);

                                                        //string removetheextensionfrommobname1 = thefilemobname1.Substring(0, thefilemobname1.Length - 3);

                                                        string theskeletonstr1 = "Skeleton";
                                                        //removetheextensionfrommobname1 = removetheextensionfrommobname1.Substring(theskeletonstr1.Length, removetheextensionfrommobname1.Length - theskeletonstr1.Length);

                                                        string pathtoremovetogetscriptmobname1 = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                        int lengthofstringtoremove1 = pathtoremovetogetscriptmobname1.Length;

                                                        if (removetheextensionfrommobname.ToLower() == removetheextensionfrommobname.ToLower())
                                                        {
                                                            File.Copy(arrayofthescriptfiles[f], pathtocharacterskeletonsmul + @"\" + "Skeleton" + removetheextensionfrommobname + ".cs", true);


                                                        }

                                                        if (removetheextensionfrommobname.ToLower() != "thumper")
                                                        {
                                                            string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                            string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                            string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
                                                            string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
                                                            string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

                                                            for (int i = 0; i < numberofvariants; i++)
                                                            {
                                                                if (endthread0 != 0)
                                                                {
                                                                    break;
                                                                }
                                                                if (debugtoconsole == 1)
                                                                {
                                                                    Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character skeleton script" + removetheextensionfrommobname.ToLower() + ".");
                                                                }
                                                                createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 1);

                                                                if (debugtoconsole == 1)
                                                                {
                                                                    Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character skeleton script" + removetheextensionfrommobname.ToLower() + ".");
                                                                }
                                                            }

                                                        }

                                                    }

















                                                    //mob zone script spawnmobs
                                                    for (int fi = 0; fi < arrayoffiles3.Length; fi++)
                                                    {
                                                        if (endthread0 == 0)
                                                        {

                                                            string thefilemobname1 = arrayoffiles3[fi].Substring(pathtozonesscriptmobs.Length + 1, (arrayoffiles3[fi].Length) - pathtozonesscriptmobs.Length - 1);

                                                            string removetheextensionfrommobname1 = thefilemobname1.Substring(0, thefilemobname1.Length - 3);

                                                            string theskeletonstr1 = "SpawnMobs";
                                                            removetheextensionfrommobname1 = removetheextensionfrommobname1.Substring(theskeletonstr1.Length, removetheextensionfrommobname1.Length - theskeletonstr1.Length);

                                                            string pathtoremovetogetscriptmobname1 = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                            int lengthofstringtoremove1 = pathtoremovetogetscriptmobname1.Length;

                                                            //Console.WriteLine("/0:" + removetheextensionfrommobname + "/1:" + removetheextensionfrommobname1);

                                                            if (removetheextensionfrommobname1 == "BossPragmiumQueen")
                                                            {
                                                                removetheextensionfrommobname1 = "PragmiumQueen";
                                                            }

                                                            if (removetheextensionfrommobname1 == "BossSandTyrant")
                                                            {
                                                                removetheextensionfrommobname1 = "SandTyrant";
                                                            }

                                                            //Console.WriteLine("/0:" + removetheextensionfrommobname + "/1:" + removetheextensionfrommobname1);      


                                                            if (removetheextensionfrommobname1.ToLower() == removetheextensionfrommobname.ToLower())
                                                            {
                                                                if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                                 removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                                 removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                                 removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                                 removetheextensionfrommobname.ToLower() == "thumperminion" ||
                                                                 removetheextensionfrommobname.ToLower() == "broodguardian" ||
                                                                 removetheextensionfrommobname.ToLower() == "brooddrone" ||
                                                                 removetheextensionfrommobname.ToLower() == "floater" &&
                                                                removetheextensionfrommobname.ToLower() != "thumper")
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    //Console.WriteLine("found:" + removetheextensionfrommobname1);

                                                                    File.Copy(arrayoffiles3[fi], pathtozonesscriptmobsmul + @"\" + "Spawn" + "Mobs" + removetheextensionfrommobname + ".cs", true);

                                                                    if (removetheextensionfrommobname.ToLower() != "thumper")
                                                                    {
                                                                        string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                        string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                        string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
                                                                        string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
                                                                        string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

                                                                        for (int i = 0; i < numberofvariants; i++)
                                                                        {
                                                                            if (endthread0 != 0)
                                                                            {
                                                                                break;
                                                                            }

                                                                            if (debugtoconsole == 1)
                                                                            {
                                                                                Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob spawn script" + removetheextensionfrommobname.ToLower() + ".");
                                                                            }
                                                                            createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 2);

                                                                            if (debugtoconsole == 1)
                                                                            {
                                                                                Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob spawn script" + removetheextensionfrommobname.ToLower() + ".");
                                                                            }
                                                                        }
                                                                    }
                                                                    /*
                                                                    //    removetheextensionfrommobname.ToLower() == "floater"
                                                                    //no back no front.
                                                                    if (removetheextensionfrommobname.ToLower() == "floater")
                                                                    {

                                                                    }
                                                                    //front only
                                                                    else if (removetheextensionfrommobname.ToLower() != "spitter" &&
                                                                    removetheextensionfrommobname.ToLower() != "crab" &&
                                                                    removetheextensionfrommobname.ToLower() != "psigrove" &&
                                                                    removetheextensionfrommobname.ToLower() != "starfish")
                                                                    {

                                                                        string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                        string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                        string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
                                                                        string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
                                                                        string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

                                                                        for (int i = 0; i < numberofvariants; i++)
                                                                        {

                                                                            if (debugtoconsole == 1)
                                                                            {
                                                                                Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob spawn script" + removetheextensionfrommobname.ToLower() + ".");
                                                                            }
                                                                            createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 2);

                                                                            if (debugtoconsole == 1)
                                                                            {
                                                                                Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob spawn script" + removetheextensionfrommobname.ToLower() + ".");
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {

                                                                    }*/

                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            //endthread0 = 1;
                                                            break;
                                                        }
                                                    }
                                                    //mob zone script spawnmobs







                                                    /*
                                                    for (int fi = 0; fi < arrayoffiles2.Length; fi++)
                                                    {
                                                        string thefilemobname1 = arrayoffiles2[fi].Substring(pathtoitemsweaponsmobweapons.Length + 1, (arrayoffiles2[fi].Length) - pathtoitemsweaponsmobweapons.Length - 1);

                                                        string removetheextensionfrommobname1 = thefilemobname1.Substring(0, thefilemobname1.Length - 3);

                                                        string theskeletonstr1 = "Skeleton";
                                                        removetheextensionfrommobname1 = removetheextensionfrommobname1.Substring(theskeletonstr1.Length, removetheextensionfrommobname1.Length - theskeletonstr1.Length);

                                                        string pathtoremovetogetscriptmobname1 = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                        int lengthofstringtoremove1 = pathtoremovetogetscriptmobname1.Length;

                                                        if (removetheextensionfrommobname1.ToLower() == removetheextensionfrommobname.ToLower())
                                                        {
                                                            File.Copy(arrayoffiles2[fi], pathtoitemsweaponsmobweaponsmul + @"\" + "ItemMobWeapon" + removetheextensionfrommobname + "Sword" + ".cs", true);
                                                        }
                                                    }

                                                    for (int fi = 0; fi < arrayoffiles3.Length; fi++)
                                                    {
                                                        string thefilemobname1 = arrayoffiles3[fi].Substring(pathtozonesscriptmobs.Length + 1, (arrayoffiles3[fi].Length) - pathtozonesscriptmobs.Length - 1);

                                                        string removetheextensionfrommobname1 = thefilemobname1.Substring(0, thefilemobname1.Length - 3);

                                                        string theskeletonstr1 = "SpawnMobs";
                                                        removetheextensionfrommobname1 = removetheextensionfrommobname1.Substring(theskeletonstr1.Length, removetheextensionfrommobname1.Length - theskeletonstr1.Length);

                                                        string pathtoremovetogetscriptmobname1 = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                                        int lengthofstringtoremove1 = pathtoremovetogetscriptmobname1.Length;

                                                        //Console.WriteLine("/0:" + removetheextensionfrommobname + "/1:" + removetheextensionfrommobname1);

                                                       // if (removetheextensionfrommobname1 == "BossPragmiumQueen")
                                                        //{
                                                            removetheextensionfrommobname1 = "PragmiumQueen";
                                                       // }

                                                       // if (removetheextensionfrommobname1 == "BossSandTyrant")
                                                      // {
                                                      //      removetheextensionfrommobname1 = "SandTyrant";
                                                       // }

                                                        //Console.WriteLine("/0:" + removetheextensionfrommobname + "/1:" + removetheextensionfrommobname1);      


                                                        if (removetheextensionfrommobname1.ToLower() == removetheextensionfrommobname.ToLower())
                                                        {
                                                            if (removetheextensionfrommobname.ToLower() == "pragmiumqueen" ||
                                                             removetheextensionfrommobname.ToLower() == "sandtyrant" ||
                                                             removetheextensionfrommobname.ToLower() == "pragmiumbeetle" ||
                                                             removetheextensionfrommobname.ToLower() == "pragmiumbeetleminion" ||
                                                             removetheextensionfrommobname.ToLower() == "thumperminion")
                                                            {
                                                                //Console.WriteLine("found:" + removetheextensionfrommobname1);
                                                                continue;
                                                            }
                                                            else
                                                            {
                                                                //Console.WriteLine("found:" + removetheextensionfrommobname1);

                                                                File.Copy(arrayoffiles3[fi], pathtozonesscriptmobsmul + @"\" + "Spawn" + "Mobs" + removetheextensionfrommobname + ".cs", true);





                                                                //no back no front.
                                                                if (removetheextensionfrommobname.ToLower() == "broodnest" ||
                                                                    removetheextensionfrommobname.ToLower() == "floater")
                                                                {

                                                                }
                                                                //front only
                                                                else if (removetheextensionfrommobname.ToLower() != "spitter" &&
                                                                removetheextensionfrommobname.ToLower() != "crab" &&
                                                                removetheextensionfrommobname.ToLower() != "psigrove" &&
                                                                removetheextensionfrommobname.ToLower() != "starfish")
                                                                {

                                                                    string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                    string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
                                                                    string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
                                                                    string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
                                                                    string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

                                                                    for (int i = 0; i < numberofvariants; i++)
                                                                    {

                                                                        if (debugtoconsole == 1)
                                                                        {
                                                                            Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob spawn script" + removetheextensionfrommobname.ToLower() + ".");
                                                                        }
                                                                        createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 2);

                                                                        if (debugtoconsole == 1)
                                                                        {
                                                                            Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob spawn script" + removetheextensionfrommobname.ToLower() + ".");
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {

                                                                }

                                                            }
                                                        }
                                                    }





                                                    arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);

                                                    if (removetheextensionfrommobname.ToLower() == "broodnest" ||
                                                        removetheextensionfrommobname.ToLower() == "floater")
                                                    {
                                                        //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                        //arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);

                                                        for (int fi = 0; fi < arrayoffiles4.Length; fi++)
                                                        {
                                                            string thefilemobname1 = arrayoffiles4[fi].Substring(pathtoPNGSmobs.Length + 1, (arrayoffiles4[fi].Length) - pathtoPNGSmobs.Length - 1);

                                                            File.Copy(arrayoffiles4[fi], pathtoPNGSmobsmul + @"\" + thefilemobname1, true);

                                                            // Console.WriteLine(thefilemobname1);

                                                            //File.Copy(arrayoffiles4[fi], pathtoPNGSmobsmul + @"\" + "Mob" + "Boss" + removetheextensionfrommobname + ".cs", true);
                                                        }
                                                    }

                                                    if (removetheextensionfrommobname.ToLower() != "spitter" &&
                                                        removetheextensionfrommobname.ToLower() != "crab" &&
                                                        removetheextensionfrommobname.ToLower() != "psigrove" &&
                                                        removetheextensionfrommobname.ToLower() != "broodnest" &&
                                                        removetheextensionfrommobname.ToLower() != "floater" &&
                                                        removetheextensionfrommobname.ToLower() != "starfish")
                                                    {
                                                        arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);

                                                        for (int fi = 0; fi < arrayoffiles5.Length; fi++)
                                                        {
                                                            string thefilemobname1 = arrayoffiles5[fi].Substring(pathtoPNGSmobsback.Length + 1, (arrayoffiles5[fi].Length) - pathtoPNGSmobsback.Length - 1);

                                                            File.Copy(arrayoffiles5[fi], pathtoPNGSmobsbackmul + @"\" + thefilemobname1, true);
                                                        }
                                                    }


                                                    if (removetheextensionfrommobname.ToLower() == "spitter" ||
                                                        removetheextensionfrommobname.ToLower() == "crab" ||
                                                        removetheextensionfrommobname.ToLower() == "psigrove" ||
                                                        removetheextensionfrommobname.ToLower() == "starfish")
                                                    {
                                                        arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);

                                                        //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                        //arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);

                                                        for (int fi = 0; fi < arrayoffiles6.Length; fi++)
                                                        {
                                                            string thefilemobname1 = arrayoffiles6[fi].Substring(pathtoPNGSmobsfront.Length + 1, (arrayoffiles6[fi].Length) - pathtoPNGSmobsfront.Length - 1);

                                                            File.Copy(arrayoffiles6[fi], pathtoPNGSmobsfrontmul + @"\" + thefilemobname1, true);
                                                        }
                                                    }



                                                    for (int fi = 0; fi < arrayoffiles7.Length; fi++)
                                                    {
                                                        string thefilemobname1 = arrayoffiles7[fi].Substring(pathtoPNGSmobsAnimation.Length, (arrayoffiles7[fi].Length) - pathtoPNGSmobsAnimation.Length);

                                                        Console.WriteLine(thefilemobname1);

                                                        //File.Copy(arrayoffiles7[fi], pathtoPNGSmobsAnimationmul + @"\" + thefilemobname1, true);
                                                        File.Copy(arrayoffiles7[fi], pathtoPNGSmobsAnimationmul + @"\" + thefilemobname1, true);

                                                    }*/
                                                }
                                            }
                                            else
                                            {
                                                //endthread0 = 1;
                                                break;
                                            }
                                        }


                                    }



                                }






                                mainninesmodsfoldercounter++;
                                break;
                            }
                        }

                        if (mainninesmodsfoldercounter == 0)
                        {
                            sccsr16.Program.MessageBox((IntPtr)0, "The folder #Cryofallscriptgen doesn't exist on the desktop. Please follow the instructions on how to run this program on the Atomic Torch Forums post https://forums.atomictorch.com/index.php?topic=2162.0", "sccsmsg", 0);
                            //application.quit or loop thread.sleep until the folder is on the desktop and that all files have been transfered? return here later.
                        }



                    }


                    // sccsr16.Form1.currentform.startmultiplicationprocessmainswtc = 0;

                    if (debugtoconsole == 1)
                    {
                        thestopwatch.Stop();

                        Console.WriteLine("end of building/creating mob variants. timer:" + thestopwatch.Elapsed.TotalSeconds);
                    }

                    startmultiplicationprocessswtc = 0;
                    sccsr16.Form1.currentform.startmultiplicationprocessthreadswtc = 2;

                }



                Thread.Sleep(1);


                /*
                if (endthread0 == 0)
                {
                    goto _thread_main_loop;
                }
                else
                {

                    //thetimer.Stop();
                    //Console.WriteLine(thetimer.Elapsed.TotalSeconds);
                    //sccsr16.Program.CloseWindow(sccsr16.Form1.currentform.theconsolehandle);
                    endthread0 = 2;
                    //sccsr16.Program.MessageBox((IntPtr)0, "Program.cs program ended.", "sccsmsg", 0);

                }
                */

            }, 0); //100000 //999999999

            mainsccsgraphicssecthread.IsBackground = true;
            mainsccsgraphicssecthread.Priority = ThreadPriority.Normal; //AboveNormal
            mainsccsgraphicssecthread.SetApartmentState(ApartmentState.STA);
            mainsccsgraphicssecthread.Start();


            //mainsccsgraphicssecthread.Join();

            if (this._adapter != null)
            {
                this._adapter.Dispose();
                this._adapter = null;
            }

            if (this.device != null)
            {
                this.device.Dispose();
                this.device = null;
            }

            if (debugtoconsole == 1)
            {
                Console.WriteLine("created main program dedicated work thread.");
            }
            //sccsr16.Program.MessageBox((IntPtr)0, "sccsgraphicssec.cs program ended.", "sccsmsg", 0);


        }




        public void getrandvalues(out float rand, out float randb, out float randg, out float randr)
        {

            //float rand = (float)sc_maths.getSomeRandNum(0.75f, 1);

            float minrandm = 0.85f; //0.998f
            float maxrandm = 0.99f;//1.015f //0.999f

            rand = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandm, maxrandm, 1.0f, 0, -1);

            float diff = maxrandm - minrandm;

            rand = 1.0f;// minrandm + (diff * rand);

            /*float minrandg = 0.5f; //0.998f
            float maxrandg = 0.99f;//1.015f //0.999f

            float minrandb = 0.5f; //0.998f
            float maxrandb = 0.99f;//1.015f //0.999f

            float minrandr = 0.5f; //0.998f
            float maxrandr = 0.99f;//1.015f //0.999f
            */

            //ORIGINAL
            /*float minrandg = 0.81f; //0.90fs
            float maxrandg = 0.99f;//1.015f //0.999f

            float minrandb = 0.81f; //0.998f
            float maxrandb = 0.99f;//1.015f //0.999f

            float minrandr = 0.81f; //0.998f
            float maxrandr = 0.99f;//1.015f //0.999f
            //ORIGINAL*/



            //ORIGINAL
            float minrandg = 0.51f; //0.90fs
            float maxrandg = 0.99f;//1.015f //0.999f

            float minrandb = 0.51f; //0.998f
            float maxrandb = 0.99f;//1.015f //0.999f

            float minrandr = 0.51f; //0.998f
            float maxrandr = 0.99f;//1.015f //0.999f
            //ORIGINAL



            float brightnessrandg = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandg, maxrandg, 1.0f, 0, -1);
            float brightnessrandb = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandb, maxrandb, 1.0f, 0, -1);
            float brightnessrandr = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandr, maxrandr, 1.0f, 0, -1);

            randg = brightnessrandg;
            randb = brightnessrandb;// (float)sc_maths.getSomeRandNumThousandDecimalfloat(0.9995f, 0.9999f, 1.0f, 0, -1);
            randr = brightnessrandr;// (float)sc_maths.getSomeRandNumThousandDecimalfloat(0.9995f, 0.9999f, 1.0f, 0, -1) * 1.15f;

            float diffg = maxrandg - minrandg;
            randg = minrandg + (diffg * randg);
            //randg *= 1.0f;

            float diffb = maxrandb - minrandb;
            randb = minrandb + (diffb * randb);
            //randb *= 1.0f;
            //randb *= 1.15f;

            float diffr = maxrandr - minrandr;
            randr = minrandr + (diffr * randr);
            //randr *= 1.0f;

            //randr *= 1.15f;
            //randb = randg;
            //randr = randg * 1.15f;
        }
        










        public unsafe void createvariantpngsnew(int variantindex, string pathtoanimationpngs, string themodfoldernamewithoutextension, int thetypeofgenerator, string themobname, int frontorback, float rand, float randr, float randg,float randb)
        {








            //string finalPathoriBack = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + originalfolder + @"\" + "Back" + @"\" + "Male" + @"\";
            //string finalPathoriFront = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + originalfolder + @"\" + "Front" + @"\" + "Male" + @"\";
            //string finalPathmulBack = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + theimagesfolder + @"\" + "Back" + @"\" + "Male" + @"\";
            //string finalPathmulFront = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + theimagesfolder + @"\" + "Front" + @"\" + "Male" + @"\";

            string thefrontorbackstring = "";

            if (frontorback == 0)
            {
                thefrontorbackstring = "Front";
            }
            else if (frontorback == 1)
            {
                thefrontorbackstring = "Back";
            }
            else if (frontorback == 2)
            {
                thefrontorbackstring = "";
            }



            if (thetypeofgenerator == 1)
            {
                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //GET PATH TO #Cryofallscriptgen
                string pathToDesktop = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
                DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
                directoryFolder.Refresh();

                string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";
                string prefinalpathtofilesmultiplied = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "multiplied";



              



                sccstextureloader texturetoload;
                string finalPathOriginalFront = @"\" + thefrontorbackstring;// "Front";







                ////Console.WriteLine(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");

                string[] arrayoforiginalpngfilesfront = null;



                if (thetypeofgenerator == 0)
                {
                    if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                    {
                        arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");
                    }
                    else
                    {
                        arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront);
                    }
                }
                else
                {

                    if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                    {
                        arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");
                    }
                    else
                    {
                        arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront);

                    }
                }







                ////Console.WriteLine(pathtoanimationpngs + finalPathOriginalFront);

                string folderNamemulPNGS = "multiplied";

                if (!Directory.Exists(prefinalpathtofilesmultiplied))
                {
                    Directory.CreateDirectory(prefinalpathtofilesmultiplied); // + @"\" + "Zones"
                }




                string mobname = themodfoldernamewithoutextension;

                string themobfolder = mobname + "Variant" + variantindex;

                string finalPathmulFront = "";// prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + "Front" + @"\" + "Male" + @"\";

                string themobsfolderstring = "Mobs";


                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    finalPathmulFront = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male" + @"\";
                }
                else
                {
                    finalPathmulFront = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + thefrontorbackstring + @"\";
                }









                string finalPathanims = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                var arrayoforiginalpngfilesanims = Directory.GetFiles(finalPathanims);

                ////Console.WriteLine(finalPathanims);


                ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);
                string finalPathanims1 = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                string finalPathanims2 = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder; // + @"\" + "images"





                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    if (!Directory.Exists(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"))
                    {
                        Directory.CreateDirectory(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"); // + @"\" + "Zones"
                    }              
                }
                else
                {
                    if (!Directory.Exists(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring))
                    {
                        Directory.CreateDirectory(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring); // + @"\" + "Zones"
                    }

                }







                //copy anims
                for (int i = 0; i < arrayoforiginalpngfilesanims.Length; i++)
                {
                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);
                    string finalfilename = arrayoforiginalpngfilesanims[i].Substring(finalPathanims1.Length, (arrayoforiginalpngfilesanims[i].Length - (finalPathanims1.Length)));
                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalpngfilesanims[i], finalPathanims2 + @"\" + finalfilename, true);
                }
                //copy anims

                //copy weapon not sure if that is necessary now
                string finalPathweapon = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"
                var arrayoforiginalweapon = Directory.GetFiles(finalPathweapon);
                for (int i = 0; i < arrayoforiginalweapon.Length; i++)
                {

                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalweapon[i]);

                    string finalfilename = arrayoforiginalweapon[i].Substring(finalPathanims1.Length, (arrayoforiginalweapon[i].Length - (finalPathanims1.Length)));
                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalweapon[i], finalPathanims2 + @"\" + finalfilename, true);
                }
                //copy weapon not sure if that is necessary now



                //string finalPathmulBack2 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + "Back" + @"\" + "Male" + @"\";
                //string finalPathmulFront2 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + "Front" + @"\" + "Male" + @"\";


                //copy anims
                for (int i = 0; i < arrayoforiginalpngfilesfront.Length; i++)
                {

                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalpngfilesfront[i]);

                    string finalfilename = arrayoforiginalpngfilesfront[i].Substring(finalPathanims1.Length, (arrayoforiginalpngfilesfront[i].Length - (finalPathanims1.Length)));
                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalpngfilesfront[i], finalPathanims2 + @"\" + finalfilename, true);
                }
                //copy anims













                //AT VARIANT INDEX 0, ALSO COPY THE ORIGINAL FILES
                if (variantindex == 0)
                {
                    string finalPathanimsa = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"

                    string finalPathanimsf = "";// prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + "Front" + @"\" + "Male"; // + @"\" + "images"


                    if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                    {
                        finalPathanimsf = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"

                    }
                    else
                    {
                        finalPathanimsf = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring; // + @"\" + "images"

                    }

                    if (!Directory.Exists(finalPathanimsf))
                    {
                        Directory.CreateDirectory(finalPathanimsf); // + @"\" + "Zones"
                    }


                    string finalPathPNGSf = "";//prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"

                    if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                    {
                        finalPathPNGSf = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"
                    }
                    else
                    {
                        finalPathPNGSf = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring; // + @"\" + "images"

                    }












                    var arrayoforiginalpngsf = Directory.GetFiles(finalPathPNGSf);


                    //copy pngs front
                    for (int i = 0; i < arrayoforiginalpngsf.Length; i++)
                    {

                        ////Console.WriteLine(finalPathanims1);
                        ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);


                        string finalfilename = arrayoforiginalpngsf[i].Substring(finalPathPNGSf.Length + 1, (arrayoforiginalpngsf[i].Length - (finalPathPNGSf.Length + 1)));
                        //Console.WriteLine(finalfilename);

                        File.Copy(arrayoforiginalpngsf[i], finalPathanimsf + @"\" + finalfilename, true);
                    }
                    //copy pngs front












                    //copy weapon not sure if that is necessary now
                    string finalPathweapon1 = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"
                    var arrayoforiginalweapon1 = Directory.GetFiles(finalPathweapon1);
                    ////Console.WriteLine(finalPathweapon1);
                    string finalPathweapon2 = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"

                    DirectoryInfo directoryFolder0 = new DirectoryInfo(finalPathweapon1);
                    directoryFolder0.Refresh();

                    for (int i = 0; i < arrayoforiginalweapon1.Length; i++)
                    {
                        ////Console.WriteLine(finalPathanims3);
                        ////Console.WriteLine(arrayoforiginalweapon[i]);

                        string finalfilename = arrayoforiginalweapon1[i].Substring(finalPathweapon1.Length + 1, (arrayoforiginalweapon1[i].Length - (finalPathweapon1.Length + 1)));
                        //Console.WriteLine(finalfilename);

                        //DirectoryInfo directoryFolder1 = new DirectoryInfo(finalfilename);
                        //directoryFolder1.Refresh();
                        ////Console.WriteLine(finalPathweapon1 + @"\" + finalfilename);
                        File.Copy(arrayoforiginalweapon1[i], finalPathweapon2 + @"\" + finalfilename, true);
                    }
                    //copy weapon not sure if that is necessary now



                    //copy weapon not sure if that is necessary now
                    string finalPathweapon11 = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                    var arrayoforiginalanims11 = Directory.GetFiles(finalPathweapon11);
                    ////Console.WriteLine(finalPathweapon1);
                    string finalpathanims = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"

                    DirectoryInfo directoryFolder00 = new DirectoryInfo(finalPathweapon11);
                    directoryFolder00.Refresh();

                    for (int i = 0; i < arrayoforiginalanims11.Length; i++)
                    {
                        ////Console.WriteLine(finalPathanims3);
                        ////Console.WriteLine(arrayoforiginalweapon[i]);

                        string finalfilename = arrayoforiginalanims11[i].Substring(finalPathweapon11.Length + 1, (arrayoforiginalanims11[i].Length - (finalPathweapon11.Length + 1)));
                        ////Console.WriteLine(finalfilename);

                        //DirectoryInfo directoryFolder1 = new DirectoryInfo(finalfilename);
                        //directoryFolder1.Refresh();
                        ////Console.WriteLine(finalPathweapon1 + @"\" + finalfilename);
                        File.Copy(arrayoforiginalanims11[i], finalpathanims + @"\" + finalfilename, true);
                    }
                    //copy weapon not sure if that is necessary now

                }































                if (!Directory.Exists(finalPathmulFront))
                {
                    Directory.CreateDirectory(finalPathmulFront); // + @"\" + "Zones"
                }

                ////Console.WriteLine("TEST"+finalPathmulFront);
                ////Console.WriteLine(arrayoforiginalpngfilesfront.Length);

                ////Console.WriteLine("TEST" + finalPathmulFront);

                string finalPathoriFront = "";// pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male";



                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    finalPathoriFront = pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male";
                }
                else
                {
                    finalPathoriFront = pathtoanimationpngs + finalPathOriginalFront;

                }












                for (int i = 0; i < arrayoforiginalpngfilesfront.Length; i++)
                {
                    texturetoload = new sccstextureloader();

                    var textureinit = texturetoload.Initialize(device, arrayoforiginalpngfilesfront[i]);

                    if (textureinit)
                    {
                        ////Console.WriteLine("texture initialiased");

                        var factory = new SharpDX.WIC.ImagingFactory();
                        var filename = arrayoforiginalpngfilesfront[i];// "OnBoardComputer.png";

                        //string finalfilename = arrayoforiginalpngfilesfront[i].Substring(finalPathmulFront.Length-2, (arrayoforiginalpngfilesfront[i].Length-1 - finalPathmulFront.Length - 1));

                        ////Console.WriteLine("finalPathoriFront:" + finalPathoriFront);

                        string finalfilename = arrayoforiginalpngfilesfront[i].Substring(finalPathoriFront.Length + 1, (arrayoforiginalpngfilesfront[i].Length - finalPathoriFront.Length - 5));
                        ////Console.WriteLine("filename:" + finalfilename);
                        ////Console.WriteLine("filename:" + filename);

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

                        ////float brightnessmultiplierb = 0.95f; //green
                        //float brightnessmultiplierg = 0.95f; //blue
                        //float brightnessmultiplierr = 1.15f; //red
                        //float lastbrightnessmul = 1.25f;

                        float brightnessmultiplierb = randb; //green
                        float brightnessmultiplierg = randg; //blue
                        float brightnessmultiplierr = randr; //red

                        float lastbrightnessmul = rand;

                        int countgreenscreenpixelsareweinanoptiontransition = 0;

                        fixed (byte* textureByteArray = onboardcomputeiconpixeldata) //, totalArray = _totalArray
                        {
                            int posY = 0;
                            for (int yyyy = 0; yyyy < theonboardcomputertextureFINAL.Description.Height; yyyy++)
                            {
                                for (int xxxx = 0; xxxx < theonboardcomputertextureFINAL.Description.Width; xxxx++)
                                {
                                    var bytePoser = ((yyyy * theonboardcomputertextureFINAL.Description.Width) + xxxx) * 4;


                                    byte invertblueandgreen = textureByteArray[bytePoser + 0];
                                    byte invertgreenandblue = textureByteArray[bytePoser + 2];

                                    textureByteArray[bytePoser + 0] = (byte)((int)(invertgreenandblue * brightnessmultiplierb * lastbrightnessmul));
                                    textureByteArray[bytePoser + 1] = (byte)((int)(textureByteArray[bytePoser + 1] * brightnessmultiplierg * lastbrightnessmul));
                                    textureByteArray[bytePoser + 2] = (byte)((int)(invertblueandgreen * brightnessmultiplierr * lastbrightnessmul));

                                    posY++;
                                }
                            }
                        }

                        ////Console.WriteLine("TEST" + finalPathmulFront + finalfilename + ".png");



                        ////Console.WriteLine(finalPathmulFront);


                        //break;




                        device.ImmediateContext.UnmapSubresource(theonboardcomputertextureFINAL, 0);



                        //Console.WriteLine(finalPathmulFront + finalfilename + ".png");

                        DirectoryInfo directoryFolder0 = new DirectoryInfo(finalPathmulFront);
                        directoryFolder0.Refresh();



                        var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
                        //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
                        somebitmap.Save(finalPathmulFront + finalfilename + ".png");
                        bitmapcounter++;
                        
                        




                        //DeleteObject(interptr1);
                        //DISCARDED
                        //DISCARDED
                        //DISCARDED






                        //somebitmap.Dispose();
                        //factory­.Dispose();
                        //thetexture2d.Dispose();
                        //theonboardcomputertextureFINAL.Dispose();
                        //bitmapDecoder.Dispose();
                        //bitmapsourceresult.Dispose();


                        if (interptr1last != IntPtr.Zero)
                        {
                            DeleteObject(interptr1last);
                            interptr1last = IntPtr.Zero;
                        }

                        interptr1last = interptr1;



                        if (thetexture2dlast != null)
                        {
                            thetexture2dlast.Dispose();
                            thetexture2dlast = null;
                        }

                        //if (thetexture2d != null)
                        {
                            thetexture2dlast = thetexture2d;
                        }


                        if (bitmapDecoderlast != null)
                        {
                            bitmapDecoderlast.Dispose();
                            bitmapDecoderlast = null;
                        }

                        //if (bitmapDecoderlast != null)
                        {
                            bitmapDecoderlast = bitmapDecoder;
                        }

                        if (factorylast != null)
                        {
                            factorylast.Dispose();
                            factorylast = null;
                        }

                        //if (factorylast != null)
                        {
                            factorylast = factory;
                        }

                        if (theonboardcomputertextureFINALlast != null)
                        {
                            theonboardcomputertextureFINALlast.Dispose();
                            theonboardcomputertextureFINALlast = null;
                        }

                        //if (theonboardcomputertextureFINALlast != null)
                        {
                            theonboardcomputertextureFINALlast = theonboardcomputertextureFINAL;
                        }

                        if (bitmapsourceresultlast != null)
                        {
                            bitmapsourceresultlast.Dispose();
                            bitmapsourceresultlast = null;
                        }

                        //if (bitmapsourceresultlast != null)
                        {
                            bitmapsourceresultlast = bitmapsourceresult;
                        }
                        
                        
                        if (somebitmaplast != null)
                        {
                            somebitmaplast.Dispose();
                            somebitmaplast = null;
                        }

                        //if (somebitmaplast != null)
                        {
                            somebitmaplast = somebitmap;
                        }




                    }
                    else
                    {

                        /*string finalPathanims = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\";

                        File.Copy(arrayoforiginalpngfilesfront[i], finalPathanims, true);
                        */

                    }


                    if (textureinit)
                    {
                       
                    }

                    if (texturetoload != null)
                    {
                        texturetoload.ShutDown();
                        texturetoload = null;
                    }
                }

                //COPYANIMATIONS
                //string finalPathmulFront1 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\";







            }
            else if (thetypeofgenerator == 0)
            {







                var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                //GET PATH TO #Cryofallscriptgen
                string pathToDesktop = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                //string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
                DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
                directoryFolder.Refresh();

                string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";
                string prefinalpathtofilesmultiplied = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "multiplied";


                sccstextureloader texturetoload;
                string finalPathOriginalFront = @"\" + thefrontorbackstring;

                ////Console.WriteLine(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");

                string[] arrayoforiginalpngfilesfront;

                
                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");
                }
                else
                {
                    arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront);
                }


                ////Console.WriteLine(pathtoanimationpngs + finalPathOriginalFront);

                string folderNamemulPNGS = "multiplied";

                if (!Directory.Exists(prefinalpathtofilesmultiplied))
                {
                    Directory.CreateDirectory(prefinalpathtofilesmultiplied); // + @"\" + "Zones"
                }




                string mobname = themodfoldernamewithoutextension;

                string themobfolder = mobname + "Variant" + variantindex;

                string finalPathmulFront = "";// prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male" + @"\";



                string themobsfolderstring = themodfoldernamewithoutextension;


                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    finalPathmulFront = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male" + @"\";


                }
                else
                {
                    finalPathmulFront = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + thefrontorbackstring + @"\";


                }









                string finalPathanims = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                var arrayoforiginalpngfilesanims = Directory.GetFiles(finalPathanims);

                ////Console.WriteLine(finalPathanims);


                ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);
                string finalPathanims1 = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                string finalPathanims2 = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder; // + @"\" + "images"





                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    if (!Directory.Exists(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"))
                    {
                        Directory.CreateDirectory(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"); // + @"\" + "Zones"
                    }

                }
                else
                {
                    if (!Directory.Exists(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring))
                    {
                        Directory.CreateDirectory(finalPathanims2 + @"\" + "images" + @"\" + thefrontorbackstring); // + @"\" + "Zones"
                    }

                }







                //copy anims
                for (int i = 0; i < arrayoforiginalpngfilesanims.Length; i++)
                {

                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);


                    string finalfilename = arrayoforiginalpngfilesanims[i].Substring(finalPathanims1.Length, (arrayoforiginalpngfilesanims[i].Length - (finalPathanims1.Length)));
                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalpngfilesanims[i], finalPathanims2 + @"\" + finalfilename, true);
                }
                //copy anims

                //copy weapon not sure if that is necessary now
                string finalPathweapon = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"
                var arrayoforiginalweapon = Directory.GetFiles(finalPathweapon);
                for (int i = 0; i < arrayoforiginalweapon.Length; i++)
                {

                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalweapon[i]);

                    string finalfilename = arrayoforiginalweapon[i].Substring(finalPathanims1.Length, (arrayoforiginalweapon[i].Length - (finalPathanims1.Length)));
                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalweapon[i], finalPathanims2 + @"\" + finalfilename, true);
                }
                //copy weapon not sure if that is necessary now



                //string finalPathmulBack2 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + "Back" + @"\" + "Male" + @"\";
                //string finalPathmulFront2 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male" + @"\";


                //copy anims
                for (int i = 0; i < arrayoforiginalpngfilesfront.Length; i++)
                {

                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalpngfilesfront[i]);

                    string finalfilename = arrayoforiginalpngfilesfront[i].Substring(finalPathanims1.Length, (arrayoforiginalpngfilesfront[i].Length - (finalPathanims1.Length)));
                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalpngfilesfront[i], finalPathanims2 + @"\" + finalfilename, true);
                }
                //copy anims













                //AT VARIANT INDEX 0, ALSO COPY THE ORIGINAL FILES
                if (variantindex == 0)
                {
                    string finalPathanimsa = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"

                    string finalPathanimsf = "";// prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"

                    if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                    {
                        finalPathanimsf = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"
                    }
                    else
                    {
                        finalPathanimsf = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring; // + @"\" + "images"
                    }

                    if (!Directory.Exists(finalPathanimsf))
                    {
                        Directory.CreateDirectory(finalPathanimsf); // + @"\" + "Zones"
                    }
                 
                    string finalPathPNGSf = "";//prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"

                    if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                    {
                        finalPathPNGSf = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring + @"\" + "Male"; // + @"\" + "images"
                    }
                    else
                    {
                        finalPathPNGSf = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + thefrontorbackstring; // + @"\" + "images"

                    }






                    var arrayoforiginalpngsf = Directory.GetFiles(finalPathPNGSf);


                    //copy pngs front
                    for (int i = 0; i < arrayoforiginalpngsf.Length; i++)
                    {

                        ////Console.WriteLine(finalPathanims1);
                        ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);


                        string finalfilename = arrayoforiginalpngsf[i].Substring(finalPathPNGSf.Length + 1, (arrayoforiginalpngsf[i].Length - (finalPathPNGSf.Length + 1)));
                        //Console.WriteLine(finalfilename);

                        File.Copy(arrayoforiginalpngsf[i], finalPathanimsf + @"\" + finalfilename, true);
                    }
                    //copy pngs front















                    //copy weapon not sure if that is necessary now
                    string finalPathweapon1 = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"
                    var arrayoforiginalweapon1 = Directory.GetFiles(finalPathweapon1);
                    ////Console.WriteLine(finalPathweapon1);
                    string finalPathweapon2 = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"

                    DirectoryInfo directoryFolder0 = new DirectoryInfo(finalPathweapon1);
                    directoryFolder0.Refresh();

                    for (int i = 0; i < arrayoforiginalweapon1.Length; i++)
                    {
                        ////Console.WriteLine(finalPathanims3);
                        ////Console.WriteLine(arrayoforiginalweapon[i]);

                        string finalfilename = arrayoforiginalweapon1[i].Substring(finalPathweapon1.Length + 1, (arrayoforiginalweapon1[i].Length - (finalPathweapon1.Length + 1)));
                        //Console.WriteLine(finalfilename);

                        //DirectoryInfo directoryFolder1 = new DirectoryInfo(finalfilename);
                        //directoryFolder1.Refresh();
                        ////Console.WriteLine(finalPathweapon1 + @"\" + finalfilename);
                        File.Copy(arrayoforiginalweapon1[i], finalPathweapon2 + @"\" + finalfilename, true);
                    }
                    //copy weapon not sure if that is necessary now



                    //copy weapon not sure if that is necessary now
                    string finalPathweapon11 = prefinalpathtofiles + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                    var arrayoforiginalanims11 = Directory.GetFiles(finalPathweapon11);
                    ////Console.WriteLine(finalPathweapon1);
                    string finalpathanims = prefinalpathtofilesmultiplied + @"\" + themobsfolderstring + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"

                    DirectoryInfo directoryFolder00 = new DirectoryInfo(finalPathweapon11);
                    directoryFolder00.Refresh();

                    for (int i = 0; i < arrayoforiginalanims11.Length; i++)
                    {
                        ////Console.WriteLine(finalPathanims3);
                        ////Console.WriteLine(arrayoforiginalweapon[i]);

                        string finalfilename = arrayoforiginalanims11[i].Substring(finalPathweapon11.Length + 1, (arrayoforiginalanims11[i].Length - (finalPathweapon11.Length + 1)));
                        ////Console.WriteLine(finalfilename);

                        //DirectoryInfo directoryFolder1 = new DirectoryInfo(finalfilename);
                        //directoryFolder1.Refresh();
                        ////Console.WriteLine(finalPathweapon1 + @"\" + finalfilename);
                        File.Copy(arrayoforiginalanims11[i], finalpathanims + @"\" + finalfilename, true);
                    }
                    //copy weapon not sure if that is necessary now

                }








                if (!Directory.Exists(finalPathmulFront))
                {
                    Directory.CreateDirectory(finalPathmulFront); // + @"\" + "Zones"
                }

                ////Console.WriteLine("TEST"+finalPathmulFront);
                ////Console.WriteLine(arrayoforiginalpngfilesfront.Length);

                ////Console.WriteLine("TEST" + finalPathmulFront);

                string finalPathoriFront = "";// pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male";



                if (themodfoldernamewithoutextension.ToLower().Contains("skeleton") || themodfoldernamewithoutextension.ToLower().Contains("zombie"))
                {
                    finalPathoriFront = pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male";
                }
                else
                {
                    finalPathoriFront = pathtoanimationpngs + finalPathOriginalFront;

                }












                for (int i = 0; i < arrayoforiginalpngfilesfront.Length; i++)
                {
                    texturetoload = new sccstextureloader();

                    var textureinit = texturetoload.Initialize(device, arrayoforiginalpngfilesfront[i]);

                    if (textureinit)
                    {
                        ////Console.WriteLine("texture initialiased");

                        SharpDX.WIC.ImagingFactory factory = new SharpDX.WIC.ImagingFactory();
                        var filename = arrayoforiginalpngfilesfront[i];// "OnBoardComputer.png";

                        //string finalfilename = arrayoforiginalpngfilesfront[i].Substring(finalPathmulFront.Length-2, (arrayoforiginalpngfilesfront[i].Length-1 - finalPathmulFront.Length - 1));

                        ////Console.WriteLine("finalPathoriFront:" + finalPathoriFront);

                        string finalfilename = arrayoforiginalpngfilesfront[i].Substring(finalPathoriFront.Length + 1, (arrayoforiginalpngfilesfront[i].Length - finalPathoriFront.Length - 5));
                        ////Console.WriteLine("filename:" + finalfilename);
                        ////Console.WriteLine("filename:" + filename);

                        SharpDX.WIC.BitmapDecoder bitmapDecoder = new SharpDX.WIC.BitmapDecoder(
                            factory,
                            filename,
                            SharpDX.WIC.DecodeOptions.CacheOnDemand
                        );

                        SharpDX.WIC.FormatConverter bitmapsourceresult = new SharpDX.WIC.FormatConverter(factory);

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

                        Texture2D theonboardcomputertextureFINAL = new Texture2D(device, _textureDescriptionFINAL);

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

                        ////float brightnessmultiplierb = 0.95f; //green
                        //float brightnessmultiplierg = 0.95f; //blue
                        //float brightnessmultiplierr = 1.15f; //red
                        //float lastbrightnessmul = 1.25f;

                        float brightnessmultiplierb = randb; //green
                        float brightnessmultiplierg = randg; //blue
                        float brightnessmultiplierr = randr; //red

                        float lastbrightnessmul = rand;

                        int countgreenscreenpixelsareweinanoptiontransition = 0;

                        fixed (byte* textureByteArray = onboardcomputeiconpixeldata) //, totalArray = _totalArray
                        {
                            int posY = 0;
                            for (int yyyy = 0; yyyy < theonboardcomputertextureFINAL.Description.Height; yyyy++)
                            {
                                for (int xxxx = 0; xxxx < theonboardcomputertextureFINAL.Description.Width; xxxx++)
                                {
                                    var bytePoser = ((yyyy * theonboardcomputertextureFINAL.Description.Width) + xxxx) * 4;

                                    /*byte originalg = textureByteArray[bytePoser + 0];
                                    byte originalb = textureByteArray[bytePoser + 1];
                                    byte originalr = textureByteArray[bytePoser + 2];

                                    float percentg = (textureByteArray[bytePoser + 0] / 255);
                                    float percentb = (textureByteArray[bytePoser + 1] / 255);
                                    float percentr = (textureByteArray[bytePoser + 2] / 255);


                                    byte valuereducedtoahundredg = (byte)(255 * percentg);
                                    byte valuereducedtoahundredb = (byte)(255 * percentg);
                                    byte valuereducedtoahundredr = (byte)(255 * percentg);

                                     //byte invertblueandgreen = textureByteArray[bytePoser + 0];
                                     //byte invertgreenandblue = textureByteArray[bytePoser + 1];

                                     //textureByteArray[bytePoser + 0] = (byte)((int)(invertgreenandblue * brightnessmultiplierg * lastbrightnessmul));
                                     //textureByteArray[bytePoser + 1] = (byte)((int)(invertblueandgreen * brightnessmultiplierb * lastbrightnessmul));
                                     //textureByteArray[bytePoser + 2] = (byte)((int)(textureByteArray[bytePoser + 2] * brightnessmultiplierr * lastbrightnessmul));

                                    */
                                    byte invertblueandgreen = textureByteArray[bytePoser + 0];
                                    byte invertgreenandblue = textureByteArray[bytePoser + 2];

                                    textureByteArray[bytePoser + 0] = (byte)((int)(invertgreenandblue * brightnessmultiplierb * lastbrightnessmul));
                                    textureByteArray[bytePoser + 1] = (byte)((int)(textureByteArray[bytePoser + 1] * brightnessmultiplierg * lastbrightnessmul));
                                    textureByteArray[bytePoser + 2] = (byte)((int)(invertblueandgreen * brightnessmultiplierr * lastbrightnessmul));

                                    posY++;
                                }
                            }
                        }

                        ////Console.WriteLine("TEST" + finalPathmulFront + finalfilename + ".png");



                        ////Console.WriteLine(finalPathmulFront);



                        device.ImmediateContext.UnmapSubresource(theonboardcomputertextureFINAL, 0);

                        
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(finalPathmulFront);
                        directoryFolder0.Refresh();
                        //break;

                        System.Drawing.Bitmap somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
                        //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
                        somebitmap.Save(finalPathmulFront + finalfilename + ".png");

                        bitmapcounter++;

                        //Console.WriteLine(finalPathmulFront + finalfilename + ".png");

                        //DeleteObject(interptr1);
                        //DISCARDED
                        //DISCARDED
                        //DISCARDED

                        /*
                        somebitmap.Dispose();
                        factory­.Dispose();
                        thetexture2d.Dispose();
                        theonboardcomputertextureFINAL.Dispose();
                        bitmapDecoder.Dispose();
                        bitmapsourceresult.Dispose();
                        */
                        /*
                        SharpDX.Direct3D11.Texture2D thetexture2dlast;
                        SharpDX.WIC.BitmapDecoder bitmapDecoderlast;
                        SharpDX.WIC.ImagingFactory factorylast;
                        Texture2D theonboardcomputertextureFINALlast;
                        SharpDX.WIC.FormatConverter bitmapsourceresultlast;
                        System.Drawing.Bitmap somebitmaplast;*/

                        if (interptr1last != IntPtr.Zero)
                        {
                            DeleteObject(interptr1last);
                        }

                        interptr1last = interptr1;

                        if (thetexture2dlast != null)
                        {
                            thetexture2dlast.Dispose();
                            thetexture2dlast = null;
                        }

                        //if (thetexture2d != null)
                        {
                            thetexture2dlast = thetexture2d;
                        }

                        if (bitmapDecoderlast != null)
                        {
                            bitmapDecoderlast.Dispose();
                            bitmapDecoderlast = null;
                        }

                        //if (bitmapDecoderlast != null)
                        {
                            bitmapDecoderlast = bitmapDecoder;
                        }

                        if (factorylast != null)
                        {
                            factorylast.Dispose();
                            factorylast = null;
                        }

                        //if (factorylast != null)
                        {
                            factorylast = factory;
                        }




                        if (theonboardcomputertextureFINALlast != null)
                        {
                            theonboardcomputertextureFINALlast.Dispose();
                            theonboardcomputertextureFINALlast = null;
                        }

                        //if (theonboardcomputertextureFINALlast != null)
                        {
                            theonboardcomputertextureFINALlast = theonboardcomputertextureFINAL;
                        }

                        if (bitmapsourceresultlast != null)
                        {
                            bitmapsourceresultlast.Dispose();
                            bitmapsourceresultlast = null;
                        }

                        //if (bitmapsourceresultlast != null)
                        {
                            bitmapsourceresultlast = bitmapsourceresult;
                        }

                        if (somebitmaplast != null)
                        {
                            somebitmaplast.Dispose();
                            somebitmaplast = null;
                        }

                        //if (somebitmaplast != null)
                        {
                            somebitmaplast = somebitmap;
                        }

                        










                    }
                    else
                    {

                        /*string finalPathanims = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\";

                        File.Copy(arrayoforiginalpngfilesfront[i], finalPathanims, true);
                        */
                        sccsr16.Program.MessageBox((IntPtr)0, "the texture has access issues or is broken/corrupted or is locked.", "sccsmsg", 0);
                    }


                    if (texturetoload != null)
                    {
                        texturetoload.ShutDown();

                    }


                    /*
                           somebitmap.Dispose();
                       factory­.Dispose();
                       thetexture2d.Dispose();
                       theonboardcomputertextureFINAL.Dispose();
                       bitmapDecoder.Dispose();
                       bitmapsourceresult.Dispose();*/


                }





                //COPYANIMATIONS
                string finalPathmulFront1 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\";
            }
        }




















        //SCRIPTS
        //SCRIPTS
        //SCRIPTS
        public void createvariantscripts(int variantindex, string mobname, string pathtoscripts, string pathtoscriptsmul, string themodfoldernamewithoutextension, int thetypeofgenerator)// double mobspeed, double mobhp, float mobheight
        {

            var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

            //GET PATH TO #Cryofallscriptgen
            string pathToDesktop = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //////Console.WriteLine("2_mainThreadStarter");
            string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
            DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
            directoryFolder.Refresh();
            //string pathToDesktopFolder = pathToDesktop + @"\" + folderName;

            //C: \Users\steve\Desktop\#Cryofallscriptgen\original\Skeleton.mpk\Scripts

            Console.WriteLine(mobname);

            ////Console.WriteLine(pathtoscripts);
            string folderNamemulPNGS = "multiplied";
            string folderNameOriginalPNGS = "original";

            //string folderNamemulPNGS = "multiplied";// + @"\" + "Skeleton" + "Variant" + variantindex;
            string themobfolder = mobname + "Variant" + variantindex;

            var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "Characters" + @"\" + "Mobs");

            ////Console.WriteLine(pathtoscripts);

            string finalpathmobscript = pathtoscriptsmul + @"\" + "Characters" + @"\" + "Mobs" + @"\";
            string finalpathmobskeletonscript = pathtoscriptsmul + @"\" + "CharacterSkeletons" + @"\";
            string finalpathmobitemscript = pathtoscriptsmul + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
            string finalpathmobzonescript = pathtoscriptsmul + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";

            string finalpathmobscriptori = pathtoscripts + @"\" + "Characters" + @"\" + "Mobs" + @"\";
            string finalpathmobskeletonscriptori = pathtoscripts + @"\" + "CharacterSkeletons" + @"\";
            string finalpathmobitemscriptori = pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
            string finalpathmobzonescriptori = pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";


            Directory.CreateDirectory(finalpathmobscript);
            Directory.CreateDirectory(finalpathmobskeletonscript);
            Directory.CreateDirectory(finalpathmobitemscript);
            Directory.CreateDirectory(finalpathmobzonescript);



















            //MODIFY THE MOB SCRIPT
            for (int i = 0; i < arrayoforiginalscriptfilesMOB.Length; i++)
            {

                var prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                var thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                var filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                string prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                string thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                string filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";

                var readalltextstring = File.ReadAllText(filenamewithext);

                string thehporiginal = "StatDefaultHealthMax => ";

                var thefiledata = File.ReadAllText(filenamewithext).IndexOf(thehporiginal);

                string substringofthehealth = readalltextstring.Substring(thefiledata, 64);

                string theendofline = ";";
                string thearrow = "=>";

                var thefiledata1 = substringofthehealth.IndexOf(theendofline);
                var thefiledata2 = substringofthehealth.IndexOf(thearrow);

                string substringofthehp = substringofthehealth.Substring(thefiledata2 + thearrow.Length + 1, 32);
                double resultparsedstr;
                double.TryParse(substringofthehp, out resultparsedstr);
                double thehpofthemob = resultparsedstr;




                ////Console.WriteLine("hp:" + thehpofthemob + "/hpdoublestr:" + substringofthehp);









                prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";

                readalltextstring = File.ReadAllText(filenamewithext);

                thehporiginal = "StatMoveSpeed => ";

                thefiledata = File.ReadAllText(filenamewithext).IndexOf(thehporiginal);

                substringofthehealth = readalltextstring.Substring(thefiledata, 64);

                theendofline = ";";
                thearrow = "=>";

                thefiledata1 = substringofthehealth.IndexOf(theendofline);
                thefiledata2 = substringofthehealth.IndexOf(thearrow);

                string substringofthespeed1 = substringofthehealth.Substring(thefiledata2 + thearrow.Length + 1 + 24, 8 + 4);
                //double resultparsedstr;
                double.TryParse(substringofthespeed1, out resultparsedstr);
                double thespeedofthemob = resultparsedstr;



                ////Console.WriteLine("thespeedofthemob:" + thespeedofthemob);



                //Console.WriteLine("substringofthespeed1:" + substringofthespeed1);



                /*
                prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";
                */


                prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";
                string filenamewithextmul = finalpathmobscript; // + (thefinalfilename) + ".cs"



                readalltextstring = File.ReadAllText(filenamewithext);

                thehporiginal = "CharacterWorldHeight => ";

                thefiledata = File.ReadAllText(filenamewithext).IndexOf(thehporiginal);

                string substringoftheheight = readalltextstring.Substring(thefiledata + thehporiginal.Length, 32 + 4);




                float resultparsedstrfloat;
                float.TryParse(substringoftheheight, out resultparsedstrfloat);
                //string finalstr = substringofthehp.Substring(0, substringofthehp.Length - 1 - thefiledata1);//
                float theheightofthemob = resultparsedstrfloat;











                double theinitmobhp = thehpofthemob;

                float minrandm = 0.85f; //0.998f
                float maxrandm = 1.15f;//1.015f //0.999f

                float randhpmul = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandm, maxrandm, 1.0f, 0, -1);

                float diff = maxrandm - minrandm;
                randhpmul = minrandm + (diff * randhpmul);

                double thefinalhp = (double)Math.Round(theinitmobhp * randhpmul);

                ////Console.WriteLine("hp:" + thefinalhp);





                float theinitmobheight = theheightofthemob;

                float minrandheight = 0.985f; //0.998f
                float maxrandheight = 1.025f;//1.015f //0.999f

                float randheightmul = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandheight, maxrandheight, 1.0f, 0, -1);

                float diffheight = maxrandheight - minrandheight;
                randheightmul = minrandheight + (diffheight * randheightmul);

                float thefinalheight = (float)(theinitmobheight * randheightmul);

                ////Console.WriteLine("height:" + thefinalheight);





                double theinitmobmovespeed = thespeedofthemob;

                float minrandmovespeed = 0.985f; //0.998f
                float maxrandmovespeed = 1.025f;//1.015f //0.999f

                float randmovespeedmul = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandmovespeed, maxrandmovespeed, 1.0f, 0, -1);

                float diffmovespeed = maxrandmovespeed - minrandmovespeed;
                randmovespeedmul = minrandmovespeed + (diffmovespeed * randmovespeedmul);

                double thefinalmovespeed = (double)(theinitmobmovespeed * randmovespeedmul);

                thefinalmovespeed = Math.Round(thefinalmovespeed * 1000) / 1000;

                //Directory.CreateDirectory(filenamewithextmul + "Variant" + variantindex);
                File.Copy(arrayoforiginalscriptfilesMOB[i], filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", true);

                DirectoryInfo directoryFolder0 = new DirectoryInfo(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs");
                directoryFolder0.Refresh();








                string scriptcharacterskeletonstring = "Skeleton" + mobname;
                string scriptnamevariant = "Variant" + variantindex;

                //string themobhp = "StatDefaultHealthMax => " + thehpofthemob + ";";
                //string themobhpmodded = "StatDefaultHealthMax => " + thefinalhp + ";";

                //string themobheight = "CharacterWorldHeight => " + theheightofthemob + "f;";
                //string themobheightmodded = "CharacterWorldHeight => " + thefinalheight + "f;";

                //string themobmovespeed = "StatMoveSpeed => " + thespeedofthemob + ";";
                //string themobmovespeedmodded = "StatMoveSpeed => " + thefinalmovespeed + ";";

                string scriptvarnames = "class Mob" + mobname;
                string scriptstaticvar = "currentMob" + mobname + "Class";

                string scriptitemnames = "Mob" + mobname + "Sword";

                string replacethistoo = "static Mob" + mobname;




                string originalsub = substringoftheheight;
                substringoftheheight = substringoftheheight.Replace(theheightofthemob.ToString(), thefinalheight.ToString());
                //string substringoftheheight = readalltextstring.Substring(thefiledata, thehporiginal.Length + 32);

                //string readalltextstringfinalforheight = readalltextstring.Replace(originalsub, substringoftheheight);

                ////Console.WriteLine(thefinalheight);




                string substringofthehpori = substringofthehp;
                substringofthehp = substringofthehp.Replace(thehpofthemob.ToString(), thefinalhp.ToString());
                ////Console.WriteLine("/hpdoublestr:" + substringofthehp);          
                string originalsub1 = substringofthehpori;
                //string readalltextstringfinalforhp = readalltextstring.Replace(originalsub1, substringofthehp);








                //substringofthespeed1



                int adder = 0;
                int numbertoreach = 10;
                int themodulomul = 0;

                for (int n = 0; n < (int)(thefinalmovespeed); n++)
                {
                    if (adder >= numbertoreach)
                    {
                        themodulomul++;
                        adder = 0;
                    }
                    adder++;
                }


                string thefinalmovespeedstr = thefinalmovespeed.ToString(); //  2.015

                int maxdigit = 8;

                int digitsleft = maxdigit - adder;

                string zerostoadd = "";
                for (int a = 0; a < digitsleft; a++)
                {
                    zerostoadd += "0";
                }

                zerostoadd += thefinalmovespeedstr;

                /*
                double testingsomething = ;

                if ()
                {
                    
                }*/

                double swapthefinalmovespeed = thefinalmovespeed;

                int[] arrayofdigits = new int[3];

                for (int r = 0; r < 3; r++)
                {
                    double beforevalue = swapthefinalmovespeed;
                    double theremnantdigit = (int)(Math.Truncate((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10));
                    arrayofdigits[r] = (int)theremnantdigit;
                    swapthefinalmovespeed = ((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10);
                    //swapthefinalmovespeed = (int)(Math.Truncate((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10));
                    //arrayofdigits[r] = (int)swapthefinalmovespeed;// beforevalue
                }



                string substringofthespeedori = substringofthespeed1;
                substringofthespeed1 = substringofthespeed1.Replace(substringofthespeed1, zerostoadd);
                ////Console.WriteLine("/hpdoublestr:" + substringofthehp);          
                //string originalspeedsub1 = substringofthespeedori;
                //string readalltextstringfinalforspeed = readalltextstring.Replace(originalspeedsub1, substringofthespeed1);


                ////Console.WriteLine("originalspeedsub1:" + originalspeedsub1);
                ////Console.WriteLine("substringofthespeed1:" + substringofthespeed1);
                ////Console.WriteLine("thefinalmovespeed:" + thefinalmovespeed);
                ////Console.WriteLine("thespeedofthemob.ToString():" + thespeedofthemob.ToString());
                /*
                File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", File.ReadAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs").
                    Replace(originalsub1, substringofthehp).
                    Replace(originalsub, substringoftheheight).
                    Replace(substringofthespeedori, substringofthespeed1));*/

                /*
                File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", File.ReadAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs").
                 Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                 Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                 Replace(originalsub1, substringofthehp).
                 Replace(originalsub, substringoftheheight).
                 Replace(substringofthespeedori, substringofthespeed1).
                 Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                 Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                 Replace(replacethistoo, replacethistoo + scriptnamevariant));
                */

                /*
                if (mobname.ToLower() == "skeleton" || mobname.ToLower() == "zombie")
                {
                    File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", File.ReadAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs").
                Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                Replace(scriptcharacterskeletonstring, "SkeletonHuman").
                Replace(originalsub1, substringofthehp).
                Replace(originalsub, substringoftheheight).
                Replace(substringofthespeedori, substringofthespeed1).
                Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                Replace(replacethistoo, replacethistoo + scriptnamevariant));
                }
                else
                {
                    File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", File.ReadAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs").
                 Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                 Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                 Replace(originalsub1, substringofthehp).
                 Replace(originalsub, substringoftheheight).
                 Replace(substringofthespeedori, substringofthespeed1).
                 Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                 Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                 Replace(replacethistoo, replacethistoo + scriptnamevariant));
                }*/


                File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", File.ReadAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs").
                  Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                  Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                  Replace(originalsub1, substringofthehp).
                  Replace(originalsub, substringoftheheight).
                  Replace(substringofthespeedori, substringofthespeed1).
                  Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                  Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                  Replace(replacethistoo, replacethistoo + scriptnamevariant));










                //File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", readalltextstringfinalforhp);
                ////Console.WriteLine("hp:" + thehpofthemob + "/hpdoublestr:" + substringofthehp);













                /*
                //string scriptname = "MobSkeleton";
                string scriptcharacterskeletonstring = "Skeleton" + mobname;
                string scriptnamevariant = "Variant" + variantindex;

                string themobhp = "StatDefaultHealthMax => " + thehpofthemob + ";";
                string themobhpmodded = "StatDefaultHealthMax => " + thefinalhp + ";";


                ////Console.WriteLine(mobheight);


                string themobheight = "CharacterWorldHeight => " + theheightofthemob + "f;";
                string themobheightmodded = "CharacterWorldHeight => " + thefinalheight + "f;";

                string themobmovespeed = "StatMoveSpeed => " + thespeedofthemob + ";";
                string themobmovespeedmodded = "StatMoveSpeed => " + thefinalmovespeed + ";";


                string scriptvarnames = "class Mob" + mobname;
                string scriptstaticvar = "currentMob" + mobname + "Class";



                string scriptitemnames = "Mob" + mobname + "Sword";


                string replacethistoo = "static Mob" + mobname;

                File.WriteAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", File.ReadAllText(filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs").
                    Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                    Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                    Replace(themobhp, themobhpmodded).
                    Replace(themobheight, themobheightmodded).
                    Replace(themobmovespeed, themobmovespeedmodded).
                    Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                    Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                    Replace(replacethistoo, replacethistoo + scriptnamevariant));*/
            }
            //MODIFY THE MOB SCRIPT





            var arrayoforiginalscriptfilesCHARACTERSKELETON = Directory.GetFiles(pathtoscripts + @"\" + "CharacterSkeletons");

            //var arrayoforiginalscriptfilesCHARACTERSKELETON = Directory.GetFiles(finalpathmobskeletonscriptori);

            //MODIFY THE MOB CHARACTER SKELETON SCRIPT
            for (int i = 0; i < arrayoforiginalscriptfilesCHARACTERSKELETON.Length; i++)
            {
                string prefinalfilename = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscriptori.Length, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - finalpathmobskeletonscriptori.Length - 3));

                //string prefinalfilename = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscript.Length-2, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - 1 - finalpathmobskeletonscript.Length));
                string thefinalfilename = prefinalfilename + "Variant" + variantindex;

                ////Console.WriteLine(prefinalfilename);

                string filenamewithext = finalpathmobskeletonscript + (thefinalfilename) + ".cs";

                //////Console.WriteLine(finalfilename);
                File.Copy(arrayoforiginalscriptfilesCHARACTERSKELETON[i], filenamewithext, true);

                DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobskeletonscript);
                directoryFolder0.Refresh();

                //string scriptname = "MobSkeleton";
                string scriptcharacterskeletonstring = "Skeleton" + mobname;
                string scriptnamevariant = "Variant" + variantindex;

                string scriptcharacterskeletonpngpath = mobname + "/";
                string scriptcharacterskeletonpngpathreplacement = mobname;

                //string prefinalfilenamecorrect = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).Replace(scriptcharacterskeletonpngpath, scriptcharacterskeletonpngpathreplacement + scriptnamevariant + "/"));

                //prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));


            }
            //MODIFY THE MOB CHARACTER SKELETON SCRIPT





            var arrayoforiginalscriptfilesITEM = Directory.GetFiles(pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons");

            //var arrayoforiginalscriptfilesITEM = Directory.GetFiles(finalpathmobitemscriptori);

            //MODIFY THE MOB CHARACTER SKELETON SCRIPT
            for (int i = 0; i < arrayoforiginalscriptfilesITEM.Length; i++)
            {
                string prefinalfilename = arrayoforiginalscriptfilesITEM[i].Substring(finalpathmobitemscriptori.Length, (arrayoforiginalscriptfilesITEM[i].Length - finalpathmobitemscriptori.Length - 3));
                string thefinalfilename = prefinalfilename + "Variant" + variantindex;

                ////Console.WriteLine(prefinalfilename);

                string filenamewithext = finalpathmobitemscript + (thefinalfilename) + ".cs";

                ////Console.WriteLine(finalfilename);
                File.Copy(arrayoforiginalscriptfilesITEM[i], filenamewithext, true);

                DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobitemscript);
                directoryFolder0.Refresh();

                string scriptname = mobname + "Sword";

                //string scriptreplace0 = "Skeleton";
                //string scriptreplace1 = "Sword";
                //string scriptcharacterskeletonstring = "Skeleton" + mobname;
                string scriptnamevariant = "Variant" + variantindex;
                //string replacescriptname = "ItemWeaponMobSkeletonSword";

                //string scriptcharacterskeletonpngpath = "Skeleton/";
                //string scriptcharacterskeletonpngpathreplacement = "Skeleton";

                //string prefinalfilenamecorrect = arrayoforiginalscriptfilesITEM[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesITEM[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptname, scriptname + scriptnamevariant));
            }
            //MODIFY THE MOB CHARACTER SKELETON SCRIPT






            var arrayoforiginalscriptfilesSpawn = Directory.GetFiles(pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs");

            //var arrayoforiginalscriptfilesSpawn = Directory.GetFiles(finalpathmobzonescriptori);
            //MODIFY THE MOB CHARACTER SKELETON SCRIPT
            for (int i = 0; i < arrayoforiginalscriptfilesSpawn.Length; i++)
            {

                string prefinalfilename = arrayoforiginalscriptfilesSpawn[i].Substring(finalpathmobzonescriptori.Length, (arrayoforiginalscriptfilesSpawn[i].Length - finalpathmobzonescriptori.Length - 3));

                //string prefinalfilename = arrayoforiginalscriptfilesSpawn[i].Substring(finalpathmobzonescript.Length, (arrayoforiginalscriptfilesSpawn[i].Length - finalpathmobzonescript.Length - 4));
                //string prefinalfilename = arrayoforiginalscriptfilesSpawn[i].Substring(finalpathmobzonescript.Length - 2, (arrayoforiginalscriptfilesSpawn[i].Length - 1 - finalpathmobzonescript.Length));
                string thefinalfilename = prefinalfilename + "Variant" + variantindex;

                ////Console.WriteLine(prefinalfilename);

                string filenamewithext = finalpathmobzonescript + (thefinalfilename) + ".cs";

                //////Console.WriteLine(finalfilename);
                File.Copy(arrayoforiginalscriptfilesSpawn[i], filenamewithext, true);

                DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobzonescript);
                directoryFolder0.Refresh();

                string scriptname = "Mob" + mobname;
                string thescriptname = "SpawnMobs" + mobname;

                //string scriptcharacterskeletonstring = "Skeleton" + mobname;
                string scriptnamevariant = "Variant" + variantindex;

                //string scriptcharacterskeletonpngpath = "Skeleton/";
                //string scriptcharacterskeletonpngpathreplacement = "Skeleton";

                //string prefinalfilenamecorrect = arrayoforiginalscriptfilesITE[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesITEM[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptname, scriptname + scriptnamevariant).Replace(thescriptname, thescriptname + scriptnamevariant));
            }
            //MODIFY THE MOB CHARACTER SKELETON SCRIPT







            //AT VARIANT INDEX 0, ALSO COPY THE ORIGINAL FILES
            if (variantindex == 0)
            {
                //MODIFY THE MOB SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesMOB.Length; i++)
                {


                    var prefinalfilename1 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    var thefinalfilename1 = prefinalfilename1;

                    var filenamewithext1 = finalpathmobscript + (thefinalfilename1) + ".cs";




                    //////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalscriptfilesMOB[i], filenamewithext1, true);



                    DirectoryInfo directoryFolder0 = new DirectoryInfo(filenamewithext1);
                    directoryFolder0.Refresh();


                }
                //MODIFY THE MOB SCRIPT





                //var arrayoforiginalscriptfilesCHARACTERSKELETON = Directory.GetFiles(pathtoscripts + @"\" + "CharacterSkeletons");

                //var arrayoforiginalscriptfilesCHARACTERSKELETON = Directory.GetFiles(finalpathmobskeletonscriptori);

                //MODIFY THE MOB CHARACTER SKELETON SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesCHARACTERSKELETON.Length; i++)
                {
                    string prefinalfilename = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscriptori.Length, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - finalpathmobskeletonscriptori.Length - 3));

                    //string prefinalfilename = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscript.Length-2, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - 1 - finalpathmobskeletonscript.Length));
                    string thefinalfilename = prefinalfilename;

                    ////Console.WriteLine(prefinalfilename);

                    string filenamewithext = finalpathmobskeletonscript + (thefinalfilename) + ".cs";

                    //////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalscriptfilesCHARACTERSKELETON[i], filenamewithext, true);

                    DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobskeletonscript);
                    directoryFolder0.Refresh();

                    //string scriptname = "MobSkeleton";
                    string scriptcharacterskeletonstring = "Skeleton" + mobname;
                    string scriptnamevariant = "Variant" + variantindex;

                    string scriptcharacterskeletonpngpath = mobname + "/";
                    string scriptcharacterskeletonpngpathreplacement = mobname;

                    //string prefinalfilenamecorrect = arrayoforiginalscriptfilesCHARACTERSKELETON[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesCHARACTERSKELETON[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                    File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring).Replace(scriptcharacterskeletonpngpath, scriptcharacterskeletonpngpathreplacement + "/"));
                }
                //MODIFY THE MOB CHARACTER SKELETON SCRIPT








                //var arrayoforiginalscriptfilesITEM = Directory.GetFiles(pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons");

                //var arrayoforiginalscriptfilesITEM = Directory.GetFiles(finalpathmobitemscriptori);

                //MODIFY THE MOB CHARACTER SKELETON SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesITEM.Length; i++)
                {
                    string prefinalfilename = arrayoforiginalscriptfilesITEM[i].Substring(finalpathmobitemscriptori.Length, (arrayoforiginalscriptfilesITEM[i].Length - finalpathmobitemscriptori.Length - 3));
                    string thefinalfilename = prefinalfilename;

                    ////Console.WriteLine(prefinalfilename);

                    string filenamewithext = finalpathmobitemscript + (thefinalfilename) + ".cs";

                    ////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalscriptfilesITEM[i], filenamewithext, true);

                    DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobitemscript);
                    directoryFolder0.Refresh();



                    string scriptname = mobname + "Sword";


                    //string scriptreplace0 = "Skeleton";
                    //string scriptreplace1 = "Sword";
                    //string scriptcharacterskeletonstring = "Skeleton" + mobname;
                    string scriptnamevariant = "Variant" + variantindex;
                    //string replacescriptname = "ItemWeaponMobSkeletonSword";

                    //string scriptcharacterskeletonpngpath = "Skeleton/";
                    //string scriptcharacterskeletonpngpathreplacement = "Skeleton";

                    //string prefinalfilenamecorrect = arrayoforiginalscriptfilesITEM[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesITEM[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                    File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptname, scriptname));
                }
                //MODIFY THE MOB CHARACTER SKELETON SCRIPT






                //var arrayoforiginalscriptfilesSpawn = Directory.GetFiles(pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs");

                //var arrayoforiginalscriptfilesSpawn = Directory.GetFiles(finalpathmobzonescriptori);
                //MODIFY THE MOB CHARACTER SKELETON SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesSpawn.Length; i++)
                {

                    string prefinalfilename = arrayoforiginalscriptfilesSpawn[i].Substring(finalpathmobzonescriptori.Length, (arrayoforiginalscriptfilesSpawn[i].Length - finalpathmobzonescriptori.Length - 3));

                    //string prefinalfilename = arrayoforiginalscriptfilesSpawn[i].Substring(finalpathmobzonescript.Length, (arrayoforiginalscriptfilesSpawn[i].Length - finalpathmobzonescript.Length - 4));
                    //string prefinalfilename = arrayoforiginalscriptfilesSpawn[i].Substring(finalpathmobzonescript.Length - 2, (arrayoforiginalscriptfilesSpawn[i].Length - 1 - finalpathmobzonescript.Length));
                    string thefinalfilename = prefinalfilename;

                    ////Console.WriteLine(prefinalfilename);

                    string filenamewithext = finalpathmobzonescript + (thefinalfilename) + ".cs";

                    //////Console.WriteLine(finalfilename);
                    File.Copy(arrayoforiginalscriptfilesSpawn[i], filenamewithext, true);

                    DirectoryInfo directoryFolder0 = new DirectoryInfo(finalpathmobzonescript);
                    directoryFolder0.Refresh();

                    string scriptname = "Mob" + mobname;
                    string thescriptname = "SpawnMobs" + mobname;

                    //string scriptcharacterskeletonstring = "Skeleton" + mobname;
                    string scriptnamevariant = "Variant" + variantindex;

                    //string scriptcharacterskeletonpngpath = "Skeleton/";
                    //string scriptcharacterskeletonpngpathreplacement = "Skeleton";

                    //string prefinalfilenamecorrect = arrayoforiginalscriptfilesITE[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesITEM[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

                    File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptname, scriptname).Replace(thescriptname, thescriptname));
                }
                //MODIFY THE MOB CHARACTER SKELETON SCRIPT
            }
        }






















        public void createvariantscriptsfororiginalmobsCHARACTERscripts(int variantindex, string mobname, string pathtoscripts, string pathtoscriptsmul, string themodfoldernamewithoutextension, int thetypeofgenerator)// double mobspeed, double mobhp, float mobheight
        {

            var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

            //GET PATH TO #Cryofallscriptgen
            string pathToDesktop = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //////Console.WriteLine("2_mainThreadStarter");
            string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
            DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
            directoryFolder.Refresh();
            //string pathToDesktopFolder = pathToDesktop + @"\" + folderName;

            //C: \Users\steve\Desktop\#Cryofallscriptgen\original\Skeleton.mpk\Scripts

            ////Console.WriteLine(pathtoscripts);
            string folderNamemulPNGS = "multiplied";
            string folderNameOriginalPNGS = "original";

            //string folderNamemulPNGS = "multiplied";// + @"\" + "Skeleton" + "Variant" + variantindex;
            string themobfolder = mobname + "Variant" + variantindex;

          

            if (thetypeofgenerator == 0) //mob character scripts
            {
                var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "Characters" + @"\" + "Mobs");

                ////Console.WriteLine(pathtoscripts);

                string finalpathmobscript = pathtoscriptsmul + @"\" + "Characters" + @"\" + "Mobs" + @"\";
                string finalpathmobskeletonscript = pathtoscriptsmul + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobitemscript = pathtoscriptsmul + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
                string finalpathmobzonescript = pathtoscriptsmul + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";

                string finalpathmobscriptori = pathtoscripts + @"\" + "Characters" + @"\" + "Mobs" + @"\";
                string finalpathmobskeletonscriptori = pathtoscripts + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobitemscriptori = pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
                string finalpathmobzonescriptori = pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";


                Directory.CreateDirectory(finalpathmobscript);
                Directory.CreateDirectory(finalpathmobskeletonscript);
                Directory.CreateDirectory(finalpathmobitemscript);
                Directory.CreateDirectory(finalpathmobzonescript);



                //MODIFY THE MOB SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesMOB.Length; i++)
                {
                    var prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    var thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                    var filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                    string prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/prefinalfilename0:" + prefinalfilename0, "sccsmsg", 0);

                    if (prefinalfilename.ToLower() == "mob" + mobname.ToLower()) // && mobname.ToLower() == "bearpolar"
                    {
                        //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename0.ToLower() == mobname.ToLower()", "sccsmsg", 0);
                        //sccsr16.Program.MessageBox((IntPtr)0, "mobname.ToLower() == \"bearpolar\"", "sccsmsg", 0);






                        string thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                        string filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";

                        var readalltextstring = File.ReadAllText(filenamewithext);

                        string thehporiginal = "StatDefaultHealthMax => ";

                        var thefiledata = File.ReadAllText(filenamewithext).IndexOf(thehporiginal);

                        string substringofthehealth = readalltextstring.Substring(thefiledata, 64);

                        string theendofline = ";";
                        string thearrow = "=>";

                        var thefiledata1 = substringofthehealth.IndexOf(theendofline);
                        var thefiledata2 = substringofthehealth.IndexOf(thearrow);

                        string substringofthehp = substringofthehealth.Substring(thefiledata2 + thearrow.Length + 1, 32);
                        double resultparsedstr;
                        double.TryParse(substringofthehp, out resultparsedstr);
                        double thehpofthemob = resultparsedstr;




                        ////Console.WriteLine("hp:" + thehpofthemob + "/hpdoublestr:" + substringofthehp);









                        prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                        thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                        filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                        prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                        thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                        filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";

                        readalltextstring = File.ReadAllText(filenamewithext);


                        /*
                        if (mobname.ToLower() == "thumper")
                        {
                            thehporiginal = "StatMoveSpeedNormal => ";
                            
                        }
                        else
                        {
                            thehporiginal = "StatMoveSpeed => ";
                        }
                        */

                        thehporiginal = "StatMoveSpeed => ";


                        //string substringofthespeed1 = "";



                        thefiledata = File.ReadAllText(filenamewithext).IndexOf(thehporiginal);

                        substringofthehealth = readalltextstring.Substring(thefiledata, 64);

                        //Console.WriteLine("substringofthehealth:" + substringofthehealth);




                        theendofline = ";";
                        thearrow = "=>";

                        thefiledata1 = substringofthehealth.IndexOf(theendofline);
                        thefiledata2 = substringofthehealth.IndexOf(thearrow);

                        string substringofthespeed1 = substringofthehealth.Substring(thefiledata2 + thearrow.Length + 1 + 24, 8 + 4);
                        //double resultparsedstr;
                        double.TryParse(substringofthespeed1, out resultparsedstr);

                        //resultparsedstr = (float)resultparsedstr;
                        



                        double thespeedofthemob = resultparsedstr + 0.0;





                        //Console.WriteLine("thespeedofthemob:" + thespeedofthemob);

                        //Console.WriteLine("substringofthespeed1:" + substringofthespeed1);




                        //prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));
                        //thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;
                        //filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";



                        prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                        thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                        filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";
                        string filenamewithextmul = finalpathmobscript; // + (thefinalfilename) + ".cs"

                        string pathoffile = filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs";


                        readalltextstring = File.ReadAllText(filenamewithext);

                        thehporiginal = "CharacterWorldHeight => ";

                        thefiledata = File.ReadAllText(filenamewithext).IndexOf(thehporiginal);

                        string substringoftheheight = readalltextstring.Substring(thefiledata + thehporiginal.Length, 32 + 4);




                        float resultparsedstrfloat;
                        float.TryParse(substringoftheheight, out resultparsedstrfloat);
                        //string finalstr = substringofthehp.Substring(0, substringofthehp.Length - 1 - thefiledata1);//
                        float theheightofthemob = resultparsedstrfloat;











                        double theinitmobhp = thehpofthemob;

                        float minrandm = 0.85f; //0.998f
                        float maxrandm = 1.15f;//1.015f //0.999f

                        float randhpmul = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandm, maxrandm, 1.0f, 0, -1);

                        float diff = maxrandm - minrandm;
                        randhpmul = minrandm + (diff * randhpmul);

                        double thefinalhp = (double)Math.Round(theinitmobhp * randhpmul);

                        ////Console.WriteLine("hp:" + thefinalhp);





                        float theinitmobheight = theheightofthemob;

                        float minrandheight = 0.985f; //0.998f
                        float maxrandheight = 1.025f;//1.015f //0.999f

                        float randheightmul = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandheight, maxrandheight, 1.0f, 0, -1);

                        float diffheight = maxrandheight - minrandheight;
                        randheightmul = minrandheight + (diffheight * randheightmul);

                        float thefinalheight = (float)(theinitmobheight * randheightmul);

                        ////Console.WriteLine("height:" + thefinalheight);











                        double theinitmobmovespeed = thespeedofthemob;

                        float minrandmovespeed = 0.985f; //0.998f
                        float maxrandmovespeed = 1.025f;//1.015f //0.999f

                        float randmovespeedmul = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandmovespeed, maxrandmovespeed, 1.0f, 0, -1);

                        float diffmovespeed = maxrandmovespeed - minrandmovespeed;
                        randmovespeedmul = minrandmovespeed + (diffmovespeed * randmovespeedmul);

                        double thefinalmovespeed = (double)(theinitmobmovespeed * randmovespeedmul);

                        thefinalmovespeed = Math.Round(thefinalmovespeed * 1000) / 1000;














                        thefinalhp = System.Math.Round(thefinalhp);
                        thefinalheight = (float)System.Math.Round(thefinalheight);
                        thefinalmovespeed = System.Math.Round(thefinalmovespeed);

                        string thefinalheightstring = thefinalheight.ToString();
                        string thefinalhpstring = thefinalhp.ToString();
                        string thefinalmovespeedstring = thefinalmovespeed.ToString();

                        
                        /*if (thefinalheight - System.Math.Round(thefinalheight) == 0)
                        {
                            if (!thefinalheightstring.Contains("."))
                            {
                                thefinalheightstring += ".";
                            }
                        }

                        if (thefinalhp - System.Math.Round(thefinalhp) == 0)
                        {
                            if (!thefinalhpstring.Contains("."))
                            {
                                thefinalhpstring += ".";
                            }
                        }*/

                        if (thefinalmovespeed - System.Math.Round(thefinalmovespeed) == 0)
                        {
                            if (!thefinalmovespeedstring.Contains("."))
                            {
                                thefinalmovespeedstring += ".";
                            }
                        }
                        


                        /*
                        IEnumerable<char> stringQuery =
                                                         from ch in thefinalmovespeedstring
                                                         where Char.IsDigit(ch)
                                                         select ch;
                        */








                        /*
                        if (thefinalheight - System.Math.Round(thefinalheight) == 0)
                        {
                            thefinalheightstring += ".";
                        }

                        if (thefinalhp - System.Math.Round(thefinalhp) == 0)
                        {
                            thefinalhpstring += ".";
                        }

                        if (thefinalmovespeed - System.Math.Round(thefinalmovespeed) == 0)
                        {
                            thefinalmovespeedstring += ".";
                        }
                        */





















                        //Directory.CreateDirectory(filenamewithextmul + "Variant" + variantindex);

                        File.Copy(arrayoforiginalscriptfilesMOB[i], pathoffile, true);
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(pathoffile);
                        directoryFolder0.Refresh();








                        string scriptcharacterskeletonstring = "Skeleton" + mobname;
                        string scriptnamevariant = "Variant" + variantindex;

                        //string themobhp = "StatDefaultHealthMax => " + thehpofthemob + ";";
                        //string themobhpmodded = "StatDefaultHealthMax => " + thefinalhp + ";";

                        //string themobheight = "CharacterWorldHeight => " + theheightofthemob + "f;";
                        //string themobheightmodded = "CharacterWorldHeight => " + thefinalheight + "f;";

                        //string themobmovespeed = "StatMoveSpeed => " + thespeedofthemob + ";";
                        //string themobmovespeedmodded = "StatMoveSpeed => " + thefinalmovespeed + ";";


                        Console.WriteLine("#####" + mobname + "#####");

                        string scriptvarnames = "class Mob" + mobname;


                        /*string scriptstaticvar = "currentMob" + mobname + "Class";
                        string scriptitemnames = "Mob" + mobname + "Sword";
                        */

                        /*if ()
                        {
                            "ItemWeaponMobBearClaws"
                        }*/
                        //MobBearClaws










                        string replacethistoo = "static Mob" + mobname;




                        string originalsub = substringoftheheight;
                        substringoftheheight = substringoftheheight.Replace(theheightofthemob.ToString(), thefinalheightstring);
                        //string substringoftheheight = readalltextstring.Substring(thefiledata, thehporiginal.Length + 32);

                        //string readalltextstringfinalforheight = readalltextstring.Replace(originalsub, substringoftheheight);

                        ////Console.WriteLine(thefinalheight);




                        string substringofthehpori = substringofthehp;
                        substringofthehp = substringofthehp.Replace(thehpofthemob.ToString(), thefinalhpstring);
                        ////Console.WriteLine("/hpdoublestr:" + substringofthehp);          
                        string originalsub1 = substringofthehpori;
                        //string readalltextstringfinalforhp = readalltextstring.Replace(originalsub1, substringofthehp);

                        //substringofthespeed1

                        int adder = 0;
                        int numbertoreach = 10;
                        int themodulomul = 0;

                        for (int n = 0; n < (int)(thefinalmovespeed); n++)
                        {
                            if (adder >= numbertoreach)
                            {
                                themodulomul++;
                                adder = 0;
                            }
                            adder++;
                        }

                        string thefinalmovespeedstr = thefinalmovespeedstring; //  2.015

                        int maxdigit = 8;

                        int digitsleft = maxdigit - adder;

                        string zerostoadd = "";
                        for (int a = 0; a < digitsleft; a++)
                        {
                            zerostoadd += "0";
                        }

                        zerostoadd += thefinalmovespeedstr;

                        double swapthefinalmovespeed = thefinalmovespeed;

                        int[] arrayofdigits = new int[3];

                        for (int r = 0; r < 3; r++)
                        {
                            double beforevalue = swapthefinalmovespeed;
                            double theremnantdigit = (int)(Math.Truncate((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10));
                            arrayofdigits[r] = (int)theremnantdigit;
                            swapthefinalmovespeed = ((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10);
                            //swapthefinalmovespeed = (int)(Math.Truncate((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10));
                            //arrayofdigits[r] = (int)swapthefinalmovespeed;// beforevalue
                        }

                        string substringofthespeedori = substringofthespeed1;
                        substringofthespeed1 = substringofthespeed1.Replace(substringofthespeed1, zerostoadd);

                        //string upperfirst = mobname;
                        //string firstletter = mobname.Substring(0,1);
                        //upperfirst = upperfirst.Substring(1, upperfirst.Length-1);
                        //upperfirst += firstletter.ToUpper();
                        //Console.WriteLine(firstletter);

                        string theclassmobori = "class Mob" + mobname;
                        string theclassmoborislim = "class Mob" + mobname;

                        string theclassmobmod = theclassmoborislim + "Variant" + variantindex;

                        //Console.WriteLine("theclassmobori:" + theclassmobori + "/theclassmobori:" + theclassmobori + scriptnamevariant);
                        //Console.WriteLine("theclassmobori:" + theclassmobori);//
                        //Console.WriteLine(pathoffile);


                        //File.Copy(arrayoforiginalscriptfilesMOB[i], pathoffile, true);


                        Console.WriteLine("theclassmobmod:" + theclassmobmod + "/scriptvarnames:" + scriptvarnames);//

                        //File.WriteAllText(pathoffile, File.ReadAllText(arrayoforiginalscriptfilesMOB[i]).
                        //Replace(theclassmobori, theclassmobori + "Variant" + variantindex));

                        /*
                         string thescriptmodded = File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                          Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                          Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                          Replace(originalsub1, substringofthehp).
                          Replace(originalsub, substringoftheheight).
                          Replace(substringofthespeedori, substringofthespeed1).
                          //Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                          //Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                          Replace(replacethistoo, replacethistoo + scriptnamevariant);

                         File.WriteAllText(pathoffile, thescriptmodded);
                        */

                        /*
                        File.WriteAllText(pathoffile, File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                          Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                          Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                          Replace(originalsub1, substringofthehp).
                          Replace(originalsub, substringoftheheight).
                          Replace(substringofthespeedori, substringofthespeed1).
                          //Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                          //Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                          Replace(replacethistoo, replacethistoo + scriptnamevariant));*/


                        /*
                        File.WriteAllText(pathoffile,
                            File.ReadAllText(pathoffile).
                            Replace(theclassmobori, theclassmobmod));*/

                        /*
                        if (mobname.ToLower() == "skeleton" || mobname.ToLower() == "zombie")
                        {
                            File.WriteAllText(pathoffile, File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                             Replace(theclassmobori, theclassmobmod).
                             Replace(scriptcharacterskeletonstring, "SkeletonHuman").
                             Replace(originalsub1, substringofthehp).
                             Replace(originalsub, substringoftheheight).
                             Replace(substringofthespeedori, substringofthespeed1).
                             //Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                             //Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                             Replace(replacethistoo, replacethistoo + scriptnamevariant));
                        }
                        else
                        {
                            File.WriteAllText(pathoffile, File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                            Replace(theclassmobori, theclassmobmod).
                            Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                            Replace(originalsub1, substringofthehp).
                            Replace(originalsub, substringoftheheight).
                            Replace(substringofthespeedori, substringofthespeed1).
                            //Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                            //Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                            Replace(replacethistoo, replacethistoo + scriptnamevariant));
                        }*/


                        File.WriteAllText(pathoffile, File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                           Replace(theclassmobori, theclassmobmod).
                           Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                           Replace(originalsub1, substringofthehp).
                           Replace(originalsub, substringoftheheight).
                           Replace(substringofthespeedori, substringofthespeed1).
                           //Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                           //Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                           Replace(replacethistoo, replacethistoo + scriptnamevariant));


                    }
                }
            }
            else if (thetypeofgenerator == 1)//mob skeleton scripts
            {

                /*
                var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "Characters" + @"\" + "Mobs");

                ////Console.WriteLine(pathtoscripts);

                string finalpathmobscript = pathtoscriptsmul + @"\" + "Characters" + @"\" + "Mobs" + @"\";
                string finalpathmobskeletonscript = pathtoscriptsmul + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobitemscript = pathtoscriptsmul + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
                string finalpathmobzonescript = pathtoscriptsmul + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";

                string finalpathmobscriptori = pathtoscripts + @"\" + "Characters" + @"\" + "Mobs" + @"\";
                string finalpathmobskeletonscriptori = pathtoscripts + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobitemscriptori = pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
                string finalpathmobzonescriptori = pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";


                Directory.CreateDirectory(finalpathmobscript);
                Directory.CreateDirectory(finalpathmobskeletonscript);
                Directory.CreateDirectory(finalpathmobitemscript);
                Directory.CreateDirectory(finalpathmobzonescript);*/

                string finalpathmobscriptori = pathtoscripts + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobscript = pathtoscriptsmul + @"\" + "CharacterSkeletons" + @"\";

                var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "CharacterSkeletons");

                //sccsr16.Program.MessageBox((IntPtr)0, "length:"+ arrayoforiginalscriptfilesMOB.Length, "sccsmsg", 0);

                //MODIFY THE MOB SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesMOB.Length; i++)
                {
                    var prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    var thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                    var filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                    string prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/prefinalfilename0:" + prefinalfilename0, "sccsmsg", 0);

                    if (prefinalfilename.ToLower() == "skeleton" + mobname.ToLower()) // && mobname.ToLower() == "bearpolar"
                    {
                        //sccsr16.Program.MessageBox((IntPtr)0, "test", "sccsmsg", 0);


                        prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                        string thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                        string filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";
                        string filenamewithextmul = finalpathmobscript; // + (thefinalfilename) + ".cs"

                        string pathoffile = filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs";

                        string theclassmobori = "class Skeleton" + mobname;
                        string theclassmoborislim = "class Skeleton" + mobname;
                        string theclassmobmod = theclassmoborislim + "Variant" + variantindex;

                        //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/pathoffile:" + pathoffile, "sccsmsg", 0);


                        string theskeletonresourceback = mobname + "/Back";
                        string theskeletonresourcefront = mobname + "/Front";

                        string theskeletonresourcebackvariant = mobname + "Variant" + variantindex + "/Back";
                        string theskeletonresourcefrontvariant = mobname + "Variant" + variantindex + "/Front";

                        //THE SKELETON SCRIPT COPY
                        //Directory.CreateDirectory(filenamewithextmul + "Variant" + variantindex);
                        File.Copy(arrayoforiginalscriptfilesMOB[i], pathoffile, true);
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(pathoffile);
                        directoryFolder0.Refresh();



                        File.WriteAllText(pathoffile, File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                        Replace(theclassmobori, theclassmobmod).
                        Replace(theskeletonresourceback, theskeletonresourcebackvariant).
                        Replace(theskeletonresourcefront, theskeletonresourcefrontvariant));
                    }
                }
            }
            else if (thetypeofgenerator == 2) //mob zone spawn scripts
            {

                /*
                var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "Characters" + @"\" + "Mobs");

                ////Console.WriteLine(pathtoscripts);

                string finalpathmobscript = pathtoscriptsmul + @"\" + "Characters" + @"\" + "Mobs" + @"\";
                string finalpathmobskeletonscript = pathtoscriptsmul + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobitemscript = pathtoscriptsmul + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
                string finalpathmobzonescript = pathtoscriptsmul + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";

                string finalpathmobscriptori = pathtoscripts + @"\" + "Characters" + @"\" + "Mobs" + @"\";
                string finalpathmobskeletonscriptori = pathtoscripts + @"\" + "CharacterSkeletons" + @"\";
                string finalpathmobitemscriptori = pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons" + @"\";
                string finalpathmobzonescriptori = pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + "Mobs" + @"\";


                Directory.CreateDirectory(finalpathmobscript);
                Directory.CreateDirectory(finalpathmobskeletonscript);
                Directory.CreateDirectory(finalpathmobitemscript);
                Directory.CreateDirectory(finalpathmobzonescript);*/

                string finalpathmobscriptori = pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + @"\" + "Mobs" + @"\";
                string finalpathmobscript = pathtoscriptsmul + @"\" + "Zones" + @"\" + "Scripts" + @"\" + @"\" + "Mobs" + @"\";

                var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + @"\" + "Mobs" + @"\");



                //sccsr16.Program.MessageBox((IntPtr)0, "length:"+ arrayoforiginalscriptfilesMOB.Length, "sccsmsg", 0);



                //MODIFY THE MOB SPAWN SCRIPT
                for (int i = 0; i < arrayoforiginalscriptfilesMOB.Length; i++)
                {
                    var prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    var thefinalfilename0 = prefinalfilename0 + "Variant" + variantindex;

                    var filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                    string prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                    //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/prefinalfilename0:" + prefinalfilename0, "sccsmsg", 0);


                    if (prefinalfilename.ToLower() == "spawnmobs" + mobname.ToLower()) // && mobname.ToLower() == "bearpolar"
                    {
                        //sccsr16.Program.MessageBox((IntPtr)0, "test", "sccsmsg", 0);


                        prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                        string thefinalfilename = prefinalfilename; // + "Variant" + variantindex

                        string filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";
                        string filenamewithextmul = finalpathmobscript; // + (thefinalfilename) + ".cs"

                        string pathoffile = filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs";

                        string theclassmobori = "class SpawnMobs" + mobname;
                        string theclassmoborislim = "class SpawnMobs" + mobname;
                        string theclassmobmod = theclassmoborislim + "Variant" + variantindex;

                        //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/pathoffile:" + pathoffile, "sccsmsg", 0);


                        /*string theskeletonresourceback = mobname + "/Back";
                        string theskeletonresourcefront = mobname + "/Front";

                        string theskeletonresourcebackvariant = mobname + "Variant" + variantindex + "/Back";
                        string theskeletonresourcefrontvariant = mobname + "Variant" + variantindex + "/Front";
                        */

                        string spawnstring = "AddExact<Mob" + mobname;
                        string spawnstringvariant = "AddExact<Mob" + mobname + "Variant" + variantindex;

                        //Directory.CreateDirectory(filenamewithextmul + "Variant" + variantindex);
                        File.Copy(arrayoforiginalscriptfilesMOB[i], pathoffile, true);
                        DirectoryInfo directoryFolder0 = new DirectoryInfo(pathoffile);
                        directoryFolder0.Refresh();



                        File.WriteAllText(pathoffile, File.ReadAllText(pathoffile).//arrayoforiginalscriptfilesMOB[i]).
                        Replace(theclassmobori, theclassmobmod).
                        Replace(spawnstring, spawnstringvariant));




                        //Replace(theskeletonresourceback, theskeletonresourcebackvariant).
                        //Replace(theskeletonresourcefront, theskeletonresourcefrontvariant));
                    }
                }
            }
        }










        public override sccsmessageobjectjitter[][] initscriptvariables(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            //Console.WriteLine("sccsgraphicssec init_update_variables");
            return _sc_jitter_tasks;
        }


        public override sccsmessageobjectjitter[][] createworldobjects(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            //Console.WriteLine("sccsgraphicssec _sc_create_world_objects");


            return _sc_jitter_tasks;
        }


        public override sccsmessageobjectjitter[][] Update(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            ////Console.WriteLine("sccsgraphicssec Update");

            //_sc_jitter_tasks = sccsgraphicssec._sc_create_world_objects(_sc_jitter_tasks);

            return _sc_jitter_tasks;
        }


        protected override sccsmessageobjectjitter[][] looprigidbody(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            //Console.WriteLine("sccsgraphicssec loop_worlds");

            return _sc_jitter_tasks;
        }

        protected override sccsmessageobjectjitter[][] workOnSomething(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            //Console.WriteLine("sccsgraphicssec workOnSomething");

            return _sc_jitter_tasks;
        }


        protected override sccsmessageobjectjitter[][] writetobuffer(sccsmessageobjectjitter[][] _sc_jitter_tasks)
        {
            //Console.WriteLine("sccsgraphicssec sc_write_to_buffer");


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












/*//front only
else if (removetheextensionfrommobname.ToLower() != "spitter" &&
removetheextensionfrommobname.ToLower() != "crab" &&
removetheextensionfrommobname.ToLower() != "psigrove" &&
removetheextensionfrommobname.ToLower() != "starfish" &&
    removetheextensionfrommobname.ToLower() != "thumper")
{

    string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
    string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
    string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
    string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
    string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

    for (int i = 0; i < numberofvariants; i++)
    {

        if (debugtoconsole == 1)
        {
            Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character skeleton script" + removetheextensionfrommobname.ToLower() + ".");
        }
        createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 1);

        if (debugtoconsole == 1)
        {
            Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character skeleton script" + removetheextensionfrommobname.ToLower() + ".");
        }
    }
}
else
{

}*/



/*

//no back no front.
if (removetheextensionfrommobname.ToLower() == "broodnest" ||
    removetheextensionfrommobname.ToLower() == "floater")
{

}
else
{

}*/




/*
//front only
else if (removetheextensionfrommobname.ToLower() != "spitter" &&
removetheextensionfrommobname.ToLower() != "crab" &&
removetheextensionfrommobname.ToLower() != "psigrove" &&
removetheextensionfrommobname.ToLower() != "starfish" &&
removetheextensionfrommobname.ToLower() != "thumper")
{

    string pathtoanimations = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
    string pathtoanimationsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname;
    string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Content\\Animations\\" + removetheextensionfrommobname + "\\images"; //back/male and /front/male
    string pathtoscripts = prefinalpathtofiles + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";
    string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodtogetmobsfrom + ".mpk" + "\\Scripts";

    for (int i = 0; i < numberofvariants; i++)
    {

        if (debugtoconsole == 1)
        {
            Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character script" + removetheextensionfrommobname.ToLower() + ".");
        }
        createvariantscriptsfororiginalmobsCHARACTERscripts(i, removetheextensionfrommobname, pathtoscripts, pathtoscriptsmul, removetheextensionfrommobname, 0);

        if (debugtoconsole == 1)
        {
            Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob character script" + removetheextensionfrommobname.ToLower() + ".");
        }
    }
}
else
{

}*/

/*//no back no front.
if (removetheextensionfrommobname.ToLower() == "broodnest" ||
    removetheextensionfrommobname.ToLower() == "floater")
{
    createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 2);

}
//front only
else if (removetheextensionfrommobname.ToLower() != "spitter" &&
    removetheextensionfrommobname.ToLower() != "crab" &&
    removetheextensionfrommobname.ToLower() != "psigrove" &&
    removetheextensionfrommobname.ToLower() != "starfish")
{
    if (debugtoconsole == 1)
    {
        Console.WriteLine("start creating Content/ variants " + i + " color for the original mob " + removetheextensionfrommobname.ToLower() + ".");
    }

    createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0);
    createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 1);

}
else
{
    if (removetheextensionfrommobname.ToLower() == "spitter" ||
        removetheextensionfrommobname.ToLower() == "crab" ||
        removetheextensionfrommobname.ToLower() == "psigrove" ||
        removetheextensionfrommobname.ToLower() == "starfish")
    {

        if (removetheextensionfrommobname.ToLower() == "spitter")
        {
            createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0);
        }
        else if (removetheextensionfrommobname.ToLower() == "crab")
        {
            createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0);

        }
        else if (removetheextensionfrommobname.ToLower() == "psigrove")
        {
            createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0);
        }
        else if (removetheextensionfrommobname.ToLower() == "starfish")
        {
            createvariantpngsnew(i, pathtoanimationpngs, removetheextensionfrommobname, 1, removetheextensionfrommobname, 0);
        }
    }
}*/






/*byte originalg = textureByteArray[bytePoser + 0];
byte originalb = textureByteArray[bytePoser + 1];
byte originalr = textureByteArray[bytePoser + 2];

float percentg = (textureByteArray[bytePoser + 0] / 255);
float percentb = (textureByteArray[bytePoser + 1] / 255);
float percentr = (textureByteArray[bytePoser + 2] / 255);


byte valuereducedtoahundredg = (byte)(255 * percentg);
byte valuereducedtoahundredb = (byte)(255 * percentg);
byte valuereducedtoahundredr = (byte)(255 * percentg);

 //byte invertblueandgreen = textureByteArray[bytePoser + 0];
 //byte invertgreenandblue = textureByteArray[bytePoser + 1];

 //textureByteArray[bytePoser + 0] = (byte)((int)(invertgreenandblue * brightnessmultiplierg * lastbrightnessmul));
 //textureByteArray[bytePoser + 1] = (byte)((int)(invertblueandgreen * brightnessmultiplierb * lastbrightnessmul));
 //textureByteArray[bytePoser + 2] = (byte)((int)(textureByteArray[bytePoser + 2] * brightnessmultiplierr * lastbrightnessmul));

*/