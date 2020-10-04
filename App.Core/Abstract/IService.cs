using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace App.Core.Abstract
{
    public interface IService<T> where T : class //T tipi class olmak zorundadır ve generic'dir.
    {
        Task<T> GetAsync(object id); //Tek kayıt getiren method.

        Task<T> QueryFirstOrDefaultAsync(string query, object parameters, CommandType commandType); //İlk kaydı getiren method.

        Task<IEnumerable<T>> GetAllAsync(); //Tüm kaydı getiren method.

        Task<IEnumerable<T>> QueryAsync(string query, object parameters, CommandType commandType); //Sorguya ve parametreye göre geriye liste şeklinde kayıt getiren method.

        Task<int> ExecuteAsync(string query, object parameters, CommandType commandType); //Sorguya ve parametreye göre geriye integer bir sayı döner.

        Task InsertAsync(T entity); //Kayıt ekleme methodu.

        Task UpdateAsync(T entity); //Kayıt güncelleme methodu.

        Task DeleteAsync(T entity); //Kayıt silme methodu.

        Task DeleteAsync(object id); //Gelen değere göre kayıt silme.
    }
}
