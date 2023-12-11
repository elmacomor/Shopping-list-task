namespace TactaTask.Services
{
    public interface ICrudService<T, Tinsert, Tupdate>:IService<T>
    {
        Task<T> Insert(Tinsert obj);
       
    }
}
