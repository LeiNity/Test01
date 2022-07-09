using UnityEngine;

/// <summary>
/// сно╥хК©з
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
