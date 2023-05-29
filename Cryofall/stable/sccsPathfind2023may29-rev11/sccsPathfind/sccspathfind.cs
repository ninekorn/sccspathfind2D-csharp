//MADE BY STEVE CHASSÉ AKA NINEKORN AKA NINE dob13may1983. 2023 MAY 14TH - MAYBE APACHE 2.0 OR MIT LICENSE. I HAVE YET TO DECIDE.
namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    //using System.IO;
    using System.Linq;
    //using System.Reflection;
    using System.Xml.Linq;
    //using UnityEditor.Build.Reporting;
    //using UnityEditor.Experimental.GraphView;
    //using UnityEngine;
    //using UnityEngine.Experimental.AI;
    //using static UnityEditor.PlayerSettings;

    using sccspathfindnode = sccspathfindstructs.sccspathfindnode;
    //using sccspathfindnodefinal = sccspathfindstructs.sccspathfindnodefinal;
    using sccspathfindcheckallsidesdata = sccspathfindstructs.sccspathfindcheckallsidesdata;

    using sccspathfindextraTiles = sccspathfindstructs.sccspathfindextraTiles;

    using sccspathfindcombineddata = sccspathfindstructs.sccspathfindcombineddata;
    using sccspathfindgriddatafinal = sccspathfindstructs.sccspathfindgriddatafinal;
    using sccspathfindgridworldindex = sccspathfindstructs.sccspathfindgridworldindex;
    using sccspathfindgridWorldSize = sccspathfindstructs.sccspathfindgridWorldSize;

    using sccspathfindneighboortile = sccspathfindstructs.sccspathfindneighboortile;
    //using sccspathfindstationnode = sccspathfindstructs.sccspathfindstationnode;
    using sccsvec2int = sccspathfindstructs.sccsvec2int;
    using sccsvec2float = sccspathfindstructs.sccsvec2float;
    using System.Numerics;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
    using AtomicTorch.CBND.CoreMod.Characters.Player;
    using sccspathfinddata = sccspathfindstructs.sccspathfinddata;



    public static class sccspathfind
    {



        /*
        ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
        public int pathfindoptionhgf = 1;
        public int debugtoconsolemsg = 0;
        public int countingmaxretracepathswtc = 0;
        public int maxRetracePath = 1500;
        int counting = 0;
        int mainSwitch = 1;
        int pathfindi = 0;
        public int pathfindimax = 3;
        //int framecounterpathfindistrying = 0;
        //public int framecounterpathfindistryingmax = 75;
        int framecounterpathfind = 0;
        public int framecounterpathfindmax = 0;
        public int createpathfindvisuals = 0;
        int retracedpathlistcounter = 0;
        public int retracedpathlistcountermaxloop = 1;
        int retracedpathlistcountertwo = 0;
        public int startpathfind = 0;
        int isgridcreated = 0;
        int pathfindswtc = 0;
        int hasstartedpathfindcounter = 0;
        public int hasstartedpathfindcountermax = 75;//1500
        ICharacter thenpc;
        ICharacter theplayer;
        float distancecurrentlast = 0;
        sccspathfindnode lastnode = new sccspathfindnode();
        sccspathfindnode currentNode;
        //public List<sccspathfindnode> retracedpathlist = new List<sccspathfindnode>();
        public Stack<sccspathfindnode> retracedpathlist = new Stack<sccspathfindnode>();
        sccspathfindcombineddata sccspathfindcombineddatavar = new sccspathfindcombineddata();
        sccspathfindnode theseekernode = new sccspathfindnode();
        sccsvec2int initialpathfindnpcpos = new sccsvec2int();
        sccsvec2int targetobjingridpos = new sccsvec2int();
        sccsvec2int initialpathfindstartpos = new sccsvec2int();
        sccsvec2int tempttargetobjingridpospos = new sccsvec2int();
        sccsvec2int lasttransformposition = new sccsvec2int();
        sccsvec2int targetobjingridposposlast = new sccsvec2int();
        int noderadius = 1;
        int gridxl = 2;
        int gridxr = 1;
        int gridyb = 2;
        int gridyt = 1;
        float gcost = 0;
        float hcost = 0;
        float fcost = 0;
        int xx;
        int yy;
        sccspathfindgridWorldSize gridworldsize = new sccspathfindgridWorldSize();
        sccspathfindgridworldindex gridworldstartlast;*/






        //maxRetracePath
        //retracedpathlistcountermax
        //framecounterpathfindmax

        /*
        public GameObject targetobj;
        public GameObject stationobj;
        public GameObject stationmesh;*/



        //int currentNode;




        /*
 public GameObject tilegreen;
 public GameObject tilered;
 public GameObject tileblue;*/


        /*
        public void debugdrawray(sccsvec2int firstnode, sccsvec2int nodeafter)
        {
            float diffx = firstnode.x - nodeafter.x;
            float diffy = firstnode.y - nodeafter.y;

            Vector2 directionfirstnodetonodeafter = new Vector2();

            float distance = GetDistance(firstnode, nodeafter);

            directionfirstnodetonodeafter.x = diffx;
            directionfirstnodetonodeafter.y = diffy;

            directionfirstnodetonodeafter.x /= distance;
            directionfirstnodetonodeafter.y /= distance;


            /*
            if ((int)Math.Round(distance) > 1.0f)
            {
                distance = 1.4f;
            }
            else
            {
                distance = 1.0f;
            }
            // - (new Vector3(directionfirstnodetonodeafter.x, directionfirstnodetonodeafter.y, 0)
            //Debug.DrawRay(new Vector3(firstnode.x,firstnode.y,0) + new Vector3(initialpathfindnpcpos.x, initialpathfindnpcpos.y, 0) - (new Vector3(initialpathfindnpcpos.x, initialpathfindnpcpos.y, 0) - new Vector3(targetobjingridpospos.x, targetobjingridpospos.y, 0)), new Vector3(directionfirstnodetonodeafter.x, directionfirstnodetonodeafter.y, 0) * distance, Color.red, 1.0f);

            //int randposx = (int)targetobj.transform.position.x - (int)this.transform.position.x;
            //int randposy = (int)targetobj.transform.position.y - (int)this.transform.position.y;
            //Vector3 finaloriginpos = new Vector3(randposx, randposy, 0) - new Vector3(firstnode.x, firstnode.y, 0);// - (new Vector3(initialpathfindnpcpos.x, initialpathfindnpcpos.y, 0));// (new Vector3(initialpathfindnpcpos.x, initialpathfindnpcpos.y, 0) - stationobj.transform.position);


            //Debug.DrawRay(new Vector3(firstnode.x, firstnode.y, 0), new Vector3(directionfirstnodetonodeafter.x, directionfirstnodetonodeafter.y, 0) * 1.0f, Color.red, 1.0f);
            Debug.DrawLine(new Vector3(firstnode.x, firstnode.y, 0), new Vector3(nodeafter.x, nodeafter.y, 0), Color.red, 1.0f);
        }*/


       static sccspathfinddata startcreategrid(sccspathfindnode thegridlinknode, sccsvec2int initialpositioningrid, sccsvec2int targetobjingridpos, sccspathfindgridworldindex sccspathfindgridworldindex, out sccspathfindgriddatafinal gridinfo, int pathfinditeration, int alternateoption, sccsvec2int newgridlinkposition, System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata) //sccspathfindnode thegridlinknode //sccsvec2int seekerpositioningrid, //, sccsvec2int gridlastinitpos
        {
            gridinfo = new sccspathfindgriddatafinal();

            sccspathfindnode[] thegrid = new sccspathfindnode[(sccspathfinddata.gridxl + sccspathfinddata.gridxr + 1) * (sccspathfinddata.gridyb + sccspathfinddata.gridyt + 1)];

            sccsvec2int gridlastinitpos = new sccsvec2int();
            gridlastinitpos.x = sccspathfindgridworldindex.x;// thegridlinknode.gridposx;
            gridlastinitpos.y = sccspathfindgridworldindex.y;//thegridlinknode.gridposy;

            sccsvec2int seekerpositioningrid = new sccsvec2int();

            if (alternateoption == 0)
            {
                seekerpositioningrid.x = thegridlinknode.x;
                seekerpositioningrid.y = thegridlinknode.y;
            }
            else
            {
                seekerpositioningrid.x = newgridlinkposition.x;
                seekerpositioningrid.y = newgridlinkposition.y;
            }

            sccspathfinddata.xx = 0;
            sccspathfinddata.yy = 0;

            //sccsvec2int stationposition = new sccsvec2int();
            //stationposition.x = (int)stationobj.transform.position.x;
            //stationposition.y = (int)stationobj.transform.position.y;

            //sccsvestationoutpost outposttilesscript = new sccsvestationoutpost();
            //sccspathfindstationnode[] arrayofstationtiles = outposttilesscript.buildTiles(stationposition);

            for (int x = -sccspathfinddata.gridxl; x <= sccspathfinddata.gridxr; x++)
            {
                for (int y = -sccspathfinddata.gridyb; y <= sccspathfinddata.gridyt; y++)
                {
                    sccspathfinddata.xx = x;
                    sccspathfinddata.yy = y;

                    if (sccspathfinddata.xx < 0)
                    {
                        sccspathfinddata.xx *= -1;
                        sccspathfinddata.xx = (sccspathfinddata.gridxr) + sccspathfinddata.xx;
                    }

                    if (sccspathfinddata.yy < 0)
                    {
                        sccspathfinddata.yy *= -1;
                        sccspathfinddata.yy = (sccspathfinddata.gridyt) + sccspathfinddata.yy;
                    }

                    var index = sccspathfinddata.xx * (sccspathfinddata.gridxl + sccspathfinddata.gridxr + 1) + sccspathfinddata.yy; //y * height + x 

                    /*
                    sccsvec2int stationpos = new sccsvec2int();
                    stationpos.x = (int)stationobj.transform.position.x;
                    stationpos.y = (int)stationobj.transform.position.y;
                    */

                    //stationpos.x += arrayofstationtiles[index];
                    //stationpos.y += arrayofstationtiles[index];

                    sccspathfindnode thecurrentnode = new sccspathfindnode();

                    /*
                    if (arrayofstationtiles[index] == 1)
                    {
                        thecurrentnode.walkable = 0;

                    }
                    else
                    {
                        thecurrentnode.walkable = 1;

                    }*/
                    //var rotWorldForStation = SC_Utilities.RotatePoint(worldPoint, stationTilesArray[cData.iop].coord, stationTilesArray[cData.iop].rot);
                    //var coords = game.GetObjectCoordinates(cData.objt.sid, stationTilesArray[cData.iop].baseID);

                    //var remnant = 360 - stationTilesArray[cData.iop] .rot;
                    //coords = SC_Utilities.RotatePoint(worldPoint, stationTilesArray[cData.iop] .coord, stationTilesArray[cData.iop] .rot);

                    //var getSomeIndex = stationTilesArray[cData.iop].xml_id.substring(11, stationTilesArray[cData.iop].xml_id.length); //outpost_01_0
                    //var parsedAngle = parseInt(getSomeIndex);
                    //coords = SC_Utilities.RotatePoint(coords, stationTilesArray[cData.iop].coord, stationTilesArray[cData.iop].rot);

                    //coords.x = Math.round(coords.x);
                    //coords.y = Math.round(coords.y);

                    //var testX = coords.x + x;7
                    //var testY = coords.y + y;

                    //Debug.Log("/x:" + x + "/y:" + y + "/gcost:" + gcost + "/hcost:" + hcost + "/fcost:" + fcost);

                    thecurrentnode.nodeinitswtc = 1;

                    thecurrentnode.x = x;
                    thecurrentnode.y = y;

                    //TO WORK ON
                    thecurrentnode.worldpositionx = gridlastinitpos.x + x;// + (int)this.transform.position.x;
                    thecurrentnode.worldpositiony = gridlastinitpos.y + y;// + (int)this.transform.position.y;
                                                                          //TO WORK ON

                    sccsvec2int currentnode = new sccsvec2int();
                    currentnode.x = thecurrentnode.worldpositionx;
                    currentnode.y = thecurrentnode.worldpositiony;

                    int toinitcost = sccsmaths.checknodedistanceint(sccspathfinddata.initialpathfindstartpos, currentnode);

                    sccspathfinddata.gcost = sccsmaths.checknodedistanceint(seekerpositioningrid, currentnode);
                    sccspathfinddata.hcost = sccsmaths.checknodedistanceint(targetobjingridpos, currentnode);
                    sccspathfinddata.fcost = sccspathfinddata.gcost + sccspathfinddata.hcost;

                    thecurrentnode.toinitcost = toinitcost;
                    thecurrentnode.gcost = sccspathfinddata.gcost;
                    thecurrentnode.hcost = sccspathfinddata.hcost;
                    thecurrentnode.fcost = sccspathfinddata.fcost;

                    thecurrentnode.gridtilex = x;
                    thecurrentnode.gridtiley = y;

                    thecurrentnode.gridposx = gridinfo.gridData.x;
                    thecurrentnode.gridposy = gridinfo.gridData.y;

                    gridinfo = getNewGridIndex(initialpositioningrid, currentnode, sccspathfinddata.gridworldsize);
                    /*
                    if (createpathfindvisuals == 1)
                    {
                        GameObject cubeobj = UnityEngine.GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cubeobj.transform.position = new Vector3(thecurrentnode.worldpositionx + (int)initialpathfindnpcpos.x, thecurrentnode.worldpositiony + (int)initialpathfindnpcpos.y, 0);
                        cubeobj.transform.rotation = Quaternion.identity;
                        cubeobj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    }*/

                    thecurrentnode.gridindex = gridinfo.index;
                    thecurrentnode.index = index;



                    thecurrentnode.parentiog = -1;
                    thecurrentnode.parentiot = -1;

                    thecurrentnode.closed = 0;
                    thecurrentnode.open = 0;

                    sccsvec2int posoftile2d = new sccsvec2int();
                    posoftile2d.x = (int)thecurrentnode.worldpositionx;// 
                    posoftile2d.y = (int)thecurrentnode.worldpositiony;//

                    sccsvec2int posofplayer = new sccsvec2int();
                    posofplayer.x = (int)sccspathfinddata.theplayer.Position.X - sccspathfinddata.initialpathfindnpcpos.x;
                    posofplayer.y = (int)sccspathfinddata.theplayer.Position.Y - sccspathfinddata.initialpathfindnpcpos.y;

                    sccsvec2int posofnpc = new sccsvec2int();
                    posofnpc.x = (int)sccspathfinddata.thenpc.Position.X - sccspathfinddata.initialpathfindnpcpos.x;
                    posofnpc.y = (int)sccspathfinddata.thenpc.Position.Y - sccspathfinddata.initialpathfindnpcpos.y;



                    if (listofobstacles.Count > 0)
                    {
                        for (int i = 0; i < listofobstacles.Count; i++)
                        {

                            sccsvec2int centerpositionofrotation = new sccsvec2int();
                            centerpositionofrotation.x = ((int)listofobstacles[i].x) - sccspathfinddata.initialpathfindnpcpos.x;
                            centerpositionofrotation.y = ((int)listofobstacles[i].y) - sccspathfinddata.initialpathfindnpcpos.y;



                            if (posofnpc.x == posoftile2d.x && posofnpc.y == posoftile2d.y)
                            {
                                thecurrentnode.walkable = 1;
                            }
                            else
                            {
                                //thecurrentnode.walkable = 1;



                                if (centerpositionofrotation.x == posoftile2d.x && centerpositionofrotation.y == posoftile2d.y)
                                {




                                    if (posofplayer.x == centerpositionofrotation.x && posofplayer.y == centerpositionofrotation.y)
                                    {
                                        thecurrentnode.walkable = 1;

                                    }
                                    else
                                    {

                                        //adminnotify.Execute(theplayer, "tileiswalkable: 0" + "/px: " + posofplayer.x + "/py: " + posofplayer.y + "/tx: " + posoftile2d.x + "/ty: " + posoftile2d.y);//+ "/twx:" + (int)listofobstacles[i].x + "/twy:" + (int)listofobstacles[i].y



                                        thecurrentnode.walkable = 0;



                                        /*
                                        for (var nx = -1; nx <= 1; nx++)
                                        {
                                            for (var ny = -1; ny <= 1; ny++)
                                            {

                                                var xxx = x + nx;
                                                var yyy = y + ny;

                                                if (xxx < 0)
                                                {
                                                    xxx *= -1;
                                                    xxx = (gridxr) + xxx;
                                                }

                                                if (yyy < 0)
                                                {
                                                    yyy *= -1;
                                                    yyy = (gridyt) + yyy;
                                                }

                                                var indexx = xxx * (gridxl + gridxr + 1) + yyy; //y * height + x 


                                                sccsvec2int posoftile2dunwalk = new sccsvec2int();
                                                posoftile2dunwalk.x = (int)thecurrentnode.worldpositionx + nx;// 
                                                posoftile2dunwalk.y = (int)thecurrentnode.worldpositiony + ny;//

                                                if (indexx >= 0 && indexx < (gridxl + gridxr + 1) * (gridyb + gridyt + 1))
                                                {
                                                    if (posofplayer.x == centerpositionofrotation.x && posofplayer.y == centerpositionofrotation.y)
                                                    {

                                                        /*thegrid[indexx].walkable = 1;
                                                        thecurrentnode.walkable = 1;

                                                        if (sccspathfindcombineddatavar.log[gridinfo.index] != null)
                                                        {

                                                        }
                                                        else
                                                        {
                                                            thecurrentnode.walkable = 1;
                                                        }

                                                    }
                                                    else
                                                    {

                                                        thegrid[indexx].walkable = 0;
                                                    }


                                                    adminnotify.Execute(theplayer, "tileiswalkable: 0" + "/px: " + posofplayer.x + "/py: " + posofplayer.y + "/tx: " + posoftile2dunwalk.x + "/ty: " + posoftile2dunwalk.y);//+ "/twx:" + (int)listofobstacles[i].x + "/twy:" + (int)listofobstacles[i].y

                                                }
                                                else
                                                {
                                                    //var neighboorandextratiles = unwalkallsides(thecurrentnode, gridworldsize, initialpathfindstartpos, gridinfo.gridData, listofobstacles);//cData.lip //, gridData00.gridData

                                                }
                                            }
                                        }*/


                                        /*
                                        if (neighboorandextratiles.neighboors.Count > 0)
                                        {
                                            for (var j = 0; j < neighboorandextratiles.neighboors.Count; j++)
                                            {
                                                sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].walkable = (byte)neighboorandextratiles.neighboors[j].walkable;

                                            }
                                        }*/



                                        /*if (neighboorandextratiles.neighboors.Count > 0)
                                        {
                                            for (var j = 0; j < neighboorandextratiles.neighboors.Count; j++)
                                            {
                                                if (sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].closed == 1 ||
                                                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].walkable == 0)
                                                {
                                                    continue;
                                                }


                                                sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].walkable = (byte)neighboorandextratiles.neighboors[j].walkable;


                                                var pos0 = new sccsvec2int();
                                                pos0.x = theseekernode.worldpositionx;
                                                pos0.y = theseekernode.worldpositiony;

                                                var pos1 = new sccsvec2int();
                                                pos1.x = neighboorandextratiles.neighboors[j].node.worldpositionx;
                                                pos1.y = neighboorandextratiles.neighboors[j].node.worldpositiony;



                                                //var toinitcost0 = theseekernode.toinitcost + checknodedistanceint(initialpathfindstartpos, pos1);

                                                var gcost0 = theseekernode.gcost + checknodedistanceint(pos0, pos1);

                                                if (gcost0 < neighboorandextratiles.neighboors[j].node.gcost || sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open == 0) // || sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open == 0
                                                {
                                                    var neighboortile = neighboorandextratiles.neighboors[j];
                                                    neighboortile.node.gcost = gcost0;
                                                    neighboortile.node.hcost = checknodedistanceint(pos1, targetobjingridpos);
                                                    neighboortile.node.fcost = neighboortile.node.gcost + neighboortile.node.hcost;

                                                    neighboortile.node.toinitcost = toinitcost;



                                                    neighboorandextratiles.neighboors[j] = neighboortile;

                                                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].gcost = neighboortile.node.gcost;
                                                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].hcost = neighboortile.node.hcost;
                                                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].fcost = neighboortile.node.fcost;

                                                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].parentiog = theseekernode.gridindex;
                                                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].parentiot = theseekernode.index;

                                                    /*sccspathfindcombineddatavar.finalset.Add(sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index]);

                                                    if (sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open == 0)
                                                    {
                                                        sccspathfindcombineddatavar.openset.Add(neighboorandextratiles.neighboors[j].node);

                                                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open = 1;

                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {

                                        }*/



                                    }
                                }
                                else
                                {
                                    thecurrentnode.walkable = 1;

                                }
                            }
                        }
                    }
                    else
                    {

                        thecurrentnode.walkable = 1;


                    }



                    if (initialpositioningrid.x == currentnode.x && initialpositioningrid.y == currentnode.y)
                    //if (initialpositioningrid.x == thegridlinknode.x && initialpositioningrid.y == thegridlinknode.y)
                    {
                        if (sccspathfinddata.debugtoconsolemsg == 1)
                        {
                            ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                            //Debug.Log("discovered start node");
                            adminnotify.Execute(sccspathfinddata.theplayer, "discovered start node");
                        }

                        sccspathfinddata.sccspathfindcombineddatavar.openset.Add(thecurrentnode);
                        sccspathfinddata.theseekernode = sccspathfinddata.sccspathfindcombineddatavar.openset.First();
                        thecurrentnode.walkable = 1;
                    }

                    /*
                    if (posofnpc.x == posoftile2d.x && posofnpc.y == posoftile2d.y)
                    {
                        thecurrentnode.walkable = 1;
                    }
                    */




                    thegrid[index] = thecurrentnode;


                    //sccspathfindcombineddatavar.log[gridinfo.index][index] = thecurrentnode;















                    //thecurrentnode.walkable = 1;


                }
            }

            if (sccspathfinddata.sccspathfindcombineddatavar.log.Count == 0)
            {
                for (int g = 0; g < (sccspathfinddata.gridxl + sccspathfinddata.gridxr + 1) * (sccspathfinddata.gridyb + sccspathfinddata.gridyt + 1); g++)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                }
                //sccspathfindcombineddatavar.log.Add(finalnodelist.nodelist);
                sccspathfinddata.sccspathfindcombineddatavar.log[gridinfo.index] = thegrid;
            }
            else
            {
                //Debug.Log(gridinfo.index + "/log.count:" + sccspathfindcombineddatavar.log.Count);
                var diff0 = gridinfo.index - sccspathfinddata.sccspathfindcombineddatavar.log.Count;
                for (int g = 0; g < diff0 + 1; g++)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                }
                sccspathfinddata.sccspathfindcombineddatavar.log[gridinfo.index] = thegrid;
            }
            /*
            sccspathfindnodefinal finalnodelist = new sccspathfindnodefinal();
            finalnodelist.nodelist = thegrid;
            */


            //return thegrid;

            return sccspathfinddata;
        }


        
       private static sccspathfinddata pathfindcoroutine(System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata)//IEnumerator
        {
            sccsvec2int initposnewgrid0 = new sccsvec2int();
            initposnewgrid0.x = sccspathfinddata.theseekernode.worldpositionx;
            initposnewgrid0.y = sccspathfinddata.theseekernode.worldpositiony;

            var gridData00 = getNewGridIndex(sccspathfinddata.initialpathfindstartpos, initposnewgrid0, sccspathfinddata.gridworldsize);

            sccspathfindgridworldindex gridworldstart = new sccspathfindgridworldindex();
            gridworldstart.x = gridData00.gridData.x;
            gridworldstart.y = gridData00.gridData.y;

            gridworldstart.gridX = gridData00.gridData.gridX;
            gridworldstart.gridY = gridData00.gridData.gridY;

            sccspathfindgriddatafinal gridData0;

            var diff0 = sccspathfinddata.theseekernode.gridindex - (sccspathfinddata.sccspathfindcombineddatavar.log.Count);

            for (int g = 0; g < diff0 + 1; g++)
            {
                sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
            }

            if (sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.theseekernode.gridindex] == null)
            {
                sccspathfinddata= startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldstart, out gridData0, 0, 0, new sccsvec2int(), listofobstacles, sccspathfinddata);
            }

            /*
            if (theseekernode.worldpositionx == targetobjingridpos.x && theseekernode.worldpositiony == targetobjingridpos.y)
            {
                Debug.Log("found target node");
                startpathfind = 3;
                //break;
            }*/
            /*
            sccsvec2int lastnodepos = new sccsvec2int();
            lastnodepos.x = lastnode.worldpositionx;
            lastnodepos.y = lastnode.worldpositiony;

            sccsvec2int currentnodepos = new sccsvec2int();
            currentnodepos.x = theseekernode.worldpositionx;
            currentnodepos.y = theseekernode.worldpositiony;
            float distancecurrent = GetDistance(currentnodepos, initialpathfindstartpos);
            float distancecurrentoflastnode = GetDistance(lastnodepos, initialpathfindstartpos);

            if (distancecurrentoflastnode < distancecurrent)
            {
                startpathfind = 3;

            }*/

            //distancecurrentlast = distancecurrent;
            /*if (theseekernode.worldpositionx == targetobjingridpos.x && theseekernode.worldpositiony == targetobjingridpos.y)
            {
                Debug.Log("found target node");
                startpathfind = 3;
                //break;
            }*/

            if (sccspathfinddata.sccspathfindcombineddatavar.openset.Count > 0)
            {
                sccspathfinddata.sccspathfindcombineddatavar.closedset.Add(sccspathfinddata.sccspathfindcombineddatavar.openset[0]);
                sccspathfinddata.sccspathfindcombineddatavar.openset.RemoveAt(0);

                if (sccspathfinddata.sccspathfindcombineddatavar.openset.Count > 0)
                {
                    //https://stackoverflow.com/questions/4003835/sort-list-in-c-sharp-with-linq

                    //sccspathfindcombineddatavar.openset = sccspathfindcombineddatavar.openset.OrderBy(x => x.fcost).ThenBy(x => x.hcost).ToList(); // ThenBy(x => x.gcost)
                    //sccspathfindcombineddatavar.openset = sccspathfindcombineddatavar.openset.OrderBy(x => x.hcost).ThenBy(x => x.fcost).ToList(); //ThenBy(x => x.hcost)
                    //heapSort(sccspathfindcombineddatavar.openset, sccspathfindcombineddatavar.openset.Count, "hcost"); //hcost

                    //sccspathfindcombineddatavar.openset = sccspathfindcombineddatavar.openset.OrderBy(x => x.fcost).ThenBy(x => x.toinitcost).ThenBy(x => x.hcost).ToList();
                    //sccspathfindcombineddatavar.openset = sccspathfindcombineddatavar.openset.OrderBy(x => x.toinitcost).ToList();

                    //heapSort(sccspathfindcombineddatavar.openset, sccspathfindcombineddatavar.openset.Count, "fcost"); //hcost
                    //heapSort(sccspathfindcombineddatavar.openset, sccspathfindcombineddatavar.openset.Count, "hcost"); //hcost

                    /*heapSort(sccspathfindcombineddatavar.openset, sccspathfindcombineddatavar.openset.Count, "gcost"); //hcost
                    heapSort(sccspathfindcombineddatavar.openset, sccspathfindcombineddatavar.openset.Count, "fcost"); //hcost
                    heapSort(sccspathfindcombineddatavar.openset, sccspathfindcombineddatavar.openset.Count, "hcost"); //hcost
                    */

                    if (sccspathfinddata.pathfindoptionhgf == 0) //fcost
                    {
                         sccspathfinddata.sccspathfindcombineddatavar.openset =  sccspathfinddata.sccspathfindcombineddatavar.openset.OrderBy(x => x.fcost).ThenBy(x => x.toinitcost).ToList(); //ThenBy(x => x.toinitcost)
                    }
                    else if (sccspathfinddata.pathfindoptionhgf == 1) //hcost
                    {
                         sccspathfinddata.sccspathfindcombineddatavar.openset =  sccspathfinddata.sccspathfindcombineddatavar.openset.OrderBy(x => x.hcost).ThenBy(x => x.fcost).ToList(); //ThenBy(x => x.toinitcost) //.ThenBy(x => x.toinitcost)
                    }
                    else if (sccspathfinddata.pathfindoptionhgf == 2) //gcost
                    {
                         sccspathfinddata.sccspathfindcombineddatavar.openset =  sccspathfinddata.sccspathfindcombineddatavar.openset.OrderBy(x => x.fcost).ThenBy(x => x.hcost).ThenBy(x => x.gcost).ToList(); //ThenBy(x => x.toinitcost)
                    }

                    //Debug.Log("/m0gcost:" + theseekernode.gcost + "/m0hcost:" + theseekernode.hcost + "/m0fcost:" + theseekernode.fcost);
                    sccspathfinddata.theseekernode =  sccspathfinddata.sccspathfindcombineddatavar.openset.First();

                    /*for (int i = 1; i <  sccspathfinddata.sccspathfindcombineddatavar.openset.Count; i++)
                    {
                        if ( sccspathfinddata.sccspathfindcombineddatavar.openset[i].fcost < theseekernode.fcost ||  sccspathfinddata.sccspathfindcombineddatavar.openset[i].fcost == theseekernode.fcost)
                        {

                            if ( sccspathfinddata.sccspathfindcombineddatavar.openset[i].hcost < theseekernode.hcost)
                            {
                                //theseekernode =  sccspathfinddata.sccspathfindcombineddatavar.openset[i];

                                if ( sccspathfinddata.sccspathfindcombineddatavar.openset[i].gcost < theseekernode.gcost)
                                {
                                    theseekernode =  sccspathfinddata.sccspathfindcombineddatavar.openset[i];
                                }
                            }
                            if ( sccspathfinddata.sccspathfindcombineddatavar.openset[i].fcost < theseekernode.fcost)
                            {
                                theseekernode =  sccspathfinddata.sccspathfindcombineddatavar.openset[i];
                            }

                        }
                    }*/

                    sccspathfinddata.theseekernode.closed = 1;
                    sccspathfinddata.theseekernode.open = 0;
                }
            }
            else
            {
                if (sccspathfinddata.debugtoconsolemsg == 1)
                {
                    ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                    adminnotify.Execute(sccspathfinddata.theplayer, "pathfind open set had no nodes.");
                }


                //startpathfind = 1;
            }
            /*if (createpathfindvisuals == 1)
            {
                Instantiate(tileblue, new Vector3(theseekernode.worldpositionx + (int)initialpathfindnpcpos.x, theseekernode.worldpositiony + (int)initialpathfindnpcpos.y), Quaternion.identity);
            }*/

            if (sccspathfinddata.theseekernode.worldpositionx == sccspathfinddata.targetobjingridpos.x && sccspathfinddata.theseekernode.worldpositiony == sccspathfinddata.targetobjingridpos.y)
            {
                if (sccspathfinddata.debugtoconsolemsg == 1)
                {
                    ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                    adminnotify.Execute(sccspathfinddata.theplayer, "found target node");
                }
                //Debug.Log("found target node");
                sccspathfinddata.startpathfind = 3;
                //break;
            }
            else
            {
                sccspathfinddata = checkAllSidesGridIndex(sccspathfinddata.theseekernode, sccspathfinddata.gridworldsize, sccspathfinddata.initialpathfindstartpos, gridData00.gridData, listofobstacles, sccspathfinddata);//cData.lip //, gridData00.gridData

                if (sccspathfinddata.pathfindswtc == 0 && sccspathfinddata.startpathfind != 3)
                {
                    /*
                    if (sccspathfinddata.extraTiles != null)
                    {
                        if (sccspathfinddata.extraTiles.Count > 0)
                        {
                            for (var i = 0; i < sccspathfinddata.extraTiles.Count; i++)
                            {
                                sccsvec2int initposnewgrid = new sccsvec2int();

                                initposnewgrid.x = sccspathfinddata.extraTiles[i].worldpositionx;
                                initposnewgrid.y = sccspathfinddata.extraTiles[i].worldpositiony;

                                var gridData = getNewGridIndex(sccspathfinddata.initialpathfindstartpos, initposnewgrid, sccspathfinddata.gridworldsize); //, cData.objt.sid


                                //if (gridData.index == sccspathfinddata.extraTiles[i].iog)
                                //{
                                //    //Debug.Log("THE INDEX IS THE SAME");
                                //}

                                var diff = sccspathfinddata.extraTiles[i].iog - sccspathfinddata.sccspathfindcombineddatavar.log.Count;

                                for (int g = 0; g < diff + 1; g++)
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                                }

                                sccsvec2int posofgrid = new sccsvec2int();
                                posofgrid.x = gridData.gridData.gridX;
                                posofgrid.y = gridData.gridData.gridY;

                                //Debug.Log("gindex:" + gridData.index + "/x:" + gridData.gridData.gridX + "/y:" + gridData.gridData.gridY);

                                sccspathfindgridworldindex gridworldlink = new sccspathfindgridworldindex();
                                gridworldlink.x = gridData.gridData.x;
                                gridworldlink.y = gridData.gridData.y;
                                gridworldlink.gridX = gridData.gridData.gridX;
                                gridworldlink.gridY = gridData.gridData.gridY;

                                var extratilepos = new sccsvec2int();
                                extratilepos.x = sccspathfinddata.extraTiles[i].worldpositionx;
                                extratilepos.y = sccspathfinddata.extraTiles[i].worldpositiony;

                                var result = startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData0, sccspathfinddata.pathfindi, 1, extratilepos,listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 

                                /*var pos0 = new sccsvec2int();
                                pos0.x = theseekernode.worldpositionx;
                                pos0.y = theseekernode.worldpositiony;

                                var pos1 = new sccsvec2int();
                                pos1.x = sccspathfinddata.extraTiles[i].worldpositionx;
                                pos1.y = sccspathfinddata.extraTiles[i].worldpositiony;

                                var gcost = checknodedistanceint(pos0, pos1);
                                
                                //sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].gcost = gcost;
                                //sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].hcost = checknodedistanceint(pos1, targetobjingridpos);
                                //sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].fcost = sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].gcost + sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].hcost;


                                var emptygridvec = new sccsvec2int();
                                emptygridvec.x = 0;
                                emptygridvec.y = 0;

                                sccspathfinddata.neighboors.Add(new sccspathfindneighboortile { swtc = 0, node = sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot], sgp = emptygridvec, iot = sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].index, iog = sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.extraTiles[i].iog][sccspathfinddata.extraTiles[i].iot].gridindex });

                                //Instantiate(tilegreen, new Vector3(sccspathfinddata.extraTiles[i].worldpositionx, sccspathfinddata.extraTiles[i].worldpositiony), Quaternion.identity);
                            }
                        }
                    }*/


                    if (sccspathfinddata.neighboors.Count > 0)
                    {
                        for (var j = 0; j < sccspathfinddata.neighboors.Count; j++)
                        {
                            if (sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].closed == 1 ||
                            sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].walkable == 0)
                            {
                                continue;
                            }

                            var pos0 = new sccsvec2int();
                            pos0.x = sccspathfinddata.theseekernode.worldpositionx;
                            pos0.y = sccspathfinddata.theseekernode.worldpositiony;

                            var pos1 = new sccsvec2int();
                            pos1.x = sccspathfinddata.neighboors[j].node.worldpositionx;
                            pos1.y = sccspathfinddata.neighboors[j].node.worldpositiony;



                            var toinitcost = sccspathfinddata.theseekernode.toinitcost + sccsmaths.checknodedistanceint(sccspathfinddata.initialpathfindstartpos, pos1);

                            var gcost = sccspathfinddata.theseekernode.gcost + sccsmaths.checknodedistanceint(pos0, pos1);

                            if (gcost < sccspathfinddata.neighboors[j].node.gcost || sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].open == 0) // || sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].open == 0
                            {
                                var neighboortile = sccspathfinddata.neighboors[j];
                                neighboortile.node.gcost = gcost;
                                neighboortile.node.hcost = sccsmaths.checknodedistanceint(pos1, sccspathfinddata.targetobjingridpos);
                                neighboortile.node.fcost = neighboortile.node.gcost + neighboortile.node.hcost;

                                neighboortile.node.toinitcost = toinitcost;



                                sccspathfinddata.neighboors[j] = neighboortile;

                                sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].gcost = neighboortile.node.gcost;
                                sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].hcost = neighboortile.node.hcost;
                                sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].fcost = neighboortile.node.fcost;

                                sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].parentiog = sccspathfinddata.theseekernode.gridindex;
                                sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].parentiot = sccspathfinddata.theseekernode.index;


                                if (sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].open == 0)
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index].open = 1;


                                    //sccspathfindcombineddatavar.openset.Add(sccspathfinddata.neighboors[j].node);
                                    sccspathfinddata.sccspathfindcombineddatavar.openset.Add(sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index]);
                                    sccspathfinddata.sccspathfindcombineddatavar.finalset.Add(sccspathfinddata.sccspathfindcombineddatavar.log[sccspathfinddata.neighboors[j].node.gridindex][sccspathfinddata.neighboors[j].node.index]);

                                    /*if (createpathfindvisuals == 1)
                                    {
                                        Instantiate(tilegreen, new Vector3(sccspathfinddata.neighboors[j].node.worldpositionx + (int)initialpathfindnpcpos.x, sccspathfinddata.neighboors[j].node.worldpositiony + (int)initialpathfindnpcpos.y), Quaternion.identity);
                                    }*/
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
            }

            /*
            pathfindi++;

            if (pathfindi >= pathfindimax)
            {
                pathfindi = 0;
            }*/

            //yield return new WaitForSeconds(3);
            return sccspathfinddata;
        }



        public static sccspathfinddata LoopPathfind(sccsvec2float npcpos, sccsvec2float targetpos, System.Collections.Generic.List<sccsvec2int> listofobstacles, ICharacter npccharacter_, ICharacter playercharacter_, sccspathfinddata sccspathfinddata)
        {
            if (sccspathfinddata.startpathfind == 1)
            {
                sccspathfinddata.thenpc = npccharacter_;
                sccspathfinddata.theplayer = playercharacter_;


                sccspathfinddata.gridworldsize.xL = sccspathfinddata.gridxl;
                sccspathfinddata.gridworldsize.xR = sccspathfinddata.gridxr;
                sccspathfinddata.gridworldsize.yB = sccspathfinddata.gridyb;
                sccspathfinddata.gridworldsize.yT = sccspathfinddata.gridyt;

                //int randposxp = 0;// (int)this.transform.position.x;
                //int randposyp = 0;//(int)this.transform.position.y;

                sccsvec2int npcinitposofpathfindzerozero = new sccsvec2int();
                npcinitposofpathfindzerozero.x = 0;
                npcinitposofpathfindzerozero.y = 0;

                sccspathfinddata.initialpathfindstartpos = new sccsvec2int();
                sccspathfinddata.initialpathfindstartpos.x = npcinitposofpathfindzerozero.x;// + (int)this.transform.position.x;
                sccspathfinddata.initialpathfindstartpos.y = npcinitposofpathfindzerozero.y;//+ (int)this.transform.position.y;

                //int randposx = (int)getSomeRandNumThousandDecimal(0, 100, 1, 1, 0) + (int)this.transform.position.x;
                //int randposy = (int)getSomeRandNumThousandDecimal(0, 100, 1, 1, 0) + (int)this.transform.position.y;

                //int randposx = (int)targetobj.transform.position.x - (int)this.transform.position.x;
                //int randposy = (int)targetobj.transform.position.y - (int)this.transform.position.y;

                //int randposx = (int)targetobj.transform.position.x; //(int)this.transform.position.x
                //int randposy = (int)targetobj.transform.position.y; // - (int)this.transform.position.y

                int targetlocationwithdiffxremoved = (int)targetpos.x - (int)npcpos.x;//(int)targetobj.transform.position.x -this.transform.position.x;
                int targetlocationwithdiffyremoved = (int)targetpos.y - (int)npcpos.y;// (int)targetobj.transform.position.y -this.transform.position.y;

                sccspathfinddata.initialpathfindnpcpos = new sccsvec2int();
                sccspathfinddata.initialpathfindnpcpos.x = (int)Math.Round((double)npcpos.x);
                sccspathfinddata.initialpathfindnpcpos.y = (int)Math.Round((double)npcpos.y);

                //Debug.Log("/targetposx" + randposx + "/targetposy:" + randposy);

                sccspathfinddata.targetobjingridpos = new sccsvec2int();
                sccspathfinddata.targetobjingridpos.x = targetlocationwithdiffxremoved;
                sccspathfinddata.targetobjingridpos.y = targetlocationwithdiffyremoved;

                sccspathfinddata.theseekernode.x = sccspathfinddata.initialpathfindstartpos.x;
                sccspathfinddata.theseekernode.y = sccspathfinddata.initialpathfindstartpos.y;
                sccspathfinddata.theseekernode.index = 0;
                sccspathfinddata.theseekernode.gridtilex = 0;
                sccspathfinddata.theseekernode.gridtiley = 0;
                sccspathfinddata.theseekernode.walkable = 1;
                sccspathfinddata.theseekernode.worldpositionx = 0;
                sccspathfinddata.theseekernode.worldpositiony = 0;

                sccsvec2int finaltargetpos = new sccsvec2int();
                finaltargetpos.x = (int)targetpos.x; //+(int)this.transform.position.x
                finaltargetpos.y = (int)targetpos.y; //+(int)this.transform.position.y

                /*if (debugtoconsolemsg == 1)
                {
                    ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                    //Debug.Log("/finaltargetposx" + finaltargetpos.x + "/finaltargetposy:" + finaltargetpos.y);
                    adminnotify.Execute(theplayer, "/finaltargetposx" + finaltargetpos.x + "/finaltargetposy:" + finaltargetpos.y);
                }*/


             


                if (sccspathfinddata.sccspathfindcombineddatavar.openset == null)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.openset = new List<sccspathfindnode>();
                }
                else
                {
                    sccspathfinddata.sccspathfindcombineddatavar.openset.Clear();
                }

                if (sccspathfinddata.sccspathfindcombineddatavar.closedset == null)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.closedset = new List<sccspathfindnode>();
                }
                else
                {
                    sccspathfinddata.sccspathfindcombineddatavar.closedset.Clear();
                }

                if (sccspathfinddata.sccspathfindcombineddatavar.finalset == null)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.finalset = new List<sccspathfindnode>();
                }
                else
                {
                    sccspathfinddata.sccspathfindcombineddatavar.finalset.Clear();
                }


                if (sccspathfinddata.sccspathfindcombineddatavar.log == null)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.log = new List<sccspathfindnode[]>();
                }
                else
                {
                    sccspathfinddata.sccspathfindcombineddatavar.log.Clear();
                }

                if (sccspathfinddata.sccspathfindcombineddatavar.betterroutechecklist == null)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.betterroutechecklist = new List<sccspathfindnode>();
                }
                else
                {
                    sccspathfinddata.sccspathfindcombineddatavar.betterroutechecklist.Clear();
                }

                if (sccspathfinddata.retracedpathlist == null)
                {
                    sccspathfinddata.retracedpathlist = new Stack<sccspathfindnode>();
                }
                else
                {
                    sccspathfinddata.retracedpathlist.Clear();
                }



                sccspathfinddata.countingmaxretracepathswtc = 0;
                sccspathfinddata.counting = 0;
                sccspathfinddata.mainSwitch = 1;


                sccspathfinddata.retracedpathlistcountertwo = 0;
                sccspathfinddata.retracedpathlistcounter = 0;
                //framecounterpathfindistrying = 0;
                sccspathfinddata.framecounterpathfind = 0;




                if (sccspathfinddata.retracedpathlistcountermaxloop == 0)
                {
                    sccspathfinddata.retracedpathlistcountermaxloop = 1;
                }



                if (sccspathfinddata.pathfindimax == 0)
                {
                    sccspathfinddata.pathfindimax = 1;
                }




                sccspathfinddata.startpathfind = 2;
                sccspathfinddata.isgridcreated = 1;
                //startpathfind = 2;
            }

            try
            {
                if (sccspathfinddata.startpathfind == 2)
                {

                    /*if (sccspathfinddata.debugtoconsolemsg == 1)
                    {
                        ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                        adminnotify.Execute(sccspathfinddata.theplayer, "test");
                    }*/



                    if (sccspathfinddata.isgridcreated == 1)
                    {

                        /*if (framecounterpathfindistrying >= framecounterpathfindistryingmax)
                        {
                            startpathfind = 1;
                            framecounterpathfindistrying = 0;
                        }*/



                        if (sccspathfinddata.framecounterpathfind >= sccspathfinddata.framecounterpathfindmax)
                        {
                            //StartCoroutine("pathfindcoroutine");



                            if (sccspathfinddata.hasstartedpathfindcounter >= sccspathfinddata.hasstartedpathfindcountermax)
                            {
                                ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
                                adminnotify.Execute(sccspathfinddata.theplayer, "test");


                                sccspathfinddata.startpathfind = 1;
                                sccspathfinddata.hasstartedpathfindcounter = 0;
                            }
                            else
                            {
                                for (int i = 0; i < sccspathfinddata.pathfindimax; i++)
                                {
                                    sccspathfinddata = pathfindcoroutine(listofobstacles, sccspathfinddata);

                                    sccspathfinddata.hasstartedpathfindcounter++;
                                    //framecounterpathfindistrying++;
                                }

                            }



                            //TO REMOVE OTHERWISE PATHFIND WON'T RESTART
                            //startpathfind = 3;
                            //TO REMOVE OTHERWISE PATHFIND WON'T RESTART

                            sccspathfinddata.framecounterpathfind = 0;
                        }
                        sccspathfinddata.framecounterpathfind++;

                    }
                }
                else if (sccspathfinddata.startpathfind == 3)
                {
                    if (sccspathfinddata.countingmaxretracepathswtc == 1)//counting >= maxRetracePath)
                    {
                        if (sccspathfinddata.debugtoconsolemsg == 1)
                        {
                            ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                            adminnotify.Execute(sccspathfinddata.theplayer, "end of RetracePath:" + sccspathfinddata.counting + "/retracedpathlist.Count:" + sccspathfinddata.retracedpathlist.Count);
                        }

                        //Debug.Log("end of RetracePath:" + counting + "/retracedpathlist.Count:" + retracedpathlist.Count);

                        //lastnode = sccspathfindcombineddatavar.finalset[sccspathfindcombineddatavar.finalset.Count - 1];
                        /*
                        if (retracedpathlist.Count > 0)
                        {
                            retracedpathlist.RemoveAt(0);
                        }

                        if (retracedpathlist.Count > 0)
                        {
                            retracedpathlist.RemoveAt(retracedpathlist.Count - 1);
                        }*/




                        sccspathfinddata.countingmaxretracepathswtc = 2;
                    }
                    else if (sccspathfinddata.countingmaxretracepathswtc == 0)
                    {
                        /*
                        if (pathfin)
                        {

                        }*/

                        //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                        //adminnotify.Execute(sccspathfinddata.theplayer, "frame arrived here");

                        if (sccspathfinddata.retracedpathlistcounter >= sccspathfinddata.retracedpathlistcountermax)
                        {
                            sccspathfinddata.startpathfind = 1;
                            sccspathfinddata.retracedpathlistcounter = 0;
                        }

                        if (sccspathfinddata.counting == 0)//the retracepathhasn't started yet.
                        {
                            //https://stackoverflow.com/questions/4003835/sort-list-in-c-sharp-with-linq
                            //sccspathfindcombineddatavar.finalset = sccspathfindcombineddatavar.finalset.OrderBy(x => x.fcost).ThenBy(x => x.toinitcost).ThenBy(x => x.hcost).ToList();

                            if (sccspathfinddata.sccspathfindcombineddatavar.finalset.Count > 0)
                            {
                                sccspathfinddata= RetracePath(sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, sccspathfinddata.sccspathfindcombineddatavar.finalset[sccspathfinddata.sccspathfindcombineddatavar.finalset.Count - 1], 1, sccspathfinddata);// theseekernode);
                                sccspathfinddata.retracedpathlistcounter++;
                            }                          
                           else
                            {
                                sccspathfinddata.startpathfind = 1;
                            }

                            //RetracePath(initialpathfindstartpos, targetobjingridpos, theseekernode, 1);
                            //RetracePath(initialpathfindstartpos, targetobjingridpos, sccspathfindcombineddatavar.closedset[sccspathfindcombineddatavar.closedset.Count - 1], 1);// theseekernode);

                            //RetracePath(initialpathfindstartpos, targetobjingridpos, sccspathfindcombineddatavar.openset[0], 1);// theseekernode);

                        }
                        else
                        {
                            for (int i = 0; i < sccspathfinddata.retracedpathlistcountermaxloop; i++)
                            {
                                sccspathfinddata = RetracePath(sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, sccspathfinddata.currentNode, 0, sccspathfinddata);// theseekernode);

                                sccspathfinddata.retracedpathlistcounter++;
                            }
                        }





                    }
                    else if (sccspathfinddata.countingmaxretracepathswtc == 2)
                    {
                        //if (createpathfindvisuals == 1)
                        {
                            /*for (int i = 0; i < retracedpathlist.Count - 1; i++)
                            {
                                if (retracedpathlist.Count + 1 > 1)
                                {
                                    Vector3 thenodepos = new Vector3(retracedpathlist[i].worldpositionx, retracedpathlist[i].worldpositiony, 0);
                                    Vector3 dirtoplayernpc = new Vector3(initialpathfindnpcpos.x, initialpathfindnpcpos.y, 0) - new Vector3(0, 0, 0); // new Vector3(targetobjingridpos.x, targetobjingridpos.y, 0) 
                                    //dirtoplayernpc.Normalize();

                                    Vector3 movethepoint = thenodepos + (dirtoplayernpc);

                                    Vector3 thenodepos1 = new Vector3(retracedpathlist[i + 1].worldpositionx, retracedpathlist[i + 1].worldpositiony, 0);
                                    //dirtoplayernpc.Normalize();

                                    Vector3 movethepoint1 = thenodepos1 + (dirtoplayernpc);

                                    sccsvec2int firstnode = new sccsvec2int();
                                    firstnode.x = (int)Math.Round(movethepoint.x);// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                                    firstnode.y = (int)Math.Round(movethepoint.y);// + (initialpathfindnpcpos.y - targetobjingridpospos.y);// + (int)initialpathfindnpcpos.y;

                                    sccsvec2int nodeafter = new sccsvec2int();
                                    nodeafter.x = (int)Math.Round(movethepoint1.x);// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                                    nodeafter.y = (int)Math.Round(movethepoint1.y);// + (initialpathfindnpcpos.y - targetobjingridpospos.y);// + (int)initialpathfindnpcpos.y;



                                    debugdrawray(firstnode, nodeafter);
                                }
                            }*/
                            sccspathfinddata.retracedpathlistcounter = 0;
                            sccspathfinddata.startpathfind = 4;


                            
                            if (sccspathfinddata.retracedpathlist.Count > 0)
                            {
                                //retracedpathlist.RemoveAt(retracedpathlist.Count-1);

                                sccspathfinddata.retracedpathlist.Pop();

                            }
                            







                            /*
                            //Debug.Log("******TEST********1");
                            if (retracedpathlistcountertwo >= retracedpathlistcountermax)
                            {
                                if (retracedpathlistcounter >= retracedpathlist.Count)
                                {
                                    targetobjingridposposlast = targetobjingridpos;

                                    //lasttransformposition = new sccsvec2int();

                                    //lasttransformposition.x = (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.x;
                                    //lasttransformposition.y = (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.y;

                                    retracedpathlistcounter = 0;
                                    startpathfind = 4;
                                }
                                else
                                {
                                    //int diffx1 = (targetobjingridpospos.x - initialpathfindstartpos.x);
                                    //int diffy1 = (targetobjingridpospos.y - initialpathfindstartpos.y);

                                    //Instantiate(tilered, new Vector3(retracedpathlist[retracedpathlistcounter].worldpositionx, retracedpathlist[retracedpathlistcounter].worldpositiony), Quaternion.identity);
                                    if (retracedpathlistcounter + 1 < retracedpathlist.Count - 1)
                                    {
                                        /*sccsvec2int firstnode = new sccsvec2int();
                                        firstnode.x = retracedpathlist[retracedpathlistcounter].worldpositionx + (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.x;
                                        firstnode.y = retracedpathlist[retracedpathlistcounter].worldpositiony + (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.y;

                                        sccsvec2int nodeafter = new sccsvec2int();
                                        nodeafter.x = retracedpathlist[retracedpathlistcounter + 1].worldpositionx + (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.x;
                                        nodeafter.y = retracedpathlist[retracedpathlistcounter + 1].worldpositiony + (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.y;
                                        */

                            /*
                            sccsvec2int firstnode = new sccsvec2int();
                            firstnode.x = retracedpathlist[retracedpathlistcounter].worldpositionx + initialpathfindnpcpos.x;// ;// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                            firstnode.y = retracedpathlist[retracedpathlistcounter].worldpositiony + initialpathfindnpcpos.y;// ;// + (initialpathfindnpcpos.y - targetobjingridpospos.y);//+ (int)initialpathfindnpcpos.y;

                            sccsvec2int nodeafter = new sccsvec2int();
                            nodeafter.x = retracedpathlist[retracedpathlistcounter + 1].worldpositionx + initialpathfindnpcpos.x;// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                            nodeafter.y = retracedpathlist[retracedpathlistcounter + 1].worldpositiony + initialpathfindnpcpos.y;// + (initialpathfindnpcpos.y - targetobjingridpospos.y);// + (int)initialpathfindnpcpos.y;
                            */
                            /*sccsvec2int firstnode = new sccsvec2int();
                            firstnode.x = retracedpathlist[retracedpathlistcounter].worldpositionx;// ;// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                            firstnode.y = retracedpathlist[retracedpathlistcounter].worldpositiony;// ;// + (initialpathfindnpcpos.y - targetobjingridpospos.y);//+ (int)initialpathfindnpcpos.y;

                            sccsvec2int nodeafter = new sccsvec2int();
                            nodeafter.x = retracedpathlist[retracedpathlistcounter + 1].worldpositionx;// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                            nodeafter.y = retracedpathlist[retracedpathlistcounter + 1].worldpositiony;// + (initialpathfindnpcpos.y - targetobjingridpospos.y);// + (int)initialpathfindnpcpos.y;


                            Vector3 thenodepos = new Vector3(retracedpathlist[retracedpathlistcounter].worldpositionx, retracedpathlist[retracedpathlistcounter].worldpositiony, 0);
                            Vector3 dirtoplayernpc = new Vector3(initialpathfindnpcpos.x, initialpathfindnpcpos.y,0) - stationobj.transform.position;
                            //dirtoplayernpc.Normalize();

                            Vector3 movethepoint = thenodepos + (dirtoplayernpc);

                            Vector3 thenodepos1 = new Vector3(retracedpathlist[retracedpathlistcounter+1].worldpositionx, retracedpathlist[retracedpathlistcounter+1].worldpositiony, 0);
                            //dirtoplayernpc.Normalize();

                            Vector3 movethepoint1 = thenodepos1 + (dirtoplayernpc);

                            sccsvec2int firstnode = new sccsvec2int();
                            firstnode.x = (int)Math.Round(movethepoint.x);// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                            firstnode.y = (int)Math.Round(movethepoint.y);// + (initialpathfindnpcpos.y - targetobjingridpospos.y);// + (int)initialpathfindnpcpos.y;

                            sccsvec2int nodeafter = new sccsvec2int();
                            nodeafter.x = (int)Math.Round(movethepoint1.x);// + (initialpathfindnpcpos.x - targetobjingridpospos.x);// + (int)initialpathfindnpcpos.x;
                            nodeafter.y = (int)Math.Round(movethepoint1.y);// + (initialpathfindnpcpos.y - targetobjingridpospos.y);// + (int)initialpathfindnpcpos.y;



                            debugdrawray(firstnode, nodeafter);
                        }

                        if (createpathfindvisuals == 1)
                        {  
                            Instantiate(tilered, new Vector3(retracedpathlist[retracedpathlistcounter].worldpositionx + (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.x, retracedpathlist[retracedpathlistcounter].worldpositiony + (int)this.transform.gameObject.GetComponent<Rigidbody2D>().position.y), Quaternion.identity);

                           //Instantiate(tilered, new Vector3(retracedpathlist[retracedpathlistcounter].worldpositionx, retracedpathlist[retracedpathlistcounter].worldpositiony), Quaternion.identity);
                        }

                    }

                    retracedpathlistcounter++;
                    retracedpathlistcountertwo = 0;
                }
                retracedpathlistcountertwo++;*/

                        }
                    }
                }







                // Debug.Log("startpathfind:" + startpathfind);

                if (sccspathfinddata.startpathfind == 2 || sccspathfinddata.startpathfind == -1)
                {


                }







                /*
                if (startpathfind == 4)
                {
                    int randposx0 = (int)Math.Round(targetpos.x) - (int)Math.Round((double)lasttransformposition.x);
                    int randposy0 = (int)Math.Round(targetpos.y) - (int)Math.Round((double)lasttransformposition.y);
                    //Debug.Log("/targetposx" + randposx + "/targetposy:" + randposy);

                    tempttargetobjingridpospos = new sccsvec2int();
                    tempttargetobjingridpospos.x = randposx0;
                    tempttargetobjingridpospos.y = randposy0;
                    /*
                    if (lasttransformposition.x != (int)Math.Round(npcpos.x) || lasttransformposition.y != (int)Math.Round(npcpos.y))
                    {
                        if (debugtoconsolemsg == 1)
                        {
                            //Debug.Log("RESTART PATHFIND0");
                        }

                        startpathfind = 1;
                    }


                    //Debug.Log("RESTART PATHFIND0");
                    if (targetobjingridposposlast.x != tempttargetobjingridpospos.x || targetobjingridposposlast.y != tempttargetobjingridpospos.y)
                    {
                        if (debugtoconsolemsg == 1)
                        {
                            //Debug.Log("RESTART PATHFIND1");
                        }

                        startpathfind = 1;

                        //break;

                    }

                    //lasttransformposition = new sccsvec2int();
                    lasttransformposition.x = (int)Math.Round(npcpos.x);
                    lasttransformposition.y = (int)Math.Round(npcpos.y);

                    targetobjingridposposlast = tempttargetobjingridpospos;

                }*/

            }
            catch //(UnityException ex)
            {
                //Debug.Log(ex.ToString());
            }


            return sccspathfinddata;
        }









        //developped by steve chassé aka ninekorn. using as reference the GetNeighBours function and logic from sebastian lagues Episode 03 - astar tutorial on how to find neighboor tiles. Sebastian Lague was getting the position of the node. With playing around with voxels a lot, i had figured how to get the index out of the position or to make an index out of it. so i decided to add more logic inside of the GetNeighBours function.
        //developped by steve chassé aka ninekorn. using as reference the GetNeighBours function and logic from sebastian lagues Episode 03 - astar tutorial on how to find neighboor tiles. Sebastian Lague was getting the position of the node. With playing around with voxels a lot, i had figured how to get the index out of the position or to make an index out of it. so i decided to add more logic inside of the GetNeighBours function.
        private static sccspathfindcheckallsidesdata unwalkallsides(sccspathfindnode node, sccspathfindgridWorldSize gridWorldSize, sccsvec2int initialPos, sccspathfindgridworldindex nodegriddata, System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata)
        {
            var neighboors = new List<sccspathfindneighboortile>();
            var extraTiles = new List<sccspathfindneighboortile>(); //[]

            try
            {
                for (var x = -1; x <= 1; x++)
                {
                    for (var y = -1; y <= 1; y++)
                    {

                        /*if (x == 0 && y == 0)
                        {
                            continue;
                        }*/
                        int xpos = (int)Math.Round((double)(node.worldpositionx + x));
                        int ypos = (int)Math.Round((double)(node.worldpositiony + y));

                        var pos = new sccsvec2int { x = xpos, y = ypos };

                        var gridData = getNewGridIndex(initialPos, pos, gridWorldSize); //, cData.objt.sid
                        var indexOfGrid = gridData.index;

                        xpos = (int)Math.Round((double)(node.worldpositionx + x));
                        ypos = (int)Math.Round((double)(node.worldpositiony + y));

                        pos = new sccsvec2int { x = xpos, y = ypos };

                        if (node.gridtilex + x == 0 && node.gridtiley + y == 0 ||
                            node.gridtilex + x == -1 && node.gridtiley + y == 0 ||
                            node.gridtilex + x == -1 && node.gridtiley + y == -1 ||
                            node.gridtilex + x == 0 && node.gridtiley + y == -1)
                        {


                            var gridTileX = node.gridtilex + x;
                            var gridTileY = node.gridtiley + y;

                            if (gridTileX < 0)
                            {
                                gridTileX = (gridWorldSize.xR) + (gridTileX * -1);
                            }

                            if (gridTileY < 0)
                            {
                                gridTileY = (gridWorldSize.yT) + (gridTileY * -1);
                            }


                            var index = ((gridTileX) * (gridWorldSize.xL + gridWorldSize.xR + 1)) + (gridTileY);

                            //int index = gridTileX + (gridWorldSize.xL + gridWorldSize.xR + 1) * (gridTileY + (gridWorldSize.yB + gridWorldSize.yT + 1) * gridTileZ);




                            var emptygridvec = new sccsvec2int();
                            emptygridvec.x = 0;
                            emptygridvec.y = 0;

                            if (indexOfGrid > sccspathfinddata.sccspathfindcombineddatavar.log.Count - 1)
                            {
                                var diff0 = indexOfGrid - (sccspathfinddata.sccspathfindcombineddatavar.log.Count);

                                for (int g = 0; g < diff0 + 1; g++)
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                                }
                            }


                            if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid] == null)
                            {
                                sccspathfindgridworldindex gridworldlink = new sccspathfindgridworldindex();
                                gridworldlink.x = gridData.gridData.x;
                                gridworldlink.y = gridData.gridData.y;

                                gridworldlink.gridX = gridData.gridData.gridX;
                                gridworldlink.gridY = gridData.gridData.gridY;


                                var extratilepos = new sccsvec2int();
                                extratilepos.x = xpos;
                                extratilepos.y = ypos;

                                sccspathfinddata = startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData, -1, 1, extratilepos, listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 
                            }

                            /*neighboors.Add(
                             new sccspathfindneighboortile
                             {
                                 swtc = 0,
                                 node = sccspathfindcombineddatavar.log[gridData.index][index],
                                 sgp = emptygridvec,
                                 iot = index,
                                 iog = node.gridindex,
                                 walkable = 0
                             }
                              );*/


                            //sccspathfindcombineddatavar.log[indexOfGrid][index].walkable = 0;
                        }
                        else
                        {
                            gridData = getNewGridIndex(initialPos, pos, gridWorldSize); //, sccspathfindcombineddatavar.objt.sid

                            indexOfGrid = gridData.index;

                            var diffX = (int)Math.Round((double)Math.Abs(Math.Abs(pos.x) - Math.Abs(gridData.gridData.x)));
                            var diffY = (int)Math.Round((double)Math.Abs(Math.Abs(pos.y) - Math.Abs(gridData.gridData.y)));
                            //var diffZ = Mathf.RoundToInt(Math.Abs(Math.Abs(pos.z) - Math.Abs(gridData.gridData.z)));

                            var starterGriderPos = new sccsvec2int { x = gridData.gridData.x, y = gridData.gridData.y };

                            if (pos.x < starterGriderPos.x)
                            {
                                diffX = (gridWorldSize.xR) + diffX;
                            }
                            else if (pos.x > starterGriderPos.x)
                            {
                                diffX = diffX;
                            }
                            else
                            {
                                diffX = 0;
                            }

                            if (pos.y < starterGriderPos.y)
                            {
                                diffY = (gridWorldSize.yT) + diffY;
                            }
                            else if (pos.y > starterGriderPos.y)
                            {
                                diffY = diffY;
                            }
                            else
                            {
                                diffY = 0;
                            }



                            //int indexer = diffX + (gridWorldSize.xL + gridWorldSize.xR + 1) * (diffY + (gridWorldSize.yB + gridWorldSize.yT + 1) * diffZ);
                            var indexer = diffX * (gridWorldSize.xL + gridWorldSize.xR + 1) + diffY;

                            if (indexOfGrid > sccspathfinddata.sccspathfindcombineddatavar.log.Count - 1)
                            {
                                var diff0 = indexOfGrid - (sccspathfinddata.sccspathfindcombineddatavar.log.Count);

                                for (int g = 0; g < diff0 + 1; g++)
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                                }
                            }
                            sccspathfindgridworldindex gridworldlink = new sccspathfindgridworldindex();
                            gridworldlink.x = gridData.gridData.x;
                            gridworldlink.y = gridData.gridData.y;

                            gridworldlink.gridX = gridData.gridData.gridX;
                            gridworldlink.gridY = gridData.gridData.gridY;

                            if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid] == null)//gridData.index == gridData00.index)
                            {
                                var extratilepos = new sccsvec2int();
                                extratilepos.x = xpos;
                                extratilepos.y = ypos;

                                sccspathfinddata = startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData, -1, 1, extratilepos, listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 
                            }

                            var emptygridvec = new sccsvec2int();
                            emptygridvec.x = 0;
                            emptygridvec.y = 0;


                            //sccspathfindcombineddatavar.log[indexOfGrid][indexer].walkable = 0;
                            //neighboors.Add(new sccspathfindneighboortile { swtc = 0, node = sccspathfindcombineddatavar.log[indexOfGrid][indexer], sgp = emptygridvec, iot = indexer, iog = indexOfGrid, walkable = 0});
                        }

                    }
                }
            }
            catch //(UnityException ex)
            {
                //Debug.Log(ex.ToString());
            }

            return new sccspathfindcheckallsidesdata { neighboors = neighboors, extraTiles = extraTiles };
        }











        //developped by steve chassé aka ninekorn. using as reference the GetNeighBours function and logic from sebastian lagues Episode 03 - astar tutorial on how to find neighboor tiles. Sebastian Lague was getting the position of the node. With playing around with voxels a lot, i had figured how to get the index out of the position or to make an index out of it. so i decided to add more logic inside of the GetNeighBours function.
        //developped by steve chassé aka ninekorn. using as reference the GetNeighBours function and logic from sebastian lagues Episode 03 - astar tutorial on how to find neighboor tiles. Sebastian Lague was getting the position of the node. With playing around with voxels a lot, i had figured how to get the index out of the position or to make an index out of it. so i decided to add more logic inside of the GetNeighBours function.
        public static sccspathfinddata checkAllSidesGridIndex(sccspathfindnode node, sccspathfindgridWorldSize gridWorldSize, sccsvec2int initialPos, sccspathfindgridworldindex nodegriddata, System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata)
        {
            sccspathfinddata.neighboors = new List<sccspathfindneighboortile>();
            //sccspathfinddata.extraTiles = new List<sccspathfindneighboortile>();
            

            //var neighboors = new List<sccspathfindneighboortile>();
            //var extraTiles = new List<sccspathfindneighboortile>(); //[]

            try
            {
                for (var x = -1; x <= 1; x++)
                {
                    for (var y = -1; y <= 1; y++)
                    {

                        if (x == 0 && y == 0)
                        {
                            continue;
                        }
                        int xpos = (int)Math.Round((double)(node.worldpositionx + x));
                        int ypos = (int)Math.Round((double)(node.worldpositiony + y));

                        var pos = new sccsvec2int { x = xpos, y = ypos };

                        var gridData = getNewGridIndex(initialPos, pos, gridWorldSize); //, cData.objt.sid
                        var indexOfGrid = gridData.index;

                        xpos = (int)Math.Round((double)(node.worldpositionx + x));
                        ypos = (int)Math.Round((double)(node.worldpositiony + y));

                        pos = new sccsvec2int { x = xpos, y = ypos };

                        if (node.gridtilex + x == 0 && node.gridtiley + y == 0 ||
                            node.gridtilex + x == -1 && node.gridtiley + y == 0 ||
                            node.gridtilex + x == -1 && node.gridtiley + y == -1 ||
                            node.gridtilex + x == 0 && node.gridtiley + y == -1)
                        {


                            var gridTileX = node.gridtilex + x;
                            var gridTileY = node.gridtiley + y;

                            if (gridTileX < 0)
                            {
                                gridTileX = (gridWorldSize.xR) + (gridTileX * -1);
                            }

                            if (gridTileY < 0)
                            {
                                gridTileY = (gridWorldSize.yT) + (gridTileY * -1);
                            }


                            var index = ((gridTileX) * (gridWorldSize.xL + gridWorldSize.xR + 1)) + (gridTileY);

                            //int index = gridTileX + (gridWorldSize.xL + gridWorldSize.xR + 1) * (gridTileY + (gridWorldSize.yB + gridWorldSize.yT + 1) * gridTileZ);




                            var emptygridvec = new sccsvec2int();
                            emptygridvec.x = 0;
                            emptygridvec.y = 0;

                            if (indexOfGrid > sccspathfinddata.sccspathfindcombineddatavar.log.Count - 1)
                            {
                                var diff0 = indexOfGrid - (sccspathfinddata.sccspathfindcombineddatavar.log.Count);

                                for (int g = 0; g < diff0 + 1; g++)
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                                }
                            }


                            if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid] == null)
                            {
                                sccspathfindgridworldindex gridworldlink = new sccspathfindgridworldindex();
                                gridworldlink.x = gridData.gridData.x;
                                gridworldlink.y = gridData.gridData.y;

                                gridworldlink.gridX = gridData.gridData.gridX;
                                gridworldlink.gridY = gridData.gridData.gridY;


                                var extratilepos = new sccsvec2int();
                                extratilepos.x = xpos;
                                extratilepos.y = ypos;

                                sccspathfinddata = startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData, -1, 1, extratilepos, listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 
                            }

                            sccspathfinddata.neighboors.Add(
                             new sccspathfindneighboortile
                             {
                                 swtc = 0,
                                 node = sccspathfinddata.sccspathfindcombineddatavar.log[gridData.index][index],
                                 sgp = emptygridvec,
                                 iot = index,
                                 iog = node.gridindex,
                                 walkable = 1
                             }
                              );
                        }
                        else
                        {
                            gridData = getNewGridIndex(initialPos, pos, gridWorldSize); //, sccspathfindcombineddatavar.objt.sid

                            indexOfGrid = gridData.index;

                            var diffX = (int)Math.Round((double)Math.Abs(Math.Abs(pos.x) - Math.Abs(gridData.gridData.x)));
                            var diffY = (int)Math.Round((double)Math.Abs(Math.Abs(pos.y) - Math.Abs(gridData.gridData.y)));
                            //var diffZ = Mathf.RoundToInt(Math.Abs(Math.Abs(pos.z) - Math.Abs(gridData.gridData.z)));

                            var starterGriderPos = new sccsvec2int { x = gridData.gridData.x, y = gridData.gridData.y };

                            if (pos.x < starterGriderPos.x)
                            {
                                diffX = (gridWorldSize.xR) + diffX;
                            }
                            else if (pos.x > starterGriderPos.x)
                            {
                                diffX = diffX;
                            }
                            else
                            {
                                diffX = 0;
                            }

                            if (pos.y < starterGriderPos.y)
                            {
                                diffY = (gridWorldSize.yT) + diffY;
                            }
                            else if (pos.y > starterGriderPos.y)
                            {
                                diffY = diffY;
                            }
                            else
                            {
                                diffY = 0;
                            }



                            //int indexer = diffX + (gridWorldSize.xL + gridWorldSize.xR + 1) * (diffY + (gridWorldSize.yB + gridWorldSize.yT + 1) * diffZ);
                            var indexer = diffX * (gridWorldSize.xL + gridWorldSize.xR + 1) + diffY;

                            if (indexOfGrid > sccspathfinddata.sccspathfindcombineddatavar.log.Count - 1)
                            {
                                var diff0 = indexOfGrid - (sccspathfinddata.sccspathfindcombineddatavar.log.Count);

                                for (int g = 0; g < diff0 + 1; g++)
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log.Add(null);
                                }
                            }
                            sccspathfindgridworldindex gridworldlink = new sccspathfindgridworldindex();
                            gridworldlink.x = gridData.gridData.x;
                            gridworldlink.y = gridData.gridData.y;

                            gridworldlink.gridX = gridData.gridData.gridX;
                            gridworldlink.gridY = gridData.gridData.gridY;

                            if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid] == null)//gridData.index == gridData00.index)
                            {
                                var extratilepos = new sccsvec2int();
                                extratilepos.x = xpos;
                                extratilepos.y = ypos;

                                sccspathfinddata = startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData, -1, 1, extratilepos, listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 
                            }


                            if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid]!= null)
                            {
                                if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid][indexer].walkable == 2)
                                {
                                    //sccspathfindcombineddatavar.log[indexOfGrid][indexer].walkable = 0;
                                }
                                else
                                {
                                    sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid][indexer].walkable = 1;
                                }
                            }

                            var emptygridvec = new sccsvec2int();
                            emptygridvec.x = 0;
                            emptygridvec.y = 0;

                            sccspathfinddata.neighboors.Add(new sccspathfindneighboortile { swtc = 0, node = sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid][indexer], sgp = emptygridvec, iot = indexer, iog = indexOfGrid, walkable = sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid][indexer].walkable });
                        }

                    }
                }
            }
            catch //(UnityException ex)
            {
                //Debug.Log(ex.ToString());
            }

            //return new sccspathfindcheckallsidesdata { neighboors = neighboors, extraTiles = extraTiles };



            return sccspathfinddata;
        }
        private static sccspathfinddata RetracePath(sccsvec2int initialPos, sccsvec2int targetPos, sccspathfindnode node, int initpathfind, sccspathfinddata sccspathfinddata) //List<sccspathfindnode>
        {
            var currentX = targetPos.x;
            var currentY = targetPos.y;

            var startX = (initialPos.x);
            var startY = (initialPos.y);

            //int lastNodeGridIndex;


            //Debug.Log("/tx:" + targetPos.x + "/ty:" + targetPos.y + "/initx:" + initialPos.x + "/inity:" + initialPos.y);


            if (sccspathfinddata.mainSwitch == 1)
            {

                if (initpathfind == 0)
                {

                    /*sccsvec2int initposnewgrid0 = new sccsvec2int();
                    initposnewgrid0.x = node.worldpositionx;
                    initposnewgrid0.y = node.worldpositiony;

                    var gridData00 = getNewGridIndex(initialpathfindstartpos, initposnewgrid0, gridworldsize);

                    var neighboorandextratiles = checkAllSidesGridIndex(node, gridworldsize, initialpathfindstartpos, gridData00.gridData);//cData.lip //, gridData00.gridData

                    if (neighboorandextratiles)
                    {

                    }*/







                    sccspathfinddata.retracedpathlist.Push(node);

                    currentX = (node.worldpositionx);
                    currentY = (node.worldpositiony);

                    if (node.parentiot != -1)
                    {
                        var gridIndex = node.parentiog;
                        var nodeIndex = node.parentiot;

                        sccspathfinddata.currentNode = sccspathfinddata.sccspathfindcombineddatavar.log[gridIndex][nodeIndex];
                        node = sccspathfinddata.currentNode;
                    }
                    else
                    {
                        ////---////console.PrintError("node.parent is NULL");
                    }
                }
                else if (initpathfind == 1)
                {
                    sccspathfinddata.retracedpathlist.Push(node);

                    currentX = (node.worldpositionx);
                    currentY = (node.worldpositiony);

                    if (node.parentiot != -1)
                    {
                        var gridIndex = node.parentiog;
                        var nodeIndex = node.parentiot;

                        sccspathfinddata.currentNode = sccspathfinddata.sccspathfindcombineddatavar.log[gridIndex][nodeIndex];
                        node = sccspathfinddata.currentNode;
                        //lastnode = node;
                    }
                    else
                    {
                        ////---////console.PrintError("node.parent is NULL");
                    }
                }

                if (currentX == startX && currentY == startY)
                {
                    if (sccspathfinddata.debugtoconsolemsg == 1)
                    {
                        ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                        adminnotify.Execute(sccspathfinddata.theplayer, "current node is the initial node");
                    }

                    //Debug.Log("current node is the initial node");
                    sccspathfinddata.mainSwitch = 0;
                    sccspathfinddata.countingmaxretracepathswtc = 1;

                    //break;
                }

                if (sccspathfinddata.counting > sccspathfinddata.maxRetracePath) //1500 original
                {
                    if (sccspathfinddata.debugtoconsolemsg == 1)
                    {
                        ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                        adminnotify.Execute(sccspathfinddata.theplayer, "counting the path gives a total of 1500 total nodes before breaking. This value can be changed. ");
                    }

                    //console.PrintError("counting the path gives a total of 1500 total nodes before breaking. This value can be changed. ");
                    //Debug.Log("counting the path gives a total of 1500 total nodes before breaking. This value can be changed. ");

                    sccspathfinddata.mainSwitch = 2;
                    sccspathfinddata.countingmaxretracepathswtc = 1;

                    //break;
                }

                sccspathfinddata.counting++;
            }

            return sccspathfinddata;
        }


        public static sccspathfindgridworldindex getGridWorldPosition(sccsvec2int initialPos, sccsvec2int seekerPos, sccspathfindgridWorldSize gridWorldSize)  //yep still fail. yep. yeah... godamnit. ,int sid
        {
            int diffX = (int)Math.Round((double)Math.Abs(Math.Abs(seekerPos.x) - Math.Abs(initialPos.x)));
            int diffY = (int)Math.Round((double)Math.Abs(Math.Abs(seekerPos.y) - Math.Abs(initialPos.y)));

            int currentGridPosX = 0;
            int currentGridPosY = 0;
            float dividerDecimal = 0;

            if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 2)
            {

                dividerDecimal = 0.5f; //doesn't work yet as of 06th april 2021 - ninekorn => widthL = 1 and widthR = 0
            }
            else if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 5)
            {

                dividerDecimal = 0.2f;
            }
            else if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 10)
            {
                dividerDecimal = 0.1f;
            }
            else if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 20)
            {
                dividerDecimal = 0.05f;
            }
            else if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 8)
            {
                dividerDecimal = 0.125f;
            }
            else if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 6)
            {
                dividerDecimal = 0.16666666666666666666666666666667f;
            }
            else if ((gridWorldSize.xL + gridWorldSize.xR + 1) == 4)
            {
                dividerDecimal = 0.25f;
            }


            var totalRemainsDivX = (diffX * dividerDecimal);
            var flooredRemainsDivX = (int)Math.Floor(totalRemainsDivX);
            var lastRemainsDivX = totalRemainsDivX - flooredRemainsDivX;


            //3 - 1 - (1 * (3)) = 
            var testX00 = diffX - gridWorldSize.xL - (flooredRemainsDivX * (gridWorldSize.xL + gridWorldSize.xR + 1));
            var testX01 = diffX - gridWorldSize.xR - (flooredRemainsDivX * (gridWorldSize.xL + gridWorldSize.xR + 1));

            if (seekerPos.x < initialPos.x)
            {
                if (testX00 > 0)
                {
                    flooredRemainsDivX = flooredRemainsDivX + 1;
                }
                currentGridPosX = (int)Math.Round((double)(initialPos.x - ((gridWorldSize.xL + gridWorldSize.xR + 1) * flooredRemainsDivX)));
            }
            else if (seekerPos.x > initialPos.x)
            {
                if (testX01 > 0)
                {
                    flooredRemainsDivX = flooredRemainsDivX + 1;
                }
                currentGridPosX = (int)Math.Round((double)(initialPos.x + ((gridWorldSize.xL + gridWorldSize.xR + 1) * flooredRemainsDivX)));
            }
            else
            {
                currentGridPosX = (int)Math.Round((double)(initialPos.x));
            }

            var totalRemainsDivY = (diffY * dividerDecimal);
            var flooredRemainsDivY = (int)Math.Floor(totalRemainsDivY);
            var lastRemainsDivY = totalRemainsDivY - flooredRemainsDivY;

            var testY00 = diffY - gridWorldSize.yB - (flooredRemainsDivY * (gridWorldSize.xL + gridWorldSize.xR + 1));
            var testY01 = diffY - gridWorldSize.yT - (flooredRemainsDivY * (gridWorldSize.xL + gridWorldSize.xR + 1));

            if (seekerPos.y < initialPos.y)
            {
                if (testY00 > 0)
                {
                    flooredRemainsDivY = flooredRemainsDivY + 1;
                }
                currentGridPosY = (int)Math.Round((double)(initialPos.y - ((gridWorldSize.yB + gridWorldSize.yT + 1) * flooredRemainsDivY)));
            }
            else if (seekerPos.y > initialPos.y)
            {
                if (testY01 > 0)
                {
                    flooredRemainsDivY = flooredRemainsDivY + 1;
                }
                currentGridPosY = (int)Math.Round((double)(initialPos.y + ((gridWorldSize.yB + gridWorldSize.yT + 1) * flooredRemainsDivY)));
            }
            else
            {
                currentGridPosY = (int)Math.Round((double)initialPos.y);
            }

            return new sccspathfindgridworldindex { x = currentGridPosX, y = currentGridPosY, gridX = flooredRemainsDivX, gridY = flooredRemainsDivY }; // 
        }

        public static sccspathfindgriddatafinal getNewGridIndex(sccsvec2int initialPos, sccsvec2int seekerPos, sccspathfindgridWorldSize gridWorldSize) // , sid
        {
            var gridData = getGridWorldPosition(initialPos, seekerPos, gridWorldSize);// , sid

            var testX = 0;
            var testY = 0;
            var minY = 0;
            var maxY = 0;

            var minX = 0;
            var maxX = 0;

            var index = 0;

            if (gridData.x < initialPos.x)
            {
                testX = -gridData.gridX;
            }
            else
            {
                testX = gridData.gridX;
            }

            if (gridData.y < initialPos.y)
            {
                testY = -gridData.gridY;
            }
            else
            {
                testY = gridData.gridY;
            }

            var someAdder = 0;

            if (gridData.gridX >= gridData.gridY)
            {
                if (testX <= 0)
                {
                    minX = gridData.gridX; //2
                    maxX = gridData.gridX; //2

                    maxY = maxX; //2
                    minY = maxY - 1; //1


                    var currentContainedGrids = (minX + maxX) * (minY + maxY + 1); //2+2*2+1+1=4*4=16

                    if (testY >= 0) // REVISED
                    {
                        //index 3
                        someAdder = (minY + gridData.gridY + 1); //
                        var tot = minY + maxY + 1;
                        index = currentContainedGrids - (tot) + someAdder;
                    }
                    else // REVISED
                    {
                        //index 59
                        someAdder = (minY - gridData.gridY + 1); //3-1+1 = 3
                        var tot = minY + maxY + 1;
                        index = currentContainedGrids - (tot) + someAdder;
                    }
                }
                else
                {
                    minX = gridData.gridX; //3
                    maxX = gridData.gridX; //3

                    minY = minX; //3
                    maxY = maxX; //3

                    var currentContainedGrids = (minX + maxX + 1) * (minY + maxY); // 42

                    if (testY >= 0)
                    {
                        // index 7 
                        someAdder = (minY + gridData.gridY + 1);
                        var tot = minY + maxY + 1;
                        index = currentContainedGrids + (tot) - someAdder;
                    }
                    else
                    {
                        //index47
                        someAdder = (minY - gridData.gridY + 1); // 3-2+1 = 2
                        var tot = minY + maxY + 1;
                        index = currentContainedGrids + (tot) - someAdder; //42+7 = 49 - 2 = 47
                    }
                }
            }
            else if (gridData.gridX < gridData.gridY)
            {
                if (testY <= 0)
                {
                    minY = gridData.gridY;//4
                    maxY = gridData.gridY;//4

                    minX = minY; //4
                    maxX = minX - 1; //3

                    var currentContainedGrids = (minX + maxX) * (minY + maxY);//8*7 = 56

                    someAdder = 0;
                    if (testX >= 0)
                    {
                        //index 25  => totalGrids 
                        someAdder = (minX - gridData.gridX + 1); //3-2+1 = 2
                        var tot = minY + maxY + 1;
                        index = currentContainedGrids - (tot) + someAdder; //30-7 + 2 = 25
                    }
                    else
                    {
                        //index 28 =>
                        someAdder = (minX + gridData.gridX + 1); //3+1+1 = 5
                        var tot = minY + maxY + 1; // 3+3+1 = 7
                        index = currentContainedGrids - (tot) + someAdder; //30-7 = 23 + 5 = 28
                    }
                }
                else //if (testY > 0) 
                {
                    minY = gridData.gridY; // 3
                    maxY = gridData.gridY; // 3

                    minX = minY; // 3
                    maxX = maxY; // 3 

                    var currentContainedGrids = (minX + maxX) * (minY + maxY); // 36 total grids.... meaning index 35 is the biggest

                    someAdder = 0;
                    if (testX >= 0)
                    {
                        //index 41
                        someAdder = (minX + gridData.gridX); // 3+2
                        index = currentContainedGrids + someAdder; // 36+5 = 41
                    }
                    else
                    {
                        //index 38 
                        someAdder = (maxX - gridData.gridX); // 3-2
                        index = currentContainedGrids + someAdder;
                    }
                }
            }

            return new sccspathfindgriddatafinal { gridData = gridData, index = index };
        }


        //https://www.tutorialspoint.com/heap-sort-in-chash
        static void heapSort(List<sccspathfindnode> arr, int n, string typeOfSort)// int[] arr
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i, typeOfSort);
            for (int i = n - 1; i >= 0; i--)
            {
                sccspathfindnode temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0, typeOfSort);
            }
        }
        static void heapify(List<sccspathfindnode> arr, int n, int i, string typeOfSort) //int[] arr
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (typeOfSort == "fcost")
            {
                if (left < n && arr[left].fcost > arr[largest].fcost)
                {
                    largest = left;
                }
                if (right < n && arr[right].fcost > arr[largest].fcost)
                {
                    largest = right;
                }
            }
            else if (typeOfSort == "gcost")
            {
                if (left < n && arr[left].gcost > arr[largest].gcost)
                {
                    largest = left;
                }
                if (right < n && arr[right].gcost > arr[largest].gcost)
                {
                    largest = right;
                }
            }
            else if (typeOfSort == "hcost")
            {
                if (left < n && arr[left].hcost > arr[largest].hcost)
                {
                    largest = left;
                }
                if (right < n && arr[right].hcost > arr[largest].hcost)
                {
                    largest = right;
                }
            }

            if (largest != i)
            {
                sccspathfindnode swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest, typeOfSort);
            }
        }

    }
}





