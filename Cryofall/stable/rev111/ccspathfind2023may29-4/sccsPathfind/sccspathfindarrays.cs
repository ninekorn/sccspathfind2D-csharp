namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;

    using AtomicTorch.CBND.CoreMod.Characters;
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;

    using sccspathfindnode = sccspathfindstructs.sccspathfindnode;
    using sccspathfindcombineddata = sccspathfindstructs.sccspathfindcombineddata;
    using sccspathfindgriddatafinal = sccspathfindstructs.sccspathfindgriddatafinal;
    using sccspathfindgridworldindex = sccspathfindstructs.sccspathfindgridworldindex;
    using sccspathfindgridWorldSize = sccspathfindstructs.sccspathfindgridWorldSize;
    using sccspathfindcheckallsidesdata = sccspathfindstructs.sccspathfindcheckallsidesdata;
    using sccspathfindneighboortile = sccspathfindstructs.sccspathfindneighboortile;
    using sccspathfindextraTiles = sccspathfindstructs.sccspathfindextraTiles;
    using sccspathfindobstacledata = sccspathfindstructs.sccspathfindobstacledata;
    using sccsvec2int = sccspathfindstructs.sccsvec2int;
    using static sccspathfindstructs;
    //using static sccsvestationoutpost;

    using AtomicTorch.CBND.GameApi.Data.Physics;
    using System.Windows.Documents;
    using AtomicTorch.CBND.GameApi.Scripting;
    using AtomicTorch.CBND.GameApi.ServicesServer;

    using System.Collections.Generic;
    using System.Collections;
    using System;
    using AtomicTorch.GameEngine.Common.Primitives;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.GameEngine.Common.DataStructures;

    public static class sccspathfindarrays
    {
        public static List<ICharacter> ListOfThisInstanceMobWolf
       = new();


        public static List<sccspathfindperscriptmobdatastruct> pathfindpermobdata = new List<sccspathfindperscriptmobdatastruct>();
        public static List<sccspathfindactionstruct> pathfindpermobdatalight = new List<sccspathfindactionstruct>();

        



        public static int ProcessAddToMainList(
            ICharacter characterNpc)
        {
            int indexbefore = ListOfThisInstanceMobWolf.Count;
            ListOfThisInstanceMobWolf.Add(characterNpc);


            sccspathfindperscriptmobdatastruct thenewstructdata = new sccspathfindperscriptmobdatastruct();

            thenewstructdata.pathfindscript = new sccspathfinddata();
            thenewstructdata.startpathfindmainswtc = 0;

            thenewstructdata.initialpathfindstartpos = new sccsvec2float();
            thenewstructdata.initialpathfindtargetpos = new sccsvec2float();
            thenewstructdata.lastinitialpathfindtargetpos = new sccsvec2float();

            thenewstructdata.swtcdebug = 0;
            thenewstructdata.distnpctoplayersqrtlast = 0;

            thenewstructdata.listofobstaclesinit = new List<sccsvec2int>();

            thenewstructdata.listofobstaclesonthewaytwo = new List<sccsvec2int>();
            thenewstructdata.listofobstaclesontheway = new List<sccsvec2int>();

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





            pathfindpermobdata.Add(thenewstructdata);



            sccspathfindactionstruct pathfindaction = new sccspathfindactionstruct();

            pathfindaction.anglerad = 0;
            pathfindaction.direction = new Vector2F(0,0);
            pathfindaction.thenpccharacter = characterNpc;

            pathfindpermobdatalight.Add(pathfindaction);



            return indexbefore;

        }









    }
}
