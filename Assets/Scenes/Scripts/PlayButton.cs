using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public Color newColor;
    public Color oldColor;
    private SpriteRenderer rend;
    void OnMouseDown()
    {
        SceneManager.LoadScene("Game");
    }
    void OnMouseOver()
    {
        rend = GetComponent<SpriteRenderer>();
        //rend.transform.localScale = new Vector3(2.6f, 1.2f, 1.2f);
        rend.color = newColor;
    }
    void OnMouseExit()
    {
        rend.color = oldColor;
    }


}
