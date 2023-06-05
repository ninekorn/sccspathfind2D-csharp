using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

//using Ab3d.DXEngine;
using Ab3d.OculusWrap;
//using Ab3d.DXEngine.OculusWrap;
using Ab3d.OculusWrap.DemoDX11;

using SharpDX;
using SharpDX.DXGI;
using SharpDX.Direct3D11;
using SharpDX.DirectInput;

//using SCCoreSystems.SC_Graphics;
//using SCCoreSystems.SC_Graphics.SC_ShaderManager;

using Jitter;
using Jitter.Dynamics;
using Jitter.Collision;
using Jitter.LinearMath;
using Jitter.Collision.Shapes;
using Jitter.Forces;

using System.Collections.Generic;
using System.Collections;
using System.Runtime;
using System.Runtime.CompilerServices;

using System.ComponentModel;
using SharpDX.D3DCompiler;

using sccsmessage = sccsmessage.sc_message_object;
using sccsmessageobjectjiter = sccsmessage.sc_message_object_jitter;

using ISCCS_Jitter_Interface = Jitter.ISCCS_Jitter_Interface;
using Jitter;

using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using sccsr16;

namespace sccs
{


    //public abstract class Direct2DComponent : DirectXComponent
    public abstract class sccsupdate : sccsdirectx
    {
        sccsgraphicssec sccsgraphicssec;
        IntPtr HWND;
        DateTime startTime;

        public sccsupdate()
        {

        }
    












        protected override sccsmessageobjectjiter[][] initscriptvariables(sccsmessageobjectjiter[][] _sc_jitter_tasks)
        {
            try
            {
                startTime = DateTime.Now;
                //HWND = hwnd;

  
                //_sc_jitter_tasks = sccsgraphicssec._sc_create_world_objects(_sc_jitter_tasks);
            }
            catch
            {

            }
            return _sc_jitter_tasks;
        }




        protected override sccsmessageobjectjiter[][] Update(jitter_sc[] jitter_sc, sccsmessageobjectjiter[][] _sc_jitter_tasks)
        {


            // Render the graphics scene.
            try
            {
                _sc_jitter_tasks = _FrameVRTWO(jitter_sc, _sc_jitter_tasks);
            }
            catch (Exception ex)
            {
                sccsr16.Program.MessageBox((IntPtr)0, "" + ex.ToString(), "sc core systems message", 0);
            }

            return _sc_jitter_tasks;
        }

        private unsafe sccsmessageobjectjiter[][] _FrameVRTWO(jitter_sc[] jitter_sc, sccsmessageobjectjiter[][] _sc_jitter_tasks)
        {
            
            return _sc_jitter_tasks;
        }





    protected override void ShutDownGraphics()
    {

    }

    public void ShutDown()
    {
    }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
    }



}

