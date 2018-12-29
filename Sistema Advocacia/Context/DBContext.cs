﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Sistema_Advocacia.Context
{
    public class DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

       

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.Colaborador> Colaboradors { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.NaturezaAcao> NaturezaAcaos { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.Processo> Processoes { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.PeticaoModelo> PeticaoModeloes { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.ClienteDocumento> ClienteDocumentoes { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.Documento> Documentoes { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Sistema_Advocacia.Models.Teste> Testes { get; set; }
    }
}
