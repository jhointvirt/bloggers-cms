﻿using System.ComponentModel.DataAnnotations;
using Pds.Core.Attributes;
using Pds.Core.Enums;

namespace Pds.Api.Contracts.Content.EditContent;

public class EditContentBillDto
{
    [GuidNotEmpty]
    public Guid ClientId { get; set; }
    
    public string Contact { get; set; }

    public string ContactEmail { get; set; }

    [Required]
    public string ContactName { get; set; }

    [EnumDataType(typeof(ContactType))]
    public ContactType? ContactType { get; set; }

    [Range(10, Double.MaxValue, ErrorMessage = "Значение поля {0} должно быть больше чем {1}.")]
    public decimal Value { get; set; }
}