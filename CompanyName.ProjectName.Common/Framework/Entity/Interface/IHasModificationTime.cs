﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Entity.Interface
{
    public interface IHasModificationTime
    {
        DateTime? LastModifiedAt { get; set; }
    }
}
