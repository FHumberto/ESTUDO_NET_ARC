﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Domain.Entities;

public class Example : BaseEntity
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
}
