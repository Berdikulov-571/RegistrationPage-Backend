namespace Registration.Domain.Exeptions.PhoneNumber
{
    public class PhoneNumberAlreadyExists : GlobalException
    {
        public PhoneNumberAlreadyExists()
        {
            TitleMessage = "Phone Number Already Exists!";
        }
    }
}