using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zemin : MonoBehaviour
{
     float can = 100.0f;
    float guncelCan = 100.0f;

    public Image canBari;
    public GameObject panel;




    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "water")
        {

            //float rast = Random.Range(-2.3f, 2.30f);


            Destroy(collision.gameObject);

            //guncelCan -= 10;
            //canBari.fillAmount = guncelCan / can;

            //if (guncelCan <= 0)
            //{
            //    panel.SetActive(true);
            //    Time.timeScale = 0.0f;
            //}


            //float rast = Random.Range(-2.3f, 2.30f);

            //collision.gameObject.transform.position = new Vector3(rast, 6, -1);
        }



       else if (collision.gameObject.tag == "fire")
        {

            Destroy(collision.gameObject);
            //guncelCan -= 10;
            //canBari.fillAmount = guncelCan / can;

            //if (guncelCan <= 0)
            //{
            //    panel.SetActive(true);
            //    Time.timeScale = 0.0f;
            //}

            //float ras = Random.Range(-2.2f, 2.10f);

            //collision.gameObject.transform.position = new Vector3(ras, 6, -1);







        }
    }
}
