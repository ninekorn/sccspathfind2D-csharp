using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using sccsmessage = sccsmessage.sc_message_object;
using sccsmessagejitter = sccsmessage.sc_message_object_jitter;

using SharpDX;
using SharpDX.DXGI;
using SharpDX.Direct2D1;
using SharpDX.Direct3D11;
using Device = SharpDX.Direct3D11.Device;
using Resource = SharpDX.Direct3D11.Resource;

namespace sccs
{
    public abstract class sccsdirectx //: ISCCS_Jitter_Interface
    {

        public int canworkphysics = 0;
        public abstract sccsmessagejitter[][] initscriptvariables(sccsmessagejitter[][] _sc_jitter_tasks); //void Update();
        public abstract sccsmessagejitter[][] createworldobjects(sccsmessagejitter[][] _sc_jitter_tasks);
        public abstract sccsmessagejitter[][] Update( sccsmessagejitter[][] _sc_jitter_tasks); //void Update();
        protected abstract sccsmessagejitter[][] writetobuffer(sccsmessagejitter[][] _sc_jitter_tasks);
        protected abstract sccsmessagejitter[][] looprigidbody(sccsmessagejitter[][] _sc_jitter_tasks);
        protected abstract sccsmessagejitter[][] workOnSomething(sccsmessagejitter[][] _sc_jitter_tasks);
      
        protected abstract void ShutDownGraphics();


        public virtual void startrenderdirectx()
        {
            if (D3D != null)
            {
                if (DepthStencilView != null)
                {
                    //Console.WriteLine("DepthStencilView != null");
                    DeviceContext.ClearDepthStencilView(DepthStencilView, SharpDX.Direct3D11.DepthStencilClearFlags.Depth, 1.0f, 0); //new SharpDX.Color(255, 15, 15, 255)

                }
                if (RenderTargetView != null)
                {
                    //Console.WriteLine("RenderTargetView != null");
                    DeviceContext.ClearRenderTargetView(RenderTargetView, SharpDX.Color.LightGray); //SharpDX.Color.LightGray //Black //new SharpDX.Color(255, 15,

                }
            }
        }

        public virtual void stoprenderdirectx()
        {
            if (D3D != null)
            {
                if (SwapChain != null)
                {
                    SwapChain.Present(0, SharpDX.DXGI.PresentFlags.None);
                }
            }
        }




        public virtual void startrenderdirectxovr() //threaddata[][] arrayofthreaddata //threaddata[][]
        {
            if (D3D != null)
            {

                canworkphysics = 1;
            }
        }





        public virtual void stoprenderdirectxovr()
        {
            if (D3D != null)
            {
                
            }

        }

