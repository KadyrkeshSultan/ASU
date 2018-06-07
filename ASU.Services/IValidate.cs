namespace ASU.Services
{
    public interface IValidate<TItem, TResult>
    {
        TResult Validate(TItem item);
    }
}
