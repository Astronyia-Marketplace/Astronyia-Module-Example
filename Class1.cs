using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astronyia_Loader;

namespace TestModule
{
    public class Main : AstronyiaModule
    {
        public static void INTIALIZE() //DONT DELETE THIS OR YOU MOD WILL NOT RUN!
        {
            AstronyiaModule.InvokeObject = new Main();
        }
        public override void OnApplicationStart()
        {
        }
        public override void OnApplicationQuit()
        {
        }
        public override void OnFixedUpdate()
        {
            
        }
        public override void OnGUI()
        {
        }
        public override void OnLateUpdate()
        {
        }
        public override void OnModSettingsApplied()
        {
        }
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
        }
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
        }
        public override void OnUIManagerInit()
        {
        }
        public override void OnUpdate()
        {
        }
    }
}
