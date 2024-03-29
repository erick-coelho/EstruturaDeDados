﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.controller
{
    class ListaEncadeada
    {
        private Node inicio, fim, no;
        private int tamanho;
        public ListaEncadeada()
        {
            inicio = new Node();
            tamanho = 0;
            fim = inicio;
        }
        public void AddInicio(int x)
        {
            if (tamanho == 0)
            {
                no = new Node();
                no.valor = x;
                inicio.prox = no;
                fim = no;
            }
            else
            {
                no = new Node();
                no.valor = x;
                no.prox = inicio.prox;
                inicio.prox = no;
            }
            tamanho++;
        }
        public void AddFim(int x)
        {
            if (tamanho == 0)
            {
                no = new Node();
                no.valor = x;
                inicio = no;
                fim = no;
            }
            else
            {
                no = new Node();
                no.valor = x;
                fim.prox = no;
                fim = no;
            }
            tamanho++;
        }
        public string Listar()
        {
            string resultado = "";
            no = inicio;
            int contador = 1;
            if (tamanho == 0)
            {
                resultado += "A lista está vazia";
            }
            else
            {
                while (no != null)
                {
                    if (!(no == inicio))
                    {
                        resultado += $"{contador++} - {no.valor}\n";
                    }
                    no = no.prox;
                }
            }
            return resultado;
        }
        public void RemoverPorPosicao(int pos)
        {
            if (pos <= tamanho)
            {
                if (pos == 1)
                {
                    inicio.prox = inicio.prox.prox;
                    tamanho--;
                }
                else
                {
                    no = inicio;
                    for (int i = 1; i < pos; i++)
                    {
                        no = no.prox;
                    }
                    if(pos == tamanho)
                    {
                        no.prox = null;
                        tamanho--;
                    } 
                    no.prox = no.prox.prox;
                }
            }
        }


    }
}
