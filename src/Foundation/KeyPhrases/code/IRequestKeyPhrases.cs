﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctaCore.Foundation.KeyPhrases
{
    public interface IRequestKeyPhrases
    {
        Task<string> GetResponse(string data);
    }
}
