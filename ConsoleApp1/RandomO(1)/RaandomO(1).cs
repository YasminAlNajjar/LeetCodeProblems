using System;
using System.Collections.Generic;
public class RandomizedSet {
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    List<int> list=new List<int>();

    public bool Insert(int val) 
    {
        if(dictionary.ContainsKey(val))
           return false;

        dictionary.Add(val,val);
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) 
    {
        if(!dictionary.ContainsKey(val))
           return false;

        dictionary.Remove(val);
        // int temp=
        // list[list.Count-1]=list[list.IndexOf(val)];
        list.Remove(val);
        return true;
    }
    
    public int GetRandom() 
    {
        Random random = new Random();
        // if(dictionary!=null)
        // {
            // foreach(int num in dictionary.Keys)
            //     list.Add(num);                      
        // }

        return list[random.Next(list.Count)];
    }
}

