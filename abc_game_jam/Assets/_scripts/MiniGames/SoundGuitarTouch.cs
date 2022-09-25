using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundGuitarTouch : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    public float amount = 10f;
    public float restamount = 5f;
    [SerializeField] private MiniGuitarPlayController controller;
    [SerializeField] private Image _image;
    public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        int rangoSprite = Random.Range(1, sprites.Count);
        controller = GameObject.FindGameObjectWithTag("MiniGuitarPlayController").GetComponent<MiniGuitarPlayController>();
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
