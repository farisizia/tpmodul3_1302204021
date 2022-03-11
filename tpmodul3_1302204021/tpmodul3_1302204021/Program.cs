namespace tpmodul3_1302204021
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos table_Kodepos = new KodePos();
            System.Console.WriteLine("Keluarahan       Kode Pos");
            table_Kodepos.getKodePos();
        }

    }
    class KodePos
    {

        System.Collections.Generic.Dictionary<string, string> dic = new System.Collections.Generic.Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "        40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "        40274"},
            {"Samoja", "        40273"}
        };

        public void getKodePos()
        {
            foreach (System.Collections.Generic.KeyValuePair<string, string> ele1 in dic)
            {
                System.Console.WriteLine("{0} \t {1}", ele1.Key, ele1.Value);
            }
        }
    }
}