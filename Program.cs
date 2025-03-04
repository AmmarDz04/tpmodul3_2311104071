using tpmodul3_2311104071;

class Program

{

  static void Main(string[] args)

  {

    KodePos kodePos = new KodePos();

    Console.WriteLine(kodePos.getKodePos("Batumunggal")); // Output: 40266


            // Contoh penggunaan KodePos
            KodePos KodePos = new KodePos();
            Console.WriteLine("Kode Pos Batumunggal: " + kodePos.getKodePos("Batumunggal")); // Output: 40266

            // Contoh penggunaan DoorMachine
            DoorMachine door = new DoorMachine();
            door.BukaPintu(); // Output: Pintu tidak terkunci
            door.KunciPintu(); // Output: Pintu terkunci


}

}
