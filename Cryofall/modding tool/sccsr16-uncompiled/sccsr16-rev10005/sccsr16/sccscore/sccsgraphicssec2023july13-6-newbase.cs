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
using sccsr16;
using static sccsr16.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace sccs
{
    public class sccsgraphicssec : sccsdirectx, IDisposable
    {
        public int generatescriptsswtc = 1;



        int copymethodstartedornot = 0;

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
            Console.Title = "Mobs variants builder/creator for Cryofall V1.33.1.15 - sccsr16-rev-1.0003 - made by steve chassé aka ninekorn. updated 2023/july/12";
            //Console.Title = "Mobs variants builder/creator for Cryofall V1.33.1.15 - sccsr16-rev-0.11 - made by steve chassé aka ninekorn. updated 2023/july/07";

            if (debugtoconsole == 1)
            {
                Console.WriteLine("sccsgraphicssec started");

            }

        }




        public unsafe void startmultiplicationprocess()
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

                int threadfinished = 0;






            _thread_main_loop:



                if (startmultiplicationprocessswtc == 1)
                {
                    Stopwatch thetimer = new Stopwatch();
                    thetimer.Start();

                    //https://stackoverflow.com/questions/19001423/getting-path-to-the-parent-folder-of-the-solution-file-using-c-sharp
                    //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Yourfile.txt");

                    var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                    //Console.WriteLine(theselectedfolderin);
                    //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                    string docPath = sccsr16.Form1.currentform.theselectedfolderin;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Environment.SpecialFolder.MyDocuments); // + @"\" + "multiplied"
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


                            //GETTING THE DIRECTORY TO THE HIGHER HIERARCHY WHERE THE SOLUTION CSPROJ IS, WHEN IN A SOLUTION, AND ALSO WHERE THE FOLDER #CRYOFALLSCRIPTGEN IS
                            //var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
                            /*
                            string separator = @"\";

                            string pathtohighestprogramfolderhierarchy = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderNameCryofallPNGScriptVariantBuilder = separator + "#Cryofallscriptgen";
                            //DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
                            //directoryFolder.Refresh();

                            string mulfolder = separator + "multiplied";
                            string originalfolder = separator + "original";

                            string pathtomodsinprojectfolder = pathtohighestprogramfolderhierarchy + folderNameCryofallPNGScriptVariantBuilder + originalfolder;

                            DirectoryInfo directoryFolder = new DirectoryInfo(pathtomodsinprojectfolder);
                            directoryFolder.Refresh();*/

                            //string pathtomodsinprojectfolder = dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
                            string pathtomodsinprojectfolder = sccsr16.Form1.currentform.theselectedfolderout; //dirinfo.FullName + @"\" + "#Cryofallscriptgen" + @"\" + foldername;
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


                                /*
                                List<float> listrand = new List<float>();
                                List<float> listrandr = new List<float>();
                                List<float> listrandg = new List<float>();
                                List<float> listrandb = new List<float>();

                                List<float> listrandswtc = new List<float>();
                                List<float> listrandrswtc = new List<float>();
                                List<float> listrandgswtc = new List<float>();
                                List<float> listrandbswtc = new List<float>();*/


                                float rand = 0;
                                float randr = 0;
                                float randb = 0;
                                float randg = 0;




                            threadsecloop:

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
                                                    }


                                                    dirs1last.Push(thecurrentpath + @"\" + foldername2);

                                                    //Console.WriteLine(dirs1last.Count);
                                                    /*
                                                    if (!Directory.Exists(thepathtovariantpngsparentfolderout))
                                                    {
                                                        Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
                                                        //dirs1last.Push(thepathtovariantpngsparentfolderout);
                                                    }*/







                                                    //Console.WriteLine(thefinalpath);
                                                    /*if (foldername2.ToLower() == "whatever")
                                                    {

                                                        for (int r = 0; r < 9; r++)
                                                        {
                                                            if (!Directory.Exists(thepathtovariantpngsparentfolderout))
                                                            {
                                                                Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
                                                                //dirs1last.Push(thepathtovariantpngsparentfolderout);
                                                            }
                                                        }
                                                    }*/







                                                    if (folderiteratorsecswtc == 0)
                                                    {

                                                        //Console.WriteLine(foldername2);
                                                        if (foldername2.ToLower() == "images")
                                                        {
                                                            getrandvalues(out rand, out randr, out randb, out randg);

                                                        }








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

                                                                        Console.WriteLine(poppedstring);

                                                                        anotherpath = pathtomods + thepathtocopyfolder + @"\" + foldername2;
                                                                        ateststring = poppedstring.Substring(anotherpath.Length + 1, poppedstring.Length - anotherpath.Length - 1);


                                                                        thecopiedfilepath = thefinalpath + @"\" + ateststring;

                                                                        //copy the original file
                                                                        if (!File.Exists(thecopiedfilepath))
                                                                        {
                                                                            File.Copy(poppedstring, thecopiedfilepath);

                                                                            DirectoryInfo directoryFolder2 = new DirectoryInfo(thecopiedfilepath);
                                                                            directoryFolder2.Refresh();
                                                                        }
                                                                        //copy the original file

                                                                        if (foldername.ToLower() == "mobs.mpk")
                                                                        {



                                                                            if (generatescriptsswtc == 1)
                                                                            {


                                                                                //SCRIPTS SECTION//SCRIPTS SECTION//SCRIPTS SECTION//SCRIPTS SECTION//SCRIPTS SECTION


                                                                                //if (ateststring.Length > 3)
                                                                                {
                                                                                    string thenameofthefilewithoutextension0 = ateststring.Substring(0, ateststring.Length - 3);

                                                                                    string getthefirsteightletters = "";
                                                                                    if (thenameofthefilewithoutextension0.Length >= "skeleton".Length + 1)
                                                                                    {
                                                                                        getthefirsteightletters = thenameofthefilewithoutextension0.Substring(0, "skeleton".Length);

                                                                                        if (getthefirsteightletters.ToLower() == "skeleton")
                                                                                        {
                                                                                            for (int r = 0; r < 9; r++)
                                                                                            {
                                                                                                string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension0 + "r" + r + ".cs";

                                                                                                //string getthefirsteightletters = thenameofthefilewithoutextension0.Substring(0, 8);

                                                                                                //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                                //CHARACTERSKELETON FOLDER

                                                                                                //CHARACTERSKELETON FOLDER
                                                                                                //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                                string thefilenamewithoutskeletoninit = thenameofthefilewithoutextension0.Substring("skeleton".Length, thenameofthefilewithoutextension0.Length - "skeleton".Length);


                                                                                                //CHECKING IF THE PATH OF THE NEW VARIANT ALREADY EXISTS
                                                                                                if (!File.Exists(thevariantfilepath))
                                                                                                {
                                                                                                    //COPYING THE VARIANT TO THE DRIVE.
                                                                                                    File.Copy(poppedstring, thevariantfilepath);


                                                                                                    if (Directory.Exists(thefinalpath))
                                                                                                    {
                                                                                                        DirectoryInfo directoryFolder1 = new DirectoryInfo(thefinalpath);
                                                                                                        directoryFolder1.Refresh();

                                                                                                        string thefinalfilename = thefilenamewithoutskeletoninit + "r" + r;

                                                                                                        string scriptcharacterskeletonstring = "Skeleton" + thefilenamewithoutskeletoninit;// mobname;
                                                                                                        string scriptnamevariant = "r" + r;

                                                                                                        string scriptcharacterskeletonpngpath = thefilenamewithoutskeletoninit + "/";// mobname;
                                                                                                        string scriptcharacterskeletonpngpathreplacement = thefilenamewithoutskeletoninit;// mobname;

                                                                                                        File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).Replace(scriptcharacterskeletonpngpath, scriptcharacterskeletonpngpathreplacement + scriptnamevariant + "/"));

                                                                                                        directoryFolder1 = new DirectoryInfo(thefinalpath);
                                                                                                        directoryFolder1.Refresh();
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                            //CHARACTERSKELETON FOLDER
                                                                                        }

                                                                                    }

                                                                                    //Console.WriteLine(ateststring);

                                                                                    //Console.WriteLine(getthefirsteightletters);







                                                                                    //CHARACTERS FOLDER
                                                                                    string thenameofthefilewithoutextension = ateststring.Substring(0, ateststring.Length - 3);

                                                                                    string getfirstfewletters = thenameofthefilewithoutextension.Substring(0, 3);
                                                                                    string getfirstfiveletters = thenameofthefilewithoutextension.Substring(0, 5);
                                                                                    //Console.WriteLine(thenameofthefilewithoutextension
                                                                                    //
                                                                                    if (thenameofthefilewithoutextension.Length >= "mob".Length + 1)
                                                                                    {
                                                                                        if (getfirstfewletters.ToLower() == "mob")
                                                                                        {
                                                                                            for (int r = 0; r < 9; r++)
                                                                                            {
                                                                                                string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension + "r" + r + ".cs";

                                                                                                //CHARACTERSKELETON FOLDER
                                                                                                //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                                string thefilenamewithoutmobinit = thenameofthefilewithoutextension.Substring("mob".Length, thenameofthefilewithoutextension.Length - "mob".Length);

                                                                                                //Console.WriteLine(thefilenamewithoutmobinit);

                                                                                                //Console.WriteLine(thevariantfilepath + "\n");
                                                                                                //CHECKING IF THE PATH OF THE NEW VARIANT ALREADY EXISTS
                                                                                                if (!File.Exists(thevariantfilepath))
                                                                                                {
                                                                                                    //COPYING THE VARIANT TO THE DRIVE.
                                                                                                    File.Copy(poppedstring, thevariantfilepath);
                                                                                                }

                                                                                                if (Directory.Exists(thefinalpath))
                                                                                                {
                                                                                                    DirectoryInfo directoryFolder1 = new DirectoryInfo(thefinalpath);
                                                                                                    directoryFolder1.Refresh();
                                                                                                }


                                                                                                if (File.Exists(thevariantfilepath))
                                                                                                {

                                                                                                    var readalltextstring = File.ReadAllText(thevariantfilepath);

                                                                                                    string thehporiginal = "StatDefaultHealthMax => ";

                                                                                                    var thefiledata = File.ReadAllText(thevariantfilepath).IndexOf(thehporiginal);

                                                                                                    string substringofthehealth = readalltextstring.Substring(thefiledata, 64);

                                                                                                    string theendofline = ";";
                                                                                                    string thearrow = "=>";

                                                                                                    var thefiledata1 = substringofthehealth.IndexOf(theendofline);
                                                                                                    var thefiledata2 = substringofthehealth.IndexOf(thearrow);

                                                                                                    string substringofthehp = substringofthehealth.Substring(thefiledata2 + thearrow.Length + 1, 32);
                                                                                                    double resultparsedstr;
                                                                                                    double.TryParse(substringofthehp, out resultparsedstr);
                                                                                                    double thehpofthemob = resultparsedstr;







                                                                                                    readalltextstring = File.ReadAllText(thevariantfilepath);

                                                                                                    thehporiginal = "StatMoveSpeed => ";

                                                                                                    thefiledata = File.ReadAllText(thevariantfilepath).IndexOf(thehporiginal);

                                                                                                    substringofthehealth = readalltextstring.Substring(thefiledata, 64);

                                                                                                    theendofline = ";";
                                                                                                    thearrow = "=>";

                                                                                                    thefiledata1 = substringofthehealth.IndexOf(theendofline);
                                                                                                    thefiledata2 = substringofthehealth.IndexOf(thearrow);

                                                                                                    string substringofthespeed1 = substringofthehealth.Substring(thefiledata2 + thearrow.Length + 1 + 24, 8 + 4);
                                                                                                    //double resultparsedstr;
                                                                                                    double.TryParse(substringofthespeed1, out resultparsedstr);
                                                                                                    double thespeedofthemob = resultparsedstr;







                                                                                                    readalltextstring = File.ReadAllText(thevariantfilepath);

                                                                                                    thehporiginal = "CharacterWorldHeight => ";

                                                                                                    thefiledata = File.ReadAllText(thevariantfilepath).IndexOf(thehporiginal);

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

                                                                                                    //Directory.CreateDirectory(filenamewithextmul + "r" + variantindex);
                                                                                                    //File.Copy(arrayoforiginalscriptfilesMOB[i], filenamewithextmul + (thefinalfilename + "r" + variantindex) + ".cs", true);







                                                                                                    ////////////////////////////////////////////////


                                                                                                    string scriptcharacterskeletonstring = "Skeleton" + thefilenamewithoutmobinit;
                                                                                                    string scriptnamevariant = "r" + r;

                                                                                                    //string themobhp = "StatDefaultHealthMax => " + thehpofthemob + ";";
                                                                                                    //string themobhpmodded = "StatDefaultHealthMax => " + thefinalhp + ";";

                                                                                                    //string themobheight = "CharacterWorldHeight => " + theheightofthemob + "f;";
                                                                                                    //string themobheightmodded = "CharacterWorldHeight => " + thefinalheight + "f;";

                                                                                                    //string themobmovespeed = "StatMoveSpeed => " + thespeedofthemob + ";";
                                                                                                    //string themobmovespeedmodded = "StatMoveSpeed => " + thefinalmovespeed + ";";

                                                                                                    //Console.WriteLine(thenameofthefilewithoutextension + "\n");


                                                                                                    //string removemobfromname = thenameofthefilewithoutextension.Substring(3, thenameofthefilewithoutextension.Length);

                                                                                                    //class MobSkeletonr0 : ProtoCharacterMob//, IProtoObjectPsiSource
                                                                                                    string scriptvarnames = "class Mob" + thefilenamewithoutmobinit;
                                                                                                    string scriptstaticvar = "currentMob" + thefilenamewithoutmobinit + "Class";


                                                                                                    //ItemWeaponMobSkeletonSwordVariant0

                                                                                                    string scriptitemnames = thefilenamewithoutmobinit; //"Mob" +  //scriptitemnames

                                                                                                    string replacethistoo = "static Mob" + thefilenamewithoutmobinit;








                                                                                                    //Console.WriteLine(scriptitemnames);

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






                                                                                                    double swapthefinalmovespeed = thefinalmovespeed;

                                                                                                    int[] arrayofdigits = new int[3];

                                                                                                    for (int i = 0; i < 3; i++)
                                                                                                    {
                                                                                                        double beforevalue = swapthefinalmovespeed;
                                                                                                        double theremnantdigit = (int)(Math.Truncate((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10));
                                                                                                        arrayofdigits[i] = (int)theremnantdigit;
                                                                                                        swapthefinalmovespeed = ((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10);
                                                                                                        //swapthefinalmovespeed = (int)(Math.Truncate((swapthefinalmovespeed - Math.Round(swapthefinalmovespeed)) * 10));
                                                                                                        //arrayofdigits[r] = (int)swapthefinalmovespeed;// beforevalue
                                                                                                    }



                                                                                                    string substringofthespeedori = substringofthespeed1;
                                                                                                    substringofthespeed1 = substringofthespeed1.Replace(substringofthespeed1, zerostoadd);

                                                                                                    //ItemWeaponMobSkeletonSword
                                                                                                    //string itemweaponname = "ItemWeaponMob" + 

                                                                                                    ///////////////////////////////////////////////////////////////////

                                                                                                    //Console.WriteLine(thevariantfilepath);

                                                                                                    DirectoryInfo directoryFolder0 = new DirectoryInfo(thevariantfilepath);
                                                                                                    directoryFolder0.Refresh();

                                                                                                    //File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).Replace(scriptvarnames, scriptvarnames + scriptnamevariant));

                                                                                                    //File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant));


                                                                                                    File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).
                                                                                                      Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                                                                                                      Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).

                                                                                                      Replace(originalsub1, substringofthehp).
                                                                                                      Replace(originalsub, substringoftheheight).
                                                                                                      Replace(substringofthespeedori, substringofthespeed1).
                                                                                                      Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                                                                                                      Replace("ItemWeapon" + "Mob" + "Sword" + thefilenamewithoutmobinit, "ItemWeapon" + "Mob" + "Sword" + thefilenamewithoutmobinit + "r" + r).
                                                                                                      Replace(replacethistoo, replacethistoo + scriptnamevariant));

                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }




                                                                                    if (thenameofthefilewithoutextension.Length >= "spawn".Length + 1)
                                                                                    {
                                                                                        if (getfirstfiveletters.ToLower() == "spawn")
                                                                                        {
                                                                                            /*
                                                                                            //CHARACTERS FOLDER
                                                                                            string thenameofthefilewithoutextension = ateststring.Substring(0, ateststring.Length - 3);

                                                                                            string getfirstfewletters = thenameofthefilewithoutextension.Substring(0, 3);



                                                                                            //ZONE FOLDER

                                                                                            string finalpathmobscriptori = pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + @"\" + "Mobs" + @"\";
                                                                                            string finalpathmobscript = pathtoscriptsmul + @"\" + "Zones" + @"\" + "Scripts" + @"\" + @"\" + "Mobs" + @"\";

                                                                                            var arrayoforiginalscriptfilesMOB = Directory.GetFiles(pathtoscripts + @"\" + "Zones" + @"\" + "Scripts" + @"\" + @"\" + "Mobs" + @"\");
                                                                                            */


                                                                                            //sccsr16.Program.MessageBox((IntPtr)0, "length:"+ arrayoforiginalscriptfilesMOB.Length, "sccsmsg", 0);



                                                                                            //MODIFY THE MOB SPAWN SCRIPT
                                                                                            //for (int i = 0; i < arrayoforiginalscriptfilesMOB.Length; i++)
                                                                                            {
                                                                                                /*var prefinalfilename0 = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                                                                                                var thefinalfilename0 = prefinalfilename0 + "r" + r;

                                                                                                var filenamewithext0 = finalpathmobscript + (thefinalfilename0) + ".cs";

                                                                                                string prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));
                                                                                                */
                                                                                                //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/prefinalfilename0:" + prefinalfilename0, "sccsmsg", 0);


                                                                                                //if (prefinalfilename.ToLower() == "spawnmobs" + mobname.ToLower()) // && mobname.ToLower() == "bearpolar"
                                                                                                {
                                                                                                    //sccsr16.Program.MessageBox((IntPtr)0, "test", "sccsmsg", 0);

                                                                                                    for (int r = 0; r < 9; r++)
                                                                                                    {
                                                                                                        //prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));

                                                                                                        string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension + "r" + r + ".cs";
                                                                                                        /*
                                                                                                        string thefinalfilename = prefinalfilename; // + "r" + variantindex

                                                                                                        string filenamewithext = finalpathmobscriptori + (thefinalfilename) + ".cs";
                                                                                                        string filenamewithextmul = finalpathmobscript; // + (thefinalfilename) + ".cs"

                                                                                                        string pathoffile = filenamewithextmul + (thefinalfilename + "r" + r) + ".cs";
                                                                                                        */

                                                                                                        string thefilenamewithoutskeletoninit = thenameofthefilewithoutextension.Substring("spawnmobs".Length, thenameofthefilewithoutextension.Length - "spawnmobs".Length);

                                                                                                        string theclassmobori = "class SpawnMobs" + thefilenamewithoutskeletoninit;
                                                                                                        string theclassmoborislim = "class SpawnMobs" + thefilenamewithoutskeletoninit;
                                                                                                        string theclassmobmod = theclassmoborislim + "r" + r;

                                                                                                        //sccsr16.Program.MessageBox((IntPtr)0, "prefinalfilename:" + prefinalfilename + "/mobname:" + mobname + "/pathoffile:" + pathoffile, "sccsmsg", 0);


                                                                                                        /*string theskeletonresourceback = mobname + "/Back";
                                                                                                        string theskeletonresourcefront = mobname + "/Front";

                                                                                                        string theskeletonresourcebackvariant = mobname + "r" + variantindex + "/Back";
                                                                                                        string theskeletonresourcefrontvariant = mobname + "r" + variantindex + "/Front";
                                                                                                        */

                                                                                                        string spawnstring = "AddExact<Mob" + thefilenamewithoutskeletoninit;
                                                                                                        string spawnstringvariant = "AddExact<Mob" + thefilenamewithoutskeletoninit + "r" + r;

                                                                                                        //Console.WriteLine("thefilenamewithoutskeletoninit:" + thefilenamewithoutskeletoninit);

                                                                                                        //Directory.CreateDirectory(filenamewithextmul + "r" + variantindex);
                                                                                                        File.Copy(poppedstring, thevariantfilepath, true);
                                                                                                        DirectoryInfo directoryFolder0 = new DirectoryInfo(thevariantfilepath);
                                                                                                        directoryFolder0.Refresh();
                                                                                                        //File.Copy(poppedstring, thevariantfilepath);



                                                                                                        File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).//arrayoforiginalscriptfilesMOB[i]).
                                                                                                        Replace(theclassmobori, theclassmobmod).
                                                                                                        Replace(spawnstring, spawnstringvariant));

                                                                                                    }


                                                                                                    //Replace(theskeletonresourceback, theskeletonresourcebackvariant).
                                                                                                    //Replace(theskeletonresourcefront, theskeletonresourcefrontvariant));
                                                                                                }
                                                                                            }

                                                                                        }
                                                                                    }












                                                                                    if (thenameofthefilewithoutextension.Length >= "ItemWeaponMob".Length + 1)
                                                                                    {
                                                                                        string getthefirstletters = thenameofthefilewithoutextension.Substring(0, "ItemWeaponMob".Length);

                                                                                        if (getthefirstletters.ToLower() == "itemweaponmob")
                                                                                        {
                                                                                            string thenameofthefilewithoutextension2 = ateststring.Substring(0, ateststring.Length - 3);

                                                                                            for (int r = 0; r < 9; r++)
                                                                                            {



                                                                                                string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension2 + "r" + r + ".cs";

                                                                                                if (!File.Exists(thevariantfilepath))
                                                                                                {
                                                                                                    //COPYING THE VARIANT TO THE DRIVE.
                                                                                                    File.Copy(poppedstring, thevariantfilepath, true);

                                                                                                    if (Directory.Exists(thefinalpath))
                                                                                                    {
                                                                                                        DirectoryInfo directoryFolder1 = new DirectoryInfo(thefinalpath);
                                                                                                        directoryFolder1.Refresh();

                                                                                                        //string thefinalfilename = thefilenamewithoutskeletoninit + "r" + r;

                                                                                                        //string scriptcharacterskeletonstring = "Skeleton" + thefilenamewithoutskeletoninit;// mobname;
                                                                                                        //string scriptnamevariant = "r" + r;

                                                                                                        //string scriptcharacterskeletonpngpath = thefilenamewithoutskeletoninit + "/";// mobname;
                                                                                                        //string scriptcharacterskeletonpngpathreplacement = thefilenamewithoutskeletoninit;// mobname;

                                                                                                        //File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).Replace(scriptcharacterskeletonpngpath, scriptcharacterskeletonpngpathreplacement + scriptnamevariant + "/"));



                                                                                                        string scriptnamevariant = "r" + r;
                                                                                                        File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).Replace(thenameofthefilewithoutextension, thenameofthefilewithoutextension + "r" + r));

                                                                                                        directoryFolder1 = new DirectoryInfo(thefinalpath);
                                                                                                        directoryFolder1.Refresh();
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }








                                                                                }
                                                                                //SCRIPTS SECTION//SCRIPTS SECTION//SCRIPTS SECTION//SCRIPTS SECTION//SCRIPTS SECTION

                                                                            }



















                                                                            //PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION
                                                                            if (ateststring.Length > 3 + 1)
                                                                            {
                                                                                string thenameofthefilewithoutextension1 = ateststring.Substring(ateststring.Length - 3, 3);

                                                                                //string getthefirsteightletters1 = "";
                                                                                if (thenameofthefilewithoutextension1 == "png")
                                                                                {

                                                                                    string thenameofthefilewithoutextension2 = ateststring.Substring(0, ateststring.Length - 4);
                                                                                    //getthefirsteightletters = thenameofthefilewithoutextension2.Substring(0, "skeleton".Length);
                                                                                    //if (getthefirsteightletters.ToLower() == "skeleton")
                                                                                    //{
                                                                                    //}

                                                                                    //Console.WriteLine(thenameofthefilewithoutextension2);


                                                                                    var texturetoload = new sccstextureloader();

                                                                                    var textureinit = texturetoload.Initialize(device, poppedstring);

                                                                                    if (textureinit)
                                                                                    {
                                                                                        ////Console.WriteLine("texture initialiased");

                                                                                        var factory = new SharpDX.WIC.ImagingFactory();
                                                                                        var filename = poppedstring;// "OnBoardComputer.png";

                                                                                        //string finalfilename = poppedstring.Substring(finalPathmulFront.Length-2, (poppedstring.Length-1 - finalPathmulFront.Length - 1));

                                                                                        ////Console.WriteLine("finalPathoriFront:" + finalPathoriFront);

                                                                                        //string finalfilename = poppedstring.Substring(finalPathoriFront.Length + 1, (poppedstring.Length - finalPathoriFront.Length - 5));
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



                                                                                        //Console.WriteLine(thefinalpath);

                                                                                        for (int r = 0; r < 9; r++)
                                                                                        {
                                                                                            string separator = @"\";
                                                                                            string thepathtovariantpngsparentfolder = sccsr16.Form1.currentform.theselectedfolderin + separator + foldername + separator + "Content" + separator + "Animations" + separator;

                                                                                            //Console.WriteLine(poppedstring + "\n" + thepathtovariantpngsparentfolder);

                                                                                            if (poppedstring.Length > thepathtovariantpngsparentfolder.Length)
                                                                                            {
                                                                                                string finalfilename = poppedstring.Substring(thepathtovariantpngsparentfolder.Length, poppedstring.Length - thepathtovariantpngsparentfolder.Length);

                                                                                                //Console.WriteLine(finalfilename);

                                                                                                string themobname = "";
                                                                                                string theretrievemobnamestring = finalfilename;
                                                                                                int hasretrievedmobname = 0;
                                                                                                int countertocharacterbackslash = 0;
                                                                                                string thecharacter = "";// theretrievemobnamestring.Substring(0, 1);
                                                                                                //Console.WriteLine(theretrievemobnamestring);

                                                                                                int lengthmax = finalfilename.Length;

                                                                                                for (int s = 0; s < finalfilename.Length; s++)
                                                                                                {
                                                                                                    thecharacter = theretrievemobnamestring.Substring(0, 1);

                                                                                                    theretrievemobnamestring = theretrievemobnamestring.Substring(1, theretrievemobnamestring.Length - 1);
                                                                                                    //Console.WriteLine(theretrievemobnamestring);
                                                                                                    themobname += thecharacter;

                                                                                                    if (thecharacter == @"\")
                                                                                                    {
                                                                                                        /*if (hasretrievedmobname == 0)
                                                                                                        {
                                                                                                            lengthmax = countertocharacterbackslash + 1;

                                                                                                            hasretrievedmobname = 1;
                                                                                                        }*/
                                                                                                        hasretrievedmobname = 1;
                                                                                                        break;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        countertocharacterbackslash++;
                                                                                                    }
                                                                                                }

                                                                                                if (hasretrievedmobname == 1)
                                                                                                {
                                                                                                    themobname = themobname.Substring(0, themobname.Length - 1);

                                                                                                    //Console.WriteLine(themobname);
                                                                                                }


                                                                                                string pathtovariantspngs = theretrievemobnamestring;



                                                                                                string pathtopng = themobname + "r" + r + separator + theretrievemobnamestring;


                                                                                                string thepngfilenamewithextinverted = "";
                                                                                                string theretrievemobnamestring1 = finalfilename;
                                                                                                int hasretrievedmobname1 = 0;
                                                                                                int countertocharacterbackslash1 = 0;
                                                                                                string thecharacter1 = "";// theretrievemobnamestring.Substring(0, 1);
                                                                                                                          //Console.WriteLine(theretrievemobnamestring);

                                                                                                for (int s = 0; s < finalfilename.Length; s++)
                                                                                                {
                                                                                                    thecharacter1 = theretrievemobnamestring1.Substring(theretrievemobnamestring1.Length - 1, 1);

                                                                                                    theretrievemobnamestring1 = theretrievemobnamestring1.Substring(0, theretrievemobnamestring1.Length - 1);
                                                                                                    //Console.WriteLine(theretrievemobnamestring);
                                                                                                    thepngfilenamewithextinverted += thecharacter1;

                                                                                                    //Console.WriteLine(thepngfilenamewithextinverted);

                                                                                                    if (thecharacter1 == @"\")
                                                                                                    {

                                                                                                        hasretrievedmobname1 = 1;
                                                                                                        break;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        countertocharacterbackslash1++;
                                                                                                    }
                                                                                                }

                                                                                                string lastthemobname = "";

                                                                                                if (hasretrievedmobname1 == 1)
                                                                                                {
                                                                                                    thepngfilenamewithextinverted = thepngfilenamewithextinverted.Substring(0, thepngfilenamewithextinverted.Length - 1);


                                                                                                    for (int s = thepngfilenamewithextinverted.Length - 1; s >= 0; s--)
                                                                                                    {
                                                                                                        lastthemobname += thepngfilenamewithextinverted[s];
                                                                                                    }
                                                                                                    //Console.WriteLine(lastthemobname);
                                                                                                }

                                                                                                string removetheendfromthestringkeepthebeginning = finalfilename.Substring(0, finalfilename.Length - lastthemobname.Length);

                                                                                                //Console.WriteLine(removetheendfromthestringkeepthebeginning);


                                                                                                string removethebeginningfromthestringkeeptheend = theretrievemobnamestring1.Substring(themobname.Length, theretrievemobnamestring1.Length - themobname.Length);


                                                                                                string removeimages = removethebeginningfromthestringkeeptheend.Substring(separator.Length + "images".Length, removethebeginningfromthestringkeeptheend.Length - (separator.Length + "images".Length));


                                                                                                if (removeimages.Length > 0)
                                                                                                {

                                                                                                }
                                                                                                string thepathtovariantpngsparentfolderout = sccsr16.Form1.currentform.theselectedfolderout + separator + foldername + separator + "Content" + separator + "Animations" + separator + themobname + "r" + r + removethebeginningfromthestringkeeptheend;// + removethecrap;


                                                                                                
                                                                                                if (finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("back") || finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("front")) // && finalfilename.Length > separator.Length + "images".Length + separator.Length + themobname.Length + 3
                                                                                                //if (finalfilename.ToLower().Contains("images"))
                                                                                                {
                                                                                                    //Console.WriteLine("mobimages:" + pathtopng);



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


                                                                                                    if (!Directory.Exists(thepathtovariantpngsparentfolderout))
                                                                                                    {
                                                                                                        Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
                                                                                                    }

                                                                                                    //ateststring
                                                                                                    DirectoryInfo directoryFolder0 = new DirectoryInfo(thefinalpath);
                                                                                                    directoryFolder0.Refresh();
                                                                                                    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
                                                                                                    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
                                                                                                    somebitmap.Save(thepathtovariantpngsparentfolderout + separator + lastthemobname);
                                                                                                    //bitmapcounter++;
                                                                                                    //Console.WriteLine(thepathtovariantpngsparentfolderout);

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



                                                                                                if (finalfilename.ToLower().Contains("images") && !finalfilename.ToLower().Contains("back") && !finalfilename.ToLower().Contains("front")) // && finalfilename.Length > separator.Length + "images".Length + separator.Length + themobname.Length + 3
                                                                                                //if (finalfilename.ToLower().Contains("images"))
                                                                                                {
                                                                                                    //Console.WriteLine("mobimages:" + pathtopng);



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


                                                                                                    if (!Directory.Exists(thepathtovariantpngsparentfolderout))
                                                                                                    {
                                                                                                        Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
                                                                                                    }

                                                                                                    //ateststring
                                                                                                    DirectoryInfo directoryFolder0 = new DirectoryInfo(thefinalpath);
                                                                                                    directoryFolder0.Refresh();
                                                                                                    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
                                                                                                    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
                                                                                                    somebitmap.Save(thepathtovariantpngsparentfolderout + separator + lastthemobname);
                                                                                                    //bitmapcounter++;
                                                                                                    //Console.WriteLine(thepathtovariantpngsparentfolderout);

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


                                                                                            }






                                                                                            //Console.WriteLine(thefinalpath);

                                                                                            //themobname

                                                                                            //string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension2 + ".png";



                                                                                        }

                                                                                        device.ImmediateContext.UnmapSubresource(theonboardcomputertextureFINAL, 0);







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

                                                                                        /*
                                                                                        if (somebitmaplast != null)
                                                                                        {
                                                                                            somebitmaplast.Dispose();
                                                                                            somebitmaplast = null;
                                                                                        }

                                                                                        //if (somebitmaplast != null)
                                                                                        {
                                                                                            somebitmaplast = somebitmap;
                                                                                        }*/



                                                                                    }
                                                                                    else
                                                                                    {

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
                                                                            }
                                                                            //PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION//PNG SECTION













                                                                            //JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION
                                                                            if (ateststring.Length > 4 + 1)
                                                                            {
                                                                                string thenameofthefilewithoutextension1 = ateststring.Substring(ateststring.Length - 4, 4);

                                                                                if (thenameofthefilewithoutextension1 == "json")
                                                                                {
                                                                                    string thenameofthefilewithoutextension2 = ateststring.Substring(0, ateststring.Length - 4);


                                                                                    for (int r = 0; r < 9; r++)
                                                                                    {
                                                                                        string separator = @"\";
                                                                                        string thepathtovariantpngsparentfolder = sccsr16.Form1.currentform.theselectedfolderin + separator + foldername + separator + "Content" + separator + "Animations" + separator;

                                                                                        //Console.WriteLine(poppedstring + "\n" + thepathtovariantpngsparentfolder);

                                                                                        if (poppedstring.Length > thepathtovariantpngsparentfolder.Length)
                                                                                        {
                                                                                            string finalfilename = poppedstring.Substring(thepathtovariantpngsparentfolder.Length, poppedstring.Length - thepathtovariantpngsparentfolder.Length);

                                                                                            string themobname = "";
                                                                                            string theretrievemobnamestring = finalfilename;
                                                                                            int hasretrievedmobname = 0;
                                                                                            int countertocharacterbackslash = 0;
                                                                                            string thecharacter = "";// theretrievemobnamestring.Substring(0, 1);
                                                                                                                     //Console.WriteLine(theretrievemobnamestring);

                                                                                            int lengthmax = finalfilename.Length;

                                                                                            for (int s = 0; s < finalfilename.Length; s++)
                                                                                            {
                                                                                                thecharacter = theretrievemobnamestring.Substring(0, 1);

                                                                                                theretrievemobnamestring = theretrievemobnamestring.Substring(1, theretrievemobnamestring.Length - 1);
                                                                                                //Console.WriteLine(theretrievemobnamestring);
                                                                                                themobname += thecharacter;

                                                                                                if (thecharacter == @"\")
                                                                                                {
                                                                                                    /*if (hasretrievedmobname == 0)
                                                                                                    {
                                                                                                        lengthmax = countertocharacterbackslash + 1;

                                                                                                        hasretrievedmobname = 1;
                                                                                                    }*/
                                                                                                    hasretrievedmobname = 1;
                                                                                                    break;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    countertocharacterbackslash++;
                                                                                                }
                                                                                            }

                                                                                            if (hasretrievedmobname == 1)
                                                                                            {
                                                                                                themobname = themobname.Substring(0, themobname.Length - 1);

                                                                                                //Console.WriteLine(themobname);
                                                                                            }

                                                                                            //Console.WriteLine(themobname);
                                                                                            string pathtovariantspngs = theretrievemobnamestring;



                                                                                            string pathtopng = themobname + "r" + r + separator + theretrievemobnamestring;


                                                                                            string thepngfilenamewithextinverted = "";
                                                                                            string theretrievemobnamestring1 = finalfilename;
                                                                                            int hasretrievedmobname1 = 0;
                                                                                            int countertocharacterbackslash1 = 0;
                                                                                            string thecharacter1 = "";// theretrievemobnamestring.Substring(0, 1);
                                                                                                                      //Console.WriteLine(theretrievemobnamestring);

                                                                                            for (int s = 0; s < finalfilename.Length; s++)
                                                                                            {
                                                                                                thecharacter1 = theretrievemobnamestring1.Substring(theretrievemobnamestring1.Length - 1, 1);

                                                                                                theretrievemobnamestring1 = theretrievemobnamestring1.Substring(0, theretrievemobnamestring1.Length - 1);
                                                                                                //Console.WriteLine(theretrievemobnamestring);
                                                                                                thepngfilenamewithextinverted += thecharacter1;

                                                                                                //Console.WriteLine(thepngfilenamewithextinverted);

                                                                                                if (thecharacter1 == @"\")
                                                                                                {

                                                                                                    hasretrievedmobname1 = 1;
                                                                                                    break;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    countertocharacterbackslash1++;
                                                                                                }
                                                                                            }

                                                                                            string lastthemobname = "";

                                                                                            if (hasretrievedmobname1 == 1)
                                                                                            {
                                                                                                thepngfilenamewithextinverted = thepngfilenamewithextinverted.Substring(0, thepngfilenamewithextinverted.Length - 1);


                                                                                                for (int s = thepngfilenamewithextinverted.Length - 1; s >= 0; s--)
                                                                                                {
                                                                                                    lastthemobname += thepngfilenamewithextinverted[s];
                                                                                                }
                                                                                                //Console.WriteLine(lastthemobname);
                                                                                            }


                                                                                            // Console.WriteLine(lastthemobname);


                                                                                            string removetheendfromthestringkeepthebeginning = finalfilename.Substring(0, finalfilename.Length - lastthemobname.Length);

                                                                                            //Console.WriteLine(removetheendfromthestringkeepthebeginning);


                                                                                            string removethebeginningfromthestringkeeptheend = theretrievemobnamestring1.Substring(themobname.Length, theretrievemobnamestring1.Length - themobname.Length);


                                                                                            /*
                                                                                            string removeimages = removethebeginningfromthestringkeeptheend.Substring(separator.Length + "images".Length, removethebeginningfromthestringkeeptheend.Length - (separator.Length + "images".Length));


                                                                                            if (removeimages.Length > 0)
                                                                                            {

                                                                                            }*/

                                                                                            string thepathtovariantpngsparentfolderout = sccsr16.Form1.currentform.theselectedfolderout + separator + foldername + separator + "Content" + separator + "Animations" + separator + themobname + "r" + r;// + removethecrap;

                                                                                            string thefinalfilename0 = thepathtovariantpngsparentfolderout + separator + lastthemobname;


                                                                                            //Console.WriteLine(thefinalfilename0);

                                                                                            /*
                                                                                            //Console.WriteLine(thepathtovariantpngsparentfolderout);
                                                                                            DirectoryInfo directoryFolder2 = new DirectoryInfo(thepathtovariantpngsparentfolderout);
                                                                                            directoryFolder2.Refresh();
                                                                                            */

                                                                                            if (!Directory.Exists(thepathtovariantpngsparentfolderout))
                                                                                            {
                                                                                                Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
                                                                                            }

                                                                                            //copy the original file
                                                                                            if (!File.Exists(thefinalfilename0))
                                                                                            {
                                                                                                File.Copy(poppedstring, thefinalfilename0);

                                                                                                //directoryFolder2 = new DirectoryInfo(thepathtovariantpngsparentfolderout);
                                                                                               // directoryFolder2.Refresh();
                                                                                            }

                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                            //JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION//JSON SECTION



















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

                                    goto threadsecloop;
                                }
                                else
                                {
                                    writemobsspawntozonescript();

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
                                    sccsr16.Form1.currentform.startmultiplicationprocessthreadswtc = 2;


                                    copymethodstartedornot = 1;
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
                    startmultiplicationprocessswtc = 0;

                }




                if (copymethodstartedornot == 1)
                {
                    Console.WriteLine("The thread has finished work on copying the files.");
                    copymethodstartedornot = 2;
                }














                /*
                if (startmultiplicationprocessswtc == 1)
                {

                    if (swtcforonoff == 0)
                    {
                        //GETTING THE DIRECTORY TO THE HIGHER HIERARCHY WHERE THE SOLUTION CSPROJ IS, WHEN IN A SOLUTION, AND ALSO WHERE THE FOLDER #CRYOFALLSCRIPTGEN IS
                        var dirinfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

                        string separator = @"\";

                        string pathtohighestprogramfolderhierarchy = dirinfo.FullName;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string folderNameCryofallPNGScriptVariantBuilder = separator + "#Cryofallscriptgen";
                        //DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
                        //directoryFolder.Refresh();

                       
                        string mulfolder = separator + "multiplied";
                        string originalfolder = separator + "original";

                        string finalpathtooriginals = pathtohighestprogramfolderhierarchy + folderNameCryofallPNGScriptVariantBuilder + originalfolder;

                        DirectoryInfo directoryFolder = new DirectoryInfo(finalpathtooriginals);
                        directoryFolder.Refresh();


                        Console.WriteLine(finalpathtooriginals);

                      
                    }

                    startmultiplicationprocessswtc = 0;
                }*/







                if (threadfinished == 0)
                {
                    Thread.Sleep(1);
                    goto _thread_main_loop;
                }
                else
                {

                }


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






        public void writemobsspawntozonescript()
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


                        if (thefoldernameinsideofcryofall.ToLower() == "zones")
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                       "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                      "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + removetheextensionfrommobname + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                   "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\n" +
                                                                  "\t" + "\t" + "\t" + ".Add(GetScript<SpawnMobs" + themodtogetmobsfrom + "r" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "));" + "\n"));
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
                    }
                }

            }
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
            float minrandg = 0.70f; //0.90fs
            float maxrandg = 0.99f;//1.015f //0.999f

            float minrandb = 0.70f; //0.998f
            float maxrandb = 0.99f;//1.015f //0.999f

            float minrandr = 0.70f; //0.998f
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








/*
if (foldername2.ToLower() == "characterskeletons0")
{
    //Console.WriteLine(ateststring);
    //Console.WriteLine(thecopiedfilepath);

    //string thenameofthefilewithoutextension = ateststring.Substring(0, ateststring.Length - 3);


}
else if (foldername2.ToLower() == "mobs0" && foldername2.ToLower() != foldername.ToLower())
{

}
else if (foldername2.ToLower() == "mobweapons0")
{


    //Console.WriteLine(thenameofthefilewithoutextension);
    /*
    string thefilenamewithoutiteminit = "";

    if (thenameofthefilewithoutextension.Contains("skeleton"))
    {
        thefilenamewithoutiteminit = thenameofthefilewithoutextension.Substring("itemweaponmobskeletonsword".Length, thenameofthefilewithoutextension.Length - "itemweaponmobskeletonsword".Length);
        //thefilenamewithoutiteminit = thefilenamewithoutiteminit.Substring(0,7);
        //thefilenamewithoutiteminit = thefilenamewithoutiteminit.Substring(0, thefilenamewithoutiteminit.Length - 3);
    }
    else if (thenameofthefilewithoutextension.Contains("zombie"))
    {
        thefilenamewithoutiteminit = thenameofthefilewithoutextension.Substring("itemweaponmobzombiesword".Length, thenameofthefilewithoutextension.Length - "itemweaponmobzombiesword".Length);
        //thefilenamewithoutiteminit = thefilenamewithoutiteminit.Substring(0, 7);
        //thefilenamewithoutiteminit = thefilenamewithoutiteminit.Substring(0, thefilenamewithoutiteminit.Length - 3);
    }


    if (thefilenamewithoutiteminit != "")
    {


        //Console.WriteLine(thefilenamewithoutiteminit);


        /*
        string themobname = "";
        if (thenameofthefilewithoutextension.Contains("skeleton"))
        {
            themobname = "Skeleton";
        }
        else if (thenameofthefilewithoutextension.Contains("zombie"))
        {
            themobname = "Zombie";
        }





    }







    //var arrayoforiginalscriptfilesITEM = Directory.GetFiles(pathtoscripts + @"\" + "Items" + @"\" + "Weapons" + @"\" + "MobWeapons");

    //var arrayoforiginalscriptfilesITEM = Directory.GetFiles(finalpathmobitemscriptori);

    //MODIFY THE MOB CHARACTER SKELETON SCRIPT
    //for (int i = 0; i < arrayoforiginalscriptfilesITEM.Length; i++)
    {
        /*string prefinalfilename = arrayoforiginalscriptfilesITEM[i].Substring(finalpathmobitemscriptori.Length, (arrayoforiginalscriptfilesITEM[i].Length - finalpathmobitemscriptori.Length - 3));
        string thefinalfilename = prefinalfilename;

        ////Console.WriteLine(prefinalfilename);

        string filenamewithext = finalpathmobitemscript + (thefinalfilename) + ".cs";
        
        ////Console.WriteLine(finalfilename);

        for (int r = 0; r < 9; r++)
        {





            //prefinalfilename = arrayoforiginalscriptfilesMOB[i].Substring(finalpathmobscriptori.Length, (arrayoforiginalscriptfilesMOB[i].Length - finalpathmobscriptori.Length - 3));
            /*
            string scriptname = thefilenamewithoutiteminit + "Sword";

            string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension + "r" + r + ".cs";


            File.Copy(poppedstring, thevariantfilepath, true);

            DirectoryInfo directoryFolder0 = new DirectoryInfo(thevariantfilepath);
            directoryFolder0.Refresh();


            //string scriptreplace0 = "Skeleton";
            //string scriptreplace1 = "Sword";
            //string scriptcharacterskeletonstring = "Skeleton" + mobname;
            string scriptnamevariant = "r" + r;
            //string replacescriptname = "ItemWeaponMobSkeletonSword";

            //string scriptcharacterskeletonpngpath = "Skeleton/";
            //string scriptcharacterskeletonpngpathreplacement = "Skeleton";

            //string prefinalfilenamecorrect = arrayoforiginalscriptfilesITEM[i].Substring(finalpathmobskeletonscript.Length, (arrayoforiginalscriptfilesITEM[i].Length - 1 - finalpathmobskeletonscript.Length - 2));

            File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).Replace(scriptname, "Sword" + thefilenamewithoutiteminit + "r" + r));
            


        }
    }
    //MODIFY THE MOB CHARACTER SKELETON SCRIPT

}*/

//Console.WriteLine(finalfilename);

//skeletonr0/images/filename.png


//dirs1last.Push(thecurrentpath + @"\" + foldername2);

/*
//if (finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("back") || finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("front")) // && finalfilename.Length > separator.Length + "images".Length + separator.Length + themobname.Length + 3
if (finalfilename.ToLower().Contains("images") && ! finalfilename.ToLower().Contains("back") && !finalfilename.ToLower().Contains("front"))
//if (finalfilename.ToLower().Contains("images"))
{
    //Console.WriteLine("mobimages:" + pathtopng);

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

    if (!Directory.Exists(thepathtovariantpngsparentfolderout))
    {
        Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
        dirs1last.Push(thepathtovariantpngsparentfolderout);
    }

    //ateststring
    DirectoryInfo directoryFolder0 = new DirectoryInfo(thefinalpath);
    directoryFolder0.Refresh();
    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
    somebitmap.Save(thepathtovariantpngsparentfolderout + separator + lastthemobname);
    //bitmapcounter++;
    //Console.WriteLine(thepathtovariantpngsparentfolderout);

    Console.WriteLine(thepathtovariantpngsparentfolderout + separator + lastthemobname);
}*/



//Console.WriteLine(thefinalpath);
/*
if (finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("back") || finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("front")) // && finalfilename.Length > separator.Length + "images".Length + separator.Length + themobname.Length + 3

//if (finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("back") && !finalfilename.ToLower().Contains("characters") && finalfilename.ToLower().Contains("weapons") || finalfilename.ToLower().Contains("images") && finalfilename.ToLower().Contains("front") && !finalfilename.ToLower().Contains("characters") && finalfilename.ToLower().Contains("weapons")) // && finalfilename.Length > separator.Length + "images".Length + separator.Length + themobname.Length + 3
//if (finalfilename.ToLower().Contains("images") && !finalfilename.ToLower().Contains("back") && !finalfilename.ToLower().Contains("front"))
//if (finalfilename.ToLower().Contains("images"))
{
    //Console.WriteLine("mobimages:" + pathtopng);

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

    /*if (!Directory.Exists(thepathtovariantpngsparentfolderout))
    {
        Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
        //dirs1last.Push(thepathtovariantpngsparentfolderout);
    }

    //ateststring
    DirectoryInfo directoryFolder0 = new DirectoryInfo(thefinalpath);
    directoryFolder0.Refresh();
    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
    somebitmap.Save(thepathtovariantpngsparentfolderout + separator + lastthemobname);
    //bitmapcounter++;
    //Console.WriteLine(thepathtovariantpngsparentfolderout);

    //Console.WriteLine(thepathtovariantpngsparentfolderout + separator + lastthemobname);
}*/


/*
if (finalfilename.ToLower().Contains("images") && !finalfilename.ToLower().Contains("back") && !finalfilename.ToLower().Contains("front"))
//if (finalfilename.ToLower().Contains("images"))
{
    if (!Directory.Exists(thepathtovariantpngsparentfolderout))
    {
        Directory.CreateDirectory(thepathtovariantpngsparentfolderout);
    }

    //Console.WriteLine("mobimages:" + pathtopng);

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


    //dirs1last.Push(thepathtovariantpngsparentfolderout);

    //ateststring
    DirectoryInfo directoryFolder0 = new DirectoryInfo(thefinalpath);
    directoryFolder0.Refresh();
    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
    somebitmap.Save(thepathtovariantpngsparentfolderout + separator + lastthemobname);
    //bitmapcounter++;
    //Console.WriteLine(thepathtovariantpngsparentfolderout);

    Console.WriteLine(thepathtovariantpngsparentfolderout + separator + lastthemobname);

}*/





//Console.WriteLine(finalPathmulFront + finalfilename + ".png");
/*
DirectoryInfo directoryFolder0 = new DirectoryInfo(finalPathmulFront);
directoryFolder0.Refresh();
var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
//somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
somebitmap.Save(finalPathmulFront + finalfilename + ".png");
bitmapcounter++;
*/

//Console.WriteLine(finalPathmulFront + finalfilename + ".png");





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
