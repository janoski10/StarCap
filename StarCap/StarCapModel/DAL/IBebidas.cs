﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IBebidas
    {
        List<Bebida> ObtenerBebidas();

        void Agregar(Bebida bebida);
    }
}
