using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    [SerializeField] private GameObject _panel;

    public void GoToScene()
    {
        Time.timeScale = 1;
        _panel.SetActive(true);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(_sceneName);
    }
}