//EXTRAS FOR 3D PATHFIND LATER.
/*

//steve chassé note 2021-jan-21
//it's still a shitty way of doing it. sebastian lague probably doesn't show us all what he can do anyway and the same goes for craig perko and holistic3d and the atomic torch studios even... My whole program, i am trying to make it work for massive instancing of objects in
//one scene and even different jitter scenes if i can bring the simple JitterDemo Scene instancing inside of this custom C# engine. But learning from those youtuber teachers was the best experience i could've gotten and not having a sebastian lague 3d pathfinding, i had to
//start with my own strategy. To learn how to do it in 2d in Void Expanse first as the ninekorn modder. So i incorporated what i learned from sebastian lagues tutorial in Unity3d with his old pathfinding tutorial series and i had to understand how to make a per frame 
//pathfinding solution for javascript ecma5 of void expanse. But then, trying to make covid19 objects to proove i can do close to something that can look like that, i mean someone might like a voxel cubic artist also. Sebastian Lague has the marching cubes and marching
//squares superioty and i think craig perko and holistic3d can also use marching cubes and marching squares but i still don't want to yet. I am not done with cubic voxels. I am barely trying.

//and i am trying to 
//MODIFIED 2D TO 3D VERSION OF SEBASTIEN LAGUE WITH SOME MODS SIMPLY FOR VISUALLY BEING ABLE TO MODIFY TO ELLIPSOID AND OTHER GEOMETRY FORMS - it kinda works but ive got a hard time getting a perfect sphere. im not a mathematician
//and i am a lazy programmer.
public static float sc_check_distance_node_3d_geometry(Vector3 nodeA, Vector3 nodeB, float minx, float miny, float minz, float maxx, float maxy, float maxz) // i was thinking about using the index instead and then was like well i need the distance man.
{
    //var pointFrontX = (1 * Math.cos(radToDeg * Math.PI / 180));
    //var pointFrontY = (1 * Math.sin(radToDeg * Math.PI / 180));

    //SEBASTIEN LAGUE 2D BLUEPRINT FOR NODE DIAGONAL OR NOT DISTANCE.
    //var dstX = Math.Abs((nodeA.X) - (nodeB.X));
    //var dstZ = Math.Abs((nodeA.Y) - (nodeB.Y));

    //if (dstX > dstZ)
    //{
    //    return 14 * dstZ + 10 * (dstX - dstZ);
    //}
    //return 14 * dstX + 10 * (dstZ - dstX);

    var dstX = Math.Abs((nodeA.x) - (nodeB.x));
    var dstY = Math.Abs((nodeA.y) - (nodeB.y));
    var dstZ = Math.Abs((nodeA.z) - (nodeB.z));

    float dstX_vs_dstZ = 0;
    float dstX_vs_dstY = 0;
    float dstY_vs_dstZ = 0;

    if (dstX > dstZ)
    {
        dstX_vs_dstZ = maxx * dstZ + minx * (dstX - dstZ);
    }
    else
    {
        dstX_vs_dstZ = maxx * dstX + minx * (dstZ - dstX);
    }

    if (dstX > dstY)
    {
        dstX_vs_dstY = maxy * dstY + miny * (dstX - dstY);
    }
    else
    {
        dstX_vs_dstY = maxy * dstX + miny * (dstY - dstX);
    }

    if (dstY > dstZ)
    {
        dstY_vs_dstZ = maxz * dstZ + minz * (dstY - dstZ);
    }
    else
    {
        dstY_vs_dstZ = maxz * dstY + minz * (dstZ - dstY);
    }

    return dstX_vs_dstY + dstX_vs_dstZ + dstY_vs_dstZ;
}



//MODIFIED 2D TO 3D VERSION OF SEBASTIEN LAGUE WITH SOME MODS SIMPLY FOR VISUALLY BEING ABLE TO MODIFY TO ELLIPSOID AND OTHER GEOMETRY FORMS - it kinda works but ive got a hard time getting a perfect sphere. im not a mathematician
//and i am a lazy programmer.
public static float sc_check_distance_node_3d(Vector3 nodeA, Vector3 nodeB, float minx, float miny, float minz, float diagmaxx, float diagmaxy, float diagmaxz, float diagminx, float diagminy, float diagminz) // i was thinking about using the index instead and then was like well i need the distance man.
{
    //var pointFrontX = (1 * cos(radToDeg * Math.PI / 180));
    //var pointFrontY = (1 * sin(radToDeg * Math.PI / 180));

    //steve chassé's notes: 2021-jan-21
    //SEBASTIEN LAGUE 2D BLUEPRINT FOR NODE DIAGONAL. It works in void expanse too. i am so jealous of those youtubers and how good their tutorials are on youtube and i am barely even to make a decent one. i am barely even able to remove what can be portrayed as 
    //despicable comments in my scripts but that is just my inner anger of not being able to have a 3d blueprint of how to do the same thing. But i think i was able to solve the problem for my planet chunk script. it's really cool but it still lags.
    //var pointFrontX = (1 * Math.cos(radToDeg * Math.PI / 180));
    //var pointFrontY = (1 * Math.sin(radToDeg * Math.PI / 180));

    //SEBASTIEN LAGUE 2D BLUEPRINT FOR NODE DIAGONAL OR NOT DISTANCE.
    //var dstX = Math.Abs((nodeA.X) - (nodeB.X));
    //var dstZ = Math.Abs((nodeA.Y) - (nodeB.Y));

    //if (dstX > dstZ)
    //{
    //    return 14 * dstZ + 10 * (dstX - dstZ);
    //}
    //return 14 * dstX + 10 * (dstZ - dstX);

    var dstX = Math.Abs((nodeA.x) - (nodeB.x));
    var dstY = Math.Abs((nodeA.y) - (nodeB.y));
    var dstZ = Math.Abs((nodeA.z) - (nodeB.z));

    float dstX_vs_dstZ = 0;
    float dstX_vs_dstY = 0;
    float dstY_vs_dstZ = 0;

    if (dstX > dstZ)
    {
        dstX_vs_dstZ = diagmaxx * dstZ + minx * (dstX - dstZ);
    }
    else
    {
        dstX_vs_dstZ = diagminx * dstX + minx * (dstZ - dstX);
    }

    if (dstX > dstY)
    {
        dstX_vs_dstY = diagmaxy * dstY + miny * (dstX - dstY);
    }
    else
    {
        dstX_vs_dstY = diagminy * dstX + miny * (dstY - dstX);
    }

    if (dstY > dstZ)
    {
        dstY_vs_dstZ = diagmaxz * dstZ + minz * (dstY - dstZ);
    }
    else
    {
        dstY_vs_dstZ = diagminz * dstY + minz * (dstZ - dstY);
    }

    return dstX_vs_dstY + dstX_vs_dstZ + dstY_vs_dstZ;
}

public static float trying_ellipsoid_with_sc_sebastian_lague_check_distanceconvertedto3dkinda(Vector3 nodeA, Vector3 nodeB)
{
    //SEBASTIEN LAGUE 2D BLUEPRINT FOR NODE DIAGONAL OR NOT DISTANCE.
    //var dstX = Math.Abs((nodeA.X) - (nodeB.X));
    //var dstZ = Math.Abs((nodeA.Y) - (nodeB.Y));

    //if (dstX > dstZ)
    //{
    //    return 14 * dstZ + 10 * (dstX - dstZ);
    //}
    //return 14 * dstX + 10 * (dstZ - dstX);


    var dstX = Math.Abs((nodeA.x) - (nodeB.x));
    var dstY = Math.Abs((nodeA.y) - (nodeB.y));
    var dstZ = Math.Abs((nodeA.z) - (nodeB.z));

    float dstX_vs_dstZ = 0;
    float dstX_vs_dstY = 0;

    if (dstX > dstZ)
    {
        dstX_vs_dstZ = 14 * dstZ + 10 * (dstX - dstZ);
    }
    else
    {
        dstX_vs_dstZ = 14 * dstX + 10 * (dstZ - dstX);
    }

    if (dstX > dstY)
    {
        dstX_vs_dstY = 14 * dstY + 10 * (dstX - dstY);
    }
    else
    {
        dstX_vs_dstY = 14 * dstX + 10 * (dstY - dstX);
    }

    return dstX_vs_dstY + dstX_vs_dstZ;
}

public static float checknodedistancefloat(sccsvec2int nodea, sccsvec2int nodeb)
{
    var dstX = Math.Abs((nodea.x) - (nodeb.x));
    var dstZ = Math.Abs((nodea.y) - (nodeb.y));

    if (dstX > dstZ)
        return 14 * dstZ + 10 * (dstX - dstZ);
    return 14 * dstX + 10 * (dstZ - dstX);
}*/