        /*
        protected override sealed void Initialize()
        {
            InternalInitialize();

            Rendering = true;
            CompositionTarget.Rendering += OnCompositionTargetRendering;
        }

        protected override sealed void Uninitialize()
        {
            Rendering = false;
            CompositionTarget.Rendering -= OnCompositionTargetRendering;

            InternalUninitialize();
        }
        private void OnCompositionTargetRendering(object sender, EventArgs eventArgs)
        {
            if (!Rendering)
                return;

            try
            {
                BeginRender();
                Render();
                EndRender();
            }
            catch (SharpDXException e)
            {
                if (e.HResult == HResults.D2DERR_RECREATE_TARGET || e.HResult == HResults.DXGI_ERROR_DEVICE_REMOVED)
                {
                    Uninitialize();
                    Initialize();
                }
                else throw;
            }
        }

        private double GetDpiScale()
        {
            PresentationSource source = PresentationSource.FromVisual(this);

            return source.CompositionTarget.TransformToDevice.M11;
        }

        /// <summary>
        /// Create required DirectX resources.
        /// Derived calls should begin with base.InternalInitialize()
        /// </summary>
        protected virtual void InternalInitialize()
        {
            var dpiScale = GetDpiScale();
            SurfaceWidth = (int)(ActualWidth < 0 ? 0 : Math.Ceiling(ActualWidth * dpiScale));
            SurfaceHeight = (int)(ActualHeight < 0 ? 0 : Math.Ceiling(ActualHeight * dpiScale));

            var swapChainDescription = new SwapChainDescription
            {
                OutputHandle = Hwnd,
                BufferCount = 1,
                Flags = SwapChainFlags.AllowModeSwitch,
                IsWindowed = true,
                ModeDescription = new ModeDescription(SurfaceWidth, SurfaceHeight, new Rational(60, 1), Format.B8G8R8A8_UNorm),
                SampleDescription = new SampleDescription(1, 0),
                SwapEffect = SwapEffect.Discard,
                Usage = Usage.RenderTargetOutput | Usage.Shared
            };

            SharpDX.Direct3D11.Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.BgraSupport, swapChainDescription, out _device, out _swapChain);

            // Ignore all windows events
            using (var factory = _swapChain.GetParent<Factory>())
            {
                factory.MakeWindowAssociation(Hwnd, WindowAssociationFlags.IgnoreAll);
            }

            // New RenderTargetView from the backbuffer
            _backBuffer = Resource.FromSwapChain<Texture2D>(_swapChain, 0);
            _renderTargetView = new RenderTargetView(_device, _backBuffer);
        }

        /// <summary>
        /// Destory all DirectX resources.
        /// Derived methods should end with base.InternalUninitialize();
        /// </summary>
        protected virtual void InternalUninitialize()
        {
            Utilities.Dispose(ref _renderTargetView);
            Utilities.Dispose(ref _backBuffer);
            Utilities.Dispose(ref _swapChain);

            // This is a workaround for an issue in SharpDx3.0.2 (https://github.com/sharpdx/SharpDX/issues/731)
            // Will need to be removed when fixed in next SharpDx release
            ((IUnknown)_device).Release();
            Utilities.Dispose(ref _device);

            GC.Collect(2, GCCollectionMode.Forced);
        }

        /// <summary>
        /// Begin render.
        /// Derived methods should begin with base.BeginRender()
        /// </summary>
        protected virtual void BeginRender()
        {
            _device.ImmediateContext.Rasterizer.SetViewport(0, 0, (float)ActualWidth, (float)ActualHeight);
            _device.ImmediateContext.OutputMerger.SetRenderTargets(_renderTargetView);
        }

        /// <summary>
        /// Finish render.
        /// Derived methods must call base.EndRender() 
        /// </summary>
        protected virtual void EndRender()
        {
            _swapChain.Present(1, PresentFlags.None);
        }

        /// <summary>
        /// Perform render.
        /// </summary>
        protected abstract void Render();
        */



        //OVR VARIABLES 
        /*public Matrix tempmatter;
        double displayMidpoint;
        TrackingState trackingState;
        Posef[] eyePoses;
        EyeType eye;
        public EyeTexture eyeTexture;
        bool latencyMark = false;
        TrackingState trackState;
        PoseStatef poseStatefer;
        Posef hmdPose;
        Quaternionf hmdRot;
        public Vector3 _hmdPoser;
        Quaternion _hmdRoter;
        public Matrix hmd_matrix;
        Matrix hmd_matrix_test;
        public SharpDX.Matrix finalRotationMatrix;*/

        public Vector3 lookUp;
        public Vector3 lookAt;

        Matrix _projectionMatrix;
        Matrix hmd_matrix_current = Matrix.Identity;
        Matrix hmdmatrixcurrentforpelvis = Matrix.Identity;
        public Vector3 viewpositionorigin = Vector3.Zero;
        public Vector3 viewPosition;

        public Matrix oriProjectionMatrix;

