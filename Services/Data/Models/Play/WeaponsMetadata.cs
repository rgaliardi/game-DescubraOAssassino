﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Services.Data.Models
{
    [MetadataType(typeof(WeaponsMetadata))]
    public partial class Weapons
    {
        internal sealed class WeaponsMetadata
        {
            [Key]
            [Display(Name = "Código", Order = 1)]
            [Required(ErrorMessage = "Campo {0} é obrigatório")]
            public int Code { get; set; }
            [Display(Name = "Nome", Order = 2)]
            [Required(ErrorMessage = "Campo {0} é obrigatório")]
            [StringLength(25, ErrorMessage = "Campo deve ter {1} caracteres.", MinimumLength = 2)]
            public string Name { get; set; }
            [Display(Name = "Descrição", Order = 3)]
            public string Description { get; set; }
            [Display(Name = "Ativo", Order = 4)]
            [Required(ErrorMessage = "Campo {0} é obrigatório")]
            public bool Enabled { get; set; }
        }

        /// <summary>
        /// COR_CST Dropdownlist
        /// </summary>
        public class WeaponsDropdown
        {
            [Display(Name = "Código", Order = 1)]
            public int value { get; set; }
            [Display(Name = "Nome", Order = 2)]
            public string text { get; set; }
        }
    }
}