/*
private static int CompareNodesByFcost(sccspathfindnode x, sccspathfindnode y)
{
    if (x.nodeinitswtc == 0)
    {
        if (y.nodeinitswtc == 0)
        {
            // If x is null and y is null, they're
            // equal.
            return 0;
        }
        else
        {
            // If x is null and y is not null, y
            // is greater.
            return -1;
        }
    }
    else
    {
        // If x is not null...
        //
        if (y.nodeinitswtc == 0)
        // ...and y is null, x is greater.
        {
            return 1;
        }
        else
        {
            // ...and y is not null, compare the
            // lengths of the two strings.
            //
            int retval = x.fcost.CompareTo(y.fcost);

            if (retval != 0)
            {
                // If the strings are not of equal length,
                // the longer string is greater.
                //
                return retval;
            }
            else
            {
                // If the strings are of equal length,
                // sort them with ordinary string comparison.
                //
                return x.fcost.CompareTo(y);
            }
        }
    }
}*/










/*
var gridData = new sccspathfindgridworldindex();

int diffX = (Math.Abs(Math.Abs(seekerPos.x) - Math.Abs(initialPos.x)));
int diffY = (Math.Abs(Math.Abs(seekerPos.y) - Math.Abs(initialPos.y)));

//let's say we are at position 3x0y so grid 1x0y

int sizeofgridx = (gridWorldSize.xL + gridWorldSize.xR + 1);
int sizeofgridy = (gridWorldSize.yB + gridWorldSize.yT + 1);

//i don't like the divisions.
int thegridx = (int)Math.Floor(diffX * 0.5f); //sizeofgridx
int thegridy = (int)Math.Floor(diffY * 0.5f); //sizeofgridx
*/

