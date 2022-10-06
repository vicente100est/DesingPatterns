﻿using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public class CBarmanDirector
    {
        private IBuilder _builder;

        public CBarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            this._builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 Limones");
            _builder.AddIngredients("Pizca de sal");
            _builder.AddIngredients("1/2 taza de Tequila");
            _builder.AddIngredients("3/4 taza de licor de naranja");
            _builder.AddIngredients("4 cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);
        }
    }
}
