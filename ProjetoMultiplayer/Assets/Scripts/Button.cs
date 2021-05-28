﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Button : MonoBehaviour
{
    //public GameObject Porta;
    public GameObject InteractiveButton;
    string ButtonColor;
    public GameObject[] Portas = new GameObject[7];
    bool Clicavel = false;

    // Start is called before the first frame update
    void Start()
    {
       // ButtonColor = InteractiveButton.GetComponent<Renderer>().material.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Clicavel)
        {
            print("colidiu");
            print(ButtonColor);
            if (Input.GetMouseButtonDown(0))
            {
                print("clicou");
                Click();
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.CompareTag("Player"))
        {
            Clicavel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Clicavel = false;
    }

    public void Click()
    {
        //Porta.SetActive(false);

        switch (this.tag)
        {
            case "Yellow":
                //Portas[0].SetActive(false);
                Destroy(Portas[0].gameObject);
                break;
            case "Green":
                //Portas[1].SetActive(false);
                Destroy(Portas[1].gameObject);
                break;
            case "Red":
                //Portas[2].SetActive(false);
                Destroy(Portas[2].gameObject);
                break;
            case "Brown":
                //Portas[3].SetActive(false);
                Destroy(Portas[3].gameObject);
                break;
            case "Orange":
                //Portas[4].SetActive(false);
                Destroy(Portas[4].gameObject);
                break;
            case "Pink":
                //Portas[5].SetActive(false);
                Destroy(Portas[5].gameObject);
                break;
            case "Blue":
                //Portas[6].SetActive(false);
                Destroy(Portas[6].gameObject);
                break;

        }
    } 


}