//  or a big grid of 5x5

//  72|73|74 |75|76|77 |78|79|80
//  71|42|43 |44|45|46 |47|48|49
//  70|41|20 |21|22|23 |24|25|50
//                                  →→→→→ 
//  69|40|19 |06|07|08 |09|26|51    ↑→→→↓
//  68|39|18 |05|00|01 |10|27|52    ↑↑→↓↓  
//  67|38|17 |04|03|02 |11|28|53    ↑↑←←↓ 
//                                  ↑←←←←          
//  66|37|16 |15|14|13 |12|29|54    
//  65|36|35 |34|33|32 |31|30|55
//  64|63|62 |61|60|59 |58|57|56  

//                                    |168?
//                                |120
//  108|72|73|74|75|76|77|78|79|80|81
//  107|71|42|43|44|45|46|47|48|49|82
//  106|70|41|20|21|22|23|24|25|50|83
//  105|69|40|19|06|07|08|09|26|51|84
//  104|68|39|18|05|00|01|10|27|52|85
//  103|67|38|17|04|03|02|11|28|53|86
//  102|66|37|16|15|14|13|12|29|54|87
//  101|65|36|35|34|33|32|31|30|55|88
//  100|64|63|62|61|60|59|58|57|56|89
//   99|98|97|96|95|94|93|92|91|90|89


