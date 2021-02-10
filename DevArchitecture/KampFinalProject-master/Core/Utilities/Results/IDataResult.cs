using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult  //T herşey olabilir ürün ürünadı vs. vs. herşey dönebilir
    {  //interface interface implemente edebilir
        T Data { get; }
    }
}
