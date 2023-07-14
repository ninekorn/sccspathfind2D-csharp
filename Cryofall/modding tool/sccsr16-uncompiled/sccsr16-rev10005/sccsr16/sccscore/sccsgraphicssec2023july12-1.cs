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

namespace sccs
{
    public class sccsgraphicssec : sccsdirectx, IDisposable
    {
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

                                                                            if (foldername.ToLower() == "mobs.mpk")
                                                                            {
                                                                                //Console.WriteLine(foldername2);
                                                                                //File.Copy(poppedstring, thecopiedfilepath);

                                                                                if (foldername2.ToLower() == "characterskeletons")
                                                                                {
                                                                                    //Console.WriteLine(ateststring);

                                                                                    string thenameofthefilewithoutextension = ateststring.Substring(0, ateststring.Length - 3);

                                                                                    for (int r = 0; r < 9; r++)
                                                                                    {
                                                                                        string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension + "r" + r  + ".cs";


                                                                                        //CHARACTERSKELETON FOLDER
                                                                                        //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                        string thefilenamewithoutskeletoninit = thenameofthefilewithoutextension.Substring("skeleton".Length, thenameofthefilewithoutextension.Length - "skeleton".Length);

                                                                                        //Console.WriteLine(thefilenamewithoutskeletoninit);

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
                                                                                        //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                        //CHARACTERSKELETON FOLDER
                                                                                    }
                                                                                }
                                                                                else if (foldername2.ToLower() == "mobs" && foldername2.ToLower() !=  foldername.ToLower())
                                                                                {






                                                                                    string thenameofthefilewithoutextension = ateststring.Substring(0, ateststring.Length - 3);



                                                                                    string getfirstfewletters = thenameofthefilewithoutextension.Substring(0, 3);


                                                                                    //Console.WriteLine(thenameofthefilewithoutextension);
                                                                                    if (getfirstfewletters.ToLower() == "mob")
                                                                                    {




                                                                                        for (int r = 0; r < 9; r++)
                                                                                        {
                                                                                            string thevariantfilepath = thefinalpath + @"\" + thenameofthefilewithoutextension + "r" + r + ".cs";


                                                                                            //CHARACTERSKELETON FOLDER
                                                                                            //MOB VARIANTS SCRIPTS MODIFICATION TO ADD THE NEW VARIANT ADDITIONAL NAMING.
                                                                                            string thefilenamewithoutmobinit = thenameofthefilewithoutextension.Substring("mob".Length, thenameofthefilewithoutextension.Length - "mob".Length);

                                                                                            //Console.WriteLine(thefilenamewithoutmobinit);

                                                                                            //CHECKING IF THE PATH OF THE NEW VARIANT ALREADY EXISTS
                                                                                            if (!File.Exists(thevariantfilepath))
                                                                                            {
                                                                                                
                                                                                                //COPYING THE VARIANT TO THE DRIVE.
                                                                                                File.Copy(poppedstring, thevariantfilepath);

                                                                                                if (Directory.Exists(thefinalpath))
                                                                                                {
                                                                                                    DirectoryInfo directoryFolder1 = new DirectoryInfo(thefinalpath);
                                                                                                    directoryFolder1.Refresh();
                                                                                                }


                                                                                                
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

                                                                                                //Directory.CreateDirectory(filenamewithextmul + "Variant" + variantindex);
                                                                                                //File.Copy(arrayoforiginalscriptfilesMOB[i], filenamewithextmul + (thefinalfilename + "Variant" + variantindex) + ".cs", true);







                                                                                                ////////////////////////////////////////////////


                                                                                                string scriptcharacterskeletonstring = "Skeleton" + thenameofthefilewithoutextension;
                                                                                                string scriptnamevariant = "r" + r;

                                                                                                //string themobhp = "StatDefaultHealthMax => " + thehpofthemob + ";";
                                                                                                //string themobhpmodded = "StatDefaultHealthMax => " + thefinalhp + ";";

                                                                                                //string themobheight = "CharacterWorldHeight => " + theheightofthemob + "f;";
                                                                                                //string themobheightmodded = "CharacterWorldHeight => " + thefinalheight + "f;";

                                                                                                //string themobmovespeed = "StatMoveSpeed => " + thespeedofthemob + ";";
                                                                                                //string themobmovespeedmodded = "StatMoveSpeed => " + thefinalmovespeed + ";";

                                                                                                string scriptvarnames = "class Mob" + thenameofthefilewithoutextension;
                                                                                                string scriptstaticvar = "currentMob" + thenameofthefilewithoutextension + "Class";

                                                                                                string scriptitemnames = "Mob" + thenameofthefilewithoutextension + "Sword";

                                                                                                string replacethistoo = "static Mob" + thenameofthefilewithoutextension;




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

                                                                                                ///////////////////////////////////////////////////////////////////

                                                                                                File.WriteAllText(thevariantfilepath, File.ReadAllText(thevariantfilepath).
                                                                                                  Replace(scriptvarnames, scriptvarnames + scriptnamevariant).
                                                                                                  Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).
                                                                                                  Replace(originalsub1, substringofthehp).
                                                                                                  Replace(originalsub, substringoftheheight).
                                                                                                  Replace(substringofthespeedori, substringofthespeed1).
                                                                                                  Replace(scriptstaticvar, scriptstaticvar + scriptnamevariant).
                                                                                                  Replace(scriptitemnames, scriptitemnames + scriptnamevariant).
                                                                                                  Replace(replacethistoo, replacethistoo + scriptnamevariant));
                                                                                            }
                                                                                        }
                                                                                    }


                                                                                }
                                                                            }
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