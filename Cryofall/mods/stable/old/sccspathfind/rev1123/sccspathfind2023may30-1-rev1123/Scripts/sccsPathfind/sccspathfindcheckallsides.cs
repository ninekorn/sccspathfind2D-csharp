using System;
using System.Collections.Generic;
using sccsvec2int = sccspathfindstructs.sccsvec2int;
using static sccspathfindstructs;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindcheckallsides
    {
        //developped by steve chassé aka ninekorn. using as reference the GetNeighBours function and logic from sebastian lagues Episode 03 - astar tutorial on how to find neighboor tiles. Sebastian Lague was getting the position of the node. With playing around with voxels a lot, i had figured how to get the index out of the position or to make an index out of it. so i decided to add more logic inside of the GetNeighBours function.
        //developped by steve chassé aka ninekorn. using as reference the GetNeighBours function and logic from sebastian lagues Episode 03 - astar tutorial on how to find neighboor tiles. Sebastian Lague was getting the position of the node. With playing around with voxels a lot, i had figured how to get the index out of the position or to make an index out of it. so i decided to add more logic inside of the GetNeighBours function.
        public static sccspathfinddata checkAllSidesGridIndex(sccspathfindnode node, sccspathfindgridWorldSize gridWorldSize, sccsvec2int initialPos, sccspathfindgridworldindex nodegriddata, System.Collections.Generic.List<sccsvec2int> listofobstacles, sccspathfinddata sccspathfinddata)
        {
            sccspathfinddata.neighboors = new List<sccspathfindneighboortile>();

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

                        var gridData = sccspathfindgridutility.getNewGridIndex(initialPos, pos, gridWorldSize); //, cData.objt.sid
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

                                sccspathfinddata = sccspathfindcreategrid.startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData, -1, 1, extratilepos, listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 
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
                            gridData = sccspathfindgridutility.getNewGridIndex(initialPos, pos, gridWorldSize); //, sccspathfindcombineddatavar.objt.sid

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

                                sccspathfinddata = sccspathfindcreategrid.startcreategrid(sccspathfinddata.theseekernode, sccspathfinddata.initialpathfindstartpos, sccspathfinddata.targetobjingridpos, gridworldlink, out gridData, -1, 1, extratilepos, listofobstacles, sccspathfinddata); //posofgrid//var finalnodelist1 = 
                            }


                            if (sccspathfinddata.sccspathfindcombineddatavar.log[indexOfGrid] != null)
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

            return sccspathfinddata;
        }
    }
}
