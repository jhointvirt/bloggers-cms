﻿using Pds.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pds.Api.Contracts.Topic;

public class UpdateTopicRequest
{
    [Required, StringLength(300, MinimumLength = 3)]
    public string Name { get; set; }

    public TopicStatus Status { get; set; }

    public ICollection<Guid> People { get; set; }
}