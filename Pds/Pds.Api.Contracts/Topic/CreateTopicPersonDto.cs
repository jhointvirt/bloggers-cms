﻿using System;
using Pds.Api.Contracts.Person;

namespace Pds.Api.Contracts.Topic
{
    public class CreateTopicPersonDto
    {
        public PersonDto Person { get; set; }

        public bool IsSelected { get; set; }
    }
}