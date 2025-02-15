﻿
using MISA.AssetManage.ApplicationCore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.AssetManage.ApplicationCore.Interfaces
{
    public interface IAssetService: IBaseService<Asset>
    {

        IEnumerable<Asset> GetAssetByCode(String code);

    }
}
