using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //restart the space spader scceme
    public void Reset()
    {
        SceneManager.LoadScene("SpaceInvaders");
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Restart button is working");
    }
}
