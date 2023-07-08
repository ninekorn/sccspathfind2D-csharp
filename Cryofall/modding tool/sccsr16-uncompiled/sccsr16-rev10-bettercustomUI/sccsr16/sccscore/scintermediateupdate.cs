using System;
using System.Collections.Generic;
using System.Text;
using SharpDX;
using SC_message_object = sccsmessage.sc_message_object;
using SC_message_object_jitter = sccsmessage.sc_message_object_jitter;
using Ab3d.OculusWrap;
using sccsr16;

namespace sccs
{
    public abstract class scintermediateupdate : sccsdirectx
    {
        protected override void sccsinitdirectX() //DSystemConfiguration configuration, IntPtr Hwnd, sc_console.sc_console_writer _writer
        {
            base.sccsinitdirectX(); //configuration, Hwnd, _writer
        }

        public abstract SC_message_object_jitter[][] sc_write_to_buffer(SC_message_object_jitter[][] _sc_jitter_tasks);
        public abstract SC_message_object_jitter[][] loop_worlds(SC_message_object_jitter[][] _sc_jitter_tasks);
        public abstract SC_message_object_jitter[][] workOnSomething(SC_message_object_jitter[][] _sc_jitter_tasks, Matrix viewMatrix, Matrix projectionMatrix, Vector3 OFFSETPOS, Matrix originRot, Matrix rotatingMatrix, Matrix rotatingMatrixForPelvis, Matrix _rightTouchMatrix, Matrix _leftTouchMatrix, Posef handPoseRight, Posef handPoseLeft);
        public abstract SC_message_object_jitter[][] _sc_create_world_objects(SC_message_object_jitter[][] _sc_jitter_tasks);

    }
}
