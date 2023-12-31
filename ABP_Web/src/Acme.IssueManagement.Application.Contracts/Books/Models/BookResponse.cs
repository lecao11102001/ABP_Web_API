﻿using System;
using Volo.Abp.Application.Dtos;
using static Acme.IssueManagement.Constants.Enums;

namespace Acme.IssueManagement.Books
{
    public class BookResponse : AuditedEntityDto<Guid>
    {
        public string? Name { get; set; }

        public BookTypeEnums Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
