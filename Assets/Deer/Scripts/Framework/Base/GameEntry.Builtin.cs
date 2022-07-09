using UnityGameFramework.Runtime;

/// <summary>
/// Gf内置组件
/// </summary>
public partial class GameEntry
{
    /// <summary>
    /// 获取游戏基础组件
    /// </summary>
    public static BaseComponent Base
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取数据节点组件
    /// </summary>
    public static DataNodeComponent DataNode
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取调试组件
    /// </summary>
    public static DebuggerComponent Debugger
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取下载组件
    /// </summary>
    public static DownloadComponent Download
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取实体组件
    /// </summary>
    public static EntityComponent Entity
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取事件组件
    /// </summary>
    public static EventComponent Event
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取文件系统组件
    /// </summary>
    public static FileSystemComponent FileSystem
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取有限状态机组件
    /// </summary>
    public static FsmComponent Fsm
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取网络组件
    /// </summary>
    public static NetworkComponent Network
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取对象池组件
    /// </summary>
    public static ObjectPoolComponent ObjectPool
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取资源组件
    /// </summary>
    public static ResourceComponent Resource
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取配置组件
    /// </summary>
    public static SettingComponent Setting
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取声音组件。
    /// </summary>
    public static SoundComponent Sound
    {
        get;
        private set;
    }
    /// <summary>
    /// 获取场景组件。
    /// </summary>
    public static SceneComponent Scene
    {
        get;
        private set;
    }

    private static void InitBuiltinComponents()
    {
        Base = UnityGameFramework.Runtime.GameEntry.GetComponent<BaseComponent>();
        DataNode = UnityGameFramework.Runtime.GameEntry.GetComponent<DataNodeComponent>();
        Debugger = UnityGameFramework.Runtime.GameEntry.GetComponent<DebuggerComponent>();
        Entity = UnityGameFramework.Runtime.GameEntry.GetComponent<EntityComponent>();
        Event = UnityGameFramework.Runtime.GameEntry.GetComponent<EventComponent>();
        FileSystem = UnityGameFramework.Runtime.GameEntry.GetComponent<FileSystemComponent>();
        Fsm = UnityGameFramework.Runtime.GameEntry.GetComponent<FsmComponent>();
        Network = UnityGameFramework.Runtime.GameEntry.GetComponent<NetworkComponent>();
        ObjectPool = UnityGameFramework.Runtime.GameEntry.GetComponent<ObjectPoolComponent>();
        Resource = UnityGameFramework.Runtime.GameEntry.GetComponent<ResourceComponent>();
        Setting = UnityGameFramework.Runtime.GameEntry.GetComponent<SettingComponent>();
        Sound = UnityGameFramework.Runtime.GameEntry.GetComponent<SoundComponent>();
        Download = UnityGameFramework.Runtime.GameEntry.GetComponent<DownloadComponent>();
        Scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();
    }
}
