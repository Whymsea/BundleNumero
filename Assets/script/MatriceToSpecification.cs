using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatriceToSpecification : MonoBehaviour
{
    public GameObject matrice;
    public GameObject matriceSignifications;
    public GameObject global;

    public void ActiverDesactiverSignification()
    {
        // Vérifie si les GameObjects sont actuellement actifs ou désactivés
        bool numEstActif = matriceSignifications.activeSelf;

        // Inverser l'état d'activation/désactivation de numerologie
        matriceSignifications.SetActive(!numEstActif);
        // Activer ou désactiver le GameObject "matrice" en fonction de l'état de "numerologie"
        matrice.SetActive(numEstActif);
        global.SetActive(numEstActif);
    }
}
