using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

   



    int saniye = 10;
    public GameObject water;
    public GameObject fire;

    float zaman_araligi = 0.5f;
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
        Time.timeScale = 1f;
        //InvokeRepeating("water_add", 0.0f, 1.0f);
    }


    void water_add()

    {
        float rast = Random.Range(-2.3f, 2.30f);
        GameObject new_water = Instantiate(water, new Vector3(rast, 6, -1), Quaternion.identity);
    }
    void fire_add()
    {
        float rast = Random.Range(2.1f, 2.30f);
        GameObject new_fire = Instantiate(fire, new Vector3(rast, 6, -1), Quaternion.identity);
    }

    

    

        void Update()
        {


            if (Time.time >= kalan_zaman)
            {
                water_add();
                fire_add();

                kalan_zaman = zaman_araligi + Time.time;
            }



            /* Debug.Log(Time.time);
             Time.timeScale = 0.7f;*/
        }
    }

