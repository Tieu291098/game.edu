using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    public void PlayGameButton()
    {
        Application.LoadLevel ("PlanesShoot");
    }
    public void QuitGameButton()
    {
        Application.Quit();
    }


}
