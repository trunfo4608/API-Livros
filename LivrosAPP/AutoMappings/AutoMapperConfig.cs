using AutoMapper;
using LivrosAPP.Model;
using LivrosAPP.Service.Dtos;

namespace LivrosAPP.Service.Dto
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig() {

            CreateMap<AutorPostDto,Autor>();
            CreateMap<AutorPutDto, Autor>();
            CreateMap<Autor, AutorGetDto>();


            CreateMap<LivroPostDto, Livro>();
            CreateMap<LivroPutDto, Livro>();
            CreateMap<Livro, LivroGetDto>();



        }



    }
}
