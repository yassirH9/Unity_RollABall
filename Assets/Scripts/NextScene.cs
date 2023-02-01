using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class NextScene : MonoBehaviour
{
    public string NextSceneName;
    public int MinimumPointsToWin = 5;
    public GameObject player;
    public TextMeshPro coinCountText;
    private void LateUpdate()
    {
        coinCountText.text = "Coins: " + player.GetComponent<PointsCounter>().coinCount + "/"+MinimumPointsToWin;
        if(player.GetComponent<PointsCounter>().coinCount < MinimumPointsToWin)
        {
            coinCountText.color = Color.red;
        }
        else
        {
            coinCountText.color = Color.green;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && player.GetComponent<PointsCounter>().coinCount >= MinimumPointsToWin)
        {
            Debug.Log("Cargando Escena...");

            SceneManager.LoadScene(NextSceneName, LoadSceneMode.Single);

            //ChangeScene(NextSceneName);
        }
    }
    public void ChangeScene(string sceneName)
    {
        StartCoroutine(LoadSceneAndUnloadPrevious(sceneName));
    }

    private IEnumerator LoadSceneAndUnloadPrevious(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
