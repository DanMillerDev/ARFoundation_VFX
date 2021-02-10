using UnityEngine;
using UnityEngine.Rendering;

public class VFXCompatibilityCheck : MonoBehaviour
{
    [SerializeField]
    GameObject m_NotSupportedUI;

    void Awake()
    {
        // currently VFX graph and AR Foundation are only supported on iOS with Metal 
        if (SystemInfo.graphicsDeviceType != GraphicsDeviceType.Metal)
        {
            m_NotSupportedUI.SetActive(true);
        }
    }
}