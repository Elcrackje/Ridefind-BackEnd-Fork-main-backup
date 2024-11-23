﻿using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace RideFind_BackEnd.Profiles;

public partial class Profile : IEntityWithCreatedUpdatedDate
{
    [Column("CreatedAt")] public DateTimeOffset? CreatedDate { get; set; }

    [Column("UpdatedAt")] public DateTimeOffset? UpdatedDate { get; set; }
}