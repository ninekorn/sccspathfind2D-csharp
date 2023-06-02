//MADE BY STEVE CHASSÉ AKA NINEKORN AKA NINE dob13may1983. 2023 MAY 14TH - MAYBE APACHE 2.0 OR MIT LICENSE. I HAVE YET TO DECIDE.
namespace AtomicTorch.CBND.CoreMod.Characters.sccsPathfind
{
    using System.Linq;
    using sccspathfindgriddatafinal = sccspathfindstructs.sccspathfindgriddatafinal;
    using sccspathfindgridworldindex = sccspathfindstructs.sccspathfindgridworldindex;
    using sccsvec2int = sccspathfindstructs.sccsvec2int;
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
    using sccspathfinddata = sccspathfindstructs.sccspathfinddata;
    using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;

    public static class sccspathfindseekerupdate
    {
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
        

        //CHOOSING A SEEKER NODE, DECIDED BY SORTING WITH FCOST OR HCOST AND CHECKING NEIGHBOOR TILES AND CREATING GRIDS AS NEEDED. REFERENCED FROM THE LOGIC OF HOW PATHFIND WORKS IN SEBASTIAN LAGUES 01 TO 03 PATHFIND TUTORIAL ON YOUTUBE.
       public static sccspathfinddata sccspathfindseekerupdatefunction(System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata)//IEnumerator
        {
            sccsvec2int initposnewgrid0 = new sccsvec2int();
            initposnewgrid0.x = sccspathfinddata.theseekernode.worldpositionx;
            initposnewgrid0.y = sccspathfinddata.theseekernode.worldpositiony;

            var gridData00 = sccspathfindgridutility.getNewGridIndex(sccspathfinddata.initialpathfindstartpos, initposnewgrid0, sccspathfinddata.gridworldsize);

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
                sccspathfinddata = sccspathfindcreategrid.startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldstart, out gridData0, 0, 0, new sccsvec2int(), listofobstacles, sccspathfinddata);
            }


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
                sccspathfinddata = sccspathfindcheckallsides.checkAllSidesGridIndex(sccspathfinddata.theseekernode, sccspathfinddata.gridworldsize, sccspathfinddata.initialpathfindstartpos, gridData00.gridData, listofobstacles, sccspathfinddata);//cData.lip //, gridData00.gridData

                if (sccspathfinddata.pathfindswtc == 0 && sccspathfinddata.startpathfind != 3)
                {                   
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
            if (sccspathfinddata.sccspathfindcombineddatavar.openset.Count > 4 * 2)
            {
                sccspathfinddata.startpathfind = 3;
            }
            */


            /*
            pathfindi++;

            if (pathfindi >= pathfindimax)
            {
                pathfindi = 0;
            }*/

            //yield return new WaitForSeconds(3);
            return sccspathfinddata;
        }
        //CHOOSING A SEEKER NODE, DECIDED BY SORTING WITH FCOST OR HCOST AND CHECKING NEIGHBOOR TILES AND CREATING GRIDS AS NEEDED. REFERENCED FROM THE LOGIC OF HOW PATHFIND WORKS IN SEBASTIAN LAGUES 01 TO 03 PATHFIND TUTORIAL ON YOUTUBE.




        //CANNOT USE FOR THE MOMENT. NO RESPONSE FROM TUTORIALSPOINT.COM
        //CANNOT USE FOR THE MOMENT. NO RESPONSE FROM TUTORIALSPOINT.COM
        /*//https://www.tutorialspoint.com/heap-sort-in-chash 
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
        }*/
        //CANNOT USE FOR THE MOMENT. NO RESPONSE FROM TUTORIALSPOINT.COM
        //CANNOT USE FOR THE MOMENT. NO RESPONSE FROM TUTORIALSPOINT.COM

    }
}