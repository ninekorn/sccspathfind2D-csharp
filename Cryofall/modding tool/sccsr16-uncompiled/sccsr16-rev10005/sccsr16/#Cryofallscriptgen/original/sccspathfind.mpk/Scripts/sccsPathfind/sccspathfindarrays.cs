//DEVELOPPED BY STEVE CHASSÉ AKA NINEKORN AKA NINE AKA 9 dob13may1983. 2023 JUNE 06TH REVISION
namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
    using sccsvec2int = sccspathfindstructs.sccsvec2int;
    using static sccspathfindstructs;
    using System.Collections.Generic;
    using System;
    using AtomicTorch.GameEngine.Common.Primitives;
    using AtomicTorch.CBND.GameApi.Data.Characters;

    public static class sccspathfindarrays
    {
        public static List<List<sccspathfindperscriptmobdatastruct>> pathfindpermobdata = new List<List<sccspathfindperscriptmobdatastruct>>();
        public static List<List<sccspathfindactionstruct>> pathfindpermobdatalight = new List<List<sccspathfindactionstruct>>();
        //public static List<sccspools> sccspoolspathfind = new List<sccspools>();
        //public static List<List<int>> pathfindpermobdatadeadindex = new List<List<int>>();
        //public static List<List<int>> pathfindpermobdatadeadindex = new List<List<int>>();
        public static List<Queue<int>> pathfindpermobdatadeadindex = new List<Queue<int>>();

        public static byte initlists = 0;

        public static int ProcessAddToMainList(
            ICharacter characterNpc, out int mobtypeofindex)
        {

            if (initlists == 0)
            {
                sccspools.createpoolscript();



                int currentmodmobtypes = 28 + 1;

                for (int i = 0; i < currentmodmobtypes; i++)
                {
                    pathfindpermobdata.Add(new List<sccspathfindperscriptmobdatastruct>());
                    pathfindpermobdatalight.Add(new List<sccspathfindactionstruct>());
                    pathfindpermobdatadeadindex.Add(new Queue<int>());
                    /*var poolscriptlist = new List<sccspools>();
                    sccspools apool = new sccspools();
                    poolscriptlist.Add(apool);*/
                    //sccspoolspathfind.Add(List<sccspools>());
                    //sccspoolspathfind.Add(new sccspools());
                }

                initlists = 1;
            }



            int indexbefore = -1;
            int thearrayindex = -1;


            /*
            if (characterNpc.Name.Substring(0, "bear".Length).ToLower() == "bear") //"Bear"
            {
                thearrayindex = 0;
            }
            else if (characterNpc.Name.Substring(0, "black beetle".Length).ToLower() =="black beetle")//"Black beetle"
            {
                thearrayindex = 1;
            }
            else if (characterNpc.Name.Substring(0, "brood drone".Length).ToLower() =="brood drone")//"Brood drone"
            {
                thearrayindex = 2;
            }
            else if (characterNpc.Name.Substring(0, "brood guardian".Length).ToLower() =="brood guardian")//"Brood guardian"
            {
                thearrayindex = 3;
            }
            else if (characterNpc.Name.Substring(0, "burrower".Length).ToLower() =="burrower")//"Burrower"
            {
                thearrayindex = 4;
            }
            else if (characterNpc.Name.Substring(0, "cloaked lizard".Length).ToLower() =="cloaked lizard")//"Cloaked lizard"
            {
                thearrayindex = 5;
            }
            else if (characterNpc.Name.Substring(0, "crab".Length).ToLower() =="crab")//"Crab"
            {
                thearrayindex = 6;
            }
            else if (characterNpc.Name.Substring(0, "crawler".Length).ToLower() =="crawler")//"Crawler"
            {
                thearrayindex = 7;
            }
            else if (characterNpc.Name.Substring(0, "fire lizard".Length).ToLower() =="fire lizard")//"Fire lizard"
            {
                thearrayindex = 8;
            }
            else if (characterNpc.Name.Substring(0, "floater".Length).ToLower() =="floater")//"Floater"
            {
                thearrayindex = 9;
            }
            else if (characterNpc.Name.Substring(0, "honey badger".Length).ToLower() =="honey badger")//"Honey badger"
            {
                thearrayindex = 10;
            }
            else if (characterNpc.Name.Substring(0, "hyena".Length).ToLower() =="hyena")//"Hyena"
            {
                thearrayindex = 11;
            }
            else if (characterNpc.Name.Substring(0, "mutated boar".Length).ToLower() =="mutated boar")//"Mutated boar"
            {
                thearrayindex = 12;
            }
            else if (characterNpc.Name.Substring(0, "mutated hyena".Length).ToLower() =="mutated hyena")//"Mutated hyena"
            {
                thearrayindex = 13;
            }
            else if (characterNpc.Name.Substring(0, "mutated wolf".Length).ToLower() =="mutated wolf")//"Mutated wolf"
            {
                thearrayindex = 14;
            }
            else if (characterNpc.Name.Substring(0, "pragmium beetle".Length).ToLower() =="pragmium beetle")//"Pragmium beetle"
            {
                thearrayindex = 15;
            }
            else if (characterNpc.Name.Substring(0, "scorpion".Length).ToLower() =="scorpion")//"Scorpion"
            {
                thearrayindex = 16;
            }
            else if (characterNpc.Name.Substring(0, "blue snake".Length).ToLower() =="blue snake")//"Blue snake"
            {
                thearrayindex = 17;
            }
            else if (characterNpc.Name.Substring(0, "brown snake".Length).ToLower() =="brown snake")//"Brown snake"
            {
                thearrayindex = 18;
            }
            else if (characterNpc.Name.Substring(0, "bear".Length).ToLower() =="Green snake")//"Green snake"
            {
                thearrayindex = 19;
            }
            else if (characterNpc.Name.Substring(0, "spitter".Length).ToLower() =="spitter")//"Spitter"
            {
                thearrayindex = 20;
            }
            else if (characterNpc.Name.Substring(0, "tropical boar".Length).ToLower() =="tropical boar")//"Tropical boar"
            {
                thearrayindex = 21;
            }
            else if (characterNpc.Name.Substring(0, "wild boar".Length).ToLower() =="wild boar")//"Wild boar"
            {
                thearrayindex = 22;
            }
            else if (characterNpc.Name.Substring(0, "wolf".Length).ToLower() =="wolf")//"Wolf"
            {
                thearrayindex = 23;
            }
            else if (characterNpc.Name.Substring(0, "polar wolf".Length).ToLower() =="polar wolf")//"Polar wolf"
            {
                thearrayindex = 24;
            }
            else if (characterNpc.Name.Substring(0, "polar bear".Length).ToLower() =="polar bear")//"Polar bear"
            {
                thearrayindex = 25;
            }
            else if (characterNpc.Name.Substring(0, "skeleton".Length).ToLower() =="skeleton")//"Skeleton"
            {
                thearrayindex = 26;
            }
            else if (characterNpc.Name.Substring(0, "zombie".Length).ToLower() =="zombie")//"Zombie"
            {
                thearrayindex = 27;
            }
            else
            {
                thearrayindex = 28;
            }*/



            if (characterNpc.Name.Contains("Bear"))
            {
                thearrayindex = 0;
            }
            else if (characterNpc.Name.Contains("Black beetle"))
            {
                thearrayindex = 1;
            }
            else if (characterNpc.Name.Contains("Brood drone"))
            {
                thearrayindex = 2;
            }
            else if (characterNpc.Name.Contains("Brood guardian"))
            {
                thearrayindex = 3;
            }
            else if (characterNpc.Name.Contains("Burrower"))
            {
                thearrayindex = 4;
            }
            else if (characterNpc.Name.Contains("Cloaked lizard"))
            {
                thearrayindex = 5;
            }
            else if (characterNpc.Name.Contains("Crab"))
            {
                thearrayindex = 6;
            }
            else if (characterNpc.Name.Contains("Crawler"))
            {
                thearrayindex = 7;
            }
            else if (characterNpc.Name.Contains("Fire lizard"))
            {
                thearrayindex = 8;
            }
            else if (characterNpc.Name.Contains("Floater"))
            {
                thearrayindex = 9;
            }
            else if (characterNpc.Name.Contains("Honey badger"))
            {
                thearrayindex = 10;
            }
            else if (characterNpc.Name.Contains("Hyena"))
            {
                thearrayindex = 11;
            }
            else if (characterNpc.Name.Contains("Mutated boar"))
            {
                thearrayindex = 12;
            }
            else if (characterNpc.Name.Contains("Mutated hyena"))
            {
                thearrayindex = 13;
            }
            else if (characterNpc.Name.Contains("Mutated wolf"))
            {
                thearrayindex = 14;
            }
            else if (characterNpc.Name.Contains("Pragmium beetle"))
            {
                thearrayindex = 15;
            }
            else if (characterNpc.Name.Contains("Scorpion"))
            {
                thearrayindex = 16;
            }
            else if (characterNpc.Name.Contains("Blue snake"))
            {
                thearrayindex = 17;
            }
            else if (characterNpc.Name.Contains("Brown snake"))
            {
                thearrayindex = 18;
            }
            else if (characterNpc.Name.Contains("Green snake"))
            {
                thearrayindex = 19;
            }
            else if (characterNpc.Name.Contains("Spitter"))
            {
                thearrayindex = 20;
            }
            else if (characterNpc.Name.Contains("Tropical boar"))
            {
                thearrayindex = 21;
            }
            else if (characterNpc.Name.Contains("Wild boar"))
            {
                thearrayindex = 22;
            }
            else if (characterNpc.Name.Contains("Wolf"))
            {
                thearrayindex = 23;
            }
            else if (characterNpc.Name.Contains("Polar wolf"))
            {
                thearrayindex = 24;
            }
            else if (characterNpc.Name.Contains("Polar bear"))
            {
                thearrayindex = 25;
            }
            else if (characterNpc.Name.Contains("Skeleton"))
            {
                thearrayindex = 26;
            }
            else if (characterNpc.Name.Contains("Zombie"))
            {
                thearrayindex = 27;
            }
            else
            {
                thearrayindex = 28;
            }

            mobtypeofindex = thearrayindex;


            int hasrecycleddeadmobindex = 0;
            if (pathfindpermobdatadeadindex[mobtypeofindex].Count > 0)
            {
                var theindextouse = pathfindpermobdatadeadindex[mobtypeofindex].Dequeue();

                indexbefore = theindextouse;
                hasrecycleddeadmobindex = 1;
            }
            else
            {
                indexbefore = pathfindpermobdata[thearrayindex].Count;
                //ListOfThisInstanceMob[thearrayindex].Count;
                //ListOfThisInstanceMob[thearrayindex].Add(characterNpc);
            }










            //pathfindpermobdatadeadindex













            //sccspathfinddata pathfindscript =new sccspathfinddata();
            //sccspathfindperscriptmobdatastruct thenewstructdata =new sccspathfindperscriptmobdatastruct();
            //List<sccspathfindobstaclestruct> listofobstaclesinit =new List<sccspathfindobstaclestruct>();
            //List<sccsvec2int> listofobstaclesonthewaytwo =new List<sccsvec2int>();
            //List<sccspathfindobstaclestruct> listofobstaclesontheway =new List<sccspathfindobstaclestruct>();
            //sccsvec2float x9
            //sccsvec2int x1
            //Vector2D x3


















            if (hasrecycleddeadmobindex == 0)
            {


                sccspathfindperscriptmobdatastruct thenewstructdata = sccspools.getpooledsccspathfindperscriptmobdatastruct();// new sccspathfindperscriptmobdatastruct();

                thenewstructdata.pathfindscript = sccspools.getpooledsccspathfinddata();//new sccspathfinddata();
                thenewstructdata.startpathfindmainswtc = 0;

                thenewstructdata.initialpathfindstartpos = sccspools.getpooledsccsvec2float();//new sccsvec2float();
                thenewstructdata.initialpathfindtargetpos = sccspools.getpooledsccsvec2float();//new sccsvec2float();
                thenewstructdata.lastinitialpathfindtargetpos = sccspools.getpooledsccsvec2float();//new sccsvec2float();

                thenewstructdata.swtcdebug = 0;
                thenewstructdata.distnpctoplayersqrtlast = 0;

                thenewstructdata.listofobstaclesinit = sccspools.getpooledsccspathfindobstaclestruct();// new List<sccspathfindobstaclestruct>();

                thenewstructdata.listofobstaclesonthewaytwo = sccspools.getpooledsccsvec2intlist();//new List<sccsvec2int>();
                thenewstructdata.listofobstaclesontheway = sccspools.getpooledsccspathfindobstaclestruct();//new List<sccspathfindobstaclestruct>();

                thenewstructdata.npcposlast = sccspools.getpooledsccsvec2float();//new sccsvec2float();


                thenewstructdata.lastdistsquared = 0;
                thenewstructdata.directionnpctopathfindnodef = new Vector2F(0, 0);
                thenewstructdata.adminnotify = sccspools.getpooledConsoleAdminNotifyPlayer();//new ConsoleAdminNotifyPlayer();
                thenewstructdata.distsquared = 0;

                thenewstructdata.playerpos = sccspools.getpooledsccsvec2float();// new sccsvec2float();
                thenewstructdata.npcpos = sccspools.getpooledsccsvec2float();// new sccsvec2float();

                thenewstructdata.disttonode0last = 0;
                thenewstructdata.playercharactercenter = new Vector2D();
                thenewstructdata.npcCharacterCenter = new Vector2D();

                thenewstructdata.npcmovementtype = 0;
                thenewstructdata.disttonode = 0;

                thenewstructdata.lastcurrentnpcpos = sccspools.getpooledsccsvec2float();// new sccsvec2float();

                //List<sccspathfindnode> pathfindretracedpath = new List<sccspathfindnode>();
                thenewstructdata.pathfindretracedpathswtc = 0;
                //thenewstructdata.poppednode;// = new sccspathfindnode();
                thenewstructdata.haspopped = false;
                thenewstructdata.lasthaspopped = false;
                thenewstructdata.haspoppedcounter = 0;
                thenewstructdata.lasthaspoppedcounter = 0;

                thenewstructdata.haspoppedcountermax = 1;

                thenewstructdata.lastcurrentnpcdirection = sccspools.getpooledsccsvec2float();//new sccsvec2float();
                thenewstructdata.currentnpcdirection = sccspools.getpooledsccsvec2float();//new sccsvec2float();

                thenewstructdata.frontdirectionposition = new Vector2D();
                //Vector2D frontdirectionpositionnotnormalized = new Vector2D();
                thenewstructdata.frontdirectionpositionnotnormalized = 0.0;
                thenewstructdata.lastdistnpctoplayersqrt = 0;
                thenewstructdata.distnpctoplayersqrt = 0;

                thenewstructdata.hasreachedpathend = 0;
                thenewstructdata.firstnodeofpathfindpoppedswtc = 0;
                thenewstructdata.decrementcounterforpath = 0;

                thenewstructdata.pathfindmaincounter = 0;
                thenewstructdata.pathfindmaincountermax = 0;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. THE HIGHER THE VALUE, THE LESS TIMES THE PATHFIND LOGIC IS ENGAGED.logic is currently broken unless it's at zero

                thenewstructdata.haschasedcharacter = 0;

                thenewstructdata.hasreachingnodestuckframecounter = 0;
                thenewstructdata.hasreachingnodestuckframecountermax = 30;

                thenewstructdata.hasreachedandattackedplayer = 0;
                thenewstructdata.lasthasreachedandattackedplayer = 0;

                thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier = 0.5f;

                if (thearrayindex == 0)//("Bear"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(650 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 1)//("Black beetle"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(325 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 2)//("Brood drone"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1150 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 3)//("Brood guardian"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1500 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 4)//("Burrower"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(450 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 5)//("Cloaked lizard"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(750 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 6)//("Crab"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(150 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 7)//("Crawler"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1250 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 8)//("Fire lizard"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1000 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 9)//("Floater"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(950 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 10)//("Honey badger"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(400 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 11)//("Hyena"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(400 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 12)//("Mutated boar"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(350 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 13)//("Mutated hyena"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(675 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 14)//("Mutated wolf"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(750 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 15)//("Pragmium beetle"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(350 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 16)//("Scorpion"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(275 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 17)//("Blue snake"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(275 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 18)//("Brown snake"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(300 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 19)//("Green snake"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(285 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 20)//("Spitter"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(500 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 21)//("Tropical boar"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(225 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 22)//("Wild boar"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(250 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 23)//("Wolf"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(450 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 24)//("Polar wolf"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(650 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 25)//("Polar bear"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(850 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 26)//("Skeleton"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(350 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else if (thearrayindex == 27)//("Zombie"))
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(150 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
                }
                else
                {
                    thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(150 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);

                }

                pathfindpermobdata[thearrayindex].Add(thenewstructdata);



                sccspathfindactionstruct pathfindaction = new sccspathfindactionstruct();

                pathfindaction.anglerad = 0;
                pathfindaction.direction = new Vector2F(0, 0);
                pathfindaction.thenpccharacter = characterNpc;





                if (thearrayindex == 0)//("Bear"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 0;
                }
                else if (thearrayindex == 1)//("Black beetle"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 1;
                }
                else if (thearrayindex == 2)//("Brood drone"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 2;
                }
                else if (thearrayindex == 3)//("Brood guardian"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 3;
                }
                else if (thearrayindex == 4)//("Burrower"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 4;
                }
                else if (thearrayindex == 5)//("Cloaked lizard"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 5;
                }
                else if (thearrayindex == 6)//("Crab"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 6;
                }
                else if (thearrayindex == 7)//("Crawler"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 7;
                }
                else if (thearrayindex == 8)//("Fire lizard"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 8;
                }
                else if (thearrayindex == 9)//("Floater"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 9;
                }
                else if (thearrayindex == 10)//("Honey badger"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 10;
                }
                else if (thearrayindex == 11)//("Hyena"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 11;
                }
                else if (thearrayindex == 12)//("Mutated boar"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 12;
                }
                else if (thearrayindex == 13)//("Mutated hyena"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 13;
                }
                else if (thearrayindex == 14)//("Mutated wolf"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 14;
                }
                else if (thearrayindex == 15)//("Pragmium beetle"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 15;
                }
                else if (thearrayindex == 16)//("Scorpion"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 16;
                }
                else if (thearrayindex == 17)//("Blue snake"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 17;
                }
                else if (thearrayindex == 18)//("Brown snake"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 18;
                }
                else if (thearrayindex == 19)//("Green snake"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 19;
                }
                else if (thearrayindex == 20)//("Spitter"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 20;
                }
                else if (thearrayindex == 21)//("Tropical boar"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 21;
                }
                else if (thearrayindex == 22)//("Wild boar"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 22;
                }
                else if (thearrayindex == 23)//("Wolf"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 23;
                }
                else if (thearrayindex == 24)//("Polar wolf"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 24;
                }
                else if (thearrayindex == 25)//("Polar bear"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 25;
                }
                else if (thearrayindex == 26)//("Skeleton"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 26;
                }
                else if (thearrayindex == 27)//("Zombie"))
                {
                    pathfindaction.pathfindarraysorttypeoption = 0;
                    pathfindaction.mobtypeofindex = 27;
                }
                else
                {
                    pathfindaction.pathfindarraysorttypeoption = 1;
                    pathfindaction.mobtypeofindex = 28;
                }




                pathfindpermobdatalight[thearrayindex].Add(pathfindaction);



            }
            else
            {


                var pathfindpermobdatatoreset = pathfindpermobdata[thearrayindex][indexbefore];
                //var pathfindpermobdatalighttoreset = pathfindpermobdatalight[thearrayindex][indexbefore];

                if (pathfindpermobdatatoreset.pathfindscript.thenpc != null)
                {
                    //pathfindpermobdatatoreset.npccharacter = thegameobject;

                    //pathfindpermobdatatoreset.pathfindscript = sccspools.getpooledsccspathfinddata(); //new sccspathfinddata();
                    /*pathfindpermobdatatoreset.pathfindscript.hasinitswtc = 1;// 1;
                    pathfindpermobdatatoreset.pathfindscript.mainSwitch = 1;//;
                    //sccspathfindactionstruct.hasclearedarrays = 0;//= 0;

                    pathfindpermobdatatoreset.pathfindscript.pathfindoptionhgf = pathfindpermobdatalighttoreset.pathfindarraysorttypeoption;//0FCOST//1HCOST//2MISCFCOSTISH //pathfinsccspathfindactionstruct.pathfindarraysorttypeoption

                    pathfindpermobdatatoreset.pathfindscript.debugtoconsolemsg = sccspathfindglobals.debugtoconsolemsg;//; // debugs messages to the console.
                    pathfindpermobdatatoreset.pathfindscript.pathfindimax = sccspathfindglobals.pathfindimax;//; //loops the pathfind 3 times per frame. //9. //PUT AT 1 MINIMUM
                    pathfindpermobdatatoreset.pathfindscript.hasstartedpathfindcountermax = sccspathfindglobals.hasstartedpathfindcountermax;//;//IF THE PATHFIND ITERATOR PATHFINDIMAX GOES OVER 75 SEEKER NODE ATTEMPT TO FIND THE TARGET. RESTART THE PATHFIND AUTOMATICALLY
                    pathfindpermobdatatoreset.pathfindscript.framecounterpathfindmax = sccspathfindglobals.framecounterpathfindmax;//;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. INCREASE TO LET MULTIPLE FRAMES PASS BEFORE LETTING 1 PASS OF PATHFIND THROUGH.
                    pathfindpermobdatatoreset.pathfindscript.createpathfindvisuals = sccspathfindglobals.createpathfindvisuals;//;//NOTHING WORKING HERE FOR THE MOMENT.
                    pathfindpermobdatatoreset.pathfindscript.startpathfind = sccspathfindglobals.startpathfind;//;//LEAVE AT 1 SO THAT THE MOMENT THAT THE LOOPPATHFIND FUNCTION IS CALLED, IT WILL AUTOMATICALLY ENGAGE THE REST OF THE PATHFIND LOGIC.
                    pathfindpermobdatatoreset.pathfindscript.maxRetracePath = sccspathfindglobals.maxRetracePath;//;//IF THE RETRACE PATH IS HIGHER THAN x INTEGER, the path is too long... don't retrace.
                    pathfindpermobdatatoreset.pathfindscript.retracedpathlistcountermaxloop = sccspathfindglobals.retracedpathlistcountermaxloop;//;//retrace only 1 reseeker node per frame. or x integer per frame to loop the retrace path faster otherwise it is 1 retrace per frame.
                    pathfindpermobdatatoreset.pathfindscript.retracedpathlistcountermax = sccspathfindglobals.retracedpathlistcountermax;//;

                    pathfindpermobdatatoreset.pathfindscript.noderadius = sccspathfindglobals.noderadius;//; //not used yet. leave at 1.

                    pathfindpermobdatatoreset.pathfindscript.gridxl = sccspathfindglobals.gridxl;//;
                    pathfindpermobdatatoreset.pathfindscript.gridxr = sccspathfindglobals.gridxr;//;
                    pathfindpermobdatatoreset.pathfindscript.gridyb = sccspathfindglobals.gridyb;//;
                    pathfindpermobdatatoreset.pathfindscript.gridyt = sccspathfindglobals.gridyt;//;*/

                    //pathfindpermobdatatoreset.pathfindscript.adminnotify = sccspools.getpooledConsoleAdminNotifyPlayer();// new ConsoleAdminNotifyPlayer();
                    //pathfindpermobdatatoreset.pathfindscript.lastnode = sccspools.getpooledsccspathfindnode();// new sccspathfindnode();

                    /*
                    if (pathfindpermobdatatoreset.pathfindscript.retracedpathlist != null)
                    {
                        pathfindpermobdatatoreset.pathfindscript.retracedpathlist.Clear();
                        pathfindpermobdatatoreset.pathfindscript.retracedpathlist = null;
                    }
                    else
                    {
                        //pathfindpermobdatatoreset.pathfindscript.retracedpathlist = sccspools.getpooledsccspathfindnodestack();//new itsalmostastack<sccspathfindnode>();//new Stack<sccspathfindnode>();
                    }

                    
                    pathfindpermobdatatoreset.pathfindscript.theseekernode = sccspools.getpooledsccspathfindnode();//new sccspathfindnode();
                    pathfindpermobdatatoreset.pathfindscript.initialpathfindnpcpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                    pathfindpermobdatatoreset.pathfindscript.targetobjingridpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                    pathfindpermobdatatoreset.pathfindscript.initialpathfindstartpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                    pathfindpermobdatatoreset.pathfindscript.tempttargetobjingridpospos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                    pathfindpermobdatatoreset.pathfindscript.lasttransformposition = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                    pathfindpermobdatatoreset.pathfindscript.targetobjingridposposlast = sccspools.getpooledsccsvec2int();// new sccsvec2int();
                    pathfindpermobdatatoreset.pathfindscript.gridworldsize = new sccspathfindgridWorldSize();*/

                    /*if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar != null)
                    {
                        if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.openset != null)
                        {
                            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.openset.Clear();
                            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.openset = null;
                        }

                        if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.closedset != null)
                        {
                            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.closedset.Clear();
                            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.closedset = null;
                        }

                        if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log != null)
                        {
                            for (int i = 0; i < pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log.Count; i++)
                            {
                                if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log[i] != null)
                                {
                                    pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log[i] = null;
                                }

                            }
                            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log = null;
                        }
                    }

                    //pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar = sccspools.getpooledsccspathfindcombineddata();// new sccspathfindcombineddata();
                    pathfindpermobdatatoreset.pathfindscript.thenpc = null;*/
                }




                //sccspathfindperscriptmobdatastruct thenewstructdata = pathfindpermobdata[thearrayindex][indexbefore];
                //sccspathfindperscriptmobdatastruct thenewstructdata = new sccspathfindperscriptmobdatastruct();
                pathfindpermobdatatoreset.npccharacter = characterNpc;



                pathfindpermobdatatoreset.pathfindscript = new sccspathfinddata();
                pathfindpermobdatatoreset.startpathfindmainswtc = 9;

                pathfindpermobdatatoreset.initialpathfindstartpos = new sccsvec2float();
                pathfindpermobdatatoreset.initialpathfindtargetpos = new sccsvec2float();
                pathfindpermobdatatoreset.lastinitialpathfindtargetpos = new sccsvec2float();

                pathfindpermobdatatoreset.swtcdebug = 0;
                pathfindpermobdatatoreset.distnpctoplayersqrtlast = 0;


                /*
                pathfindpermobdatatoreset.listofobstaclesinit = new List<sccspathfindobstaclestruct>();
                pathfindpermobdatatoreset.listofobstaclesonthewaytwo = new List<sccsvec2int>();
                pathfindpermobdatatoreset.listofobstaclesontheway = new List<sccspathfindobstaclestruct>();
                */

                if (pathfindpermobdatatoreset.listofobstaclesinit != null)
                {
                    pathfindpermobdatatoreset.listofobstaclesinit.Clear();
                }

                if (pathfindpermobdatatoreset.listofobstaclesonthewaytwo != null)
                {
                    pathfindpermobdatatoreset.listofobstaclesonthewaytwo.Clear();
                }

                if (pathfindpermobdatatoreset.listofobstaclesontheway != null)
                {
                    pathfindpermobdatatoreset.listofobstaclesontheway.Clear();
                }





                pathfindpermobdatatoreset.npcposlast = new sccsvec2float();


                pathfindpermobdatatoreset.lastdistsquared = 0;
                pathfindpermobdatatoreset.directionnpctopathfindnodef = new Vector2F(0, 0);
                //pathfindpermobdatatoreset.adminnotify = new ConsoleAdminNotifyPlayer();

                if (pathfindpermobdatatoreset.adminnotify == null)
                {
                    pathfindpermobdatatoreset.adminnotify = new ConsoleAdminNotifyPlayer();
                }

                pathfindpermobdatatoreset.distsquared = 0;

                pathfindpermobdatatoreset.playerpos = new sccsvec2float();
                pathfindpermobdatatoreset.npcpos = new sccsvec2float();

                pathfindpermobdatatoreset.disttonode0last = 0;
                pathfindpermobdatatoreset.playercharactercenter = new Vector2D();
                pathfindpermobdatatoreset.npcCharacterCenter = new Vector2D();

                pathfindpermobdatatoreset.npcmovementtype = 0;
                pathfindpermobdatatoreset.disttonode = 0;

                pathfindpermobdatatoreset.lastcurrentnpcpos = new sccsvec2float();

                //List<sccspathfindnode> pathfindretracedpath = new List<sccspathfindnode>();
                pathfindpermobdatatoreset.pathfindretracedpathswtc = 0;
                //pathfindpermobdatatoreset.poppednode;// = new sccspathfindnode();
                pathfindpermobdatatoreset.haspopped = false;
                pathfindpermobdatatoreset.lasthaspopped = false;
                pathfindpermobdatatoreset.haspoppedcounter = 0;
                pathfindpermobdatatoreset.lasthaspoppedcounter = 0;

                pathfindpermobdatatoreset.haspoppedcountermax = 1;

                pathfindpermobdatatoreset.lastcurrentnpcdirection = new sccsvec2float();
                pathfindpermobdatatoreset.currentnpcdirection = new sccsvec2float();

                pathfindpermobdatatoreset.frontdirectionposition = new Vector2D();
                //Vector2D frontdirectionpositionnotnormalized = new Vector2D();
                pathfindpermobdatatoreset.frontdirectionpositionnotnormalized = 0.0;
                pathfindpermobdatatoreset.lastdistnpctoplayersqrt = 0;
                pathfindpermobdatatoreset.distnpctoplayersqrt = 0;

                pathfindpermobdatatoreset.hasreachedpathend = 0;
                pathfindpermobdatatoreset.firstnodeofpathfindpoppedswtc = 0;
                pathfindpermobdatatoreset.decrementcounterforpath = 0;

                pathfindpermobdatatoreset.pathfindmaincounter = 0;
                pathfindpermobdatatoreset.pathfindmaincountermax = 0;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. THE HIGHER THE VALUE, THE LESS TIMES THE PATHFIND LOGIC IS ENGAGED.logic is currently broken unless it's at zero

                pathfindpermobdatatoreset.haschasedcharacter = 0;

                pathfindpermobdatatoreset.hasreachingnodestuckframecounter = 0;
                pathfindpermobdatatoreset.hasreachingnodestuckframecountermax = 30;

                pathfindpermobdatatoreset.hasreachedandattackedplayer = 0;
                pathfindpermobdatatoreset.lasthasreachedandattackedplayer = 0;



                pathfindpermobdata[thearrayindex][indexbefore] = pathfindpermobdatatoreset;



            }



            return indexbefore;

        }









    }
}

















