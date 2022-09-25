using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGuitarTouch : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    public float amount = 10f;
    public float restamount = 5f;
    [SerializeField] private MiniGuitarPlayController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("MiniGuitarPlayController").GetComponent<MiniGuitarPlayController>();
<<<<<<< HEAD
        _image = this.gameObject.GetComponent<Image>();
        _image.sprite = sprites[rangoSprite];
        _image.SetNativeSize();
=======
    

    // Start is called before the first frame update
    void Start()
    {
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
=======
    

    // Start is called before the first frame update
    void Start()
    {
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
=======
        
>>>>>>> parent of e1ef9d3a (Merge pull request #5 from NagroAfic/c2_jsaldana)
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
