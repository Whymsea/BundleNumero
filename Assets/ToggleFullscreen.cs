using UnityEngine;
using UnityEngine.UI;

public class ToggleFullscreen : MonoBehaviour
{
    public Button toggleButton;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleFullscreenMode);
    }

    public void ToggleFullscreenMode()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
