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

        public static byte initlists = 0;

        public static int ProcessAddToMainList(
            ICharacter characterNpc, out int mobtypeofindex)
        {

            if (initlists == 0)
            {
                int currentmodmobtypes = 28 + 1;

                for (int i = 0; i < currentmodmobtypes; i++)
                {
                    pathfindpermobdata.Add(new List<sccspathfindperscriptmobdatastruct>());
                    pathfindpermobdatalight.Add(new List<sccspathfindactionstruct>());
                }

                initlists = 1;
            }


            int indexbefore = -1;
            int thearrayindex = -1;


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

            indexbefore = pathfindpermobdata[thearrayindex].Count;// ListOfThisInstanceMob[thearrayindex].Count;
            //ListOfThisInstanceMob[thearrayindex].Add(characterNpc);






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




            thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier = 0.5f;

            if (characterNpc.Name.Contains("Bear"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(650 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Black beetle"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(325 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Brood drone"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1150 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Brood guardian"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1500 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Burrower"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(450 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Cloaked lizard"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(750 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Crab"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(150 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Crawler"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1250 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Fire lizard"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(1000 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Floater"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(950 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Honey badger"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(400 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Hyena"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(400 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Mutated boar"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(350 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Mutated hyena"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(675 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Mutated wolf"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(750 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Pragmium beetle"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(350 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Scorpion"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(275 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Blue snake"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(275 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Brown snake"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(300 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Green snake"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(285 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Spitter"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(500 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Tropical boar"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(225 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Wild boar"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(250 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Wolf"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(450 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Polar wolf"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(650 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Polar bear"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(850 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Skeleton"))
            {
                thenewstructdata.sccspathfinddistsquaredaggrodistancemax = (int)Math.Round(350 * thenewstructdata.sccspathfinddistsquaredaggrodistancemaxmultiplier);
            }
            else if (characterNpc.Name.Contains("Zombie"))
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
            pathfindaction.direction = new Vector2F(0,0);
            pathfindaction.thenpccharacter = characterNpc;





            if (characterNpc.Name.Contains("Bear"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 0;
            }
            else if (characterNpc.Name.Contains("Black beetle"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 1;
            }
            else if (characterNpc.Name.Contains("Brood drone"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 2;
            }
            else if (characterNpc.Name.Contains("Brood guardian"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 3;
            }
            else if (characterNpc.Name.Contains("Burrower"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 4;
            }
            else if (characterNpc.Name.Contains("Cloaked lizard"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 5;
            }
            else if (characterNpc.Name.Contains("Crab"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 6;
            }
            else if (characterNpc.Name.Contains("Crawler"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 7;
            }
            else if (characterNpc.Name.Contains("Fire lizard"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 8;
            }
            else if (characterNpc.Name.Contains("Floater"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 9;
            }
            else if (characterNpc.Name.Contains("Honey badger"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 10;
            }
            else if (characterNpc.Name.Contains("Hyena"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 11;
            }
            else if (characterNpc.Name.Contains("Mutated boar"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 12;
            }
            else if (characterNpc.Name.Contains("Mutated hyena"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 13;
            }
            else if (characterNpc.Name.Contains("Mutated wolf"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 14;
            }
            else if (characterNpc.Name.Contains("Pragmium beetle"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 15;
            }
            else if (characterNpc.Name.Contains("Scorpion"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 16;
            }
            else if (characterNpc.Name.Contains("Blue snake"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 17;
            }
            else if (characterNpc.Name.Contains("Brown snake"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 18;
            }
            else if (characterNpc.Name.Contains("Green snake"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 19;
            }
            else if (characterNpc.Name.Contains("Spitter"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 20;
            }
            else if (characterNpc.Name.Contains("Tropical boar"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 21;
            }
            else if (characterNpc.Name.Contains("Wild boar"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 22;
            }
            else if (characterNpc.Name.Contains("Wolf"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 23;
            }
            else if (characterNpc.Name.Contains("Polar wolf"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 24;
            }
            else if (characterNpc.Name.Contains("Polar bear"))
            {
                pathfindaction.pathfindarraysorttypeoption = 0;
                pathfindaction.mobtypeofindex = 25;
            }
            else if (characterNpc.Name.Contains("Skeleton"))
            {
                pathfindaction.pathfindarraysorttypeoption = 1;
                pathfindaction.mobtypeofindex = 26;
            }
            else if (characterNpc.Name.Contains("Zombie"))
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

            return indexbefore;

        }









    }
}
