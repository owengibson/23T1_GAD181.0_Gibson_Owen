using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OwenGibson.SimpleLevelLoader
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private int sceneToLoad;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}