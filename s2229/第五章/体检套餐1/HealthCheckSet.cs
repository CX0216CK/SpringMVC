using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检套餐1
{
  public  class HealthCheckSet
    {

      List<HealthCheckItem> list;

      //套餐的价格
      private double price;
      public double Price
      {
          get { return price; }
          set { price = value; }
      }
      //套餐名称
      private string name;
      public string Name
      {
          get { return name; }
          set { name = value; }
      }
      //保存所有的
   public   List<HealthCheckItem> all = new List<HealthCheckItem>();
      //保存体检套餐的
   private List<HealthCheckItem> tems = new List<HealthCheckItem>();

   public List<HealthCheckItem> Items
   {
       get { return tems; }
       set { tems = value; }
   }

      public void CarlPrice() {
          double po = 0;
          foreach (HealthCheckItem item in this.Items)
          {
              po += item.Price;
          }
          this.Price = po;
      
      
      
      }
    }
}
