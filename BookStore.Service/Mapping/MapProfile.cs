using AutoMapper;
using BookStore.Core.DTOs.Requests;
using BookStore.Core.DTOs.Respons;
using BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookResponsDto>();
            CreateMap<Category, CategoryResponsDto>();
            CreateMap<AddBookRequest, Book>();
            CreateMap<UpdateBookRequest, Book>();
        }
    }
}
