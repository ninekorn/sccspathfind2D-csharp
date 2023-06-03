//DEVELOPPED BY STEVE CHASSÉ AKA NINEKORN AKA NINE AKA 9 dob13may1983. 2023 JUNE 06TH REVISION

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindglobals
    {
        public static byte stopatpathfindendswtc = 1;
        public static byte checkforobstaclesonthewayswtc = 1;
        public static float distnpctoplayersqrt = 0.75f;
        public static float dotnpcrotdirmin = 0.35f;

        //public static byte hasclearedarrays = 0;
        //public static byte hasinitswtc = 1;
        //public static byte mainSwitch = 1;
        public static byte debugtoconsolemsg = 0;
        public static int pathfindimax = 3;
        public static int hasstartedpathfindcountermax = 75;
        public static int framecounterpathfindmax = 0;
        public static byte createpathfindvisuals = 0;
        public static byte startpathfind = 1;
        public static int maxRetracePath = 75;
        public static int retracedpathlistcountermaxloop = 3;
        public static int retracedpathlistcountermax = 75;
        public static float noderadius = 1;
        public static int gridxl = 1;
        public static int gridxr = 0;
        public static int gridyb = 1;
        public static int gridyt = 0;
    }
}
