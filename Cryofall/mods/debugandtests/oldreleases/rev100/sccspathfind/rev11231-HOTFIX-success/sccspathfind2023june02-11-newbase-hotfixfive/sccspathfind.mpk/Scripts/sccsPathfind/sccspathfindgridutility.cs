//DEVELOPPED BY STEVE CHASSÉ AKA NINEKORN AKA NINE AKA 9 dob13may1983. 2023 JUNE 06TH REVISION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sccspathfindstructs;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindgridutility
    {

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

    }
}
