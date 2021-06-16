namespace Classes.Metodos {

    public class Ref {
        
        static void Inverter(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter() {
            int i = 1, j = 2;
            inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}"); //Escreve "2 1"
        }
    }
}