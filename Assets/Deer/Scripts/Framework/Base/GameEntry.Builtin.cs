using UnityGameFramework.Runtime;

/// <summary>
/// Gf�������
/// </summary>
public partial class GameEntry
{
    /// <summary>
    /// ��ȡ��Ϸ�������
    /// </summary>
    public static BaseComponent Base
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ���ݽڵ����
    /// </summary>
    public static DataNodeComponent DataNode
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�������
    /// </summary>
    public static DebuggerComponent Debugger
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�������
    /// </summary>
    public static DownloadComponent Download
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡʵ�����
    /// </summary>
    public static EntityComponent Entity
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�¼����
    /// </summary>
    public static EventComponent Event
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�ļ�ϵͳ���
    /// </summary>
    public static FileSystemComponent FileSystem
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ����״̬�����
    /// </summary>
    public static FsmComponent Fsm
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�������
    /// </summary>
    public static NetworkComponent Network
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ��������
    /// </summary>
    public static ObjectPoolComponent ObjectPool
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ��Դ���
    /// </summary>
    public static ResourceComponent Resource
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�������
    /// </summary>
    public static SettingComponent Setting
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ���������
    /// </summary>
    public static SoundComponent Sound
    {
        get;
        private set;
    }
    /// <summary>
    /// ��ȡ���������
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
