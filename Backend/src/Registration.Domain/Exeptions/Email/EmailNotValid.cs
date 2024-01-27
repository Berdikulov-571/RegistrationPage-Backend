namespace Registration.Domain.Exeptions.Email
{
    public class EmailNotValid : GlobalException
    {
        public EmailNotValid()
        {
            TitleMessage = "Email Not Valid !";
        }
    }
}