        public SharpDX.Matrix hmdmatrixRot = SharpDX.Matrix.Identity;
        public SharpDX.Matrix originRot = SharpDX.Matrix.Identity;
        public SharpDX.Matrix rotatingMatrixForPelvis = SharpDX.Matrix.Identity;
        public SharpDX.Matrix rotatingMatrix = SharpDX.Matrix.Identity;
        Quaternion quatt;
        public static Vector4 dirikvoxelbodyInstanceRight0;
        public static Vector4 dirikvoxelbodyInstanceUp0;
        public static Vector4 dirikvoxelbodyInstanceForward0;
        public static double RotationY4Pelvis;
        public static double RotationX4Pelvis;
        public static double RotationZ4Pelvis;
        public static double RotationY4PelvisTwo;
        public static double RotationX4PelvisTwo;
        public static double RotationZ4PelvisTwo;
        public static double RotationGrabbedYOff;
        public static double RotationGrabbedXOff;
        public static double RotationGrabbedZOff;
        public static double RotationGrabbedY;
        public static double RotationGrabbedX;
        public static double RotationGrabbedZ;
        public static double Rotationscreenx;
        public static double Rotationscreeny;
        public static double Rotationscreenz;
        double RotationX;
        double RotationY;
        double RotationZ;
        double RotationOriginX;
        double RotationOriginY;
        double RotationOriginZ;
        Matrix rotatingMatrixForGrabber;
        //OVR VARIABLES


    

        public static sccsdirectx D3D;






        //SHARPDX DIRECTX VARIABLES
        //SHARPDX DIRECTX VARIABLES
        //SHARPDX DIRECTX VARIABLES
        public int SurfaceWidth;
        public int SurfaceHeight;
        public DateTime startTime;
        private Adapter1 adapter;
        private Adapter1 _adapter;
        private Output monitor;
        private SharpDX.DXGI.Factory1 factory;
        public appconfiguration appconfiguration;
        public SharpDX.Direct3D11.Device Device;
        public SharpDX.Direct3D11.DeviceContext DeviceContext;
        public SharpDX.DXGI.SwapChain SwapChain;
        public SharpDX.Viewport viewport;
        public Texture2D BackBuffer;
        public RenderTargetView RenderTargetView;
        Texture2D DepthStencilBuffer;
        public DepthStencilView DepthStencilView;
        public Matrix ProjectionMatrix;
        public Matrix WorldMatrix = Matrix.Identity;
        public RasterizerState RasterState;
        public DepthStencilState DepthStencilState;
        public Matrix OrthoMatrix;
        public DepthStencilState DepthDisabledStencilState;
        public BlendState AlphaEnableBlendingState;
        public BlendState AlphaDisableBlendingState;
        //SHARPDX DIRECTX VARIABLES
        //SHARPDX DIRECTX VARIABLES
        //SHARPDX DIRECTX VARIABLES


        //SHARPDX DEFERRED RENDERING VARIABLES
        //SHARPDX DEFERRED RENDERING VARIABLES
        //SHARPDX DEFERRED RENDERING VARIABLES
        //public State currentState;
        //public State nextState;
        /*public SharpDX.Direct3D11.DeviceContext[] deferredContexts;
        public SharpDX.Direct3D11.DeviceContext[] contextPerThread;
        public SharpDX.Direct3D11.CommandList[] commandsList;
        public SharpDX.Direct3D11.CommandList[] frozenCommandLists;
        public bool supportConcurentResources;
        public bool supportCommandList;
        public enum TestType
        {
            Immediate = 0,
            Deferred = 1,
            FrozenDeferred = 2
        }
        public struct State
        {
            public bool Exit;
            public int CountCubes;
            public int ThreadCount;
            public TestType Type;
            public bool SimulateCpuUsage;
            public bool UseMap;
        }
        public int MaxNumberOfCubes = 1024;
        public const int MaxNumberOfThreads = 16;
        public const int BurnCpuFactor = 50;*/
        //SHARPDX DEFERRED RENDERING VARIABLES
        //SHARPDX DEFERRED RENDERING VARIABLES
        //SHARPDX DEFERRED RENDERING VARIABLES

        public IntPtr apphandle;



        // Constructor
        /*public SC_console_directx()
        {

        }*/

        protected sccsdirectx() //DSystemConfiguration configuration, IntPtr Hwnd, sc_console.sc_console_writer _writer
        {
            D3D = this;
            //Update();
            sccsinitdirectX(); //configuration, Hwnd, _writer 
        }



