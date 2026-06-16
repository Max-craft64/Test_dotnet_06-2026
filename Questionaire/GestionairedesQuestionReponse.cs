namespace test_15_06_2026.Questionaire
{
    public class GestionairedesQuestionReponse
    {
        public bool AfficherReponses { get; set; } = false;

        public void AfficherReponsesMethod(List<QuestionReponse> listeQR)
        {
            if (AfficherReponses)
            {
                Console.WriteLine("Voici les réponses :");
                foreach (QuestionReponse QR in listeQR)
                {
                    Console.WriteLine($"{QR.PréReponse}{QR.Reponse}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Vous avez choisi de ne pas voir vos réponses.");
                Console.WriteLine("");
            }
        }

        public bool RefaireLeQuestionaire { get; set; } = false;

        public void RefaireLeQuestionaireMethod()
        {
            if (RefaireLeQuestionaire)
            {
                Console.WriteLine("Vous avez choisi de refaire le questionnaire.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Vous avez choisi de ne pas refaire le questionnaire.");
                Console.WriteLine("");
            }
        }
    }
}