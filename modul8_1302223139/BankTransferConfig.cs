using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
namespace modul8_1302223139
{
    internal class BankTransferConfig
    {
        public string Bahasa { set; get; }
        public detail_transfer Transfer { set; get; }
        public string Methods { set; get; }
        public detail_confirmation Confirm { set; get; }
        public int total;
        public string jml_uang;

        public void bahasa()
        {
            if (Bahasa == "en")
            {
                Console.WriteLine("Please insert the amoun of money to transfer: ");
            }
            else if (Bahasa == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan ditransfer: ");
            }
            string jml_uang = Console.ReadLine();
            total = int.Parse(jml_uang);
        }

        public int Total(int total)
        {

            if (total <= Transfer.transfer_threshold)
            {
                total += Transfer.transfer_low_fee;
                if (Bahasa == "en")
                {
                    Console.WriteLine("Total Fee = " + Transfer.transfer_low_fee);
                    Console.Write("Total Amount = ");
                }
                else if (Bahasa == "id")
                {
                    Console.WriteLine("Biaya Transfer = " + Transfer.transfer_low_fee);
                    Console.Write("Total Biaya = ");
                }

            }
            else if (total >= Transfer.transfer_threshold)
            {
                total += Transfer.transfer_high_fee;
                if (Bahasa == "en")
                {
                    Console.WriteLine("Total Fee = " + Transfer.transfer_high_fee);
                    Console.Write("Total Amount = ");
                }
                else if (Bahasa == "id")
                {
                    Console.WriteLine("Biaya Transfer = " + Transfer.transfer_high_fee);
                    Console.Write("Total Biaya = ");
                }
            }
            return total;
        }


    }
}

internal class detail_transfer
{
    public int transfer_threshold = 25000000;
    public int transfer_low_fee = 6500;
    public int transfer_high_fee = 15000;
}

internal class detail_confirmation
{
    public string confirm_en = "yes";
    public string confirm_id = "ya";
}
