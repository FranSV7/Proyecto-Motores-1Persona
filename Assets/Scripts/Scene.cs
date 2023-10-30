using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ActiveScreenDeath()
    {
        gameObject.SetActive(true);
        Time.timeScale = 1;
    }
    public void ActiveScreenWin()
    {
        gameObject.SetActive(true);
        Time.timeScale = 1;
    }
}
