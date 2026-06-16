using test_15_06_2026.Questionaire;

Console.WriteLine("Infromation Personelles\n");

List<QuestionReponse> listeQR = new List<QuestionReponse>();
listeQR.Add(new QuestionReponse() { Question = "Quel est votre prénom ?\n", PréReponse = "Prénom : "  } ); 
listeQR.Add(new QuestionReponse() { Question = "Quel est votre nom ?\n", PréReponse = "Nom : " });
listeQR.Add(new QuestionReponse() { Question = "Quel est votre âge ?\n", PréReponse = "Âge : " });


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

GestionairedesQuestionReponse afficher = new GestionairedesQuestionReponse();

if (choixAffichage == "Y" || choixAffichage == "y")
{
    afficher.AfficherReponses = true;
}

else if (choixAffichage == "N" || choixAffichage == "n")
{
    afficher.AfficherReponses = false;
}

else
{
    Console.WriteLine("heu...");
    throw new Exception("erreur : vous devez répondre par y ou n !");
}

afficher.AfficherReponsesMethod(listeQR);

//if (yon == "Y" || yon == "y")
//{
//    Console.WriteLine("Voici les réponses :");
//    foreach (QuestionReponse QR in listeQR)
//    {
//        Console.WriteLine(QR.Reponse);
//    }
//    Console.WriteLine("");
//}

//else if (yon == "N" || yon == "n")
//{
//    Console.WriteLine("au revoir !");
//    Console.WriteLine("");
//}

//else
//{
//    Console.WriteLine("heu...");
//    throw new Exception("erreur : vous devez répondre par y ou n !");
//}

Console.WriteLine("Appuyer sur n’importe quelle touche pour fermer cette fenêtre...");
Console.ReadKey();

// crée un liste avec x questions 
// On veut boucler la liste, pour qu'a chaque itération, on pose la question et on récupère la réponse
// On demande si on veut afficher les réponses
// Si oui, on affiche la réponse, sinon au revoir!