//                                             |168?
//  110|111|112|113|114|115|116|117|118|119|120|121
//  109| 72| 73| 74| 75| 76| 77| 78| 79| 80| 81|122
//  108| 71| 42| 43| 44| 45| 46| 47| 48| 49| 82|123
//  107| 70| 41| 20| 21| 22| 23| 24| 25| 50| 83|124
//  106| 69| 40| 19| 06| 07| xx| 09| 26| 51| 84|125 <= 08
//  105| 68| 39| 18| 05| 00| 01| 10| 27| 52| 85|126 
//  104| 67| 38| 17| 04| 03| 02| 11| 28| 53| 86|127
//  103| 66| 37| 16| 15| 14| 13| 12| 29| 54| 87|128
//  102| 65| 36| 35| 34| 33| 32| 31| 30| 55| 88|129
//  101| 64| 63| 62| 61| 60| 59| 58| 57| 56| 89|130
//  100| 99| 98| 97| 96| 95| 94| 93| 92| 91| 90|131
//  143|142|141|140|139|138|137|136|135|134|133|132

//8/16/24/32/
//8/8/8/8

// test 1*8 = 8

//gridx = 1, gridy = 0 
//diffX == 3 diffy == 0 // 

// (x * width) + y
// (y * height) + x

//8*3 = 32

