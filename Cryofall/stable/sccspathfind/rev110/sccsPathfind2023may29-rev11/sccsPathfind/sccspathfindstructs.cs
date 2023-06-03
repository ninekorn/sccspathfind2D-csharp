
using System;
using System.Collections;
using System.Collections.Generic;

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

using AtomicTorch.GameEngine.Common.Primitives;
using AtomicTorch.CBND.GameApi.Data.Characters;
using AtomicTorch.GameEngine.Common.DataStructures;
using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;
using AtomicTorch.CBND.CoreMod.Characters.Mobs;



//using UnityEngine;
//namespace AtomicTorch.CBND.CoreMod.Characters.Mobs

public class sccspathfindstructs //: MonoBehaviour
{

   

    public struct sccspathfindperscriptmobdatastruct
    {
        public ICharacter npccharacter;
        public ICharacter playercharacter;
        //AtomicTorch.CBND.CoreMod.ConsoleCommands.Debug.ConsoleDebugTestNotification debug = new ConsoleCommands.Debug.ConsoleDebugTestNotification();
        public sccspathfinddata pathfindscript;
        public int startpathfindmainswtc;//= 0;
        public sccsvec2float initialpathfindstartpos;//= new sccsvec2float();
        public sccsvec2float initialpathfindtargetpos;// = new sccsvec2float();
        public sccsvec2float lastinitialpathfindtargetpos;// = new sccsvec2float();

        public int swtcdebug;//= 0;

        public float distnpctoplayersqrtlast;//= 0;
        public System.Collections.Generic.List<sccsvec2int> listofobstaclesinit;//= new System.Collections.Generic.List<sccsvec2int>();
        public ITempList<TestResult> obstacles;

        public System.Collections.Generic.List<sccsvec2int> listofobstaclesonthewaytwo;//= new System.Collections.Generic.List<sccsvec2int>();

        public System.Collections.Generic.List<sccsvec2int> listofobstaclesontheway;//= new System.Collections.Generic.List<sccsvec2int>();
        public ITempList<TestResult> obstaclesontheway;
        public ITempList<TestResult> obstaclesonthewaytwo;

        public int swtcobstaclesontheway;//= 0;

        public sccsvec2float npcposlast;// = new sccsvec2float();

        public float lastdistsquared;// = 0;
        public Vector2F directionnpctopathfindnodef;//= new Vector2F(0, 0);
        public ConsoleAdminNotifyPlayer adminnotify;// = new ConsoleAdminNotifyPlayer();
        public float distsquared;// = 0;
        public sccsvec2float playerpos;
        public sccsvec2float npcpos;


        public float disttonode0last;// = 0;
        public Vector2D playercharactercenter;
        public Vector2D npcCharacterCenter;

        public int npcmovementtype;// = 0;
        public float disttonode;// = 0;

        public sccsvec2float lastcurrentnpcpos;// = new sccsvec2float();

        //List<sccspathfindnode> pathfindretracedpath = new List<sccspathfindnode>();
        public int pathfindretracedpathswtc;//= 0;
        public sccspathfindnode poppednode;
        public bool haspopped;//= false;
        public bool lasthaspopped;// = false;
        public int haspoppedcounter;// = 0;
        public int lasthaspoppedcounter;//= 0;

        public int haspoppedcountermax;//= 1;

        public sccsvec2float lastcurrentnpcdirection;//= new sccsvec2float();
        public sccsvec2float currentnpcdirection;// = new sccsvec2float();

        public Vector2D frontdirectionposition;// = new Vector2D();
                                               //Vector2D frontdirectionpositionnotnormalized = new Vector2D();
        public double frontdirectionpositionnotnormalized;//= 0.0;
        public float lastdistnpctoplayersqrt;//= 0;
        public float distnpctoplayersqrt;// = 0;

        public int hasreachedpathend;// = 0;
        public int firstnodeofpathfindpoppedswtc;// = 0;
        public int decrementcounterforpath;// = 0;

        public int pathfindmaincounter;//= 0;
        public int pathfindmaincountermax;// = 0;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. THE HIGHER THE VALUE, THE LESS TIMES THE PATHFIND LOGIC IS ENGAGED.logic is currently broken unless it's at zero

        public int haschasedcharacter;//= 0;

        public int hasreachingnodestuckframecounter;// = 0;
        public int hasreachingnodestuckframecountermax;// = 30;

        public int hasreachedandattackedplayer;// = 0;
        public int lasthasreachedandattackedplayer;// = 0;


    }




    public struct sccspathfinddata
    {


        public int hasinitswtc;
        public ConsoleAdminNotifyPlayer adminnotify;// = new ConsoleAdminNotifyPlayer();
        public int pathfindoptionhgf;//= 1;
        public int debugtoconsolemsg;// = 0;
        public int countingmaxretracepathswtc;// = 0;
        public int maxRetracePath;// = 1500;
        public int counting;// = 0;
        public int mainSwitch;// = 1;
        public int pathfindi;// = 0;
        public int pathfindimax;//= 3;
        //int framecounterpathfindistrying = 0;
        //public int framecounterpathfindistryingmax = 75;
        public int framecounterpathfind;//= 0;
        public int framecounterpathfindmax;// = 0;
        public int createpathfindvisuals;// = 0;
        public int retracedpathlistcounter;//= 0;
        public int retracedpathlistcountermax;//= 0;

