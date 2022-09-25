using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public int scene = 1;
    public float seconds = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SplashScreenCour(scene, seconds));
    }

    IEnumerator SplashScreenCour(int n,float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneController.Instance.CambioEscena(n);
    }

}