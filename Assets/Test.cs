using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if(mp > 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 30, 50, 70, 90};
        
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; 0 <= i && i < array.Length; i--)
        {
            Debug.Log(array[i]);
        }

        Boss boss = new Boss();
        
        for (int i = 1; i < 12; i++)
        {
            boss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
