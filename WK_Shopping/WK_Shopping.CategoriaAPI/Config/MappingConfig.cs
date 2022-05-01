using AutoMapper;
using WK_Shopping.CategoriaAPI.Data.ValueObjects;
using WK_Shopping.CategoriaAPI.Model;

namespace WK_Shopping.CategoriaAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriaVO, Categoria>();
                config.CreateMap<Categoria, CategoriaVO>();
            });
            return mappingConfig;
        }
    }
}
