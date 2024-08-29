
using Dumpify;

///这里相当于main函数 
var numbers=new List<int>() { 1,2,3,4,5,6,7,8};
numbers.Dump();
var man = new LiSHuai();

man.Dump();


///函数定义和类定义放在最下面
//这就是顶级语句
//你不再需要main函数
//git在这
class LiSHuai {
    public string name { get; set; } = "李帅";
    public int age { get; set; } = 21;
    public string hubbit { get; set; } = "play game";
    
}