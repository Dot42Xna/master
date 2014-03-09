using System;
using Microsoft.SPOT;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Threading;
using Grommet.Ext;

namespace Microsoft.Xna.Framework
{
    public class Game : IDisposable
    {
        private bool exit;
        private GameTime time;
        private DateTime lastUpdate;
        private DateTime startTime;
        private TimeSpan targetElapsedTime;
        private TimeSpan giveUpElapsedTime;
        private int updateCount = 0;

        //public GameComponentCollection Components { get; private set; }
        public ContentManager Content { get; set; }
        public GraphicsDevice GraphicsDevice { get; internal set; }
        public AudioDevice AudioDevice { get; internal set; }
        public TimeSpan InactiveSleepTime { get; set; }
        public bool IsActive { get; private set; }
        public bool IsFixedTimeStep { get; set; }
        public bool IsMouseVisible { get; set; }
        public GameServiceContainer Services { get; private set; }
        public GameWindow Window { get; private set; }

        public TimeSpan TargetElapsedTime 
        {
            get { return targetElapsedTime;}
            set { targetElapsedTime = value; } 
        }

        public Game()
        {
            this.Services = new GameServiceContainer();
            this.Content = new ContentManager(Services);
            this.Window = new GameWindow();
            this.time = new GameTime();
            this.time.ElapsedGameTime = TimeSpan.Zero;
            this.time.ElapsedRealTime = TimeSpan.Zero;
            this.IsActive = true;
            this.IsFixedTimeStep = true;
            this.TargetElapsedTime = TimeSpan.FromTicks(100 * TimeSpan.TicksPerMillisecond);
            this.giveUpElapsedTime = TimeSpan.FromTicks(2 * TimeSpan.TicksPerSecond);
        }

        protected virtual void Draw(GameTime gameTime)
        {
            GraphicsDevice.Present();
        }

        public void Exit()
        {
            exit = true;
        }

        protected virtual void Initialize()
        { 
        }

        protected virtual void LoadContent()
        { 
        }

        public void Run()
        {
            IGraphicsDeviceManager graphicsManager = (IGraphicsDeviceManager)Services.GetService(typeof(IGraphicsDeviceManager));
            if (GraphicsDevice == null)
            {
                graphicsManager.CreateDevice();
            }

            IAudioDeviceManager audioManager = (IAudioDeviceManager)Services.GetService(typeof(IAudioDeviceManager));
            if (audioManager != null && AudioDevice == null)
            {
                audioManager.CreateDevice();
            }

            Initialize();
            LoadContent();

            startTime = DateTime.Now;
            lastUpdate = startTime;
            time.IsRunningSlowly = true;

            while (!exit)
            {
                Tick();
            }

            UnloadContent();
        }

        public void Tick()
        {
            DateTime now;

            if (IsFixedTimeStep)
            {
                now = DateTime.Now;

                time.ElapsedRealTime = now - lastUpdate;
                time.TotalRealTime = now - startTime;
                time.ElapsedGameTime = targetElapsedTime;
                time.TotalGameTime += targetElapsedTime;

                lastUpdate = now;

                Update(time);

                time.IsRunningSlowly = ++updateCount < (int)(time.TotalRealTime.TotalSeconds() / targetElapsedTime.TotalSeconds());

                if (time.IsRunningSlowly)
                {
                    if (time.ElapsedGameTime > giveUpElapsedTime)
                    {
                        startTime += time.ElapsedGameTime;
                    }
                }
                else
                {
                    if ((DateTime.Now - lastUpdate) < targetElapsedTime)
                    {
                        Draw(time);

                        if ((DateTime.Now - lastUpdate) < targetElapsedTime)
                        {
                            Thread.Sleep((int)(targetElapsedTime - (DateTime.Now - now)).TotalMilliseconds());
                        }
                    }
                }
            }
            else
            {
                // variable time step
                now = DateTime.Now;

                time.ElapsedRealTime = now - lastUpdate;
                time.TotalRealTime = now - startTime;
                time.ElapsedGameTime = time.ElapsedRealTime;
                time.TotalGameTime = time.TotalRealTime;

                lastUpdate = now;

                Update(time);

                Draw(time);
            }
        }

        protected virtual void UnloadContent()
        { 
        }

        protected virtual void Update(GameTime gameTime)
        { 
        
        }


        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion
    }
}
