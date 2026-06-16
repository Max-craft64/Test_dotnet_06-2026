namespace test_15_06_2026.Questionaire
{
    public class QuestionReponse
    {
        public string Question { get; set; } = "";

        public string Reponse { get; set; } = "";

        public string PréReponse { get; set; } = "";
    }

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
                Console.WriteLine("au revoir !");
                Console.WriteLine("");
            }
        }

        public bool RefaireLeQuestionaire { get; set; } = false;
    }
}
