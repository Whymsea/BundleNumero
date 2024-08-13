using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActiverDesactiverObjetsOnClick : MonoBehaviour
{
    public GameObject numerologie;
    public GameObject matrice;
    public GameObject matriceSignifications;
    public GameObject debut;
    public TMP_InputField[] champsDeTexte;

    private void Start()
    {
        // Désactiver les deux GameObjects au démarrage
        numerologie.SetActive(false);
        matrice.SetActive(false);
        matriceSignifications.SetActive(false);
        debut.SetActive(true);
    }

    public void ChampsRemplisDebut()
    {
        bool tousChampsRemplis = true;

        // Vérifier si tous les champs de texte sont remplis
        foreach (TMP_InputField champ in champsDeTexte)
        {
            if (string.IsNullOrEmpty(champ.text))
            {
                tousChampsRemplis = false;
                break;
            }
        }

        // Activer ou désactiver le GameObject "debut" en fonction du remplissage des champs
        debut.SetActive(!tousChampsRemplis);
        // Activer ou désactiver le GameObject "matrice" en fonction du remplissage des champs
        matrice.SetActive(tousChampsRemplis);
    }

    public void ActiverDesactiverObjets()
    {
        // Vérifie si les GameObjects sont actuellement actifs ou désactivés
        bool numEstActif = numerologie.activeSelf;

        // Inverser l'état d'activation/désactivation de numerologie
        numerologie.SetActive(!numEstActif);
        // Activer ou désactiver le GameObject "matrice" en fonction de l'état de "numerologie"
        matrice.SetActive(numEstActif);
    }
}
