﻿using Pedido.Aplic.Cardapios;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Repositorio.Repositorios;

namespace Pedido
{
    public class IDI
    {
        public void IdiAplic(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IAplicCardapio, AplicCardapio>();
        }
        public void IdiRepositorio(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepCardapioCategoria, RepCardapioCategoria>();
        }
    }
}