using ServerToAngular.Models;

namespace ServerToAngular
{
    public class Data
    {
        public static List<Donor> donors = new List<Donor>
        {
            new Donor(1,"aaa","aaaaaaaaaa") ,
            new Donor(2,"bbb","bbbbbbbbbb"),
            new Donor(3,"ccc","cccccccccc"),
            new Donor(4,"ddd","dddddddddd")
        };
        public static List<Gift> gifts = new List<Gift>
        {
            new Gift(1,"camera",donors[0],30,"1.png","biggg") ,
            new Gift(2,"car",donors[1],40,"2.png","fastttt"),
            new Gift(3,"house",donors[2],50,"3.png","gggg"),
            new Gift(4,"gift",donors[3],60,"4.png","jgdkj")
        };
    }
}
