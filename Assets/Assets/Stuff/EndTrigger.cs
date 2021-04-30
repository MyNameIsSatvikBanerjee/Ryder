using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public GameObject completeLevelUI;

    void OnTriggerEnter()
    {
        completeLevelUI.SetActive(true);
    }
}