        protected virtual void sccsinitdirectX() //DSystemConfiguration configuration, IntPtr Hwnd, sc_console.sc_console_writer _writer
        {
            D3D = this;

            apphandle = sccsr16.Form1.theHandle;

            Console.WriteLine("sccsinitdirectX begin => apphandle " + apphandle);

            appconfiguration = new appconfiguration(false);

            startTime = DateTime.Now;
            //var dpiScale = GetDpiScale();

            using (var _factory = new SharpDX.DXGI.Factory1())
            {
                _adapter = _factory.GetAdapter1(0);

                using (var _output = _adapter.GetOutput(0))
                {
                    SurfaceWidth = ((SharpDX.Rectangle)_output.Description.DesktopBounds).Width;
                    SurfaceHeight = ((SharpDX.Rectangle)_output.Description.DesktopBounds).Height;
                }
            }





            if (sccsr16­.Program.useOculusRift == 0)
            {


                // Store the vsync setting.
                //VerticalSyncEnabled = SC_skYaRk_VR_V007.DSystemConfiguration.DSystemConfiguration.VerticalSyncEnabled;

                // Create a DirectX graphics interface factory.
                factory = new SharpDX.DXGI.Factory1();

                // Use the factory to create an adapter for the primary graphics interface (video card).
                adapter = factory.GetAdapter1(0);
                // Get the primary adapter output (monitor).
                monitor = adapter.GetOutput(0);

                // Get modes that fit the DXGI_FORMAT_R8G8B8A8_UNORM display format for the adapter output (monitor).
                var modes = monitor.GetDisplayModeList(Format.R8G8B8A8_UNorm, DisplayModeEnumerationFlags.Interlaced);

                // Now go through all the display modes and find the one that matches the screen width and height.
                // When a match is found store the the refresh rate for that monitor, if vertical sync is enabled. 
                // Otherwise we use maximum refresh rate.
                var rational = new Rational(0, 1);
                if (appconfiguration.verticalsync)
                {
                    foreach (var mode in modes)
                    {
                        if (mode.Width == SurfaceWidth && mode.Height == SurfaceHeight)
                        {
                            rational = new Rational(mode.RefreshRate.Numerator, mode.RefreshRate.Denominator);
                            break;
                        }
                    }
                }


                // Get the adapter (video card) description.
                //var adapterDescription = adapter.Description;

                // Store the dedicated video card memory in megabytes.
                //VideoCardMemory = adapterDescription.DedicatedVideoMemory >> 10 >> 10;

                // Convert the name of the video card to a character array and store it.
                //VideoCardDescription = adapterDescription.Description.Trim('\0');

                // Release the adapter output.
                monitor.Dispose();
                // Release the adapter.
                adapter.Dispose();
                // Release the factory.
                //factory.Dispose();


                // Initialize the swap chain description.
                /*swapChainDesc = new SwapChainDescription()
                {
                    // Set to a single back buffer.
                    BufferCount = 1,
                    // Set the width and height of the back buffer.
                    ModeDescription = new ModeDescription(SurfaceWidth, SurfaceHeight, rational, Format.R8G8B8A8_UNorm),
                    // Set the usage of the back buffer.
                    Usage = Usage.RenderTargetOutput,
                    // Set the handle for the window to render to.
                    OutputHandle = sccsr14sc.Form1.theHandle,
                    // Turn multisampling off.
                    SampleDescription = new SampleDescription(1, 0),
                    // Set to full screen or windowed mode.
                    IsWindowed = true, // !SC_skYaRk_VR_V007.DSystemConfiguration.DSystemConfiguration.FullScreen,
                    // Don't set the advanced flags.
                    Flags = SwapChainFlags.None,
                    // Discard the back buffer content after presenting.
                    SwapEffect = SwapEffect.Discard
                };*/


                var swapChainDesc = new SwapChainDescription
                {
                    BufferCount = 2, // 2
                    Flags = SwapChainFlags.None,
                    IsWindowed = true,
                    ModeDescription = new ModeDescription(SurfaceWidth, SurfaceHeight, new Rational(60, 1), Format.B8G8R8A8_UNorm),
                    OutputHandle = apphandle,
                    SampleDescription = new SampleDescription(1, 0),
                    SwapEffect = SwapEffect.Discard,
                    Usage = Usage.RenderTargetOutput
                };



                //SharpDX.Direct3D11.Device.CreateWithSwapChain(SharpDX.Direct3D.DriverType.Hardware, DeviceCreationFlags.BgraSupport, swapChainDesc, out someDevice, out someswap);
                SharpDX.Direct3D11.Device.CreateWithSwapChain(SharpDX.Direct3D.DriverType.Hardware, DeviceCreationFlags.None, swapChainDesc, out Device, out SwapChain);

                DeviceContext = Device.ImmediateContext;







                // Get the pointer to the back buffer.
                BackBuffer = Texture2D.FromSwapChain<Texture2D>(SwapChain, 0);

                // Create the render target view with the back buffer pointer.
                RenderTargetView = new RenderTargetView(Device, BackBuffer);

                // Release pointer to the back buffer as we no longer need it.
                BackBuffer.Dispose();





                #region
                // Initialize and set up the description of the depth buffer.
                var depthBufferDesc = new Texture2DDescription()
                {
                    Width = SurfaceWidth,
                    Height = SurfaceHeight,
                    MipLevels = 1,
                    ArraySize = 1,
                    Format = Format.D24_UNorm_S8_UInt,
                    SampleDescription = new SampleDescription(1, 0),
                    Usage = ResourceUsage.Default,
                    BindFlags = BindFlags.DepthStencil,
                    CpuAccessFlags = CpuAccessFlags.None,
                    OptionFlags = ResourceOptionFlags.None
                };

                // Create the texture for the depth buffer using the filled out description.
                DepthStencilBuffer = new Texture2D(Device, depthBufferDesc);
                #endregion

                #region Initialize Depth Enabled Stencil
                // Initialize and set up the description of the stencil state.
                var depthStencilDesc = new DepthStencilStateDescription()
                {
                    IsDepthEnabled = true,
                    DepthWriteMask = DepthWriteMask.All,
                    DepthComparison = Comparison.Less,
                    IsStencilEnabled = true,
                    StencilReadMask = 0xFF,
                    StencilWriteMask = 0xFF,
                    // Stencil operation if pixel front-facing.
                    FrontFace = new DepthStencilOperationDescription()
                    {
                        FailOperation = StencilOperation.Keep,
                        DepthFailOperation = StencilOperation.Increment,
                        PassOperation = StencilOperation.Keep,
                        Comparison = Comparison.Always
                    },
                    // Stencil operation if pixel is back-facing.
                    BackFace = new DepthStencilOperationDescription()
                    {
                        FailOperation = StencilOperation.Keep,
                        DepthFailOperation = StencilOperation.Decrement,
                        PassOperation = StencilOperation.Keep,
                        Comparison = Comparison.Always
                    }
                };

                // Create the depth stencil state.
                DepthStencilState = new DepthStencilState(Device, depthStencilDesc);
                #endregion

                #region Initialize Output Merger
                // Set the depth stencil state.
                DeviceContext.OutputMerger.SetDepthStencilState(DepthStencilState, 1);

                // Initialize and set up the depth stencil view.
                var depthStencilViewDesc = new DepthStencilViewDescription()
                {
                    Format = Format.D24_UNorm_S8_UInt,
                    Dimension = DepthStencilViewDimension.Texture2D,
                    Texture2D = new DepthStencilViewDescription.Texture2DResource()
                    {
                        MipSlice = 0
                    }
                };

                // Create the depth stencil view.
                DepthStencilView = new DepthStencilView(Device, DepthStencilBuffer, depthStencilViewDesc);

                // Bind the render target view and depth stencil buffer to the output render pipeline.
                DeviceContext.OutputMerger.SetTargets(DepthStencilView, RenderTargetView);
                #endregion

                #region Initialize Raster State
                // Setup the raster description which will determine how and what polygon will be drawn.
                var rasterDesc = new RasterizerStateDescription()
                {
                    IsAntialiasedLineEnabled = false,
                    CullMode = CullMode.Back,
                    DepthBias = 0,
                    DepthBiasClamp = .0f,
                    IsDepthClipEnabled = true,
                    FillMode = SharpDX.Direct3D11.FillMode.Solid,
                    IsFrontCounterClockwise = false,
                    IsMultisampleEnabled = false,
                    IsScissorEnabled = false,
                    SlopeScaledDepthBias = .0f
                };

                // Create the rasterizer state from the description we just filled out.
                RasterState = new RasterizerState(Device, rasterDesc);
                #endregion

                #region Initialize Rasterizer
                // Now set the rasterizer state.
                DeviceContext.Rasterizer.State = RasterState;

                // Setup and create the viewport for rendering.
                //DeviceContext.Rasterizer.SetViewport(0, 0, SurfaceWidth, SurfaceHeight, 0, 1);
                #endregion





                #region Initialize matrices
                // Setup and create the projection matrix.
                //ProjectionMatrix = Matrix.PerspectiveFovLH((float)(Math.PI / 4), ((float)SurfaceWidth / (float)SurfaceHeight), appconfiguration.ScreenNear, appconfiguration.ScreenDepth);

                // Initialize the world matrix to the identity matrix.
                //WorldMatrix = Matrix.Identity;

                // Create an orthographic projection matrix for 2D rendering.
                OrthoMatrix = Matrix.OrthoLH(SurfaceWidth, SurfaceHeight, appconfiguration.ScreenNear, appconfiguration.ScreenDepth);
                #endregion

                #region Initialize Depth Disabled Stencil
                // Now create a second depth stencil state which turns off the Z buffer for 2D rendering. Added in Tutorial 11
                // The difference is that DepthEnable is set to false.
                // All other parameters are the same as the other depth stencil state.
                var depthDisabledStencilDesc = new DepthStencilStateDescription()
                {
                    IsDepthEnabled = false,
                    DepthWriteMask = DepthWriteMask.All,
                    DepthComparison = Comparison.Less,
                    IsStencilEnabled = true,
                    StencilReadMask = 0xFF,
                    StencilWriteMask = 0xFF,
                    // Stencil operation if pixel front-facing.
                    FrontFace = new DepthStencilOperationDescription()
                    {
                        FailOperation = StencilOperation.Keep,
                        DepthFailOperation = StencilOperation.Increment,
                        PassOperation = StencilOperation.Keep,
                        Comparison = Comparison.Always
                    },
                    // Stencil operation if pixel is back-facing.
                    BackFace = new DepthStencilOperationDescription()
                    {
                        FailOperation = StencilOperation.Keep,
                        DepthFailOperation = StencilOperation.Decrement,
                        PassOperation = StencilOperation.Keep,
                        Comparison = Comparison.Always
                    }
                };

                // Create the depth stencil state.
                DepthDisabledStencilState = new DepthStencilState(Device, depthDisabledStencilDesc);
                #endregion

                #region Initialize Blend States
                // Create an alpha enabled blend state description.
                var blendStateDesc = new BlendStateDescription();
                blendStateDesc.RenderTarget[0].IsBlendEnabled = true;
                blendStateDesc.RenderTarget[0].SourceBlend = BlendOption.One;
                blendStateDesc.RenderTarget[0].DestinationBlend = BlendOption.InverseSourceAlpha;
                blendStateDesc.RenderTarget[0].BlendOperation = SharpDX.Direct3D11.BlendOperation.Add;
                blendStateDesc.RenderTarget[0].SourceAlphaBlend = BlendOption.One;
                blendStateDesc.RenderTarget[0].DestinationAlphaBlend = BlendOption.Zero;
                blendStateDesc.RenderTarget[0].AlphaBlendOperation = SharpDX.Direct3D11.BlendOperation.Add;
                blendStateDesc.RenderTarget[0].RenderTargetWriteMask = ColorWriteMaskFlags.All;

                // Create the blend state using the description.
                AlphaEnableBlendingState = new BlendState(Device, blendStateDesc);

                // Modify the description to create an disabled blend state description.
                blendStateDesc.RenderTarget[0].IsBlendEnabled = false;

                // Create the blend state using the description.
                AlphaDisableBlendingState = new BlendState(Device, blendStateDesc);
                #endregion


















                viewport = new Viewport(0, 0, SurfaceWidth, SurfaceHeight, 0.0f, 1.0f);


                // Setup and create the viewport for rendering.
                DeviceContext.Rasterizer.SetViewport(viewport);

                // Setup and create the projection matrix.
                ProjectionMatrix = SharpDX.Matrix.PerspectiveFovLH((float)(Math.PI / 4), ((float)SurfaceWidth / (float)SurfaceHeight), 0.1f, 1000.0f);

                // Initialize the world matrix to the identity matrix.
                WorldMatrix = SharpDX.Matrix.Identity;
            }
            else if (sccsr16­.Program.useOculusRift == 1)
            {
                WorldMatrix = SharpDX.Matrix.Identity;

                DeviceContext.ClearState();
                DeviceContext.Flush();
            }
        }



