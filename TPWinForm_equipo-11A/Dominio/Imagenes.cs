﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagenes
    {
        public int ID {  get; set; }
        public int ID_Articulo { get; set; }
        public string ImagenUrl {  get; set; }

        public override string ToString()
        {
            return ImagenUrl; 
        }
    }
}
