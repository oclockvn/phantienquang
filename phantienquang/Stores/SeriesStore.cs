using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phantienquang.Stores
{
    using oclockvn.Repository;
    using Contracts.Stores;
    using Entities;

    public class SeriesStore : ISeriesStore
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Series> seriesRepo;

        public SeriesStore(IUnitOfWork unit)
        {
            unitOfWork = unit;
            seriesRepo = unit.Get<Series>();
        }


    }
}