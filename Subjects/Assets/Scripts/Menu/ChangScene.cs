using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScene : MonoBehaviour
{

    [SerializeField] private OpenCard _card;

    public void ChangeScene(string _nameScene)
    {

        //_card.WhenEnabled();
        //SceneManager.LoadScene(_nameScene);

    }

    public void OpenScene(GameObject obj)
    {
        _card.gameObject.SetActive(true);
        _card.WhenEnabled(obj);
    }

}