        public void ShutDown()
        {

            ShutDownGraphics();
        }






        public enum BodyTag
        {

            DrawMe,
            DontDrawMe,
            Terrain,
            pseudoCloth,


            PlayerHandLeft,
            PlayerHandRight,
            PlayerShoulderLeft,
            PlayerShoulderRight,
            PlayerTorso,
            PlayerPelvis,
            PlayerUpperArmLeft,
            PlayerLowerArmLeft,
            PlayerUpperArmRight,
            PlayerLowerArmRight,
            PlayerUpperLegLeft,
            PlayerLowerLegLeft,
            PlayerUpperLegRight,
            PlayerLowerLegRight,
            PlayerFootRight,
            PlayerFootLeft,
            PlayerHead,
            PlayerLeftElbowTarget,
            PlayerRightHandGrabTarget,
            PlayerLeftHandGrabTarget,

            PlayerRightElbowTarget,
            PlayerLeftElbowTargettwo,
            PlayerRightElbowTargettwo,
            PlayerLeftTargetKnee,
            PlayerRightTargetKnee,
            PlayerLeftTargettwoKnee,
            PlayerRightTargettwoKnee,


            sc_containment_grid,
            sc_grid,

            Screen,
            sc_jitter_cloth,
            //someothertest,
            //testChunkCloth,
            //cloth_cube,
            //screen_corners,
            //screen_pointer_touch,
            //screen_pointer_HMD,
            _terrain_tiles,
            _terrain,
            _floor,
            //_icosphere,
            //_sphere,
            _spectrum,
            //_physics_cube_group_b,
            _screen_assets,


