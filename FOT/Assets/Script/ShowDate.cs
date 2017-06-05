using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ShowDate : MonoBehaviour
{

    public Text[] dateText;
    bool isLeapYear;
    int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    public int d, i;
    public int year, month, day;
    // public int count;


    // Use this for initialization
    void Start()
    {

        dateText = gameObject.GetComponentsInChildren<Text>();


        DateTime Now = DateTime.Now;
        year = Now.Year;
        month = Now.Date.Month;
        day = Now.Date.Day;

        //計算是一年中第幾天
        d = 1;
        for (i = 0; i < month - 1; i++)
        {
            d = d + days[i];
        }
        //據公式計算是星期幾
        year--;
        d = d + year + (year / 4) - (year / 100) + (year / 400);
        d += 1;
        d = d % 7;


        //判斷閏年
        if (year % 400 == 0 || ((year % 4 == 0) && (year % 100 != 0)))
        {
            isLeapYear = true;
        }
        else
        {
            isLeapYear = false;
        }
        //處理空格
        for (int l = 0; l <= d ; l++)
        {
            dateText[l].text = null;
        }

        //處理日期
        for (int j = 0, count = d; j < days[month - 1]; j++, count++)
        {
            dateText[count].text += (int)(j + 1);
            if (j + 1 == day)
            {
                dateText[count].color = Color.red;
            }

        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}
