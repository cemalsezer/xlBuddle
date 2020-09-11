

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{



    private basketController bsc;

    //int saniye = 10;
    public GameObject water;
    public GameObject fire;
    public GameObject emptyBottle;
    public GameObject fullBottle;
    public GameObject acma;
    public int x2;
   

    float zaman_araligi = 0.7f;
    float kalan_zaman = 1f;

    bool oyunKontrol = false;

    public void yenidenOyna()
    {
        SceneManager.LoadScene("Scenes/xlBuddle");
    }




    public void pauseButton()
    {
        oyunKontrol = !oyunKontrol;

        if (oyunKontrol == true)
        {
            Time.timeScale = 0.0f;

        }
        else
        {
            Time.timeScale = 1.0f;
        }


    }




    void Start()
    {

        bsc = acma.GetComponent<basketController>();
        x2 = bsc.puan;

        Time.timeScale = 0.8f;
        //InvokeRepeating("water_add", 0.0f, 1.0f);
    }


    void water_add()

    {
        float rast = Random.Range(-2.32f, 2.30f);
        float yrast = Random.Range(6.0f, 8.0f);
        GameObject new_water = Instantiate(water, new Vector3(rast, yrast, -1), Quaternion.identity);
      
    }
    void fire_add()
    {
        float rast2 = Random.Range(-2.0f, 2.30f);
        float yrast2 = Random.Range(6.0f, 9.30f);
        GameObject new_fire = Instantiate(fire, new Vector3(rast2, yrast2, -1), Quaternion.identity);
    }



    void emptyBottle_add()

    {
        //bsc = emptyBottle.GetComponent<basketController>();

        float rast3 = Random.Range(-1.8f, 2.31f);
        float yrast3 = Random.Range(6.0f, 8.20f);
        GameObject new_eBottle = Instantiate(emptyBottle, new Vector3(rast3, yrast3, -1), Quaternion.identity);
    }

    void fullBottle_add()

    {


        float rast4 = Random.Range(-1.95f, 2.32f);
        float yrast4 = Random.Range(6.0f, 8.60f);
        GameObject new_fBottle = Instantiate(fullBottle, new Vector3(rast4, yrast4, -1), Quaternion.identity);
    }



    void Update()
    {

    
       

        //int x = bsc.puan;
        if (Time.time >= kalan_zaman)
        {
            water_add();
            fire_add();
            
            x2 = bsc.puan;
          //  Debug.Log(x2);

            kalan_zaman = zaman_araligi + Time.time;

            if(x2>=20)
            {
                  emptyBottle_add();
                  fullBottle_add();

            }

            /* Debug.Log(Time.time);
             Time.timeScale = 0.7f;*/
        }

       
     





    } 
}

