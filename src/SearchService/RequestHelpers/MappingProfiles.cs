using AutoMapper;
using Contracts;
using SearchService.Models;

namespace SearchService.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AuctionCreated, Item>()
            .ForMember(dest => dest.ID, source => source.MapFrom(s => s.Id));

        CreateMap<AuctionUpdated, Item>()
            .ForMember(dest => dest.ID, source => source.MapFrom(s => s.Id));
    }
}
