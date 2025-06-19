﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BLL.Models
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }

        public string Error { get; set; }
    }
}
