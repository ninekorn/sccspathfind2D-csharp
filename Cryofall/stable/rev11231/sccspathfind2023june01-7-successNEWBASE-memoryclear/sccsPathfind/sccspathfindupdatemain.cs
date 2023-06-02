using System;
using System.Collections.Generic;
using sccspathfindnode = sccspathfindstructs.sccspathfindnode;
using sccsvec2int = sccspathfindstructs.sccsvec2int;
using sccsvec2float = sccspathfindstructs.sccsvec2float;
using AtomicTorch.CBND.GameApi.Data.Characters;
using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
using sccspathfinddata = sccspathfindstructs.sccspathfinddata;
using AtomicTorch.CBND.CoreMod.Characters.sccsPathfind;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindupdatemain
    {

        public static sccspathfinddata pathfindupdatemainfunction(sccsvec2float npcpos, sccsvec2float targetpos, System.Collections.Generic.List<sccsvec2int> listofobstacles, ICharacter npccharacter_, ICharacter playercharacter_, sccspathfinddata sccspathfinddata)
        {
            if (sccspathfinddata.startpathfind == 1)
            {
                sccspathfinddata.thenpc = npccharacter_;
                sccspathfinddata.theplayer = playercharacter_;


                sccspathfinddata.gridworldsize.xL = sccspathfinddata.gridxl;
                sccspathfinddata.gridworldsize.xR = sccspathfinddata.gridxr;
                sccspathfinddata.gridworldsize.yB = sccspathfinddata.gridyb;
                sccspathfinddata.gridworldsize.yT = sccspathfinddata.gridyt;

                sccsvec2int npcinitposofpathfindzerozero = new sccsvec2int();
                npcinitposofpathfindzerozero.x = 0;
                npcinitposofpathfindzerozero.y = 0;

                sccspathfinddata.initialpathfindstartpos = new sccsvec2int();
                sccspathfinddata.initialpathfindstartpos.x = npcinitposofpathfindzerozero.x;// + (int)this.transform.position.x;
                sccspathfinddata.initialpathfindstartpos.y = npcinitposofpathfindzerozero.y;//+ (int)this.transform.position.y;

                int targetlocationwithdiffxremoved = (int)targetpos.x - (int)npcpos.x;//(int)targetobj.transform.position.x -this.transform.position.x;
                int targetlocationwithdiffyremoved = (int)targetpos.y - (int)npcpos.y;// (int)targetobj.transform.position.y -this.transform.position.y;

                sccspathfinddata.initialpathfindnpcpos = new sccsvec2int();
                sccspathfinddata.initialpathfindnpcpos.x = (int)Math.Round((double)npcpos.x);
                sccspathfinddata.initialpathfindnpcpos.y = (int)Math.Round((double)npcpos.y);

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
                /*
                if (sccspathfinddata.sccspathfindcombineddatavar.betterroutechecklist == null)
                {
                    sccspathfinddata.sccspathfindcombineddatavar.betterroutechecklist = new List<sccspathfindnode>();
                }
                else
                {
                    sccspathfinddata.sccspathfindcombineddatavar.betterroutechecklist.Clear();
                }*/

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
                                //ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();
                                //adminnotify.Execute(sccspathfinddata.theplayer, "test");


                                sccspathfinddata.startpathfind = 1;
                                sccspathfinddata.hasstartedpathfindcounter = 0;
                            }
                            else
                            {
                                for (int i = 0; i < sccspathfinddata.pathfindimax; i++)
                                {
                                    if (sccspathfinddata.startpathfind == 2)
                                    {
                                        sccspathfinddata = sccspathfindseekerupdate.sccspathfindseekerupdatefunction(listofobstacles, sccspathfinddata);
                                    }
                                    else
                                    {
                                        break;
                                    }

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
                                sccspathfinddata = sccspathfindretrace.RetracePath(sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, sccspathfinddata.sccspathfindcombineddatavar.finalset[sccspathfinddata.sccspathfindcombineddatavar.finalset.Count - 1], 1, sccspathfinddata);// theseekernode);
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
                                sccspathfinddata = sccspathfindretrace.RetracePath(sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, sccspathfinddata.currentNode, 0, sccspathfinddata);// theseekernode);

                                sccspathfinddata.retracedpathlistcounter++;
                            }
                        }

                        /*
                        if (sccspathfinddata.retracedpathlistcounter > )
                        {

                        }*/


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
                        }
                    }
                }

            }
            catch //(UnityException ex)
            {
                //Debug.Log(ex.ToString());
            }


            return sccspathfinddata;
        }

    }
}
