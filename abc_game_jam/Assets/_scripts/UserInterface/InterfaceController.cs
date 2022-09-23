using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    public Canvas canvasMain;
    [SerializeField] Animator panelSelected;
    public List<GameObject> paneles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ClickInPanel(int i)
    {
        panelSelected = paneles[i].gameObject.GetComponent<Animator>();
        panelSelected.SetBool("abierto", true);
    }


}
