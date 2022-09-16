using System;
    public class Program {
        public static void Main(string[] args){
string[] U_name = new string[5] {"Chulalongkorn University","Mahidol University","King Mongkut's Institute of Technology Ladkrabang","Khonkaen University","King Mongkut's University of Technology Thonburi "};
        string[] U_Library = new string[5]{"Rakdee","Raklok","Gaygey","Wattana","Athorn"};
        string[] U_Address = new string[5]{"Pathumwan,Bangkok","Salaya,Nakhornpathom","LardKrabang,Bangkok","Nai Mueng,Khonkaen","Thoongkru,Bangkok"};
int[] U_Tel = new int[5]{02-215-3555,02-849-6211,02-329-8000,043-002539,02-470-8000};
string[] UA_name = new string[5]{"Chaidee","Nondee","Apaidee","Thamdee","Nondee"};
string[] UA_surname = new string[5]{"Rakdee","Jaidee","Riandee","Ngandee","Riabdee"};
int[] ID_Card = new int[5]{153-698-4561237,742-112-5687412,541-772-3215689,777-772-4578923,003-852-4752000};
double[] FT = new double[5]{79.6,70.7,249,30.2,208.9};
double[] FT_Cost = new double[5]{7911,7725,25172,4369,21470};
 string menu;
 Console.WriteLine("Welcome Please input a,b,c to Select Menu");
 menu = Console.ReadLine();
if (menu == "a"){
    for(int i = 0; i < 5;i++){
        Console.WriteLine("--------------------");
        Console.WriteLine(U_name[i]);
        Console.WriteLine(U_Library[i]);
        Console.WriteLine(U_Address[i]);
        Console.WriteLine(U_Tel[i]);
        Console.WriteLine("--------------------");
    }
}
else if (menu == "b"){
     for(int i = 0; i < 5;i++){
        Console.WriteLine("--------------------");
        Console.WriteLine(U_name[i]);
        Console.WriteLine(UA_name[i]);
        Console.WriteLine(UA_surname[i]);
        Console.WriteLine(ID_Card[i]);
        Console.WriteLine("--------------------");
    
}

        }
else if (menu == "c"){
    for (int i = 0; i < 5;i++){
        if(i == 1){
            if(FT[1] > FT[2]){
                
            }
        }
    }
}
        }
    }
    
