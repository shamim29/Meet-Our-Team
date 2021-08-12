using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UserPreviewController : MonoBehaviour
{
    public static UserPreviewController instance;

    public TextMeshProUGUI UserExperience;
    public TextMeshProUGUI UserName;
    public TextMeshProUGUI UserDesignation;
    public Image UserProfile;

    public Image[] UserSocialIcons;

    public TextMeshProUGUI UserQuotes;

    public Image[] UserTechIcons;


    public void Awake()
    {
        instance = this;
    }

    public void ShowUser(User user)
    {
        UserExperience.text = user.UserExperience;
        UserName.text = user.UserName;
        UserDesignation.text = user.UserDesignation;
        UserProfile.sprite = user.UserProfile;

        int i = 0;

        foreach(var socialLink in user.SocilaLinks)
        {
            UserSocialIcons[i].sprite = IconController.instance.GetIcon(socialLink.Key);
            UserSocialIcons[i].GetComponent<Button>().onClick.RemoveAllListeners();
            UserSocialIcons[i].GetComponent<Button>().onClick.AddListener(() => OpenURL(socialLink.Value));
            i++;
        }

        int j = 0;

        foreach(var technology in user.Technologies)
        {
            UserTechIcons[j].sprite = IconController.instance.GetIcon(technology);

            j++;
        }

        UserQuotes.text = user.UserQuotes;
    }

    private void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

}