/*
var pathfindpermobdatatoreset = pathfindpermobdata[thearrayindex][indexbefore];
var pathfindpermobdatalighttoreset = pathfindpermobdatalight[thearrayindex][indexbefore];

if (pathfindpermobdatatoreset.pathfindscript.thenpc != null)
{
    //pathfindpermobdatatoreset.npccharacter = thegameobject;

    //pathfindpermobdatatoreset.pathfindscript = sccspools.getpooledsccspathfinddata(); //new sccspathfinddata();
    pathfindpermobdatatoreset.pathfindscript.hasinitswtc = 1;// 1;
    pathfindpermobdatatoreset.pathfindscript.mainSwitch = 1;//;
    //sccspathfindactionstruct.hasclearedarrays = 0;//= 0;

    pathfindpermobdatatoreset.pathfindscript.pathfindoptionhgf = pathfindpermobdatalighttoreset.pathfindarraysorttypeoption;//0FCOST//1HCOST//2MISCFCOSTISH //pathfinsccspathfindactionstruct.pathfindarraysorttypeoption

    pathfindpermobdatatoreset.pathfindscript.debugtoconsolemsg = sccspathfindglobals.debugtoconsolemsg;//; // debugs messages to the console.
    pathfindpermobdatatoreset.pathfindscript.pathfindimax = sccspathfindglobals.pathfindimax;//; //loops the pathfind 3 times per frame. //9. //PUT AT 1 MINIMUM
    pathfindpermobdatatoreset.pathfindscript.hasstartedpathfindcountermax = sccspathfindglobals.hasstartedpathfindcountermax;//;//IF THE PATHFIND ITERATOR PATHFINDIMAX GOES OVER 75 SEEKER NODE ATTEMPT TO FIND THE TARGET. RESTART THE PATHFIND AUTOMATICALLY
    pathfindpermobdatatoreset.pathfindscript.framecounterpathfindmax = sccspathfindglobals.framecounterpathfindmax;//;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. INCREASE TO LET MULTIPLE FRAMES PASS BEFORE LETTING 1 PASS OF PATHFIND THROUGH.
    pathfindpermobdatatoreset.pathfindscript.createpathfindvisuals = sccspathfindglobals.createpathfindvisuals;//;//NOTHING WORKING HERE FOR THE MOMENT.
    pathfindpermobdatatoreset.pathfindscript.startpathfind = sccspathfindglobals.startpathfind;//;//LEAVE AT 1 SO THAT THE MOMENT THAT THE LOOPPATHFIND FUNCTION IS CALLED, IT WILL AUTOMATICALLY ENGAGE THE REST OF THE PATHFIND LOGIC.
    pathfindpermobdatatoreset.pathfindscript.maxRetracePath = sccspathfindglobals.maxRetracePath;//;//IF THE RETRACE PATH IS HIGHER THAN x INTEGER, the path is too long... don't retrace.
    pathfindpermobdatatoreset.pathfindscript.retracedpathlistcountermaxloop = sccspathfindglobals.retracedpathlistcountermaxloop;//;//retrace only 1 reseeker node per frame. or x integer per frame to loop the retrace path faster otherwise it is 1 retrace per frame.
    pathfindpermobdatatoreset.pathfindscript.retracedpathlistcountermax = sccspathfindglobals.retracedpathlistcountermax;//;

    pathfindpermobdatatoreset.pathfindscript.noderadius = sccspathfindglobals.noderadius;//; //not used yet. leave at 1.

    pathfindpermobdatatoreset.pathfindscript.gridxl = sccspathfindglobals.gridxl;//;
    pathfindpermobdatatoreset.pathfindscript.gridxr = sccspathfindglobals.gridxr;//;
    pathfindpermobdatatoreset.pathfindscript.gridyb = sccspathfindglobals.gridyb;//;
    pathfindpermobdatatoreset.pathfindscript.gridyt = sccspathfindglobals.gridyt;//;

    //pathfindpermobdatatoreset.pathfindscript.adminnotify = sccspools.getpooledConsoleAdminNotifyPlayer();// new ConsoleAdminNotifyPlayer();
    pathfindpermobdatatoreset.pathfindscript.lastnode = sccspools.getpooledsccspathfindnode();// new sccspathfindnode();


    if (pathfindpermobdatatoreset.pathfindscript.retracedpathlist!= null)
    {
        pathfindpermobdatatoreset.pathfindscript.retracedpathlist.Clear();
    }
    else
    {
        pathfindpermobdatatoreset.pathfindscript.retracedpathlist = sccspools.getpooledsccspathfindnodestack();//new itsalmostastack<sccspathfindnode>();//new Stack<sccspathfindnode>();
    }

    pathfindpermobdatatoreset.pathfindscript.theseekernode = sccspools.getpooledsccspathfindnode();//new sccspathfindnode();

    pathfindpermobdatatoreset.pathfindscript.initialpathfindnpcpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
    pathfindpermobdatatoreset.pathfindscript.targetobjingridpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
    pathfindpermobdatatoreset.pathfindscript.initialpathfindstartpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
    pathfindpermobdatatoreset.pathfindscript.tempttargetobjingridpospos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
    pathfindpermobdatatoreset.pathfindscript.lasttransformposition = sccspools.getpooledsccsvec2int();//new sccsvec2int();
    pathfindpermobdatatoreset.pathfindscript.targetobjingridposposlast = sccspools.getpooledsccsvec2int();// new sccsvec2int();
    pathfindpermobdatatoreset.pathfindscript.gridworldsize = new sccspathfindgridWorldSize();

    if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar!= null)
    {
        if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.openset != null)
        {
            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.openset.Clear();
        }

        if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.closedset != null)
        {
            pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.openset.Clear();
        }
        /*
        if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log != null)
        {
            for (int i = 0;i < pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log.Count;i++)
            {
                for (int j = 0;j < pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log[i].Length;j++)
                {
                    if (pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log[i]!= null)
                    {
                        //pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar.log[i] = new ;
                    }
                }
            }
        }
    }


    pathfindpermobdatatoreset.pathfindscript.sccspathfindcombineddatavar = sccspools.getpooledsccspathfindcombineddata();// new sccspathfindcombineddata();

}*/













