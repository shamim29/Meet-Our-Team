using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UserPreviewController : MonoBehaviour
{
    public static UserPreviewController instance;

    public Image Thumnail;
    public TextMeshProUGUI UserName;
    public TextMeshProUGUI UserDesignation;


    public void Awake()
    {
        instance = this;
    }

    public void ShowUser(User user)
    {
        Thumnail.sprite = user.UserThamnail;
        UserName.text = user.UserName;
        UserDesignation.text = user.UserDesignation; 
    }
}
