using testdotnetcomp.BusinessEntities.Entities;
using testdotnetcomp.Contracts.DTO;
using AutoMapper;
namespace testdotnetcomp.Api.Middleware
{
public class MappingFile : Profile
{
    public MappingFile()
    {
        // Mapping variables
		CreateMap<User , UserDto>(); 
    }
  }
}
