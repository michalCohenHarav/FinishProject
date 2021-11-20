using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
   public class CompanyConverter
    {
public List<CompanyDTO> ConvertListToDto(List<Company> listEntities)
        {
            List<CompanyDTO> list = new List<CompanyDTO>();
            foreach(var item in listEntities)
            {
                list.Add(ConvertToDTO(item));
            }
            return list;
        }
  public CompanyDTO  ConvertToDTO(Company entity)
        {
            CompanyDTO dto = new CompanyDTO();
            dto.CompID = entity.CompID;
            dto.CompName = entity.CompName;
            dto.NameConect = entity.NameConect;
            dto.Phone = entity.Phone;
            return dto;
        }
    }
}
