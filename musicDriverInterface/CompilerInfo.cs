﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicDriverInterface
{
    public class CompilerInfo
    {
        public List<int> totalCount;
        public List<int> loopCount;
        public List<int> bufferCount;
        public int jumpClock;
        public object addtionalInfo;

        public List<Tuple<int, int, string>> warningList = new List<Tuple<int, int, string>>();
        public List<Tuple<int, int, string>> errorList = new List<Tuple<int, int, string>>();
    }
}
