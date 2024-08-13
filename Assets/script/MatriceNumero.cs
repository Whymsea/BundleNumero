using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
    
public class MatriceNumero : MonoBehaviour
{
    //Tableau Maison
    public TextMeshProUGUI[] Maison1A9TextElement;

    //Text Input et text
    public TMP_InputField fileNameInput;
    public TMP_InputField InitialjourText;
    public TMP_InputField InitialmoisText;
    public TMP_InputField InitialanneeText;
    public TMP_InputField AnneeActuelText;
    public TextMeshProUGUI moisText;
    public TextMeshProUGUI ApparenceText;
    public TextMeshProUGUI VisionDuMondeText;
    public TextMeshProUGUI RessourceText;
    public TextMeshProUGUI CheminDeVieText;
    public TextMeshProUGUI PassageObligeText;
    public TextMeshProUGUI DifficulteText;
    public TextMeshProUGUI MoteurText;
    public TextMeshProUGUI PartLumineuseText;
    public TextMeshProUGUI PointSensibleText;
    public TextMeshProUGUI CheminDeVieNumeroText;
    public TextMeshProUGUI RealisationText;
    public TextMeshProUGUI IntimeText;
    public TextMeshProUGUI ExpressionText;
    public TextMeshProUGUI AnneePersoText;
    public TextMeshProUGUI Cycle1EnCoursText;
    public TextMeshProUGUI Cycle2EnCoursText;
    public TextMeshProUGUI Cycle3EnCoursText;
    public TextMeshProUGUI Realisation1Text;
    public TextMeshProUGUI Realisation2Text;
    public TextMeshProUGUI Realisation3Text;
    public TextMeshProUGUI Realisation4Text;
    public TextMeshProUGUI Cycle1Text;
    public TextMeshProUGUI Cycle2Text;
    public TextMeshProUGUI Cycle3Text;
    public TextMeshProUGUI DefiMineur1Text;
    public TextMeshProUGUI DefiMineur2Text;
    public TextMeshProUGUI DefiMajeurText;
    public Button Valider;

    //INT MATRICE
    public int jour;
    public int mois;
    public int annee;
    public int Jsomme;
    public int Msomme;
    public int Asomme;
    public int ANumSomme;
    public int AAsomme;
    public int apparence;
    public int VisionDuMonde;
    public int Ressource;
    public int SommeNaissance;
    public int CheminDeVie;
    public int PassageOblige;
    public int Difficulte;
    public int Moteur;
    public int PartLumineuse;
    public int PointSensible;
    public int SommeNaissanceAnnee;
    //FIN INT MATRICE

    //INT NUMEROLOGIE

    //Premier Bloc
    public int Realisation;
    public int Intime;
    public int Expression;

    //Annee en cours
    public int AnneeActuel;
    public int AnneePerso;
    public int Cycle1EnCours;
    public int Cycle2EnCours;
    public int Cycle3EnCours;

    //Cycle Defi et Realisation de la vie
    public int Realisation1;
    public int Realisation2;
    public int Realisation3;
    public int Realisation4;
    public int Cycle1;
    public int Cycle2;
    public int Cycle3;
    public int DefiMineur1;
    public int DefiMineur2;
    public int DefiMajeur;
    //FIN INT NUMEROLOGIE


    void Start()
    {
        // Attacher la méthode "CalculerNumerologie" à l'événement "OnClick" du bouton
        Valider.onClick.AddListener(CalculerNumerologie);
        Valider.onClick.AddListener(CalculerMatrice);
    }

