namespace Buoi3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ID không được bỏ trống")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được bỏ trống")]
        [StringLength(100,ErrorMessage ="Tiêu đề không được quá 100 kí tự")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tên không được bỏ trống")]
        [StringLength(30, ErrorMessage ="Tên không được quá 30 kí tự")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được bỏ trống")]
        [StringLength(255)]
        public string Images { get; set; }

        [Required(ErrorMessage = "Giá không được bỏ trống")]
        [Range (1000,1000000,ErrorMessage ="Giá sách từ 1000-1000000")]
        public int? Price { get; set; }
    }
}