//  |06|07|08|
//  |05|00|01|
//  |04|03|02|


//-----------------------
//  |06  |07|  08|

//  |05  |00|  01|

//  |04  |03|  02|
//-----------------------

//-----------------------
//  |06  |07|  08|

//  |05  |00|  x(8 * diffX) + (gridsizexl + gridsizexr + 1),y0 |

//  |04  |03|  x(8 * diffX) + (gridsizexl + gridsizexr + 1),y (8 * diffY) + (gridsizeyb + gridsizeyt + 1)|
//-----------------------

/*int sizex = 1;//(gridWorldSize.xL + gridWorldSize.xR + 1);
int sizey = 1;// (gridWorldSize.yB + gridWorldSize.yT + 1);

int finalindex = 0;

if (thegridx == 0)
{
    sizex = 0;
}
if (thegridy == 0)
{
    sizey = 0;
}


if (thegridx == 0 && thegridy == 0)
{
    sizex = 1;
    sizey = 1;

    finalindex = 0;
}
else
{
    sizex = 1;
    sizey = 1;
    //sizex = (gridWorldSize.xL + gridWorldSize.xR+1);
    //sizey = (gridWorldSize.yB + gridWorldSize.yT+1);

    if (thegridx == 0 && thegridy == 0)
    {
        finalindex = 0;
    }
    else if (thegridx > 0 && thegridy == 0)
    {







        //                                             |168?
        //  110|111|112|113|114|115|116|117|118|119|120|121
        //  109| 72| 73| 74| 75| 76| 77| 78| 79| 80| 81|122
        //  108| 71| 42| 43| 44| 45| 46| 47| 48| 49| 82|123
        //  107| 70| 41| 20| 21| 22| 23| 24| 25| 50| 83|124
        //  106| 69| 40| 19| 06| 07| 08| 09| 26| 51| 84|125
        //  105| 68| 39| 18| 05| 00| 01| 10| 27| 52| 85|126 
        //  104| 67| 38| 17| 04| 03| 02| 11| 28| 53| 86|127
        //  103| 66| 37| 16| 15| 14| 13| 12| 29| 54| 87|128
        //  102| 65| 36| 35| 34| 33| 32| 31| 30| 55| 88|129
        //  101| 64| 63| 62| 61| 60| 59| 58| 57| 56| 89|130
        //  100| 99| 98| 97| 96| 95| 94| 93| 92| 91| 90|131
        //  143|142|141|140|139|138|137|136|135|134|133|132

        //8/16/24/32/
        //8/8/8/8

        //gridx = 1, gridy = 0 
        //diffX == 3 diffy == 0

        // gridx == 2
        // gridx * 8 = 16;
        // current max index = 16
        // 


        //finalindex = (8 * diffX);

        //DIAGONAL UPRIGHT
        //00/08/24/48/80/120/168
        //0/1/3/6/10/15/21? //multiple of 
        //0/1/2/3/4/5/6? //row x
        //0+0/0+1/1+2/3+3/6+4/10+5/15+6/

        //UP
        //00/07/22/45/76/115
        //0/1/3/6/10/15/21
}*/