            physicsInstancedCube,
            physicsInstancedCone,
            physicsInstancedCylinder,
            physicsInstancedCapsule,
            physicsInstancedSphere,

            sc_perko_voxel,
            physicsInstancedScreen,
            sc_perko_voxel_planet_chunk,
        }




        /*
        public jitter_sc sc_create_jitter_instances(sc_jitter_data _sc_jitter_data)
        {
            return Instance;
        }



        static jitter_sc instance = null;

        public static jitter_sc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new jitter_sc();

                }
                return instance;
            }
        }*/




        public void TurnOnAlphaBlending(SharpDX.Direct3D11.DeviceContext someDevicecontext)
        {
            // Setup the blend factor.
            var blendFactor = new Color4(0, 0, 0, 0);

            // Turn on the alpha blending.
            someDevicecontext.OutputMerger.SetBlendState(AlphaEnableBlendingState, blendFactor, -1);
        }
        public void TurnOffAlphaBlending(SharpDX.Direct3D11.DeviceContext someDevicecontext)
        {
            // Setup the blend factor.
            var blendFactor = new Color4(0, 0, 0, 0);

            // Turn on the alpha blending.
            someDevicecontext.OutputMerger.SetBlendState(AlphaDisableBlendingState, blendFactor, -1);
        }
        public void TurnZBufferOn(SharpDX.Direct3D11.DeviceContext someDevicecontext)
        {
            someDevicecontext.OutputMerger.SetDepthStencilState(DepthStencilState, 1);
        }
        public void TurnZBufferOff(SharpDX.Direct3D11.DeviceContext someDevicecontext)
        {
            someDevicecontext.OutputMerger.SetDepthStencilState(DepthDisabledStencilState, 1);
        }

















