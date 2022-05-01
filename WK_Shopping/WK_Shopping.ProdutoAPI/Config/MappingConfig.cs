﻿using AutoMapper;
using WK_Shopping.ProdutoAPI.Data.ValueObjects;
using WK_Shopping.ProdutoAPI.Model;

namespace WK_Shopping.ProdutoAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProdutoVO, Produto>();
                config.CreateMap<Produto, ProdutoVO>();
            });
            return mappingConfig;
        }
    }
}
