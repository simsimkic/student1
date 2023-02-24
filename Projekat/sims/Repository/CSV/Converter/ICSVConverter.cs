using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public interface ICSVConverter<E> where E : class
    {
        string ConvertEntityToCSVFormat(E entity);

        E ConvertCSVFormatToEntity(string entityCSVFormat);
    }
}
