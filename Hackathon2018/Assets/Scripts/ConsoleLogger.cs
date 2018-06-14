using UnityEngine;

public class ConsoleLogger: MonoBehaviour
{
   private void Start()
   {
      int a = 2;
      int b = 3;
      int c = 4;
      int d = 1;
      
      int i = CombineTwo(3,4);
      Debug.Log(i);
      int o = SubtractOne(6,3);
      Debug.Log(o);
      int q = CombineTwo(a,b);
      int s = CombineTwo(c,d);
      int m = SubtractOne(q,s);
      Debug.Log(m);
   }

   private int SubtractOne(int num1, int num2)
   {
      int p = num1 - num2;
      return p;
   }   
   
   private int CombineTwo(int num1, int num2)
   {
      int w = num1 + num2;
      return w;
   }
}