        public int retracedpathlistcountermaxloop;// = 1;
        public int retracedpathlistcountertwo;// = 0;
        public int startpathfind;// = 0;
        public int isgridcreated;// = 0;
        public int pathfindswtc;// = 0;
        public int hasstartedpathfindcounter;//= 0;
        public int hasstartedpathfindcountermax;//= 75;//1500
        public ICharacter thenpc;
        public ICharacter theplayer;
        public float distancecurrentlast;//;// = 0;
        public sccspathfindnode lastnode;//= new sccspathfindnode();
        public sccspathfindnode currentNode;
        //public List<sccspathfindnode> retracedpathlist = new List<sccspathfindnode>();
        public Stack<sccspathfindnode> retracedpathlist;// = new Stack<sccspathfindnode>();
        public sccspathfindcombineddata sccspathfindcombineddatavar;// = new sccspathfindcombineddata();
        public sccspathfindnode theseekernode;//= new sccspathfindnode();
        public sccsvec2int initialpathfindnpcpos;//= new sccsvec2int();
        public sccsvec2int targetobjingridpos;//= new sccsvec2int();
        public sccsvec2int initialpathfindstartpos;//= new sccsvec2int();
        public sccsvec2int tempttargetobjingridpospos;//= new sccsvec2int();
        public sccsvec2int lasttransformposition;//= new sccsvec2int();
        public sccsvec2int targetobjingridposposlast;//= new sccsvec2int();
        public int noderadius;//= 1;
        public int gridxl;// = 2;
        public int gridxr;//= 1;
        public int gridyb;//= 2;
        public int gridyt;//= 1;
        public float gcost;// = 0;
        public float hcost;// = 0;
        public float fcost;// = 0;
        public int xx;
        public int yy;
        public sccspathfindgridWorldSize gridworldsize;// = new sccspathfindgridWorldSize();
        //public sccspathfindgridworldindex gridworldstartlast;
        public List<sccspathfindneighboortile> neighboors;// = public List<sccspathfindneighboortile>();
        //public List<sccspathfindneighboortile> extraTiles;// = public List<sccspathfindneighboortile>(); //[]

    }



    public struct sccspathfindneighboortile
    {
        public byte swtc;
        public sccspathfindnode node; //
        public sccsvec2int sgp; // start grid pos
        public int iot; // index of tile
        public int iog; // indes of grid
        public int worldpositionx;
        public int worldpositiony;
        public byte walkable;
    }

    public struct sccspathfindextraTiles
    {
        public int x;
        public int y;
        //public int z;

        public int worldpositionx;
        public int worldpositiony;
        //public int worldpositionz;
        public int iog; //index of grid
        public sccsvec2int sgp; // start grid pos
        public int iot; // index of tile
        public sccspathfindgriddatafinal docg; //data of current grid
    }

    public class sccspathfindcombineddata
    {
        public List<sccspathfindnode> betterroutechecklist;
        public List<sccspathfindnode[]> log;
        public List<sccspathfindnode> openset;
        public List<sccspathfindnode> closedset;
        public List<sccspathfindnode> finalset;
    }

    public struct sccspathfindcheckallsidesdata
    {
        public List<sccspathfindneighboortile> neighboors;
        //public List<sccspathfindextraTiles> extraTiles;
        public List<sccspathfindneighboortile> extraTiles;

    }
    public struct sccspathfindgridWorldSize
    {
        public int xL; //x axis grid left
        public int xR; //x axis grid right
        public int yT; //y axis grid top
        public int yB; //y axis grid bottom
                       //public int zF; //y axis grid top
                       //public int zB; //y axis grid bottom
    }

    public struct sccspathfindobstacledata
    {
        public byte thebyte;
        public int x;
        public int y;
        //public int z;
        public int index;
        public int gridindex;
        public int worldpositionx;
        public int worldpositiony;
        //public int worldpositionz;
        public int gridposx;
        public int gridposy;
        //public int gridposz;
        public int gridtilex;
        public int gridtiley;
        //public int gridtilez;
    }


    public struct sccspathfindnode
    {
        public int parentiog;
        public int parentiot;
        public byte open;
        public byte closed;
        public byte nodeinitswtc;
        public int x;
        public int y;
        //public int z;
        public int index;
        public byte walkable;
        public int gridindex;
        public int worldpositionx;
        public int worldpositiony;
        //public int worldpositionz;

        public float gcost;
        public float hcost;
        public float fcost;
        public float toinitcost;

        public int gridposx;
        public int gridposy;
        //public int gridposz;
        public int gridtilex;
        public int gridtiley;
        //public int gridtilez;
    }
    public struct sccspathfindgridworldindex
    {
        //public int pushaddindex;
        //public int flatindex;

        public int x;
        public int y;
        //public int z;

        public int gridX;
        public int gridY;
        //public int gridZ;
    }
    public struct sccspathfindgriddatafinal
    {
        public sccspathfindgridworldindex gridData;
        public int index;
    }

    public struct sccsvec3int //? c# 10.0 
    {
        public int x;
        public int y;
        public int z;
    }

    public struct sccsvec2float //? c# 10.0 
    {
        public float x;
        public float y;
    }

    public struct sccsvec2int //? c# 10.0 
    {
        public int x;
        public int y;
    }
}

