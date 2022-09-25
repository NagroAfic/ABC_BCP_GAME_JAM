using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGuitarPlayController : MonoBehaviour
{

    public GameObject button;
    public float valueX;
    public float valueY;
    public float timer = 60f;
    
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
=======
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)


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
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
        }
<<<<<<< HEAD
        else
        {
            finalCanvas.SetActive(true);
            if (image.fillAmount > 0.75f)
            {
                LlenarText("Tocas Genial",50,30,30);
            }
            else if(image.fillAmount <= 0.75f && image.fillAmount > 0.35f)
            {
                LlenarText("Puedes hacerlo mejor", 25, 30, 30);
            }
            else
            {
                LlenarText("¡BUHH! ", 0, 30, 30);
            }
=======
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
        }
=======
>>>>>>> parent of e1ef9d3a (Merge pull request #5 from NagroAfic/c2_jsaldana)
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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public void LlenarText(string d, int m, int s,int c)
    {
        descripcion.text=d;
        dinero.text=m.ToString();
        salud.text="-"+s.ToString();
        comida.text="-"+c.ToString();
    }

    public void RestartGame(int n)
    {
        SceneController.Instance.CambioEscena(n);
    }
=======
    
>>>>>>> parent of e1ef9d3a (Merge pull request #5 from NagroAfic/c2_jsaldana)

=======
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
=======
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
=======
>>>>>>> parent of a35d05f8 (Merge branch 'main' into c1_botones_marimon_branch)
}
