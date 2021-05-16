using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    GameObject anaKup;
    int yukseklik;

    void Start()
    {
        anaKup = GameObject.Find("AnaCube");
    }

    // Update is called once per frame
    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void YukseklikAzalt()
    {
        yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla" && other.gameObject.GetComponent<Collectible>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<Collectible>().ToplandiYap();
            other.gameObject.GetComponent<Collectible>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKup.transform;
        }
    }
}
