using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;

public class ScreenshotToPDF : MonoBehaviour
{
    public TMP_InputField fileNameInput;
    public GameObject NUMEROLOGIE; // GameObject pour Numérologie
    public GameObject MATRICE; // GameObject pour Matrice
    public GameObject SIGNIFICATION; // GameObject pour Matrice

    private string baseFileName; // Variable pour stocker le nom de fichier de base

    void Start()
    {
        // Enregistrez le nom de fichier de base lorsque le champ de texte change
        fileNameInput.onValueChanged.AddListener(UpdateBaseFileName);
    }

    public void CaptureScreenshotPNG()
    {
        // Utilisez le nom de fichier de base pour générer le nom du fichier PNG
        string screenshotType = GetScreenshotType();
        string screenshotName = baseFileName + screenshotType + ".png";

        // Capture de l'écran et enregistrement de la capture d'écran en tant que fichier PNG
        ScreenCapture.CaptureScreenshot(screenshotName);
    }

    void UpdateBaseFileName(string text)
    {
        baseFileName = text; // Mettez à jour le nom de fichier de base avec le texte actuel du champ de texte
    }

    string GetScreenshotType()
    {
        if (NUMEROLOGIE != null && NUMEROLOGIE.activeSelf)
        {
            return "Numero";
        }
        else if (MATRICE != null && MATRICE.activeSelf)
        {
            return "Matrice";
        }
        else if (SIGNIFICATION != null && SIGNIFICATION.activeSelf)
        {
            return "Signification";
        }
        else
        {
            return ""; // Retourne une chaîne vide par défaut
        }
    }
}
