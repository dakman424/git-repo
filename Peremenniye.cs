using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*Этот класс задает  начальные переменные,отображает картинки  на сцене и задает фуункции управдения кнопками */
public class Peremenniye : MonoBehaviour
{

    public GameObject[] picther = new GameObject[5];
    public GameObject panel_ok;//Панель отображается при удачной покупке
    public GameObject panel_no;// Панель отображается если у вас недостаточно денег
    public GameObject panel_temn;//Панель затемнения
    public GameObject panel_Uzhe_kupleno;

    public bool[] picther_Buy = new bool[5];// Если true то объект куплен,если false то нет.

    public int[] money_build = {200, 300, 400, 500, 600};
           int money = 200; 
           string[] description = {"it is first", "it is second", "it is third", "it is fourth", "it is fifth" };// Краткое описание объекта который собираются купить
    public Text description_T;
    public Text moneyText;


    public int schetchik_M_I = 0;

    private void Start()
    {
      picther[0].SetActive(true);
        for (int i = 0; i < 5; i++)
        {
            picther_Buy[i] = false;
        }
        description_T.text = description[0];
        moneyText.text = money.ToString();
    }

    private void Update()
    {
        if (picther_Buy[schetchik_M_I] == true)
            panel_temn.SetActive(true);

        else if (picther_Buy[schetchik_M_I] == false)
            panel_temn.SetActive(false);
    }

    //Отображает одну картинку и скрвыает другую,подрузомевая перелистывание вправо.
    public void NextImage()
    {
    
        ++schetchik_M_I;
        if(schetchik_M_I > 4)
        {
            schetchik_M_I = 0;
        }
        switch (schetchik_M_I) {
            case 0 :
                for(int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                    
                }
                picther[0].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 1:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[1].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 2:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[2].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 3:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[3].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 4:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[4].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;

        }
            

    }
    //Отображает одну картинку и скрвыает другую,подрузомевая перелистывание влево.
    public void prewieImage()
    {
        --schetchik_M_I;
        if (schetchik_M_I < 0)
        {
            schetchik_M_I = 4;
        }
        switch (schetchik_M_I)
        {
            case 0:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[0].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 1:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[1].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 2:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[2].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 3:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[3].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;
            case 4:
                for (int i = 0; i < 5; i++)
                {
                    picther[i].SetActive(false);
                }
                picther[4].SetActive(true);
                description_T.text = description[schetchik_M_I];
                break;

        }

    }
    // Если достаточно денег покупает постройки если нет выводит ошибку
    public void buy_b()
    {
        if (money <= 0 && picther_Buy[schetchik_M_I] == true)
        {

            panel_Uzhe_kupleno.SetActive(true);
        }
        else if (money <= 0 && picther_Buy[schetchik_M_I] == false)
        {
            money = 0;
            panel_no.SetActive(true);
            moneyText.text = money.ToString();
        }


        if (money < money_build[schetchik_M_I] && picther_Buy[schetchik_M_I] == true)
        {
            panel_Uzhe_kupleno.SetActive(true);
        }

        else if (money < money_build[schetchik_M_I] && picther_Buy[schetchik_M_I] == false)
        {
            if (picther_Buy[schetchik_M_I] == true)
                panel_Uzhe_kupleno.SetActive(true);
            panel_no.SetActive(true);
            moneyText.text = money.ToString();
        }
        
         if (money >= money_build[schetchik_M_I])
        {
            if (picther_Buy[schetchik_M_I] == true)
                panel_Uzhe_kupleno.SetActive(true);
            money -= money_build[schetchik_M_I];
            panel_ok.SetActive(true);
            picther_Buy[schetchik_M_I] = true;
            moneyText.text = money.ToString();

        }
        
         

        



    }

public void close_panel_Ok()
    {
        panel_ok.SetActive(false);
    }

    public void close_panel_off()
    {
        panel_no.SetActive(false);
    }

    public void close_Uzhe_kupil()
    {
        panel_Uzhe_kupleno.SetActive(false);
    }
}




    


