using System.Linq;
using sccspathfindnode = sccspathfindstructs.sccspathfindnode;
using sccspathfindgriddatafinal = sccspathfindstructs.sccspathfindgriddatafinal;
using sccspathfindgridworldindex = sccspathfindstructs.sccspathfindgridworldindex;
using sccsvec2int = sccspathfindstructs.sccsvec2int;
using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
using sccspathfinddata = sccspathfindstructs.sccspathfinddata;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindcreategrid
    {

        public static sccspathfinddata startcreategrid(sccspathfindnode thegridlinknode, sccsvec2int initialpositioningrid, sccsvec2int targetobjingridpos, sccspathfindgridworldindex sccspathfindgridworldindex, out sccspathfindgriddatafinal gridinfo, int pathfinditeration, int alternateoption, sccsvec2int newgridlinkposition, System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata) //sccspathfindnode thegridlinknode //sccsvec2int seekerpositioningrid, //, sccsvec2int gridlastinitpos
        {
            gridinfo = new sccspathfindgriddatafinal();

            sccspathfindnode[] thegrid = new sccspathfindnode[(sccspathfinddata.gridxl + sccspathfinddata.gridxr + 1) * (sccspathfinddata.gridyb + sccspathfinddata.gridyt + 1)];

            sccsvec2int gridlastinitpos = new sccsvec2int();
            gridlastinitpos.x = sccspathfindgridworldindex.x;//thegridlinknode.gridposx;
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

                    gridinfo = sccspathfindgridutility.getNewGridIndex(initialpositioningrid, currentnode, sccspathfinddata.gridworldsize);
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
    }
}
