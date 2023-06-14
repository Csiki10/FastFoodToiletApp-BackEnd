namespace ToiletApp.Models
{
    public class UpdateToiletViewModel
    {
        public string Uid { get; set; }

        public string Code { get; set; }

        public virtual Address Address { get; set; }

        public Institution Institution { get; set; }

        public virtual AppFileData? ToiletPicture { get; set; }
    }
}
