using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DomApp.Models;
using DomApp.Models.DomainModels;
using DomApp.Models.DTOs;

namespace DomApp.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateMasterInstrumentDto, MasterInstrument>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => GenerateNewId()));
        }

        private int GenerateNewId()
        {
            return new Random().Next(1, int.MaxValue);
        }
    }
}