using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Vector3 positionToMoveTo;

    float startValue = 0;
    float endValue = 10;
    float valueToLerp;


    public GameObject Red;
    public GameObject Pink;
    public GameObject Blue;
    public GameObject Green;
    public GameObject Yellow;
    public GameObject Brown;



    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RedButton()
    {
        positionToMoveTo = new Vector3 (Red.transform.position.x, Red.transform.position.y + 10f, Red.transform.position.z);
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
    }

    public void PinkButton()
    {

    }

    public void BlueButton()
    {

    }

    public void GreenButton()
    {

    }

    public void YellowButton()
    {

    }

    public void BrownButton()
    {

    }



    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
