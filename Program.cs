using System.Text.Json;

NhanVien nv = new NhanVien();

Console.WriteLine($@"Nhân viên: {JsonSerializer.Serialize(nv)}");

SanPham sp = new SanPham();

Console.WriteLine($@"Sản phẩm: {JsonSerializer.Serialize(sp)}");


Console.WriteLine($@"abc");


Console.WriteLine($@"Dev A develop");
Console.WriteLine($@"Dev B develop");
