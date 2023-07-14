using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
    //FROM THE UNITY3D OFFICIAL OBJECT POOL TUTORIAL

    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using static sccspathfindstructs;
    using sccsvec2int = sccspathfindstructs.sccsvec2int;
    //using UnityEngine;


    //sccspathfinddata pathfindscript =new sccspathfinddata();
    //sccspathfindperscriptmobdatastruct thenewstructdata =new sccspathfindperscriptmobdatastruct();
    //List<sccspathfindobstaclestruct> listofobstaclesinit =new List<sccspathfindobstaclestruct>();
    //List<sccsvec2int> listofobstaclesonthewaytwo =new List<sccsvec2int>();
    //List<sccspathfindobstaclestruct> listofobstaclesontheway =new List<sccspathfindobstaclestruct>();
    //sccsvec2float x9
    //sccsvec2int x1
    //Vector2D x3


    public static class sccspools //: MonoBehaviour
    {
        /*
        List<sccspathfindnode>();
                    List<sccspathfindnode[]>();
                    sccspathfindstructs.itsalmostastack<sccspathfindnode>()*/


        //public new sccspools current;
        public static int pooledAmountsccsvec2float = 3;//3
        public static int pooledAmountsccsvec2int = 3;//3
        public static int pooledAmountsccspathfindnode = 3;//3     

        public static int pooledAmount = 1;//3
        public static bool willGrow = true;
        /*static itsalmostastack<sccspathfinddata> pooledsccspathfinddata;
        static itsalmostastack<sccspathfindperscriptmobdatastruct> pooledsccspathfindperscriptmobdatastruct;
        static itsalmostastack<List<sccspathfindobstaclestruct>> pooledsccspathfindobstaclestructlist;
        static itsalmostastack<List<sccsvec2int>> pooledsccsvec2intlist;
        static itsalmostastack<List<sccspathfindobstaclestruct>> pooledsccspathfindobstaclestructlisttwo;
        static itsalmostastack<sccsvec2float> pooledsccsvec2float;
        static itsalmostastack<List<sccspathfindnode>> pooledsccspathfindnodelist;
        static itsalmostastack<List<sccspathfindnode[]>> pooledsccspathfindnodelistarray;
        static itsalmostastack<itsalmostastack<sccspathfindnode>> pooledsccspathfindnodestack;
        static itsalmostastack<sccspathfindnode> pooledsccspathfindnode;
        static itsalmostastack<sccsvec2int> pooledsccsvec2int;
        */

        static Queue<sccspathfinddata> pooledsccspathfinddata = new Queue<sccspathfinddata>();
        static Queue<sccspathfindperscriptmobdatastruct> pooledsccspathfindperscriptmobdatastruct = new Queue<sccspathfindperscriptmobdatastruct>();
        static Queue<List<sccspathfindobstaclestruct>> pooledsccspathfindobstaclestructlist = new Queue<List<sccspathfindobstaclestruct>>();
        static Queue<List<sccsvec2int>> pooledsccsvec2intlist = new Queue<List<sccsvec2int>>();
        static Queue<List<sccspathfindobstaclestruct>> pooledsccspathfindobstaclestructlisttwo = new Queue<List<sccspathfindobstaclestruct>>();
        static Queue<sccsvec2float> pooledsccsvec2float = new Queue<sccsvec2float>();
        static Queue<List<sccspathfindnode>> pooledsccspathfindnodelist = new Queue<List<sccspathfindnode>>();
        static Queue<List<sccspathfindnode[]>> pooledsccspathfindnodelistarray = new Queue<List<sccspathfindnode[]>>();
        static Queue<Queue<sccspathfindnode>> pooledsccspathfindnodestack = new Queue<Queue<sccspathfindnode>>();
        static Queue<sccspathfindnode> pooledsccspathfindnode = new Queue<sccspathfindnode>();
        static Queue<sccsvec2int> pooledsccsvec2int = new Queue<sccsvec2int>();
        static Queue<ConsoleAdminNotifyPlayer> pooledConsoleAdminNotifyPlayer = new Queue<ConsoleAdminNotifyPlayer>();
        static Queue<sccspathfindcombineddata> pooledsccspathfindcombineddata = new Queue<sccspathfindcombineddata>();


        
                          



        public static int sentmsgtogrowlist0 = 1;
        public static int sentmsgtogrowlist1 = 1;
        public static int sentmsgtogrowlist2 = 1;
        public static int sentmsgtogrowlist3 = 1;
        public static int sentmsgtogrowlist4 = 1;
        public static int sentmsgtogrowlist5 = 1;
        public static int sentmsgtogrowlist6 = 1;
        public static int sentmsgtogrowlist7 = 1;
        public static int sentmsgtogrowlist8 = 1;
        public static int sentmsgtogrowlist9 = 1;
        public static int sentmsgtogrowlist10 = 1;
        public static int sentmsgtogrowlist11 = 1;
        public static int sentmsgtogrowlist12 = 1;


        public static int threadsleepswtc = 0;
        public static void worktopoolobjectmethod()
        {

            var mainsccsgraphicssecthread = new Thread((tester0000) =>
            {

                int pooledamountcounter0 = 0;
                int pooledamountcounter1 = 0;
                int pooledamountcounter2 = 0;
                int pooledamountcounter3 = 0;
                int pooledamountcounter4 = 0;
                int pooledamountcounter5 = 0;
                int pooledamountcounter6 = 0;
                int pooledamountcounter7 = 0;
                int pooledamountcounter8 = 0;
                int pooledamountcounter9 = 0;
                int pooledamountcounter10 = 0;
                int pooledamountcounter11 = 0;
                int pooledamountcounter12 = 0;



                int fillpoolscounter = 10;


                if (sentmsgtogrowlist5 == 1)
                {
                    //for (int i = 0; i < 3; i++)
                    {
                        threadsleepswtc = 1;
                        if (pooledamountcounter5 >= 100)
                        {
                            sentmsgtogrowlist5 = 0;
                            pooledamountcounter5 = 0;
                        }
                        else
                        {
                            lock (pooledsccsvec2float)
                            {
                                pooledsccsvec2float.Enqueue(new sccsvec2float());
                            }
                        }

                        pooledamountcounter5++;
                    }
                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist9 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter9 >= 100)
                    {
                        sentmsgtogrowlist9 = 0;
                        pooledamountcounter9 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnode)
                        {
                            pooledsccspathfindnode.Enqueue(new sccspathfindnode());
                        }
                    }

                    pooledamountcounter9++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }


                if (sentmsgtogrowlist10 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter10 >= 100)
                    {
                        sentmsgtogrowlist10 = 0;
                        pooledamountcounter10 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2int)
                        {
                            pooledsccsvec2int.Enqueue(new sccsvec2int());
                        }
                    }

                    pooledamountcounter10++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist0 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter0 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist0 = 0;
                        pooledamountcounter0 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfinddata)
                        {
                            //pooledsccspathfinddata.Enqueue(new sccspathfinddata());
                            pooledsccspathfinddata.Enqueue(new sccspathfinddata());

                        }
                    }

                    pooledamountcounter0++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist1 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter1 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist1 = 0;
                        pooledamountcounter1 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindperscriptmobdatastruct)
                        {
                            pooledsccspathfindperscriptmobdatastruct.Enqueue(new sccspathfindperscriptmobdatastruct());

                        }
                    }

                    pooledamountcounter1++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }





                if (sentmsgtogrowlist2 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter2 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist2 = 0;
                        pooledamountcounter2 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindobstaclestructlist)
                        {
                            pooledsccspathfindobstaclestructlist.Enqueue(new List<sccspathfindobstaclestruct>());
                        }
                    }

                    pooledamountcounter2++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }





                if (sentmsgtogrowlist3 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter3 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist3 = 0;
                        pooledamountcounter3 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2intlist)
                        {
                            pooledsccsvec2intlist.Enqueue(new List<sccsvec2int>());
                        }
                    }

                    pooledamountcounter3++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }






                if (sentmsgtogrowlist4 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter4 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist4 = 0;
                        pooledamountcounter4 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindobstaclestructlisttwo)
                        {
                            pooledsccspathfindobstaclestructlisttwo.Enqueue(new List<sccspathfindobstaclestruct>());
                        }
                    }

                    pooledamountcounter4++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }









                if (sentmsgtogrowlist6 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter6 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist6 = 0;
                        pooledamountcounter6 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodelist)
                        {
                            pooledsccspathfindnodelist.Enqueue(new List<sccspathfindnode>());
                        }
                    }

                    pooledamountcounter6++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }


                if (sentmsgtogrowlist7 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter7 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist7 = 0;
                        pooledamountcounter7 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodelistarray)
                        {
                            pooledsccspathfindnodelistarray.Enqueue(new List<sccspathfindnode[]>());
                        }
                    }

                    pooledamountcounter7++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }

                if (sentmsgtogrowlist8 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter8 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist8 = 0;
                        pooledamountcounter8 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodestack)
                        {
                            pooledsccspathfindnodestack.Enqueue(new Queue<sccspathfindnode>());
                        }
                    }

                    pooledamountcounter8++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }










                if (sentmsgtogrowlist11 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter11 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist11 = 0;
                        pooledamountcounter11 = 0;
                    }
                    else
                    {
                        lock (pooledConsoleAdminNotifyPlayer)
                        {
                            pooledConsoleAdminNotifyPlayer.Enqueue(new ConsoleAdminNotifyPlayer());
                        }
                    }

                    pooledamountcounter11++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist12 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter12 >= fillpoolscounter)
                    {
                        sentmsgtogrowlist12 = 0;
                        pooledamountcounter12 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindcombineddata)
                        {
                            pooledsccspathfindcombineddata.Enqueue(new sccspathfindcombineddata());
                        }
                    }

                    pooledamountcounter12++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }






            _thread_main_loop:

                threadsleepswtc = 0;









                if (sentmsgtogrowlist5 == 1)
                {
                    //for (int i = 0; i < 3; i++)
                    {
                        threadsleepswtc = 1;
                        if (pooledamountcounter5 >= pooledAmountsccsvec2float)
                        {
                            sentmsgtogrowlist5 = 0;
                            pooledamountcounter5 = 0;
                        }
                        else
                        {
                            lock (pooledsccsvec2float)
                            {
                                pooledsccsvec2float.Enqueue(new sccsvec2float());
                            }
                        }

                        pooledamountcounter5++;
                    }
                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist9 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter9 >= pooledAmountsccspathfindnode)
                    {
                        sentmsgtogrowlist9 = 0;
                        pooledamountcounter9 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnode)
                        {
                            pooledsccspathfindnode.Enqueue(new sccspathfindnode());
                        }
                    }

                    pooledamountcounter9++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }


                if (sentmsgtogrowlist10 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter10 >= pooledAmountsccsvec2int)
                    {
                        sentmsgtogrowlist10 = 0;
                        pooledamountcounter10 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2int)
                        {
                            pooledsccsvec2int.Enqueue(new sccsvec2int());
                        }
                    }

                    pooledamountcounter10++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist0 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter0 >= pooledAmount)
                    {
                        sentmsgtogrowlist0 = 0;
                        pooledamountcounter0 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfinddata)
                        {
                            //pooledsccspathfinddata.Enqueue(new sccspathfinddata());
                            pooledsccspathfinddata.Enqueue(new sccspathfinddata());

                        }
                    }

                    pooledamountcounter0++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist1 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter1 >= pooledAmount)
                    {
                        sentmsgtogrowlist1 = 0;
                        pooledamountcounter1 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindperscriptmobdatastruct)
                        {
                            pooledsccspathfindperscriptmobdatastruct.Enqueue(new sccspathfindperscriptmobdatastruct());

                        }
                    }

                    pooledamountcounter1++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }





                if (sentmsgtogrowlist2 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter2 >= pooledAmount)
                    {
                        sentmsgtogrowlist2 = 0;
                        pooledamountcounter2 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindobstaclestructlist)
                        {
                            pooledsccspathfindobstaclestructlist.Enqueue(new List<sccspathfindobstaclestruct>());
                        }
                    }

                    pooledamountcounter2++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }





                if (sentmsgtogrowlist3 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter3 >= pooledAmount)
                    {
                        sentmsgtogrowlist3 = 0;
                        pooledamountcounter3 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2intlist)
                        {
                            pooledsccsvec2intlist.Enqueue(new List<sccsvec2int>());
                        }
                    }

                    pooledamountcounter3++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }






                if (sentmsgtogrowlist4 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter4 >= pooledAmount)
                    {
                        sentmsgtogrowlist4 = 0;
                        pooledamountcounter4 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindobstaclestructlisttwo)
                        {
                            pooledsccspathfindobstaclestructlisttwo.Enqueue(new List<sccspathfindobstaclestruct>());
                        }
                    }

                    pooledamountcounter4++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }









                if (sentmsgtogrowlist6 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter6 >= pooledAmount)
                    {
                        sentmsgtogrowlist6 = 0;
                        pooledamountcounter6 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodelist)
                        {
                            pooledsccspathfindnodelist.Enqueue(new List<sccspathfindnode>());
                        }
                    }

                    pooledamountcounter6++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }


                if (sentmsgtogrowlist7 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter7 >= pooledAmount)
                    {
                        sentmsgtogrowlist7 = 0;
                        pooledamountcounter7 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodelistarray)
                        {
                            pooledsccspathfindnodelistarray.Enqueue(new List<sccspathfindnode[]>());
                        }
                    }

                    pooledamountcounter7++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }

                if (sentmsgtogrowlist8 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter8 >= pooledAmount)
                    {
                        sentmsgtogrowlist8 = 0;
                        pooledamountcounter8 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodestack)
                        {
                            pooledsccspathfindnodestack.Enqueue(new Queue<sccspathfindnode>());
                        }
                    }

                    pooledamountcounter8++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }










                if (sentmsgtogrowlist11 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter11 >= pooledAmount)
                    {
                        sentmsgtogrowlist11 = 0;
                        pooledamountcounter11 = 0;
                    }
                    else
                    {
                        lock (pooledConsoleAdminNotifyPlayer)
                        {
                            pooledConsoleAdminNotifyPlayer.Enqueue(new ConsoleAdminNotifyPlayer());
                        }
                    }

                    pooledamountcounter11++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist12 == 1)
                {
                    threadsleepswtc = 1;
                    if (pooledamountcounter12 >= pooledAmount)
                    {
                        sentmsgtogrowlist12 = 0;
                        pooledamountcounter12 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindcombineddata)
                        {
                            pooledsccspathfindcombineddata.Enqueue(new sccspathfindcombineddata());
                        }
                    }

                    pooledamountcounter12++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }







                if (threadsleepswtc == 0)
                {
                    Thread.Sleep(3);
                }
                else
                {
                    Thread.Sleep(1);
                }

                goto _thread_main_loop;

            }, 0); //100000 //999999999

            mainsccsgraphicssecthread.IsBackground = true;
            mainsccsgraphicssecthread.Priority = ThreadPriority.Normal; //AboveNormal
            mainsccsgraphicssecthread.SetApartmentState(ApartmentState.STA);
            mainsccsgraphicssecthread.Start();
        }










        public static void createpoolscript()
        {
            /*pooledsccspathfinddata = new Queue<sccspathfinddata>();
            pooledsccspathfindperscriptmobdatastruct = new Queue<sccspathfindperscriptmobdatastruct>();
            pooledsccspathfindobstaclestructlist = new Queue<List<sccspathfindobstaclestruct>>();
            pooledsccsvec2intlist = new Queue<List<sccsvec2int>>();
            pooledsccspathfindobstaclestructlisttwo = new Queue<List<sccspathfindobstaclestruct>>();
            pooledsccsvec2float = new Queue<sccsvec2float>();*/
            /*
            sentmsgtogrowlist0 = 1;
            sentmsgtogrowlist1 = 1;
            sentmsgtogrowlist2 = 1;
            sentmsgtogrowlist3 = 1;
            sentmsgtogrowlist4 = 1;
            sentmsgtogrowlist5 = 1;
            sentmsgtogrowlist6 = 1;
            sentmsgtogrowlist7 = 1;
            sentmsgtogrowlist8 = 1;
            sentmsgtogrowlist9 = 1;
            sentmsgtogrowlist10 = 1;*/

            int pooledamountcounter0 = 0;
            int pooledamountcounter1 = 0;
            int pooledamountcounter2 = 0;
            int pooledamountcounter3 = 0;
            int pooledamountcounter4 = 0;
            int pooledamountcounter5 = 0;
            int pooledamountcounter6 = 0;
            int pooledamountcounter7 = 0;
            int pooledamountcounter8 = 0;
            int pooledamountcounter9 = 0;
            int pooledamountcounter10 = 0;





            /*
            for (int i = 0; i < pooledAmount; i++)
            {


                if (sentmsgtogrowlist0 == 1)
                {
                    if (pooledamountcounter0 >= pooledAmount)
                    {
                        sentmsgtogrowlist0 = 0;
                        pooledamountcounter0 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfinddata)
                        {
                            pooledsccspathfinddata.Enqueue(new sccspathfinddata());

                        }
                    }

                    pooledamountcounter0++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }



                if (sentmsgtogrowlist1 == 1)
                {
                    if (pooledamountcounter1 >= pooledAmount)
                    {
                        sentmsgtogrowlist1 = 0;
                        pooledamountcounter1 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindperscriptmobdatastruct)
                        {
                            pooledsccspathfindperscriptmobdatastruct.Enqueue(new sccspathfindperscriptmobdatastruct());

                        }
                    }

                    pooledamountcounter1++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }





                if (sentmsgtogrowlist2 == 1)
                {
                    if (pooledamountcounter2 >= pooledAmount)
                    {
                        sentmsgtogrowlist2 = 0;
                        pooledamountcounter2 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindobstaclestructlist)
                        {
                            pooledsccspathfindobstaclestructlist.Enqueue(new List<sccspathfindobstaclestruct>());
                        }
                    }

                    pooledamountcounter2++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }





                if (sentmsgtogrowlist3 == 1)
                {
                    if (pooledamountcounter3 >= pooledAmount)
                    {
                        sentmsgtogrowlist3 = 0;
                        pooledamountcounter3 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2intlist)
                        {
                            pooledsccsvec2intlist.Enqueue(new List<sccsvec2int>());
                        }
                    }

                    pooledamountcounter3++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }






                if (sentmsgtogrowlist4 == 1)
                {
                    if (pooledamountcounter4 >= pooledAmount)
                    {
                        sentmsgtogrowlist4 = 0;
                        pooledamountcounter4 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindobstaclestructlisttwo)
                        {
                            pooledsccspathfindobstaclestructlisttwo.Enqueue(new List<sccspathfindobstaclestruct>());
                        }
                    }

                    pooledamountcounter4++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }




                if (sentmsgtogrowlist5 == 1)
                {
                    if (pooledamountcounter5 >= pooledAmount)
                    {
                        sentmsgtogrowlist5 = 0;
                        pooledamountcounter5 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2float)
                        {
                            pooledsccsvec2float.Enqueue(new sccsvec2float());
                        }
                    }

                    pooledamountcounter5++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }








                if (sentmsgtogrowlist6 == 1)
                {
                    if (pooledamountcounter6 >= pooledAmount)
                    {
                        sentmsgtogrowlist6 = 0;
                        pooledamountcounter6 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodelist)
                        {
                            pooledsccspathfindnodelist.Enqueue(new List<sccspathfindnode>());
                        }
                    }

                    pooledamountcounter6++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }


                if (sentmsgtogrowlist7 == 1)
                {
                    if (pooledamountcounter7 >= pooledAmount)
                    {
                        sentmsgtogrowlist7 = 0;
                        pooledamountcounter7 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodelistarray)
                        {
                            pooledsccspathfindnodelistarray.Enqueue(new List<sccspathfindnode[]>());
                        }
                    }

                    pooledamountcounter7++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }

                if (sentmsgtogrowlist8 == 1)
                {
                    if (pooledamountcounter8 >= pooledAmount)
                    {
                        sentmsgtogrowlist8 = 0;
                        pooledamountcounter8 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnodestack)
                        {
                            pooledsccspathfindnodestack.Enqueue(new itsalmostastack<sccspathfindnode>());
                        }
                    }

                    pooledamountcounter8++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }







                if (sentmsgtogrowlist9 == 1)
                {
                    if (pooledamountcounter9 >= pooledAmount)
                    {
                        sentmsgtogrowlist9 = 0;
                        pooledamountcounter9 = 0;
                    }
                    else
                    {
                        lock (pooledsccspathfindnode)
                        {
                            pooledsccspathfindnode.Enqueue(new sccspathfindnode());
                        }
                    }

                    pooledamountcounter9++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }


                if (sentmsgtogrowlist10 == 1)
                {
                    if (pooledamountcounter10 >= pooledAmount)
                    {
                        sentmsgtogrowlist10 = 0;
                        pooledamountcounter10 = 0;
                    }
                    else
                    {
                        lock (pooledsccsvec2int)
                        {
                            pooledsccsvec2int.Enqueue(new sccsvec2int());
                        }
                    }

                    pooledamountcounter10++;

                    //Thread.Sleep(1);
                }
                else
                {
                    //Thread.Sleep(2);
                }
            }*/




            worktopoolobjectmethod();


            /*
            for (int i = 0; i < pooledAmount; i++)
            {
                //var pathfindscript = new sccspathfinddata();
                //GameObject obj = (GameObject)Instantiate(pooledObject);
                //obj.SetActive(false);
                pooledObjects.Enqueue(new sccspathfinddata());
            }*/

        }


        // Update is called once per frame




        public static sccspathfinddata getpooledsccspathfinddata()
        {

            if (pooledsccspathfinddata.Count > 0)
            {
                var dequeued = pooledsccspathfinddata.Dequeue();
                return dequeued;
            }
            else
            {
                //for (int i = 0; i < pooledAmount; i++)
                //{
                //pooledsccspathfinddata.Enqueue(new sccspathfinddata());
                ///}
                sentmsgtogrowlist0 = 1;
                return new sccspathfinddata();
            }
        }

        /*
        itsalmostastack<sccspathfinddata> pooledsccspathfinddata;
        itsalmostastack<sccspathfindperscriptmobdatastruct> pooledsccspathfindperscriptmobdatastruct;
        itsalmostastack<List<sccspathfindobstaclestruct>> pooledsccspathfindobstaclestructlist;
        itsalmostastack<List<sccsvec2int>> pooledsccsvec2intlist;
        itsalmostastack<List<sccspathfindobstaclestruct>> pooledsccspathfindobstaclestructlisttwo;
        itsalmostastack<sccsvec2float> pooledsccsvec2float;*/

        public static sccspathfindperscriptmobdatastruct getpooledsccspathfindperscriptmobdatastruct()
        {

            if (pooledsccspathfindperscriptmobdatastruct.Count > 0)
            {
                var dequeued = pooledsccspathfindperscriptmobdatastruct.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist1 = 1;
                return new sccspathfindperscriptmobdatastruct();
            }
        }
        public static List<sccspathfindobstaclestruct> getpooledsccspathfindobstaclestruct()
        {

            if (pooledsccspathfindobstaclestructlist.Count > 0)
            {
                var dequeued = pooledsccspathfindobstaclestructlist.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist2 = 1;
                return new List<sccspathfindobstaclestruct>();
            }
        }
        public static List<sccsvec2int> getpooledsccsvec2intlist()
        {

            if (pooledsccsvec2intlist.Count > 0)
            {
                var dequeued = pooledsccsvec2intlist.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist3 = 1;
                return new List<sccsvec2int>();
            }
        }

        public static List<sccspathfindobstaclestruct> getpooledsccspathfindobstaclestructtwo()
        {

            if (pooledsccspathfindobstaclestructlisttwo.Count > 0)
            {
                var dequeued = pooledsccspathfindobstaclestructlisttwo.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist4 = 1;
                return new List<sccspathfindobstaclestruct>();
            }
        }





        public static sccsvec2float getpooledsccsvec2float()
        {

            if (pooledsccsvec2float.Count > 0)
            {
                var dequeued = pooledsccsvec2float.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist5 = 1;
                return new sccsvec2float();
            }
        }




        public static List<sccspathfindnode> getpooledsccspathfindnodelist()
        {

            /*if (pooledsccspathfindnodelist.Count > 0)
            {
                var dequeued = pooledsccspathfindnodelist.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist6 = 1;
                return new List<sccspathfindnode>();
            }*/


            return new List<sccspathfindnode>();
        }




        public static List<sccspathfindnode[]> getpooledsccspathfindnodelistarray()
        {

            if (pooledsccspathfindnodelistarray.Count > 0)
            {
                var dequeued = pooledsccspathfindnodelistarray.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist7 = 1;
                return new List<sccspathfindnode[]>();
            }
        }




        public static Queue<sccspathfindnode> getpooledsccspathfindnodestack()
        {

            if (pooledsccspathfindnodestack.Count > 0)
            {
                var dequeued = pooledsccspathfindnodestack.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist8 = 1;
                return new Queue<sccspathfindnode>();
            }
        }


        public static sccspathfindnode getpooledsccspathfindnode()
        {

            if (pooledsccspathfindnode.Count > 0)
            {
                var dequeued = pooledsccspathfindnode.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist9 = 1;
                return new sccspathfindnode();
            }
        }





        public static sccsvec2int getpooledsccsvec2int()
        {

            if (pooledsccsvec2int.Count > 0)
            {
                var dequeued = pooledsccsvec2int.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist10 = 1;
                return new sccsvec2int();
            }
        }


        public static ConsoleAdminNotifyPlayer getpooledConsoleAdminNotifyPlayer()
        {

            if (pooledConsoleAdminNotifyPlayer.Count > 0)
            {
                var dequeued = pooledConsoleAdminNotifyPlayer.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist11 = 1;
                return new ConsoleAdminNotifyPlayer();
            }
        }

        public static sccspathfindcombineddata getpooledsccspathfindcombineddata()
        {

            if (pooledsccspathfindcombineddata.Count > 0)
            {
                var dequeued = pooledsccspathfindcombineddata.Dequeue();
                return dequeued;
            }
            else
            {
                sentmsgtogrowlist12 = 1;
                return new sccspathfindcombineddata();
            }
        }

    }
}


//public GameObject pooledObject;
//List<sccspathfinddata> pooledObjects;

/*pooledObjects = new List<GameObject>();
for(int i = 0;i <pooledAmount;i++)
{
    GameObject obj = (GameObject)Instantiate(pooledObject);
    obj.SetActive(false);
    pooledObjects.Add(obj);
}*/
/*
if (willGrow)
{
    GameObject obj = (GameObject)Instantiate(pooledObject);
    pooledObjects.Add(obj);
    return obj;
}
return null;*/
/*if (pooledObjects != null)
{
    for (int i = 0; i < pooledObjects.Count; i++)
    {
        if (!pooledObjects[i].activeInHierarchy)
        {
            return pooledObjects[i];
        }
    }
}*/
