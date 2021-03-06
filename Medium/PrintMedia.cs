﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_sharp_experience.Attributes.MediaElements;

namespace C_sharp_experience.Medium
{
    [Serializable]
    abstract public class PrintMedia:Media
    {
        public int sizeCirculation { get; set; }
        public int issueNum { get; set; }

        public Pereodicity pereodicity { get; set; }
    }
}