    //DEBUT MATRICE
    public void  CalculerMatrice()
    {
        // Conversion des champs de texte InitialjourText, InitialmoisText et InitialanneeText en entiers
        if (int.TryParse(InitialjourText.text, out int valeurJour))
        {
            jour = valeurJour;
            Debug.Log("jour: " + jour);
        
        
        }
        else
        {
            Debug.LogError("Impossible de convertir le texte en nombre pour le jour.");
        }

        if (int.TryParse(InitialmoisText.text, out int valeurMois))
        { 
            mois = valeurMois;
            Debug.Log("mois: " + mois);
            moisText.text = valeurMois.ToString();
        }
        else
        {
            Debug.LogError("Impossible de convertir le texte en nombre pour le mois.");
        }

        if (int.TryParse(InitialanneeText.text, out int valeurAnnee))
        {
            annee = valeurAnnee;
            Debug.Log("annee: " + annee);
        }
        else
        {
            Debug.LogError("Impossible de convertir le texte en nombre pour l'année.");
        }
        if (int.TryParse(AnneeActuelText.text, out int valeurAnneeActuel))
        {
            AnneeActuel = valeurAnneeActuel;
            Debug.Log("anneeActuel: " + AnneeActuel);
        }
        else
        {
            Debug.LogError("Impossible de convertir le texte en nombre pour l'année.");
        }

        // Calcul numérologique du jour
        int JourCalcul = jour;
        int Jchiffre1 = JourCalcul / 10; // Obtient le premier chiffre
        int Jchiffre2 = JourCalcul % 10; // Obtient le deuxième chiffre
            Jsomme = Jchiffre1 + Jchiffre2; // Additionne les deux chiffres
        Debug.Log("Jsomme: " + Jsomme);

        // Calcul numérologique du mois
        int MoisCalcul = mois;
        int Mchiffre1 = MoisCalcul / 10; // Obtient le premier chiffre
        int Mchiffre2 = MoisCalcul % 10; // Obtient le deuxième chiffre
            Msomme = Mchiffre1 + Mchiffre2; // Additionne les deux chiffres
        Debug.Log("Msomme: " + Msomme);

        // Calcul numérologique de l'année
        int AnneeCalcul = annee;
        int Achiffre1 = AnneeCalcul / 1000; // Obtient le premier chiffre (milliers)
        AnneeCalcul %= 1000; // Met à jour annee en retirant les milliers
        int Achiffre2 = AnneeCalcul / 100; // Obtient le deuxième chiffre (centaines)
        AnneeCalcul %= 100; // Met à jour annee en retirant les centaines
        int Achiffre3 = AnneeCalcul / 10; // Obtient le troisième chiffre (dizaines)
        int Achiffre4 = AnneeCalcul % 10; // Obtient le quatrième chiffre (unités)
            Asomme = Achiffre1 + Achiffre2 + Achiffre3 + Achiffre4; // Additionne tous les chiffres
        while (Asomme > 22){
            int Aschiffre1 = Asomme / 10; // Obtient le premier chiffre
            int Aschiffre2 = Asomme % 10; // Obtient le deuxième chiffre
            Asomme = Aschiffre1 + Aschiffre2;
        }
        Debug.Log("Asomme: " + Asomme);

        // Calcul numérologique de l'année
        int AnneeNumCalcul = annee;
        int ANumchiffre1 = AnneeNumCalcul / 1000; // Obtient le premier chiffre (milliers)
        AnneeNumCalcul %= 1000; // Met à jour annee en retirant les milliers
        int ANumchiffre2 = AnneeNumCalcul / 100; // Obtient le deuxième chiffre (centaines)
        AnneeNumCalcul %= 100; // Met à jour annee en retirant les centaines
        int ANumchiffre3 = AnneeNumCalcul / 10; // Obtient le troisième chiffre (dizaines)
        int ANumchiffre4 = AnneeNumCalcul % 10; // Obtient le quatrième chiffre (unités)
            ANumSomme = ANumchiffre1 + ANumchiffre2 + ANumchiffre3 + ANumchiffre4; // Additionne tous les chiffres
        while (ANumSomme > 9){
            int ANumschiffre1 = ANumSomme / 10; // Obtient le premier chiffre
            int ANumschiffre2 = ANumSomme % 10; // Obtient le deuxième chiffre
            ANumSomme = ANumschiffre1 + ANumschiffre2;
        }
        Debug.Log("ANumSomme: " + ANumSomme);

        // Calcul numérologique de l'année Actuelle
        int AnneeActuelCalcul = AnneeActuel;
        int AAchiffre1 = AnneeActuelCalcul / 1000; // Obtient le premier chiffre (milliers)
        AnneeActuelCalcul %= 1000; // Met à jour annee en retirant les milliers
        int AAchiffre2 = AnneeActuelCalcul / 100; // Obtient le deuxième chiffre (centaines)
        AnneeActuelCalcul %= 100; // Met à jour annee en retirant les centaines
        int AAchiffre3 = AnneeActuelCalcul / 10; // Obtient le troisième chiffre (dizaines)
        int AAchiffre4 = AnneeActuelCalcul % 10; // Obtient le quatrième chiffre (unités)
            AAsomme = AAchiffre1 + AAchiffre2 + AAchiffre3 + AAchiffre4; // Additionne tous les chiffres
        while (AAsomme > 9){
            int AAschiffre1 = AAsomme / 10; // Obtient le premier chiffre
            int AAschiffre2 = AAsomme % 10; // Obtient le deuxième chiffre
            AAsomme = AAschiffre1 + AAschiffre2;
        }
        Debug.Log("AnneeActuelsomme: " + AAsomme);

        // Calcul numérologique de l'apparence
        apparence = jour > 22 ? Jsomme : jour; // Si jour > 22, utilise la somme des chiffres, sinon utilise jour lui-même
        ApparenceText.text = apparence.ToString();
        Debug.Log("Apparence: " + apparence);

        // Calcul numérologique de la vision du monde
        VisionDuMonde = Asomme;
        VisionDuMondeText.text = VisionDuMonde.ToString();
        Debug.Log("Vision du monde: " + VisionDuMonde);

        // Calcul numérologique de la Ressource
        Ressource = apparence + mois;
        if (Ressource > 22)
        {
            int Rechiffre1 = Ressource / 10; // Obtient le premier chiffre
            int Rechiffre2 = Ressource % 10; // Obtient le deuxième chiffre
            Ressource = Rechiffre1 + Rechiffre2; // Additionne les deux chiffres
        }
        RessourceText.text = Ressource.ToString();

        Debug.Log("Ressource: " + Ressource);
        // Calcul numérologique du Chemin de vie
        int SommeNaissanceDebut = Jsomme + Msomme + Asomme;
        Debug.Log("SommeNaissanceDebut: " + SommeNaissanceDebut);
        SommeNaissance = SommeNaissanceDebut;
        int SNchiffre1 = SommeNaissance / 10; // Obtient le troisième chiffre (dizaines)
        int SNchiffre2 = SommeNaissance % 10; // Obtient le quatrième chiffre (unités)
        CheminDeVie = SNchiffre1 + SNchiffre2; // Additionne tous les chiffres
        CheminDeVieText.text = CheminDeVie.ToString();
        CheminDeVieNumeroText.text = CheminDeVie.ToString();


        Debug.Log("Chemin de vie : " + CheminDeVie);
        // Calcul numérologique du passage obligé
        PassageOblige = mois + apparence + VisionDuMonde + CheminDeVie;
        if (PassageOblige > 22)
        {
            int POchiffre1 = PassageOblige / 10; // Obtient le premier chiffre
            int POchiffre2 = PassageOblige % 10; // Obtient le deuxième chiffre
            PassageOblige = POchiffre1 + POchiffre2; // Additionne les deux chiffres
        }
        PassageObligeText.text = PassageOblige.ToString();

        Debug.Log("Passage Oblige: " + PassageOblige);
        // Calcul numérologique de la difficulté
        int Difficultemois = valeurMois;
        
        Difficulte = Mathf.Abs(VisionDuMonde - Difficultemois);
        DifficulteText.text = Difficulte.ToString();

        Debug.Log("Difficultemois: " + Difficultemois);
        Debug.Log("Difficulte: " + Difficulte);
        // Calcul numérologique du moteur
        int MoteurAsomme = Asomme;
        while(MoteurAsomme > 9){
        int MAchiffre1 = MoteurAsomme / 10; // Obtient le premier chiffre
        int MAchiffre2 = MoteurAsomme % 10; // Obtient le deuxième chiffre
        MoteurAsomme = MAchiffre1 + MAchiffre2; // Additionne les deux chiffres
        }
        Moteur = MoteurAsomme + Ressource;
        Debug.Log("MoteurAsomme: " + MoteurAsomme);
        if (Moteur > 22)
        {
            int MoteurChiffre1 = Moteur / 10; // Obtient le premier chiffre
            int MoteurChiffre2 = Moteur % 10; // Obtient le deuxième chiffre
            Moteur = MoteurChiffre1 + MoteurChiffre2; // Additionne les deux chiffres
        }
        MoteurText.text = Moteur.ToString();

        Debug.Log("Moteur: " + Moteur);

        // Calcul numérologique de la part lumineuse
        PartLumineuse = Ressource + Difficulte;
        if (PartLumineuse > 22)
        {
            int PLchiffre1 = PartLumineuse / 10; // Obtient le premier chiffre
            int PLchiffre2 = PartLumineuse % 10; // Obtient le deuxième chiffre
            PartLumineuse = PLchiffre1 + PLchiffre2; // Additionne les deux chiffres
        }
        PartLumineuseText.text = PartLumineuse.ToString();

        Debug.Log("Part Lumineuse: " + PartLumineuse);
        // Calcul numérologique du point sensible
        PointSensible = 22 - PartLumineuse;
        PointSensibleText.text = PointSensible.ToString();

        Debug.Log("Point Sensible: " + PointSensible);

        // FIN CALCUL MATRICE
    }
        //DEBUT CALCUL NUMEROLOGIQUE MAISON REALISATION ....