//i use grids where the starting point is the middle of the grids, so we have to use negative and positive digits. i better understood during development how to fetch the index
//of a list (array of objects in javascript ecmascript5) when pushing the value inside of the list. How i visualized it is as if each additional items in the list, is a node that
//adds up to 0 in a spiral:      

//-----------------------------------------------------------------------------------------------------------

//  a grid of 3x3y visualized on how the count/length of the list increases when i add a new item and we visualize it in spiral.
//  |06|07|08|  //>>> //→→→ //different unicode for the arrows characters causes visual studio 2022 to popup a different script encoding. applied to all scripts.
//  |05|00|01|  //^>v //↑→↓
//  |04|03|02|  //^<< //↑←←

//  the grid positions are for a small grid
//  |-01, 01|00, 01|01, 01|
//  |-01, 00|00, 00|01, 00|
//  |-01,-01|00,-01|01,-01|

//  the position between 0 to 8 in a negative loop 3x3y that have to be set as grid left -1 to grid right 1
// total values is looping the x and y. (var index = xx * (gridxl + gridxr + 1) + yy;) vs the the flat index of the nodes negatives vs the flat index positive.

//  how the loop loops x then y         negative/positive indexes       positive indexes only
//      | 06| 07| 08|                   | 02| 03| 04|                   | 05| 03| 04| 
//      | 03| 04| 05|                   |-01| 00| 01|                   | 02| 00| 01| 
//      | 00| 01| 02|                   |-04|-03|-02|                   | 08| 06| 07| 
//                                                      
//-----------------------------------------------------------------------------------------------------------

