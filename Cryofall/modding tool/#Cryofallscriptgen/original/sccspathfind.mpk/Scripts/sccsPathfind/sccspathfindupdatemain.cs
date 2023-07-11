//DEVELOPPED BY STEVE CHASSÉ AKA NINEKORN AKA NINE AKA 9 dob13may1983. 2023 JUNE 06TH REVISION

using System;
using System.Collections.Generic;
using sccspathfindnode = sccspathfindstructs.sccspathfindnode;
using sccsvec2int = sccspathfindstructs.sccsvec2int;
using sccsvec2float = sccspathfindstructs.sccsvec2float;
using AtomicTorch.CBND.GameApi.Data.Characters;
using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
using sccspathfinddata = sccspathfindstructs.sccspathfinddata;
using AtomicTorch.CBND.CoreMod.Characters.sccsPathfind;
using static sccspathfindstructs;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindupdatemain
    {

        public static sccspathfinddata pathfindupdatemainfunction(sccsvec2float npcpos, sccsvec2float targetpos, System.Collections.Generic.List<sccspathfindobstaclestruct> listofobstacles, ICharacter npccharacter_, ICharacter playercharacter_, sccspathfinddata pathfindscript)
        {
            if (pathfindscript.startpathfind == 1)
            {
                pathfindscript.thenpc = npccharacter_;
                pathfindscript.theplayer = playercharacter_;


                pathfindscript.gridworldsize.xL = pathfindscript.gridxl;
                pathfindscript.gridworldsize.xR = pathfindscript.gridxr;
                pathfindscript.gridworldsize.yB = pathfindscript.gridyb;
                pathfindscript.gridworldsize.yT = pathfindscript.gridyt;

                sccsvec2int npcinitposofpathfindzerozero = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                npcinitposofpathfindzerozero.x = 0;
                npcinitposofpathfindzerozero.y = 0;

                pathfindscript.initialpathfindstartpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                pathfindscript.initialpathfindstartpos.x = npcinitposofpathfindzerozero.x;// + (int)this.transform.position.x;
                pathfindscript.initialpathfindstartpos.y = npcinitposofpathfindzerozero.y;//+ (int)this.transform.position.y;

                int targetlocationwithdiffxremoved = (int)targetpos.x - (int)npcpos.x;//(int)targetobj.transform.position.x -this.transform.position.x;
                int targetlocationwithdiffyremoved = (int)targetpos.y - (int)npcpos.y;// (int)targetobj.transform.position.y -this.transform.position.y;

                pathfindscript.initialpathfindnpcpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                pathfindscript.initialpathfindnpcpos.x = (int)Math.Round((double)npcpos.x);
                pathfindscript.initialpathfindnpcpos.y = (int)Math.Round((double)npcpos.y);

                pathfindscript.targetobjingridpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                pathfindscript.targetobjingridpos.x = targetlocationwithdiffxremoved;
                pathfindscript.targetobjingridpos.y = targetlocationwithdiffyremoved;

                pathfindscript.theseekernode.x = pathfindscript.initialpathfindstartpos.x;
                pathfindscript.theseekernode.y = pathfindscript.initialpathfindstartpos.y;
                pathfindscript.theseekernode.index = 0;
                pathfindscript.theseekernode.gridtilex = 0;
                pathfindscript.theseekernode.gridtiley = 0;
                pathfindscript.theseekernode.walkable = 1;
                pathfindscript.theseekernode.worldpositionx = 0;
                pathfindscript.theseekernode.worldpositiony = 0;

                sccsvec2int finaltargetpos = sccspools.getpooledsccsvec2int();//new sccsvec2int();
                finaltargetpos.x = (int)targetpos.x; //+(int)this.transform.position.x
                finaltargetpos.y = (int)targetpos.y; //+(int)this.transform.position.y

                /*if (debugtoconsolemsg == 1)
                {
                    ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
                    //Debug.Log("/finaltargetposx" + finaltargetpos.x + "/finaltargetposy:" + finaltargetpos.y);
                    adminnotify.Execute(theplayer, "/finaltargetposx" + finaltargetpos.x + "/finaltargetposy:" + finaltargetpos.y);
                }*/


                if (pathfindscript.sccspathfindcombineddatavar.openset == null)
                {
                    pathfindscript.sccspathfindcombineddatavar.openset = sccspools.getpooledsccspathfindnodelist();// new List<sccspathfindnode>();
                }
                else
                {
                    pathfindscript.sccspathfindcombineddatavar.openset.Clear();
                }

                if (pathfindscript.sccspathfindcombineddatavar.closedset == null)
                {
                    pathfindscript.sccspathfindcombineddatavar.closedset = sccspools.getpooledsccspathfindnodelist();// new List<sccspathfindnode>();
                }
                else
                {
                    pathfindscript.sccspathfindcombineddatavar.closedset.Clear();
                }

                /*if (pathfindscript.sccspathfindcombineddatavar.finalset == null)
                {
                    pathfindscript.sccspathfindcombineddatavar.finalset = new List<sccspathfindnode>();//sccspools.getpooledsccspathfindnodelist();// new List<sccspathfindnode>();
                }
                else
                {
                    pathfindscript.sccspathfindcombineddatavar.finalset.Clear();
                }*/


                if (pathfindscript.sccspathfindcombineddatavar.log == null)
                {
              
                    pathfindscript.sccspathfindcombineddatavar.log = sccspools.getpooledsccspathfindnodelistarray();// new List<sccspathfindnode[]>();
                }
                else
                {
                    pathfindscript.sccspathfindcombineddatavar.log.Clear();
                }
                /*
                if (pathfindscript.sccspathfindcombineddatavar.betterroutechecklist == null)
                {
                    pathfindscript.sccspathfindcombineddatavar.betterroutechecklist = new List<sccspathfindnode>();
                }
                else
                {
                    pathfindscript.sccspathfindcombineddatavar.betterroutechecklist.Clear();
                }*/

                if (pathfindscript.retracedpathlist == null)
                {
                    //pathfindscript.retracedpathlist = new Stack<sccspathfindnode>();
                    //pathfindscript.retracedpathlist = new List<sccspathfindnode>();
                    pathfindscript.retracedpathlist = sccspools.getpooledsccspathfindnodestack();//  new sccspathfindstructs.itsalmostastack<sccspathfindnode>();

                }
                else
                {
                    pathfindscript.retracedpathlist.Clear();
                }

                pathfindscript.countingmaxretracepathswtc = 0;
                pathfindscript.counting = 0;
                pathfindscript.mainSwitch = 1;

                pathfindscript.retracedpathlistcountertwo = 0;
                pathfindscript.retracedpathlistcounter = 0;
                //framecounterpathfindistrying = 0;
                pathfindscript.framecounterpathfind = 0;

                if (pathfindscript.retracedpathlistcountermaxloop == 0)
                {
                    pathfindscript.retracedpathlistcountermaxloop = 1;
                }

                if (pathfindscript.pathfindimax == 0)
                {
                    pathfindscript.pathfindimax = 1;
                }

                pathfindscript.startpathfind = 2;
                pathfindscript.isgridcreated = 1;
                //startpathfind = 2;
            }

            try
            {
                if (pathfindscript.startpathfind == 2)
                {

                    /*if (pathfindscript.debugtoconsolemsg == 1)
                    {
                        ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                        adminnotify.Execute(pathfindscript.theplayer, "test");
                    }*/



                    if (pathfindscript.isgridcreated == 1)
                    {

                        /*if (framecounterpathfindistrying >= framecounterpathfindistryingmax)
                        {
                            startpathfind = 1;
                            framecounterpathfindistrying = 0;
                        }*/



                        if (pathfindscript.framecounterpathfind >= pathfindscript.framecounterpathfindmax)
                        {
                            //StartCoroutine("pathfindcoroutine");



                            if (pathfindscript.hasstartedpathfindcounter >= pathfindscript.hasstartedpathfindcountermax)
                            {
                                //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
                                //adminnotify.Execute(pathfindscript.theplayer, "test");


                                pathfindscript.startpathfind = 3;


                                pathfindscript.hasstartedpathfindcounter = 0;
                            }
                            else
                            {
                                for (int i = 0; i < pathfindscript.pathfindimax; i++)
                                {
                                    if (pathfindscript.startpathfind == 2)
                                    {
                                        pathfindscript = sccspathfindseekerupdate.sccspathfindseekerupdatefunction(listofobstacles, pathfindscript);
                                    }
                                    else
                                    {
                                        break;
                                    }

                                    pathfindscript.hasstartedpathfindcounter++;
                                    //framecounterpathfindistrying++;
                                }

                            }



                            //TO REMOVE OTHERWISE PATHFIND WON'T RESTART
                            //startpathfind = 3;
                            //TO REMOVE OTHERWISE PATHFIND WON'T RESTART

                            pathfindscript.framecounterpathfind = 0;
                        }
                        pathfindscript.framecounterpathfind++;

                    }
                }
                else if (pathfindscript.startpathfind == 3)
                {
                    if (pathfindscript.countingmaxretracepathswtc == 1)//counting >= maxRetracePath)
                    {
                        if (pathfindscript.debugtoconsolemsg == 1)
                        {
                            ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                            adminnotify.Execute(pathfindscript.theplayer, "end of RetracePath:" + pathfindscript.counting + "/retracedpathlist.Count:" + pathfindscript.retracedpathlist.Count);
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




                        pathfindscript.countingmaxretracepathswtc = 2;
                    }
                    else if (pathfindscript.countingmaxretracepathswtc == 0)
                    {
                        /*
                        if (pathfin)
                        {

                        }*/

                        //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

                        //adminnotify.Execute(pathfindscript.theplayer, "frame arrived here");



               


                        if (pathfindscript.retracedpathlistcounter >= pathfindscript.retracedpathlistcountermax)
                        {
                            pathfindscript.startpathfind = 1;
                            pathfindscript.retracedpathlistcounter = 0;
                        }

                        if (pathfindscript.counting == 0)//the retracepathhasn't started yet.
                        {
                            //https://stackoverflow.com/questions/4003835/sort-list-in-c-sharp-with-linq
                            //sccspathfindcombineddatavar.finalset = sccspathfindcombineddatavar.finalset.OrderBy(x => x.fcost).ThenBy(x => x.toinitcost).ThenBy(x => x.hcost).ToList();

                            if (pathfindscript.sccspathfindcombineddatavar.closedset.Count > 0)
                            {
                                pathfindscript = sccspathfindretrace.RetracePath(pathfindscript.initialpathfindstartpos, pathfindscript.targetobjingridpos, pathfindscript.sccspathfindcombineddatavar.closedset[pathfindscript.sccspathfindcombineddatavar.closedset.Count - 1], 1, pathfindscript);// theseekernode);
                                pathfindscript.retracedpathlistcounter++;
                            }
                            else
                            {
                                pathfindscript.startpathfind = 1;
                            }

                            //RetracePath(initialpathfindstartpos, targetobjingridpos, theseekernode, 1);
                            //RetracePath(initialpathfindstartpos, targetobjingridpos, sccspathfindcombineddatavar.closedset[sccspathfindcombineddatavar.closedset.Count - 1], 1);// theseekernode);

                            //RetracePath(initialpathfindstartpos, targetobjingridpos, sccspathfindcombineddatavar.openset[0], 1);// theseekernode);

                        }
                        else
                        {
                            for (int i = 0; i < pathfindscript.retracedpathlistcountermaxloop; i++)
                            {

                                if (pathfindscript.countingmaxretracepathswtc == 0)
                                {
                                    pathfindscript = sccspathfindretrace.RetracePath(pathfindscript.initialpathfindstartpos, pathfindscript.targetobjingridpos, pathfindscript.currentNode, 0, pathfindscript);// theseekernode);

                                }
                                else
                                {
                                    break;
                                }

                                pathfindscript.retracedpathlistcounter++;
                            }
                        }
                    }
                    else if (pathfindscript.countingmaxretracepathswtc == 2)
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
                            pathfindscript.retracedpathlistcounter = 0;
                            pathfindscript.startpathfind = 4;



                            if (pathfindscript.retracedpathlist.Count > 0)
                            {
                                //retracedpathlist.RemoveAt(retracedpathlist.Count-1);
                                pathfindscript.retracedpathlist.Dequeue();
                            }
                        }
                    }
                }

            }
            catch //(UnityException ex)
            {
                //Debug.Log(ex.ToString());
            }


            return pathfindscript;
        }

    }
}
