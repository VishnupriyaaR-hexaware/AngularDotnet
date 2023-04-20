namespace testdotnetcomp.Data.Interfaces
{
    public interface IDelete<in T>
    {
        bool Delete(T id);
    }
}
