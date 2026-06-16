using test_15_06_2026.Questionaire;

Console.WriteLine("Infromation Personelles\n");

List<QuestionReponse> listeQR = new List<QuestionReponse>();
listeQR.Add(new QuestionReponse() { Question = "Quel est votre prénom ?\n", PreReponse = "Prénom : " });
listeQR.Add(new QuestionReponse() { Question = "Quel est votre nom ?\n", PreReponse = "Nom : " });
listeQR.Add(new QuestionReponse() { Question = "Quel est votre âge ?\n", PreReponse = "Âge : " });

GestionnaireQuestionnaire Gestionaire = new GestionnaireQuestionnaire();

while (Gestionaire.RefaireLeQuestionaire == true)
{  
    foreach (QuestionReponse QR in listeQR)
    {
        Console.WriteLine(QR.Question);
        string? reponse = Console.ReadLine();
        QR.Reponse = reponse ?? "";
        Console.WriteLine("");
    }
    
    Console.WriteLine("Voulez-vous afficher les réponses ? (Y/N)\n");
    string? choixAffichage = Console.ReadLine();
    Console.WriteLine("");

    if (choixAffichage == "Y" || choixAffichage == "y")
    {
        Gestionaire.AfficherReponses = true;
    }

    else if (choixAffichage == "N" || choixAffichage == "n")
    {
        Gestionaire.AfficherReponses = false;
    }

    else
    {
        Console.WriteLine("heu...");
        throw new Exception("erreur : vous devez répondre par y ou n !");
    }

    Gestionaire.AfficherReponsesMethod(listeQR);

    Console.WriteLine("Voulez-vous Refaire le test ? (Y/N)\n");
    string? ChoixRépétition = Console.ReadLine();
    Console.WriteLine("");

    if (ChoixRépétition == "Y" || ChoixRépétition == "y")
    {
        Gestionaire.RefaireLeQuestionaire = true;
    }
    else if (ChoixRépétition == "N" || ChoixRépétition == "n")
    {
        Gestionaire.RefaireLeQuestionaire = false;
    }
    else
    {
        Console.WriteLine("heu...");
        throw new Exception("erreur : vous devez répondre par y ou n !");
    }
}

Console.WriteLine("Appuyer sur n’importe quelle touche pour fermer cette fenêtre...");
Console.ReadKey();

// crée un liste avec x questions 
// On veut boucler la liste, pour qu'a chaque itération, on pose la question et on récupère la réponse
// On demande si on veut afficher les réponses
// Si oui, on affiche la réponse, sinon au revoir!