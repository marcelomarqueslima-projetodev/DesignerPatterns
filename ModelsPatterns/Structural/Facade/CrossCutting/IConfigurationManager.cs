namespace ModelsPatterns.Structural.Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
