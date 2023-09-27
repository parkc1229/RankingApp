using System;
using AutoMapper;
using RankingApp.Models;
using RankingApp.ViewModel;

namespace RankingApp
{
	public class ItemProfile : Profile
	{
		public ItemProfile()
		{
            CreateMap<ItemModel, ItemViewModel>()
                .ForMember(dest =>
                    dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(dest =>
                    dest.Title,
                    opt => opt.MapFrom(src => src.Title))
                .ForMember(dest =>
                    dest.ImageId,
                    opt => opt.MapFrom(src => src.ImageId))
                .ForMember(dest =>
                    dest.Ranking,
                    opt => opt.MapFrom(src => src.Ranking))
                .ForMember(dest =>
                    dest.ItemType,
                    opt => opt.MapFrom(src => src.ItemType));

        }
	}
}

