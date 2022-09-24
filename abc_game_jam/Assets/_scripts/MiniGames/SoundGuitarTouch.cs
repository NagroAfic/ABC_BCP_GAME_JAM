using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGuitarTouch : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TouchButtonSound()
    {
        Destroy(this.gameObject);
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
