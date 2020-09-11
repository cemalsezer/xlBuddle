using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Audio;

public class basketController : MonoBehaviour
{



    public TextMeshProUGUI skor_txt;

    public TextMeshProUGUI skor1_txt;

    //private void Start()
    //{
    //    skor_txt = GameObject.Find("Canvas/skor_txt").GetComponent<TextMeshProUGUI>();
    //}



    public int puan = 0;
    public float can = 100.0f;

    public UnityEngine.UI.Image canBari;
    public GameObject panel;

    public float guncelCan = 100.0f;
    public float hiz;



    public AudioSource ses_dosyasi;
    public AudioClip water_sound;
    public AudioClip fire_sound;
    public AudioClip eBottle;
    public AudioClip fBottle;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "water")
        {
            puan += 5;
            Destroy(collision.gameObject);
            //Debug.Log(puan);
            skor_txt.text = puan.ToString();
            skor1_txt.text = puan.ToString();
            GetComponent<AudioSource>().PlayOneShot(water_sound);



        }




        else if (collision.gameObject.tag == "fire")
        {
            // Debug.Log("ateş değdi");
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(fire_sound);
            guncelCan -= 5;
            canBari.fillAmount = guncelCan / can;



            if (guncelCan <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0.0f;
            }

        }
        else if (collision.gameObject.tag == "eBottle")
        {

            Destroy(collision.gameObject);
            guncelCan -= 5;
            canBari.fillAmount = guncelCan / can;
            GetComponent<AudioSource>().PlayOneShot(eBottle);



            if (guncelCan <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0.0f;
            }

        }
        else if (collision.gameObject.tag == "fBottle")
        {
            Destroy(collision.gameObject);
            puan += 5;
            skor_txt.text = puan.ToString();
            skor1_txt.text = puan.ToString();
            GetComponent<AudioSource>().PlayOneShot(fBottle);

        }
    }








    //else if(puan>=100)
    //{

    //}












    void Update()
    {



        if (Input.GetKey(KeyCode.RightArrow))

        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);

        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);

        }



    }

}