﻿using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbLayout
    {
        public int Id { get; set; }
        public string? Programa { get; set; }
        public string? Descricao { get; set; }
        public string? Ordem { get; set; }
    }
}