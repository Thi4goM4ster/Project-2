using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LevelName;
    
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player"){
            SceneManager.LoadScene(LevelName);
        }
    }
}
