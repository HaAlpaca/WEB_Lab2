using System.ComponentModel.DataAnnotations;

namespace ThucHanh_2.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage = "Tên phải tối thiểu 4 ký tự, tối đa 100 ký tự")]
        [RegularExpression(@"^[a-zA-Z0-9]{4,100}$")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bắt buộc phải có đuôi @gmail.com")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com")]
        public string? Email { get; set; } //Email
        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}:;<>?,.])[a-zA-Z0-9!@#$%^&*()_+{}:;<>?,.]{8,}$")]
        public string? Password { get; set; }//Mật khẩu
        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Required]
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }//Ngày sinh
        [Required]
        [RegularExpression(@"^(10(\.0{1,2})?|[0-9](\.\d{1,2})?)$", ErrorMessage = "Bắt buộc nhập kiểu số thực và miền giá trị từ 0.0 đến 10.0")]
        public double Mark { get; set; } // điểm số

    }
}
