﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCatalogAPI.Mapping
{
    public interface IMap
    {
        void Mapping(Profile profile);
    }
}