        // Mapping des lettres à leur valeur numérique
    private readonly Dictionary<char, int> letterValueMap = new Dictionary<char, int>()
    {
        {'A', 1}, {'J', 1}, {'S', 1},
        {'B', 2}, {'K', 2}, {'T', 2},
        {'C', 3}, {'L', 3}, {'U', 3},
        {'D', 4}, {'M', 4}, {'V', 4},
        {'E', 5}, {'N', 5}, {'W', 5},
        {'F', 6}, {'O', 6}, {'X', 6},
        {'G', 7}, {'P', 7}, {'Y', 7},
        {'H', 8}, {'Q', 8}, {'Z', 8},
        {'I', 9}, {'R', 9}
    };


    public void CalculerNumerologie()
    {
        //TABLEAU VALEUR POUR EXPRESSION INTIME REALISATION + TABLEAU LETTRE
        string NomPrenomText = fileNameInput.text.ToUpper();
        
        int total = CalculateGeneralValue(NomPrenomText);
        
        Expression = total; // Stocker le total global
        while (Expression > 9){
                int Expressionschiffre1 = Expression / 10; // Obtient le premier chiffre
                int Expressionschiffre2 = Expression % 10; // Obtient le deuxième chiffre
                Expression = Expressionschiffre1 + Expressionschiffre2;
            }
        //mise de la valeur dans la boite text
        ExpressionText.text = Expression.ToString();
        
        Realisation = CalculConsonne(NomPrenomText);
        while (Realisation > 9){
                int Realisationschiffre1 = Realisation / 10; // Obtient le premier chiffre
                int Realisationschiffre2 = Realisation % 10; // Obtient le deuxième chiffre
                Realisation = Realisationschiffre1 + Realisationschiffre2;
            }
        //mise de la valeur dans la boite text
        RealisationText.text = Realisation.ToString();

        Intime = CalculVoyelle(NomPrenomText);
        while (Intime > 9){
                int Intimeschiffre1 = Intime / 10; // Obtient le premier chiffre
                int Intimeschiffre2 = Intime % 10; // Obtient le deuxième chiffre
                Intime = Intimeschiffre1 + Intimeschiffre2;
            }
        //mise de la valeur dans la boite text
        IntimeText.text = Intime.ToString();

        //on fait un array pour avoir chaque valeur des 9 maisons
        int[] Maison1A9 = CountLetterGroups(NomPrenomText);
        //On fait une boucle for pour pouvoir écrire chaque valeur dans les boites textes associés au tableau Maison1A9
        for (int i = 0; i < Maison1A9.Length && i < Maison1A9TextElement.Length; i++)
        {
            Maison1A9TextElement[i].text = Maison1A9[i].ToString();
        }

        Debug.Log("Global total: " + Expression);
        Debug.Log("Consonant total: " + Realisation);
        Debug.Log("Vowel total: " + Intime);

        //FIN DES CALCULS ^

        //DEBUT ANNEE PERSO CYCLE1 A 3 ACTUELLE 

        //Annee Perso 

        AnneePerso = Jsomme + Msomme + AAsomme;

        while(AnneePerso > 9){
            // Calcul numérologique de l'année personnelle
            int APchiffre1 = AnneePerso / 10; // Obtient le premier chiffre
            int APchiffre2 = AnneePerso % 10; // Obtient le deuxième chiffre
            AnneePerso = APchiffre1 + APchiffre2; // Additionne les deux chiffres
            Debug.Log("AnneePerso: " + AnneePerso);
        }
        AnneePersoText.text = AnneePerso.ToString();

        //Cycle 1 en cours
        Cycle1EnCours = ANumSomme;
        Cycle1EnCoursText.text = Cycle1EnCours.ToString();
        //Cycle 2 en cours
        if (mois < 9)
        {
            Cycle2EnCours = AnneeActuel - CheminDeVie;
        }
        else
        {
            Cycle2EnCours = (AnneeActuel - 1) - CheminDeVie;
        }
        if(Cycle2EnCours > 9)
        {
            // Calcul numérologique du cycle 2 en cours
            int C2ECchiffre1 = Cycle2EnCours / 1000; // Obtient le premier chiffre (milliers)
            Cycle2EnCours %= 1000; // Met à jour en retirant les milliers
            int C2ECchiffre2 = Cycle2EnCours / 100; // Obtient le deuxième chiffre (centaines)
            Cycle2EnCours %= 100; // Met à jour en retirant les centaines
            int C2ECchiffre3 = Cycle2EnCours / 10; // Obtient le troisième chiffre (dizaines)
            int C2ECchiffre4 = Cycle2EnCours % 10; // Obtient le quatrième chiffre (unités)
            Cycle2EnCours = C2ECchiffre1 + C2ECchiffre2 + C2ECchiffre3 + C2ECchiffre4; // Additionne tous les chiffres
            while (Cycle2EnCours > 9){
                int C2ECschiffre1 = Cycle2EnCours / 10; // Obtient le premier chiffre
                int C2ECschiffre2 = Cycle2EnCours % 10; // Obtient le deuxième chiffre
                Cycle2EnCours = C2ECschiffre1 + C2ECschiffre2;
            }
            Debug.Log("Cycle2EnCours: " + Cycle2EnCours);
        }
        Cycle2EnCoursText.text = Cycle2EnCours.ToString();

        //Cycle 3 en cours
        Cycle3EnCours = Cycle1EnCours + Cycle2EnCours;
        while(Cycle3EnCours > 9){
            // Calcul numérologique du cycle 2 en cours
            int CEC3chiffre1 = Cycle3EnCours / 10; // Obtient le premier chiffre
            int CEC3chiffre2 = Cycle3EnCours % 10; // Obtient le deuxième chiffre
            Cycle3EnCours = CEC3chiffre1 + CEC3chiffre2; // Additionne les deux chiffres
            Debug.Log("Cycle3EnCours: " + Cycle3EnCours);
        }
        Cycle3EnCoursText.text = Cycle3EnCours.ToString();

        //FIN ANNEE PERSO CYCLE1 A 3 ACTUELLE 

        //DEBUT GRAND SCHEMA DE VIE

        //REALISATION DE 1 A 4

        //Realisation 1
        Realisation1 = Jsomme + Msomme;
        if(Realisation1 > 9){
            // Calcul numérologique du cycle 2 en cours
            int Realisation1Calcul = Realisation1;
            int Realisation1chiffre1 = Realisation1Calcul / 10; // Obtient le premier chiffre
            int Realisation1chiffre2 = Realisation1Calcul % 10; // Obtient le deuxième chiffre
            Realisation1 = Realisation1chiffre1 + Realisation1chiffre2; // Additionne les deux chiffres
            Debug.Log("Realisation1: " + Realisation1);
        }
        Realisation1Text.text = Realisation1.ToString();


        //Realisation 2
        Realisation2 = Jsomme + ANumSomme;
        if(Realisation2 > 9){
            // Calcul numérologique du cycle 2 en cours
            int Realisation2Calcul = Realisation2;
            int Realisation2chiffre1 = Realisation2Calcul / 10; // Obtient le premier chiffre
            int Realisation2chiffre2 = Realisation2Calcul % 10; // Obtient le deuxième chiffre
            Realisation2 = Realisation2chiffre1 + Realisation2chiffre2; // Additionne les deux chiffres
            Debug.Log("Realisation2: " + Realisation2);
        }
        Realisation2Text.text = Realisation2.ToString();


        //Realisation 3
        Realisation3 = Realisation1 + Realisation2;
        if(Realisation3 > 9){
            // Calcul numérologique du cycle 2 en cours
            int Realisation3Calcul = Realisation3;
            int Realisation3chiffre1 = Realisation3Calcul / 10; // Obtient le premier chiffre
            int Realisation3chiffre2 = Realisation3Calcul % 10; // Obtient le deuxième chiffre
            Realisation3 = Realisation3chiffre1 + Realisation3chiffre2; // Additionne les deux chiffres
            Debug.Log("Realisation3: " + Realisation3);
        }
        Realisation3Text.text = Realisation3.ToString();


        //Realisation 4
        Realisation4 = Msomme + ANumSomme;
        if(Realisation4 > 9){
            // Calcul numérologique du cycle 2 en cours
            int Realisation4Calcul = Realisation4;
            int Realisation4chiffre1 = Realisation4Calcul / 10; // Obtient le premier chiffre
            int Realisation4chiffre2 = Realisation4Calcul % 10; // Obtient le deuxième chiffre
            Realisation4 = Realisation4chiffre1 + Realisation4chiffre2; // Additionne les deux chiffres
            Debug.Log("Realisation4: " + Realisation4);
        }
        Realisation4Text.text = Realisation4.ToString();
        //FIN REALISATION 


        //CYCLE DE 1 A 3
        
        //Cycle 1
        Cycle1 = Msomme;
        if(Cycle1 > 9){
            // Calcul numérologique du cycle 1
            int Cycle1Calcul = Cycle1;
            int Cycle1chiffre1 = Cycle1Calcul / 10; // Obtient le premier chiffre
            int Cycle1chiffre2 = Cycle1Calcul % 10; // Obtient le deuxième chiffre
            Cycle1 = Cycle1chiffre1 + Cycle1chiffre2; // Additionne les deux chiffres
            Debug.Log("Cycle1: " + Cycle1);
        }
        Cycle1Text.text = Cycle1.ToString();

        //Cycle 2
        Cycle2 = Jsomme;
        if(Cycle2 > 9){
            // Calcul numérologique du cycle 2
            int Cycle2Calcul = Cycle2;
            int Cycle2chiffre1 = Cycle2Calcul / 10; // Obtient le premier chiffre
            int Cycle2chiffre2 = Cycle2Calcul % 10; // Obtient le deuxième chiffre
            Cycle2 = Cycle2chiffre1 + Cycle2chiffre2; // Additionne les deux chiffres
            Debug.Log("Cycle2: " + Cycle2);
        }
        Cycle2Text.text = Cycle2.ToString();
        //Cycle 3
        Cycle3 = ANumSomme;
        if(Cycle3 > 9){
            // Calcul numérologique du cycle 3
            int Cycle3Calcul = Cycle3;
            int Cycle3chiffre1 = Cycle3Calcul / 10; // Obtient le premier chiffre
            int Cycle3chiffre2 = Cycle3Calcul % 10; // Obtient le deuxième chiffre
            Cycle3 = Cycle3chiffre1 + Cycle3chiffre2; // Additionne les deux chiffres
            Debug.Log("Cycle3: " + Cycle3);
        }
        Cycle3Text.text = Cycle3.ToString();

        //DEBUT DEFI MINEUR ET MAJEUR

        //Defi Mineur 1
        DefiMineur1 = Mathf.Abs(Msomme - Jsomme);
        DefiMineur1Text.text = DefiMineur1.ToString();
        //Defi Mineur 2
        DefiMineur2 = Mathf.Abs(Jsomme - ANumSomme);
        DefiMineur2Text.text = DefiMineur2.ToString();
        //Defi Majeur
        DefiMajeur = Mathf.Abs(DefiMineur1 - DefiMineur2);
        DefiMajeurText.text = DefiMajeur.ToString();
    }

