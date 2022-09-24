using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGuitarTouch : MonoBehaviour
{
    public float amount = 10f;
    public float restamount = 5f;
    [SerializeField] private MiniGuitarPlayController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("MiniGuitarPlayController").GetComponent<MiniGuitarPlayController>();
        
        StartCoroutine(WaitDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TouchButtonSound()
    {
        controller.image.fillAmount += (amount/100);
        Destroy(this.gameObject);
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(0.85f);
        controller.image.fillAmount -= (restamount / 100);
        Destroy(this.gameObject);
    }
}
