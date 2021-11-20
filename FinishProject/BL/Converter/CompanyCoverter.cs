using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converter
{
 public   class CompanyCoverter
    {
        public List<CompanyDTO> ConvertListDTO(List<Company> listEntities)
        {
            List<CompanyDTO> lst = new List<CompanyDTO>();
            foreach(var item in listEntities)
            {
                lst.Add(ConvertDTO(item));
            }
            return lst;
        }
        public CompanyDTO ConvertDTO(Company entity)
        { CompanyDTO dto = new CompanyDTO();
            dto.CompID = entity.CompID;
            dto.CompName = entity.CompName;
            dto.NameConect = entity.NameConect;
            dto.Phone = entity.Phone;
            return dto;
        }
    }
}
