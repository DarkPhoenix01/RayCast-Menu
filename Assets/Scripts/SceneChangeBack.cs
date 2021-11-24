using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeBack : MonoBehaviour
{

    
    public void GoBack()
    {
        SceneManager.LoadScene("SceneMenu");
    }
}
