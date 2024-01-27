namespace Registration.Domain.Exeptions.Email
{
    public class EmailAlreadyExists : GlobalException
    {
        public EmailAlreadyExists()
        {
            TitleMessage = "Email Already Exists !";
        }
    }
}