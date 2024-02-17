using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Microsoft.VisualBasic;

public class Scripture{
    public int book;
    public KeyValuePair<string, string> referen;
    Random random = new();
    
    private Dictionary<string, string> Bom_references = new(){{"2 Nephi 2:25","Adam fell that men might be; and men are, that they might have joy."},
    {"Moroni 10:21", "And except ye have charity ye can in nowise be saved in the kingdom of God; neither can ye be saved in the kingdom of God if ye have not faith; neither can ye if ye have no hope."},
    {"1 Nephi 20:10", "For, behold, I have refined thee, I have chosen thee in the furnace of affliction."}
    };
    private Dictionary<string, string> Ot_references = new(){
        {"1 Corinthians 10:31","Whether therefore ye eat, or drink, or whatsoever ye do, do all to the glory of God."},
        {"Isaiah 26:3", "Thou wilt keep him in perfect peace, whose mind is stayed on thee: because he trusteth in thee."},
        {"Amos 3:7", "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets."}
    };
    private Dictionary<string, string> Nt_references = new(){
        {"Matthew 6:24", "No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon."},
        {"John 3:5", "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."},
        {"Hebrews 5:4", "And no man taketh this honour unto himself, but he that is called of God, as was Aaron."}
    };

    public KeyValuePair<string, string> PickReference(int book){
        this.book = book;
        int value = random.Next(0,3);
        if (book == 1){
            return Bom_references.ElementAt(value);
        }
        else if(book == 2){
            return Ot_references.ElementAt(value);
        }
        else if(book == 3){
            return Nt_references.ElementAt(value);
        }
        else{
            return referen;
        }  
    }
}