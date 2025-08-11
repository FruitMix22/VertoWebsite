namespace VertoTask.Models
{
    public class GlobalContent
    {
        public int Id { get; set; }
        // Header
        public string LogoImagePath { get; set; } 
        public string[] HeaderLinks { get; set; }
        public string QuestionBoxPath { get; set; } 
        
        //Footer
        public string CoopyRightext { get; set; }
        public string TermsConditions { get; set; }
        public string WebsiteMakerText { get; set; }
        public string AdressName { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string interactionText1 { get; set; }
        public string interactionText2 { get; set; }
        public string phoneNumber { get; set; }
        public string ContactEmail { get; set; }
    }
}