//  or a big grid of 5x5
//  |20|21|22|23|24|    →→→→→ 
//  |19|06|07|08|09|    ↑→→→↓
//  |18|05|00|01|10|    ↑↑→↓↓  
//  |17|04|03|02|11|    ↑↑←←↓ 
//  |16|15|14|13|12|    ↑←←←←

//  the grid positions for a big grid
//  |-02, 02|-01, 02|00, 02|01, 02|02, 02|
//  |-02, 01|-01, 01|00, 01|01, 01|02, 01|
//  |-02, 00|-01, 00|00, 00|01, 00|02, 00|
//  |-02,-01|-01,-01|00,-01|01,-01|02,-01|
//  |-02,-02|-01,-02|00,-02|01,-02|02,-02|

// the flat index of the nodes vs the position between 0 to 8 in a negative loop in a grid of 5x5y that have to be set as grid left -2 to grid right 2
// total values is looping the x and y. var index = xx * (gridxl + gridxr + 1) + yy; <= to get the index

//  | 20| 21| 22| 23| 24|       |  08|  09|  10|  11|  12|        | 14| 13| 10| 11| 12|
//  | 15| 16| 17| 18| 19|       |  03|  04|  05|  06|  07|        | 09| 08| 05| 06| 07|
//  | 10| 11| 12| 13| 14|       | -02| -01|  00|  01|  02|        | 04| 03| 00| 01| 02|
//  | 05| 06| 07| 08| 09|       | -07| -06| -05| -04| -03|        | 19| 18| 15| 16| 17|
//  | 00| 01| 02| 03| 04|       | -12| -11| -10| -09| -08|        | 24| 23| 20| 21| 22|

//-----------------------------------------------------------------------------------------------------------

//to use the index x and y, we cannot use negative integers, so we have to make an array of the proper size, and then we can multiply by -1 the value and add the right
//size of the array to get the positive index; as long as we always use the same way to fetch the indexes, the indexes won't change.


//when reaching the end of a grid and finding null nodes, instead, i am assigning values to the nodes and adding them in the extratiles if the grid where
//those tiles are isn't built yet.

//discovered grid       undiscovered grid
//678                   678
//501                   501  
//432                   432

//let's say we are checking the neighboors for the tile #1 of the discovered grid, this is going to output the tiles 6/5/4 of the adjacent grid which is 
//undiscovered so it is null, hence the tiles wouldn't exist, but instead i add the position to a new list extra tiles and deal with them separately.

//678       8 678
//501      01 501
//432       2 432


//  or a big grid of 5x5
//  |20|21|22|23|24|    →→→→→ 
//  |19|06|07|08|09|    ↑→→→↓
//  |18|05|00|01|10|    ↑↑→↓↓  
//  |17|04|03|02|11|    ↑↑←←↓ 
//  |16|15|14|13|12|    ↑←←←←
























/*
if (posofnpc.x == posoftile2d.x && posofnpc.y == posoftile2d.y)
{
    //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
    //adminnotify.Execute(theplayer, "tileiswalkable: 0" + "/px: " + posofplayer.x + "/py: " + posofplayer.y + "/tx: " + centerpositionofrotation.x + "/ty: " + centerpositionofrotation.y);

    thecurrentnode.walkable = 1;
}
else
{
    if (centerpositionofrotation.x == posoftile2d.x && centerpositionofrotation.y == posoftile2d.y)
    {
        if (posofplayer.x == centerpositionofrotation.x && posofplayer.y == centerpositionofrotation.y)
        {
            thecurrentnode.walkable = 1;
        }
        else
        {
            thecurrentnode.walkable = 0;



            var neighboorandextratiles = unwalkallsides(thecurrentnode, gridworldsize, initialpathfindstartpos, gridinfo.gridData, listofobstacles);//cData.lip //, gridData00.gridData


            if (neighboorandextratiles.neighboors.Count > 0)
            {
                for (var j = 0; j < neighboorandextratiles.neighboors.Count; j++)
                {
                    if (sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].closed == 1 ||
                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].walkable == 0)
                    {
                        continue;
                    }


                    sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].walkable = (byte)neighboorandextratiles.neighboors[j].walkable;


                    var pos0 = new sccsvec2int();
                    pos0.x = theseekernode.worldpositionx;
                    pos0.y = theseekernode.worldpositiony;

                    var pos1 = new sccsvec2int();
                    pos1.x = neighboorandextratiles.neighboors[j].node.worldpositionx;
                    pos1.y = neighboorandextratiles.neighboors[j].node.worldpositiony;



                    //var toinitcost0 = theseekernode.toinitcost + checknodedistanceint(initialpathfindstartpos, pos1);

                    var gcost0 = theseekernode.gcost + checknodedistanceint(pos0, pos1);

                    if (gcost0 < neighboorandextratiles.neighboors[j].node.gcost || sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open == 0) // || sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open == 0
                    {
                        var neighboortile = neighboorandextratiles.neighboors[j];
                        neighboortile.node.gcost = gcost0;
                        neighboortile.node.hcost = checknodedistanceint(pos1, targetobjingridpos);
                        neighboortile.node.fcost = neighboortile.node.gcost + neighboortile.node.hcost;

                        neighboortile.node.toinitcost = toinitcost;



                        neighboorandextratiles.neighboors[j] = neighboortile;

                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].gcost = neighboortile.node.gcost;
                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].hcost = neighboortile.node.hcost;
                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].fcost = neighboortile.node.fcost;

                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].parentiog = theseekernode.gridindex;
                        sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].parentiot = theseekernode.index;

                        /*sccspathfindcombineddatavar.finalset.Add(sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index]);

                        if (sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open == 0)
                        {
                            sccspathfindcombineddatavar.openset.Add(neighboorandextratiles.neighboors[j].node);

                            sccspathfindcombineddatavar.log[neighboorandextratiles.neighboors[j].node.gridindex][neighboorandextratiles.neighboors[j].node.index].open = 1;

                        }
                    }
                }
            }
            else
            {

            }
        }



    }*/




//unwalkallsides(thecurrentnode, grud);








/*
for (var nx = -1; nx <= 1; nx++)
{
    for (var ny = -1; ny <= 1; ny++)
    {

       var xxx = x + nx;
       var yyy = y + ny;

        if (xxx < 0)
        {
            xxx *= -1;
            xxx = (gridxr) + xxx;
        }

        if (yyy < 0)
        {
            yyy *= -1;
            yyy = (gridyt) + yyy;
        }


        //gridinfo = getNewGridIndex(initialpositioningrid, currentnode, gridworldsize);


        var indexx = xxx * (gridxl + gridxr + 1) + yyy; //y * height + x 



        centerpositionofrotation.x += nx;
        centerpositionofrotation.y += ny;


        //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
        //adminnotify.Execute(theplayer, "sccspathfind unwalkabletile: 1" + "startpathfind:" + startpathfind + "/id:" + theplayer.Id);

        //thecurrentnode.walkable = 1;

       /*if (centerpositionofrotation.x == posoftile2d.x && centerpositionofrotation.y == posoftile2d.y)
        {
            if (debugtoconsolemsg == 1)
            {
                ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
                adminnotify.Execute(theplayer, "tileiswalkable: 0" + "/npcx: " + posofnpc.x + "/npcy: " + posofnpc.y + "/px: " + posofplayer.x + "/py: " + posofplayer.y + "/tx: " + centerpositionofrotation.x + "/ty: " + centerpositionofrotation.y);
            }

            if (posofplayer.x == centerpositionofrotation.x && posofplayer.y == centerpositionofrotation.y)
            {
                thecurrentnode.walkable = 1;
            }
            else
            {
                thecurrentnode.walkable = 0;
            }

        }
        else
        {
            //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
            //adminnotify.Execute(theplayer, "sccspathfind unwalkabletile: 1" + "startpathfind:" + startpathfind + "/id:" + theplayer.Id);

            thecurrentnode.walkable = 1;
        }
    }
}
}*/