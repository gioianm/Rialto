﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rialto.Data.Interfaces;

namespace Rialto.Domain.Interfaces
{
    interface IAddLots
    {
        void addLot(ILot newLot);
    }
}
