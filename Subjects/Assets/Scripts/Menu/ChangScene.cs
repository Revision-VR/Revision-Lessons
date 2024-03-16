using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScene : MonoBehaviour
{

    [SerializeField] private OpenCard _card;
    [SerializeField] private GameObject _openCard;



    public void ChangeScene(string _nameScene)
    {

        //_card.WhenEnabled();s
        //SceneManager.LoadScene(_nameScene);

    }

    public void OpenScene(GameObject obj)
    {
        _openCard.SetActive(true);
        _card.WhenEnabled(obj);
    }

}
