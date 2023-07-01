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

namespace sccs
{
    public class sccsgraphicssec : sccsdirectx, IDisposable
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


        int debugtoconsole = 1;

        public sccsgraphicssec()
        {

            Console.Title = "Mobs variants builder/creator for Cryofall V1.33.1.15 - sccsr16-rev-0.1002 - made by steve chassé aka ninekorn. updated 2023/june/11";





            if (debugtoconsole == 1)
            {
                Console.WriteLine("sccsgraphicssec started");

            }




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








            var _mainTasker00 = new Thread((tester0000) =>
            {


           //_thread_main_loop:


                string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
                DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
                directoryFolder.Refresh();


                if (debugtoconsole == 1)
                {
                    Console.WriteLine("desktop folder #Cryofallscriptgen found.");
                }




                string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";
                string prefinalpathtofilesmultiplied = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "multiplied";

                string pathoforiginalfolder = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder;

                int lengthofpath = pathoforiginalfolder.Length;

                ////Console.WriteLine(prefinalpathtofiles);
                //var arrayoforiginalzonesscriptfiles = Directory.GetFiles(prefinalpathtofiles);

                int numberofvariants = 9;

                //https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-enumerate-directories-and-files
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// Environment.SpecialFolder.MyDocuments);
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));



                if (debugtoconsole == 1)
                {
                    Console.WriteLine("Listing mods from Documents/Cryofall/Mods");
                }

                foreach (var dir in dirs)
                {
                    ////Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");

                    string foldername = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";

                    if (foldername.ToLower() == "atomictorchstudio")
                    {
                        string dirtocryofallmodfolder = dir + @"\" + "Cryofall" + @"\" + "Mods";

                        List<string> listofmodfolders = new List<string>(Directory.EnumerateDirectories(dirtocryofallmodfolder));

                        foreach (var modfolder in listofmodfolders)
                        {
                            string themodfoldername = $"{modfolder.Substring(modfolder.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";



                            if (debugtoconsole == 1)
                            {
                                Console.WriteLine("mod name:" + themodfoldername);
                            }




                            if (themodfoldername != "sccspathfind.mpk")
                            {





                                string themodfoldernamewithoutextension = themodfoldername.Substring(0, themodfoldername.Length - 4);

                                ////Console.WriteLine(themodfoldernamewithoutextension);

                                string finalPathheader = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk"; // + @"\" + "images"
                                var arrayoforiginalheader = Directory.GetFiles(finalPathheader);

                                ////Console.WriteLine(arrayoforiginalweapon[i]);
                                string finalPathanims1 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk"; // + @"\" + "images"
                                string finalPathanims2 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk"; // + @"\" + "images"

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







                                /*
                                if (themodfoldernamewithoutextension.ToLower() == "sccspathfind")
                                {
                                    continue;
                                }*/


                                if (themodfoldernamewithoutextension.ToLower() == "skeleton")
                                {




                                    /*float mobheight = 1.65f;
                                    double mobhp = 99;
                                    double mobspeed = 2.0;
                                    string mobname = "Skeleton";*/

                                    //string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";

                                    string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content\\Animations\\" + themodfoldernamewithoutextension + "\\images"; //back/male and /front/male
                                    string pathtoscripts = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts";
                                    string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts";

                                    for (int i = 0; i < numberofvariants; i++)
                                    {
                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("start creating Content/ variants " + i + " color for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }

                                        createvariantpngs(i, pathtoanimationpngs, themodfoldernamewithoutextension,0);
                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("end creating Content/ variants " + i + " color for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }

                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }
                                        createvariantscripts(i, themodfoldernamewithoutextension, pathtoscripts, pathtoscriptsmul, themodfoldernamewithoutextension, 0);

                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }
                                    }
                                }
                                else if (themodfoldernamewithoutextension.ToLower() == "zombie")
                                {

                                    /*
                                    float mobheight = 1.65f;
                                    double mobhp = 200;
                                    double mobspeed = 1.5;
                                    string mobname = "Zombie";
                                    */

                                    //string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";

                                    string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content\\Animations\\" + themodfoldernamewithoutextension + "\\images"; //back/male and /front/male
                                    string pathtoscripts = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts";
                                    string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts";

                                    for (int i = 0; i < numberofvariants; i++)
                                    {
                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("start creating Content/ variants " + i + " color for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }

                                        createvariantpngs(i, pathtoanimationpngs, themodfoldernamewithoutextension, 0);
                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("end creating Content/ variants " + i + " color for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }

                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }
                                        createvariantscripts(i, themodfoldernamewithoutextension, pathtoscripts, pathtoscriptsmul, themodfoldernamewithoutextension, 0);

                                        if (debugtoconsole == 1)
                                        {
                                            Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                        }
                                    }
                                }
                                else if (themodfoldernamewithoutextension.ToLower() == "zones")
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

                                    //string pathtozones = "C:\\Users\\steve\\Desktop\\#Cryofallscriptgen\\original" + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts" + @"\" + "Zones" + @"\" + "Zones";

                                    string pathtozones = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts" + @"\" + "Zones" + @"\" + "Zones";


                                    for (int j = 0; j < 1; j++)//skeleton and zombie variants
                                    {
                                        for (int i = 0; i < arrayofzones.Length; i++)
                                        {
                                            preparezones(i, currentfolderzone, pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder, i, prefinalpathtofiles, prefinalpathtofilesmultiplied, pathtozones);
                                        }
                                    }

                                    if (debugtoconsole == 1)
                                    {
                                        Console.WriteLine("end creating Zones scripts for the mobs where all mobs variants and original will be spawned within a Cryofall game.");
                                    }
                                }
                                else if(themodfoldernamewithoutextension.ToLower() == "TODO-mobs-TODO")//any MOB MOds or MOBS files correctly set in hieararchy.
                                {
                                    //GET THE FILES FROM THE MOBS FOLDER AND GET THE MOB NAME FROM THE SCRIPT FILES. 








                                    string originalfoldername = themodfoldernamewithoutextension;

                                    string pathtothescriptswhereweretrievethemobsname = prefinalpathtofiles + @"\" + originalfoldername + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";// + "\\Characters" + "\\Mobs";
                                    var arrayofthescriptfiles = Directory.GetFiles(pathtothescriptswhereweretrievethemobsname);

                                    string pathtoremovetogetscriptmobname = prefinalpathtofiles + @"\" + originalfoldername + ".mpk" + "\\Scripts" + "\\CharacterSkeletons" + @"\";// + "\\Characters" + "\\Mobs" + "\\Mob";
                                    int lengthofstringtoremove = pathtoremovetogetscriptmobname.Length;











                                    //option 0 == CREATE A SINGLE MPK FOR EACH MOBS
                                    //option 1 == CREATE A SINGLE MPK THAT INCLUDES ALL MOBS <= TODO
                                    int creatempkpermobornot = 0;

                                    if (creatempkpermobornot == 0)
                                    {
                                        for (int f = 0; f < arrayofthescriptfiles.Length; f++)
                                        {
                                            ///Console.WriteLine(arrayofthescriptfiles[f]);

                                            string thefilemobname = arrayofthescriptfiles[f].Substring(lengthofstringtoremove, (arrayofthescriptfiles[f].Length) - lengthofstringtoremove);
                                            // Console.WriteLine(thefilemobname);
                                            string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);


                                            string theskeletonstr = "skeleton";

                                            removetheextensionfrommobname = removetheextensionfrommobname.Substring(theskeletonstr.Length, removetheextensionfrommobname.Length - theskeletonstr.Length);
                                            //Console.WriteLine(removetheextensionfrommobname);

                                            //removetheextensionfrommobname = removetheextensionfrommobname.Substring(0, "skeleton".Length);







                                            /*
                                            if (removetheextensionfrommobname == "BossPragmiumQueen")
                                            {
                                                removetheextensionfrommobname = "PragmiumQueen";
                                            }*/



                                            //FOR MAKING FOLDERS FOR SCRIPT FILES TO BE COPIED
                                            string pathtocharactermobsmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";
                                            string pathtocharacterskeletonsmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";
                                            string pathtoitemsweaponsmobweaponsmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Items" + "\\Weapons" + "\\MobWeapons";
                                            string pathtozonesscriptmobsmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";
                                            //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED


                                            string pathtoPNGSmobsmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images";
                                            string pathtoPNGSmobsbackmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Back";
                                            string pathtoPNGSmobsfrontmul = prefinalpathtofilesmultiplied + @"\" + removetheextensionfrommobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Front";

                                            Directory.CreateDirectory(pathtocharactermobsmul);
                                            Directory.CreateDirectory(pathtocharacterskeletonsmul);
                                            Directory.CreateDirectory(pathtoitemsweaponsmobweaponsmul);
                                            Directory.CreateDirectory(pathtozonesscriptmobsmul);
                                            Directory.CreateDirectory(pathtoPNGSmobsmul);
                                            Directory.CreateDirectory(pathtoPNGSmobsbackmul);
                                            Directory.CreateDirectory(pathtoPNGSmobsfrontmul);

                                            string pathtocharactermobs = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";
                                            string pathtocharacterskeletons = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts" + "\\CharacterSkeletons";
                                            string pathtoitemsweaponsmobweapons = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts" + "\\Items" + "\\Weapons" + "\\MobWeapons";
                                            string pathtozonesscriptmobs = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";
                                            //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED

                                            string pathtoPNGSmobs = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images";
                                            string pathtoPNGSmobsback = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Back";
                                            string pathtoPNGSmobsfront = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Front";

                                            Console.WriteLine(pathtoPNGSmobs);

                                            var arrayoffiles0 = Directory.GetFiles(pathtocharactermobs);
                                            var arrayoffiles1 = Directory.GetFiles(pathtocharacterskeletons);
                                            var arrayoffiles2 = Directory.GetFiles(pathtoitemsweaponsmobweapons);
                                            var arrayoffiles3 = Directory.GetFiles(pathtozonesscriptmobs);

                                            string[] arrayoffiles4 = null;
                                            string[] arrayoffiles5 = null;
                                            string[] arrayoffiles6 = null;

                                            if (removetheextensionfrommobname.ToLower() == "broodnest")
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);

                                                //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                //arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }
                                            else if (removetheextensionfrommobname.ToLower() == "crab")
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);
                                                //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }
                                            else if (removetheextensionfrommobname.ToLower() == "floater")
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);

                                                //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                //arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }
                                            else if (removetheextensionfrommobname.ToLower() == "psigrove")
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);

                                                //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }
                                            else if (removetheextensionfrommobname.ToLower() == "spitter")
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);

                                                //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }
                                            else if (removetheextensionfrommobname.ToLower() == "starfish")
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);

                                                //arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }
                                            else
                                            {
                                                arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);
                                                arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                                arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);
                                            }








                                            /*
                                            for (int fi = 0; fi < arrayoffiles0.Length; fi++)
                                            {

                                                if (removetheextensionfrommobname.ToLower() == "pragmiumqueen")
                                                {
                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul + @"\" + "Mob" + "Boss" + removetheextensionfrommobname + ".cs", true);

                                                }
                                                else if (removetheextensionfrommobname.ToLower() == "sandtyrant")
                                                {
                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul + @"\" + "Mob" + "Boss" + removetheextensionfrommobname + ".cs", true);

                                                }         
                                                else
                                                {
                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul + @"\" + "Mob" + removetheextensionfrommobname + ".cs", true);
                                                }
                                            }


                                            for (int fi = 0; fi < arrayoffiles1.Length; fi++)
                                            {
                                                File.Copy(arrayoffiles1[fi], pathtocharacterskeletonsmul + @"\" + "Skeleton" + removetheextensionfrommobname + ".cs", true);

                                            }
                                            */

                                            //TODO OTHERWISE CRASH AT CRYOFALL LOAD OR DONT ADD VARIANT WEAPONS AND USE THE ORIGINAL ONLY FOR THE VARIANT MOBS ALSO.
                                            /*
                                            for (int fi = 0; fi < arrayoffiles2.Length; fi++)
                                            {
                                                File.Copy(arrayoffiles2[fi], pathtoitemsweaponsmobweaponsmul + @"\" + "ItemWeaponMob" + removetheextensionfrommobname + "Sword" + ".cs", true);
                                            }*/
                                            //TODO OTHERWISE CRASH AT CRYOFALL LOAD OR DONT ADD VARIANT WEAPONS AND USE THE ORIGINAL ONLY FOR THE VARIANT MOBS ALSO.

                                            /*
                                            for (int fi = 0; fi < arrayoffiles3.Length; fi++)
                                            {
                                                File.Copy(arrayoffiles3[fi], pathtozonesscriptmobsmul + @"\" + "SpawnMobs" + removetheextensionfrommobname + ".cs", true);
                                            }*/

                                            /*
                                            for (int fi = 0; fi < arrayoffiles4.Length; fi++)
                                            {
                                                File.Copy(arrayoffiles4[fi], pathtoPNGSmobsmul + @"\" + "SpawnMobs" + removetheextensionfrommobname + "", true);
                                            }
                                            for (int fi = 0; fi < arrayoffiles5.Length; fi++)
                                            {
                                                File.Copy(arrayoffiles5[fi], pathtoPNGSmobsbackmul + @"\" + "SpawnMobs" + removetheextensionfrommobname + ".cs", true);
                                            }
                                            for (int fi = 0; fi < arrayoffiles6.Length; fi++)
                                            {
                                                File.Copy(arrayoffiles6[fi], pathtoPNGSmobsfrontmul + @"\" + "SpawnMobs" + removetheextensionfrommobname + ".cs", true);
                                            }*/
                                            //string pathtoPNGSmobsback = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content" + "\\Animations" + @"\" + removetheextensionfrommobname + @"\" + "images" + @"\" + "Back"














































                                            /*
                                            if (removetheextensionfrommobname.ToLower() == "broodnest")
                                            {
                                                for (int fi = 0; fi < arrayoffiles0.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles1.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles1[fi], pathtocharacterskeletonsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles2.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles2[fi], pathtoitemsweaponsmobweaponsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles3.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles3[fi], pathtozonesscriptmobsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles4.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles4[fi], pathtoPNGSmobsmul, true);
                                                }
                                            }
                                            else
                                            {
                                                for (int fi = 0; fi < arrayoffiles0.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles0[fi], pathtocharactermobsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles1.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles1[fi], pathtocharacterskeletonsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles2.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles2[fi], pathtoitemsweaponsmobweaponsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles3.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles3[fi], pathtozonesscriptmobsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles4.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles4[fi], pathtoPNGSmobsmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles5.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles5[fi], pathtoPNGSmobsbackmul, true);
                                                }
                                                for (int fi = 0; fi < arrayoffiles6.Length; fi++)
                                                {
                                                    File.Copy(arrayoffiles6[fi], pathtoPNGSmobsfrontmul, true);
                                                }
                                            }*/

                                        }












                                    }
                                    else if (creatempkpermobornot == 1)
                                    {

                                    }













                                    /*

                                    //FOR MAKING FOLDERS FOR SCRIPT FILES TO BE COPIED
                                    string pathtocharactermobsmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";
                                    string pathtocharacterskeletonsmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\CharactersSkeleton";
                                    string pathtoitemsweaponsmobweaponsmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\Items" + "\\Weapons" + "\\MobWeapons";
                                    string pathtozonesscriptmobsmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";
                                    //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED


                                    string pathtoPNGSmobsmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + pathtoremovetogetscriptmobname + @"\" + "images";
                                    string pathtoPNGSmobsbackmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + pathtoremovetogetscriptmobname + @"\" + "images" + @"\" + "Back";
                                    string pathtoPNGSmobsfrontmul = prefinalpathtofilesmultiplied + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + pathtoremovetogetscriptmobname + @"\" + "images" + @"\" + "Front";

                                    Directory.CreateDirectory(pathtocharactermobsmul);
                                    Directory.CreateDirectory(pathtocharacterskeletonsmul);
                                    Directory.CreateDirectory(pathtoitemsweaponsmobweaponsmul);
                                    Directory.CreateDirectory(pathtozonesscriptmobsmul);
                                    Directory.CreateDirectory(pathtoPNGSmobsmul);
                                    Directory.CreateDirectory(pathtoPNGSmobsbackmul);
                                    Directory.CreateDirectory(pathtoPNGSmobsfrontmul);*/




                                    /*
                                    string pathtocharactermobs = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\Characters" + "\\Mobs";
                                    string pathtocharacterskeletons = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\CharactersSkeleton";
                                    string pathtoitemsweaponsmobweapons = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\Items" + "\\Weapons" + "\\MobWeapons";
                                    string pathtozonesscriptmobs = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Scripts" + "\\Zones" + "\\Scripts" + "\\Mobs";
                                    //FOR MAKING FOLDERS FOR PNG FILES TO BE COPIED

                                    string pathtoPNGSmobs = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + pathtoremovetogetscriptmobname + @"\" + "images";
                                    string pathtoPNGSmobsback = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + pathtoremovetogetscriptmobname + @"\" + "images" + @"\" + "Back";
                                    string pathtoPNGSmobsfront = prefinalpathtofiles + @"\" + pathtoremovetogetscriptmobname + ".mpk" + "\\Content" + "\\Animations" + @"\" + pathtoremovetogetscriptmobname + @"\" + "images" + @"\" + "Front";

                                    var arrayoffiles0 = Directory.GetFiles(pathtocharactermobs);
                                    var arrayoffiles1 = Directory.GetFiles(pathtocharacterskeletons);
                                    var arrayoffiles2 = Directory.GetFiles(pathtoitemsweaponsmobweapons);
                                    var arrayoffiles3 = Directory.GetFiles(pathtozonesscriptmobs);

                                    var arrayoffiles4 = Directory.GetFiles(pathtoPNGSmobs);
                                    var arrayoffiles5 = Directory.GetFiles(pathtoPNGSmobsback);
                                    var arrayoffiles6 = Directory.GetFiles(pathtoPNGSmobsfront);

                                    for (int fi = 0;fi < arrayoffiles0.Length;fi++)
                                    {
                                        File.Copy(arrayoffiles0[fi], pathtocharactermobsmul, true);
                                    }
                                    for (int fi = 0; fi < arrayoffiles1.Length; fi++)
                                    {
                                        File.Copy(arrayoffiles1[fi], pathtocharacterskeletonsmul, true);
                                    }
                                    for (int fi = 0; fi < arrayoffiles2.Length; fi++)
                                    {
                                        File.Copy(arrayoffiles2[fi], pathtoitemsweaponsmobweaponsmul, true);
                                    }
                                    for (int fi = 0; fi < arrayoffiles3.Length; fi++)
                                    {
                                        File.Copy(arrayoffiles3[fi], pathtozonesscriptmobsmul, true);
                                    }
                                    for (int fi = 0; fi < arrayoffiles4.Length; fi++)
                                    {
                                        File.Copy(arrayoffiles4[fi], pathtoPNGSmobsmul, true);
                                    }
                                    for (int fi = 0; fi < arrayoffiles5.Length; fi++)
                                    {
                                        File.Copy(arrayoffiles5[fi], pathtoPNGSmobsbackmul, true);
                                    }
                                    for (int fi = 0; fi < arrayoffiles6.Length; fi++)
                                    {
                                        File.Copy(arrayoffiles6[fi], pathtoPNGSmobsfrontmul, true);
                                    }






























                                    for (int f = 0; f < arrayofthescriptfiles.Length; f++)
                                    {
                                        ///Console.WriteLine(arrayofthescriptfiles[f]);

                                        string thefilemobname = arrayofthescriptfiles[f].Substring(lengthofstringtoremove, (arrayofthescriptfiles[f].Length) - lengthofstringtoremove);
                                        // Console.WriteLine(thefilemobname);
                                        string removetheextensionfrommobname = thefilemobname.Substring(0, thefilemobname.Length - 3);
                                        //Console.WriteLine(removetheextensionfrommobname);






                                        //themodfoldernamewithoutextension = removetheextensionfrommobname;





                                        string pathtoanimationpngs = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Content\\Animations\\" + themodfoldernamewithoutextension + "\\images"; //back/male and /front/male
                                        string pathtoscripts = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts";
                                        string pathtoscriptsmul = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + "\\Scripts";

                                        for (int i = 0; i < numberofvariants; i++)
                                        {
                                            if (debugtoconsole == 1)
                                            {
                                                Console.WriteLine("start creating Content/ variants " + i + " color for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                            }

                                            createvariantpngs(i, pathtoanimationpngs, themodfoldernamewithoutextension, 1);

                                            if (debugtoconsole == 1)
                                            {
                                                Console.WriteLine("end creating Content/ variants " + i + " color for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                            }

                                            if (debugtoconsole == 1)
                                            {
                                                Console.WriteLine("start creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                            }

                                            createvariantscripts(i, themodfoldernamewithoutextension, pathtoscripts, pathtoscriptsmul, themodfoldernamewithoutextension, 1);

                                            if (debugtoconsole == 1)
                                            {
                                                Console.WriteLine("end creating Scripts/ variants " + i + " color/hp/speed/height for the original mob " + themodfoldernamewithoutextension.ToLower() + ".");
                                            }
                                        }
                                    }
                                    */



                                    /*
                                    float mobheight = 1.65f;
                                    double mobhp = 200;
                                    double mobspeed = 1.5;
                                    string mobname = "Zombie";
                                    */

                                    //string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";
                                    /*
                                    */



                                }
                            }
                        }
                    }
                }

                if (debugtoconsole == 1)
                {
                    Console.WriteLine("end of program.");
                }

                Thread.Sleep(1);
                //goto _thread_main_loop;

                //_thread_start:
            }, 0); //100000 //999999999

            _mainTasker00.IsBackground = true;
            _mainTasker00.Priority = ThreadPriority.Normal; //AboveNormal
            _mainTasker00.SetApartmentState(ApartmentState.STA);
            _mainTasker00.Start();


            _mainTasker00.Join();

        }




        public unsafe void preparezones(int variantindex, string zonefolderselected, string pathoriginal, int indexofzone, string prefinalpathtofiles, string prefinalpathtofilesmultiplied, string pathtozones)
        {

            string zonearctic = "Arctic";
            string zoneboreal = "Boreal";
            string zonegeneric = "Generic";
            string zonemobs = "Mobs";
            string zoneruins = "Ruins";
            string zonespecial = "Special";
            string zonetemperate = "Temperate";
            string zonetropical = "Tropical";

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







            ////Console.WriteLine(prefinalpathtofiles);







            if (!Directory.Exists(prefinalpathtofiles))
            {
                //create directory
            }
            else
            {
                string pathtozonescripts = pathtozones + @"\" + chosenzonefolder;

                /*if (!Directory.Exists(pathtozonescripts))
                {
                    Directory.CreateDirectory(pathtozonescripts);
                }*/




                /*
                if (!Directory.Exists(prefinalpathtofilesmultiplied))
                {
                    Directory.CreateDirectory(prefinalpathtofilesmultiplied);
                }

                if (!Directory.Exists(prefinalpathtofilesmultiplied + @"\" + "Zones"))
                {
                    Directory.CreateDirectory(prefinalpathtofilesmultiplied + @"\" + "Zones");

                }


                if (!Directory.Exists(prefinalpathtofilesmultiplied + @"\" + "Zones" + @"\" + chosenzonefolder))
                {
                    Directory.CreateDirectory(prefinalpathtofilesmultiplied + @"\" + "Zones" + @"\" + chosenzonefolder);

                }
                */



                //string thepathtofiles = prefinalpathtofiles + "" + @"\" + "Zones" + @"\" + chosenzonefolder;

                ////Console.WriteLine(thepathtofiles);


                ////Console.WriteLine(pathtozonescripts);


                var arrayoforiginalpngfilesfront = Directory.GetFiles(pathtozonescripts);

                ////Console.WriteLine(arrayoforiginalpngfilesfront.Length);




                pathoriginal += @"\" + "original" + @"\";

                int lengthofpath = pathoriginal.Length;
                //string thepathtoremove = @"\" + "original" + "Zones" + @"\" + "Arctic";

                for (int i = 0; i < arrayoforiginalpngfilesfront.Length; i++)
                {
                    var substring = arrayoforiginalpngfilesfront[i].Substring(lengthofpath, arrayoforiginalpngfilesfront[i].Length - lengthofpath);

                    string pathtozonescripts1 = "Zones" + ".mpk" + @"\" + "Scripts" + @"\" + "Zones" + @"\" + "Zones" + @"\";

                    var substring1 = substring.Substring(pathtozonescripts1.Length + chosenzonefolder.Length + 1, substring.Length - pathtozonescripts1.Length - (chosenzonefolder.Length + 1));

                    ////Console.WriteLine(substring1);

                    ////Console.WriteLine(arrayoforiginalpngfilesfront[i]);
                    ////Console.WriteLine(substring);
                    ////Console.WriteLine(pathoriginal);

                    /*var st = substring.Substring(zonefolderselected.Length + 2, substring.Length - zonefolderselected.Length - 2);
                    //Console.WriteLine(st);
                    */
                    //File.WriteAllText(filenamewithext, File.ReadAllText(filenamewithext).Replace(scriptcharacterskeletonstring, scriptcharacterskeletonstring + scriptnamevariant).Replace(scriptcharacterskeletonpngpath, scriptcharacterskeletonpngpathreplacement + scriptnamevariant + "/"));

                    string strtoreplace = "//9SMODS";

                    //.Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.2))

                    double densitymul = 0.1;

                    string densitymultiplier = densitymul + "";

                    ////Console.WriteLine("@" + prefinalpathtofilesmultiplied + st);


                    /*
                    string finalpath = prefinalpathtofilesmultiplied + st;

                    







                    
                    string multipliedfilepath = prefinalpathtofilesmultiplied + @"\" + "Zones" + st;
                    */









                    /////Console.WriteLine(prefinalpathtofilesmultiplied);




                    /*
                    if (!Directory.Exists(prefinalpathtofilesmultiplied + @"\" + "Zones"))
                    {
                        Directory.CreateDirectory(prefinalpathtofilesmultiplied + @"\" + "Zones");
                    }

                    */



                    ////Console.WriteLine(prefinalpathtofilesmultiplied);


                    ////Console.WriteLine(substring1);


                    string multipliedfilepath = prefinalpathtofilesmultiplied + @"\" + pathtozonescripts1 + @"\" + chosenzonefolder + @"\";
                    if (!Directory.Exists(multipliedfilepath))
                    {
                        Directory.CreateDirectory(multipliedfilepath);
                    }





                    string thepathtofilewithext = multipliedfilepath + substring1;





                    File.Copy(arrayoforiginalpngfilesfront[i], thepathtofilewithext, true);


                    DirectoryInfo directoryFolder = new DirectoryInfo(thepathtofilewithext);
                    directoryFolder.Refresh();




                    //File.WriteAllText(multipliedfilepath, File.ReadAllText(multipliedfilepath).Replace(strtoreplace, strtoreplace + "TEST"));//



                    ////Console.WriteLine(multipliedfilepath);



                    File.WriteAllText(thepathtofilewithext, File.ReadAllText(thepathtofilewithext).Replace(strtoreplace, strtoreplace + "\r" + "scripts" +
".Add(GetScript<SpawnMobs" + "Skeleton" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Skeleton" + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +

".Add(GetScript<SpawnMobs" + "Zombie" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "0" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "1" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "2" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "3" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "4" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "5" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "6" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "7" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + "\r" +
".Add(GetScript<SpawnMobs" + "Zombie" + "Variant" + "8" + ">().Configure(densityMultiplier: " + densitymultiplier + "))" + ";"
                        ));









                    /*

                    if (indexofzone == 0)
                    {
                        if (st == "ZoneArcticCoastLake.cs")
                        {

                        }
                        else if (st == "ZoneArcticCoastOcean.cs")
                        {

                        }
                        else if (st == "ZoneArcticCoastForest.cs")
                        {

                        }
                    }
                    else if (indexofzone == 1)
                    {
                        if (st == "ZoneBorealCoastLake.cs")
                        {

                        }
                        else if (st == "ZoneBorealCoastOcean.cs")
                        {

                        }
                        else if (st == "ZoneBorealForest.cs")
                        {

                        }
                        else if (st == "ZoneBorealMountain.cs")
                        {

                        }
                    }
                    else if (indexofzone == 2)
                    {
                        if (st == "ZoneGenericPragmiumWasteland.cs")
                        {

                        }
                        else if (st == "ZoneGenericRoads.cs")
                        {

                        }
                        else if (st == "ZoneGenericVolcanic.cs")
                        {

                        }
                    }
                    else if (indexofzone == 3)
                    {
                        if (st == "ZoneMobsSpitter.cs")
                        {

                        }
                        else if (st == "ZoneMobsScorpion.cs")
                        {

                        }
                        else if (st == "ZoneMobsPsiGrove.cs")
                        {

                        }
                    }
                    else if (indexofzone == 4)
                    {
                        if (st == "ZoneRuinsLootIndustrial.cs")
                        {

                        }
                        else if (st == "ZoneRuinsLootLaboratory.cs")
                        {

                        }
                        else if (st == "ZoneRuinsLootMilitary.cs")
                        {

                        }
                        else if (st == "ZoneRuinsLootResidential.cs")
                        {

                        }
                        else if (st == "ZoneRuinsMobsNormal.cs")
                        {

                        }
                    }
                    else if (indexofzone == 5)
                    {
                        if (st == "ZoneEventBoss.cs")
                        {

                        }
                        else if (st == "ZoneSpecialConstructionRestricted.cs")
                        {

                        }
                        else if (st == "ZoneSpecialPlayerSpawn.cs")
                        {

                        }
                        else if (st == "ZoneSpecialRadiationTier1.cs")
                        {

                        }
                        else if (st == "ZoneSpecialRadiationTier2.cs")
                        {

                        }
                        else if (st == "ZoneSpecialRadiationTier3.cs")
                        {

                        }
                    }
                    else if (indexofzone == 6)
                    {
                        if (st == "ZoneTemperateBarren.cs")
                        {

                        }
                        else if (st == "ZoneTemperateClay.cs")
                        {

                        }
                        else if (st == "ZoneTemperateCoastLake.cs")
                        {

                        }
                        else if (st == "ZoneTemperateCoastOcean.cs")
                        {

                        }
                        else if (st == "ZoneTemperateForest.cs")
                        {

                        }
                        else if (st == "ZoneTemperateMeadow.cs")
                        {

                        }
                        else if (st == "ZoneTemperateMountain.cs")
                        {

                        }
                        else if (st == "ZoneTemperateSalt.cs")
                        {

                        }
                        else if (st == "ZoneTemperateSwamp.cs")
                        {

                        }
                    }
                    else if (indexofzone == 7)
                    {
                        if (st == "ZoneTropicalForest.cs")
                        {

                        }
                        else if (st == "ZoneTropicalMountain.cs")
                        {

                        }
                    }*/
                }
            }
        }









































        public unsafe void createvariantpngs(int variantindex, string pathtoanimationpngs, string themodfoldernamewithoutextension, int thetypeofgenerator)
        {
            //float rand = (float)sc_maths.getSomeRandNum(0.75f, 1);

            float minrandm = 0.85f; //0.998f
            float maxrandm = 0.99f;//1.015f //0.999f

            float rand = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandm, maxrandm, 1.0f, 0, -1);

            float diff = maxrandm - minrandm;

            rand = 1.0f;// minrandm + (diff * rand);

            /*float minrandg = 0.5f; //0.998f
            float maxrandg = 0.99f;//1.015f //0.999f

            float minrandb = 0.5f; //0.998f
            float maxrandb = 0.99f;//1.015f //0.999f

            float minrandr = 0.5f; //0.998f
            float maxrandr = 0.99f;//1.015f //0.999f
            */

            float minrandg = 0.90f;
            float maxrandg = 0.99f;//1.015f //0.999f

            float minrandb = 0.90f; //0.998f
            float maxrandb = 0.99f;//1.015f //0.999f

            float minrandr = 0.90f; //0.998f
            float maxrandr = 0.99f;//1.015f //0.999f

            float brightnessrandg = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandg, maxrandg, 1.0f, 0, -1);
            float brightnessrandb = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandb, maxrandb, 1.0f, 0, -1);
            float brightnessrandr = (float)sc_maths.getSomeRandNumThousandDecimalfloat(minrandr, maxrandr, 1.0f, 0, -1);

            float randg = brightnessrandg;
            float randb = brightnessrandb;// (float)sc_maths.getSomeRandNumThousandDecimalfloat(0.9995f, 0.9999f, 1.0f, 0, -1);
            float randr = brightnessrandr;// (float)sc_maths.getSomeRandNumThousandDecimalfloat(0.9995f, 0.9999f, 1.0f, 0, -1) * 1.15f;

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




            //string finalPathoriBack = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + originalfolder + @"\" + "Back" + @"\" + "Male" + @"\";
            //string finalPathoriFront = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + originalfolder + @"\" + "Front" + @"\" + "Male" + @"\";
            //string finalPathmulBack = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + theimagesfolder + @"\" + "Back" + @"\" + "Male" + @"\";
            //string finalPathmulFront = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + folderNamemulPNGS + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + theimagesfolder + @"\" + "Front" + @"\" + "Male" + @"\";


            if (thetypeofgenerator == 1)
            {

            }














            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderNameCryofallPNGScriptVariantBuilder = "#Cryofallscriptgen";
            DirectoryInfo directoryFolder = new DirectoryInfo(folderNameCryofallPNGScriptVariantBuilder);
            directoryFolder.Refresh();

            string prefinalpathtofiles = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "original";
            string prefinalpathtofilesmultiplied = pathToDesktop + @"\" + folderNameCryofallPNGScriptVariantBuilder + @"\" + "multiplied";


            sccstextureloader texturetoload;
            string finalPathOriginalFront = @"\" + "Front";
            string finalPathOriginalBack = @"\" + "Back";

            ////Console.WriteLine(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");

            var arrayoforiginalpngfilesfront = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male");
            var arrayoforiginalpngfilesback = Directory.GetFiles(pathtoanimationpngs + finalPathOriginalBack + @"\" + "Male");





            ////Console.WriteLine(pathtoanimationpngs + finalPathOriginalFront);

            string folderNamemulPNGS = "multiplied";

            if (!Directory.Exists(prefinalpathtofilesmultiplied))
            {
                Directory.CreateDirectory(prefinalpathtofilesmultiplied); // + @"\" + "Zones"
            }




            string mobname = themodfoldernamewithoutextension;

            string themobfolder = mobname + "Variant" + variantindex;

            string finalPathmulBack = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + "Back" + @"\" + "Male" + @"\";
            string finalPathmulFront = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\" + "Front" + @"\" + "Male" + @"\";





            string finalPathanims = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
            var arrayoforiginalpngfilesanims = Directory.GetFiles(finalPathanims);

            ////Console.WriteLine(finalPathanims);


            ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);
            string finalPathanims1 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
            string finalPathanims2 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder; // + @"\" + "images"


            if (!Directory.Exists(finalPathanims2 + @"\" + "images" + @"\" + "Front" + @"\" + "Male"))
            {
                Directory.CreateDirectory(finalPathanims2 + @"\" + "images" + @"\" + "Front" + @"\" + "Male"); // + @"\" + "Zones"
            }


            if (!Directory.Exists(finalPathanims2 + @"\" + "images" + @"\" + "Back" + @"\" + "Male"))
            {
                Directory.CreateDirectory(finalPathanims2 + @"\" + "images" + @"\" + "Back" + @"\" + "Male"); // + @"\" + "Zones"
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
            string finalPathweapon = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"
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
                string finalPathanimsa = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"

                string finalPathanimsf = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + "Front" + @"\" + "Male"; // + @"\" + "images"
                string finalPathanimsb = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + "Back" + @"\" + "Male"; // + @"\" + "images"

                if (!Directory.Exists(finalPathanimsf))
                {
                    Directory.CreateDirectory(finalPathanimsf); // + @"\" + "Zones"
                }
                if (!Directory.Exists(finalPathanimsb))
                {
                    Directory.CreateDirectory(finalPathanimsb); // + @"\" + "Zones"
                }


                string finalPathPNGSf = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + "Front" + @"\" + "Male"; // + @"\" + "images"
                string finalPathPNGSb = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images" + @"\" + "Back" + @"\" + "Male"; // + @"\" + "images"


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





                var arrayoforiginalpngsb = Directory.GetFiles(finalPathPNGSb);
                //copy pngs back
                for (int i = 0; i < arrayoforiginalpngsb.Length; i++)
                {

                    ////Console.WriteLine(finalPathanims1);
                    ////Console.WriteLine(arrayoforiginalpngfilesanims[i]);


                    string finalfilename = arrayoforiginalpngsb[i].Substring(finalPathPNGSb.Length + 1, (arrayoforiginalpngsb[i].Length - (finalPathPNGSb.Length + 1)));
                    ////Console.WriteLine(finalfilename);

                    File.Copy(arrayoforiginalpngsb[i], finalPathanimsb + @"\" + finalfilename, true);
                }
                //copy pngs back












                //copy weapon not sure if that is necessary now
                string finalPathweapon1 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"
                var arrayoforiginalweapon1 = Directory.GetFiles(finalPathweapon1);
                ////Console.WriteLine(finalPathweapon1);
                string finalPathweapon2 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname + @"\" + "images"; // + @"\" + "images"

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
                string finalPathweapon11 = prefinalpathtofiles + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"
                var arrayoforiginalanims11 = Directory.GetFiles(finalPathweapon11);
                ////Console.WriteLine(finalPathweapon1);
                string finalpathanims = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + mobname; // + @"\" + "images"

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

































            if (!Directory.Exists(finalPathmulBack))
            {
                Directory.CreateDirectory(finalPathmulBack); // + @"\" + "Zones"
            }

            if (!Directory.Exists(finalPathmulFront))
            {
                Directory.CreateDirectory(finalPathmulFront); // + @"\" + "Zones"
            }

            ////Console.WriteLine("TEST"+finalPathmulFront);
            ////Console.WriteLine(arrayoforiginalpngfilesfront.Length);

            ////Console.WriteLine("TEST" + finalPathmulFront);

            string finalPathoriBack = pathtoanimationpngs + finalPathOriginalBack + @"\" + "Male";
            string finalPathoriFront = pathtoanimationpngs + finalPathOriginalFront + @"\" + "Male";

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


                    //break;

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
                else
                {

                    /*string finalPathanims = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\" + "images" + @"\";

                    File.Copy(arrayoforiginalpngfilesfront[i], finalPathanims, true);
                    */

                }


            }









            for (int i = 0; i < arrayoforiginalpngfilesback.Length; i++)
            {
                texturetoload = new sccstextureloader();

                var textureinit = texturetoload.Initialize(device, arrayoforiginalpngfilesback[i]);

                if (textureinit)
                {
                    ////Console.WriteLine("texture initialiased");

                    var factory = new SharpDX.WIC.ImagingFactory();
                    var filename = arrayoforiginalpngfilesback[i];// "OnBoardComputer.png";

                    //string finalfilename = arrayoforiginalpngfilesback[i].Substring(finalPathmulback.Length-2, (arrayoforiginalpngfilesback[i].Length-1 - finalPathmulback.Length - 1));

                    ////Console.WriteLine("finalPathoriback:" + finalPathoriback);

                    string finalfilename = arrayoforiginalpngfilesback[i].Substring(finalPathoriBack.Length + 1, (arrayoforiginalpngfilesback[i].Length - finalPathoriBack.Length - 5));
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

                    ////Console.WriteLine("TEST" + finalPathmulback + finalfilename + ".png");



                    ////Console.WriteLine(finalPathmulBack);


                    //break;

                    var somebitmap = new System.Drawing.Bitmap(columnsonboardcomputer, rowsonboardcomputer, columnsonboardcomputer * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, Marshal.UnsafeAddrOfPinnedArrayElement(onboardcomputeiconpixeldata, 0));
                    //somebitmap.Save(@"C:\Users\steve\Desktop\screenRecord\" + bitmapcounter + "_" + rowsonboardcomputer.ToString("00") + columnsonboardcomputer.ToString("00") + ".png");
                    somebitmap.Save(finalPathmulBack + finalfilename + ".png");

                    bitmapcounter++;

                    device.ImmediateContext.UnmapSubresource(theonboardcomputertextureFINAL, 0);
                    DeleteObject(interptr1);
                    //DISCARDED
                    //DISCARDED
                    //DISCARDED                 
                }
                else
                {

                }
            }










            //COPYANIMATIONS
            string finalPathmulBack1 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\";
            string finalPathmulFront1 = prefinalpathtofilesmultiplied + @"\" + themodfoldernamewithoutextension + ".mpk" + @"\" + "Content" + @"\" + "Animations" + @"\" + themobfolder + @"\";



























        }




        public void createvariantscripts(int variantindex, string mobname, string pathtoscripts, string pathtoscriptsmul, string themodfoldernamewithoutextension, int thetypeofgenerator)// double mobspeed, double mobhp, float mobheight
        {








            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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








        //MADE BY STEVE CHASSÉ AKA NINEKORN FOR MODS INSIDE OF THE GAME VOID EXPANSE WHERE I WANTED TO MULTIPLY DRONE FORMATION SCRIPTS TO HAVE RESULTS FASTER CODING.
        static int someInitItems = 0;
        //UI THREAD TEST
        //////////////////////////////////
        //////////////////////////////////
        public static void sccsScriptAutoCorrectNMultiply()
        {
            //////Console.WriteLine("0_mainThreadStarter");
            if (someInitItems == 0)
            {
                //////Console.WriteLine("1_mainThreadStarter");
                var updateMainUITitle2 = new Action(() =>
                {
                    //_mainUpdateThread();
                });
                // XmlDocument doc = new XmlDocument();
                //doc.Load("");

                string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                //////Console.WriteLine("2_mainThreadStarter");
                string folderName = "#Cryofallscriptgen";
                DirectoryInfo directoryFolder = new DirectoryInfo(folderName);
                directoryFolder.Refresh();
                string pathToDesktopFolder = pathToDesktop + @"\" + folderName;

                //////Console.WriteLine("2_mainThreadStarter");
                if (!Directory.Exists(pathToDesktopFolder))
                {
                    ////Console.WriteLine("0the directory !exists");
                    Directory.CreateDirectory(pathToDesktopFolder);
                }
                else
                {
                    ////Console.WriteLine("0the directory exists");
                }



                string folderNameOriginal = "original";
                DirectoryInfo dirnameOriginal = new DirectoryInfo(folderNameOriginal);
                dirnameOriginal.Refresh();
                //////Console.WriteLine("2_mainThreadStarter");
                if (!Directory.Exists(pathToDesktop + @"\" + folderName))
                {
                    ////Console.WriteLine("1the directory !exists");
                    Directory.CreateDirectory(folderNameOriginal);
                }
                else
                {
                    ////Console.WriteLine("1the directory exists");
                }

                string finalPathOriginal = pathToDesktop + @"\" + folderName + @"\" + folderNameOriginal;
                ////Console.WriteLine(finalPathOriginal);




                string folderNameMul = "multiplied";
                string mulPath = pathToDesktop + @"\" + folderName + @"\" + folderNameMul;
                if (!Directory.Exists(mulPath))
                {
                    ////Console.WriteLine("2the directory !exists");
                    Directory.CreateDirectory(mulPath);
                }
                else
                {
                    ////Console.WriteLine("2the directory exists");
                }


                var arrayOfFiles = Directory.GetFiles(finalPathOriginal);


                if (arrayOfFiles.Length > 0)
                {
                    ////Console.WriteLine("Got Files");
                }
                else
                {
                    //////Console.WriteLine("!Got Files");
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
                        //////Console.WriteLine("3the directory exists");

                        var filenewPath = folderNameMul + @"\" + arrayOfFiles[i];

                        var someString = pathToDesktop + @"\" + folderName + @"\" + folderNameOriginal + @"\";
                        //var test = arrayOfFiles[i];
                        var newstring = arrayOfFiles[i].Substring(someString.Length);
                        arrayOfOnlyfileNamesFormationOne[i] = newstring;

                        //var removedExtension = arrayOfFiles[i].Substring(someString.Length);

                        var someOtherString = Path.ChangeExtension(newstring, "");
                        //////Console.WriteLine(newstring);

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
                        //////Console.WriteLine(output);

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

                            ////Console.WriteLine(someLastString);


                            var menuOption = 1;

                            if (menuOption == 0)
                            {

                                var lastString = "Mining_";
                                var lastString2 = "_" + indexMain;
                                File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("Combat_cc_", lastString).Replace("_1", lastString2));



                                if (File.Exists(someLastString))
                                {
                                    //////Console.WriteLine("02File.Exists");
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
                                    //////Console.WriteLine("02File.Exists");
                                    FileInfo filinfo = new FileInfo(someLastString);
                                    filinfo.Refresh();
                                }


                                //var newString = File.ReadAllText(someLastString);

                                //lastString = "Mining_";
                                var lastString2 = "_" + indexMain;
                                File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("_1", lastString2));
                            }














                            //////Console.WriteLine(someLastString);

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
                    //////Console.WriteLine(arrayOfFilesNames[i]);
                    //Directory.Fil(mulPath + @"\" + arrayOfOnlyfileNamesFormationOne[i]);
                    if (File.Exists(arrayOfOnlyfileNamesFormationOne[i]))
                    {
                        //////Console.WriteLine("02File.Exists");
                        FileInfo filinfo = new FileInfo(arrayOfOnlyfileNamesFormationOne[i]);
                        filinfo.Delete();
                    }

                }



                dirnameMulNewFiles.Refresh();





                ////Console.WriteLine("ended scripts multiplication");

                //var someString = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\";
                //var test = arrayOfFiles[i];
                //var newstring = arrayOfFiles[i].Substring(someString.Length);
                //var someTest = newstring; // arrayOfOnlyfileNamesFormationOne[i] 



                /*for (int i = 0; i < arrayOfOnlyfileNamesFormationOne.Length; i++)
                {
                    if (arrayOfOnlyfileNamesFormationOne[i].Contains(""))
                    {

                    }
                    //////Console.WriteLine(arrayOfOnlyfileNamesFormationFive[i]);

                    if (File.Exists(arrayOfOnlyfileNamesFormationOne[i]))
                    {
                        //////Console.WriteLine("02File.Exists");
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

                    //////Console.WriteLine(someLastString);

                    if (File.Exists(someLastString))
                    {
                        //////Console.WriteLine("02File.Exists");
                        FileInfo filinfo = new FileInfo(someLastString);
                        filinfo.Refresh();

                        var someResults = File.ReadAllText(someLastString);

                        someResults.Replace("_1", "_5");

                        //File.WriteAllText(someLastString, someResults);

                        File.WriteAllText(someLastString, File.ReadAllText(someLastString).Replace("_1", "_5"));
                    }
                    else
                    {
                       // ////Console.WriteLine("02File.!Exists");
                    }
                }*/

























                //arrayOfOnlyfileNames[i]
                //////Console.WriteLine(someResults);








                /*using (XmlReader xmlreader = new XmlTextReader(someLastString))
                {
                    //////Console.WriteLine("element: ");
                    while (xmlreader.Read())
                    {
                        ////Console.WriteLine("element: ");
                        //var element = xmlreader.Name;
                        //////Console.WriteLine("element: " + element);
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

                // ////Console.WriteLine("4the directory exists " + arrayOfFiles[i]);

                /*if (!File.Exists(lastPath))
                {
                    ////Console.WriteLine("00!File.Exists");
                    FileInfo filinfo = new FileInfo(lastPath);
                    filinfo.Refresh();
                }
                else
                {
                    ////Console.WriteLine("01File.Exists");
                }*/
                //var result = Path.ChangeExtension(lastPath, ".xml");


                /*var lastPath2 = pathToDesktop + @"\" + folderName + @"\" + folderNameMul + @"\" + someOtherString + ".xml";
                //XmlDocument doc = new XmlDocument();
                //doc.Load(lastPath);


                if (File.Exists(lastPath2))
                {
                    ////Console.WriteLine("02File.Exists");
                    FileInfo filinfo = new FileInfo(lastPath2);
                    filinfo.Refresh();
                }
                else
                {
                    ////Console.WriteLine("02File.!Exists");
                }*/
                //XDocument doc = XDocument.Load(lastPath2);
                //doc.Save(lastPath2);


                /*using (XmlTextReader textReader = new XmlTextReader(lastPath2))
                {
                    while (textReader.Read())
                    {
                        var element = textReader.Name;
                        //////Console.WriteLine(element + "");

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
                ////Console.WriteLine(result);
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










                //////Console.WriteLine("3_mainThreadStarter");
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