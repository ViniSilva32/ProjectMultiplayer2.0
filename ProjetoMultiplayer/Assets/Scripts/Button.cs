using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        ButtonColor = InteractiveButton.GetComponent<Renderer>().material.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Clicavel)
        {
            print("colidiu");
            print(ButtonColor);
            if (Input.GetKey(KeyCode.Q))
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

        switch (ButtonColor)
        {
            case "Yellow Button (Instance)":
                Portas[0].SetActive(false);
                break;
            case "Green Button (Instance)":
                Portas[1].SetActive(false);
                break;
            case "Red Button (Instance)":
                Portas[2].SetActive(false);
                break;
            case "Brown Button (Instance)":
                Portas[3].SetActive(false);
                break;
            case "Orange Button (Instance)":
                Portas[4].SetActive(false);
                break;
            case "Pink Button (Instance)":
                Portas[5].SetActive(false);
                break;
            case "Blue Button (Instance)":
                Portas[6].SetActive(false);
                break;

        }
    } 


}
