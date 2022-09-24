using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGuitarPlayController : MonoBehaviour
{

    public GameObject button;
    public float valueX;
    public float valueY;
    public float timer = 60f;
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaveController());
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    void CrearObjeto()
    {
        float newRandomX = Random.Range(-valueX, valueX);
        float newRandomY = Random.Range(-valueY, valueY);
        Vector3 randomPost = new Vector3(newRandomX, newRandomY, 0f);
        GameObject newButton = Instantiate(button, randomPost, transform.rotation) as GameObject;
        newButton.transform.SetParent(GameObject.FindGameObjectWithTag("MiniGuitarPlayController").transform, false);
    }

    IEnumerator WaveController()
    {
        while (timer > 0)
        {
            CrearObjeto();
            yield return new WaitForSeconds(1f);
        }
    } 

    public Vector3 RandomPosition()
    {
        Vector3  newTransform = new Vector3(0f,0f,0f);
        return newTransform;
    }

}
