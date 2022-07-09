using Deer;
/// <summary>
/// �Զ������
/// </summary>
public partial class GameEntry
{
    /// <summary>
    /// ��ȡ��Ϸ�������
    /// </summary>
    public static GameSettingsComponent GameSettings
    {
        get;
        private set;
    }

    /// <summary>
    /// Lua���
    /// </summary>
    public static LuaComponent Lua
    {
        get;
        private set;
    }

    /// <summary>
    /// �¼����
    /// </summary>
    public static MessengerComponent Messenger
    {
        get;
        private set;
    }

    /// <summary>
    /// Config���
    /// </summary>
    public static ConfigComponent Config
    {
        get;
        private set;
    }

    /// <summary>
    /// Camera���
    /// </summary>
    public static CameraComponent Camera
    {
        get;
        private set;
    }

    /// <summary>
    /// UI���
    /// </summary>
    public static DeerUIComponent UI
    {
        get;
        private set;
    }
    /// <summary>
    /// AssetObject���
    /// </summary>
    public static AssetObjectComponent AssetObject
    {
        get;
        private set;
    }
    // ע���Զ�������
    private static void InitCustomComponents()
    {
        GameSettings = UnityGameFramework.Runtime.GameEntry.GetComponent<GameSettingsComponent>();
        Lua = UnityGameFramework.Runtime.GameEntry.GetComponent<LuaComponent>();
        Messenger = UnityGameFramework.Runtime.GameEntry.GetComponent<MessengerComponent>();
        Config = UnityGameFramework.Runtime.GameEntry.GetComponent<ConfigComponent>();
        Camera = UnityGameFramework.Runtime.GameEntry.GetComponent<CameraComponent>();
        UI = UnityGameFramework.Runtime.GameEntry.GetComponent<DeerUIComponent>();
        AssetObject = UnityGameFramework.Runtime.GameEntry.GetComponent<AssetObjectComponent>();
    }
}