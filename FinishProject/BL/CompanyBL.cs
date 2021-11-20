using DTO;
using System;
using System.Collections.Generic;

namespace BL
{
    public class CompanyBL
    {
        public static List<CompanyDTO> getAllClock()
        {
        return new Converter.CompanyCoverter().ConvertListDTO( DAL.CompanyDAL.GetAll());
        }
    }
} 