        ~sccsdirectx()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // so that Dispose(false) isn't called later
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                SurfaceWidth = 0;
                SurfaceHeight = 0;
                //startTime = null;

                if (adapter != null)
                {
                    adapter.Dispose();
                    adapter = null;
                }

                if (appconfiguration != null)
                {
                    appconfiguration.Dispose();
                    appconfiguration = null;
                }

                if (Device != null)
                {
                    Device.Dispose();
                    Device = null;
                }

                if (DeviceContext != null)
                {
                    DeviceContext.Dispose();
                    DeviceContext = null;
                }

                if (SwapChain != null)
                {
                    SwapChain.Dispose();
                    SwapChain = null;
                }

                //cannot be null. cannot be disposed of.
                //if (viewport != null)
                //{
                //    viewport.Dispose();
                //    viewport = null;
                //}

                if (BackBuffer != null)
                {
                    BackBuffer.Dispose();
                    BackBuffer = null;
                }

                if (RenderTargetView != null)
                {
                    RenderTargetView.Dispose();
                    RenderTargetView = null;
                }

                if (DepthStencilBuffer != null)
                {
                    DepthStencilBuffer.Dispose();
                    DepthStencilBuffer = null;
                }

                if (DepthStencilView != null)
                {
                    DepthStencilView.Dispose();
                    DepthStencilView = null;
                }
                if (_adapter != null)
                {
                    _adapter.Dispose();
                    _adapter = null;
                }

