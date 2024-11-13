  Console.WriteLine("Hello, Welcome to matematika!");
  using System;
  class program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(1);
      double angka1 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine(2);
      double angka2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine(pilih operasi (+, -, *, /):);
      char operasi = Console.ReadKey()KeyChar;
      Console.WriteLine();

      double hasil = 0;

      switch (operasi)
      {
        
        case '+':
        hasil = angka1 + angka2;
        break
        case '-':
        hasil = angka1 - angka2;
        break
        case '*':
        hasil = angka1 * angka2;
        break
        case '/':
        if (angka2 !=0)
      }
      else
      {
        Console.WriteLine(Pembagian dengan nol tidak diizinkan.);
        return;
      }
      break;
default:
      Console.WriteLine(operasi tidak dikenali.);
      return;
    }
    Console.WriteLine($Hasil: {hasil});
  }
}