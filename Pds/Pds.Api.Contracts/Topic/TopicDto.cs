﻿using Pds.Api.Contracts.Person;
using Pds.Core.Enums;

namespace Pds.Api.Contracts.Topic;

public class TopicDto
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string Name { get; set; }

    public ICollection<PersonDto> Persons { get; set; }
        
    public TopicStatus Status { get; set; }
}