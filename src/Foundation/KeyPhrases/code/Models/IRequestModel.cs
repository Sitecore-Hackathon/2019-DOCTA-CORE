﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctaCore.Foundation.KeyPhrases.Models
{
    public interface IRequestModel
    {
        Guid Id { get; set; }
        string Language { get; set; }
        string Text { get; set; }
    }
}
