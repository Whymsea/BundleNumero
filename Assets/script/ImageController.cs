using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageController : MonoBehaviour
{   //Image pour matrice
    public Image Imageapparence; // Composant Image où afficher l'image
    public Image ImageVisionDuMonde; // Composant Image où afficher l'image
    public Image ImageRessource; // Composant Image où afficher l'image
    public Image ImageCheminDeVie; // Composant Image où afficher l'image
    public Image ImagePassageOblige; // Composant Image où afficher l'image
    public Image ImageDifficulte; // Composant Image où afficher l'image
    public Image ImageMoteur; // Composant Image où afficher l'image
    public Image ImagePartLumineuse; // Composant Image où afficher l'image
    public Image ImagePointSensible; // Composant Image où afficher l'image
    public Image Imagemois; // Composant Image où afficher l'image
    public Image ImageapparenceSignification; // Composant Image où afficher l'image
    public Image ImageVisionDuMondeSignification; // Composant Image où afficher l'image
    public Image ImageRessourceSignification; // Composant Image où afficher l'image
    public Image ImageCheminDeVieSignification; // Composant Image où afficher l'image
    public Image ImagePassageObligeSignification; // Composant Image où afficher l'image
    public Image ImageDifficulteSignification; // Composant Image où afficher l'image
    public Image ImageMoteurSignification; // Composant Image où afficher l'image
    public Image ImagePartLumineuseSignification; // Composant Image où afficher l'image
    public Image ImagePointSensibleSignification; // Composant Image où afficher l'image
    public Image ImagemoisSignification; // Composant Image où afficher l'image
    public Sprite[] imagesMatrice; // Tableau des images Matrices correspondant aux nombres
    public Sprite[] imagesSignification;// Tableau des images Matrices et significations correspondant aux nombres
    public MatriceNumero matriceNumero; // Référence au script MatriceNumero

    void Start()
    {
        // Assurez-vous que la référence au script MatriceNumero est définie
        if (matriceNumero == null)
        {
            Debug.LogError("Référence à MatriceNumero non définie.");
            return;
        }
    }

    void Update()
    {
        //Pour la matrice
        AfficherImageMatrice(matriceNumero.apparence, Imageapparence); 
        AfficherImageMatrice(matriceNumero.VisionDuMonde, ImageVisionDuMonde); 
        AfficherImageMatrice(matriceNumero.Ressource, ImageRessource); 
        AfficherImageMatrice(matriceNumero.CheminDeVie, ImageCheminDeVie); 
        AfficherImageMatrice(matriceNumero.PassageOblige, ImagePassageOblige); 
        AfficherImageMatrice(matriceNumero.Difficulte, ImageDifficulte); 
        AfficherImageMatrice(matriceNumero.Moteur, ImageMoteur); 
        AfficherImageMatrice(matriceNumero.PartLumineuse, ImagePartLumineuse); 
        AfficherImageMatrice(matriceNumero.PointSensible, ImagePointSensible); 
        AfficherImageMatrice(matriceNumero.mois, Imagemois);

        //Pour les significations des cartes
        AfficherImageSignification(matriceNumero.apparence, ImageapparenceSignification); 
        AfficherImageSignification(matriceNumero.VisionDuMonde, ImageVisionDuMondeSignification); 
        AfficherImageSignification(matriceNumero.Ressource, ImageRessourceSignification); 
        AfficherImageSignification(matriceNumero.CheminDeVie, ImageCheminDeVieSignification); 
        AfficherImageSignification(matriceNumero.PassageOblige, ImagePassageObligeSignification); 
        AfficherImageSignification(matriceNumero.Difficulte, ImageDifficulteSignification); 
        AfficherImageSignification(matriceNumero.Moteur, ImageMoteurSignification); 
        AfficherImageSignification(matriceNumero.PartLumineuse, ImagePartLumineuseSignification); 
        AfficherImageSignification(matriceNumero.PointSensible, ImagePointSensibleSignification); 
        AfficherImageSignification(matriceNumero.mois, ImagemoisSignification);  
    }

    // Méthode pour afficher l'image correspondant au nombre donné
    public void AfficherImageMatrice(int nombreImage, Image imageDisplay)
    {
        // Ajuster le nombre pour qu'il corresponde à l'indice correct dans le tableau images
        int indiceImage = nombreImage - 1;

        if (indiceImage >= 0 && indiceImage < imagesMatrice.Length)
        {
            if (imageDisplay != null)
            {
                imageDisplay.sprite = imagesMatrice[indiceImage]; // Affiche l'image correspondant au nombre
            }
        }
        else
        {
            Debug.LogError("Aucune image associée à ce nombre."); // Affiche une erreur si aucune image n'est trouvée
        }
    }
    public void AfficherImageSignification(int nombreImage, Image imageDisplay)
    {
        int indiceImage = nombreImage - 1;

        if (indiceImage >= 0 && indiceImage < imagesSignification.Length)
        {
            if (imageDisplay != null)
            {
                imageDisplay.sprite = imagesSignification[indiceImage];
            }
        }
        else
        {
            Debug.LogError("Aucune image associée à ce nombre.");
        }
    }

}
