namespace Refatorando3.Aula5.R60.ExtractInterface.depois
{
    public interface IFormatter
    {
        bool CanBeFormatted(string value);
        string Format(string value);
        bool IsFormatted(string value);
        string Unformat(string value);
    }
}