using GameFramework;
using UnityGameFramework.Runtime;

namespace Framework_Learn
{
    public partial class GameEntry
    {
        public static int Base
        {
            get;
            private set;
        }

        private void InitBuiltinComponents()
        {
            Log.Debug("This is debug log.");
            LogHelper login = new LogHelper();
            login.Log(LogLevel.Info, "ssss");
        }
    }
}