                if (factory != null)
                {
                    factory.Dispose();
                    factory = null;
                }

                if (monitor != null)
                {
                    monitor.Dispose();
                    monitor = null;
                }

                OrthoMatrix = Matrix.Identity;

                if (RasterState != null)
                {
                    RasterState.Dispose();
                    RasterState = null;
                }

                if (DepthStencilState != null)
                {
                    DepthStencilState.Dispose();
                    DepthStencilState = null;
                }


                if (DepthDisabledStencilState != null)
                {
                    DepthDisabledStencilState.Dispose();
                    DepthDisabledStencilState = null;
                }


                if (AlphaEnableBlendingState != null)
                {
                    AlphaEnableBlendingState.Dispose();
                    AlphaEnableBlendingState = null;
                }


                if (AlphaDisableBlendingState != null)
                {
                    AlphaDisableBlendingState.Dispose();
                    AlphaDisableBlendingState = null;
                }












                ProjectionMatrix = Matrix.Zero;
                WorldMatrix = Matrix.Zero;


                /*
                private Adapter1 adapter;
                public appconfiguration appconfiguration;
                public SharpDX.Direct3D11.Device Device;
                public SharpDX.Direct3D11.DeviceContext DeviceContext;
                public SharpDX.DXGI.SwapChain SwapChain;
                public SharpDX.Viewport viewport;
                Texture2D BackBuffer;
                RenderTargetView RenderTargetView;
                Texture2D DepthStencilBuffer;
                DepthStencilView DepthStencilView;
                Matrix ProjectionMatrix;
                Matrix WorldMatrix;*/
                // Dispose all owned managed objects
            }

            // Release unmanaged resources
        }


        /*
        public jitter_sc[] create_jitter_instances(jitter_sc[] sc_jitter_physics, sc_jitter_data _sc_jitter_data)
        {
            for (int xx = 0; xx < sccsr16.Program.physicsengineinstancex; xx++)
            {
                for (int yy = 0; yy < sccsr16.Program.physicsengineinstancey; yy++)
                {
                    for (int zz = 0; zz < sccsr16.Program.physicsengineinstancez; zz++)
                    {
                        var indexer00 = xx + sccsr16.Program.physicsengineinstancex * (yy + sccsr16.Program.physicsengineinstancey * zz);
                        sc_jitter_physics[indexer00] = sc_create_jitter_instances(_sc_jitter_data);
                    }
                }
            }

            return sc_jitter_physics;
        }*/
    }
}
