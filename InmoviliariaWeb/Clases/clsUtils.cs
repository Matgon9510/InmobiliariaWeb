﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InmoviliariaWeb.Modelos;

namespace InmoviliariaWeb.Clases
{
    public class clsUtils
    {
        DBInmobiliariaEntities dBInmobiliariaTipoTelefono = new DBInmobiliariaEntities();
        public List<Tipo_Tel> LlenarComboTpTelefono()
        {
            return dBInmobiliariaTipoTelefono.Tipo_Tel.OrderBy(p => p.descripcion).ToList();
        }

        DBInmobiliariaEntities dBInmobiliariaGenero = new DBInmobiliariaEntities();
        public List<Genero> LlenarComboGenero()
        {
            return dBInmobiliariaGenero.Generoes.OrderBy(p => p.descripcion).ToList();
        }

        DBInmobiliariaEntities dBInmobiliariaCiudad = new DBInmobiliariaEntities();
        public List<Ciudad> LlenarComboCiudad()
        {
            return dBInmobiliariaCiudad.Ciudads.OrderBy(p => p.descripcion).ToList();
        }




    }
}