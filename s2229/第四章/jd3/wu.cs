using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
    class wu
    {
        public wu(string name,int HP) {
            this.HP = HP;
            this.name = name;
        
        }
        public void show() {
            Console.WriteLine("名字是{0},生命值{1}",name,HP);
        
        
        }
        public wu(string name,int HP,int ji,int zahn){
        this.name=name;
            this.HP=HP;
            this.ji=ji;
            this.zahn=zahn;
        
        }
        public void show1()
        {
            Console.WriteLine("名字是{0},生命值{1},等级{2},战斗力{3}", name, HP,ji,zahn);


        }
        public string name;
        public int HP;
        public int ji;
        public int zahn;
        
    }
}
