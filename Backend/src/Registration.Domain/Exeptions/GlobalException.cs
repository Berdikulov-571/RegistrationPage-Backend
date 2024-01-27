namespace Registration.Domain.Exeptions
{
    public class GlobalException : Exception
    {
        public string TitleMessage { get; set; } = default!;
    }
}