    private int CalculateGeneralValue(string inputText)
    {
        int ValeurTotal = 0;

        foreach (char letter in inputText)
        {
            if (letterValueMap.ContainsKey(letter))
            {
                ValeurTotal += letterValueMap[letter];
            }
        }

        return ValeurTotal;
    }
    
    private int CalculConsonne(string inputText)
    {
        int totalConsonne = 0; // Variable pour stocker la valeur totale des consonnes

        foreach (char letter in inputText)
        {
            if (!IsVowel(letter) && letterValueMap.ContainsKey(letter))
            {
                totalConsonne += letterValueMap[letter];
            }
        }

        return totalConsonne;
    }

    private int CalculVoyelle(string inputText)
    {
        int totalVoyelle = 0; // Variable pour stocker la valeur totale des voyelles

        foreach (char letter in inputText)
        {
            if (IsVowel(letter) && letterValueMap.ContainsKey(letter))
            {
                totalVoyelle += letterValueMap[letter];
            }
        }

        return totalVoyelle;
    }

    
    private bool IsVowel(char letter)
    {
        return "AEIOUY".Contains(letter);
    }

    // Déclaration de la variable letterGroupToHouseMap au niveau de la classe
    private readonly Dictionary<string, int> letterGroupToHouseMap = new Dictionary<string, int>()
    {
        {"AJS", 1}, {"BKT", 2}, {"CLU", 3}, {"DMV", 4}, {"NEW", 5}, {"FOX", 6}, {"GPY", 7}, {"HQZ", 8}, {"IR", 9}
    };

    // Modification de la signature de la méthode CountLetterGroups
    private int[] CountLetterGroups(string inputText)
    {
        int[] housesCount = new int[9];

        foreach (char letter in inputText)
        {
            foreach (var group in letterGroupToHouseMap)
            {
                if (group.Key.Contains(letter))
                {
                    housesCount[group.Value - 1]++;
                    break;
                }
            }
        }

        // Affichage du nombre de lettres dans chaque groupe
        for (int i = 0; i < housesCount.Length; i++)
        {
            Debug.Log("Nombre de lettres dans la maison " + (i + 1) + " : " + housesCount[i]);
        }

        return housesCount;
    }

}

