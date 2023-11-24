﻿using System.ComponentModel.DataAnnotations;

namespace bdExercicio.Models
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }
        public int IdCliente { get; set; }
        public int IdMaquina { get; set; }
        public string Valor {  get; set; }
        public int Quantidade { get; set; }
    }
}
