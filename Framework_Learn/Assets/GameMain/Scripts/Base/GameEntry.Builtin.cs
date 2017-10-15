using System.Diagnostics;
public partial class GameEntry
{
    public static int Base
    {
        get;
        private set;
    }

    private string DebugContent = string.Empty;

    private void InitBuiltinComponents()
    {
        Base = 233;
        UnityEngine.Debug.LogFormat("Base = {0}", Base);
        DebugLogTest("Debug Only");
    }

    private void OnGUI()
    {
        UnityEngine.GUILayout.Label("Begin:");
        UnityEngine.GUILayout.Label(m_DebugContent);
    }

    private string m_DebugContent = string.Empty;

    [Conditional("DEBUG")]
    public void DebugLogTest(string content)
    {
        m_DebugContent = content;
    }
}
