//DEVELOPPED BY STEVE CHASSÉ AKA NINEKORN AKA NINE AKA 9 dob13may1983. 2023 JUNE 06TH REVISION

using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
using sccsvec2int = sccspathfindstructs.sccsvec2int;
using static sccspathfindstructs;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindretrace
    {
        public static sccspathfinddata RetracePath(sccsvec2int initialPos, sccsvec2int targetPos, sccspathfindnode node, int initpathfind, sccspathfinddata sccspathfinddata) //List<sccspathfindnode>
        {
            var currentX = targetPos.x;
            var currentY = targetPos.y;

            var startX = (initialPos.x);
            var startY = (initialPos.y);

            if (sccspathfinddata.mainSwitch == 1)
            {

                if (initpathfind == 0)
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

                    sccspathfinddata.mainSwitch = 2;
                    sccspathfinddata.countingmaxretracepathswtc = 1;

                    //break;
                }

                sccspathfinddata.counting++;
            }

            return sccspathfinddata;
        }

    }
}
