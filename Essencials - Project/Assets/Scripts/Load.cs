using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public string cena;

    public void OnBtn()
    {
        SceneManager.LoadScene(cena);
    }
}
