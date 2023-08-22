using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Cashing
{
    public interface ICasheManager
    {
        T Get<T>(string key);
        object Get(string key);      // generic olmayan versiyonu.
        void Add(string key, object value , int duration);
        bool IsAdd(string key);      // cashe'de varmı diye kontrol yaptığımız metot.
        void Remove(string key);         // cashe'den kaldırma.
        void RemoveByPattern(string pattern); // Filtreye göre cashe'den kaldırma.
    }
}
