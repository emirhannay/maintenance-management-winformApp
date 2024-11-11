using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
    public record GetUserTypesRequestDTO
    {
        public int Id { get; init; }
        public string ParamCode { get; init; }
        public string Label { get; init; }
        public int Value { get; init; }

        public GetUserTypesRequestDTO(int id, string paramCode, string label, int value)
        {
            Id = id;
            ParamCode = paramCode;
            Label = label;
            Value = value;
        }

    }
}
