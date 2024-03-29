﻿using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContratoBLL
    {
        public DataSet PesquisarContrato()
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarContrato();
        }

        public DataSet PesquisarContrato(string arg)
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarContrato(arg);
        }

        public DataSet PesquisarMotorista()
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarMotoristas();
        }

        public DataSet PesquisarClientes()
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarClientes();
        }
        public DataSet ListarVeiculos()
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.ListarVeiculos();
        }

        public List<Contrato> PesquisarContratoList(string arg, int id)
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarContratoList(arg, id);
        }
    }
}