/*
//sccspathfindperscriptmobdatastruct thenewstructdata = sccspools.getpooledsccspathfindperscriptmobdatastruct();// new sccspathfindperscriptmobdatastruct();

//pathfindpermobdatatoreset.pathfindscript = sccspools.getpooledsccspathfinddata();//new sccspathfinddata();
pathfindpermobdatatoreset.startpathfindmainswtc = 0;

pathfindpermobdatatoreset.initialpathfindstartpos = sccspools.getpooledsccsvec2float();//new sccsvec2float();
pathfindpermobdatatoreset.initialpathfindtargetpos = sccspools.getpooledsccsvec2float();//new sccsvec2float();
pathfindpermobdatatoreset.lastinitialpathfindtargetpos = sccspools.getpooledsccsvec2float();//new sccsvec2float();

pathfindpermobdatatoreset.swtcdebug = 0;
pathfindpermobdatatoreset.distnpctoplayersqrtlast = 0;

pathfindpermobdatatoreset.listofobstaclesinit = sccspools.getpooledsccspathfindobstaclestruct();// new List<sccspathfindobstaclestruct>();

pathfindpermobdatatoreset.listofobstaclesonthewaytwo = sccspools.getpooledsccsvec2intlist();//new List<sccsvec2int>();
pathfindpermobdatatoreset.listofobstaclesontheway = sccspools.getpooledsccspathfindobstaclestruct();//new List<sccspathfindobstaclestruct>();

pathfindpermobdatatoreset.npcposlast = sccspools.getpooledsccsvec2float();//new sccsvec2float();


pathfindpermobdatatoreset.lastdistsquared = 0;
pathfindpermobdatatoreset.directionnpctopathfindnodef = new Vector2F(0, 0);
pathfindpermobdatatoreset.adminnotify = sccspools.getpooledConsoleAdminNotifyPlayer();//new ConsoleAdminNotifyPlayer();
pathfindpermobdatatoreset.distsquared = 0;

pathfindpermobdatatoreset.playerpos = sccspools.getpooledsccsvec2float();// new sccsvec2float();
pathfindpermobdatatoreset.npcpos = sccspools.getpooledsccsvec2float();// new sccsvec2float();

pathfindpermobdatatoreset.disttonode0last = 0;
pathfindpermobdatatoreset.playercharactercenter = new Vector2D();
pathfindpermobdatatoreset.npcCharacterCenter = new Vector2D();

pathfindpermobdatatoreset.npcmovementtype = 0;
pathfindpermobdatatoreset.disttonode = 0;

pathfindpermobdatatoreset.lastcurrentnpcpos = sccspools.getpooledsccsvec2float();// new sccsvec2float();

//List<sccspathfindnode> pathfindretracedpath = new List<sccspathfindnode>();
pathfindpermobdatatoreset.pathfindretracedpathswtc = 0;
//pathfindpermobdatatoreset.poppednode;// = new sccspathfindnode();
pathfindpermobdatatoreset.haspopped = false;
pathfindpermobdatatoreset.lasthaspopped = false;
pathfindpermobdatatoreset.haspoppedcounter = 0;
pathfindpermobdatatoreset.lasthaspoppedcounter = 0;

pathfindpermobdatatoreset.haspoppedcountermax = 1;

pathfindpermobdatatoreset.lastcurrentnpcdirection = sccspools.getpooledsccsvec2float();//new sccsvec2float();
pathfindpermobdatatoreset.currentnpcdirection = sccspools.getpooledsccsvec2float();//new sccsvec2float();

pathfindpermobdatatoreset.frontdirectionposition = new Vector2D();
//Vector2D frontdirectionpositionnotnormalized = new Vector2D();
pathfindpermobdatatoreset.frontdirectionpositionnotnormalized = 0.0;
pathfindpermobdatatoreset.lastdistnpctoplayersqrt = 0;
pathfindpermobdatatoreset.distnpctoplayersqrt = 0;

pathfindpermobdatatoreset.hasreachedpathend = 0;
pathfindpermobdatatoreset.firstnodeofpathfindpoppedswtc = 0;
pathfindpermobdatatoreset.decrementcounterforpath = 0;

pathfindpermobdatatoreset.pathfindmaincounter = 0;
pathfindpermobdatatoreset.pathfindmaincountermax = 0;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. THE HIGHER THE VALUE, THE LESS TIMES THE PATHFIND LOGIC IS ENGAGED.logic is currently broken unless it's at zero

pathfindpermobdatatoreset.haschasedcharacter = 0;

pathfindpermobdatatoreset.hasreachingnodestuckframecounter = 0;
pathfindpermobdatatoreset.hasreachingnodestuckframecountermax = 30;

pathfindpermobdatatoreset.hasreachedandattackedplayer = 0;
pathfindpermobdatatoreset.lasthasreachedandattackedplayer = 0;

pathfindpermobdata[thearrayindex][indexbefore] = pathfindpermobdatatoreset;


*/
//var pathfindpermobdatalighttoreset = pathfindpermobdatalight[thearrayindex][indexbefore];
/*
pathfindpermobdata[thearrayindex][indexbefore] = thenewstructdata;//.Add(thenewstructdata);
pathfindpermobdatalight[thearrayindex][indexbefore] = pathfindaction;//.Add(thenewstructdata);*/
/*
sccspathfindperscriptmobdatastruct thenewstructdata = new sccspathfindperscriptmobdatastruct();

thenewstructdata.pathfindscript = new sccspathfinddata();
thenewstructdata.startpathfindmainswtc = 0;

thenewstructdata.initialpathfindstartpos = new sccsvec2float();
thenewstructdata.initialpathfindtargetpos = new sccsvec2float();
thenewstructdata.lastinitialpathfindtargetpos = new sccsvec2float();

thenewstructdata.swtcdebug = 0;
thenewstructdata.distnpctoplayersqrtlast = 0;

thenewstructdata.listofobstaclesinit = new List<sccspathfindobstaclestruct>();

thenewstructdata.listofobstaclesonthewaytwo = new List<sccsvec2int>();
thenewstructdata.listofobstaclesontheway = new List<sccspathfindobstaclestruct>();

thenewstructdata.npcposlast = new sccsvec2float();


thenewstructdata.lastdistsquared = 0;
thenewstructdata.directionnpctopathfindnodef = new Vector2F(0, 0);
thenewstructdata.adminnotify = new ConsoleAdminNotifyPlayer();
thenewstructdata.distsquared = 0;

thenewstructdata.playerpos = new sccsvec2float();
thenewstructdata.npcpos = new sccsvec2float();

thenewstructdata.disttonode0last = 0;
thenewstructdata.playercharactercenter = new Vector2D();
thenewstructdata.npcCharacterCenter = new Vector2D();

thenewstructdata.npcmovementtype = 0;
thenewstructdata.disttonode = 0;

thenewstructdata.lastcurrentnpcpos = new sccsvec2float();

//List<sccspathfindnode> pathfindretracedpath = new List<sccspathfindnode>();
thenewstructdata.pathfindretracedpathswtc = 0;
//thenewstructdata.poppednode;// = new sccspathfindnode();
thenewstructdata.haspopped = false;
thenewstructdata.lasthaspopped = false;
thenewstructdata.haspoppedcounter = 0;
thenewstructdata.lasthaspoppedcounter = 0;

thenewstructdata.haspoppedcountermax = 1;

thenewstructdata.lastcurrentnpcdirection = new sccsvec2float();
thenewstructdata.currentnpcdirection = new sccsvec2float();

thenewstructdata.frontdirectionposition = new Vector2D();
//Vector2D frontdirectionpositionnotnormalized = new Vector2D();
thenewstructdata.frontdirectionpositionnotnormalized = 0.0;
thenewstructdata.lastdistnpctoplayersqrt = 0;
thenewstructdata.distnpctoplayersqrt = 0;

thenewstructdata.hasreachedpathend = 0;
thenewstructdata.firstnodeofpathfindpoppedswtc = 0;
thenewstructdata.decrementcounterforpath = 0;

thenewstructdata.pathfindmaincounter = 0;
thenewstructdata.pathfindmaincountermax = 0;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. THE HIGHER THE VALUE, THE LESS TIMES THE PATHFIND LOGIC IS ENGAGED.logic is currently broken unless it's at zero

thenewstructdata.haschasedcharacter = 0;

thenewstructdata.hasreachingnodestuckframecounter = 0;
thenewstructdata.hasreachingnodestuckframecountermax = 30;

thenewstructdata.hasreachedandattackedplayer = 0;
thenewstructdata.lasthasreachedandattackedplayer = 0;
*/









//sccspoolspathfind[thearrayindex] = new sccspools();
//sccspoolspathfind[thearrayindex].
//sccspoolspathfind[thearrayindex].createpoolscript();
