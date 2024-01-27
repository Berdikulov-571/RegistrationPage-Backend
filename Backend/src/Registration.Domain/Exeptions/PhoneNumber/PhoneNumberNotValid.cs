namespace Registration.Domain.Exeptions.PhoneNumber
{
    public class PhoneNumberNotValid : GlobalException
    {
        public PhoneNumberNotValid()
        {
            TitleMessage = "Phone Number Not Valid !";
        }
    }
}