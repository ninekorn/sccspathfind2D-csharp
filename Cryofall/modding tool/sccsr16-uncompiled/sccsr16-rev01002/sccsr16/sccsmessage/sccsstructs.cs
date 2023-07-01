using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;


using System.Runtime.InteropServices;


namespace sccs
{
    public static class sccsstructs
    {

        public struct scinstanceintmaps
        {
            public Matrix instanceintmap;
        };


        public struct scinstancevertdimensions
        {
            public Matrix instancematrix;
            //public Matrix instancematrixb;
            //public Matrix instancematrixc;
            //public Matrix instancematrixd;
        };


        public struct chunkdata
        {
            public int swtcdirtyarea;

            public float[] positioninbundle;

            

            public int vertexcount;

          
            //public tutorialchunkcubemap arraychunkvertslod0;


            public float distanceculling;
            public bool frustrumculldraw;
            public float[] realpos;
            public int[] chunkPos;
            //public int indexinlevelgenmap;
            public int indexintypeoftiles;
            public int typeofterraintile;

            public int X;
            public int Y;
            public int Z;




            public scinstancevertdimensions instanceintmapfirstvertexa;
            //public SharpDX.Direct3D11.Buffer instanceintmapbufferfirstvertexa;

            public scinstancevertdimensions instanceintmapfirstvertexb;
            //public SharpDX.Direct3D11.Buffer instanceintmapbufferfirstvertexb;

            /*public scinstancevertdimensions instanceintmapfirstvertexc;
            //public SharpDX.Direct3D11.Buffer instanceintmapbufferfirstvertexc;

            public scinstancevertdimensions instanceintmapfirstvertexd;
            //public SharpDX.Direct3D11.Buffer instanceintmapbufferfirstvertexd;
            */





            public scinstanceintmaps instanceintmap;
            //public SharpDX.Direct3D11.Buffer instanceintmapbuffer;

            public scinstancevertdimensions instancesmatrixa;
            //public SharpDX.Direct3D11.Buffer instancesmatrixbuffera;

            public scinstancevertdimensions instancesmatrixb;
            //public SharpDX.Direct3D11.Buffer instancesmatrixbufferb;

            /*public scinstancevertdimensions instancesmatrixc;
            //public SharpDX.Direct3D11.Buffer instancesmatrixbufferc;

            public scinstancevertdimensions instancesmatrixd;
            //public SharpDX.Direct3D11.Buffer instancesmatrixbufferd;*/

            public int indexinmainarray;

            //public SharpDX.Direct3D11.Buffer ConstantLightBuffer;
        }

        public struct instancetype
        {
            public Vector4 instancePos;
        };


        //[StructLayout(LayoutKind.Explicit, Size = 80)]
        [StructLayout(LayoutKind.Explicit)]
        public struct DVertex
        {
            [FieldOffset(0)]
            public Vector4 position;
            [FieldOffset(16)]
            public Vector4 indexPos;
            [FieldOffset(32)]
            public Vector4 color;
            [FieldOffset(48)]
            public Vector3 normal;
            [FieldOffset(60)]
            public float padding0;
            [FieldOffset(64)]
            public Vector2 tex;
            [FieldOffset(72)]
            public float padding1;
            [FieldOffset(76)]
            public float padding2;
        }

    }
}
