using UnityEngine;
using UnityEngine.UI;

public class CloseApplication : MonoBehaviour
{
    public Button closeButton;

    void Start()
    {
        closeButton.onClick.AddListener(CloseApp);
    }

    public void CloseApp()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Ferme l'application dans l'éditeur Unity
        #else
        Application.Quit(); // Ferme l'application dans un build exécutable
        #endif
    }
}
