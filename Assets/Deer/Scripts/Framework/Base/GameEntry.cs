using UnityEngine;

/// <summary>
/// ��Ϸ���
/// </summary>
public partial class GameEntry : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        InitBuiltinComponents();
        InitCustomComponents();
    }
}
