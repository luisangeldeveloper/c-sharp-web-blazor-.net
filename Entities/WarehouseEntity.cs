﻿using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class WarehouseEntity
	{
		[Key] // Llave primaria
		[StringLength(50)]
		public string WarehouseId { get; set; }

		[Required]
		[StringLength(100)]
		public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }


		// Relación con almacenamiento (StorageEntity)
		public ICollection<StorageEntity> Storages { get; set; }
	}
}
