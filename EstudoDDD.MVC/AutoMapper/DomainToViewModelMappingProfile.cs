using AutoMapper;
using EstudoDDD.Domain.Entities;
using EstudoDDD.MVC.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();            
        }

    }
}