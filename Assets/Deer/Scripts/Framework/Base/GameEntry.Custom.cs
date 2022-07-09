using Deer;
/// <summary>
/// 自定义组件
/// </summary>
public partial class GameEntry
{
    /// <summary>
    /// 获取游戏设置组件
    /// </summary>
    public static GameSettingsComponent GameSettings
    {
        get;
        private set;
    }

    /// <summary>
    /// Lua组件
    /// </summary>
    public static LuaComponent Lua
    {
        get;
        private set;
    }

    /// <summary>
    /// 事件组件
    /// </summary>
    public static MessengerComponent Messenger
    {
        get;
        private set;
    }

    /// <summary>
    /// Config组件
    /// </summary>
    public static ConfigComponent Config
    {
        get;
        private set;
    }

    /// <summary>
    /// Camera组件
    /// </summary>
    public static CameraComponent Camera
    {
        get;
        private set;
    }

    /// <summary>
    /// UI组件
    /// </summary>
    public static DeerUIComponent UI
    {
        get;
        private set;
    }
    /// <summary>
    /// AssetObject组件
    /// </summary>
    public static AssetObjectComponent AssetObject
    {
        get;
        private set;
    }
    // 注册自定义的组件
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