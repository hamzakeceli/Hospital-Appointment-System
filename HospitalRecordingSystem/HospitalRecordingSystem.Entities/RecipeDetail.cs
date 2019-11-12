namespace HospitalRecordingSystem.Entities
{
    public class RecipeDetail
    {
        public int RecipeId { get; set; }
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string PatientNameAndSurname { get; set; }
    }
}
