using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public void LoadStore()
    {
        SceneManager.LoadScene("Store");
    }

    public void LoadWalk()
    {
        SceneManager.LoadScene("scMap");
    }

    public void LoadSetRoom()
    {
        SceneManager.LoadScene("SetRoom");
    }

    public void LoadInventory()
    {
        SceneManager.LoadScene("Inventory");
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
}
