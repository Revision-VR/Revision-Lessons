using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScene : MonoBehaviour
{
    
    public void ChangeScene(string _nameScene)
    {
        
        SceneManager.LoadScene(_nameScene);

    }

}
