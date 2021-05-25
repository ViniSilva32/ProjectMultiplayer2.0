using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float velocidade;
    public float girar;
    private Animator anim;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 20.0f;
        girar = 60.0f;
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Pulo();//
        
    }

    void Move()
    {
        float translate = (Input.GetAxis("Vertical") * velocidade) * Time.deltaTime;
        float rotate = (Input.GetAxis("Horizontal") * girar) * Time.deltaTime;

        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);

        
    }
     void Pulo()
    {
        
    }
}
